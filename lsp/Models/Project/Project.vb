Namespace LSP.Project
    Public Class Project
        Public Property ID As Integer
        Public Property Lead As LSP.Lead.Lead
        Public Property ProjectConvertedDate As Date
        Public Property InvoiceAmount As Single
        Public Property Payments As IList(Of Payment)
    End Class
End Namespace
