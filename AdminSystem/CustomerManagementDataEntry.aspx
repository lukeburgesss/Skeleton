<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerNo" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Customer Number" width="171px"></asp:Label>
        <asp:TextBox ID="txtCustomerNo" runat="server" style="z-index: 1; left: 184px; top: 33px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 10px; top: 72px; position: absolute" Text="Customer Name" width="171px"></asp:Label>
        <asp:Label ID="lblCustomerContactNo" runat="server" style="z-index: 1; left: 10px; top: 109px; position: absolute; width: 171px" Text="Customer Contact Number"></asp:Label>
        <asp:Label ID="lblDeliveryAddr" runat="server" style="z-index: 1; left: 10px; top: 143px; position: absolute" Text="Delivery Address" width="171px"></asp:Label>
        <asp:Label ID="lblCustomerDob" runat="server" style="z-index: 1; left: 10px; top: 179px; position: absolute" Text="Customer Date of Birth" width="171px"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 184px; top: 70px; position: absolute; bottom: 473px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerContactNo" runat="server" style="z-index: 1; left: 184px; top: 108px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDeliveryAddr" runat="server" style="z-index: 1; left: 184px; top: 141px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerDob" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 184px; top: 177px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkAccountStatus" runat="server" style="z-index: 1; left: 12px; top: 214px; position: absolute" Text="Account Status" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 244px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" height="26px" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 277px; position: absolute; right: 1426px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 49px; top: 277px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
