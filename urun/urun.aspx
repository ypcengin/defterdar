<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="urun.aspx.cs" Inherits="TCRAPP.Urun.urun" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>KOD</th>
            <th>ÜRÜN ADI</th>
            <th>MARKA</th>
            <th>KATEGORİ</th>
            <th>FİYAT</th>
            <th>STOK</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("ID") %></td>
                    <td><%#Eval("URUN_AD") %></td>
                    <td><%#Eval("URUN_MARKA") %></td>
                    <td><%#Eval("KATEGORI_AD") %></td>
                    <td><%#Eval("ETIKET_FIYAT") %></td>
                    <td><%#Eval("STOK") %></td>
                    
                    <td> <asp:HyperLink NavigateUrl='<%# "~/urun/urun_sil.aspx?ID=" + Eval("ID") %>'  ID="HyperLink1" runat="server" CssClass="btn btn-danger" >Sil</asp:HyperLink> </td>
                    <td> <asp:HyperLink NavigateUrl='<%# "~/urun/urun_guncelle.aspx?ID=" + Eval("ID") %>'  ID="HyperLink2" runat="server" CssClass="btn btn-success" >Güncelle</asp:HyperLink> </td>

    
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
    <a href="urun_ekle.aspx" class="btn btn-info"> Yeni Ürün</a>
</asp:Content>
