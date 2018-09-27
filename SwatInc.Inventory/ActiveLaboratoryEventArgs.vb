Public Class ActiveLaboratoryEventArgs
    Inherits EventArgs

    Private _laboratoryName As String

    Property LaboratoryName As String
        Get
            Return _laboratoryName
        End Get
        Set
            _laboratoryName = Value
            LaboratoryLogo = My.Resources.ResourceManager.GetObject(LaboratoryName)
        End Set
    End Property

    Public Property LaboratoryLogo As Image
End Class