<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="ASGSSTN004_1.Employee_.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><h2>Employee Registration</h2></center>
            <table align="center">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Phone"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                       <center>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                       </center>
                    </td>
                </tr>
            
        <tr>
        <td colspan="2">
        <center>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:BoundField DataField="name" HeaderText="Name" />
                <asp:BoundField DataField="email" HeaderText="Email" />
                <asp:BoundField DataField="phn" HeaderText="Phone" />
                <asp:BoundField DataField="age" HeaderText="Age" />
                <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="test.aspx?Id={0}" HeaderText="View" Text="view" />
            </Columns>

        </asp:GridView></center>
        </td></tr>
      </table></div>
    </form>
</body>
</html>
 