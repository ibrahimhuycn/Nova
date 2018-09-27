Imports System.Security.Cryptography
Imports System.Text

Public Class Hashing

    Private Const Delimiter As String = ":"
    Const HashAlgorithmIndex As Integer = 0
    Const HashIndex As Integer = 3
    Const HashSections As Integer = 4
    Const HashSizeIndex As Integer = 1
    Const SaltBytes As Integer = 24
    Const SaltIndex As Integer = 2

    Public Shared Function CreateHashSHA512(ByVal PasswordString As String) As String

        'TO STORE A PASSWORD

        ' 1) Generate a long random salt using a CSPRNG(Cryptographically Secure Pseudo-Random Number Generator).
        '.NET does this using System.Security.Cryptography.RNGCryptoServiceProvider
        Dim authenticationHash As String
        Dim Salt(SaltBytes) As Byte
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

        Dim saltStringNPasswordString As String = SaltString & PasswordString  'Combinig SaltString and PasswordString
        Dim saltedPasswordByteArray() As Byte = Encoding.UTF8.GetBytes(saltStringNPasswordString) 'This step converts the combination of SaltString and PasswordString given to the funtion into a collection of bytes.
        Dim saltedSha512PasswordHash() As Byte 'Declaring the array to hold salted and hashed password as an array of bytes prior to conversion to base64string.

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

        Dim splittedHash() As String = goodHash.Split(Delimiter)

        If Not splittedHash.Length = HashSections Then
            Throw New Exception("Fields are missing from the password hash.")
            Exit Function
        End If

        'Only SHA512 is supported right now
        If Not splittedHash(HashAlgorithmIndex) = "SHA512" Then
            Throw New Exception("Unsupported hash type")
            Exit Function
        End If

        'Verify that the Hash is valid.
        If Not splittedHash(HashIndex).Length = splittedHash(HashSizeIndex) Then
            Throw New Exception("Invalid hash. Hash length doesn't match stored hash length.")
            Exit Function
        End If

        'Get the salt, Prepend the salt to the given password and hash it using the same hash function.
        Dim gettingSaltString As String = splittedHash(SaltIndex)
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

    End Function

End Class