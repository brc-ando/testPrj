<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	HelloWorld
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>HelloWorld</h2>
	<h3>日付選択</h3>
	<asp:Calendar runat="server" ID="myCallender" BorderColor="ControlLight" BackColor="Azure" ></asp:Calendar>
</asp:Content>
	