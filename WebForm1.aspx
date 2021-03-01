<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ApplicationExample.WebForm1" %>

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
                    <td class="auto-style3" colspan="6">
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">Employee ID</td>
                    <td colspan="3">
                        <asp:TextBox ID="TxtId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">Employee Name</td>
                    <td colspan="3">
                        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">Employee Saly</td>
                    <td colspan="3">
                        <asp:TextBox ID="TxtSal" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="BtnInsert" runat="server" OnClick="BtnInsert_Click" Text="Insert" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="BtnDel" runat="server" OnClick="BtnDel_Click" Text="Delete" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="BtnSelect" runat="server" OnClick="BtnSelect_Click" Text="Show" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" Text="Find" />
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
