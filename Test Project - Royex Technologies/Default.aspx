<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Test_Project___Royex_Technologies.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Show Salary with Bonus</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="Scripts/WebForms/Script.js"></script>
    <style>
        .employee-row td:nth-child(4) {
            font-weight: bold;
        }

        .highlight-salary {
            color: green;
        }

        .highlight-name {
            color: blue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
            <h2>Show Salary with Bonus</h2>
            <div class="form-group">
                <label for="txtEmployeeId">Employee ID:</label>
                <asp:TextBox ID="txtEmployeeId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="btnShowSalary" runat="server" Text="Show Salary with Bonus" CssClass="btn btn-primary" OnClick="btnShowSalary_Click" />
            <asp:Button ID="btnHighlightSalary" runat="server" Text="Highlight Salary" CssClass="btn btn-success" OnClientClick="highlightSalary(); return false;" />
            <asp:Button ID="btnHighlightName" runat="server" Text="Highlight Name" CssClass="btn btn-info" OnClientClick="highlightName(); return false;" />
            <br />
            <br />
            <%-- <asp:GridView ID="gvEmployees" runat="server" CssClass="table table-bordered table-striped">
            </asp:GridView>--%>
            <asp:GridView ID="gvEmployees" runat="server" CssClass="table table-bordered table-striped">
                <RowStyle CssClass="employee-row" />
            </asp:GridView>
        </div>
        <div id="validationModal" class="modal fade" tabindex="-1" role="dialog">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Validation Error</h4>
                    </div>
                    <div class="modal-body">
                        <p>Please provide a valid employee ID.</p>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
