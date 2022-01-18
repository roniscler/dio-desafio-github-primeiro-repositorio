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
    public partial class FrmFazSozinha : Form
    {
        string acaoVinda;
        public FrmFazSozinha(string acao)
        {
            InitializeComponent();
            acaoVinda = acao;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregaGridFazSo();
            
        }

        private void carregaGridFazSo()
        {
            FazSozinhaColecao fazSoCoelcao = new FazSozinhaColecao();
            FazSozinhaNegocios fazSozinhaNegocios = new FazSozinhaNegocios();
            fazSoCoelcao = fazSozinhaNegocios.Consultar(txtpesquisaNome.Text);
            dgvFazSo.DataSource = fazSoCoelcao;

            dgvFazSo.DataSource = fazSoCoelcao;
            dgvFazSo.Update();
            dgvFazSo.Refresh();
        }

        private void FrmFazSozinha_Load(object sender, EventArgs e)
        {
            carregaGridFazSo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (btnAlterar.Text == "Alterar" && dgvFazSo.SelectedRows.Count > 0)
            {
                txtpesquisaNome.Text = Convert.ToString(dgvFazSo.CurrentRow.Cells[1].Value);
                btnAlterar.Text = "Gravar";
            }

            else if (btnAlterar.Text == "Gravar")
            {

                if (txtpesquisaNome.Text == null || txtpesquisaNome.Text == "")
                {
                    btnAlterar.Text = "Alterar";
                    return;
                }

                for (int i = 0; i < dgvFazSo.Rows.Count; i++)
                {

                    if (txtpesquisaNome.Text.ToUpper() == dgvFazSo[1, i].Value.ToString().ToUpper())
                    {

                        MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnAlterar.Text = "Alterar";
                        return;
                    }

                }

                AlterarFazSo();

            }
        }

        private void AlterarFazSo()
        {
            FazSozinha fazSozinha = new FazSozinha();
            FazSozinhaNegocios fazSozinhaNegocios = new FazSozinhaNegocios();
            fazSozinha.Cod_FazSozinha = Convert.ToInt32(dgvFazSo.CurrentRow.Cells[0].Value);
            fazSozinha.Desc_FazSozinha = txtpesquisaNome.Text;
            string retorno = fazSozinhaNegocios.Alterar(fazSozinha);
            try
            {
                int codDoenca = Convert.ToInt32(retorno);
                MessageBox.Show("Item alterado com sucesso.");
                txtpesquisaNome.Text = "";
                carregaGridFazSo();
                btnAlterar.Text = "Alterar";
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;

            }
            catch
            {
                MessageBox.Show("Não Foi possivel alterar os dados do item.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NovaFazSo()
        {
            FazSozinha novoFazSo = new FazSozinha();
            novoFazSo.Desc_FazSozinha = txtpesquisaNome.Text;
            FazSozinhaNegocios fazSozinhaNegocios = new FazSozinhaNegocios();
            string retorno = fazSozinhaNegocios.Inserir(novoFazSo);

            try
            {

                int codItem = Convert.ToInt32(retorno);
                MessageBox.Show("Item inserido com sucesso. Código: " + codItem);
                txtpesquisaNome.Text = "";
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;
                carregaGridFazSo();

            }
            catch
            {
                MessageBox.Show("Não Foi possivel inserir o item na lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o item da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            if (dgvFazSo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FazSozinha fazSozinhaSelecionada = (dgvFazSo.SelectedRows[0].DataBoundItem as FazSozinha);
            FazSozinhaNegocios fazSozinhaNegocios = new FazSozinhaNegocios();
            string retorno = fazSozinhaNegocios.Excluir(fazSozinhaSelecionada);

            try
            {
                int codElemento = Convert.ToInt32(retorno);
                txtpesquisaNome.Text = "";
                carregaGridFazSo();
                if (acaoVinda == "VindoAluno") this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtpesquisaNome.Text == null || txtpesquisaNome.Text == "") return;

            for (int i = 0; i < dgvFazSo.Rows.Count; i++)
            {

                if (txtpesquisaNome.Text.ToUpper() == dgvFazSo[1, i].Value.ToString().ToUpper())
                {
                    MessageBox.Show("Item já cadastrado. Pesquise e veja seu código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnAlterar.Text = "Alterar";
                    return;
                }

            }

            NovaFazSo();
        }

        private void FrmFazSozinha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

    }
}
