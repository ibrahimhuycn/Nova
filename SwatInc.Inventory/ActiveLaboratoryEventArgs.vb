Public Class ActiveLaboratoryEventArgs
    Inherits EventArgs

    Private _laboratoryName As String

    Property LaboratoryName As String
        Get
            Return _laboratoryName
        End Get
        Set
            _laboratoryName = Value
            Dim LabNameSpacesReplaced As String = Replace(LaboratoryName, " ", "_")
            LaboratoryLogo = My.Resources.ResourceManager.GetObject(LabNameSpacesReplaced)
        End Set
    End Property

    Public Property LaboratoryLogo As Image
End Class