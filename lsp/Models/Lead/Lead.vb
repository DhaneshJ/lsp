Namespace LSP.Lead
    Public Class Lead
        Public Property ID As Integer
        Public Property Studio As LSP.Settings.Studio
        Public Property UserName As String
        Public Property Phone As String
        Public Property EMail As String
        Public Property Address As String
        Public Property FacebookID As String
        Public Property OrderType As LSP.Settings.OrderType
        Public Property Comments As String
        Public Property Events As IList(Of Events)
        Public Property Deliverables As IList(Of Deliverables)
        Public Property Invoice As IList(Of Invoice)
        Public Property IsProject As Boolean
        Public Property Status As String
        Public Property CreatedOn As Date
        Public Property CreatedBy As LSP.Settings.User
        Public Property LastUpdatedOn As Date
        Public Property LastUpdatedBy As LSP.Settings.User
    End Class
End Namespace
