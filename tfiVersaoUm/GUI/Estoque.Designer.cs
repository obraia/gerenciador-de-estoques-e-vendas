namespace tfiVersaoUm
{
    partial class Estoque
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
            this.button_adicionar = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new tfiVersaoUm.GUI.RoundedPanel();
            this.pictureBox_produto = new System.Windows.Forms.PictureBox();
            this.pB_codigoBarras = new System.Windows.Forms.PictureBox();
            this.roundedPanel1 = new tfiVersaoUm.GUI.RoundedPanel();
            this.pictureBox_categoria = new System.Windows.Forms.PictureBox();
            this.lb_valorTotal = new System.Windows.Forms.Label();
            this.textBox_descricao = new System.Windows.Forms.TextBox();
            this.lb_dataCadastro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new tfiVersaoUm.GUI.RoundedPanel();
            this.listView_estoque = new System.Windows.Forms.ListView();
            this.ch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSeparator = new System.Windows.Forms.Label();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_codigoBarras)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_categoria)).BeginInit();
            this.roundedPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_adicionar
            // 
            this.button_adicionar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.button_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_adicionar.Location = new System.Drawing.Point(133, 543);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(90, 35);
            this.button_adicionar.TabIndex = 5;
            this.button_adicionar.Text = "Adicionar";
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.button_adicionar_Click);
            // 
            // button_atualizar
            // 
            this.button_atualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.button_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_atualizar.Location = new System.Drawing.Point(28, 543);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(90, 35);
            this.button_atualizar.TabIndex = 6;
            this.button_atualizar.Text = "Atualizar";
            this.button_atualizar.UseVisualStyleBackColor = true;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // button_editar
            // 
            this.button_editar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.button_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editar.Location = new System.Drawing.Point(234, 543);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(90, 35);
            this.button_editar.TabIndex = 7;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.button_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_excluir.Location = new System.Drawing.Point(671, 543);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(90, 35);
            this.button_excluir.TabIndex = 8;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(23, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "ESTOQUE";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedPanel2.Controls.Add(this.pictureBox_produto);
            this.roundedPanel2.Controls.Add(this.pB_codigoBarras);
            this.roundedPanel2.Location = new System.Drawing.Point(28, 333);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(152, 193);
            this.roundedPanel2.TabIndex = 13;
            // 
            // pictureBox_produto
            // 
            this.pictureBox_produto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_produto.Location = new System.Drawing.Point(11, 10);
            this.pictureBox_produto.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pictureBox_produto.Name = "pictureBox_produto";
            this.pictureBox_produto.Size = new System.Drawing.Size(130, 130);
            this.pictureBox_produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_produto.TabIndex = 1;
            this.pictureBox_produto.TabStop = false;
            // 
            // pB_codigoBarras
            // 
            this.pB_codigoBarras.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pB_codigoBarras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pB_codigoBarras.Location = new System.Drawing.Point(11, 145);
            this.pB_codigoBarras.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pB_codigoBarras.Name = "pB_codigoBarras";
            this.pB_codigoBarras.Size = new System.Drawing.Size(130, 40);
            this.pB_codigoBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_codigoBarras.TabIndex = 1;
            this.pB_codigoBarras.TabStop = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedPanel1.Controls.Add(this.pictureBox_categoria);
            this.roundedPanel1.Controls.Add(this.lb_valorTotal);
            this.roundedPanel1.Controls.Add(this.textBox_descricao);
            this.roundedPanel1.Controls.Add(this.lb_dataCadastro);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Location = new System.Drawing.Point(196, 333);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(565, 193);
            this.roundedPanel1.TabIndex = 12;
            // 
            // pictureBox_categoria
            // 
            this.pictureBox_categoria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_categoria.Location = new System.Drawing.Point(22, 33);
            this.pictureBox_categoria.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pictureBox_categoria.Name = "pictureBox_categoria";
            this.pictureBox_categoria.Size = new System.Drawing.Size(90, 90);
            this.pictureBox_categoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_categoria.TabIndex = 1;
            this.pictureBox_categoria.TabStop = false;
            // 
            // lb_valorTotal
            // 
            this.lb_valorTotal.AutoSize = true;
            this.lb_valorTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valorTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_valorTotal.Location = new System.Drawing.Point(173, 165);
            this.lb_valorTotal.Name = "lb_valorTotal";
            this.lb_valorTotal.Size = new System.Drawing.Size(58, 20);
            this.lb_valorTotal.TabIndex = 3;
            this.lb_valorTotal.Text = "R$ 0,00";
            // 
            // textBox_descricao
            // 
            this.textBox_descricao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_descricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_descricao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_descricao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_descricao.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_descricao.Location = new System.Drawing.Point(127, 33);
            this.textBox_descricao.Multiline = true;
            this.textBox_descricao.Name = "textBox_descricao";
            this.textBox_descricao.ReadOnly = true;
            this.textBox_descricao.Size = new System.Drawing.Size(367, 90);
            this.textBox_descricao.TabIndex = 2;
            // 
            // lb_dataCadastro
            // 
            this.lb_dataCadastro.AutoSize = true;
            this.lb_dataCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dataCadastro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_dataCadastro.Location = new System.Drawing.Point(409, 165);
            this.lb_dataCadastro.Name = "lb_dataCadastro";
            this.lb_dataCadastro.Size = new System.Drawing.Size(85, 20);
            this.lb_dataCadastro.TabIndex = 3;
            this.lb_dataCadastro.Text = "00/00/0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(7, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor total em estoque:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(273, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de cadastro:";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedPanel3.Controls.Add(this.listView_estoque);
            this.roundedPanel3.Location = new System.Drawing.Point(28, 78);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(733, 239);
            this.roundedPanel3.TabIndex = 13;
            // 
            // listView_estoque
            // 
            this.listView_estoque.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listView_estoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_estoque.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_ID,
            this.ch_Categoria,
            this.ch_Nome,
            this.ch_Preco,
            this.ch_Quantidade});
            this.listView_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_estoque.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView_estoque.FullRowSelect = true;
            this.listView_estoque.GridLines = true;
            this.listView_estoque.HideSelection = false;
            this.listView_estoque.Location = new System.Drawing.Point(13, 13);
            this.listView_estoque.Name = "listView_estoque";
            this.listView_estoque.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView_estoque.Size = new System.Drawing.Size(706, 214);
            this.listView_estoque.TabIndex = 0;
            this.listView_estoque.UseCompatibleStateImageBehavior = false;
            this.listView_estoque.View = System.Windows.Forms.View.Details;
            this.listView_estoque.SelectedIndexChanged += new System.EventHandler(this.listView_estoque_SelectedIndexChanged);
            this.listView_estoque.DoubleClick += new System.EventHandler(this.listView_estoque_DoubleClick);
            // 
            // ch_ID
            // 
            this.ch_ID.Text = "Código de barras";
            this.ch_ID.Width = 126;
            // 
            // ch_Categoria
            // 
            this.ch_Categoria.Text = "Categoria";
            this.ch_Categoria.Width = 125;
            // 
            // ch_Nome
            // 
            this.ch_Nome.Text = "Nome do produto";
            this.ch_Nome.Width = 235;
            // 
            // ch_Preco
            // 
            this.ch_Preco.Text = "Preço Unidade/Kg";
            this.ch_Preco.Width = 126;
            // 
            // ch_Quantidade
            // 
            this.ch_Quantidade.Text = "Quantidade";
            this.ch_Quantidade.Width = 94;
            // 
            // labelSeparator
            // 
            this.labelSeparator.AutoSize = true;
            this.labelSeparator.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelSeparator.Location = new System.Drawing.Point(14, 50);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(775, 13);
            this.labelSeparator.TabIndex = 14;
            this.labelSeparator.Text = "_________________________________________________________________________________" +
    "_______________________________________________";
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.button_atualizar);
            this.Controls.Add(this.labelSeparator);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_adicionar);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.roundedPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_codigoBarras)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_categoria)).EndInit();
            this.roundedPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_estoque;
        private System.Windows.Forms.ColumnHeader ch_ID;
        private System.Windows.Forms.ColumnHeader ch_Categoria;
        private System.Windows.Forms.ColumnHeader ch_Nome;
        private System.Windows.Forms.ColumnHeader ch_Preco;
        private System.Windows.Forms.ColumnHeader ch_Quantidade;
        private System.Windows.Forms.PictureBox pictureBox_produto;
        private System.Windows.Forms.TextBox textBox_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_valorTotal;
        private System.Windows.Forms.Label lb_dataCadastro;
        private System.Windows.Forms.PictureBox pB_codigoBarras;
        private System.Windows.Forms.PictureBox pictureBox_categoria;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Label label3;
        private GUI.RoundedPanel roundedPanel1;
        private GUI.RoundedPanel roundedPanel2;
        private GUI.RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label labelSeparator;
    }
}