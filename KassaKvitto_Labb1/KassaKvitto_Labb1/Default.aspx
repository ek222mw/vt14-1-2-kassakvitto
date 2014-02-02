<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KassaKvitto_Labb1.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kassa Kvitto</title>
    <link href="Content/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Kassa Kvitto</h1>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Fältet är tomt mata in ett tal" ControlToValidate="sumTextBox"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Mata in ett tal" Type="Double" ControlToValidate="sumTextBox" Operator="GreaterThan" ValueToCompare="0"></asp:CompareValidator>
        </div>
        <p>
            <asp:Label ID="sumLabel" runat="server" Text="Total Köpesumma: "></asp:Label><br />
            <asp:TextBox ID="sumTextBox" runat="server"></asp:TextBox>
            <asp:Label ID="krLabel" runat="server" Text="kr"></asp:Label>
        </p>
        <div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </div>
        <div>
            <asp:Button ID="sendButton" runat="server" Text="Button" OnClick="sendButton_Click"/>
        </div>
      <div>
          <asp:PlaceHolder ID="formPlaceHolder" runat="server" Visible="false">
              <h1>Kvitto</h1>
              <div id="popupdiv">
              <asp:Label ID="subTotalLabel" runat="server" Text=""></asp:Label><br />
              <asp:Label ID="discountLabel" runat="server" Text=""></asp:Label><br />
              <asp:Label ID="moneyOffLabel" runat="server" Text=""></asp:Label><br />
              <asp:Label ID="totalSumLabel" runat="server" Text=""></asp:Label><br />
              </div>
          </asp:PlaceHolder>
      </div>
    </form>
</body>
</html>
