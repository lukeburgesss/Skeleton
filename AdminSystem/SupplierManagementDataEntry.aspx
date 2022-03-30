<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="lblError">
            <asp:Label ID="lblSupplierNo" runat="server" Text="Supplier ID" width="129px"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSupplierID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <br />
            <asp:Label ID="SupplierName" runat="server" Text="Supplier Name" width="129px"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="SupplierDateAdded" runat="server" Text="Supplier Date Added"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSupplierDateAdded" runat="server"></asp:TextBox>
            <br />
&nbsp;<br />
            <asp:CheckBox ID="chkArchive" runat="server" Text="Archive" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" style="height: 26px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
