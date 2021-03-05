<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplicationWithDisConnnected.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmailId" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="fname" HeaderText="fname" SortExpression="fname" />
                    <asp:BoundField DataField="lname" HeaderText="lname" SortExpression="lname" />
                    <asp:BoundField DataField="EmailId" HeaderText="EmailId" ReadOnly="True" SortExpression="EmailId" />
                    <asp:TemplateField HeaderText="ImageUrl" SortExpression="ImageUrl">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ImageUrl") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <div class="auto-style1">
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("ImageUrl") %>'></asp:Label>
                                <br />
                                <br />
                                <asp:Image ID="Image1" runat="server" Height="195px" ImageUrl='<%# Eval("ImageUrl") %>' Width="174px" />
                                <br />
                                <br />
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBCS %>" SelectCommand="SELECT [fname], [lname], [EmailId], [ImageUrl] FROM [usertable]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
