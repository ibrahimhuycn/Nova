Public Class ActiveLaboratoryEventArgs
    Inherits EventArgs

    Private _LaboratoryLogo As Image
    Private _laboratoryName As String

    Property LaboratoryName As String
        Get
            Return _laboratoryName
        End Get
        Set
            _laboratoryName = Value
            Dim LabNameSpacesReplaced As String = Replace(LaboratoryName, " ", "_")
            _LaboratoryLogo = My.Resources.ResourceManager.GetObject(LabNameSpacesReplaced)
        End Set
    End Property

    Public Property LaboratoryId As Integer

    Public ReadOnly Property LaboratoryLogo As Image
        Get
            Return _LaboratoryLogo
        End Get
    End Property

End Class