<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="kategori.aspx.cs" Inherits="TCRAPP.kategori" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>KOD</th>
            <th>KATEGORİ ADI</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("ID") %></td>
                    <td><%#Eval("KATEGORI_AD") %></td>
                    <td> <asp:HyperLink NavigateUrl='<%# "~/kategori_sil.aspx?ID=" + Eval("ID") %>'  ID="HyperLink1" runat="server" CssClass="btn btn-danger" >Sil</asp:HyperLink> </td>
                    <td> <asp:HyperLink NavigateUrl='<%# "~/kategori_guncelle.aspx?ID=" + Eval("ID") %>'  ID="HyperLink2" runat="server" CssClass="btn btn-success" >Güncelle</asp:HyperLink> </td>

                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
    <a href="kategori_ekle.aspx" class="btn btn-info"> Yeni Kategori </a>
</asp:Content>
