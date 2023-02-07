<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="kategori_guncelle.aspx.cs" Inherits="TCRAPP.kategori_guncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server">
        <div>
            <asp:TextBox ID="txtId" runat="server" CssClass="form-control" Enabled="false" ></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="txtAd" runat="server" placeholder="Kategori Adını Tanımlayın" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="Button1_Click" />
        </div>
    </form>

</asp:Content>
