namespace UI
{
    partial class FrmCategoriaDespesa
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
            this.PnlCadCategoriaDespesa = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCadastrarDespesaReceita = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgvListDespesa = new System.Windows.Forms.DataGridView();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.PnlCadCategoriaDespesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDespesa)).BeginInit();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlCadCategoriaDespesa
            // 
            this.PnlCadCategoriaDespesa.BackColor = System.Drawing.Color.White;
            this.PnlCadCategoriaDespesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCadCategoriaDespesa.Controls.Add(this.btnSalvar);
            this.PnlCadCategoriaDespesa.Controls.Add(this.txtCadastrarDespesaReceita);
            this.PnlCadCategoriaDespesa.Controls.Add(this.btnExcluir);
            this.PnlCadCategoriaDespesa.Controls.Add(this.btnAlterar);
            this.PnlCadCategoriaDespesa.Controls.Add(this.dgvListDespesa);
            this.PnlCadCategoriaDespesa.Controls.Add(this.panel15);
            this.PnlCadCategoriaDespesa.Location = new System.Drawing.Point(15, 12);
            this.PnlCadCategoriaDespesa.Name = "PnlCadCategoriaDespesa";
            this.PnlCadCategoriaDespesa.Size = new System.Drawing.Size(476, 396);
            this.PnlCadCategoriaDespesa.TabIndex = 10;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(221, 74);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 27);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // txtCadastrarDespesaReceita
            // 
            this.txtCadastrarDespesaReceita.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarDespesaReceita.Location = new System.Drawing.Point(12, 74);
            this.txtCadastrarDespesaReceita.Name = "txtCadastrarDespesaReceita";
            this.txtCadastrarDespesaReceita.Size = new System.Drawing.Size(203, 27);
            this.txtCadastrarDespesaReceita.TabIndex = 15;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(110)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(245, 353);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 28);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(207)))), ((int)(((byte)(113)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(361, 353);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 28);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // dgvListDespesa
            // 
            this.dgvListDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDespesa.Location = new System.Drawing.Point(3, 144);
            this.dgvListDespesa.Name = "dgvListDespesa";
            this.dgvListDespesa.Size = new System.Drawing.Size(468, 203);
            this.dgvListDespesa.TabIndex = 4;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(63)))), ((int)(((byte)(59)))));
            this.panel15.Controls.Add(this.label8);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(474, 57);
            this.panel15.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lista de Categorias";
            // 
            // FrmCategoriaDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(505, 421);
            this.Controls.Add(this.PnlCadCategoriaDespesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCategoriaDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria de Despesa";
            this.PnlCadCategoriaDespesa.ResumeLayout(false);
            this.PnlCadCategoriaDespesa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDespesa)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlCadCategoriaDespesa;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCadastrarDespesaReceita;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgvListDespesa;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label8;
    }
}