<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Specifications.aspx.cs" Inherits="Specifications" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    Спецификации
    <asp:BulletedList ID="BulletedList_Specs" runat="server">
        <asp:ListItem>Data are provided from XML files</asp:ListItem>
        <asp:ListItem>Data are transfered via .net web-services</asp:ListItem>
        <asp:ListItem>Separate Products xml is created inside 'Products' folder by Category name </asp:ListItem>
        <asp:ListItem>Data Can be filtered by: Category, Manufacture, Components, Meatless</asp:ListItem>
    </asp:BulletedList>
    Полезные ссылки
    <asp:HyperLink ID="HyperLink1" NavigateUrl="http://www.drdobbs.com/windows/parsing-xml-files-in-net-using-c/184416669?pgno=3"
        runat="server" Text="XML read methods" />
    <asp:HyperLink ID="HyperLink2" NavigateUrl="http://www.w3schools.com/aspnet/aspnet_navigation.asp"
        runat="server" Text="W3 schools asp.net" />
</asp:Content>
