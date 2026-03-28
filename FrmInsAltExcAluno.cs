using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmInsAltExcAluno : Form
    {
        //instanciado o objeto aluno
        Aluno objAluno = new Aluno();

        public FrmInsAltExcAluno(Aluno aluno)
        {
            InitializeComponent();

            //Atribuindo valor ao objeto
            objAluno = aluno ?? new Aluno();
        }

        private void MetodoPreencherFormulario()
        {
            if (objAluno.Id != 0)
            {
                txtNome.Text = objAluno.Nome;
                txtId.Text = objAluno.Id.ToString();

                lbId.Visible = true;
                txtId.Visible = true;
                txtId.Enabled = false;

                btnAlterar.Visible = true;
                btnExcluir.Visible = true;
                btnCadastrar.Visible = false;
            }
            else
            {
                lbId.Visible = false;
                txtId.Visible = false;
                btnAlterar.Visible = false;
                btnExcluir.Visible = false;
                btnCadastrar.Visible = true;
            }

        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome é obrigatório.",
                    "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }
            return true;
        }

        private void MetodoSair()
        {
         DialogResult resultado = 
                MessageBox.Show("Deseja realmente sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                DialogResult = DialogResult.OK;
            }
            return;
        }



        //Eventos
        private void FrmInsAltExcAluno_Load(object sender, EventArgs e)
        {
            MetodoPreencherFormulario();
        }


    }
}
