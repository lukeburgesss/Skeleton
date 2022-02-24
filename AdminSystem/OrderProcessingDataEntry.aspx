﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblProductID" runat="server" Text="Product ID " width="176px"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;<br />
        <asp:Label ID="lblTotalProduct" runat="server" Text="Total Product " width="176px"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:CheckBox ID="chkOrderIsPaid" runat="server" Text="Order Is Paid" />
        <br />
        <br />
        <asp:Label ID="lblOrderCreationDate" runat="server" Text="Order Creaction Date "></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblOrderName" runat="server" Text="Order Name " width="176px"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="[lblError] "></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK " />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel " />
    </form>
</body>
</html>
