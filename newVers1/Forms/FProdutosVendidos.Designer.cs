﻿
namespace Projeto_DA_BooKids.Forms
{
    partial class FProdutosVendidos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProdutosVendidos));
            this.booKids_DBDataSet = new Projeto_DA_BooKids.BooKids_DBDataSet();
            this.produtoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.ProdutoSetTableAdapter();
            this.tableAdapterManager = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager();
            this.tipoProdutoSetTableAdapter = new Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TipoProdutoSetTableAdapter();
            this.produtoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.produtoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tipoProdutoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBProdutosVendidos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoSetBindingNavigator)).BeginInit();
            this.produtoSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // booKids_DBDataSet
            // 
            this.booKids_DBDataSet.DataSetName = "BooKids_DBDataSet";
            this.booKids_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoSetBindingSource
            // 
            this.produtoSetBindingSource.DataMember = "ProdutoSet";
            this.produtoSetBindingSource.DataSource = this.booKids_DBDataSet;
            // 
            // produtoSetTableAdapter
            // 
            this.produtoSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboracaoSetTableAdapter = null;
            this.tableAdapterManager.CompraSetTableAdapter = null;
            this.tableAdapterManager.DetalheCompraSetTableAdapter = null;
            this.tableAdapterManager.EscolaSetTableAdapter = null;
            this.tableAdapterManager.EventoSetTableAdapter = null;
            this.tableAdapterManager.InscricaoSetTableAdapter = null;
            this.tableAdapterManager.ParticipacaoSetTableAdapter = null;
            this.tableAdapterManager.PessoaSet_AnimadorTableAdapter = null;
            this.tableAdapterManager.PessoaSet_ClienteTableAdapter = null;
            this.tableAdapterManager.PessoaSet_FilhoTableAdapter = null;
            this.tableAdapterManager.PessoaSetTableAdapter = null;
            this.tableAdapterManager.ProdutoSetTableAdapter = this.produtoSetTableAdapter;
            this.tableAdapterManager.TipoProdutoSetTableAdapter = this.tipoProdutoSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projeto_DA_BooKids.BooKids_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tipoProdutoSetTableAdapter
            // 
            this.tipoProdutoSetTableAdapter.ClearBeforeFill = true;
            // 
            // produtoSetBindingNavigator
            // 
            this.produtoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produtoSetBindingNavigator.BindingSource = this.produtoSetBindingSource;
            this.produtoSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produtoSetBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.produtoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.produtoSetBindingNavigatorSaveItem});
            this.produtoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtoSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtoSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtoSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtoSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtoSetBindingNavigator.Name = "produtoSetBindingNavigator";
            this.produtoSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtoSetBindingNavigator.Size = new System.Drawing.Size(921, 27);
            this.produtoSetBindingNavigator.TabIndex = 0;
            this.produtoSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // produtoSetBindingNavigatorSaveItem
            // 
            this.produtoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produtoSetBindingNavigatorSaveItem.Image")));
            this.produtoSetBindingNavigatorSaveItem.Name = "produtoSetBindingNavigatorSaveItem";
            this.produtoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.produtoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.produtoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.produtoSetBindingNavigatorSaveItem_Click);
            // 
            // tipoProdutoSetBindingSource
            // 
            this.tipoProdutoSetBindingSource.DataMember = "TipoProdutoSet";
            this.tipoProdutoSetBindingSource.DataSource = this.booKids_DBDataSet;
            // 
            // produtoSetDataGridView
            // 
            this.produtoSetDataGridView.AutoGenerateColumns = false;
            this.produtoSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.produtoSetDataGridView.DataSource = this.produtoSetBindingSource;
            this.produtoSetDataGridView.Location = new System.Drawing.Point(53, 217);
            this.produtoSetDataGridView.Name = "produtoSetDataGridView";
            this.produtoSetDataGridView.RowHeadersWidth = 51;
            this.produtoSetDataGridView.RowTemplate.Height = 24;
            this.produtoSetDataGridView.Size = new System.Drawing.Size(804, 351);
            this.produtoSetDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodProduto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Designacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Designacao";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Preco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Preco";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CodTipoProduto";
            this.dataGridViewTextBoxColumn4.HeaderText = "CodTipoProduto";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StockExistente";
            this.dataGridViewTextBoxColumn5.HeaderText = "StockExistente";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TipoProduto_CodTipoProduto";
            this.dataGridViewTextBoxColumn6.HeaderText = "TipoProduto_CodTipoProduto";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // LBProdutosVendidos
            // 
            this.LBProdutosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBProdutosVendidos.Location = new System.Drawing.Point(240, 71);
            this.LBProdutosVendidos.Name = "LBProdutosVendidos";
            this.LBProdutosVendidos.Size = new System.Drawing.Size(429, 59);
            this.LBProdutosVendidos.TabIndex = 24;
            this.LBProdutosVendidos.Text = "Produtos Vendidos";
            this.LBProdutosVendidos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FProdutosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 580);
            this.Controls.Add(this.LBProdutosVendidos);
            this.Controls.Add(this.produtoSetDataGridView);
            this.Controls.Add(this.produtoSetBindingNavigator);
            this.Name = "FProdutosVendidos";
            this.Text = "FormProdutosVendidos";
            this.Load += new System.EventHandler(this.FormProdutosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booKids_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoSetBindingNavigator)).EndInit();
            this.produtoSetBindingNavigator.ResumeLayout(false);
            this.produtoSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoSetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooKids_DBDataSet booKids_DBDataSet;
        private System.Windows.Forms.BindingSource produtoSetBindingSource;
        private BooKids_DBDataSetTableAdapters.ProdutoSetTableAdapter produtoSetTableAdapter;
        private BooKids_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produtoSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton produtoSetBindingNavigatorSaveItem;
        private BooKids_DBDataSetTableAdapters.TipoProdutoSetTableAdapter tipoProdutoSetTableAdapter;
        private System.Windows.Forms.BindingSource tipoProdutoSetBindingSource;
        private System.Windows.Forms.DataGridView produtoSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label LBProdutosVendidos;
    }
}