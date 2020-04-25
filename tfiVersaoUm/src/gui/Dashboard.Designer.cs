namespace tfiVersaoUm
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.roundedPanel4 = new tfiVersaoUm.GUI.RoundedPanel();
            this.pictureBoxSaldoEstoque = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelSaldoEstoque = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new tfiVersaoUm.GUI.RoundedPanel();
            this.pictureBoxSaldo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new tfiVersaoUm.GUI.RoundedPanel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSeparator2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new tfiVersaoUm.GUI.RoundedPanel();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaldoEstoque)).BeginInit();
            this.roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaldo)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
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
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "DASHBOARD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(14, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(775, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "_________________________________________________________________________________" +
    "_______________________________________________";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedPanel4.Controls.Add(this.pictureBoxSaldoEstoque);
            this.roundedPanel4.Controls.Add(this.label8);
            this.roundedPanel4.Controls.Add(this.labelSaldoEstoque);
            this.roundedPanel4.Controls.Add(this.label10);
            this.roundedPanel4.Location = new System.Drawing.Point(28, 102);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(420, 128);
            this.roundedPanel4.TabIndex = 12;
            // 
            // pictureBoxSaldoEstoque
            // 
            this.pictureBoxSaldoEstoque.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSaldoEstoque.Image")));
            this.pictureBoxSaldoEstoque.Location = new System.Drawing.Point(351, 65);
            this.pictureBoxSaldoEstoque.Name = "pictureBoxSaldoEstoque";
            this.pictureBoxSaldoEstoque.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxSaldoEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSaldoEstoque.TabIndex = 16;
            this.pictureBoxSaldoEstoque.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(3, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(415, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "____________________________________________________________________";
            // 
            // labelSaldoEstoque
            // 
            this.labelSaldoEstoque.AutoSize = true;
            this.labelSaldoEstoque.BackColor = System.Drawing.Color.Transparent;
            this.labelSaldoEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoEstoque.ForeColor = System.Drawing.Color.Gray;
            this.labelSaldoEstoque.Location = new System.Drawing.Point(14, 62);
            this.labelSaldoEstoque.Name = "labelSaldoEstoque";
            this.labelSaldoEstoque.Size = new System.Drawing.Size(148, 50);
            this.labelSaldoEstoque.TabIndex = 10;
            this.labelSaldoEstoque.Text = "R$ 0,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(13, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Saldo em estoque";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedPanel3.Controls.Add(this.pictureBoxSaldo);
            this.roundedPanel3.Controls.Add(this.label7);
            this.roundedPanel3.Controls.Add(this.labelSaldo);
            this.roundedPanel3.Controls.Add(this.label5);
            this.roundedPanel3.Location = new System.Drawing.Point(465, 102);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(296, 128);
            this.roundedPanel3.TabIndex = 12;
            // 
            // pictureBoxSaldo
            // 
            this.pictureBoxSaldo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSaldo.Image")));
            this.pictureBoxSaldo.Location = new System.Drawing.Point(228, 65);
            this.pictureBoxSaldo.Name = "pictureBoxSaldo";
            this.pictureBoxSaldo.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxSaldo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSaldo.TabIndex = 16;
            this.pictureBoxSaldo.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(3, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "_______________________________________________";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.BackColor = System.Drawing.Color.Transparent;
            this.labelSaldo.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.ForeColor = System.Drawing.Color.Gray;
            this.labelSaldo.Location = new System.Drawing.Point(14, 62);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(148, 50);
            this.labelSaldo.TabIndex = 10;
            this.labelSaldo.Text = "R$ 0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(13, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Saldo";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedPanel2.Controls.Add(this.cartesianChart1);
            this.roundedPanel2.Controls.Add(this.label2);
            this.roundedPanel2.Controls.Add(this.labelSeparator2);
            this.roundedPanel2.Controls.Add(this.label4);
            this.roundedPanel2.Location = new System.Drawing.Point(28, 248);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(420, 327);
            this.roundedPanel2.TabIndex = 12;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(17, 58);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(385, 250);
            this.cartesianChart1.TabIndex = 16;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(-16, -16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(775, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "_________________________________________________________________________________" +
    "_______________________________________________";
            // 
            // labelSeparator2
            // 
            this.labelSeparator2.AutoSize = true;
            this.labelSeparator2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelSeparator2.Location = new System.Drawing.Point(3, 31);
            this.labelSeparator2.Name = "labelSeparator2";
            this.labelSeparator2.Size = new System.Drawing.Size(415, 13);
            this.labelSeparator2.TabIndex = 13;
            this.labelSeparator2.Text = "____________________________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vendas da semana";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedPanel1.Controls.Add(this.labelSeparator);
            this.roundedPanel1.Controls.Add(this.pieChart1);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Location = new System.Drawing.Point(465, 248);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(296, 327);
            this.roundedPanel1.TabIndex = 12;
            // 
            // labelSeparator
            // 
            this.labelSeparator.AutoSize = true;
            this.labelSeparator.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelSeparator.Location = new System.Drawing.Point(3, 31);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(289, 13);
            this.labelSeparator.TabIndex = 13;
            this.labelSeparator.Text = "_______________________________________________";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(23, 64);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(250, 250);
            this.pieChart1.TabIndex = 11;
            this.pieChart1.Text = "pieChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Produtos mais vendidos";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaldoEstoque)).EndInit();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaldo)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private LiveCharts.WinForms.PieChart pieChart1;
        private GUI.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSeparator;
        private GUI.RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label labelSeparator2;
        private System.Windows.Forms.Label label4;
        private GUI.RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.PictureBox pictureBoxSaldo;
        private GUI.RoundedPanel roundedPanel4;
        private System.Windows.Forms.PictureBox pictureBoxSaldoEstoque;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelSaldoEstoque;
        private System.Windows.Forms.Label label10;
    }
}