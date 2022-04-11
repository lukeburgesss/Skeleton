<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerManagementConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 10px; top: 106px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 53px; top: 106px; position: absolute" Text="No" />
        <asp:Label ID="lblErrorQuestion" runat="server" style="z-index: 1; left: 10px; top: 75px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
    </form>
</body>
</html>
