<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crud.aspx.cs" Inherits="crudoperation.crud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="Nametxt" ></asp:TextBox>
            <%--<asp:Button Text="Submit" runat="server" OnClick="Unnamed_Click"/>--%>
            <asp:TextBox runat="server" ID="IDtxt" ></asp:TextBox>
            <asp:Button Text="Update" runat="server" OnClick="Unnamed_Click1"/>
            <asp:Button Text="delete" runat="server" OnClick="Unnamed_Click"/>
            
            
        </div>
        <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" AutoGenerateColumns="false" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
            <Columns>
                 <asp:BoundField HeaderText="ID" DataField="ID" />
                <asp:BoundField HeaderText="Name" DataField="studentname" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
    </form>
</body>
</html>
