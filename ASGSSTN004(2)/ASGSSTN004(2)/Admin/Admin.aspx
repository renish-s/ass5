<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="ASGSSTN004_2_.Admin.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Admin Home Page</h1>
  
    <table>
       
        <tr>
           
            <h2>Confirm-User</h2>
       
            <td>
                 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeId" OnRowDeleting="GridView1_RowDeleting">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="UserName" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:BoundField DataField="Phone" HeaderText="Phone" />
            <asp:BoundField DataField="Age" HeaderText="Age" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:CommandField DeleteText="Confirm" HeaderText="Confirm" ShowDeleteButton="True" />
           
        </Columns>
    </asp:GridView>
            </td>
        </tr>

       </table>
</asp:Content>
