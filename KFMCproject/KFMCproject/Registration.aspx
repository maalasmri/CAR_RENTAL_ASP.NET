<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="KFMCproject.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


                <br />

            <div class ="pos"  style="text-align: center; direction: ltr;">

                <div style="direction: ltr; width: 718px; text-align: center;">

                    <br />
                 
                   <br />
                    <br />

                <asp:Label ID="Label6" runat="server" Text="Full Name:"></asp:Label>


                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


                    <asp:TextBox ID="txtfullname" runat="server" Width="250px" Height="40"></asp:TextBox>
                    <br />
                                        <asp:Label ID="lblOutfname" runat="server" style="color:red;font-weight:bold"></asp:Label>
                                        <br />

                    <asp:Label ID="Label7" runat="server" Text="National ID:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtnatID" runat="server" Width="250px" Height="40" ></asp:TextBox>
                    <br />
                                        <asp:Label ID="lblOutnatid" runat="server" style="color:red;font-weight:bold"></asp:Label>
                                        <br />

                    <asp:Label ID="Label8" runat="server" Text="Phone Number:"></asp:Label>

                    &nbsp;<asp:TextBox ID="txtPhone" runat="server" Width="250px" Height="40" ></asp:TextBox>
                    &nbsp;&nbsp;<br />
                    <asp:Label ID="lblOutphone" runat="server" style="color:red;font-weight:bold"></asp:Label>
                    <br>
                <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>


            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


            <asp:TextBox ID="txtemail" runat="server" style="top: 24px; left: 100px; " Width="250px" Height="40"></asp:TextBox>


                    <br />
                    <asp:Label ID="lblOutemail" runat="server" style="color:red;font-weight:bold"></asp:Label>
                    <br />
<asp:Label ID="lblOuput" runat="server" style="color:green;font-weight:bold"></asp:Label>             &nbsp;<br />
                <br />
              


                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="registrationButton" runat="server" Text="registration" OnClick="btnregistration_Click" CssClass="btn-hover color-8" />


  <asp:Button ID="Button12" runat="server" Text="Create Password" OnClick="btnCreatepass_Click" EnableTheming="True" CssClass="btn-hover color-8" Width="181px" />    

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    

                    <br />
                    <br />





    </div>
</asp:Content>
