<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Personal_Information_ASP._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Personal Information Form</title>
    <link href="styles/StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="wrapper">
        <div class="form-container">
            <form id="form1" runat="server">
                <h2>Personal Information Form</h2>

                <div class="form-group">
                    <label for="txtFullname">Fullname:</label>
                    <asp:TextBox ID="txtFullname" runat="server" CssClass="input-field"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtAge">Age:</label>
                    <asp:TextBox ID="txtAge" runat="server" CssClass="input-field"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="ddlSex">Sex:</label>
                    <asp:DropDownList ID="ddlSex" runat="server" CssClass="dropdown-list">
                        <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                        <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="form-group">
                    <label for="txtNationality">Nationality:</label>
                    <asp:TextBox ID="txtNationality" runat="server" CssClass="input-field"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtAddress">Address:</label>
                    <asp:TextBox ID="txtAddress" runat="server" CssClass="input-field"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtPhoneNumber">Phone Number:</label>
                    <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="input-field"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtEmailAddress">Email Address:</label>
                    <asp:TextBox ID="txtEmailAddress" runat="server" CssClass="input-field"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtPlaceofBirth">Place of Birth:</label>
                    <asp:TextBox ID="txtPlaceofBirth" runat="server" CssClass="input-field"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="ddlMaritalStatus">Marital Status:</label>
                    <asp:DropDownList ID="ddlMaritalStatus" runat="server" CssClass="dropdown-list">
                        <asp:ListItem Text="Single" Value="Single"></asp:ListItem>
                        <asp:ListItem Text="Married" Value="Married"></asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="form-group">
                    <label for="txtLanguage">Language:</label>
                    <asp:TextBox ID="txtLanguage" runat="server" CssClass="input-field"></asp:TextBox>
                </div>

                <div class="form-group" style="width: 100%;">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="submit-btn" />
                </div>
            </form>
        </div>

        <div class="table-container">
            <asp:Table ID="Table1" runat="server" CssClass="info-table"></asp:Table>
        </div>
    </div>
</body>
</html>
