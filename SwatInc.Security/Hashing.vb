Imports System.Text
Imports System.Security.Cryptography

Public Class Hashing

    Private Const DELIMITER As String = ":"

    Const HASH_ALGORITHM_INDEX As Integer = 0

    Const HASH_INDEX As Integer = 3

    'These constants define the encoding and may not be changed.
    Const HASH_SECTIONS As Integer = 4

    Const HASH_SIZE_INDEX As Integer = 1

    'These constants may be changed without breaking existing hashes.
    Const SALT_BYTES As Integer = 24    'setting the size of the arrays

    Const SALT_INDEX As Integer = 2

    Public Shared Function SwatIncSecurityCreateHashSHA512(ByVal PasswordString As String) As String

        'TO STORE A PASSWORD

        ' 1) Generate a long random salt using a CSPRNG(Cryptographically Secure Pseudo-Random Number Generator).
        '.NET does this using System.Security.Cryptography.RNGCryptoServiceProvider
        Dim authenticationHash As String
        Dim Salt(SALT_BYTES) As Byte
        Dim SaltString As String

        Try
            Using csprng As New RNGCryptoServiceProvider()
                'generates a cryptographically secure salt consisting of an array of bytes having the amount of bytes specified by the constant SALT_BYTES
                csprng.GetBytes(Salt)
                SaltString = Convert.ToBase64String(Salt)
            End Using

            'MsgBox(SaltString)
        Catch ex As CryptographicException
            Throw New CryptographicException("Random number generator not available.")
            Exit Function
        Catch ex As ArgumentNullException
            Throw New ArgumentNullException("Invalid argument given to random number generator.")
            Exit Function
        End Try

        ' 2) Prepend the salt to the password and hash it with a standard cryptographic hash function such as SHA256.
        'if "aaaa" is the salt(generated using CSPRNG) and "bbbb" is the password. The String to be Hashed would be "aaaabbbb"
        '"aaaabbbb" would then be UTF8 encoded and assigned to an array as a collection of bytes using something like below.

        'Dim SaltPasswordString As String  = aaaabbbb
        'Dim SaltPasswordByteArray() As Byte = Encoding.UTF8.GetBytes(SaltPasswordString)

        Dim saltStringNPasswordString As String = SaltString & PasswordString  'Combinig SaltString and PasswordString
        Dim saltedPasswordByteArray() As Byte = Encoding.UTF8.GetBytes(saltStringNPasswordString) 'This step converts the combination of SaltString and PasswordString given to the funtion into a collection of bytes.
        Dim saltedSha512PasswordHash() As Byte 'Declaring the array to hold salted and hashed password as an array of bytes prior to conversion to base64string.

        ' 3) Save both the salt and the hash in the user's database record.

        'hash would be stored as
        'algorithm:HashByteSize:salt:hash
        'SHA512:88:aaaa:tn+Zr/xo99LI+kSwLOUav72X

        'if the algorithm is updated at a later date. Storing the algorithm name with the hash keeps already existing Passes operational, since they will be processed using
        'the old algorithm. only new and changed passes will use the updated algorithm.
        Dim saltedSha512PasswordHashString As String
        Try
            Using SHA512Algorithm As New SHA512Managed()
                saltedSha512PasswordHash = SHA512Algorithm.ComputeHash(saltedPasswordByteArray)
                saltedSha512PasswordHashString = Convert.ToBase64String(saltedSha512PasswordHash)
            End Using
        Catch ex As ArgumentNullException
            Throw New ArgumentNullException("Cannot compute hash!")
            Exit Function
        Catch ex As ObjectDisposedException
            Throw New ObjectDisposedException("Cannot return calculated Hash")
            Exit Function
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try

        'HashFormat: algorithm:hashSize:salt:hash
        authenticationHash = String.Format("SHA512:{0}:{1}:{2}", saltedSha512PasswordHashString.Length, SaltString, saltedSha512PasswordHashString)
        Return authenticationHash

    End Function

    Public Shared Function VerifyPassword(ByVal password As String, ByVal goodHash As String) As Boolean

        'TO VALIDATE THE PASSWORD

        'Retrieve the user's salt and hash from the database.
        Dim splittedHash() As String = goodHash.Split(DELIMITER)

        'Verifying that the splittedHash has 3 parts where 0 is algorithm, 1 is hash size, 2 is the salt and 3 is the hash.
        'splittedHash.Length property returns 1 value more than the last array index. Since Length starts counter from 1 which array couunter starts at Zero
        'This requires HASH_SECTIONS to be set as 4 while array has a max index of 3
        If Not splittedHash.Length = HASH_SECTIONS Then
            Throw New Exception("Fields are missing from the password hash.")
            Exit Function
        End If

        'Only SHA512 is supported right now
        If Not splittedHash(HASH_ALGORITHM_INDEX) = "SHA512" Then
            Throw New Exception("Unsupported hash type")
            Exit Function
        End If

        'Verify that the Hash is valid.
        If Not splittedHash(HASH_INDEX).Length = splittedHash(HASH_SIZE_INDEX) Then
            Throw New Exception("Invalid hash. Hash length doesn't match stored hash length.")
            Exit Function
        End If

        'Get the salt, Prepend the salt to the given password and hash it using the same hash function.
        Dim gettingSaltString As String = splittedHash(SALT_INDEX)
        Dim prependAquiredSaltNPassword As String = gettingSaltString & password
        Dim AquiredSaltNPasswordByteArray() As Byte = Encoding.UTF8.GetBytes(prependAquiredSaltNPassword)
        Dim SHA512AquiredSaltNPasswordHash() As Byte
        'Compare the hash of the given password with the hash from the database. If they match, the password is correct. Otherwise, the password is incorrect.

        Dim Sha512AquiredPasswordHashString As String
        Try
            Using SHA512Algorithm As New SHA512Managed()
                SHA512AquiredSaltNPasswordHash = SHA512Algorithm.ComputeHash(AquiredSaltNPasswordByteArray)
                Sha512AquiredPasswordHashString = Convert.ToBase64String(SHA512AquiredSaltNPasswordHash)
            End Using
        Catch ex As ArgumentNullException
            Throw New ArgumentNullException("Cannot compute hash!")
            Exit Function
        Catch ex As ObjectDisposedException
            Throw New ObjectDisposedException("Cannot return calculated Hash")
            Exit Function
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try

        Dim hashForComparisionWithGoodHash As String = String.Format("SHA512:{0}:{1}:{2}", Sha512AquiredPasswordHashString.Length, gettingSaltString, Sha512AquiredPasswordHashString)

        If hashForComparisionWithGoodHash = goodHash Then
            Return True
        Else
            Return False
        End If

        'Parameter PasswordString passed to function for a new user or a new password.

        'PasswordString is Encoded as UTF8 and converted to a byte array for Hashing.
        'Probably because each byte is hashed individually. Not Sure. But the string have to be converted to bytes since SHA512 algorithm accepts only bytes.
        ' Dim PasswordByteArray() As Byte = Encoding.UTF8.GetBytes(PasswordString)
    End Function

End Class