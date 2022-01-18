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
    public partial class FrmMensalidades : Form
    {        
        int pages = 1;
        int contador = 0;
        public FrmMensalidades()
        {
            InitializeComponent();
            dgvMensalidade.AutoGenerateColumns = false;
        }

        private void carregaGridMensalidade()
        {
            MensalidadeColecao mensalidadeColecao = new MensalidadeColecao();
            MensalidadeNegocios mensalidadeNegocios = new MensalidadeNegocios();

            mensalidadeColecao = mensalidadeNegocios.ConsultarGrid(Convert.ToInt32(cmbAluno.SelectedValue), Convert.ToInt32(cmbTurma.SelectedValue));
            dgvMensalidade.DataSource = mensalidadeColecao;

            dgvMensalidade.DataSource = mensalidadeColecao.Select(s => new
            {
                s.Cod_Mensalidade,
                s.aluno.Cod_Aluno,
                s.turma.Cod_Turma,
                s.Num_Mensalidade,
                s.Valor,
                s.DataVencimento,
                s.ValorJuros,
                s.ValorMulta

            }).ToArray();

            dgvMensalidade.Update();
            dgvMensalidade.Refresh();
            SomaColuna();
        }

        private void CarregaCmbPlano()
        {

            //instancia uma coleção de alunos com base na procedure do Banco de Dados
            PlanosNegocios planosNegocios = new PlanosNegocios();
            PlanosColecao planosColecao = planosNegocios.Consultar();

            Planos planos = new Planos();
            planos.Cod_Plano = 0;
            planos.Desc_Plano = "";
            planosColecao.Insert(0, planos);
            this.cmbPlano.DataSource = planosColecao;
            this.cmbPlano.ValueMember = "Cod_Plano";
            this.cmbPlano.DisplayMember = "Desc_Plano";
            this.cmbPlano.SelectedIndex = 0;

        }

        private void CarregaAlunos()
        {
            AlunoNegocios alunoNegocios = new AlunoNegocios();
            AlunoColecao alunoColecao = alunoNegocios.ConsultarCombo();

            Aluno aluno = new Aluno();
            aluno.Cod_Aluno = 0;
            aluno.Nome_Aluno = "";
            alunoColecao.Insert(0, aluno);
            this.cmbAluno.DataSource = alunoColecao;
            this.cmbAluno.ValueMember = "Cod_Aluno";
            this.cmbAluno.DisplayMember = "Nome_Aluno";
            this.cmbAluno.SelectedIndex = 0;

        }

        private void CarregaTurma()
        {
            TurmaNegocios turmaNegocios = new TurmaNegocios();
            TurmaColecao turmaColecao = turmaNegocios.ConsultarCombo();

            Turma turma = new Turma();
            turma.Cod_Turma = 0;
            turma.Nome_Turma = "";
            turmaColecao.Insert(0, turma);
            this.cmbTurma.DataSource = turmaColecao;
            this.cmbTurma.ValueMember = "Cod_Turma";
            this.cmbTurma.DisplayMember = "Nome_Turma";
            this.cmbTurma.SelectedIndex = 0;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGeraMensalidades_Load(object sender, EventArgs e)
        {
            carregaGridMensalidade();
            CarregaAlunos();
            CarregaCmbPlano();
            CarregaTurma();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbAluno.SelectedIndex == 0 || cmbTurma.SelectedIndex == 0 || cmbPlano.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione todos os ítens obrigatórios para geração das mensalidades", "Erro ao gerar mensalidades", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                int qtdeParcelas = Convert.ToInt16(nudQtdeMensalidae.Value);
                PlanosNegocios planosNegocios = new PlanosNegocios();
                Planos planos = new Planos();
                planos  = planosNegocios.ConsultarValor(Convert.ToInt32(cmbPlano.SelectedValue));
                decimal valor = Convert.ToDecimal(planos.Valor);
                int codAluno = Convert.ToInt32(cmbAluno.SelectedValue);
                int codTurma = Convert.ToInt32(cmbTurma.SelectedValue);
                DateTime dataInicial = Convert.ToDateTime(dtpDataInicial.Value);
                
                for (var i = 1; i < qtdeParcelas + 1; i++)
                {
                    Mensalidade mensalidade = new Mensalidade();
                    MensalidadeNegocios mensalidadeNegocios = new MensalidadeNegocios();

                    mensalidade.turma = new Turma();
                    mensalidade.turma.Cod_Turma = codTurma;

                    mensalidade.aluno = new Aluno();
                    mensalidade.aluno.Cod_Aluno = codAluno;

                    mensalidade.Num_Mensalidade = Convert.ToString(i + "/" + qtdeParcelas);
                    mensalidade.Valor = valor;
                    mensalidade.DataVencimento = Convert.ToDateTime(dataInicial.AddMonths(i).ToShortDateString());
                    string retorno = mensalidadeNegocios.Inserir(mensalidade);
                    try
                    {
                        Convert.ToInt32(retorno);

                    }
                    catch 
                    {
                        MessageBox.Show("Não foi possivel inserir as mensalidades para esse aluno." + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

                MessageBox.Show("Registros gerados com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregaGridMensalidade();
            }

        }

        private void btConsultar_Click(object sender, EventArgs e)
        {

            if (cmbAluno.SelectedIndex == 0 || cmbTurma.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um aluno e uma turma para obter as respectivas mesalidades", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }

            carregaGridMensalidade();
        }

        private void SomaColuna()
        {
            foreach (DataGridViewRow row in dgvMensalidade.Rows)
            {
                row.Cells[8].Value = Convert.ToDecimal(row.Cells[5].Value)  + Convert.ToDecimal(row.Cells[6].Value)  + Convert.ToDecimal(row.Cells[7].Value);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarMensalidade_Click(object sender, EventArgs e)
        {
            if (dgvMensalidade.SelectedRows.Count == 0)
            {
                MessageBox.Show("Slecione uma mensalidade na lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            
            Mensalidade mensalidade = new Mensalidade();

            mensalidade.Cod_Mensalidade = Convert.ToInt32(dgvMensalidade.CurrentRow.Cells[0].Value);

            mensalidade.turma = new Turma();
            mensalidade.turma.Cod_Turma = Convert.ToInt32(dgvMensalidade.CurrentRow.Cells[1].Value);
              
            mensalidade.aluno = new Aluno();
            mensalidade.aluno.Cod_Aluno = Convert.ToInt32(dgvMensalidade.CurrentRow.Cells[2].Value);
            mensalidade.Num_Mensalidade = Convert.ToString(dgvMensalidade.CurrentRow.Cells[3].Value);
            mensalidade.DataVencimento = Convert.ToDateTime(dgvMensalidade.CurrentRow.Cells[4].Value);
            mensalidade.Valor = Convert.ToDecimal(dgvMensalidade.CurrentRow.Cells[5].Value);
            mensalidade.ValorJuros = Convert.ToDecimal(dgvMensalidade.CurrentRow.Cells[6].Value);
            mensalidade.ValorMulta = Convert.ToDecimal(dgvMensalidade.CurrentRow.Cells[7].Value);

            FrmMensalidadeAlterar frmMensalidadeAlterar = new FrmMensalidadeAlterar(mensalidade);
            DialogResult dialogResult = frmMensalidadeAlterar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                carregaGridMensalidade();
            }
        }

        private void btnExcluirHabitos_Click(object sender, EventArgs e)
        {
            if (dgvMensalidade.SelectedRows.Count == 0)
            {
                MessageBox.Show("Slecione uma mensalidade na lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }

            //x-x-x-x-x-x-x-x-x-x-x-x-
            
            Int32 selectedRowCount = dgvMensalidade.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
               
                for (int i = 0; i < selectedRowCount; i++)
                {
                    Mensalidade mensalidade = new Mensalidade();
                    mensalidade.Cod_Mensalidade = Convert.ToInt32(dgvMensalidade.SelectedRows[i].Cells[0].Value);
                    MensalidadeNegocios mensalidadeNegocios = new MensalidadeNegocios();
                    string retorno = mensalidadeNegocios.Excluir(mensalidade);
                    try
                    {
                        Convert.ToInt32(retorno);                    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível excluir a mensalidade" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                                       
                    
                }
                MessageBox.Show("Dados Excluídos com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregaGridMensalidade();
            }
                        
        }

        private void btnGerarCarnet_Click(object sender, EventArgs e)
        {
            if (dgvMensalidade.Rows.Count == 0)
            {
                MessageBox.Show("Somente serão impressas as \n mensalidades que estiverem na grade. ", "Grade Vazia", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            ppvCarnet.Document = carnet;
            ppvCarnet.ShowDialog();
            contador = 0;

            
            //Relatorios.FrmCarnetMensalidade frmCarnetMensalidade = new Relatorios.FrmCarnetMensalidade(Convert.ToInt32(cmbAluno.SelectedValue), Convert.ToInt32(cmbTurma.SelectedValue));
            //frmCarnetMensalidade.ShowDialog();
                       
        }

        private void carnet_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DadosEmpresaColecao dadosEmpresaColecao = new DadosEmpresaColecao();
            Dados_EmpresaNegocios dados_EmpresaNegocios = new Dados_EmpresaNegocios();
            dadosEmpresaColecao = dados_EmpresaNegocios.ConsultarRelatorio();

            DTOMensalidadeCarnetColecao dTOMensalidadeCarnetColecao = new DTOMensalidadeCarnetColecao();
            MensalidadeNegocios mensalidadeNegocios = new MensalidadeNegocios();
            dTOMensalidadeCarnetColecao = mensalidadeNegocios.ConsultarCarnet(Convert.ToInt32(cmbAluno.SelectedValue), Convert.ToInt32(cmbTurma.SelectedValue));

            //========================================================================================================================================================================
            //PREPARAÇÃO PARA IMPRESSÃO DO CARNET DE MENSALIDADE

            Font letra16 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel);
            Brush cor = new SolidBrush(Color.Black);
            //Rectangle rect1 = new Rectangle(5, 5, 750, 1160);
            Rectangle rect1 = new Rectangle(50, 35, 150, 50);
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            float pgLargura = e.PageSettings.PrintableArea.Width;
            float pgAltura = e.PageSettings.PrintableArea.Height;
            pages = 0;
            

            for (int i = contador; i < dTOMensalidadeCarnetColecao.Count; i++)
            {

                if (rect1.Y != 20) rect1.Y += 20;
                int pi = rect1.Y;
                string nrMatricula = string.Format("\nNº da Matrícula\n{0}", dTOMensalidadeCarnetColecao[i].Cod_ALuno.ToString());
                e.Graphics.DrawString(nrMatricula, letra16, cor, rect1, formato);
                e.Graphics.DrawRectangle(new Pen(cor), rect1);
                rect1.Y += rect1.Height;
                int ITENSpp = 4;
                int resto = dTOMensalidadeCarnetColecao.Count % ITENSpp;
                int nrpgina = 0;

                if (resto == 0)
                {
                    nrpgina = (dTOMensalidadeCarnetColecao.Count / ITENSpp);
                }
                else
                {
                    nrpgina = (dTOMensalidadeCarnetColecao.Count / ITENSpp) + 1;
                }


                //============================================================================================================================================
                string dtVcto = "Data do Vencimento\n\n" + dTOMensalidadeCarnetColecao[i].DataVencimento.ToString("dd/MM/yyyy");
                e.Graphics.DrawString(dtVcto, letra16, cor, rect1, formato);
                e.Graphics.DrawRectangle(new Pen(cor), rect1);
                rect1.Y += rect1.Height;
                //============================================================================================================================================
                string dtPgto = "Data do PAgamento\n\n ______/______/__________";
                e.Graphics.DrawString(dtPgto, letra16, cor, rect1, formato);
                e.Graphics.DrawRectangle(new Pen(cor), rect1);
                rect1.Y += rect1.Height;
                //============================================================================================================================================
                string parcela = String.Format("Parcela\n\n {0}", dTOMensalidadeCarnetColecao[i].Num_Mensalidade);
                e.Graphics.DrawString(parcela, letra16, cor, rect1, formato);
                e.Graphics.DrawRectangle(new Pen(cor), rect1);
                rect1.Y += rect1.Height;
                //============================================================================================================================================
                string valor = String.Format("Valor\n\n {0}", dTOMensalidadeCarnetColecao[i].Valor.ToString());
                e.Graphics.DrawString(valor, letra16, cor, rect1, formato);
                e.Graphics.DrawRectangle(new Pen(cor), rect1);
                rect1.Y += rect1.Height;
                //============================================================================================================================================
                //string nmAluno = "Aluno: " + dTOMensalidadeCarnetColecao[i].Nome_Aluno;
                //string endereco = string.Format("{0}, {1} - {2} - {3}", dadosEmpresaColecao[i].End_Rua, dadosEmpresaColecao[i].End_Nr.ToString(), dadosEmpresaColecao[i].End_Comp, dadosEmpresaColecao[i].Bairro);
                int pf = rect1.Height;
                Rectangle rect = new Rectangle(260, pi, 500, 250);
                e.Graphics.DrawRectangle(new Pen(cor), rect);
                //============================================================================================================================================
                Rectangle rect2 = new Rectangle(270, 35, 480, 25);
                rect2.Y = pi + 10;
                Font letra16b = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Pixel);
                string nmEmpresa = (from p in dadosEmpresaColecao select p.Nome_Fantasia).First().ToUpper();
                e.Graphics.DrawString(nmEmpresa, letra16b, cor, rect2, formato);
                e.Graphics.DrawRectangle(new Pen(cor), rect2);
                //============================================================================================================================================
                rect2.Y += 30;
                string nrMatricula1 = string.Format("Matrícula: {0}", (from p in dTOMensalidadeCarnetColecao select p.Cod_ALuno).First().ToString());
                e.Graphics.DrawString(nrMatricula1, letra16, cor, rect2, formato);
                //============================================================================================================================================
                rect2.Y += 30;
                string nmAluno = string.Format("Aluno: {0}", (from p in dTOMensalidadeCarnetColecao select p.Nome_Aluno).First().ToUpper());
                e.Graphics.DrawString(nmAluno, letra16, cor, rect2, formato);
                //============================================================================================================================================
                rect2.Y += 30;
                string dtvctoParc = string.Format("Data de Vcto: {0}                      Parcela: {1}", (from p in dTOMensalidadeCarnetColecao select p.DataVencimento).First().ToString("dd/MM/yyyy"), (from p in dTOMensalidadeCarnetColecao select p.Num_Mensalidade).First().ToString());
                e.Graphics.DrawString(dtvctoParc, letra16, cor, rect2, formato);
                //============================================================================================================================================
                rect2.Y += 30;
                string vlrDtPgto = string.Format("Valor: {0}                    Data de pagamento ____/____/_______", (from p in dTOMensalidadeCarnetColecao select p.Valor).First().ToString());
                e.Graphics.DrawString(vlrDtPgto, letra16, cor, rect2, formato);
                //============================================================================================================================================
                rect2.Y += 30;
                e.Graphics.DrawString("APÓS O VENCIMENTO SERÃO COBRADOS JUROS E MULTAS\n DEACORDO COM O CONTRATO DE PRESTAÇÃO DE SERVIÇOS", letra16, cor, rect2, formato);
                //============================================================================================================================================
                rect2.Y += 40;
                e.Graphics.DrawString("SECRETARIA: ___________________________________________________________", letra16, cor, rect2, formato);
                rect2.Y += 30;
                string endereco = string.Format("{0}, {1} - {2} - Bairro: {3}", (from p in dadosEmpresaColecao select p.End_Rua).First(), (from p in dadosEmpresaColecao select p.End_Nr).First(), (from p in dadosEmpresaColecao select p.End_Comp).First(), (from p in dadosEmpresaColecao select p.Bairro).First());
                e.Graphics.DrawString(endereco, letra16, cor, rect2, formato);

                if (rect1.Y > e.MarginBounds.Bottom)
                {
                    pages++;
                    contador = i + 1;

                    if (pages < nrpgina)
                    {                        
                        e.HasMorePages = i < dTOMensalidadeCarnetColecao.Count;
                        rect1.Y = 35;
                        return;
                    }
                    if (pages == nrpgina)
                    {
                        e.HasMorePages = false;
                    }

                }
                                                
            }
                     

        }

    }
}
