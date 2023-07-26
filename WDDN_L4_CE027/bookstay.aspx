<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bookstay.aspx.cs" Inherits="Lab04_27.bookstay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 186px;
        }
        .auto-style4 {
            height: 23px;
            width: 186px;
        }
        .auto-style5 {
            width: 186px;
            height: 42px;
        }
        .auto-style6 {
            height: 42px;
        }
        .auto-style7 {
            width: 545px;
        }
        .auto-style8 {
            height: 23px;
            width: 545px;
        }
        .auto-style9 {
            height: 42px;
            width: 545px;
        }
        .auto-style10 {
            width: 186px;
            height: 26px;
        }
        .auto-style11 {
            width: 545px;
            height: 26px;
        }
        .auto-style12 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td id="fname" class="auto-style3">FirstName</td>
                <td class="auto-style7">
                    <asp:TextBox ID="theName" runat="server" OnTextChanged="TextBox1_TextChanged" Width="311px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="theName" ErrorMessage="FirstName is Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">LastName</td>
                <td class="auto-style8">
                    <asp:TextBox ID="lastName" runat="server" Width="312px"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style3">You Are Interested In...</td>
                <td class="auto-style7">
                    <asp:RadioButtonList ID="my_interest" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Width="185px">
                        <asp:ListItem Selected="True" Value="studio">Studio</asp:ListItem>
                        <asp:ListItem>Suite</asp:ListItem>
                        <asp:ListItem>Deluxe</asp:ListItem>
                        <asp:ListItem>Double</asp:ListItem>
                        <asp:ListItem>Single</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">FullName</td>
                <td class="auto-style11">
                    <asp:TextBox ID="fullName" runat="server" Width="393px"></asp:TextBox>
                </td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style3">My Secret is </td>
                <td class="auto-style7">
                    <asp:TextBox ID="pass" runat="server" OnTextChanged="TextBox4_TextChanged" TextMode="Password" Width="213px"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="pass" ErrorMessage="Enter atleast 6 alphanumeric characters in string!!" ForeColor="Red" ValidationExpression="[0-9|a-z|A-Z]{6}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Actually Interested In...</td>
                <td class="auto-style9">
                    <asp:CheckBoxList ID="actual_interest" runat="server">
                        <asp:ListItem>Swimming</asp:ListItem>
                        <asp:ListItem>Cricket</asp:ListItem>
                        <asp:ListItem>VollyBall</asp:ListItem>
                        <asp:ListItem>Tennis</asp:ListItem>
                        <asp:ListItem>Kabaddi</asp:ListItem>
                        <asp:ListItem>Kho</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style3">How many Adults?</td>
                <td class="auto-style7">
                    <asp:TextBox ID="adults" runat="server" TextMode="Number" Width="108px"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="adults" ErrorMessage="Value Must be more than 0 " ForeColor="Red" Operator="GreaterThan" Type="Integer" ValueToCompare="0"></asp:CompareValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="adults" ErrorMessage="Count is Required!!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="book_button" runat="server" OnClick="Button1_Click" Text="Book" Width="68px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
