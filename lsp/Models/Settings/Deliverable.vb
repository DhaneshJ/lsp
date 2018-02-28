Namespace LSP.Settings
    Public Class Deliverable
        Public Enum DeliverableType
            Album
            Electronic_Media
        End Enum

        Public Property ID As Integer
        Public Property Studio As Studio
        Public Property Type As DeliverableType
        Public Property Name As String
        Public Property Sizes As IList(Of DeliverableSize)
        Public Property Comments As String
        Public Property Status As String
        Public Property CreatedOn As Date
        Public Property CreatedBy As User
        Public Property LastUpdatedOn As Date
        Public Property LastUpdatedBy As User
    End Class
End Namespace
