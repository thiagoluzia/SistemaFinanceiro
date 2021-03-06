﻿using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmCategoriaDespesa : Form
    {
        CategoriaDespesaDTO dto = new CategoriaDespesaDTO();
        CategoriaDespesaBLL bll = new CategoriaDespesaBLL();

        public FrmCategoriaDespesa()
        {
            InitializeComponent();
        }
        private void FrmCategoriaDespesa_Load(object sender, EventArgs e)
        {
            CarregarCategoriasDespesa();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dto.Id > 0)
                {
                    dto.Id = (int)dgvListDespesa.CurrentRow.Cells[0].Value;
                    dto.Descricao = txtCadastrarDespesaReceita.Text;
                    bll.AtualizarCategoria(dto);
                    MessageBox.Show("Categoria Atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtCadastrarDespesaReceita.Text == "")
                    {
                        MessageBox.Show("Prencha o campo descrição antes de salvar!","Informmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dto.Descricao = txtCadastrarDespesaReceita.Text;
                        bll.InserirCategoria(dto);
                        MessageBox.Show("Categoria Cadastrada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar salvar um registro! {ex.Message}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dto.Id = 0;
                CarregarCategoriasDespesa();
                LimparCampos();
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                dto.Id = (int)dgvListDespesa.CurrentRow.Cells[0].Value;
                txtCadastrarDespesaReceita.Text = dgvListDespesa.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nenhuma categoria foi selecionado: {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {

            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Deseja realmente excluir essa Categoria? Caso ela esteja vinculada a algum lançamento, não poderá ser excluida", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (DialogResult == DialogResult.Yes)
                {
                    dto.Id = (int)dgvListDespesa.CurrentRow.Cells[0].Value;
                    dto.Descricao = dgvListDespesa.CurrentRow.Cells[1].ToString();
                    bll.Excluir(dto);
                    MessageBox.Show($"Categoria excluida com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarCategoriasDespesa();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nenhuma categoria foi selecionado: {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CarregarCategoriasDespesa()
        {
            dgvListDespesa.DataSource = bll.Exibir();
        }
        private void LimparCampos()
        {
            txtCadastrarDespesaReceita.Text = "";
        }
    }
}
