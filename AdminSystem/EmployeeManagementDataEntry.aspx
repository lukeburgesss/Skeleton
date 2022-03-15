<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="AdRotator1" runat="server" />
        </div>
        <asp:Label ID="lblEmployeeNo" runat="server" Text="Employee Number" width="124px"></asp:Label>
        <asp:TextBox ID="txtEmployeeNo" runat="server" OnTextChanged="txtEmployeeNo_TextChanged"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblEmployeeName" runat="server" Text="Name" width="124px"></asp:Label>
            <asp:TextBox ID="txtEmployeeName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDOB" runat="server" Text="Date Of Birth" width="124px"></asp:Label>
            <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblHouseAddress" runat="server" Text="House Address" width="124px"></asp:Label>
            <asp:TextBox ID="txtHouseAddress" runat="server" OnTextChanged="txtHouseAddress_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblsalary" runat="server" Text="Salary" width="124px"></asp:Label>
            <asp:TextBox ID="txtsalary" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblContractStatus" runat="server" Text="Contract Status"></asp:Label>
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
