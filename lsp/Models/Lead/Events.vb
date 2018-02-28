Namespace LSP.Lead
    Public Class Events
        Public Property ID As Integer
        Public Property [Event] As LSP.Settings.Event
        Public Property EventDate As Date
        Public Property Location As String
        Public Property ApproxCrowd As Integer
        Public Property ShootInfo As IList(Of ShootInfo)
        Public Property Status As String
        Public Property CreatedOn As Date
        Public Property CreatedBy As LSP.Settings.User
        Public Property LastUpdatedOn As Date
        Public Property LastUpdatedBy As LSP.Settings.User
    End Class
End Namespace
