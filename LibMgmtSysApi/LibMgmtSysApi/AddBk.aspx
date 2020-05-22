<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBk.aspx.cs" Inherits="LibMgmtSysApi._Default"  MasterPageFile="~/BIM.Master" %>
 
    
<%--<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Add Book</title>
</head>
<body>
    <form id="frmAdd" runat="server">
    <div align="center" 
        
        
        
        style="background-position: center center; width: 543px; text-align: center; height: 458px; margin-left: 240px; background-color: #FFFF00;">
        <br />
        <br />--%>
        
        <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <br />
        <br />
        <br />
        
        <div style="background:#FFEFD5; background-position:center;width:auto;height:100%;">
      
          
            <br />
            <br />
        <asp:Label ID="Label1" runat="server" style="text-align: center" 
            Text="Add Book" Font-Bold="True" Font-Names="Bodoni MT" Font-Size="28px" 
            Font-Underline="True" ForeColor="#0033CC"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblTtl" runat="server" Text="Title :-" Width="78px"  
            text-align="left" style="text-align: right"></asp:Label>
        <asp:TextBox ID="txtTtl" runat="server" ToolTip="Title of the book" 
            Width="183px" TabIndex="1"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtTtl" ErrorMessage="*"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblAthr" runat="server" Text="Author :-" Width="78px" 
            style="text-align: right"></asp:Label>
        <asp:TextBox ID="txtAuthr" runat="server" TabIndex="2" 
            ToolTip="Author of the book" Width="183px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtAuthr" ErrorMessage="*"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblIsbn" runat="server" Text="ISBN :-" style="text-align: right" 
            Width="78px"></asp:Label>
        <asp:TextBox ID="txtIsbn" runat="server" TabIndex="3" 
            ToolTip="ISBN of the book" Width="183px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="txtIsbn" ErrorMessage="*"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblPblsr" runat="server" Text="Publisher :-" Width="78px" 
            style="text-align: right"></asp:Label>
        <asp:TextBox ID="txtPublsr" runat="server" TabIndex="4" 
            ToolTip="Publisher of the book" Width="183px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="txtPublsr" ErrorMessage="*"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblYr" runat="server" Text="Year :-" style="text-align: right" 
            Width="78px"></asp:Label>
        <asp:TextBox ID="txtYr" runat="server" TabIndex="5" ToolTip="Year of the book" 
            Width="183px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ControlToValidate="txtYr" ErrorMessage="*"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" TabIndex="6" Text="Add" 
            ToolTip="Click to add the book to the inventory" BackColor="#99CCFF" 
            Width="125px" Font-Bold="True" Font-Names="Microsoft PhagsPa" 
            Font-Size="15px" onclick="btnAdd_Click" />
        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
       
      
         </div>
        </asp:Content>
    <%--</div>
   
    </form>
</body>
</html>--%>