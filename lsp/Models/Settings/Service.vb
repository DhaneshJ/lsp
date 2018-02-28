Namespace LSP.Settings
    Public Class Service
        Public Enum ServiceType
            Photography
            Videography
            Others
        End Enum

        Public Enum ServiceValueType
            [Boolean]
            [Integer]
        End Enum

        Public Property ID As Integer
        Public Property Studio As Studio
        Public Property Type As ServiceType
        Public Property Name As String
        Public Property ServiceResponseType As ServiceValueType
        Public Property Status As String
        Public Property CreatedOn As Date
        Public Property CreatedBy As User
        Public Property LastUpdatedOn As Date
        Public Property LastUpdatedBy As User
    End Class
End Namespace
