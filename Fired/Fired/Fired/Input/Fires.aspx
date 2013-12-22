<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fires.aspx.cs" Inherits="Fired.Input.Salary" %>

<%@ Register TagPrefix="asp" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="Server" />
        <%--http://www.asp.net/ajaxlibrary/act_AutoComplete_Simple.ashx--%>
        <br />
        <br />
        <table>
            <tr>
                <td>
                    Company
                </td>
                <td>
                    <asp:TextBox ID="txtCompany" runat="server" />
                    <asp:AutoCompleteExtender ID="AutoCompleteExtendertxtCompany" TargetControlID="txtCompany"
                        runat="server" ServiceMethod="GetCompletionListForCompany" UseContextKey="True"
                        CompletionSetCount="2" />
                </td>
                <td>
                    City
                </td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </td>
                <td>
                    Url
                </td>
                <td>
                    <asp:TextBox ID="txtCompanyUrl" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <table>
            <tr>
                <td>
                    Position
                </td>
                <td>
                    <asp:TextBox ID="txtPosition" runat="server"></asp:TextBox>
                    <asp:AutoCompleteExtender ID="AutoCompleteExtendertxtPosition" TargetControlID="txtPosition"
                        runat="server" ServiceMethod="GetCompletionListForPosition" UseContextKey="True"
                        CompletionSetCount="1" />
                </td>
                <td>
                    Year
                </td>
                <td>
                    <asp:DropDownList ID="ddlYear" runat="server">
                        <asp:ListItem Enabled="False">2014</asp:ListItem>
                        <asp:ListItem Selected="True">2013</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    Month
                </td>
                <td>
                    <asp:DropDownList ID="ddlMonth" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <ul>
            <li>Rules adding New users:
                <ul>
                    <li>No more then 2 users / emails:
                        <ul>
                            <li>per 1 ip </li>
                        </ul>
                    </li>
                    <li>No more then 1 user:
                        <ul>
                            <li>per 1 email </li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li>Rules of Fire data Storage:
                <ul>
                    <li>Statistics starts from 2010 </li>
                    <li>Year is not higher then now </li>
                    <li>No more then 2 inputs:
                        <ul>
                            <li>per company </li>
                        </ul>
                    </li>
                    <li>No more then 12 inputs:
                        <ul>
                            <li>per user </li>
                        </ul>
                        <ul>
                            <li>per year </li>
                        </ul>
                    </li>
                </ul>
            </li>
        </ul>
        <br />
    </div>
    </form>
</body>
</html>
