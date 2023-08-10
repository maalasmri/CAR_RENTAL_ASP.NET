<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Rent a car.aspx.cs" Inherits="KFMCproject.Rent_a_car" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <p>
&nbsp;
        <br />
       
    <br>
                <br />

            <div class ="pos"  style="text-align: center; direction: ltr;">

                <div style="direction: ltr; width: 718px">


                <br />
                    <asp:DropDownList ID="ddltype" style = "position:relative; left: 295px; top: 101px;" AutoPostBack="true" Width="145px" OnSelectedIndexChanged="revClick" runat="server" CssClass="drop">
            <asp:ListItem Value="">Please Select</asp:ListItem>  
            <asp:ListItem>SEDAN</asp:ListItem>  
            <asp:ListItem>Crossover</asp:ListItem>  
                <asp:ListItem>SUV</asp:ListItem>  
            </asp:DropDownList>     
                               <br />
                    <br />

                    <asp:Label  style = "position:relative; left: -130px; top: 5px;" ID="Label1" runat="server" Text="Select Car:"></asp:Label>

                    <br />
                    <asp:Label ID="lblOselectCar" runat="server" style="color:red;font-weight:bold"></asp:Label>
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="PickUp Date and Time:" ></asp:Label>
                    <asp:TextBox ID="txtPickup" runat="server" TextMode="DateTimeLocal" Width="250px"></asp:TextBox>
                <br />
                                    <asp:Label ID="lblOutPick" runat="server" style="color:red;font-weight:bold"></asp:Label>
                                    <br /> 
                        <asp:Label ID="Label8" runat="server" Text="Return Date and Time:"></asp:Label>
                        <asp:TextBox ID="txtReturn" runat="server" TextMode="DateTimeLocal" Width="250px"></asp:TextBox>
                        <br />
                    <asp:Label ID="lblOutreturn" runat="server" style="color:red;font-weight:bold"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="btnChooseCar" runat="server" Text="Choose"  OnClick ="btnChooseCar_Click " ReadOnly ="true" Enabled="false" CssClass="btn-hover color-8"/>
                <br />
                <br />

                <br />
                    <asp:Label ID="lblOuput" runat="server"></asp:Label>
                    <br />
                    <br />
                    <asp:TextBox ID="txtGridID" style="display: none;" runat="server"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="txtgridPrice" style="display: none;" runat="server"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="txttotalprice" style="display: none;" runat="server"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="txtGridCarname" style="display: none;" runat="server"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="txtGridModel" style="display: none;" runat="server" ></asp:TextBox>
                    <br />
                    <asp:TextBox ID="txtgridType" style="display: none;" runat="server"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="gridviewcarrev" style="display: none;" runat="server"></asp:TextBox>
                    <br />

                <br />

                    <asp:GridView class ="gridviewtable" ID="grcars" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" Width="679px">
                        <Columns>
               
                            <asp:CommandField ShowSelectButton="True" />
                            
                <asp:BoundField DataField="carid" HeaderText="Car ID" SortExpression="carid" />
                <asp:BoundField DataField="carname" HeaderText="Car Name" SortExpression="carname" />
                <asp:BoundField DataField="cartype" HeaderText="Car Type" InsertVisible="False" ReadOnly="True"
                    SortExpression="cartype" />

                <asp:BoundField DataField="model" HeaderText="Model" SortExpression="model" />
                <asp:BoundField DataField="price" HeaderText="Price per day" SortExpression="price" />


                        </Columns>
                        
                      
                        
                        
                    </asp:GridView>
                          <div>
                <br />


           


</asp:Content>
