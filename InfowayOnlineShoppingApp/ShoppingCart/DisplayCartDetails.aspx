<%@ Page Title="" Language="C#" MasterPageFile="~/ShoppingTemplate.Master" AutoEventWireup="true" CodeBehind="DisplayCartDetails.aspx.cs" Inherits="InfowayOnlineShoppingApp.ShoppingCart.DisplayCartDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="scripts/particle/stylesheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    
    <div id="particles-js">

        <h1>CArts Details</h1>
       <table class="table table-bordered">
         <asp:Repeater ID="purchasedProductDisplay" runat="server">
            
            <HeaderTemplate>
                
                     <tr>
                        <th>Product ID</th>
                        <th>Product Name</th>
                        <th>Qty</th>
                        <th>Unit Price</th>
                    </tr>
                   
                
            </HeaderTemplate>
            
            <ItemTemplate>
                
                    <tr>
                        <td>
                            <asp:Literal ID="litProductId" runat="server" Text='<%#Eval("ProductId") %>' ></asp:Literal>
                        </td>
                        <td>
                            <asp:Literal ID="litProductName" runat="server" Text='<%#Eval("ProductName") %>'></asp:Literal>
                        </td>
                        <td>
                            <asp:Literal ID="litQty" runat="server" Text='<%#Eval("Qty") %>'></asp:Literal>
                        </td>
                        <td>
                            <asp:Literal ID="litUnitPrice" runat="server" Text='<%#Eval("UnitPrice") %>'></asp:Literal>
                        </td>
                    </tr>
                

            </ItemTemplate>
            <FooterTemplate>
                <tr>
                    <td></td>
                    <td></td>
                    <th>Total</th>
                    <td ><%ShowTotal(); %></td>
           </tr>
            </FooterTemplate>
        </asp:Repeater>
           
           </table>

    </div>
    <script type="text/javascript" src="scripts/particle/particles.js"></script>
    <script type="text/javascript" src="scripts/particle/app.js"></script>
</asp:Content>
