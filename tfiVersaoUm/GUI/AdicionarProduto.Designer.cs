namespace tfiVersaoUm
{
    partial class AdicionarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarProduto));
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_descricao = new System.Windows.Forms.TextBox();
            this.button_abrirImagem = new System.Windows.Forms.Button();
            this.pictureBox_Imagem = new System.Windows.Forms.PictureBox();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_quantidade = new System.Windows.Forms.TextBox();
            this.textBox_preco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_categoria = new System.Windows.Forms.ComboBox();
            this.panel_move = new System.Windows.Forms.Panel();
            this.label_titulo = new System.Windows.Forms.Label();
            this.panel_lateral = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Imagem)).BeginInit();
            this.panel_move.SuspendLayout();
            this.panel_lateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(187, 38);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(160, 20);
            this.textBox_nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Descrição do produto:";
            // 
            // textBox_descricao
            // 
            this.textBox_descricao.Location = new System.Drawing.Point(187, 168);
            this.textBox_descricao.Name = "textBox_descricao";
            this.textBox_descricao.Size = new System.Drawing.Size(160, 20);
            this.textBox_descricao.TabIndex = 5;
            // 
            // button_abrirImagem
            // 
            this.button_abrirImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_abrirImagem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_abrirImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_abrirImagem.Location = new System.Drawing.Point(371, 144);
            this.button_abrirImagem.Name = "button_abrirImagem";
            this.button_abrirImagem.Size = new System.Drawing.Size(100, 23);
            this.button_abrirImagem.TabIndex = 8;
            this.button_abrirImagem.Text = "Carregar imagem";
            this.button_abrirImagem.UseVisualStyleBackColor = true;
            this.button_abrirImagem.Click += new System.EventHandler(this.button_abrirImagem_Click);
            // 
            // pictureBox_Imagem
            // 
            this.pictureBox_Imagem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox_Imagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Imagem.BackgroundImage")));
            this.pictureBox_Imagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Imagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Imagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Imagem.Location = new System.Drawing.Point(371, 38);
            this.pictureBox_Imagem.Name = "pictureBox_Imagem";
            this.pictureBox_Imagem.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Imagem.TabIndex = 4;
            this.pictureBox_Imagem.TabStop = false;
            this.pictureBox_Imagem.Click += new System.EventHandler(this.pictureBox_ImagemProd_Click);
            // 
            // button_adicionar
            // 
            this.button_adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_adicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_adicionar.Location = new System.Drawing.Point(396, 203);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(75, 23);
            this.button_adicionar.TabIndex = 7;
            this.button_adicionar.Text = "Adicionar";
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.button_adicionar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelar.Location = new System.Drawing.Point(187, 203);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 6;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantidade do produto:";
            // 
            // textBox_quantidade
            // 
            this.textBox_quantidade.Location = new System.Drawing.Point(187, 116);
            this.textBox_quantidade.Name = "textBox_quantidade";
            this.textBox_quantidade.Size = new System.Drawing.Size(160, 20);
            this.textBox_quantidade.TabIndex = 3;
            // 
            // textBox_preco
            // 
            this.textBox_preco.Location = new System.Drawing.Point(187, 142);
            this.textBox_preco.Name = "textBox_preco";
            this.textBox_preco.Size = new System.Drawing.Size(160, 20);
            this.textBox_preco.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Preço da unidade/Kg:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código do produto:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(187, 64);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(160, 20);
            this.textBox_id.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Categoria do produto:";
            // 
            // comboBox_categoria
            // 
            this.comboBox_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_categoria.FormattingEnabled = true;
            this.comboBox_categoria.Items.AddRange(new object[] {
            "Alimentos",
            "Higiene pessoal",
            "Hortifruti",
            "Limpeza",
            "Outros"});
            this.comboBox_categoria.Location = new System.Drawing.Point(187, 89);
            this.comboBox_categoria.Name = "comboBox_categoria";
            this.comboBox_categoria.Size = new System.Drawing.Size(160, 21);
            this.comboBox_categoria.TabIndex = 2;
            // 
            // panel_move
            // 
            this.panel_move.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_move.Controls.Add(this.label_titulo);
            this.panel_move.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_move.Location = new System.Drawing.Point(172, 0);
            this.panel_move.Name = "panel_move";
            this.panel_move.Size = new System.Drawing.Size(313, 30);
            this.panel_move.TabIndex = 7;
            this.panel_move.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_move_MouseMove);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Enabled = false;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_titulo.Location = new System.Drawing.Point(6, 7);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(146, 18);
            this.label_titulo.TabIndex = 1;
            this.label_titulo.Text = "Adicionar produto:";
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.LightGray;
            this.panel_lateral.Controls.Add(this.label1);
            this.panel_lateral.Controls.Add(this.label6);
            this.panel_lateral.Controls.Add(this.label2);
            this.panel_lateral.Controls.Add(this.label4);
            this.panel_lateral.Controls.Add(this.label3);
            this.panel_lateral.Controls.Add(this.label5);
            this.panel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(172, 234);
            this.panel_lateral.TabIndex = 8;
            // 
            // AdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(485, 234);
            this.ControlBox = false;
            this.Controls.Add(this.panel_move);
            this.Controls.Add(this.comboBox_categoria);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_adicionar);
            this.Controls.Add(this.pictureBox_Imagem);
            this.Controls.Add(this.button_abrirImagem);
            this.Controls.Add(this.textBox_descricao);
            this.Controls.Add(this.textBox_preco);
            this.Controls.Add(this.textBox_quantidade);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.panel_lateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AdicionarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddProduto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Imagem)).EndInit();
            this.panel_move.ResumeLayout(false);
            this.panel_move.PerformLayout();
            this.panel_lateral.ResumeLayout(false);
            this.panel_lateral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_descricao;
        private System.Windows.Forms.Button button_abrirImagem;
        private System.Windows.Forms.PictureBox pictureBox_Imagem;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_quantidade;
        private System.Windows.Forms.TextBox textBox_preco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_categoria;
        private System.Windows.Forms.Panel panel_move;
        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.Label label_titulo;
    }
}