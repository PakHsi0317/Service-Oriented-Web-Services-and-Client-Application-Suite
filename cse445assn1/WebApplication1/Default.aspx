<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

    <p>
&nbsp;<asp:Label ID="Label1" runat="server" Text="Convert Celsius temperature to Fahrenheit temperature"></asp:Label>
&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="343px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        &nbsp;&nbsp;
    <asp:Button ID="btnc2f" runat="server" OnClick="btnc2f_Click" Text="btnc2f" />
</p>
<p>
&nbsp;<asp:Label ID="Label2" runat="server" Text="Convert Fahrenheit temperature to Celsius temperature"></asp:Label>
&nbsp; &nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" Width="341px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
&nbsp;&nbsp;
    <asp:Button ID="btnf2c" runat="server" Text="btnf2c" OnClick="btnf2c_Click" />
</p>
<p>
&nbsp;<asp:Label ID="Label3" runat="server" Text="Sort a string of numbers, separated by comma"></asp:Label>
</p>
    <p>
        &nbsp;<asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" Width="1013px"></asp:TextBox>
        &nbsp;
    <asp:Button ID="btnCvert" runat="server" OnClick="btnCvert_Click" Text="btnConvert" />
</p>
<p>
    &nbsp;</p>

    

</asp:Content>
