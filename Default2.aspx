<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:DetailsView ID="DetailsView2" runat="server" AutoGenerateRows="False" Height="50px" Width="125px">
            <Fields>
                <asp:TemplateField HeaderText="id"></asp:TemplateField>
                <asp:TemplateField HeaderText="fname"></asp:TemplateField>
                <asp:TemplateField HeaderText="lname"></asp:TemplateField>
            </Fields>
        </asp:DetailsView>
    </form>
</body>
</html>
