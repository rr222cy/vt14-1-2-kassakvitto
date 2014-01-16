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
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Ange en summa som är större än 0!" Display="Dynamic" Type="Currency" Operator="DataTypeCheck" ControlToValidate="totalCost" CssClass="field-validation-error"></asp:CompareValidator>                       
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
