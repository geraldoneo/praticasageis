using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Emprestimo;


public partial class EmprestimoPage : System.Web.UI.Page
{
    ClientRepository clientRepository;
    EquipamentoRepository equipamentoRepository;
    EmprestimoRepository emprestimoRepository;



    protected void Page_Load(object sender, EventArgs e)
    {

        equipamentoRepository = new EquipamentoRepository();

        var equipamentoList = equipamentoRepository.FindAll();

        dropEquipamento.DataSource = equipamentoList;
        dropEquipamento.DataValueField = "IdEquipamnto";
        dropEquipamento.DataTextField = "NumeroSerie";
        dropEquipamento.DataBind();




    }

    protected void selecionarEquipamento_Click(object sender, EventArgs e)
    {
        if (char.IsNumber(txtQtdeEmprestimo.Text, 0) && char.IsNumber(lblIdClient.Text, 0))
        {

            emprestimoRepository = new EmprestimoRepository();

            emprestimoModel.emprestimo _emprestimo = new emprestimoModel.emprestimo();

            _emprestimo.DataEmprestimo = DateTime.Now;
            _emprestimo.IdCliente = int.Parse(lblIdClient.Text);
            _emprestimo.IdEquipamento = int.Parse(dropEquipamento.SelectedValue);
            _emprestimo.Status = 1;
            _emprestimo.Quantidade = int.Parse(txtQtdeEmprestimo.Text);

            var id = 1;

           if (emprestimoRepository.FindAll().Count() > 0)
               id = emprestimoRepository.FindAll().Last().IdEmprestimo;

            _emprestimo.IdEmprestimo = id;



            emprestimoRepository.Add(_emprestimo);


            var _emprestimos = emprestimoRepository.FindAllByIdClient(int.Parse(lblIdClient.Text));

            gridEmprestimo.DataSource = _emprestimos;
            gridEmprestimo.DataBind();

        }
        else
        {
            Response.Write("Consulte o cliente e insira a quantidade, campo deve ser numerico.");
        }
    }
    protected void consultar_Click(object sender, EventArgs e)
    {
        clientRepository = new ClientRepository();

        var clients = clientRepository.FindAll().Where(x => x.Cpf == txtCpf.Text);

        if (clients != null)
        {
            emprestimoRepository = new EmprestimoRepository();

            txtNomeCliente.Text = clients.First().Nome;
            lblIdClient.Text = clients.First().IdCliente.ToString();

            var _emprestimos = emprestimoRepository.FindAllByIdClient(clients.First().IdCliente);

            gridEmprestimo.DataSource = _emprestimos;
            gridEmprestimo.DataBind();
        }

    }
}