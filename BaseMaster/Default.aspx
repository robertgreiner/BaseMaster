<%@ Page Title="Base Master | Base Conversion Calculator" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="BaseMaster._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <form id="BaseForm" runat="server">
        <asp:TextBox runat="server" ID="UserNumber"></asp:TextBox>
        <asp:DropDownList ID="ConvertFromList" runat="server">
            <asp:ListItem Enabled="false" Value="2" >2 - Binary</asp:ListItem>
            <asp:ListItem Enabled="false" Value="8" >8 - Octal</asp:ListItem>
            <asp:ListItem Value="10" >10 - Decimal</asp:ListItem>
            <asp:ListItem Enabled="false" Value="16" >16 - Hexidecimal</asp:ListItem>
        </asp:DropDownList>
        to
        <asp:DropDownList ID="ConvertToList" runat="server" onselectedindexchanged="ConvertToList_SelectedIndexChanged">
            <asp:ListItem Enabled="false" Value="0" >Select</asp:ListItem>
            <asp:ListItem Enabled="false" Value="2" >2 - Binary</asp:ListItem>
            <asp:ListItem Enabled="false" Value="8" >8 - Octal</asp:ListItem>
            <asp:ListItem Enabled="false" Value="10" >10 - Decimal</asp:ListItem>
            <asp:ListItem Value="16" >16 - Hexidecimal</asp:ListItem>
        </asp:DropDownList>
        =
        <asp:Label ID="BaseResult" runat="server"></asp:Label>
        <br />
        <asp:Button ID="Submit" runat="server" UseSubmitBehavior="true" onclick="Submit_Click" Text="Calculate" />
    </form>
</asp:Content>
