namespace UI
{
    partial class FrmCadDespesa
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
            this.PnlCadDespesa = new System.Windows.Forms.Panel();
            this.BtnSalvarDespesa = new System.Windows.Forms.Button();
            this.BtnCadastrarCategoriaDespesa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboConta = new System.Windows.Forms.ComboBox();
            this.cboCategoriaDespesa = new System.Windows.Forms.ComboBox();
            this.txtObservacaoDespesa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorDespesa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricaoDespesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mskVencimento = new System.Windows.Forms.MaskedTextBox();
            this.PnlCadDespesa.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlCadDespesa
            // 
            this.PnlCadDespesa.BackColor = System.Drawing.Color.White;
            this.PnlCadDespesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCadDespesa.Controls.Add(this.mskVencimento);
            this.PnlCadDespesa.Controls.Add(this.BtnSalvarDespesa);
            this.PnlCadDespesa.Controls.Add(this.BtnCadastrarCategoriaDespesa);
            this.PnlCadDespesa.Controls.Add(this.label6);
            this.PnlCadDespesa.Controls.Add(this.label5);
            this.PnlCadDespesa.Controls.Add(this.label4);
            this.PnlCadDespesa.Controls.Add(this.cboConta);
            this.PnlCadDespesa.Controls.Add(this.cboCategoriaDespesa);
            this.PnlCadDespesa.Controls.Add(this.txtObservacaoDespesa);
            this.PnlCadDespesa.Controls.Add(this.label7);
            this.PnlCadDespesa.Controls.Add(this.txtValorDespesa);
            this.PnlCadDespesa.Controls.Add(this.label3);
            this.PnlCadDespesa.Controls.Add(this.txtDescricaoDespesa);
            this.PnlCadDespesa.Controls.Add(this.label2);
            this.PnlCadDespesa.Controls.Add(this.panel2);
            this.PnlCadDespesa.Location = new System.Drawing.Point(12, 12);
            this.PnlCadDespesa.Name = "PnlCadDespesa";
            this.PnlCadDespesa.Size = new System.Drawing.Size(380, 348);
            this.PnlCadDespesa.TabIndex = 0;
            // 
            // BtnSalvarDespesa
            // 
            this.BtnSalvarDespesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
            this.BtnSalvarDespesa.FlatAppearance.BorderSize = 0;
            this.BtnSalvarDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvarDespesa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarDespesa.ForeColor = System.Drawing.Color.White;
            this.BtnSalvarDespesa.Location = new System.Drawing.Point(10, 304);
            this.BtnSalvarDespesa.Name = "BtnSalvarDespesa";
            this.BtnSalvarDespesa.Size = new System.Drawing.Size(358, 35);
            this.BtnSalvarDespesa.TabIndex = 14;
            this.BtnSalvarDespesa.Text = "Salvar Despesa";
            this.BtnSalvarDespesa.UseVisualStyleBackColor = false;
            this.BtnSalvarDespesa.Click += new System.EventHandler(this.BtnSalvarDespesa_Click);
            // 
            // BtnCadastrarCategoriaDespesa
            // 
            this.BtnCadastrarCategoriaDespesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(167)))), ((int)(((byte)(80)))));
            this.BtnCadastrarCategoriaDespesa.FlatAppearance.BorderSize = 0;
            this.BtnCadastrarCategoriaDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrarCategoriaDespesa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarCategoriaDespesa.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarCategoriaDespesa.Location = new System.Drawing.Point(192, 129);
            this.BtnCadastrarCategoriaDespesa.Name = "BtnCadastrarCategoriaDespesa";
            this.BtnCadastrarCategoriaDespesa.Size = new System.Drawing.Size(30, 24);
            this.BtnCadastrarCategoriaDespesa.TabIndex = 7;
            this.BtnCadastrarCategoriaDespesa.Text = "+";
            this.BtnCadastrarCategoriaDespesa.UseVisualStyleBackColor = false;
            this.BtnCadastrarCategoriaDespesa.Click += new System.EventHandler(this.BtnCategoriaDespesa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vencimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Categoria";
            // 
            // cboConta
            // 
            this.cboConta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConta.FormattingEnabled = true;
            this.cboConta.Location = new System.Drawing.Point(11, 174);
            this.cboConta.Name = "cboConta";
            this.cboConta.Size = new System.Drawing.Size(135, 24);
            this.cboConta.TabIndex = 9;
            // 
            // cboCategoriaDespesa
            // 
            this.cboCategoriaDespesa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoriaDespesa.FormattingEnabled = true;
            this.cboCategoriaDespesa.Location = new System.Drawing.Point(10, 129);
            this.cboCategoriaDespesa.Name = "cboCategoriaDespesa";
            this.cboCategoriaDespesa.Size = new System.Drawing.Size(176, 24);
            this.cboCategoriaDespesa.TabIndex = 6;
            // 
            // txtObservacaoDespesa
            // 
            this.txtObservacaoDespesa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacaoDespesa.Location = new System.Drawing.Point(10, 218);
            this.txtObservacaoDespesa.Multiline = true;
            this.txtObservacaoDespesa.Name = "txtObservacaoDespesa";
            this.txtObservacaoDespesa.Size = new System.Drawing.Size(358, 80);
            this.txtObservacaoDespesa.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Observações";
            // 
            // txtValorDespesa
            // 
            this.txtValorDespesa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDespesa.Location = new System.Drawing.Point(236, 82);
            this.txtValorDespesa.Name = "txtValorDespesa";
            this.txtValorDespesa.Size = new System.Drawing.Size(132, 23);
            this.txtValorDespesa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // txtDescricaoDespesa
            // 
            this.txtDescricaoDespesa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoDespesa.Location = new System.Drawing.Point(10, 82);
            this.txtDescricaoDespesa.Name = "txtDescricaoDespesa";
            this.txtDescricaoDespesa.Size = new System.Drawing.Size(220, 23);
            this.txtDescricaoDespesa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(63)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 47);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Despesa";
            // 
            // mskVencimento
            // 
            this.mskVencimento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskVencimento.Location = new System.Drawing.Point(236, 129);
            this.mskVencimento.Mask = "00/00/0000";
            this.mskVencimento.Name = "mskVencimento";
            this.mskVencimento.Size = new System.Drawing.Size(100, 23);
            this.mskVencimento.TabIndex = 15;
            this.mskVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // FrmCadDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 378);
            this.Controls.Add(this.PnlCadDespesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCadDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Despesas";
            this.Load += new System.EventHandler(this.FrmCadDespesa_Load);
            this.PnlCadDespesa.ResumeLayout(false);
            this.PnlCadDespesa.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCadDespesa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservacaoDespesa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorDespesa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricaoDespesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboConta;
        private System.Windows.Forms.ComboBox cboCategoriaDespesa;
        private System.Windows.Forms.Button BtnCadastrarCategoriaDespesa;
        private System.Windows.Forms.Button BtnSalvarDespesa;
        private System.Windows.Forms.MaskedTextBox mskVencimento;
    }
}