using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Negocios;
using ObjetoTrasnferencia;

namespace Apresentacao
{
    public partial class FrmMateria : Form
    {
        public FrmMateria()
        {
            InitializeComponent();
            dgvMateria.AutoGenerateColumns = false;
        }

        private void CarregaProfessores()
        {
            ProfessorNegocios professorNegocios = new ProfessorNegocios();
            ProfessorColecao elementosColecao = professorNegocios.ConsultarCombo();

            Professor professor = new Professor();
            professor.Cod_Professor = 0;
            professor.Nome_Professor = "";
            elementosColecao.Insert(0, professor);
            this.cmbProfessor.DataSource = elementosColecao;
            this.cmbProfessor.ValueMember = "Cod_Professor";
            this.cmbProfessor.DisplayMember = "Nome_Professor";
            this.cmbProfessor.SelectedIndex = 0;
        }

        private void CarregaGrid()
        {
            MateriaNegocios materiaNegocio = new MateriaNegocios();
            MateriaColecao materiaColecao = materiaNegocio.ConsultarGrid(txtNome_Materia.Text);

            dgvMateria.DataSource = null;
            dgvMateria.DataSource = materiaColecao.Select(s => new
            {
                s.Cod_Materia,
                s.professor.Nome_Professor,
                s.Nome_Materia

            }).ToArray();

            dgvMateria.Update();
            dgvMateria.Refresh();

        }

        private void NovaMateria()
        {
            if (String.IsNullOrEmpty(txtNome_Materia.Text))
            {
                MessageBox.Show("Preencha um nome para a Matéria", "Cuidado !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dgvMateria.Rows.Count; i++)
            {

                if (txtNome_Materia.Text.ToUpper() == dgvMateria[1, i].Value.ToString().ToUpper())
                {

                    MessageBox.Show("Matéria já cadastrada. Altere o nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnAlterar.Text = "Alterar";
                    return;
                }

            }

            Materia novaMateria = new Materia();
            novaMateria.Nome_Materia = Convert.ToString(txtNome_Materia.Text);

            novaMateria.professor = new Professor();
            novaMateria.professor.Cod_Professor = Convert.ToInt32(cmbProfessor.SelectedValue);
            MateriaNegocios materiaNegocios = new MateriaNegocios();
            string retorno = materiaNegocios.Inserir(novaMateria);

            try
            {

                int codMateria = Convert.ToInt32(retorno);
                MessageBox.Show("MAtéria inserida com sucesso. Código: " + codMateria);
                txtNome_Materia.Text = "";
                cmbProfessor.SelectedValue = 0;
                CarregaGrid();

            }
            catch
            {
                MessageBox.Show("Não Foi possivel inserir a Matéria.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void AlteraMateria()
        {
            Materia materia = new Materia();
            MateriaNegocios materiaNegocios = new MateriaNegocios();
            materia.Cod_Materia = Convert.ToInt32(dgvMateria.CurrentRow.Cells[0].Value);
            materia.Nome_Materia = txtNome_Materia.Text;
            materia.professor = new Professor();
            materia.professor.Cod_Professor = Convert.ToInt32(cmbProfessor.SelectedValue);
            string retorno = materiaNegocios.Alterar(materia);
            try
            {
                int codMateria = Convert.ToInt32(retorno);
                MessageBox.Show("MAtéria alterado com sucesso.");
                txtNome_Materia.Text = "";
                cmbProfessor.SelectedIndex = -1;
                CarregaGrid();
                btnAlterar.Text = "Alterar";
                btnConsultar.Enabled = true;
                btnExcluir.Enabled = true;
                btnInserir.Enabled = true;
                dgvMateria.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Não Foi possivel alterar os dados da Matéria.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMateria_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregaProfessores();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            NovaMateria();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvMateria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cadastre uma matéria", "Materia não selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (btnAlterar.Text == "Alterar")
            {
                txtNome_Materia.Text = Convert.ToString(dgvMateria.CurrentRow.Cells[1].Value);
                string prof = Convert.ToString(dgvMateria.CurrentRow.Cells[2].Value);
                cmbProfessor.Text = prof;
                btnAlterar.Text = "Gravar";
                btnConsultar.Enabled = false;
                btnExcluir.Enabled = false;
                btnInserir.Enabled = false;
                dgvMateria.Enabled = false;
            }

            else if (btnAlterar.Text == "Gravar")
            {

                if (string.IsNullOrEmpty(txtNome_Materia.Text) || cmbProfessor.SelectedIndex == -1)
                {
                    btnAlterar.Text = "Alterar";
                    btnConsultar.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnInserir.Enabled = true;
                    dgvMateria.Enabled = true;

                    return;
                }

                AlteraMateria();

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dgvMateria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Tem certeza que deseja excluir a Matéria da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Materia materiaSelecionado = new Materia();
            MateriaNegocios materiaNegocios = new MateriaNegocios();
            materiaSelecionado.Cod_Materia = Convert.ToInt32(dgvMateria.CurrentRow.Cells[0].Value); 
            string retorno = materiaNegocios.Excluir(materiaSelecionado);

            try
            {

                int codMateria = Convert.ToInt32(retorno);
                txtNome_Materia.Text = "";
                CarregaGrid();

            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir a Matéria." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

    }
}
