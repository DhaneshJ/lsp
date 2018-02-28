Imports System.ComponentModel.DataAnnotations

Namespace LSP.Settings
    Public Class Studio

        Public Enum CountryCode
            India = 91
            United_States_of_America_Canada = 1
        End Enum

        Public Property ID As Integer

        <Required>
        <Display(Name:="Studio Name")>
        <DataType(DataType.Text)>
        Public Property Name As String

        <Required>
        <Display(Name:="Primary Phone Code")>
        <DataType(DataType.Text)>
        Public Property Phone_1_Code As CountryCode

        <Required>
        <Display(Name:="Primary Phone")>
        <DataType(DataType.Text)>
        Public Property Phone_1 As String

        <Required>
        <Display(Name:="EMail")>
        <DataType(DataType.EmailAddress)>
        Public Property EMail As String

        <Required>
        <Display(Name:="Website")>
        <DataType(DataType.Url)>
        Public Property Website As String

        <Required>
        <Display(Name:="Address Line 1")>
        <DataType(DataType.Text)>
        Public Property Address_Line_1 As String

        <Display(Name:="Address Line 2")>
        <DataType(DataType.Text)>
        Public Property Address_Line_2 As String

        <Display(Name:="Address Line 3")>
        <DataType(DataType.Text)>
        Public Property Address_Line_3 As String

        <Required>
        <Display(Name:="City")>
        <DataType(DataType.Text)>
        Public Property Address_City As String

        <Required>
        <Display(Name:="State")>
        <DataType(DataType.Text)>
        Public Property Address_State As String

        <Required>
        <Display(Name:="Country")>
        <DataType(DataType.Text)>
        Public Property Address_Country As String

        <Required>
        <Display(Name:="Zip Code")>
        <DataType(DataType.Text)>
        Public Property Address_Code As String

        Public Property Status As String
        Public Property CreatedOn As Date
    End Class
End Namespace
