<%@ Page Title="" Language="C#" MasterPageFile="~/ShoppingTemplate.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="InfowayOnlineShoppingApp.Products.ProductDetails"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../scripts/particle/stylesheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    
    <div id="particles-js">


        <asp:DetailsView ID="productDetailsView" runat="server" Height="100%" Width="100%" AutoGenerateRows="False" DataSourceID="ObjectDataSource1">
            <Fields>
                <asp:BoundField DataField="ProductId" HeaderText="Product Id" />
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                <asp:BoundField DataField="ProductCompanyName" HeaderText="Company Name" />
                <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" />
                <asp:BoundField DataField="AvailableQuantity" HeaderText="Products in Stock" />
                <asp:ImageField DataImageUrlField="ProductImg" HeaderText="Image">
                </asp:ImageField>
            </Fields>
            

        </asp:DetailsView>




        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllProducts" TypeName="InfowayOnlineShoppingApp.Dal.ProductDal">
            <SelectParameters>
                <asp:QueryStringParameter Name="productId" QueryStringField="id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>




    </div>
    <script type="text/javascript" src="../scripts/particle/particles.js"></script>
    <script type="text/javascript" src="../scripts/particle/app.js"></script>
    
    
</asp:Content>
