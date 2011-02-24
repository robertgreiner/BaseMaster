<%@ Page Title="Base Master | Base Conversion Calculator" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="BaseMaster._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <form id="BaseForm" runat="server">
        <asp:TextBox CssClass="number" runat="server" ID="UserNumber"></asp:TextBox>
        <asp:TextBox ID="HiddenTextBox" runat="server" style="visibility:hidden; display:none;" />
        <br />
        <asp:DropDownList CssClass="list" ID="ConvertFromList" runat="server">
            <asp:ListItem Value="2" >2 - Binary</asp:ListItem>
            <asp:ListItem Value="8" >8 - Octal</asp:ListItem>
            <asp:ListItem Selected="True" Value="10" >10 - Decimal</asp:ListItem>
            <asp:ListItem Value="16" >16 - Hexidecimal</asp:ListItem>
        </asp:DropDownList>
        <br />
        to
        <br />
        <asp:DropDownList CssClass="list" ID="ConvertToList" runat="server">
            <asp:ListItem Selected="True" Value="2" >2 - Binary</asp:ListItem>
            <asp:ListItem Value="8" >8 - Octal</asp:ListItem>
            <asp:ListItem Value="10" >10 - Decimal</asp:ListItem>
            <asp:ListItem Value="16" >16 - Hexidecimal</asp:ListItem>
        </asp:DropDownList>
        <br />
        <% if (Page.IsPostBack) { %>
            <div style="margin-top: 10px;"></div>
            <asp:Label CssClass="result" ID="BaseResult" runat="server"></asp:Label>
            <div style="margin-top: 10px;"></div>
        <% } %>
        <asp:Button ID="Submit" CssClass="submit" runat="server" UseSubmitBehavior="true" onclick="Submit_Click" Text="Calculate" />
    </form>
</asp:Content>
