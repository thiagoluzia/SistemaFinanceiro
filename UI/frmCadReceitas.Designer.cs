﻿namespace UI
{
    partial class FrmCadReceita
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
            this.txtObservacaoReceita = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboConta = new System.Windows.Forms.ComboBox();
            this.cboCategoriaReceita = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricaoReceita = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlCadReceita = new System.Windows.Forms.Panel();
            this.btnConta = new System.Windows.Forms.Button();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.mskVencimento = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCadastrarCategoriaReceita = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.PnlCadReceita.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtObservacaoReceita
            // 
            this.txtObservacaoReceita.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacaoReceita.Location = new System.Drawing.Point(10, 218);
            this.txtObservacaoReceita.Multiline = true;
            this.txtObservacaoReceita.Name = "txtObservacaoReceita";
            this.txtObservacaoReceita.Size = new System.Drawing.Size(358, 80);
            this.txtObservacaoReceita.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Observações";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "*Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "*Categoria";
            // 
            // cboConta
            // 
            this.cboConta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConta.FormattingEnabled = true;
            this.cboConta.Location = new System.Drawing.Point(11, 172);
            this.cboConta.Name = "cboConta";
            this.cboConta.Size = new System.Drawing.Size(135, 24);
            this.cboConta.TabIndex = 4;
            // 
            // cboCategoriaReceita
            // 
            this.cboCategoriaReceita.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoriaReceita.FormattingEnabled = true;
            this.cboCategoriaReceita.Location = new System.Drawing.Point(10, 127);
            this.cboCategoriaReceita.Name = "cboCategoriaReceita";
            this.cboCategoriaReceita.Size = new System.Drawing.Size(176, 24);
            this.cboCategoriaReceita.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "*Valor";
            // 
            // txtDescricaoReceita
            // 
            this.txtDescricaoReceita.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoReceita.Location = new System.Drawing.Point(10, 82);
            this.txtDescricaoReceita.Name = "txtDescricaoReceita";
            this.txtDescricaoReceita.Size = new System.Drawing.Size(220, 23);
            this.txtDescricaoReceita.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "*Descrição";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(182)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 47);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receita";
            // 
            // PnlCadReceita
            // 
            this.PnlCadReceita.BackColor = System.Drawing.Color.White;
            this.PnlCadReceita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCadReceita.Controls.Add(this.btnConta);
            this.PnlCadReceita.Controls.Add(this.mskValor);
            this.PnlCadReceita.Controls.Add(this.mskVencimento);
            this.PnlCadReceita.Controls.Add(this.btnSalvar);
            this.PnlCadReceita.Controls.Add(this.btnCadastrarCategoriaReceita);
            this.PnlCadReceita.Controls.Add(this.label6);
            this.PnlCadReceita.Controls.Add(this.txtObservacaoReceita);
            this.PnlCadReceita.Controls.Add(this.label7);
            this.PnlCadReceita.Controls.Add(this.label5);
            this.PnlCadReceita.Controls.Add(this.label4);
            this.PnlCadReceita.Controls.Add(this.cboConta);
            this.PnlCadReceita.Controls.Add(this.cboCategoriaReceita);
            this.PnlCadReceita.Controls.Add(this.label3);
            this.PnlCadReceita.Controls.Add(this.txtDescricaoReceita);
            this.PnlCadReceita.Controls.Add(this.label2);
            this.PnlCadReceita.Controls.Add(this.panel2);
            this.PnlCadReceita.Location = new System.Drawing.Point(12, 12);
            this.PnlCadReceita.Name = "PnlCadReceita";
            this.PnlCadReceita.Size = new System.Drawing.Size(380, 348);
            this.PnlCadReceita.TabIndex = 1;
            // 
            // btnConta
            // 
            this.btnConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(167)))), ((int)(((byte)(80)))));
            this.btnConta.FlatAppearance.BorderSize = 0;
            this.btnConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConta.ForeColor = System.Drawing.Color.White;
            this.btnConta.Location = new System.Drawing.Point(152, 172);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(30, 24);
            this.btnConta.TabIndex = 15;
            this.btnConta.Text = "+";
            this.btnConta.UseVisualStyleBackColor = false;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // mskValor
            // 
            this.mskValor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskValor.Location = new System.Drawing.Point(236, 82);
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(132, 23);
            this.mskValor.TabIndex = 1;
            this.mskValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskValor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskValor_MaskInputRejected);
            this.mskValor.TextChanged += new System.EventHandler(this.mskValor_TextChanged);
            this.mskValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskValor_KeyPress);
            // 
            // mskVencimento
            // 
            this.mskVencimento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskVencimento.Location = new System.Drawing.Point(236, 127);
            this.mskVencimento.Mask = "00/00/0000";
            this.mskVencimento.Name = "mskVencimento";
            this.mskVencimento.Size = new System.Drawing.Size(100, 23);
            this.mskVencimento.TabIndex = 3;
            this.mskVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(10, 304);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(358, 35);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar Receita";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCadastrarCategoriaReceita
            // 
            this.btnCadastrarCategoriaReceita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(167)))), ((int)(((byte)(80)))));
            this.btnCadastrarCategoriaReceita.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCategoriaReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCategoriaReceita.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCategoriaReceita.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCategoriaReceita.Location = new System.Drawing.Point(192, 127);
            this.btnCadastrarCategoriaReceita.Name = "btnCadastrarCategoriaReceita";
            this.btnCadastrarCategoriaReceita.Size = new System.Drawing.Size(30, 24);
            this.btnCadastrarCategoriaReceita.TabIndex = 9;
            this.btnCadastrarCategoriaReceita.Text = "+";
            this.btnCadastrarCategoriaReceita.UseVisualStyleBackColor = false;
            this.btnCadastrarCategoriaReceita.Click += new System.EventHandler(this.BtnCategoriaReceita_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "*Vencimento";
            // 
            // FrmCadReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(404, 378);
            this.Controls.Add(this.PnlCadReceita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCadReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Receitas";
            this.Load += new System.EventHandler(this.FrmCadReceita_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PnlCadReceita.ResumeLayout(false);
            this.PnlCadReceita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtObservacaoReceita;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboConta;
        private System.Windows.Forms.ComboBox cboCategoriaReceita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricaoReceita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlCadReceita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadastrarCategoriaReceita;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox mskVencimento;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.Button btnConta;
    }
}