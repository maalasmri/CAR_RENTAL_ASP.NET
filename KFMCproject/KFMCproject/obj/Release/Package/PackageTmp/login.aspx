<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="KFMCproject.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">





    
    <br>
                <br />

            <div class ="pos"  style="text-align: center; direction: ltr;">


                <br />
                <br />
                <br />

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                
                <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox class="textlabel" ID="txtEmail" runat="server" type="Email" CssClass="newStyle30" style="top: 24px; left: 100px; margin-right: 87px;" Width="250px"></asp:TextBox>

                    <br />
                <asp:Label ID="lblOut" runat="server" style="color:red;font-weight:bold"></asp:Label>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" type="password" CssClass="newStyle10" style="top: 32px; left: 100px; " Width="250px"></asp:TextBox>
                <br />
                <asp:Label ID="lblOut1" runat="server" style="color:red;font-weight:bold"></asp:Label>
                <br />
              


            <asp:Button CssClass="btn-hover color-8" ID="LoginButton" runat="server" Text="Login" OnClick="btnLogin_Click"/>
              

                    <asp:Button CssClass="btn-hover color-8" ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />

                <br />
              

                    <br />
                    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>



                </div>
  
</asp:Content>
