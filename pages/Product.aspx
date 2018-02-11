<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="pages_Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imgProduct" runat="server" CssClass="detailsImage" />
            </td>
            
            <td><h2><asp:Label ID="lblTitle" runat="server"></asp:Label><hr /></h2></td>
            
            <td></td>
            
        </tr>
         <tr>
            <td><asp:Label ID="lblDiscription" runat="server" CssClass="detailsDescription"></asp:Label></td>
            <td><asp:Label ID="lblPrice" runat="server" cssClass="detailsPrice"></asp:Label></td>
             Quantity :
             <asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList><br />
             <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            <td></td>
        </tr>
         <tr>
             
            <td>Product Number : <asp:Label ID="lblItemNr" runat="server" Text="Label"></asp:Label></td>
             
            
        </tr>
         <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Available" CssClass="productPrice"></asp:Label></td>
        </tr>
    </table>
</asp:Content>

