<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Customers.aspx.cs" Inherits="TaxiOffice.Customers" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .form-group {
            margin-bottom: 10px;
        }

            .form-group label {
                display: inline-block;
                width: 150px;
                font-weight: bold;
            }

            .form-group input[type="text"] {
                width: 250px;
                padding: 5px;
                border: 1px solid #ccc;
                border-radius: 3px;
            }
    </style>

    <div>
        <asp:GridView ID="CustomersGridView" runat="server" Caption="Customers" OnDataBinding="CustomersGridView_DataBinding"></asp:GridView>
    </div>
    <div class="form-group">
        <asp:Label ID="lblCustomerName" runat="server" Text="Name:" AssociatedControlID="tbCustomerName"></asp:Label>
        <asp:TextBox ID="tbCustomerName" runat="server" ToolTip="Enter Customer Name"></asp:TextBox>
    </div>

    <div class="form-group">
        <asp:Label ID="lblPaymentMethod" runat="server" Text="Payment Method:" AssociatedControlID="tbPaymentMethod"></asp:Label>
        <asp:TextBox ID="tbPaymentMethod" runat="server"></asp:TextBox>
    </div>

    <div class="form-group">
        <asp:Label ID="lblPhone" runat="server" Text="Phone:" AssociatedControlID="tbPhone"></asp:Label>
        <asp:TextBox ID="tbPhone" runat="server"></asp:TextBox>
    </div>

    <div class="form-group">
        <asp:Label ID="lblEmail" runat="server" Text="Email:" AssociatedControlID="tbEmail"></asp:Label>
        <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
    </div>

    <div class="form-group">
        <asp:Label ID="lblAddress" runat="server" Text="Address:" AssociatedControlID="tbAddress"></asp:Label>
        <asp:TextBox ID="tbAddress" runat="server"></asp:TextBox>
    </div>

    <div class="form-group">
        <asp:Label ID="lblZip" runat="server" Text="Zip:" AssociatedControlID="tbZip"></asp:Label>
        <asp:TextBox ID="tbZip" runat="server"></asp:TextBox>
    </div>

    <div class="form-group">
        <asp:Label ID="lblCity" runat="server" Text="City:" AssociatedControlID="tbCity"></asp:Label>
        <asp:TextBox ID="tbCity" runat="server"></asp:TextBox>
    </div>

    <div class="form-group">
        <asp:Label ID="lblDefaultPickupAddress" runat="server" Text="Default Pickup Address:" AssociatedControlID="tbDefaultPickupAddress"></asp:Label>
        <asp:TextBox ID="tbDefaultPickupAddress" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click"></asp:Button>
    </div>

</asp:Content>
