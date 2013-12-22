<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Fired.Account.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Login</h1>
        <asp:Label ID="lblSubMessage" runat="server" ForeColor="Red" />
        <br />
        Email<asp:TextBox ID="txtAuthEmail" runat="server" MaxLength="100" /><asp:RequiredFieldValidator
            ControlToValidate="txtAuthEmail" Display="Static" ErrorMessage="*" ToolTip="Please, type Your email"
            runat="server" ID="vAuthEmail" />
        <br />
        Password
        <asp:TextBox ID="txtFormsAuthPwd" runat="server" TextMode="Password" MaxLength="64" />
        <asp:RequiredFieldValidator ControlToValidate="txtFormsAuthPwd" Display="Static"
            ErrorMessage="*" ToolTip="Please, type Your password" runat="server" ID="vAuthPwd" />
        <br />
        <asp:CheckBox ID="cbFormsAuthCb" runat="server" Text="Remember me" />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Login" OnClick="subMemberLogin" />
        <asp:Button ID="ButtonRegister" runat="server" Text="Register" 
            CausesValidation="False" onclick="ButtonRegister_Click" />
        <br />
        <asp:LinkButton ID="LinkButtonForgotPassword" runat="server" 
            CausesValidation="False" onclick="LinkButtonForgotPassword_Click">Forgot password ?</asp:LinkButton>
    </div>
    </form>
</body>
</html>
