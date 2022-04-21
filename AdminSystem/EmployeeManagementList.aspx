<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstEmployeeList" runat="server" Width="100px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <asp:Label ID="Label1" runat="server" Text="Enter a Name"></asp:Label>
        <asp:TextBox ID="txtfilter" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="BtnApply" runat="server" OnClick="BtnApply_Click" Text="apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="clear" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
