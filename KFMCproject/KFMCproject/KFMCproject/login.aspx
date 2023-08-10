<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="KFMCproject.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">






    
    <br>
                <br />

            <div class ="pos"  style="text-align: center; direction: ltr;">

                <div style="direction: ltr; width: 718px">

                <br />
                <br />
                <br />

                    &nbsp;&nbsp;&nbsp;

                <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>


            <asp:TextBox ID="txtEmail" runat="server" CssClass="newStyle30" style="top: 24px; left: 100px; " Width="150px" Height="19px"></asp:TextBox>


                    <br />
                    <br />
                <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" CssClass="newStyle10" style="top: 32px; left: 100px; " Width="150px"></asp:TextBox>
            &nbsp;<br />
              



            <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="newStyle19 auto-style10" />
                <br />
              



                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
                    <br />
                    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
                    <br />







</asp:Content>
