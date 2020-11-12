using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe2_ContaBancaria
{
    public partial class frmClientes : Form
    {
        int numLinha = 0;

        Cliente_V1 cliente_v1;
        Cliente_V2 cliente_v2;
        Cliente_V3 cliente_v3;
        Cliente_V4 cliente_v4_1;
        Cliente_V4 cliente_v4_2;
        Cliente_V4 cliente_v4_3;
        Cliente_V4 cliente_v4_4;

        public frmClientes()
        {
            InitializeComponent();
        }

        public void CarregarGrid(string nome, string cpf, string rg, string endereco)
        {
            dgvClientes.Rows.Add();
            dgvClientes[0, numLinha].Value = nome;
            dgvClientes[1, numLinha].Value = cpf; 
            dgvClientes[2, numLinha].Value = rg;
            dgvClientes[3, numLinha].Value = endereco;
            numLinha++;
        }

        private void btnCriarClienteV1_Click(object sender, EventArgs e)
        {
            cliente_v1 = new Cliente_V1();
            cliente_v1.SetNome(txtNomeCliente.Text);
            cliente_v1.SetCpf(txtCpfCliente.Text);
            cliente_v1.SetRg(txtRgCliente.Text);
            cliente_v1.SetEndereco(txtEnderecoCliente.Text);

            CarregarGrid(cliente_v1.GetNome(), cliente_v1.GetCpf(), cliente_v1.GetRg(), cliente_v1.GetEndereco());

        }

        private void btnCriarClienteV2_Click(object sender, EventArgs e)
        {
            cliente_v2 = new Cliente_V2();
            cliente_v2.Nome = txtNomeCliente.Text;
            cliente_v2.Cpf = txtCpfCliente.Text;
            cliente_v2.Rg = txtRgCliente.Text;
            cliente_v2.Endereco = txtEnderecoCliente.Text;

            CarregarGrid(cliente_v2.Nome, cliente_v2.Cpf, cliente_v2.Rg, cliente_v2.Endereco);

        }

        private void btnCriarClienteV3_Click(object sender, EventArgs e)
        {
            cliente_v3 = new Cliente_V3();
            cliente_v3.Nome = txtNomeCliente.Text;
            cliente_v3.Cpf = txtCpfCliente.Text;
            cliente_v3.Rg = txtRgCliente.Text;
            cliente_v3.Endereco = txtEnderecoCliente.Text;

            CarregarGrid(cliente_v3.Nome, cliente_v3.Cpf, cliente_v3.Rg, cliente_v3.Endereco);
        }

        private void btnCriarClienteV4_1_Click(object sender, EventArgs e)
        {
            //teste 1
            /*cliente_v4_1 = new Cliente_V4(txtNomeCliente.Text);
            CarregarGrid(cliente_v4_1.Nome, "", "", "");*/

            //teste 2

            cliente_v4_1 = new Cliente_V4(txtNomeCliente.Text)
            {
                Cpf = txtCpfCliente.Text,
                Rg = txtRgCliente.Text,
                Endereco = txtEnderecoCliente.Text
            };

            CarregarGrid(cliente_v4_1.Nome, cliente_v4_1.Cpf, cliente_v4_1.Rg, cliente_v4_1.Endereco);

        }

        private void btnCriarClienteV4_2_Click(object sender, EventArgs e)
        {
            //teste 1
            /*cliente_v4_2 = new Cliente_V4(txtNomeCliente.Text, txtCpfCliente.Text);
            CarregarGrid(cliente_v4_2.Nome, cliente_v4_2.Cpf, "", "");*/

            //teste2

            cliente_v4_2 = new Cliente_V4(txtNomeCliente.Text, txtCpfCliente.Text)
            {
                Rg = txtRgCliente.Text,
                Endereco = txtEnderecoCliente.Text
            };

            CarregarGrid(cliente_v4_2.Nome, cliente_v4_2.Cpf, cliente_v4_2.Rg, cliente_v4_2.Endereco);
        }

        private void btnCriarClienteV4_3_Click(object sender, EventArgs e)
        {
            //teste 1
            /*cliente_v4_3 = new Cliente_V4(txtNomeCliente.Text, txtCpfCliente.Text, txtRgCliente.Text);
            CarregarGrid(cliente_v4_3.Nome, cliente_v4_3.Cpf, cliente_v4_3.Rg, "");*/

            //teste 2

            cliente_v4_3 = new Cliente_V4(txtNomeCliente.Text, txtCpfCliente.Text, txtRgCliente.Text)
            {
                Endereco = txtEnderecoCliente.Text
            };

            CarregarGrid(cliente_v4_3.Nome, cliente_v4_3.Cpf, cliente_v4_3.Rg, cliente_v4_3.Endereco);
        }

        private void btnCriarClienteV4_4_Click(object sender, EventArgs e)
        {
            //teste 1
            cliente_v4_4 = new Cliente_V4(txtNomeCliente.Text, txtCpfCliente.Text, txtRgCliente.Text, txtEnderecoCliente.Text);
            CarregarGrid(cliente_v4_4.Nome, cliente_v4_4.Cpf, cliente_v4_4.Rg, cliente_v4_4.Endereco);
        }
    }
}
