<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="~/Content/style.css" rel="stylesheet" />
</head>
<body>
    <header class="header">
        <h1>Kassa Kvitto</h1>
    </header>
    <form id="form1" runat="server">
        <div>
            <p>Total Köpsumma:</p>
            <asp:TextBox ID="MyTextBox" runat="server"></asp:TextBox><p>kr</p>
            <asp:CompareValidator ID="MyCompareValidator" runat="server" ErrorMessage="Måste vara ett tal som är större än 0" ControlToValidate="MyTextBox" Operator="GreaterThan" ValueToCompare="0" Type="Double" Display="Dynamic"></asp:CompareValidator>
            <asp:RequiredFieldValidator ID="MyRequiredFieldValidator" runat="server" ErrorMessage="Ange en total köpesumma" ControlToValidate="MyTextBox" Display="Dynamic"></asp:RequiredFieldValidator>
            <p id="bottom">
                <asp:Button ID="SubmitButton" runat="server" Text="Beräkna rabatt" OnClick="SubmitButton_Click" />
            </p>
        </div>
    </form>
    <asp:Panel ID="RecieptPanel" runat="server" Visible="false">
        <p>
            <asp:Label ID="SubtotalLabel" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="DiscountRateLabel" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="DiscountLabel" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="TotalLabel" runat="server" Text="Label"></asp:Label>
        </p>
    </asp:Panel>
</body>
</html>
