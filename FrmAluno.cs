using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmAluno : Form
    {
        Aluno aluno = new Aluno();
        List<Aluno> listaAluno = new List<Aluno>();
        NegAluno negAluno = new NegAluno();

        public FrmAluno()
        {
            InitializeComponent();
        }
        private void PreencherGrid(string nome)
        {
            //dgvAluno.Rows.Clear();
                listaAluno = negAluno.BuscarAluno(nome);
                if (listaAluno.Count != 0)
                {
                    dgvAluno.DataSource = listaAluno;
                }
                return;
            
        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {
            PreencherGrid(txtBuscarAluno.Text);
        }
    }
}
