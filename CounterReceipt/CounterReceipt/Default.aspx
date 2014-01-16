<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CounterReceipt.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kassakvitto</title>
    <link rel="stylesheet" href="~/Style2.css">
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
            <header id="header">
                <h1>Kassakvitto</h1>
            </header>
            
            <main>
                <section>
                    <p>Total köpesumma:</p>
                    
                    <p>
                        <asp:TextBox ID="totalCost" runat="server" defaultbutton="calculateDiscount"></asp:TextBox> kr 
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Du måste ange en summa!" Display="Dynamic" ControlToValidate="totalCost" CssClass="field-validation-error"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Ange summan i ett numeriskt värde!" Display="Dynamic" Type="Currency" Operator="DataTypeCheck" ControlToValidate="totalCost" CssClass="field-validation-error"></asp:CompareValidator>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Summan måste vara större än 0!" Type="Currency" Operator="GreaterThan" ValueToCompare="0" CssClass="field-validation-error" ControlToValidate="totalCost"></asp:CompareValidator>       
                    </p>               
                    
                    <p>
                        <asp:Button ID="calculateDiscount" runat="server" Text="Beräkna rabatt" CssClass="standardButton" OnClick="calculateDiscount_Click"></asp:Button>
                    </p>
                </section>
            </main>
        </div>
    </form>
    <script src="scripts.js"></script>
</body>
</html>
