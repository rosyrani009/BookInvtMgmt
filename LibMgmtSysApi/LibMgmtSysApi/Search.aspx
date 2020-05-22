<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="LibMgmtSysApi.Search" MasterPageFile="~/BIM.Master" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <br />
        <br />
        <br />
        
        <div style="background:#FFDEAD; background-position:center;width:auto;height:100%;">
      
           
            <br />
            <br />
        <asp:Label ID="lblSearch" runat="server" Text="Search" Font-Size="Large"></asp:Label>
        <br />
        <asp:TextBox ID="txtSearch" runat="server" 
            ToolTip="Enter name of author or title of book or  ISBN number of book"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSearch" runat="server" Font-Bold="False" 
            Font-Names="Microsoft Sans Serif" onclick="btnSearch_Click" TabIndex="1" 
            Text="Search Book" ToolTip="Click to search for book/s." />
            <br />
        <br />
      
            <asp:Label ID="Label1" runat="server" style="text-align: center" 
            Text="List of Books" Font-Bold="True" Font-Names="Bodoni MT" Font-Size="28px" 
            Font-Underline="True" ForeColor="#0033CC"></asp:Label>
            <div style="width: 1323px;height:350px; margin-left:auto;margin-right:auto ;">
        <asp:GridView ID="gdvBkLst" runat="server" AllowPaging="True" 
    BackColor="White" BorderColor="#CC9966" 
            BorderStyle="None" BorderWidth="1px" CellPadding="4" 
            EnableSortingAndPagingCallbacks="True" 
    style="position: relative; top: 3px; left: 56px; width: 1303px" 
            DataKeyNames="ISBN" AutoGenerateColumns="False">
            <RowStyle BackColor="White" ForeColor="#330099" />
            <Columns>
                <asp:BoundField  DataField="Title" HeaderText="Title"  />
                <asp:BoundField  DataField="Author" HeaderText="Author" />
                <asp:BoundField DataField="ISBN" HeaderText="ISBN" InsertVisible="False" 
                    ReadOnly="True" />
                <asp:BoundField  DataField="Publisher" HeaderText="Publisher" />
                <asp:BoundField  DataField="Year" HeaderText="Year" />
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <EditRowStyle BorderStyle="Solid" />
        </asp:GridView>
         </div>
      <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
         </div>

</asp:Content>
   

