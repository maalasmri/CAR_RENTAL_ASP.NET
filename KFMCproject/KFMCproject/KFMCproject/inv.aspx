<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="inv.aspx.cs" Inherits="KFMCproject.inv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <head>




    </head>

    <p>
&nbsp;
        <br />
       
    <br>
                <br />

            <div class ="pos"  style="text-align: center; direction: ltr;">

                <div style="direction: ltr; width: 718px; text-align: left;">


                    <br />


                    <br />
                    <asp:Label ID="Label18" runat="server" Text="Car id"></asp:Label>
                    <asp:TextBox ID="invcarid" runat="server"></asp:TextBox>
                    <asp:Label ID="Label11" runat="server" Text="CarName"></asp:Label>
                    <asp:TextBox ID="invCarname" runat="server"></asp:TextBox>
                    <asp:Label ID="Label7" runat="server" Text="Cartype"></asp:Label>
                    <asp:TextBox ID="invCartype" runat="server"></asp:TextBox>
                    <br>
                    <asp:Label ID="Label8" runat="server" Text="Car Model"></asp:Label>
                    <asp:TextBox ID="invModelcar" runat="server"></asp:TextBox>
                   <asp:Label ID="Label9" runat="server" Text="Car Price per Day"></asp:Label>
                   
                    <asp:TextBox ID="invPD" runat="server"></asp:TextBox>


                    <asp:Label ID="Label10" runat="server" Text="Total price"></asp:Label>
                    <asp:TextBox ID="invTP" runat="server"></asp:TextBox>
                   <br> 


                <br />
           
                   <asp:Label ID="Label12" runat="server" Text="pickup Date andTime"></asp:Label>
                   
                    <asp:TextBox ID="invpickup" runat="server"></asp:TextBox>
                   <asp:Label ID="Label13" runat="server" Text="Return Date andTime"></asp:Label>
                   
                    <asp:TextBox ID="invreturn" runat="server"></asp:TextBox>
           
                    <br />
                    <br />
                    -------------------------------------------------------------------------------------<br />
                    <asp:Label ID="Label14" runat="server" Text="Booking id"></asp:Label>
                    <asp:TextBox ID="invbooking" runat="server" style="margin-bottom: 1px"></asp:TextBox>
                    <asp:Label ID="Label19" runat="server" Text="Customer ID:"></asp:Label>
                    <asp:TextBox ID="invCustomerid" runat="server"></asp:TextBox>
                    <asp:Label ID="Label15" runat="server" Text="Customer Name"></asp:Label>
                    <asp:TextBox ID="invCustomer" runat="server"></asp:TextBox>
                    <asp:Label ID="Label16" runat="server" Text="Phone Number"></asp:Label>
                    <asp:TextBox ID="invPhone" runat="server"></asp:TextBox>
                <br />
                                    <asp:Label ID="Label17" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="invEmail" runat="server"></asp:TextBox>
                                    <br /> 
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="rentclick"/>
                        <br />
                    <br />
                    <asp:Label ID="Label6" runat="server" style="display: none;" Text="Label"></asp:Label>
                    <asp:Label ID="gen" runat="server" Text="Label"></asp:Label>
                    <br />
           
                    <asp:TextBox ID="invrev" runat="server"></asp:TextBox>
           
                    <br />
                    <br />

                    <asp:Label ID="Label21" runat="server"></asp:Label>
                                       <br>
                    <asp:Label ID="Label20" runat="server"></asp:Label>

                <br />
                   


           

</asp:Content>
