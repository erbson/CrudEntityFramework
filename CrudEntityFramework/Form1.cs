using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudEntityFramework
{
    public partial class Form1 : Form
    {
        // Os icones desse projeto obtive pelo site : https://www.flaticon.com/
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            ClienteForm cliente = new ClienteForm(this, codigo);
            cliente.Show();
        }

        private void Form1_Load(object sender, System.EventArgs e)

        {

            BDcontext bd = new BDcontext();
            dataGridView1.DataSource = bd.Clientes.ToList();
        }

        private void l(object sender, ControlEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)

        {
            panel3.Visible = false;
            comboBox1.Visible = false;
            BDcontext bd = new BDcontext();
            comboBox1.DataSource = bd.Clientes.ToList();
            comboBox1.ValueMember = "Codigo";
            comboBox1.DisplayMember = "nome";
            this.preenchegrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;


            }
            else
            {

                this.WindowState = FormWindowState.Maximized;

                this.MaximumSize = this.Size;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }


        }

        private void btpesquisar_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            comboBox1.Visible = true;

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            BDcontext bd = new BDcontext();

            var codigo = comboBox1.SelectedValue;
            if (codigo != null)
            {

                int id = Convert.ToInt32(codigo.ToString());
                this.preenchegridPorCodigo(id);

            }
            else
            {

                preenchegrid();
            }

            panel3.Visible = false;

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            BDcontext bd = new BDcontext();

            var codigo = comboBox1.SelectedValue;
            if (!String.IsNullOrEmpty(codigo.ToString()))
            {
                int id = Convert.ToInt32(codigo.ToString());

                this.preenchegridPorCodigo(id);

            }
            panel3.Visible = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            panel3.Visible = false;
        }
        public void preenchegrid()
        {
            BDcontext bd = new BDcontext();
            var consulta = (from cliente in bd.Clientes
                            join endereco in bd.Endereco on cliente.Codigo equals endereco.idcliente
                            select new
                            {
                                Codigo = cliente.Codigo,
                                Nome = cliente.nome,
                                Cpf = cliente.cpf,
                                Whatsapp = cliente.whatsapp,
                                Email = cliente.email,
                                Cidade = endereco.cidade,
                                UF = endereco.uf
                            });

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = consulta.ToList();
        }

        public void preenchegridPorCodigo(int codigo)
        {
            BDcontext bd = new BDcontext();
            var consulta = (from cliente in bd.Clientes
                            join endereco in bd.Endereco on cliente.Codigo equals endereco.idcliente
                            where cliente.Codigo == codigo
                            select new
                            {
                                Codigo = cliente.Codigo,
                                Nome = cliente.nome,
                                Cpf = cliente.cpf,
                                Whatsapp = cliente.whatsapp,
                                Email = cliente.email,
                                Cidade = endereco.cidade,
                                UF = endereco.uf
                            });

            dataGridView1.DataSource = null;


            dataGridView1.DataSource = consulta.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var idcliente = dataGridView1.CurrentRow.Cells[0].Value;

            BDcontext bd = new BDcontext();

            DialogResult confirma = MessageBox.Show("Deseja Realmente excluir esse cadastrado ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirma.Equals(DialogResult.OK))
            {
                int codigo = Convert.ToInt32(idcliente.ToString());

                bd.Clientes.Remove(bd.Clientes.First(p => p.Codigo == codigo));

                bd.SaveChanges();

                MessageBox.Show("Cadastro Excluido com sucesso");

                this.preenchegrid();

            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var idcliente = dataGridView1.CurrentRow.Cells[0].Value;
            int codigo = Convert.ToInt32(idcliente.ToString());

            // Abrindo o formulario para manutenção do Cadastro
            ClienteForm cliente = new ClienteForm(this, codigo);
            cliente.Show();

        }

        private void bt_pesquisarcliente_Click(object sender, EventArgs e)
        {
            BDcontext bd = new BDcontext();

            var codigo = comboBox1.SelectedValue;
            if (codigo != null)
            {

                int id = Convert.ToInt32(codigo.ToString());
                this.preenchegridPorCodigo(id);

            }
            else
            {

                preenchegrid();
            }

            panel3.Visible = false;

        }
    }
}
