<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create_Password.aspx.cs" Inherits="KFMCproject.Create_Password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />

            <div class ="pos"  style="text-align: center; direction: ltr;">

                <div style="direction: ltr; width: 718px; text-align: center;">

                    <br />


                   <br />
                    <br />

                <asp:Label ID="Label6" runat="server" Text="Username:"></asp:Label>


                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


                    <asp:TextBox ID="txtUsrrname" runat="server" Width="250px" Height="40"></asp:TextBox>
                    <br />
                                        <asp:Label ID="lblOutUsername" runat="server" style="color:red;font-weight:normal"></asp:Label>
                                        <br />

                    <asp:Label ID="Label7" runat="server" Text="Password"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtpass" runat="server" Width="250px" Height="40" type="password" ></asp:TextBox>
                    <br />
                                        <asp:Label ID="lblOutpass" runat="server" style="color:red;font-weight:normal"></asp:Label>
                                        <br />

                    <asp:Label ID="Label8" runat="server" Text="Confirm Password:"></asp:Label>

                    &nbsp;<asp:TextBox ID="txtconfpass" runat="server" Width="250px" Height="40" type="password"></asp:TextBox>
                    &nbsp;&nbsp;<br />
                    <asp:Label ID="lblOutconform" runat="server" style="color:red;font-weight:normal"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                
                    <br />
                    <br />
                    &nbsp;<asp:Label ID="lblOuput" runat="server" style="color:green;font-weight:bold"></asp:Label>                       

            &nbsp;<br />
                <br />



            <asp:Button ID="createpassButton" runat="server" Text="createpass" OnClick="btnCreate_Click" CssClass="btn-hover color-8" />


                    <br />
                    <br />





    </div>
</asp:Content>
