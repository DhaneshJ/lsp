Namespace LSP.Lead
    Public Class Invoice
        Public Property ID As Integer
        Public Property Item As LSP.Settings.RateCard
        Public Property Quantity As Integer
        Public Property DiscountAmount As Single
        Public Property DiscountPercent As Single
        Public Property Status As String
        Public Property CreatedOn As Date
        Public Property CreatedBy As LSP.Settings.User
        Public Property LastUpdatedOn As Date
        Public Property LastUpdatedBy As LSP.Settings.User
    End Class
End Namespace
