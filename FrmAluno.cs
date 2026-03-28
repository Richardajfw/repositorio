using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmAluno : Form
    {
        List<Aluno> listaAluno = new List<Aluno>();
        NegAluno negAluno = new NegAluno();



        public FrmAluno()
        {
            InitializeComponent();
        }

        private void MetodoPreencherGrid()
        {
            listaAluno =
                negAluno.BuscarAlunoPorNome(txtBuscarAluno.Text);

            if (listaAluno.Count > 0)
            {
                dgvAluno.DataSource = listaAluno;
            }
          
        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {
            MetodoPreencherGrid();
        }
    }








}
