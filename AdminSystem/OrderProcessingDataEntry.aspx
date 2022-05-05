<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    hello this is the order entry page
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderId" runat="server" Text="Order Id " width="176px"></asp:Label>
        <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="height: 26px" Text="Find" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblProductID" runat="server" Text="Product ID " width="176px"></asp:Label>
        <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;<br />
        <asp:Label ID="lblTotalProduct" runat="server" Text="Total Product " width="176px"></asp:Label>
        <asp:TextBox ID="txtTotalProduct" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:CheckBox ID="chkOrderIsPaid" runat="server" Text="Order Is Paid" />
        <br />
        <br />
        <asp:Label ID="lblOrderCreationData" runat="server" Text="Order Creaction Data"></asp:Label>
        <asp:TextBox ID="txtOrderCreationData" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblOrderName" runat="server" Text="Order Name " width="176px"></asp:Label>
        <asp:TextBox ID="txtOrderName" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="[lblError] "></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK " />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel " OnClick="btnCancel_Click" />
    </form>
</body>
</html>
