Namespace LSP.Settings
    Public Class RateCard
        Public Enum RateCardType
            Deliverables
            Events
        End Enum

        Public Property ID As Integer
        Public Property Studio As Studio
        Public Property RateCardFor As RateCardType
        Public Property Entity1 As Integer
        Public Property Entity2 As Integer
        Public Property UnitRate As Single
        Public Property Status As String
        Public Property CreatedOn As Date
        Public Property CreatedBy As User
        Public Property LastUpdatedOn As Date
        Public Property LastUpdatedBy As User
    End Class
End Namespace
