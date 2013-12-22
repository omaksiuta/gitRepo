<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Fired.Account.Profile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            General</h1>
        <table>
            <tr>
                <td>
                    <asp:Label ID="LabelError" runat="server" ForeColor="#C00000"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="PanelGeneral" runat="server" Visible="true">
                        <table>
                            <tr>
                                <td>
                                    Email:
                                </td>
                                <td style="width: 310px">
                                    <asp:TextBox ID="TextBoxEmail" runat="server" MaxLength="100" Width="250px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ControlToValidate="TextBoxEmail" ErrorMessage="*" runat="server"
                                        ID="RequiredFieldValidatorEmail" ToolTip="Please, type Your email" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    First Name:
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBoxFirstName" runat="server" MaxLength="32" Width="250px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Middle Name:
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBoxMiddleName" runat="server" MaxLength="32" Width="250px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Last Name:
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBoxLastName" runat="server" MaxLength="32" Width="250px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Nick Name:
                                </td>
                                <td style="width: 310px;">
                                    <asp:TextBox ID="TextBoxNickname" runat="server" MaxLength="32" Width="250px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Gender:
                                </td>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonListSelectGender" runat="server">
                                        <asp:ListItem Value="M">Male</asp:ListItem>
                                        <asp:ListItem Value="F">Female</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Birth date:
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownListMonth" runat="server" ToolTip="Month" EnableViewState="False">
                                        <asp:ListItem Text="January" Value="01" />
                                        <asp:ListItem Text="February" Value="02" />
                                        <asp:ListItem Text="March" Value="03" />
                                        <asp:ListItem Text="April" Value="04" />
                                        <asp:ListItem Text="May" Value="05" />
                                        <asp:ListItem Text="June" Value="06" />
                                        <asp:ListItem Text="July" Value="07" />
                                        <asp:ListItem Text="August" Value="08" />
                                        <asp:ListItem Text="September" Value="09" />
                                        <asp:ListItem Text="October" Value="10" />
                                        <asp:ListItem Text="November" Value="11" />
                                        <asp:ListItem Text="December" Value="12" />
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="DropDownListDay" runat="server" ToolTip="Day" EnableViewState="False">
                                        <asp:ListItem Text="1" Value="01" />
                                        <asp:ListItem Text="2" Value="02" />
                                        <asp:ListItem Text="3" Value="03" />
                                        <asp:ListItem Text="4" Value="04" />
                                        <asp:ListItem Text="5" Value="05" />
                                        <asp:ListItem Text="6" Value="06" />
                                        <asp:ListItem Text="7" Value="07" />
                                        <asp:ListItem Text="8" Value="08" />
                                        <asp:ListItem Text="9" Value="09" />
                                        <asp:ListItem Text="10" Value="10" />
                                        <asp:ListItem Text="11" Value="11" />
                                        <asp:ListItem Text="12" Value="12" />
                                        <asp:ListItem Text="13" Value="13" />
                                        <asp:ListItem Text="14" Value="14" />
                                        <asp:ListItem Text="15" Value="15" />
                                        <asp:ListItem Text="16" Value="16" />
                                        <asp:ListItem Text="17" Value="17" />
                                        <asp:ListItem Text="18" Value="18" />
                                        <asp:ListItem Text="19" Value="19" />
                                        <asp:ListItem Text="20" Value="20" />
                                        <asp:ListItem Text="21" Value="21" />
                                        <asp:ListItem Text="22" Value="22" />
                                        <asp:ListItem Text="23" Value="23" />
                                        <asp:ListItem Text="24" Value="24" />
                                        <asp:ListItem Text="25" Value="25" />
                                        <asp:ListItem Text="26" Value="26" />
                                        <asp:ListItem Text="27" Value="27" />
                                        <asp:ListItem Text="28" Value="28" />
                                        <asp:ListItem Text="29" Value="29" />
                                        <asp:ListItem Text="30" Value="30" />
                                        <asp:ListItem Text="31" Value="31" />
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="DropDownListYear" runat="server" ToolTip="Year" EnableViewState="False">
                                        <asp:ListItem Text="1900" Value="1900" />
                                        <asp:ListItem Text="1901" Value="1901" />
                                        <asp:ListItem Text="1902" Value="1902" />
                                        <asp:ListItem Text="1903" Value="1903" />
                                        <asp:ListItem Text="1904" Value="1904" />
                                        <asp:ListItem Text="1905" Value="1905" />
                                        <asp:ListItem Text="1906" Value="1906" />
                                        <asp:ListItem Text="1907" Value="1907" />
                                        <asp:ListItem Text="1908" Value="1908" />
                                        <asp:ListItem Text="1909" Value="1909" />
                                        <asp:ListItem Text="1910" Value="1910" />
                                        <asp:ListItem Text="1911" Value="1911" />
                                        <asp:ListItem Text="1912" Value="1912" />
                                        <asp:ListItem Text="1913" Value="1913" />
                                        <asp:ListItem Text="1914" Value="1914" />
                                        <asp:ListItem Text="1915" Value="1915" />
                                        <asp:ListItem Text="1916" Value="1916" />
                                        <asp:ListItem Text="1917" Value="1917" />
                                        <asp:ListItem Text="1918" Value="1918" />
                                        <asp:ListItem Text="1919" Value="1919" />
                                        <asp:ListItem Text="1920" Value="1920" />
                                        <asp:ListItem Text="1921" Value="1921" />
                                        <asp:ListItem Text="1922" Value="1922" />
                                        <asp:ListItem Text="1923" Value="1923" />
                                        <asp:ListItem Text="1924" Value="1924" />
                                        <asp:ListItem Text="1925" Value="1925" />
                                        <asp:ListItem Text="1926" Value="1926" />
                                        <asp:ListItem Text="1927" Value="1927" />
                                        <asp:ListItem Text="1928" Value="1928" />
                                        <asp:ListItem Text="1929" Value="1929" />
                                        <asp:ListItem Text="1930" Value="1930" />
                                        <asp:ListItem Text="1931" Value="1931" />
                                        <asp:ListItem Text="1932" Value="1932" />
                                        <asp:ListItem Text="1933" Value="1933" />
                                        <asp:ListItem Text="1934" Value="1934" />
                                        <asp:ListItem Text="1935" Value="1935" />
                                        <asp:ListItem Text="1936" Value="1936" />
                                        <asp:ListItem Text="1937" Value="1937" />
                                        <asp:ListItem Text="1938" Value="1938" />
                                        <asp:ListItem Text="1939" Value="1939" />
                                        <asp:ListItem Text="1940" Value="1940" />
                                        <asp:ListItem Text="1941" Value="1941" />
                                        <asp:ListItem Text="1942" Value="1942" />
                                        <asp:ListItem Text="1943" Value="1943" />
                                        <asp:ListItem Text="1944" Value="1944" />
                                        <asp:ListItem Text="1945" Value="1945" />
                                        <asp:ListItem Text="1946" Value="1946" />
                                        <asp:ListItem Text="1947" Value="1947" />
                                        <asp:ListItem Text="1948" Value="1948" />
                                        <asp:ListItem Text="1949" Value="1949" />
                                        <asp:ListItem Text="1950" Value="1950" />
                                        <asp:ListItem Text="1951" Value="1951" />
                                        <asp:ListItem Text="1952" Value="1952" />
                                        <asp:ListItem Text="1953" Value="1953" />
                                        <asp:ListItem Text="1954" Value="1954" />
                                        <asp:ListItem Text="1955" Value="1955" />
                                        <asp:ListItem Text="1956" Value="1956" />
                                        <asp:ListItem Text="1957" Value="1957" />
                                        <asp:ListItem Text="1958" Value="1958" />
                                        <asp:ListItem Text="1959" Value="1959" />
                                        <asp:ListItem Text="1960" Value="1960" />
                                        <asp:ListItem Text="1961" Value="1961" />
                                        <asp:ListItem Text="1962" Value="1962" />
                                        <asp:ListItem Text="1963" Value="1963" />
                                        <asp:ListItem Text="1964" Value="1964" />
                                        <asp:ListItem Text="1965" Value="1965" />
                                        <asp:ListItem Text="1966" Value="1966" />
                                        <asp:ListItem Text="1967" Value="1967" />
                                        <asp:ListItem Text="1968" Value="1968" />
                                        <asp:ListItem Text="1969" Value="1969" />
                                        <asp:ListItem Text="1970" Value="1970" />
                                        <asp:ListItem Text="1971" Value="1971" />
                                        <asp:ListItem Text="1972" Value="1972" />
                                        <asp:ListItem Text="1973" Value="1973" />
                                        <asp:ListItem Text="1974" Value="1974" />
                                        <asp:ListItem Text="1975" Value="1975" />
                                        <asp:ListItem Text="1976" Value="1976" />
                                        <asp:ListItem Text="1977" Value="1977" />
                                        <asp:ListItem Text="1978" Value="1978" />
                                        <asp:ListItem Text="1979" Value="1979" />
                                        <asp:ListItem Text="1980" Value="1980" />
                                        <asp:ListItem Text="1981" Value="1981" />
                                        <asp:ListItem Text="1982" Value="1982" />
                                        <asp:ListItem Text="1983" Value="1983" />
                                        <asp:ListItem Text="1984" Value="1984" />
                                        <asp:ListItem Text="1985" Value="1985" />
                                        <asp:ListItem Text="1986" Value="1986" />
                                        <asp:ListItem Text="1987" Value="1987" />
                                        <asp:ListItem Text="1988" Value="1988" />
                                        <asp:ListItem Text="1989" Value="1989" />
                                        <asp:ListItem Text="1990" Value="1990" />
                                        <asp:ListItem Text="1991" Value="1991" />
                                        <asp:ListItem Text="1992" Value="1992" />
                                        <asp:ListItem Text="1993" Value="1993" />
                                        <asp:ListItem Text="1994" Value="1994" />
                                        <asp:ListItem Text="1995" Value="1995" />
                                        <asp:ListItem Text="1996" Value="1996" />
                                        <asp:ListItem Text="1997" Value="1997" />
                                        <asp:ListItem Text="1998" Value="1998" />
                                        <asp:ListItem Text="1999" Value="1999" />
                                        <asp:ListItem Text="2000" Value="2000" />
                                        <asp:ListItem Text="2001" Value="2001" />
                                        <asp:ListItem Text="2002" Value="2002" />
                                        <asp:ListItem Text="2003" Value="2003" />
                                        <asp:ListItem Text="2004" Value="2004" />
                                        <asp:ListItem Text="2005" Value="2005" />
                                        <asp:ListItem Text="2006" Value="2006" />
                                        <asp:ListItem Text="2007" Value="2007" />
                                        <asp:ListItem Text="2008" Value="2008" />
                                        <asp:ListItem Text="2009" Value="2009" />
                                        <asp:ListItem Text="2010" Value="2010" />
                                        <asp:ListItem Text="2010" Value="2011" />
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Country:
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownListCountry" runat="server" DataSourceID="SqlDataSourceCountry"
                                        DataTextField="COUNTRY_NAME" DataValueField="COUNTRY_NAME" Width="250px">
                                    </asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSourceCountry" runat="server" ConnectionString="<%$ ConnectionStrings:MsSqlDb %>"
                                        SelectCommand="SELECT '' AS [COUNTRY_NAME] UNION SELECT DISTINCT [COUNTRY_NAME] FROM [tbl_COUNTRY] ORDER BY [COUNTRY_NAME]">
                                    </asp:SqlDataSource>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Registered Since:
                                </td>
                                <td>
                                    <asp:Label ID="LabelRegisteredSince" runat="server" Width="299px"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Panel ID="PanelSaveRestoreButton" runat="server" Visible="True">
                        <table>
                            <tr>
                                <td align="center">
                                    <asp:Button ID="ButtonSave" runat="server" Text="Save" />
                                    <asp:Button ID="Restore" runat="server" Text="Restore" CausesValidation="False" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        </tabl>
    </div>
    </form>
</body>
</html>
