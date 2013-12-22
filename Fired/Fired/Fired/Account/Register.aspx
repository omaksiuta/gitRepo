<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Fired.Account.Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            New User Details</h1>
        <table>
            <tr>
                <td>
                    Email:
                </td>
                <td style="width: 289px">
                    <asp:TextBox ID="TextBoxEmail" runat="server" MaxLength="100" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ControlToValidate="TextBoxEmail"
                        ErrorMessage="*" ToolTip="Please, enter your email" />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server"
                        ErrorMessage="eg. you@domain.com" ControlToValidate="TextBoxEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Password:
                </td>
                <td style="width: 289px">
                    <asp:TextBox ID="TextBoxPassword" runat="server" MaxLength="10" Width="300px" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ControlToValidate="TextBoxPassword" Display="Static"
                        ErrorMessage="*" runat="server" ID="RequiredFieldValidatorPassword" ToolTip="Please, Type Your Password" />
                </td>
            </tr>
            <tr>
                <td>
                    Confirm Password:
                </td>
                <td style="width: 289px; height: 26px;">
                    <asp:TextBox ID="TextBoxConfirmPassword" runat="server" MaxLength="10" Width="300px"
                        TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorTextBoxConfirmPassword" runat="server"
                        ErrorMessage="&laquo; (Required)" ControlToValidate="TextBoxConfirmPassword"
                        ToolTip="Compare Password is a REQUIRED field" />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBoxConfirmPassword"
                        CssClass="ValidationError" ControlToCompare="TextBoxPassword" ErrorMessage="Passwords do not match."
                        ToolTip="Password must be the same" />
                </td>
                <td style="height: 26px">
                    <asp:RequiredFieldValidator ControlToValidate="TextBoxConfirmPassword" Display="Static"
                        ErrorMessage="*" runat="server" ID="RequiredFieldValidatorConfirmPassword" ToolTip="Please re-type Your Password" />
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td style="height: 22px">
                    &nbsp;<asp:CheckBox ID="CheckBoxShowPassword" runat="server" Text="Show Password"
                        TextAlign="Left" AutoPostBack="True" ToolTip="Check to see Password" OnCheckedChanged="CheckBoxShowPassword_CheckedChanged" />
                </td>
            </tr>
            <tr>
                <td>
                    Image Text:
                </td>
                <td valign="top">
                    <asp:TextBox ID="TextBoxTuringCode" Height="20" runat="server" MaxLength="5" Width="75px"></asp:TextBox>
                    <asp:Image ID="ImageTuringCode" ImageUrl="~/Media/Turing.aspx" runat="server" Width="75"
                        Height="25" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ControlToValidate="TextBoxTuringCode" Display="Static"
                        ErrorMessage="*" runat="server" ID="RequiredFieldValidator1" ToolTip="Please, type the characters you see in the picture below." />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <center>
                        <asp:Label ID="LabelErrorMsg" runat="server" ForeColor="Red"></asp:Label><br />
                        <br />
                        <asp:Button ID="ButtonSave" runat="server" Text="Register" ToolTip="Click to register New User"
                            OnClick="ButtonSave_Click" />
                        <asp:Button ID="ButtonReset" runat="server" Text="Reset" ToolTip="Click to Empty data in all fields"
                            CausesValidation="False" />
                    </center>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
