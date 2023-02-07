<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="satis_yap.aspx.cs" Inherits="TCRAPP.satis.satis_yap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" >
    Ürün Seçin 
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server"  CssClass="form-control" ></asp:DropDownList>
    </div>
    <br />  
    Personel Seçin
     <div>
        <asp:DropDownList ID="DropDownList2" runat="server"  CssClass="form-control" ></asp:DropDownList>
    </div>
    <br /> 
    Müşteri Seçin
     <div>
        <asp:DropDownList ID="DropDownList3" runat="server"  CssClass="form-control" ></asp:DropDownList>
    </div>
    <br /> 
    Fiyat
    <div>
        <asp:TextBox ID="txtSatisFiyat" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Button ID="Button1" runat="server" Text="Satış Yap" CssClass="btn btn-success" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Vazgeç" CssClass="btn btn-danger" />
    </div>
    </form>
    
</asp:Content>
