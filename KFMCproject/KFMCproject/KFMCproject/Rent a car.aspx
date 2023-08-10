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
                    <asp:Label ID="Label1" runat="server" Text="Select Car"></asp:Label>
                    <asp:DropDownList ID="DropDown" AutoPostBack="true" OnSelectedIndexChanged="revClick" runat="server" CssClass="newStyle29">
            <asp:ListItem Value="">Please Select</asp:ListItem>  
            <asp:ListItem>SEDAN</asp:ListItem>  
            <asp:ListItem>Crossover</asp:ListItem>  
                <asp:ListItem>SUV</asp:ListItem>  
            </asp:DropDownList>     
           
                    <br />
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="pickup Date and Time"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
                <br />
                                    <br /> 
                        <asp:Label ID="Label8" runat="server" Text="Return Date and Time"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
                        <br />
                    <asp:Button ID="Button1" runat="server" Text="Choose"  OnClick ="diffclick " ReadOnly ="true" Enabled="false"/>
                <br />
                <br />

                <br />
                    <asp:Label ID="Label9" runat="server" style="display: none;"></asp:Label>
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox3" style="display: none;" runat="server"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox4" style="display: none;" runat="server"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="totalprice" style="display: none;" runat="server"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="gridviewCarname" style="display: none;" runat="server"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="gridviewModel" style="display: none;" runat="server" ></asp:TextBox>
                    <br />
                    <asp:TextBox ID="gridviewtype" style="display: none;" runat="server"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="gridviewcarrev" runat="server"></asp:TextBox>
                    <br />

                <br />
                    <asp:GridView ID="grcars" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" Width="382px">
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
                <br />


           


</asp:Content>
