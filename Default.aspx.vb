Public Class _Default
    Inherits System.Web.UI.Page

    Dim CONNECT As New Connection()

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Register()
    End Sub

    Public Sub Register()
        Dim fullname = txtFullname.Text
        Dim age = txtAge.Text
        Dim sex = ddlSex.SelectedValue
        Dim nationality = txtNationality.Text
        Dim address = txtAddress.Text
        Dim phone_number = txtPhoneNumber.Text
        Dim email_address = txtEmailAddress.Text
        Dim placeofbirth = txtPlaceofBirth.Text
        Dim marital_status = ddlMaritalStatus.SelectedValue
        Dim language = txtLanguage.Text


        Dim query = "INSERT INTO personal (fullname, age, sex, nationality, address, phone_number, email_address, placeofbirth, marital_status, language) VALUES (@fullname, @dateofbirth, @sex, @nationality, @address, @phone_number, @email_address, @placeofbirth, @marital_status, @language)"

        CONNECT.AddParam("@fullname", fullname)
        CONNECT.AddParam("@dateofbirth", age)
        CONNECT.AddParam("@sex", sex)
        CONNECT.AddParam("@nationality", nationality)
        CONNECT.AddParam("@address", address)
        CONNECT.AddParam("@phone_number", phone_number)
        CONNECT.AddParam("@email_address", email_address)
        CONNECT.AddParam("@placeofbirth", placeofbirth)
        CONNECT.AddParam("@marital_status", marital_status)
        CONNECT.AddParam("@language", language)

        Dim insert = CONNECT.Query(query)

        If insert Then
            Dim script As String = "alert('Successfully Register!');"
            ClientScript.RegisterStartupScript(Me.GetType(), "alertMessage", script, True)
        Else
            Dim script As String = "alert('Failed to Register!');"
            ClientScript.RegisterStartupScript(Me.GetType(), "alertMessage", script, True)
        End If

        ViewTable()
    End Sub

    Public Sub ViewTable()
        Dim query = "SELECT * FROM personal"

        CONNECT.Query(query)

        Table1.Rows.Clear()

        Dim headerRow As New TableHeaderRow()
        headerRow.Cells.Add(New TableHeaderCell() With {.Text = "Full Name"})
        headerRow.Cells.Add(New TableHeaderCell() With {.Text = "Age"})
        headerRow.Cells.Add(New TableHeaderCell() With {.Text = "Sex"})
        headerRow.Cells.Add(New TableHeaderCell() With {.Text = "Nationality"})
        headerRow.Cells.Add(New TableHeaderCell() With {.Text = "Address"})
        headerRow.Cells.Add(New TableHeaderCell() With {.Text = "Phone Number"})
        headerRow.Cells.Add(New TableHeaderCell() With {.Text = "Email Address"})
        headerRow.Cells.Add(New TableHeaderCell() With {.Text = "Place of Birth"})
        headerRow.Cells.Add(New TableHeaderCell() With {.Text = "Marital Status"})
        headerRow.Cells.Add(New TableHeaderCell() With {.Text = "Language"})
        Table1.Rows.Add(headerRow)

        For Each row As DataRow In CONNECT.Data.Tables(0).Rows
            Dim tableRow As New TableRow()

            tableRow.Cells.Add(New TableCell() With {.Text = row("fullname").ToString()})
            tableRow.Cells.Add(New TableCell() With {.Text = row("age").ToString()})
            tableRow.Cells.Add(New TableCell() With {.Text = row("sex").ToString()})
            tableRow.Cells.Add(New TableCell() With {.Text = row("nationality").ToString()})
            tableRow.Cells.Add(New TableCell() With {.Text = row("address").ToString()})
            tableRow.Cells.Add(New TableCell() With {.Text = row("phone_number").ToString()})
            tableRow.Cells.Add(New TableCell() With {.Text = row("email_address").ToString()})
            tableRow.Cells.Add(New TableCell() With {.Text = row("placeofbirth").ToString()})
            tableRow.Cells.Add(New TableCell() With {.Text = row("marital_status").ToString()})
            tableRow.Cells.Add(New TableCell() With {.Text = row("language").ToString()})
            Table1.Rows.Add(tableRow)
        Next
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ViewTable()
    End Sub

End Class