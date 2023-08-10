<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarsEdit.aspx.cs" Inherits="KFMCproject.CarsEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <head></head>
<body>

    <br>
                    <br />
                <br />

            <div class ="pos"  style="text-align: center; direction: ltr;">

                <div style="direction: ltr; width: 626px">
                                        &nbsp;<asp:Label ID="lblOuput" runat="server" style="color:green;font-weight:bold"></asp:Label>                       

                <br />
                <br />
                <br />
 

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 

                <asp:Label ID="Label3" runat="server" Text="ID:"></asp:Label>


            <asp:TextBox ID="txtCarid" runat="server" CssClass="newStyle30" style="top: 24px; left: 100px; " Width="250px"></asp:TextBox>




                    <br />
                    <br />
                <asp:Label ID="Label5" runat="server" Text="Car Name:"></asp:Label>
            <asp:TextBox ID="txtCarname" runat="server" CssClass="newStyle10" style="top: 32px; left: 100px; " Width="250px"></asp:TextBox>
            &nbsp;<br />
                    <br />
                &nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Price: "></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" CssClass="auto-style3" Width="250px"></asp:TextBox>
                    <br />
                <br />
                <asp:Label style = "position:relative; left: -200px; top: 5px;" ID="Label4" runat="server" Text="Car type: "></asp:Label>
            <asp:DropDownList ID="ddltype" runat="server"  CssClass="drop" style = "position:relative; left: 151px; top: -22px;"  Width="150px">
            <asp:ListItem Value="">Please Select</asp:ListItem>  
            <asp:ListItem>SEDAN</asp:ListItem>  
            <asp:ListItem>Crossover</asp:ListItem>  
                <asp:ListItem>SUV</asp:ListItem>  
            </asp:DropDownList>    
            
                <br />
                <br />
                    <asp:Label style = "position:relative; left: 80px; top: -115px;" ID="Label6" runat="server" Text="Model: "></asp:Label>

                                        <asp:Label style = "position:relative; left: -160px; top: -55px;" ID="Label7" runat="server" Text="Car reserved?: "></asp:Label>

                   

            <asp:DropDownList ID="ddlmodel" runat="server" CssClass="drop" style = "position:relative; left: 371px; top: -143px;"  Width="150px">
                <asp:ListItem Value="">Please Select</asp:ListItem>  
            <asp:ListItem>2023</asp:ListItem>  
            <asp:ListItem>2022</asp:ListItem>  
            <asp:ListItem>2021</asp:ListItem>  
            <asp:ListItem>2020</asp:ListItem>  
            <asp:ListItem>2019</asp:ListItem>  
            </asp:DropDownList>
            <asp:DropDownList ID="ddlrev" runat="server" CssClass="drop" style = "position:relative; top: -143px; bottom: 143px; left: 238px;"  Width="150px">
                <asp:ListItem Value="">Car reserved?</asp:ListItem>  
            <asp:ListItem>Yes</asp:ListItem>  
            <asp:ListItem>No</asp:ListItem>  
           
            </asp:DropDownList>


          <asp:Button ID="btnRead" runat="server" OnClick="btnRead_Click" Text="read" CssClass="btn-hover color-8"/>



            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="btn-hover color-8" />
           <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" CssClass="btn-hover color-8"/>
                    <br />
                    <br />
                </div>
&nbsp;
          
         <asp:GridView  CssClass ="gridviewtable" ID="GvcarsEdit" runat="server" AutoGenerateColumns="False"
            DataKeyNames="carid" OnSelectedIndexChanged="gvCars_SelectedIndexChanged" Width="658px">

            <Columns >
                                     <asp:CommandField ShowSelectButton="True" />

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
