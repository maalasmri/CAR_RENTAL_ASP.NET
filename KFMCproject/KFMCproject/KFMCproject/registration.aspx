<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="KFMCproject.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


                <br />

            <div class ="pos"  style="text-align: center; direction: ltr;">

                <div style="direction: ltr; width: 718px">

                    <br />
                 
                   <br />
                    <br />

                <asp:Label ID="Label6" runat="server" Text="YourName:"></asp:Label>


                    <asp:TextBox ID="TextBox4" runat="server" Width="150px"></asp:TextBox>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label7" runat="server" Text="natid"></asp:Label>
                    <asp:TextBox ID="TextBox5" runat="server" Width="150px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label8" runat="server" Text="PhoneNumber"></asp:Label>

                    &nbsp;<asp:TextBox ID="TextBox6" runat="server" Width="150px"></asp:TextBox>
                    &nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>


            <asp:TextBox ID="TextBox2" runat="server" CssClass="newStyle30" style="top: 24px; left: 100px; " Width="150px" Height="19px"></asp:TextBox>


                    <br />
                    <br />
                    <asp:Label ID="Label9" runat="server"></asp:Label>
            &nbsp;<br />
                <br />
              


            <asp:Button ID="registrationButton" runat="server" Text="registration" OnClick="RegClick" CssClass="newStyle19 auto-style10" />

  <asp:Button ID="Button12" runat="server" Text="aaaaa" OnClick="button_Click" EnableTheming="True"  style="left: 66px; top: -284px; width: 170px; height: 53px" />    

                    <br />
                    <br />





    </div>
</asp:Content>
