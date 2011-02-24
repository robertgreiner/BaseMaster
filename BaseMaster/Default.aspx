<%@ Page Title="Base Master | Base Conversion Calculator" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="BaseMaster._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <form id="BaseForm" runat="server">
        <asp:TextBox CssClass="number" runat="server" ID="UserNumber"></asp:TextBox>
        <asp:DropDownList CssClass="list" ID="ConvertFromList" runat="server">
            <asp:ListItem Value="2" >2 - Binary</asp:ListItem>
            <asp:ListItem Value="8" >8 - Octal</asp:ListItem>
            <asp:ListItem Selected="True" Value="10" >10 - Decimal</asp:ListItem>
            <asp:ListItem Value="16" >16 - Hexidecimal</asp:ListItem>
        </asp:DropDownList>
        to
        <asp:DropDownList CssClass="list" ID="ConvertToList" runat="server">
            <asp:ListItem Selected="True" Value="2" >2 - Binary</asp:ListItem>
            <asp:ListItem Value="8" >8 - Octal</asp:ListItem>
            <asp:ListItem Value="10" >10 - Decimal</asp:ListItem>
            <asp:ListItem Value="16" >16 - Hexidecimal</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Submit" CssClass="submit" runat="server" UseSubmitBehavior="true" onclick="Submit_Click" Text="Calculate" />
        <div></div>
        <asp:Label CssClass="result" ID="BaseResult" runat="server"></asp:Label>
        <br />
        
    </form>
</asp:Content>
