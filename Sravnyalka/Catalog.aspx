<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Catalog.aspx.cs" Inherits="Catalog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <table>
        <tr>
            <td height="400px" width="250px">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label_Developer" runat="server" Text="Производители" Font-Bold="True"></asp:Label>
                            <asp:Panel ID="Panel_Developer" runat="server" ScrollBars="Both" Height="200px">
                                <asp:CheckBoxList ID="CheckBoxList_Developer" runat="server" OnSelectedIndexChanged="CheckBoxList_Developer_SelectedIndexChanged" />
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label_Components" runat="server" Text="Состав" Font-Bold="True"></asp:Label>
                            <asp:Panel ID="Panel_Components" runat="server" ScrollBars="Both" Height="200px">
                                <asp:CheckBoxList ID="CheckBoxList_Components" runat="server" OnSelectedIndexChanged="CheckBoxList_Developer_SelectedIndexChanged" />
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <iframe src="http://furshet.zakaz.ua/ru/dairy-and-eggs/" height="400px" width="650px">
                </iframe>
            </td>
        </tr>
    </table>
</asp:Content>
