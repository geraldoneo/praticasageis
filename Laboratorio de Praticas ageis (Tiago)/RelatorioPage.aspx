<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="RelatorioPage.aspx.cs" Inherits="RelatorioPage" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <link href="Scripts/estilo.css" rel="stylesheet" type="text/css" />

    <script language="javascript" type="text/javascript">
// <![CDATA[

        function selecionarEquipamento_onclick() {

        }

// ]]>
    </script>
    <style type="text/css">
        .style1
        {
            font-size: small;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
        <span class="bold">Geração de Relatório de Empréstimo</span><br />
        <p>
            Selecione uma opção e clique em pesquisar</p>
        <p>
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Relatorio01" 
                    oncheckedchanged="RadioButton1_CheckedChanged" Text="Equipamento Emprestado" />
&nbsp;-
                <asp:RadioButton ID="RdStatus" runat="server" GroupName="Relatorio01" 
                    Text="Equipamento Livre" Checked="True" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Consultar" 
                onclick="Button1_Click" />
        </p>
        <p>
            <asp:GridView ID="gridEmprestimo" runat="server">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
</p>
        <p align="right">
            &nbsp;</p>
 
    </asp:Content>
