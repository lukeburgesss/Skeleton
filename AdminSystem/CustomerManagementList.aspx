<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 14px; top: 454px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 56px; top: 454px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 567px; position: absolute"></asp:Label>
        <asp:Label ID="lblEnterName" runat="server" style="z-index: 1; left: 10px; top: 501px; position: absolute" Text="Enter a customer name"></asp:Label>
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; top: 535px; position: absolute; left: 68px" Text="Clear" />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; top: 535px; position: absolute; left: 12px" Text="Apply" />
        <asp:ListBox ID="lstCustomerList" runat="server" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" style="z-index: 1; left: 13px; top: 36px; position: absolute; height: 412px; width: 521px"></asp:ListBox>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 98px; top: 455px; position: absolute" Text="Delete" />
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 164px; top: 500px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
