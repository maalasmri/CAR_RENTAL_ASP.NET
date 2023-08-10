<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarsAdd.aspx.cs" Inherits="KFMCproject.CarsAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<body>



    <br>
                    <br />
                <br />
                <br />

            <div class ="pos"  style="text-align: center; width: 690px; height: 800px;">

                <div style="direction: ltr; width: 690px; height: 503px;">

                <br />

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:Label ID="Label3" runat="server" Text="ID:"></asp:Label>


            <asp:TextBox ID="txtIdAdd" runat="server" CssClass="newStyle30" Width="250px" left ="100px" ></asp:TextBox>


                    <br />
                    <asp:Label ID="lblOutcarid" runat="server" style="color:red;font-weight:normal"></asp:Label>
                    <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Text="Car Name:"></asp:Label>
            <asp:TextBox ID="txtNameAdd" runat="server" type="Text" CssClass="newStyle10" style="top: 32px; left: 100px; " Width="250px" ></asp:TextBox>
            &nbsp;<br />
                    <asp:Label ID="lblOutcarname" runat="server" style =" color:red;font-weight:normal"></asp:Label>
                    
                  
                    <br />
            
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Label ID="Label2" runat="server" Text="Price: "></asp:Label>
            <asp:TextBox ID="txtpriceAdd" runat="server" CssClass="auto-style3" Width="250px" ></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblOutprice" runat="server" style =" color:red;font-weight:normal"></asp:Label>
                  
                    <br />
            <asp:DropDownList ID="ddltype" runat="server"  CssClass="drop" style = "position:relative; left: 184px; top: 20px;"  Width="150px">
            <asp:ListItem  Value="">Please Select</asp:ListItem>  
            <asp:ListItem  >SEDAN</asp:ListItem>  
            <asp:ListItem >Crossover</asp:ListItem>  
                <asp:ListItem>SUV</asp:ListItem>  
            </asp:DropDownList>
            
                    <asp:Label  style = "position:relative; left: -200px; top: -30px;" ID="Label6" runat="server" Text="Model:"></asp:Label>
                    <br />
            
            <asp:DropDownList ID="ddlModel" runat="server" style = "position:relative; left: 422px; top: -60px;" CssClass="drop" Width="150px">
                <asp:ListItem Value="">Please Select</asp:ListItem>  
            <asp:ListItem>2023</asp:ListItem>  
            <asp:ListItem>2022</asp:ListItem>  
            <asp:ListItem>2021</asp:ListItem>  
            <asp:ListItem>2020</asp:ListItem>  
            <asp:ListItem>2019</asp:ListItem>  
            </asp:DropDownList>


                <asp:Label style = "position:relative; left: 40px; top: -110px;" ID="Label4" runat="server" Text="Car type: "></asp:Label>


                    <br />



            <asp:Button ID="Button1" runat="server" OnClick="BtnCreate_Click" Text="Create" CssClass="btn-hover color-8"/>            
          <asp:Button ID="btnRead" runat="server" OnClick="btnRead_Click" Text="read" CssClass="btn-hover color-8"/>
            <asp:Button ID="Button2" runat="server" Text="Export" OnClick="btnExport_Click" CssClass="btn-hover color-8"/>
                       <asp:Label ID="lblOuput1" runat="server" style="color:red;font-weight:normal;margin:0"></asp:Label>
                    <br />
                    <br />
                 

                </div>
&nbsp;<asp:Label ID="lblOuput" runat="server" style="color:green;font-weight:bold"></asp:Label>                       
                       &nbsp;<asp:GridView  CssClass ="gridviewtable" ID="gvCars" runat="server" AutoGenerateColumns="False"
            DataKeyNames="carid" OnSelectedIndexChanged="gvCars_SelectedIndexChanged" Width="636px">
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
            </asp:Content>
