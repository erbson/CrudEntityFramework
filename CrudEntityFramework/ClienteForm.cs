using Accord;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudEntityFramework
{
    public partial class ClienteForm : Form
    {
        // Os icones desse projeto obtive pelo site : https://www.flaticon.com/

        Form1 form;
        bool novo = true;
        int codigo;
        public ClienteForm(Form1 formulario, int idcliente)
        {
            InitializeComponent();

            form = formulario;
            codigo = idcliente;
            if (codigo != 0)
            {
                novo = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BDcontext bd = new BDcontext();
            try
            {


                if (novo)
                {
                    Clientes cliente = new Clientes()
                    {
                        nome = txtnome.Text,
                        cpf = txtcpf.Text,
                        email = txtemail.Text,
                        datanascimento = txtdatanascimento.Text,
                        whatsapp = txtwhatsapp.Text

                    };
                    bd.Clientes.Add(cliente);
                    bd.SaveChanges();
                    BDcontext banco = new BDcontext();

                    var sql = (from r in bd.Clientes
                               orderby r.Codigo descending
                               select r).First();

                    Endereco endereco = new Endereco()
                    {
                        rua = txtrua.Text,
                        bairro = txtbairro.Text,
                        cidade = txtcidade.Text,
                        uf = cb_uf.Text,
                        pais = cb_pais.Text,

                        cep = txtcep.Text,
                        idcliente = sql.Codigo

                    };
                    banco.Endereco.Add(endereco);
                    banco.SaveChanges();

                    MessageBox.Show("Cadastro Realizado com Sucesso!");
                    this.LimpaFormulario();

                }
                else
                {
                    DialogResult confirma = MessageBox.Show("Deseja Salvar as Alteraçoes ?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (confirma.Equals(DialogResult.OK))
                    {
                        Clientes cliente = bd.Clientes.First(p => p.Codigo == codigo);

                        cliente.nome = txtnome.Text;
                        cliente.cpf = txtcpf.Text;
                        cliente.email = txtemail.Text;
                        cliente.datanascimento = txtdatanascimento.Text;
                        cliente.whatsapp = txtwhatsapp.Text;
                        bd.SaveChanges();
                        Endereco endereco = bd.Endereco.First(p => p.idcliente == codigo);
                        endereco.rua = txtrua.Text;
                        endereco.bairro = txtbairro.Text;
                        endereco.cidade = txtcidade.Text;
                        endereco.uf = cb_uf.Text;
                        endereco.pais = cb_pais.Text;
                        endereco.cep = txtcep.Text;
                        bd.SaveChanges();
                        MessageBox.Show("Dados Atualizados com sucesso!");
                        this.LimpaFormulario();

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            form.preenchegrid();

        }

        private void btfechar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpaFormulario()
        {

            txtnome.Text = "";
            txtcpf.Text = "";
            txtemail.Text = "";
            txtdatanascimento.Text = "";
            txtwhatsapp.Text = "";
            txtrua.Text = "";
            txtbairro.Text = "";
            txtcidade.Text = "";
            cb_uf.Text = "";
            cb_pais.Text = "";
            txtcep.Text = "";

        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            if (!novo)
            {
                BDcontext bd = new BDcontext();

                Clientes cliente = bd.Clientes.First(p => p.Codigo == codigo);

                txtnome.Text = cliente.nome;
                txtcpf.Text = cliente.cpf;
                txtemail.Text = cliente.email;
                txtdatanascimento.Text = cliente.datanascimento;
                txtwhatsapp.Text = cliente.whatsapp;
                Endereco endereco = bd.Endereco.First(p => p.idcliente == codigo);
                txtrua.Text = endereco.rua;
                txtbairro.Text = endereco.bairro;
                txtcidade.Text = endereco.cidade;
                cb_uf.Text = endereco.uf;
                cb_pais.Text = endereco.pais;
                txtcep.Text = endereco.cep;
            }

        }
    }
}
