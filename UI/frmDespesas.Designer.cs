﻿namespace UI
{
    partial class frmDespesas
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
            this.BtnCadDespesa = new System.Windows.Forms.Button();
            this.PnlListDespesa = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.DgvListDespesa = new System.Windows.Forms.DataGridView();
            this.btnPesquisarDespesa = new System.Windows.Forms.Button();
            this.txtPesquisarDespesa = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.PnlListDespesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListDespesa)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCadDespesa
            // 
            this.BtnCadDespesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(63)))), ((int)(((byte)(59)))));
            this.BtnCadDespesa.FlatAppearance.BorderSize = 0;
            this.BtnCadDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadDespesa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadDespesa.ForeColor = System.Drawing.Color.White;
            this.BtnCadDespesa.Location = new System.Drawing.Point(16, 77);
            this.BtnCadDespesa.Name = "BtnCadDespesa";
            this.BtnCadDespesa.Size = new System.Drawing.Size(161, 39);
            this.BtnCadDespesa.TabIndex = 5;
            this.BtnCadDespesa.Text = "Nova Transação";
            this.BtnCadDespesa.UseVisualStyleBackColor = false;
            this.BtnCadDespesa.Click += new System.EventHandler(this.BtnCadDespesa_Click);
            // 
            // PnlListDespesa
            // 
            this.PnlListDespesa.BackColor = System.Drawing.Color.White;
            this.PnlListDespesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlListDespesa.Controls.Add(this.btnExcluir);
            this.PnlListDespesa.Controls.Add(this.btnAlterar);
            this.PnlListDespesa.Controls.Add(this.DgvListDespesa);
            this.PnlListDespesa.Controls.Add(this.btnPesquisarDespesa);
            this.PnlListDespesa.Controls.Add(this.txtPesquisarDespesa);
            this.PnlListDespesa.Controls.Add(this.panel2);
            this.PnlListDespesa.Location = new System.Drawing.Point(15, 131);
            this.PnlListDespesa.Name = "PnlListDespesa";
            this.PnlListDespesa.Size = new System.Drawing.Size(687, 428);
            this.PnlListDespesa.TabIndex = 4;
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
            // DgvListDespesa
            // 
            this.DgvListDespesa.AllowUserToAddRows = false;
            this.DgvListDespesa.AllowUserToDeleteRows = false;
            this.DgvListDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListDespesa.Location = new System.Drawing.Point(7, 109);
            this.DgvListDespesa.Name = "DgvListDespesa";
            this.DgvListDespesa.ReadOnly = true;
            this.DgvListDespesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListDespesa.Size = new System.Drawing.Size(665, 273);
            this.DgvListDespesa.TabIndex = 4;
            // 
            // btnPesquisarDespesa
            // 
            this.btnPesquisarDespesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
            this.btnPesquisarDespesa.FlatAppearance.BorderSize = 0;
            this.btnPesquisarDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarDespesa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarDespesa.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarDespesa.Location = new System.Drawing.Point(591, 62);
            this.btnPesquisarDespesa.Name = "btnPesquisarDespesa";
            this.btnPesquisarDespesa.Size = new System.Drawing.Size(81, 27);
            this.btnPesquisarDespesa.TabIndex = 3;
            this.btnPesquisarDespesa.Text = "Buscar";
            this.btnPesquisarDespesa.UseVisualStyleBackColor = false;
            this.btnPesquisarDespesa.Click += new System.EventHandler(this.btnPesquisarDespesa_Click);
            // 
            // txtPesquisarDespesa
            // 
            this.txtPesquisarDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarDespesa.Location = new System.Drawing.Point(378, 63);
            this.txtPesquisarDespesa.Name = "txtPesquisarDespesa";
            this.txtPesquisarDespesa.Size = new System.Drawing.Size(207, 26);
            this.txtPesquisarDespesa.TabIndex = 1;
            this.txtPesquisarDespesa.TextChanged += new System.EventHandler(this.txtPesquisarDespesa_TextChanged);
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
            this.label1.Size = new System.Drawing.Size(232, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lançamentos de Despesa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Despesas Cadastradas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCarregar);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(539, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 111);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtra";
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.ForeColor = System.Drawing.Color.White;
            this.btnCarregar.Location = new System.Drawing.Point(24, 64);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(126, 29);
            this.btnCarregar.TabIndex = 12;
            this.btnCarregar.Text = "Filtrar por Mês";
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // dtpData
            // 
            this.dtpData.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(23, 29);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(126, 23);
            this.dtpData.TabIndex = 9;
            // 
            // frmDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(715, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCadDespesa);
            this.Controls.Add(this.PnlListDespesa);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesas";
            this.Load += new System.EventHandler(this.frmDespesas_Load);
            this.PnlListDespesa.ResumeLayout(false);
            this.PnlListDespesa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListDespesa)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCadDespesa;
        private System.Windows.Forms.Panel PnlListDespesa;
        private System.Windows.Forms.DataGridView DgvListDespesa;
        private System.Windows.Forms.Button btnPesquisarDespesa;
        private System.Windows.Forms.TextBox txtPesquisarDespesa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}