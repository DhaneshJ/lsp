Namespace LSP.Settings
    Public Class [Event]
        Public Property ID As Integer
        Public Property OrderType As OrderType
        Public Property Name As String
        Public Property Services As IList(Of Service)
        Public Property Status As String
        Public Property CreatedOn As Date
        Public Property CreatedBy As User
        Public Property LastUpdatedOn As Date
        Public Property LastUpdatedBy As User
    End Class
End Namespace
