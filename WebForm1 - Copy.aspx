<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationWithDisConnnected.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 40%;
        }
        .auto-style2 {
            text-align: right;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2">First Name</td>
                    <td colspan="4">
                        <asp:TextBox ID="TxtFName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Last Name</td>
                    <td colspan="4">
                        <asp:TextBox ID="TxtLName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">EmailId</td>
                    <td colspan="4">
                        <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td colspan="4">
                        <asp:TextBox ID="TxtPwd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Image</td>
                    <td colspan="2">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:Image ID="Image1" runat="server" Height="149px" Width="200px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="ADD User" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update User" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="BtnDel" runat="server" OnClick="BtnDel_Click" Text="Delete User" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="BtnShow" runat="server" OnClick="BtnShow_Click" Text="Show Users" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" Text="Find" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
