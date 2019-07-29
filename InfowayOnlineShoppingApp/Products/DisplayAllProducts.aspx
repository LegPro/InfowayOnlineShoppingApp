<%@ Page Title="" Language="C#" MasterPageFile="~/ShoppingTemplate.Master" AutoEventWireup="true" CodeBehind="DisplayAllProducts.aspx.cs" Inherits="InfowayOnlineShoppingApp.Products.DisplayAllProducts" ClientIDMode="Static"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" RepeatColumns="2" Width="100%" OnItemCommand="DataList1_ItemCommand">
        <ItemTemplate>
            <div class="container-fluid">
                <div class="row">
                    <div class="col-md-4" >
                        <table class="table" style="height:350px;width:400px;">
                <tr>
                    <td colspan="2" style="text-align:center;">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("ProductImg")%>' style="Width:257px; Height:320px;" />

                    </td>
                </tr>
                <tr>
                    <td>Product Name</td>
                    <td>
                        <asp:Literal ID="litProductName" runat="server" Text='<%#Eval("ProductName") %>'></asp:Literal>
                    </td>
                </tr>
                <tr>
                    <td>Product Price</td>
                    <td>
                        <asp:Literal ID="litPrice" Text='<%#Eval("UnitPrice") %>' runat="server"></asp:Literal>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnViewDetails" CssClass="btn btn-warning" CommandName="View Details" runat="server" Text="View Details" />
                    </td>
                    <td>
                        <asp:Button ID="btnAddToCart" CssClass="btn btn-info" CommandName="Add To Cart" runat="server" Text="Add To Cart" />
                        <asp:HiddenField ID="hiddenProductId" runat="server" Value='<%#Eval("ProductId") %>' />
                    </td>
                </tr>
            </table>
                    </div>
                </div>

            
                    
        </ItemTemplate>
    </asp:DataList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllProducts" TypeName="InfowayOnlineShoppingApp.Dal.ProductDal"></asp:ObjectDataSource>
</asp:Content>
