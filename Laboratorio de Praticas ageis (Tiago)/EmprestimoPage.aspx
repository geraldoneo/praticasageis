<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="EmprestimoPage.aspx.cs" Inherits="EmprestimoPage" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function selecionarEquipamento_onclick() {

        }

// ]]>
    </script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

        <p> <div id="conteudo">
            <div id="alinhamento"><label for="cpf">
                CPF do cliente:</label></div>
            <div id="input"><asp:TextBox ID="txtCpf" runat="server"></asp:TextBox></div></div>

        </p>
        <p>
            <label for="nomeCliente">
                Nome do Cliente</label>
            <asp:TextBox id="txtNomeCliente" runat="server" size="80" Enabled="False" />
        &nbsp;<asp:Label ID="lblIdClient" runat="server" Text="Label" Visible="False"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p align="right">
            <asp:Button id="consultar" runat="server" Text="CONSULTAR" 
                onclick="consultar_Click" />
        </p>
        <p>
            Selecione o equipamento desejado a ser locado:
            <input type="radio" name="radio" id="internet" value="internet" />
            <label for="internet">
                Internet</label>
            --
            <input type="radio" name="radio" id="TV" value="TV" />
            <label for="TV">
                tv</label>
            --
            <input type="radio" name="radio" id="Híbrido" value="Híbrido" />
            <label for="Híbrido">
                hibrido</label>
        </p>
        <p>
                Equipamentos Disponíveis&nbsp;
            <asp:DropDownList ID="dropEquipamento" runat="server">
            </asp:DropDownList>
            <label for="quantidadeEmprestimo">
                <br />
                <br />
                Quantidade</label>
                
            <asp:TextBox id="txtQtdeEmprestimo" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="selecionarEquipamento" runat="server" Text="Incluir" 
                    OnClick="selecionarEquipamento_Click" Width="65px" />
        </p>
        <p>
            Equipamentos Selecionados:</p>
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
