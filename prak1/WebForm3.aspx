<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="prak1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                    <asp:TextBox ID="TextBoxInput" runat="server"></asp:TextBox>
            <br />
            <asp:ListBox ID="ListBoxSpices" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
                <asp:ListItem>Сахар</asp:ListItem>
                <asp:ListItem>Соль</asp:ListItem>
                <asp:ListItem>Перец</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:DropDownList ID="DropDownListFruits" runat="server">
                <asp:ListItem>яблоко</asp:ListItem>
                <asp:ListItem>лимон</asp:ListItem>
                <asp:ListItem>груша</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:RadioButton ID="RadioButtonCup" runat="server" GroupName="v1" Text="Кружка" />
            <br />
            <asp:RadioButton ID="RadioButtonPlate" runat="server" GroupName="v1" Text="Тарелка" />
            <br />
            <asp:RadioButton ID="RadioButtonKettle" runat="server" GroupName="v1" Text="Чайник" />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Отправить" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
