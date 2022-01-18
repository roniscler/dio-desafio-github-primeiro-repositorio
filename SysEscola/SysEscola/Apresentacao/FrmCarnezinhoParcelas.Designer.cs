namespace Apresentacao
{
    partial class FrmCarnezinhoParcelas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstTitulo = new System.Windows.Forms.ListBox();
            this.lblTitulos = new System.Windows.Forms.Label();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.clmnCod_Carnezinho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCod_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNome_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnData_Vcto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListarParcelas = new System.Windows.Forms.Button();
            this.gpbExculsaoParcelas = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.rdbSomenteSelecioada = new System.Windows.Forms.RadioButton();
            this.rdbAlunoSelecionado = new System.Windows.Forms.RadioButton();
            this.rdbTodas = new System.Windows.Forms.RadioButton();
            this.gpbImpressao = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.rbdTodas = new System.Windows.Forms.RadioButton();
            this.rbdAluno = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.gpbExculsaoParcelas.SuspendLayout();
            this.gpbImpressao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTitulo
            // 
            this.lstTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTitulo.FormattingEnabled = true;
            this.lstTitulo.ItemHeight = 24;
            this.lstTitulo.Location = new System.Drawing.Point(12, 60);
            this.lstTitulo.Name = "lstTitulo";
            this.lstTitulo.Size = new System.Drawing.Size(303, 676);
            this.lstTitulo.TabIndex = 1;
            // 
            // lblTitulos
            // 
            this.lblTitulos.AutoSize = true;
            this.lblTitulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulos.Location = new System.Drawing.Point(39, 19);
            this.lblTitulos.Name = "lblTitulos";
            this.lblTitulos.Size = new System.Drawing.Size(237, 24);
            this.lblTitulos.TabIndex = 2;
            this.lblTitulos.Text = "Títulos Gerados no sistema";
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelas.ForeColor = System.Drawing.SystemColors.Control;
            this.lblParcelas.Location = new System.Drawing.Point(515, 19);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(267, 24);
            this.lblParcelas.TabIndex = 3;
            this.lblParcelas.Text = "Detalhes das parcelas geradas";
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParcelas.ColumnHeadersHeight = 40;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCod_Carnezinho,
            this.clmnCod_Aluno,
            this.clmnNome_Aluno,
            this.clmnParcela,
            this.clmnData_Vcto,
            this.clmnValor,
            this.clmnTitulo});
            this.dgvParcelas.Location = new System.Drawing.Point(321, 60);
            this.dgvParcelas.MultiSelect = false;
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowHeadersVisible = false;
            this.dgvParcelas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(670, 556);
            this.dgvParcelas.TabIndex = 4;
            // 
            // clmnCod_Carnezinho
            // 
            this.clmnCod_Carnezinho.DataPropertyName = "Cod_Carnezinho";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnCod_Carnezinho.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmnCod_Carnezinho.HeaderText = "Codigo";
            this.clmnCod_Carnezinho.Name = "clmnCod_Carnezinho";
            this.clmnCod_Carnezinho.ReadOnly = true;
            this.clmnCod_Carnezinho.Visible = false;
            // 
            // clmnCod_Aluno
            // 
            this.clmnCod_Aluno.DataPropertyName = "Cod_Aluno";
            this.clmnCod_Aluno.HeaderText = "codigo do aluno";
            this.clmnCod_Aluno.Name = "clmnCod_Aluno";
            this.clmnCod_Aluno.ReadOnly = true;
            this.clmnCod_Aluno.Visible = false;
            // 
            // clmnNome_Aluno
            // 
            this.clmnNome_Aluno.DataPropertyName = "Nome_Aluno";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clmnNome_Aluno.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmnNome_Aluno.HeaderText = "Nomo do Aluno";
            this.clmnNome_Aluno.Name = "clmnNome_Aluno";
            this.clmnNome_Aluno.ReadOnly = true;
            this.clmnNome_Aluno.Width = 250;
            // 
            // clmnParcela
            // 
            this.clmnParcela.DataPropertyName = "Parcela";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnParcela.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmnParcela.HeaderText = "Parcela";
            this.clmnParcela.Name = "clmnParcela";
            this.clmnParcela.ReadOnly = true;
            this.clmnParcela.Width = 150;
            // 
            // clmnData_Vcto
            // 
            this.clmnData_Vcto.DataPropertyName = "Data_Vcto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnData_Vcto.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmnData_Vcto.HeaderText = "Vencimento";
            this.clmnData_Vcto.Name = "clmnData_Vcto";
            this.clmnData_Vcto.ReadOnly = true;
            this.clmnData_Vcto.Width = 150;
            // 
            // clmnValor
            // 
            this.clmnValor.DataPropertyName = "Valor";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmnValor.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmnValor.HeaderText = "Valor";
            this.clmnValor.Name = "clmnValor";
            this.clmnValor.ReadOnly = true;
            // 
            // clmnTitulo
            // 
            this.clmnTitulo.DataPropertyName = "Titulo";
            this.clmnTitulo.HeaderText = "Titulo";
            this.clmnTitulo.Name = "clmnTitulo";
            this.clmnTitulo.ReadOnly = true;
            this.clmnTitulo.Visible = false;
            // 
            // btnListarParcelas
            // 
            this.btnListarParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarParcelas.ForeColor = System.Drawing.Color.Teal;
            this.btnListarParcelas.Location = new System.Drawing.Point(12, 738);
            this.btnListarParcelas.Name = "btnListarParcelas";
            this.btnListarParcelas.Size = new System.Drawing.Size(303, 55);
            this.btnListarParcelas.TabIndex = 5;
            this.btnListarParcelas.Text = "Listar Parcelas do Titulo selecionado";
            this.btnListarParcelas.UseVisualStyleBackColor = true;
            this.btnListarParcelas.Click += new System.EventHandler(this.btnListarParcelas_Click);
            // 
            // gpbExculsaoParcelas
            // 
            this.gpbExculsaoParcelas.Controls.Add(this.btnExcluir);
            this.gpbExculsaoParcelas.Controls.Add(this.rdbSomenteSelecioada);
            this.gpbExculsaoParcelas.Controls.Add(this.rdbAlunoSelecionado);
            this.gpbExculsaoParcelas.Controls.Add(this.rdbTodas);
            this.gpbExculsaoParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbExculsaoParcelas.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbExculsaoParcelas.Location = new System.Drawing.Point(660, 626);
            this.gpbExculsaoParcelas.Name = "gpbExculsaoParcelas";
            this.gpbExculsaoParcelas.Size = new System.Drawing.Size(331, 167);
            this.gpbExculsaoParcelas.TabIndex = 9;
            this.gpbExculsaoParcelas.TabStop = false;
            this.gpbExculsaoParcelas.Text = "Exclusao de Parcelas";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Teal;
            this.btnExcluir.Location = new System.Drawing.Point(93, 116);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(140, 42);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // rdbSomenteSelecioada
            // 
            this.rdbSomenteSelecioada.AutoSize = true;
            this.rdbSomenteSelecioada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSomenteSelecioada.Location = new System.Drawing.Point(56, 87);
            this.rdbSomenteSelecioada.Name = "rdbSomenteSelecioada";
            this.rdbSomenteSelecioada.Size = new System.Drawing.Size(240, 24);
            this.rdbSomenteSelecioada.TabIndex = 2;
            this.rdbSomenteSelecioada.TabStop = true;
            this.rdbSomenteSelecioada.Text = "Somente parcela Selecionada";
            this.rdbSomenteSelecioada.UseVisualStyleBackColor = true;
            // 
            // rdbAlunoSelecionado
            // 
            this.rdbAlunoSelecionado.AutoSize = true;
            this.rdbAlunoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlunoSelecionado.Location = new System.Drawing.Point(56, 59);
            this.rdbAlunoSelecionado.Name = "rdbAlunoSelecionado";
            this.rdbAlunoSelecionado.Size = new System.Drawing.Size(242, 24);
            this.rdbAlunoSelecionado.TabIndex = 1;
            this.rdbAlunoSelecionado.TabStop = true;
            this.rdbAlunoSelecionado.Text = "Parcelas do aluno selecionado";
            this.rdbAlunoSelecionado.UseVisualStyleBackColor = true;
            // 
            // rdbTodas
            // 
            this.rdbTodas.AutoSize = true;
            this.rdbTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodas.Location = new System.Drawing.Point(56, 30);
            this.rdbTodas.Name = "rdbTodas";
            this.rdbTodas.Size = new System.Drawing.Size(216, 24);
            this.rdbTodas.TabIndex = 0;
            this.rdbTodas.TabStop = true;
            this.rdbTodas.Text = "Todas parcelas do sistema";
            this.rdbTodas.UseVisualStyleBackColor = true;
            // 
            // gpbImpressao
            // 
            this.gpbImpressao.Controls.Add(this.btnImprimir);
            this.gpbImpressao.Controls.Add(this.rbdTodas);
            this.gpbImpressao.Controls.Add(this.rbdAluno);
            this.gpbImpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbImpressao.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbImpressao.Location = new System.Drawing.Point(321, 626);
            this.gpbImpressao.Name = "gpbImpressao";
            this.gpbImpressao.Size = new System.Drawing.Size(331, 167);
            this.gpbImpressao.TabIndex = 10;
            this.gpbImpressao.TabStop = false;
            this.gpbImpressao.Text = "Imoressão de Parcelas";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Teal;
            this.btnImprimir.Location = new System.Drawing.Point(93, 112);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(140, 42);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // rbdTodas
            // 
            this.rbdTodas.AutoSize = true;
            this.rbdTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdTodas.Location = new System.Drawing.Point(58, 71);
            this.rbdTodas.Name = "rbdTodas";
            this.rbdTodas.Size = new System.Drawing.Size(223, 24);
            this.rbdTodas.TabIndex = 1;
            this.rbdTodas.TabStop = true;
            this.rbdTodas.Text = "Todas as parcelas da grade";
            this.rbdTodas.UseVisualStyleBackColor = true;
            // 
            // rbdAluno
            // 
            this.rbdAluno.AutoSize = true;
            this.rbdAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdAluno.Location = new System.Drawing.Point(58, 36);
            this.rbdAluno.Name = "rbdAluno";
            this.rbdAluno.Size = new System.Drawing.Size(242, 24);
            this.rbdAluno.TabIndex = 0;
            this.rbdAluno.TabStop = true;
            this.rbdAluno.Text = "Parcelas do aluno selecionado";
            this.rbdAluno.UseVisualStyleBackColor = true;
            // 
            // FrmCarnezinhoParcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1006, 805);
            this.Controls.Add(this.gpbImpressao);
            this.Controls.Add(this.gpbExculsaoParcelas);
            this.Controls.Add(this.btnListarParcelas);
            this.Controls.Add(this.dgvParcelas);
            this.Controls.Add(this.lblParcelas);
            this.Controls.Add(this.lblTitulos);
            this.Controls.Add(this.lstTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarnezinhoParcelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar parcelas do carnezinho";
            this.Load += new System.EventHandler(this.FrmParcelasCarnezinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.gpbExculsaoParcelas.ResumeLayout(false);
            this.gpbExculsaoParcelas.PerformLayout();
            this.gpbImpressao.ResumeLayout(false);
            this.gpbImpressao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTitulo;
        private System.Windows.Forms.Label lblTitulos;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Button btnListarParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Carnezinho;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCod_Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNome_Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnData_Vcto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTitulo;
        private System.Windows.Forms.GroupBox gpbExculsaoParcelas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.RadioButton rdbSomenteSelecioada;
        private System.Windows.Forms.RadioButton rdbAlunoSelecionado;
        private System.Windows.Forms.RadioButton rdbTodas;
        private System.Windows.Forms.GroupBox gpbImpressao;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.RadioButton rbdTodas;
        private System.Windows.Forms.RadioButton rbdAluno;
    }
}