<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UnitTesting.Tools.PA.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <span style="color: rgb(51, 51, 51); font-family: arial, tahoma, 'Microsoft Yahei', 宋体, sans-serif; font-size: 16px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 32px; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none; background-color: rgb(255, 255, 255);">被除数：</span><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        除数：&nbsp; 
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="计算" />
        <br />
        结果：&nbsp; 
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
        <br />
        <br />
        数1:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        数2:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="相加计算" />
        <br />
        结果: <asp:Label ID="Label2" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
