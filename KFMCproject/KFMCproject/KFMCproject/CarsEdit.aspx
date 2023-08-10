<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarsEdit.aspx.cs" Inherits="KFMCproject.CarsEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <head></head>
<body>

    <br>
                    <br />
                <br />
                <br />

            <div class ="pos"  style="text-align: center; direction: ltr;">

                <div style="direction: ltr; width: 626px">

                <br />
                <br />
                <br />

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:Label ID="Label3" runat="server" Text="ID"></asp:Label>


            <asp:TextBox ID="TextBox2" runat="server" CssClass="newStyle30" style="top: 24px; left: 100px; " Width="150px" Height="19px"></asp:TextBox>


                    <asp:Button ID="Button1" OnClick="get_Click" runat="server" Text="GetInfo" />


          <asp:Button ID="btnRead" runat="server" OnClick="btnRead_Click" Text="read" CssClass="newStyle28" Width="48px"/>


                    <br />
                    <br />
                <asp:Label ID="Label5" runat="server" Text="CarName:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="newStyle10" style="top: 32px; left: 100px; " Width="150px"></asp:TextBox>
            &nbsp;<br />
                    <br />
                <asp:Label ID="Label2" runat="server" Text="Price: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3" Width="150px"></asp:TextBox>
                    <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Car type: "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="newStyle4">
            <asp:ListItem Value="">Please Select</asp:ListItem>  
            <asp:ListItem>SEDAN</asp:ListItem>  
            <asp:ListItem>Crossover</asp:ListItem>  
                <asp:ListItem>SUV</asp:ListItem>  
            </asp:DropDownList>    
            
                <br />
                <br />
                    <asp:Label ID="Label6" runat="server" Text="Model: "></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="newStyle5 auto-style2">
                <asp:ListItem Value="">Please Select</asp:ListItem>  
            <asp:ListItem>2023</asp:ListItem>  
            <asp:ListItem>2022</asp:ListItem>  
            <asp:ListItem>2021</asp:ListItem>  
            <asp:ListItem>2020</asp:ListItem>  
            <asp:ListItem>2019</asp:ListItem>  
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList3" runat="server" CssClass="newStyle29">
                <asp:ListItem Value="">Car reserved?</asp:ListItem>  
            <asp:ListItem>Yes</asp:ListItem>  
            <asp:ListItem>No</asp:ListItem>  
           
            </asp:DropDownList>
                <br />
                <br />



            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="newStyle19 auto-style10" />
           <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" CssClass="newStyle24 auto-style13"/>
                    <br />
                    <br />
                </div>
                <div class ="gird" style="text-align: center; width: 509px">
&nbsp;
          
         <asp:GridView  ID="gvCars" runat="server" AutoGenerateColumns="False"
            DataKeyNames="carid" CssClass="newStyle18 auto-style9">
            <Columns >
         
                <asp:BoundField DataField="carid" HeaderText="Car ID" SortExpression="carid" />
                <asp:BoundField DataField="carname" HeaderText="Car Name" SortExpression="carname" />
                <asp:BoundField DataField="cartype" HeaderText="Car Type" InsertVisible="False" ReadOnly="True"
                    SortExpression="cartype" />
                <asp:BoundField DataField="carreserved" HeaderText="Car Reserved" SortExpression="carreserved" />
                <asp:BoundField DataField="model" HeaderText="Model" SortExpression="model" />
                <asp:BoundField DataField="price" HeaderText="Price per day" SortExpression="price" />
            </Columns>
        </asp:GridView>
                </div>
                <br />
          
       </div>
          
            <br />
            <br />

            
</body>
           <asp:Label ID="Label1" runat="server" ></asp:Label>

</asp:Content>
