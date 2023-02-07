<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="satis.aspx.cs" Inherits="TCRAPP.satis.satis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <table class="table table-bordered">
        <tr>
            <th>KOD</th>
            <th>ÜRÜN </th>
            <th>PERSONEL</th>
            <th>MÜŞTERİ</th>
            <th>FİYAT</th>
        </tr>

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("ID") %></td>
                    <td><%#Eval("URUN_AD") %></td>
                    <td><%#Eval("personelAdSoyadBilgisi") %></td>
                    <td><%#Eval("musteriAdSoyadBilgisi") %></td>
                    <td><%#Eval("FIYAT") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

    <a href="satis_yap.aspx" class="btn btn-info"> Yeni Satış İşlemi</a>
</asp:Content>
