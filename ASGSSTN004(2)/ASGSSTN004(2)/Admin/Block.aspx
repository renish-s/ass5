<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Block.aspx.cs" Inherits="ASGSSTN004_2_.Admin.Block" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        <tr>
             <h2>Block-User</h2>
            <td>
                 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeId" OnRowDeleting="GridView1_RowDeleting">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="UserName" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:BoundField DataField="Phone" HeaderText="Phone" />
            <asp:BoundField DataField="Age" HeaderText="Age" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:CommandField DeleteText="Block" HeaderText="Block" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
