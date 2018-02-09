namespace EmpresaMySQLApp
{
    partial class FormFuncionarios
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
            this.labelNomeDepartamento = new System.Windows.Forms.Label();
            this.comboBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.labelIdDepartamento = new System.Windows.Forms.Label();
            this.textBoxIdDepartamento = new System.Windows.Forms.TextBox();
            this.groupBoxFuncionario = new System.Windows.Forms.GroupBox();
            this.ButtonElimina = new System.Windows.Forms.Button();
            this.ButtonEdita = new System.Windows.Forms.Button();
            this.ButtonInsere = new System.Windows.Forms.Button();
            this.textBoxIdFuncionario = new System.Windows.Forms.TextBox();
            this.labelIdFuncionario = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.dataGridViewFuncionarios = new System.Windows.Forms.DataGridView();
            this.groupBoxFuncionarios = new System.Windows.Forms.GroupBox();
            this.ButtonAtualizarDataGridView = new System.Windows.Forms.Button();
            this.groupBoxFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionarios)).BeginInit();
            this.groupBoxFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNomeDepartamento
            // 
            this.labelNomeDepartamento.AutoSize = true;
            this.labelNomeDepartamento.Location = new System.Drawing.Point(6, 49);
            this.labelNomeDepartamento.Name = "labelNomeDepartamento";
            this.labelNomeDepartamento.Size = new System.Drawing.Size(121, 13);
            this.labelNomeDepartamento.TabIndex = 0;
            this.labelNomeDepartamento.Text = "Nome do departamento:";
            // 
            // comboBoxDepartamento
            // 
            this.comboBoxDepartamento.FormattingEnabled = true;
            this.comboBoxDepartamento.Location = new System.Drawing.Point(133, 46);
            this.comboBoxDepartamento.Name = "comboBoxDepartamento";
            this.comboBoxDepartamento.Size = new System.Drawing.Size(294, 21);
            this.comboBoxDepartamento.TabIndex = 1;
            this.comboBoxDepartamento.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartamento_SelectedIndexChanged);
            // 
            // labelIdDepartamento
            // 
            this.labelIdDepartamento.AutoSize = true;
            this.labelIdDepartamento.Location = new System.Drawing.Point(25, 23);
            this.labelIdDepartamento.Name = "labelIdDepartamento";
            this.labelIdDepartamento.Size = new System.Drawing.Size(102, 13);
            this.labelIdDepartamento.TabIndex = 2;
            this.labelIdDepartamento.Text = "Id do departamento:";
            // 
            // textBoxIdDepartamento
            // 
            this.textBoxIdDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxIdDepartamento.Location = new System.Drawing.Point(133, 20);
            this.textBoxIdDepartamento.Name = "textBoxIdDepartamento";
            this.textBoxIdDepartamento.ReadOnly = true;
            this.textBoxIdDepartamento.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdDepartamento.TabIndex = 3;
            // 
            // groupBoxFuncionario
            // 
            this.groupBoxFuncionario.Controls.Add(this.ButtonElimina);
            this.groupBoxFuncionario.Controls.Add(this.ButtonEdita);
            this.groupBoxFuncionario.Controls.Add(this.ButtonInsere);
            this.groupBoxFuncionario.Controls.Add(this.textBoxIdFuncionario);
            this.groupBoxFuncionario.Controls.Add(this.labelIdFuncionario);
            this.groupBoxFuncionario.Controls.Add(this.textBoxNome);
            this.groupBoxFuncionario.Controls.Add(this.labelNome);
            this.groupBoxFuncionario.Controls.Add(this.labelNomeDepartamento);
            this.groupBoxFuncionario.Controls.Add(this.textBoxIdDepartamento);
            this.groupBoxFuncionario.Controls.Add(this.comboBoxDepartamento);
            this.groupBoxFuncionario.Controls.Add(this.labelIdDepartamento);
            this.groupBoxFuncionario.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFuncionario.Name = "groupBoxFuncionario";
            this.groupBoxFuncionario.Size = new System.Drawing.Size(760, 134);
            this.groupBoxFuncionario.TabIndex = 4;
            this.groupBoxFuncionario.TabStop = false;
            this.groupBoxFuncionario.Text = "Dados do Funcionario";
            // 
            // ButtonElimina
            // 
            this.ButtonElimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonElimina.Location = new System.Drawing.Point(684, 46);
            this.ButtonElimina.Name = "ButtonElimina";
            this.ButtonElimina.Size = new System.Drawing.Size(59, 47);
            this.ButtonElimina.TabIndex = 10;
            this.ButtonElimina.Text = "Eliminar";
            this.ButtonElimina.UseVisualStyleBackColor = false;
            this.ButtonElimina.Click += new System.EventHandler(this.ButtonElimina_Click);
            // 
            // ButtonEdita
            // 
            this.ButtonEdita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonEdita.Location = new System.Drawing.Point(593, 46);
            this.ButtonEdita.Name = "ButtonEdita";
            this.ButtonEdita.Size = new System.Drawing.Size(56, 47);
            this.ButtonEdita.TabIndex = 9;
            this.ButtonEdita.Text = "Atualizar";
            this.ButtonEdita.UseVisualStyleBackColor = false;
            this.ButtonEdita.Click += new System.EventHandler(this.ButtonAtualiza_Click);
            // 
            // ButtonInsere
            // 
            this.ButtonInsere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonInsere.Location = new System.Drawing.Point(442, 46);
            this.ButtonInsere.Name = "ButtonInsere";
            this.ButtonInsere.Size = new System.Drawing.Size(145, 47);
            this.ButtonInsere.TabIndex = 8;
            this.ButtonInsere.Text = "Inserir";
            this.ButtonInsere.UseVisualStyleBackColor = false;
            this.ButtonInsere.Click += new System.EventHandler(this.ButtonInsere_Click);
            // 
            // textBoxIdFuncionario
            // 
            this.textBoxIdFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxIdFuncionario.Location = new System.Drawing.Point(133, 102);
            this.textBoxIdFuncionario.Name = "textBoxIdFuncionario";
            this.textBoxIdFuncionario.ReadOnly = true;
            this.textBoxIdFuncionario.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdFuncionario.TabIndex = 7;
            // 
            // labelIdFuncionario
            // 
            this.labelIdFuncionario.AutoSize = true;
            this.labelIdFuncionario.Location = new System.Drawing.Point(41, 105);
            this.labelIdFuncionario.Name = "labelIdFuncionario";
            this.labelIdFuncionario.Size = new System.Drawing.Size(86, 13);
            this.labelIdFuncionario.TabIndex = 6;
            this.labelIdFuncionario.Text = "Id do funcionário";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(133, 73);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(294, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(89, 76);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome:";
            // 
            // dataGridViewFuncionarios
            // 
            this.dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionarios.Location = new System.Drawing.Point(19, 48);
            this.dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            this.dataGridViewFuncionarios.Size = new System.Drawing.Size(709, 268);
            this.dataGridViewFuncionarios.TabIndex = 5;
            this.dataGridViewFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFuncionarios_CellClick);
            // 
            // groupBoxFuncionarios
            // 
            this.groupBoxFuncionarios.Controls.Add(this.ButtonAtualizarDataGridView);
            this.groupBoxFuncionarios.Controls.Add(this.dataGridViewFuncionarios);
            this.groupBoxFuncionarios.Location = new System.Drawing.Point(21, 190);
            this.groupBoxFuncionarios.Name = "groupBoxFuncionarios";
            this.groupBoxFuncionarios.Size = new System.Drawing.Size(734, 349);
            this.groupBoxFuncionarios.TabIndex = 6;
            this.groupBoxFuncionarios.TabStop = false;
            this.groupBoxFuncionarios.Text = "Funcionários";
            // 
            // ButtonAtualizarDataGridView
            // 
            this.ButtonAtualizarDataGridView.Location = new System.Drawing.Point(275, 19);
            this.ButtonAtualizarDataGridView.Name = "ButtonAtualizarDataGridView";
            this.ButtonAtualizarDataGridView.Size = new System.Drawing.Size(188, 23);
            this.ButtonAtualizarDataGridView.TabIndex = 6;
            this.ButtonAtualizarDataGridView.Text = "Atualizar";
            this.ButtonAtualizarDataGridView.UseVisualStyleBackColor = true;
            this.ButtonAtualizarDataGridView.Click += new System.EventHandler(this.ButtonAtualizarDataGridView_Click);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBoxFuncionarios);
            this.Controls.Add(this.groupBoxFuncionario);
            this.Name = "FormFuncionarios";
            this.Text = "Gestão de funcionários da empresa";
            this.groupBoxFuncionario.ResumeLayout(false);
            this.groupBoxFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionarios)).EndInit();
            this.groupBoxFuncionarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNomeDepartamento;
        private System.Windows.Forms.ComboBox comboBoxDepartamento;
        private System.Windows.Forms.Label labelIdDepartamento;
        private System.Windows.Forms.TextBox textBoxIdDepartamento;
        private System.Windows.Forms.GroupBox groupBoxFuncionario;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button ButtonElimina;
        private System.Windows.Forms.Button ButtonEdita;
        private System.Windows.Forms.Button ButtonInsere;
        private System.Windows.Forms.TextBox textBoxIdFuncionario;
        private System.Windows.Forms.Label labelIdFuncionario;
        private System.Windows.Forms.DataGridView dataGridViewFuncionarios;
        private System.Windows.Forms.GroupBox groupBoxFuncionarios;
        private System.Windows.Forms.Button ButtonAtualizarDataGridView;
    }
}

