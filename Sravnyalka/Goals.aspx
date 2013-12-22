<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Goals.aspx.cs" Inherits="Goals" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    Наши цели
    <asp:BulletedList ID="BulletedList_Goals" runat="server">
        <asp:ListItem>Найти одинаковые по составу товары</asp:ListItem>
        <asp:ListItem>Определить вредные состовляющие</asp:ListItem>
        <asp:ListItem>Выбрать максимально полезный товар</asp:ListItem>
        <asp:ListItem>Сэкономить</asp:ListItem>
        <asp:ListItem>Ознакомить посетителей с новинками</asp:ListItem>
        <asp:ListItem>Формировать отзывы о последствиях питания товаром</asp:ListItem>
    </asp:BulletedList>
    <br />
    Что мы отображаем
    <asp:BulletedList ID="BulletedList_DataToShow" runat="server">
        <asp:ListItem>Производители</asp:ListItem>
        <asp:ListItem>Наименование товаров</asp:ListItem>
        <asp:ListItem>Состав товаров</asp:ListItem>
        <asp:ListItem> Каллорийность товаров</asp:ListItem>
    </asp:BulletedList>
    <br />
    ЧТо мы не отображаем
    <asp:BulletedList ID="BulletedList_DataNotShow" runat="server">
        <asp:ListItem>Вес товаров</asp:ListItem>
        <asp:ListItem>Цена товаров</asp:ListItem>
    </asp:BulletedList>
    Что мы позволяем
    <asp:BulletedList ID="BulletedList_Options" runat="server">
        <asp:ListItem>Оставлять правдивые отзывы о купленных товарах</asp:ListItem>
        <asp:ListItem>Добавлять новые продукты - альтернативы извесным брэндам</asp:ListItem>
        <asp:ListItem>Найти не менее качественные продукты по более низкой цене</asp:ListItem>
        <asp:ListItem>Формировать список покупки в зависимости от каллорий </asp:ListItem>
        <asp:ListItem>Отсеевать продукты с вредными составляющими</asp:ListItem>
    </asp:BulletedList>
    Источники информации
    <asp:BulletedList ID="BulletedList_InfoSource" runat="server">
        <asp:ListItem>Википедия</asp:ListItem>
        <asp:ListItem>Веб-сайты производителей</asp:ListItem>
    </asp:BulletedList>
    
</asp:Content>
