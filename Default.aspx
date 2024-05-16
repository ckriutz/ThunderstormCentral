<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="ThunderstormCentral._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">⚡ Thunderstorm Central</h1>
            <p class="lead">Thunderstorm Central is a full framework (4.7.2) project, designed to randomly display if there is a thunderstorm or not.</p>
        </section>
        <div class="px-4 py-5 my-5 text-center">
             <div style="font-size: 7rem;"><asp:Label id="weatherIconlabel" Text="☀️" runat="server"/></div>

            <h1 class="display-5 fw-bold"><asp:Label id="weatherTextLabel" Text="Sunny" runat="server"/></h1>
            <div class="col-lg-10 mx-auto">
                <p class="lead mb-4"><asp:Label id="weatherDescriptionLabel" Text="Sunny" runat="server"/></p>
            </div>
        </div>
    </main>

</asp:Content>
