﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstSupplierList" runat="server" OnSelectedIndexChanged="lstSupplierList_SelectedIndexChanged"></asp:ListBox>
        </div>
    </form>
</body>
</html>
