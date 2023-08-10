<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="createpassword.aspx.cs" Inherits="KFMCproject.createpassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />

            <div class ="pos"  style="text-align: center; direction: ltr;">

                <div style="direction: ltr; width: 718px">

                    <br />

                   <br />
                    <br />

                <asp:Label ID="Label6" runat="server" Text="username:"></asp:Label>


                    <asp:TextBox ID="usernametext" runat="server" Width="150px"></asp:TextBox>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label7" runat="server" Text="password"></asp:Label>
                    <asp:TextBox ID="passwordtext" runat="server" Width="150px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label8" runat="server" Text="Confirm Password:"></asp:Label>

                    &nbsp;<asp:TextBox ID="ConfirmPasswordtext" runat="server" Width="150px"></asp:TextBox>
                    &nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                
                    <br />
                    <br />
                    <asp:Label ID="Label10" runat="server"></asp:Label>
            &nbsp;<br />
                <br />



            <asp:Button ID="createpassButton" runat="server" Text="createpass" OnClick="cerClick" CssClass="newStyle19 auto-style10" />


                    <br />
                    <br />





    </div>
</asp:Content>
