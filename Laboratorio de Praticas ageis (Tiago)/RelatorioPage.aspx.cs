using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Emprestimo;
using emprestimoModel;


public partial class RelatorioPage : System.Web.UI.Page
{
    ClientRepository clientRepository;
    EquipamentoRepository equipamentoRepository;
    EmprestimoRepository emprestimoRepository;



    protected void Page_Load(object sender, EventArgs e)
    {

        equipamentoRepository = new EquipamentoRepository();

        var equipamentoList = equipamentoRepository.FindAll();

        /*dropEquipamento.DataSource = equipamentoList;
        dropEquipamento.DataValueField = "IdEquipamnto";
        dropEquipamento.DataTextField = "NumeroSerie";
        dropEquipamento.DataBind();*/




    }

    protected void selecionarEquipamento_Click(object sender, EventArgs e)
    {
        /*if (char.IsNumber(txtQtdeEmprestimo.Text, 0) && char.IsNumber(lblIdClient.Text, 0))
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
            
        }*/
        /*else
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
        }*/

    }
    protected void txtNomedoRelatorio0_TextChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RadioButton1.Checked)
        {
            EmprestimoRepository _emprestimo = new EmprestimoRepository();

            gridEmprestimo.DataSource = _emprestimo.FindAll().Where(x => x.Status == 1);
            gridEmprestimo.DataBind();

        }
        else
        {

            EmprestimoRepository _emprestimo = new EmprestimoRepository();
            EquipamentoRepository _equipamento = new EquipamentoRepository();

            List<equipamento> equip = new List<equipamento>();

            List<equipamento> equipTemp = new List<equipamento>();


            equip = _equipamento.FindAll().ToList<equipamento>();

            foreach (equipamento _equip in equip)
            {
                var eqp = _emprestimo.FindAll().Where(x => x.IdEquipamento == _equip.IdEquipamnto);

                if (eqp.Count() > 0)
                {
                    int qtde = 0;


                    foreach (emprestimo emp in eqp)
                    {

                        qtde += (int)emp.Quantidade;
                    
                    }

                    _equip.Quantidade = _equip.Quantidade - qtde;

                    equipTemp.Add(_equip);
                }
                else
                    equipTemp.Add(_equip);
            

            }


            gridEmprestimo.DataSource = equipTemp;
            gridEmprestimo.DataBind();
        }
    }

}