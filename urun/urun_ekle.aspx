<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="urun_ekle.aspx.cs" Inherits="TCRAPP.urun.urun_ekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
       
    <form runat="server">
        <div>
            <asp:TextBox ID="txtUrunAd" runat="server" placeholder="Ürün Adını Tanımlayın" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="txtMarka" runat="server" placeholder="Marka Bilgisini Tanımlayın" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server"  placeholder="Kategori Bilgisini Belirleyin" CssClass="form-control" ></asp:DropDownList>
            
        </div>
        <br />
        <div>
            <asp:TextBox ID="txtGelisFiyat" runat="server" placeholder="Maliyet - Geliş Fiyatı Bilgisi Tanımlayın (Ondalık bilgiler için ',' kullanarak iki tane bilgi girişi yapılabilir)" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="txtSatisFiyat" runat="server" placeholder="Satış - Raf Fiyat Bilgisini Tanımlayın" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="txtStok" runat="server" placeholder="Adet - Stok Bilgisi Tanımlayın" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:Button ID="Button1" runat="server" Text="Ekle" CssClass="btn btn-primary" OnClick="Button1_Click"  />
        </div>
    </form>

</asp:Content>
