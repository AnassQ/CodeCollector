<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="CodeCollector_MyProject.GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Test GridView - CodeCollector</title>
</head>
<body>
<form id="form1" runat="server">
<asp:GridView CssClass="table table-striped" ID="GridView1" AutoGenerateColumns="False" runat="server">
  <Columns>

      
      <asp:TemplateField Headertext="Product Id">
          <ItemTemplate>
              <asp:Label ID="lblProductId" runat="server"  Text='<%#Eval("ProductId")%>'></asp:Label>
          </ItemTemplate> <!--ProductId its a column in the table Product in DataBase -->
      </asp:TemplateField>

      <asp:TemplateField HeaderText="Product Name">
          <ItemTemplate>
              <asp:Label ID="lblProductName" runat="server"  Text='<%#Eval("ProductName")%>'></asp:Label>
          </ItemTemplate>
      </asp:TemplateField>

      <asp:TemplateField HeaderText="Product Price">
       <ItemTemplate>
              <asp:Label ID="lblProductPrice" runat="server"  Text='<%#Eval("Price")%>'></asp:Label>
          </ItemTemplate>
      </asp:TemplateField>

      //if you wanna add more links
      //MoreDetail.aspx is a simple page aspx 
      <asp:HyperLinkField  DataNavigateUrlFields="ProductId" DataNavigateUrlFormatString="MoreDetail.aspx?id={0}" 
                  Text=" + More " >
      </asp:HyperLinkField>
      
          
      
  </Columns>
</asp:GridView>
 </form>
</body>
</html>

