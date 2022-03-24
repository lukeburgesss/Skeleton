<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeManagementConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="are you sure you want to deletethis record"></asp:Label>
        <p>
            <asp:Button ID="btnyes" runat="server" OnClick="btnyes_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" Text="No" />
        </p>
    </form>
</body>
</html>
