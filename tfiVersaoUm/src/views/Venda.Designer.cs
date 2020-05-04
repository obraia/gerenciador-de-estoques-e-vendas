namespace tfiVersaoUm
{
    partial class Venda
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
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.roundedPanel7 = new tfiVersaoUm.GUI.RoundedPanel();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel4 = new tfiVersaoUm.GUI.RoundedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelImposto = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.roundedPanel3 = new tfiVersaoUm.GUI.RoundedPanel();
            this.pictureBoxCodigoBarras = new System.Windows.Forms.PictureBox();
            this.roundedPanel2 = new tfiVersaoUm.GUI.RoundedPanel();
            this.labelNome = new System.Windows.Forms.Label();
            this.roundedPanel6 = new tfiVersaoUm.GUI.RoundedPanel();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.textBoxCodigoBarras = new System.Windows.Forms.TextBox();
            this.roundedPanel5 = new tfiVersaoUm.GUI.RoundedPanel();
            this.listViewCompras = new System.Windows.Forms.ListView();
            this.ch_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roundedPanel1 = new tfiVersaoUm.GUI.RoundedPanel();
            this.pictureBoxProduto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.roundedPanel7.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCodigoBarras)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel6.SuspendLayout();
            this.roundedPanel5.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(23, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "VENDA";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Location = new System.Drawing.Point(654, 531);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(109, 41);
            this.buttonConfirmar.TabIndex = 12;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(539, 531);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(109, 41);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Limpar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // roundedPanel7
            // 
            this.roundedPanel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedPanel7.Controls.Add(this.labelValorTotal);
            this.roundedPanel7.Controls.Add(this.label1);
            this.roundedPanel7.Location = new System.Drawing.Point(476, 466);
            this.roundedPanel7.Name = "roundedPanel7";
            this.roundedPanel7.Size = new System.Drawing.Size(287, 55);
            this.roundedPanel7.TabIndex = 12;
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelValorTotal.Location = new System.Drawing.Point(152, 8);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(120, 40);
            this.labelValorTotal.TabIndex = 1;
            this.labelValorTotal.Text = "R$ 0,00 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor Total: ";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedPanel4.Controls.Add(this.label4);
            this.roundedPanel4.Controls.Add(this.labelImposto);
            this.roundedPanel4.Controls.Add(this.labelPreco);
            this.roundedPanel4.Location = new System.Drawing.Point(453, 169);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(310, 77);
            this.roundedPanel4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Impostos:";
            // 
            // labelImposto
            // 
            this.labelImposto.AutoSize = true;
            this.labelImposto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImposto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelImposto.Location = new System.Drawing.Point(98, 7);
            this.labelImposto.Name = "labelImposto";
            this.labelImposto.Size = new System.Drawing.Size(62, 25);
            this.labelImposto.TabIndex = 2;
            this.labelImposto.Text = "0,00%";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreco.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPreco.Location = new System.Drawing.Point(23, 31);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(284, 37);
            this.labelPreco.TabIndex = 0;
            this.labelPreco.Text = "Preço Uni/Kg: R$ 0,00";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedPanel3.Controls.Add(this.pictureBoxCodigoBarras);
            this.roundedPanel3.Location = new System.Drawing.Point(210, 169);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(223, 77);
            this.roundedPanel3.TabIndex = 11;
            // 
            // pictureBoxCodigoBarras
            // 
            this.pictureBoxCodigoBarras.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxCodigoBarras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCodigoBarras.InitialImage = null;
            this.pictureBoxCodigoBarras.Location = new System.Drawing.Point(14, 9);
            this.pictureBoxCodigoBarras.Name = "pictureBoxCodigoBarras";
            this.pictureBoxCodigoBarras.Size = new System.Drawing.Size(195, 60);
            this.pictureBoxCodigoBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCodigoBarras.TabIndex = 0;
            this.pictureBoxCodigoBarras.TabStop = false;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedPanel2.Controls.Add(this.labelNome);
            this.roundedPanel2.Location = new System.Drawing.Point(210, 81);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(553, 65);
            this.roundedPanel2.TabIndex = 11;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelNome.Location = new System.Drawing.Point(10, 20);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(175, 25);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome do produto";
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedPanel6.Controls.Add(this.buttonAdicionar);
            this.roundedPanel6.Controls.Add(this.textBoxCodigoBarras);
            this.roundedPanel6.Location = new System.Drawing.Point(28, 466);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Size = new System.Drawing.Size(434, 55);
            this.roundedPanel6.TabIndex = 11;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(312, 13);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(109, 30);
            this.buttonAdicionar.TabIndex = 1;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // textBoxCodigoBarras
            // 
            this.textBoxCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoBarras.Location = new System.Drawing.Point(13, 16);
            this.textBoxCodigoBarras.MaxLength = 13;
            this.textBoxCodigoBarras.Name = "textBoxCodigoBarras";
            this.textBoxCodigoBarras.Size = new System.Drawing.Size(293, 24);
            this.textBoxCodigoBarras.TabIndex = 0;
            this.textBoxCodigoBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigoBarras_KeyDown);
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedPanel5.Controls.Add(this.listViewCompras);
            this.roundedPanel5.Location = new System.Drawing.Point(28, 258);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(735, 197);
            this.roundedPanel5.TabIndex = 11;
            // 
            // listViewCompras
            // 
            this.listViewCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCompras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Nome,
            this.ch_Preco,
            this.ch_Quantidade});
            this.listViewCompras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCompras.FullRowSelect = true;
            this.listViewCompras.GridLines = true;
            this.listViewCompras.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCompras.HideSelection = false;
            this.listViewCompras.Location = new System.Drawing.Point(13, 12);
            this.listViewCompras.Name = "listViewCompras";
            this.listViewCompras.Size = new System.Drawing.Size(711, 173);
            this.listViewCompras.TabIndex = 0;
            this.listViewCompras.UseCompatibleStateImageBehavior = false;
            this.listViewCompras.View = System.Windows.Forms.View.Details;
            // 
            // ch_Nome
            // 
            this.ch_Nome.Text = "Nome do produto";
            this.ch_Nome.Width = 329;
            // 
            // ch_Preco
            // 
            this.ch_Preco.Text = "Preço da unidade/kg";
            this.ch_Preco.Width = 152;
            // 
            // ch_Quantidade
            // 
            this.ch_Quantidade.Text = "Quantidade/Quilos";
            this.ch_Quantidade.Width = 229;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedPanel1.Controls.Add(this.pictureBoxProduto);
            this.roundedPanel1.Location = new System.Drawing.Point(28, 81);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(165, 165);
            this.roundedPanel1.TabIndex = 11;
            // 
            // pictureBoxProduto
            // 
            this.pictureBoxProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxProduto.InitialImage = null;
            this.pictureBoxProduto.Location = new System.Drawing.Point(10, 11);
            this.pictureBoxProduto.Name = "pictureBoxProduto";
            this.pictureBoxProduto.Size = new System.Drawing.Size(145, 145);
            this.pictureBoxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProduto.TabIndex = 0;
            this.pictureBoxProduto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(775, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "_________________________________________________________________________________" +
    "_______________________________________________";
            // 
            // buttonRemover
            // 
            this.buttonRemover.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemover.Location = new System.Drawing.Point(424, 531);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(109, 41);
            this.buttonRemover.TabIndex = 17;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.ControlBox = false;
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roundedPanel7);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel6);
            this.Controls.Add(this.roundedPanel5);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venda";
            this.Text = "Venda";
            this.roundedPanel7.ResumeLayout(false);
            this.roundedPanel7.PerformLayout();
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCodigoBarras)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel6.ResumeLayout(false);
            this.roundedPanel6.PerformLayout();
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private GUI.RoundedPanel roundedPanel1;
        private System.Windows.Forms.PictureBox pictureBoxProduto;
        private GUI.RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label labelNome;
        private GUI.RoundedPanel roundedPanel3;
        private System.Windows.Forms.PictureBox pictureBoxCodigoBarras;
        private GUI.RoundedPanel roundedPanel4;
        private System.Windows.Forms.Label labelPreco;
        private GUI.RoundedPanel roundedPanel5;
        private System.Windows.Forms.ListView listViewCompras;
        private System.Windows.Forms.ColumnHeader ch_Nome;
        private System.Windows.Forms.ColumnHeader ch_Preco;
        private System.Windows.Forms.ColumnHeader ch_Quantidade;
        private GUI.RoundedPanel roundedPanel6;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.TextBox textBoxCodigoBarras;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonCancelar;
        private GUI.RoundedPanel roundedPanel7;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelImposto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemover;
    }
}