<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prak2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <configuration>
                <appSettings>
                    <add key="ValidationSettings:UnobtrusiveValidationMode" value="None" />
                </appSettings>
            </configuration>
            Имя<asp:TextBox ID="TextBoxName" runat="server" style="margin-left: 110px"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="TextBoxName" Display="Static" ErrorMessage="имя не должно быть пустым" runat="server"></asp:RequiredFieldValidator>
            <br />
            Пароль<asp:TextBox ID="TextBoxPassword" MaxLength ="100" MinLength="8" runat="server" style="margin-left: 89px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="valPassword" runat="server"  ControlToValidate="TextBoxPassword" ErrorMessage="Minimum password length is 8" ValidationExpression=".{8}.*" />

            <br />
            Поддтверждение<asp:TextBox ID="TextBoxPasswordConfirm" runat="server" style="margin-left: 23px"></asp:TextBox>
            <asp:CompareValidator ControlToValidate="TextBoxPassword" Display="Static" ErrorMessage="пароли должны совпадать" ControlToCompare="TextBoxPasswordConfirm" Type="String" Operator="Equal" runat="server"></asp:CompareValidator>
            <br />
            Email<asp:TextBox ID="TextBoxEmail" runat="server" style="margin-left: 105px"></asp:TextBox>
            <asp:RegularExpressionValidator ControlToValidate="TextBoxEmail" Display="Static" ErrorMessage="неправильный email" ValidationExpression="(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)" runat="server"></asp:RegularExpressionValidator>
            <br />
            Возраст
            <asp:TextBox ID="TextBoxAge" runat="server" style="margin-left: 82px"></asp:TextBox>
            <asp:RangeValidator ControlToValidate="TextBoxAge" Type="Integer" MinimumValue="18" MaximumValue="65" ErrorMessage
                ="возраст от 18 до 65" Display="Static" runat="server"></asp:RangeValidator>
            <br />
        </div>
    </form>
</body>
</html>
