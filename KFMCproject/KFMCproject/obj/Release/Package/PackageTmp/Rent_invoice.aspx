<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Rent_invoice.aspx.cs" Inherits="KFMCproject.Rent_invoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   

&nbsp;
    <div ID ="email">
<body style="background-color:#e2e1e0;font-family: Open Sans, sans-serif;font-size:100%;font-weight:400;line-height:1.4;color:#000;">

   <table id="rentColor" style="width:800px;margin:10px auto 100px;background-color:#fff;padding:50px;-webkit-border-radius:3px;-moz-border-radius:3px;border-radius:3px;-webkit-box-shadow:0 1px 3px rgba(0,0,0,.12),0 1px 2px rgba(0,0,0,.24);-moz-box-shadow:0 1px 3px rgba(0,0,0,.12),0 1px 2px rgba(0,0,0,.24);box-shadow:0 1px 3px rgba(0,0,0,.12),0 1px 2px rgba(0,0,0,.24); border-top: solid 10px green;"><thead>
            <tr>
                <th style="text-align:left;">&nbsp;</th>
                <th style="text-align:right;font-weight:400;"><asp:Label ID="labledate" runat="server"></asp:Label></th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td style="height:35px;"></td>
            </tr>
            <tr>
                <td colspan="2" style="border: solid 1px #ddd; padding:10px 20px;">
                    <p style="font-size:18px;margin:0 0 6px 0;"><b style="color:green;font-weight:normal;margin:0; font-size:20px;"><asp:Label ID="lbloutemail" runat="server"></asp:Label></b></p>
                    <p style="font-size:18px;margin:0 0 6px 0;"><span style="font-weight:bold;display:inline-block;min-width:150px">Order status</span><b style="color:green;font-weight:normal;margin:0; font-size:20px;"><asp:Label ID="Label20" runat="server"></asp:Label></b></p>
                    <p style="font-size:18px;margin:0 0 6px 0;"><span style="font-weight:bold;display:inline-block;min-width:146px">Booking ID:</span><asp:Label ID="invbooking" runat="server"></asp:Label></p>
                    <p style="font-size:18px;margin:0 0 0 0;"><span style="font-weight:bold;display:inline-block;min-width:146px">Total price</span><asp:Label ID="invTP" runat="server"></asp:Label>SR</p>

                    </td>
            </tr>
            <tr>
                <td style="height:35px;"></td>
            </tr>
            <tr>
                <td style="width:50%;padding:20px;vertical-align:top; height: 111px;">
                    <p style="margin:0 0 10px 0;padding:0;font-size:14px;"><span style="display:block;font-weight:bold;font-size:16px">Name</span><asp:Label ID="invCustomer" runat="server"></asp:Label></p>
                    <p style="margin:0 0 10px 0;padding:0;font-size:14px;"><span style="display:block;font-weight:bold;font-size:16px;">Phone</span><asp:Label ID="invPhone" runat="server"></asp:Label></p>
                    <p style="margin:0 0 10px 0;padding:0;font-size:14px;"><span style="display:block;font-weight:bold;font-size:16px;">ID No.</span><asp:Label ID="invCustomerid" runat="server"></asp:Label>
</p>
                </td>
                <td style="width:50%;padding:20px;vertical-align:top; height: 111px;">
                                        <p style="margin:0 0 10px 0;padding:0;font-size:14px;"><span style="display:block;font-weight:bold;font-size:16px;">Email</span><asp:Label ID="invEmail" runat="server"></asp:Label></p>

                  <p style="margin:0 0 10px 0;padding:0;font-size:14px;"><span style="display:block;font-weight:bold;font-size:16px">pickup Date and Time</span><asp:Label ID="invpickup" runat="server"></asp:Label></p>
                   <p style="margin:0 0 10px 0;padding:0;font-size:14px;"><span style="display:block;font-weight:bold;font-size:16px;">Return Date and Time</span><asp:Label ID="invreturn" runat="server"></asp:Label></p>
                   <p style="margin:0 0 10px 0;padding:0;font-size:14px;"><span style="display:block;font-weight:bold;font-size:16px;">Total Days</span><asp:Label ID="invdays" runat="server"></asp:Label></p>

                </td>
            </tr>
            <tr>
                <td colspan="2" style="font-size:20px;padding:30px 15px 0 15px; height: 42px;">Rent Car</td>
            </tr>
            <tr>
                <td colspan="2" style="padding:15px;">
                    <p style="font-size:14px;margin:0;padding:10px;border:solid 1px #ddd;font-weight:bold;"><span style="display:block;font-size:16px;font-weight:normal;">Car ID:</span> <asp:Label ID="invcarid" runat="server"></asp:Label></p>
                    <p style="font-size:14px;margin:0;padding:10px;border:solid 1px #ddd;font-weight:bold;"><span style="display:block;font-size:16px;font-weight:normal;">Car Name:</span><asp:Label ID="invCarname" runat="server"></asp:Label></p>
                    <p style="font-size:14px;margin:0;padding:10px;border:solid 1px #ddd;font-weight:bold;"><span style="display:block;font-size:16px;font-weight:normal;">Car Type</span><asp:Label ID="invCartype" runat="server"></asp:Label></p>
                    <p style="font-size:14px;margin:0;padding:10px;border:solid 1px #ddd;font-weight:bold;"><span style="display:block;font-size:13px;font-weight:normal;">Car Model</span> <asp:Label ID="invModelcar" runat="server"></asp:Label></p>
                                   <p style="font-size:14px;margin:0;padding:10px;border:solid 1px #ddd;font-weight:bold;"><span style="display:block;font-size:13px;font-weight:normal;">price per day</span><asp:Label ID="invPD" runat="server"></asp:Label></p>
                             <asp:Button CssClass="btn-hover color-8" ID="Rent" runat="server" Text="Rent" OnClick="btnRent_click"/>

                    </td>
            </tr>
        </tbody>

</body>
    <br>
                        <asp:TextBox ID="invrev" runat="server" style="display: none;"></asp:TextBox>



</asp:Content>
