namespace UI
{
    partial class FrmReceitas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlListReceita = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.DgvCadListReceita = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPesquisarReceita = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovaReceita = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlListReceita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCadListReceita)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlListReceita
            // 
            this.PnlListReceita.BackColor = System.Drawing.Color.White;
            this.PnlListReceita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlListReceita.Controls.Add(this.btnExcluir);
            this.PnlListReceita.Controls.Add(this.btnAlterar);
            this.PnlListReceita.Controls.Add(this.DgvCadListReceita);
            this.PnlListReceita.Controls.Add(this.btnBuscar);
            this.PnlListReceita.Controls.Add(this.txtPesquisarReceita);
            this.PnlListReceita.Controls.Add(this.panel2);
            this.PnlListReceita.Location = new System.Drawing.Point(13, 130);
            this.PnlListReceita.Name = "PnlListReceita";
            this.PnlListReceita.Size = new System.Drawing.Size(687, 428);
            this.PnlListReceita.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(110)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(446, 388);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 28);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(207)))), ((int)(((byte)(113)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(562, 388);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 28);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // DgvCadListReceita
            // 
            this.DgvCadListReceita.AllowUserToAddRows = false;
            this.DgvCadListReceita.AllowUserToDeleteRows = false;
            this.DgvCadListReceita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCadListReceita.Location = new System.Drawing.Point(7, 109);
            this.DgvCadListReceita.Name = "DgvCadListReceita";
            this.DgvCadListReceita.ReadOnly = true;
            this.DgvCadListReceita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCadListReceita.Size = new System.Drawing.Size(665, 273);
            this.DgvCadListReceita.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(591, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 27);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPesquisarReceita
            // 
            this.txtPesquisarReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarReceita.Location = new System.Drawing.Point(378, 63);
            this.txtPesquisarReceita.Name = "txtPesquisarReceita";
            this.txtPesquisarReceita.Size = new System.Drawing.Size(207, 26);
            this.txtPesquisarReceita.TabIndex = 1;
            this.txtPesquisarReceita.TextChanged += new System.EventHandler(this.txtPesquisarReceita_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 57);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Histórico de Receitas";
            // 
            // btnNovaReceita
            // 
            this.btnNovaReceita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(167)))), ((int)(((byte)(80)))));
            this.btnNovaReceita.FlatAppearance.BorderSize = 0;
            this.btnNovaReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaReceita.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaReceita.ForeColor = System.Drawing.Color.White;
            this.btnNovaReceita.Location = new System.Drawing.Point(14, 76);
            this.btnNovaReceita.Name = "btnNovaReceita";
            this.btnNovaReceita.Size = new System.Drawing.Size(161, 39);
            this.btnNovaReceita.TabIndex = 1;
            this.btnNovaReceita.Text = "Nova Transação";
            this.btnNovaReceita.UseVisualStyleBackColor = false;
            this.btnNovaReceita.Click += new System.EventHandler(this.CadReceita_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Receitas Cadastradas";
            // 
            // FrmReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(715, 576);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNovaReceita);
            this.Controls.Add(this.PnlListReceita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReceitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receitas";
            this.Load += new System.EventHandler(this.FrmReceitas_Load);
            this.PnlListReceita.ResumeLayout(false);
            this.PnlListReceita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCadListReceita)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlListReceita;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPesquisarReceita;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovaReceita;
        private System.Windows.Forms.DataGridView DgvCadListReceita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
    }
}

