<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RemindPassword.aspx.cs"
    Inherits="Fired.Account.RemindPassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Password Reminder</h1>
        <asp:Wizard ID="WizardChangePassword" runat="server" ActiveStepIndex="0" HeaderText=""
            DisplaySideBar="false" OnNextButtonClick="WizardChangePassword_NextButtonClick">
            <WizardSteps>
                <asp:WizardStep runat="server" StepType="Start" ID="wStepStart">
                    <br />
                    <br />
                    <table>
                        <tr>
                            <td>
                                Email:
                            </td>
                            <td>
                                <asp:TextBox ID="TextBoxEmail" runat="server" MaxLength="100" Width="100px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ControlToValidate="TextBoxEmail"
                                    ErrorMessage="*" ToolTip="Please, enter your email" />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server"
                                    ErrorMessage="*" ToolTip="eg. you@domain.com" ControlToValidate="TextBoxEmail"
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
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
                    </table>
                    <br />
                    <asp:Label ID="LabelErrorMsgStep0" runat="server" ForeColor="#C00000"></asp:Label><br />
                </asp:WizardStep>
                <asp:WizardStep runat="server" StepType="Complete" ID="wStepComplete">
                    <center>
                        Password is sent to user's email.
                        <br />
                    </center>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    </div>
    </form>
</body>
</html>
