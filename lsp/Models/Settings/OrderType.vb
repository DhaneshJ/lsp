Namespace LSP.Settings
    Public Class OrderType
        Public Enum OrderCategory
            General = 1
            Multievents = 2
            Other = -1
        End Enum

        Public Property ID As Integer
        Public Property Studio As Studio
        Public Property Category As OrderCategory
        Public Property Name As String
        Public Property Status As String
        Public Property CreatedOn As Date
        Public Property CreatedBy As User
        Public Property LastUpdatedOn As Date
        Public Property LastUpdatedBy As User
    End Class
End Namespace
