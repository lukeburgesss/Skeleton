<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProductId" runat="server" Text="Product Id"></asp:Label>
        <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text="Find" />
        <p>
            <asp:Label ID="lblProductName" runat="server" Text="Product Name" width="68px"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkInStock" runat="server" Text="In Stock" />
        <p>
            <asp:Label ID="lblProductQuantity" runat="server" Text="Product Quantity" width="68px"></asp:Label>
            <asp:TextBox ID="txtProductQuantity" runat="server" style="margin-top: 0px"></asp:TextBox>
        </p>
        <asp:Label ID="lblLastAdjustment" runat="server" Text="Last Adjustment" width="68px"></asp:Label>
        <asp:TextBox ID="txtLastAdjustment" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblColour" runat="server" Text="Colour" width="68px"></asp:Label>
            <asp:TextBox ID="txtColour" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="68px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
