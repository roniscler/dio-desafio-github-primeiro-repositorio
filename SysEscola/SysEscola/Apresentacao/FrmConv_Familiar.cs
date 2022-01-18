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
    public partial class FrmConv_Familiar : Form
    {
        string acaoVinda;

        public FrmConv_Familiar(string acao)
        {
            InitializeComponent();

            acaoVinda = acao;
        }

        private void carregaGridConvFam()
        {
            ConvivenciaFamiliarColecao convivenciaFamiliarColecao = new ConvivenciaFamiliarColecao();
            Conv_FamiliarNegocio ConvFamNeg = new Conv_FamiliarNegocio();
            convivenciaFamiliarColecao = ConvFamNeg.ConsultarGrid(txtpesquisaNome.Text);
            dgvConvFam.DataSource = convivenciaFamiliarColecao;

            dgvConvFam.DataSource = convivenciaFamiliarColecao;
            dgvConvFam.Update();
            dgvConvFam.Refresh();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregaGridConvFam();           
        }

        private void FrmConv_Familiar_Load(object sender, EventArgs e)
        {
            carregaGridConvFam();
        
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (btnAlterar.Text == "Alterar" && dgvConvFam.SelectedRows.Count > 0)
                if (btnAlterar.Text == "Alterar")
            {
                txtpesquisaNome.Text = Convert.ToString(dgvConvFam.CurrentRow.Cells[1].Value);
                btnAlterar.Text = "Gravar";
            }

         else if (btnAlterar.Text == "Gravar")
         {

             if (txtpesquisaNome.Text == null || txtpesquisaNome.Text == "")
             {
                 btnAlterar.Text = "Alterar";
                 return;
             }
             for (int i = 0; i < dgvConvFam.Rows.Count; i++)
             {

                 if (txtpesquisaNome.Text.ToUpper() == dgvConvFam[1, i].Value.ToString().ToUpper())
                 {

                     MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     btnAlterar.Text = "Alterar";
                     return;
                 }

             }

             alteraConvFam();
         }

                         
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o item da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            if (dgvConvFam.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            ConvivenciaFamiliar convivenciaFamiliarSelecionada = (dgvConvFam.SelectedRows[0].DataBoundItem as ConvivenciaFamiliar);
            Conv_FamiliarNegocio convFamNegocio = new Conv_FamiliarNegocio();
            string retorno = convFamNegocio.Excluir(convivenciaFamiliarSelecionada);

            try
            {
                int codDoenca = Convert.ToInt32(retorno);
                txtpesquisaNome.Text = "";
                carregaGridConvFam();
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void alteraConvFam()
        {
            ConvivenciaFamiliar convivenciaFamiliar = new ConvivenciaFamiliar();
            Conv_FamiliarNegocio ConvFamNEg = new Conv_FamiliarNegocio();
            convivenciaFamiliar.Cod_Conv = Convert.ToInt32(dgvConvFam.CurrentRow.Cells[0].Value);
            convivenciaFamiliar.Desc_Conv = txtpesquisaNome.Text;
            string retorno = ConvFamNEg.Alterar(convivenciaFamiliar);
            try
            {
                int CodConv = Convert.ToInt32(retorno);
                MessageBox.Show("Item alterado com sucesso.");
                txtpesquisaNome.Text = "";
                carregaGridConvFam();
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;
                btnAlterar.Text = "Alterar";

            }
            catch
            {
                MessageBox.Show("Não Foi possivel alterar os dados di item.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insereConvFam()
        {
            ConvivenciaFamiliar novaConvivenciaFamiliar = new ConvivenciaFamiliar();
            novaConvivenciaFamiliar.Desc_Conv = txtpesquisaNome.Text;
            Conv_FamiliarNegocio ConvFam = new Conv_FamiliarNegocio();
            string retorno = ConvFam.Inserir(novaConvivenciaFamiliar);

            try
            {

                int codDoenca = Convert.ToInt32(retorno);
                MessageBox.Show("Item inserido com sucesso. Código: " + codDoenca);
                txtpesquisaNome.Text = "";
                carregaGridConvFam();
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;

            }
            catch
            {
                MessageBox.Show("Não Foi possivel inserir a Convivência Familiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtpesquisaNome.Text == null || txtpesquisaNome.Text == "") return;

            for (int i = 0; i < dgvConvFam.Rows.Count; i++)
            {
                if (txtpesquisaNome.Text.ToUpper() == dgvConvFam[1, i].Value.ToString().ToUpper())
                {

                    MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnAlterar.Text = "Alterar";
                    return;
                }
                                
            }

            insereConvFam();
        }

        private void FrmConv_Familiar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
