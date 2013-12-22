<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <table>
        <tr>
            <td colspan="3" align="center">
                <asp:Label ID="LabelSendEmailMsg" runat="server" Text="Ждем!"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" valign="top">
                Имя
            </td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="TextBoxSenderName" ErrorMessage="*"
                    runat="server" ID="RequiredFieldValidatorSenderName" ToolTip="Please enter your name ;)" />
            </td>
            <td>
                <asp:TextBox ID="TextBoxSenderName" runat="server" Width="600"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" valign="top">
                Ваш E-mail
            </td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="TextBoxEmailAddress" ErrorMessage="*"
                    runat="server" ID="RequiredFieldValidatorEmailAddress" ToolTip="Please enter Your valid Email Address" />
            </td>
            <td>
                <asp:TextBox ID="TextBoxEmailAddress" runat="server" Width="600"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" valign="top">
                Тема
            </td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="TextBoxSubject" Display="Static" ErrorMessage="*"
                    runat="server" ID="RequiredFieldValidatorSubject" ToolTip="Please enter Subject of Email" />
            </td>
            <td>
                <asp:TextBox ID="TextBoxSubject" runat="server" Width="600"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td rowspan="2" align="right" valign="top">
                Сообщение
            </td>
            <td rowspan="2" align="right" valign="top">
                <asp:RequiredFieldValidator ControlToValidate="TextBoxSubject" Display="Static" ErrorMessage="*"
                    runat="server" ID="RequiredFieldValidatorMessage" ToolTip="Please enter Email Message" />
            </td>
            <td>
                <asp:TextBox ID="TextBoxMessage" runat="server" TextMode="MultiLine" Width="600"
                    Rows="10"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" valign="middle">
                <asp:Button ID="ButtonSendEmail" runat="server" Text="Отправить" />
            </td>
        </tr>
    </table>
</asp:Content>
