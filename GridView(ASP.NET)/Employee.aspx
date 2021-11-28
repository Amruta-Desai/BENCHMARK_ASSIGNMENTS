<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="DBControls.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="empno" DataSourceID="SqlDataSource2" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="empno" HeaderText="empno" ReadOnly="True" SortExpression="empno" />
                <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
                <asp:BoundField DataField="designation" HeaderText="designation" SortExpression="designation" />
                <asp:BoundField DataField="mgrid" HeaderText="mgrid" SortExpression="mgrid" />
                <asp:BoundField DataField="deptno" HeaderText="deptno" SortExpression="deptno" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeDBConnectionString2 %>" SelectCommand="SELECT * FROM [Employee]" InsertCommand="InsertEmployee" InsertCommandType="StoredProcedure" UpdateCommand="UpdateEmployee" UpdateCommandType="StoredProcedure" DeleteCommand="DeleteEmpUsingEmpno" DeleteCommandType="StoredProcedure" ></asp:SqlDataSource>
        
        <asp:FormView ID="FormView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="empno" DataSourceID="SqlDataSource2" GridLines="Horizontal">
            <EditItemTemplate>
                empno:
                <asp:Label ID="empnoLabel1" runat="server" Text='<%# Eval("empno") %>' />
                <br />
                ename:
                <asp:TextBox ID="enameTextBox" runat="server" Text='<%# Bind("ename") %>' />
                <br />
                salary:
                <asp:TextBox ID="salaryTextBox" runat="server" Text='<%# Bind("salary") %>' />
                <br />
                designation:
                <asp:TextBox ID="designationTextBox" runat="server" Text='<%# Bind("designation") %>' />
                <br />
                mgrid:
                <asp:TextBox ID="mgridTextBox" runat="server" Text='<%# Bind("mgrid") %>' />
                <br />
                deptno:
                <asp:TextBox ID="deptnoTextBox" runat="server" Text='<%# Bind("deptno") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <EditRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <InsertItemTemplate>
                empno:
                <asp:TextBox ID="empnoTextBox" runat="server" Text='<%# Bind("empno") %>' />
                <br />
                ename:
                <asp:TextBox ID="enameTextBox" runat="server" Text='<%# Bind("ename") %>' />
                <br />
                salary:
                <asp:TextBox ID="salaryTextBox" runat="server" Text='<%# Bind("salary") %>' />
                <br />
                designation:
                <asp:TextBox ID="designationTextBox" runat="server" Text='<%# Bind("designation") %>' />
                <br />
                mgrid:
                <asp:TextBox ID="mgridTextBox" runat="server" Text='<%# Bind("mgrid") %>' />
                <br />
                deptno:
                <asp:TextBox ID="deptnoTextBox" runat="server" Text='<%# Bind("deptno") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                empno:
                <asp:Label ID="empnoLabel" runat="server" Text='<%# Eval("empno") %>' />
                <br />
                ename:
                <asp:Label ID="enameLabel" runat="server" Text='<%# Bind("ename") %>' />
                <br />
                salary:
                <asp:Label ID="salaryLabel" runat="server" Text='<%# Bind("salary") %>' />
                <br />
                designation:
                <asp:Label ID="designationLabel" runat="server" Text='<%# Bind("designation") %>' />
                <br />
                mgrid:
                <asp:Label ID="mgridLabel" runat="server" Text='<%# Bind("mgrid") %>' />
                <br />
                deptno:
                <asp:Label ID="deptnoLabel" runat="server" Text='<%# Bind("deptno") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
            </ItemTemplate>
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
        </asp:FormView>
        
        <div>
        </div>
    </form>
</body>
</html>
