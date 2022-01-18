using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ObjetoTrasnferencia;
using Negocios;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuAluno_Click(object sender, EventArgs e)
        {
            FrmAlunoSelecionar frmAlunoSelecionar = new FrmAlunoSelecionar();
            frmAlunoSelecionar.ShowDialog();
            
        }

        private void doencasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDoenca = new FrmDoenca(null);
            frmDoenca.ShowDialog();
        }

        private void convivênciaFamiliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmConvFam = new FrmConv_Familiar(null);
            frmConvFam.ShowDialog();
        }

        private void habitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmHabitos = new FrmHabitos(null);
            frmHabitos.ShowDialog(); ;
        }

        private void condiçõesDeSonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmCondSono = new FrmCondSono(null);
            frmCondSono.ShowDialog();
        }

        private void horarioRegularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmHoraRegular = new FrmHoraRegular("");
            frmHoraRegular.ShowDialog();
        }

        private void fazSozinhacomportamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmFazSo = new FrmFazSozinha("");
            frmFazSo.ShowDialog();
        }

        private void responsávelLegalContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmRespLegal = new FrmRespLegal(null);
            frmRespLegal.ShowDialog();
        }

        private void religiãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmReligiao = new FrmReligiao(null);
            frmReligiao.ShowDialog();
        }

        private void bairrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBairro = new FrmBairros(null);
            frmBairro.ShowDialog();
        }

        private void dadosDaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDadosEmpresa = new FrmDadosEmpresa();
            frmDadosEmpresa.ShowDialog();
        }
        
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            FrmAlunoSelecionar frmAlunoSelecionar = new FrmAlunoSelecionar();
            frmAlunoSelecionar.ShowDialog();
        }

        private void TSDBDoenca_Click(object sender, EventArgs e)
        {
            Form frmDoenca = new FrmDoenca(null);
            frmDoenca.ShowDialog();
        }

        private void TSDBRespLegal_Click(object sender, EventArgs e)
        {
            Form frmRespLegal = new FrmRespLegal(null);
            frmRespLegal.ShowDialog();
        }

        private void TSDBPRofessores_Click(object sender, EventArgs e)
        {
            Form formProfessorSelecionar = new FrmProfessorSelecionar();
            formProfessorSelecionar.ShowDialog();
        }

        private void planosEstudantísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanos frmPlanos = new FrmPlanos(null);
            frmPlanos.ShowDialog();
        }

        private void TSDBTurma_Click(object sender, EventArgs e)
        {
            FrmTurmas frmTurmas = new FrmTurmas();
            frmTurmas.ShowDialog();
        }

        private void TSDBItemAvaliacaoPedagogica_Click(object sender, EventArgs e)
        {
            FrmItensAvaliacaoPedagogica frmItensAvaliacaoPedagogica = new FrmItensAvaliacaoPedagogica();
            frmItensAvaliacaoPedagogica.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMateria frmMateria = new FrmMateria();
            frmMateria.ShowDialog();
        }

        private void TSDBSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripDropDownButton1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void stPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLancamentoNota frmLancamentoNota = new FrmLancamentoNota();
            frmLancamentoNota.ShowDialog();
        }

        private void conceitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLancamentoConceito frmLancamentoConceito = new FrmLancamentoConceito();
            frmLancamentoConceito.ShowDialog();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form formProfessorSelecionar = new FrmProfessorSelecionar();
            formProfessorSelecionar.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmTurmas frmTurmas = new FrmTurmas();
            frmTurmas.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmItensAvaliacaoPedagogica frmItensAvaliacaoPedagogica = new FrmItensAvaliacaoPedagogica();
            frmItensAvaliacaoPedagogica.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor frmFornecedor = new FrmFornecedor();
            frmFornecedor.ShowDialog();
        }

        private void centrosDeCustoESeusSubÍtensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContaCorrente frmCentroCusto = new FrmContaCorrente();
            frmCentroCusto.ShowDialog();

        }
        private void gênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerosLiterarios frmGenerosLiterarios = new FrmGenerosLiterarios();
            frmGenerosLiterarios.ShowDialog();
        }

        private void lIvrosDidáticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLivroDidatico frmLivroDidatico = new FrmLivroDidatico();
            frmLivroDidatico.ShowDialog();
        }

        private void cadatrosDeLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLivroDidatico frmLivroDidatico = new FrmLivroDidatico();
            frmLivroDidatico.ShowDialog();
        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerosLiterarios frmGenerosLiterarios = new FrmGenerosLiterarios();
            frmGenerosLiterarios.ShowDialog();
        }

        private void toolStripDropDownButton1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSDBMInimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void listaDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fichaDoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.FrmFichaAluno f = new Relatorios.FrmFichaAluno();
            f.ShowDialog();
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.FrmContrato frmContrato = new Relatorios.FrmContrato();
            frmContrato.ShowDialog();
        }

        private void alunoPorTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.FrmAlunosPorTurmaCry frmAlunosPorTurma = new Relatorios.FrmAlunosPorTurmaCry();
            frmAlunosPorTurma.ShowDialog();
        }

        private void backupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBackup frmBackup = new FrmBackup();
            frmBackup.ShowDialog();
        }

        private void restauraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRestore frmRestore = new FrmRestore();
            frmRestore.ShowDialog();
        }

        private void fichaDoProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.FrmFichaProfessor frmFichaProfessorcs = new Relatorios.FrmFichaProfessor();
            frmFichaProfessorcs.ShowDialog();
        }

        private void mensalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMensalidades frmGeraMensalidades = new FrmMensalidades();
            frmGeraMensalidades.ShowDialog();
        }

        private void carnezinhoFestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCarnezinho frmCarnezinho = new FrmCarnezinho();
            frmCarnezinho.ShowDialog();
        }
    }
}
