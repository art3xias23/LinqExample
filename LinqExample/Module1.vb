Module LINQModule

    Public Class cEmployee
        Public Property Id As Integer
        Public Property FirstName As String
        Public Property LastName As String
        Public Property YearsWorked As Integer
        Public Property PhoneNumber As String
        Public Property Address As New cAddress
        Public Property AccessPoints As New List(Of cAccessPoints)

        Public ReadOnly Property FullName As String
            Get
                Return FirstName & " " & LastName
            End Get
        End Property
    End Class

    Public Class cAddress

        Public Property Address1 As String
        Public Property Address2 As String
        Public Property City As String
        Public Property State As String
        Public Property Zip As String
    End Class

    Public Class cAccessPoints
        Public Property Id As Integer
        Public Property Name As Integer

    End Class


    Public Class cFullTimer
        Inherits cEmployee
    End Class

    Sub Main()
        'Shorthand Declarations of Named Types (Stringly Typed)
        Dim oAllAccess As New cAccessPoints() With {
            .Id = 0,
            .Name = "All Access"}
        Dim MainMenuAccess As New cAccessPoints() With {
            .Id = 1,
            .Name = "Main Menu"}
        Dim oPayrollAccess As New cAccessPoints() With {
            .Id = 2,
            .Name = "Payroll"}
        Dim oPhoneAccess As New cAccessPoints() With {
            .Id = 3,
            .Name = "Phone Numbers"}
        Dim oTimeSheetsAccess As New cAccessPoints() With {
            .Id = 4,
            .Name = "Time Sheets"}

        Dim lstEmployees As IEnumerable(Of cEmployee) = New List(Of cEmployee)({
                                                                               })


    End Sub
End Module

