Imports System.ComponentModel.DataAnnotations

Namespace LSP.Settings
    Public Class User
        Public Enum UserType
            Administrator
            Clerk
            Front_Office
            Photographer
        End Enum

        Public Property ID As Integer
        Public Property Studio As Studio

        <Required>
        <Display(Name:="First Name")>
        <DataType(DataType.Text)>
        Public Property FirstName As String
        Public Property MiddleName As String
        Public Property LastName As String
        Public Property EMail As String
        Public Property FacebookID As String
        Public Property Website As String
        Public Property Address_Line_1 As String
        Public Property Address_Line_2 As String
        Public Property Address_Line_3 As String
        Public Property Address_City As String
        Public Property Address_State As String
        Public Property Address_Country As String
        Public Property Address_Code As String
        Public Property Type As UserType
        Public Property Status As String
        Public Property CreatedOn As Date
        Public Property CreatedBy As User
        Public Property LastUpdatedOn As Date
        Public Property LastUpdatedBy As User
    End Class
End Namespace
