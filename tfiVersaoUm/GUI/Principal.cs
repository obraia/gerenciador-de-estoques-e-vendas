using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Move panel

namespace tfiVersaoUm
{
    public partial class Principal : Form
    {
        Estoque estoqueForms = new Estoque();
        Dashboard dashboard = new Dashboard();
        Venda vendaForms = new Venda();
        Fornecedores fornecedores = new Fornecedores();
        

        // Move Panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_Paint(object sender, MouseEventArgs e) //mover a tela
        {
            if (e.Button == MouseButtons.Left)
            {
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 13, 13));
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panelLateral_MouseMove(object sender, MouseEventArgs e)  //mover a tela
        {
            if (e.Button == MouseButtons.Left)
            {
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Round Window
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        // Drop Shadow
        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        public Principal()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 13, 13));
        }


        private void bt_close_window_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_minimize_window_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tituloTrabalho_Click(object sender, EventArgs e)
        {
            EsconderAbas();
            imagemPrincipal.Visible = true;
        }

        private void botaoDashboard_Click(object sender, EventArgs e)
        {
            if (dashboard.Visible == false)
            {
                EsconderAbas();

                dashboard.TopLevel = false;
                fornecedores.Dock = DockStyle.Fill;
                this.panelPrincipal.Controls.Add(dashboard);
                this.panelPrincipal.Tag = dashboard;
                dashboard.Show();
                dashboard.AtualizarComponentes();
            }
        }

        private void botaoEstoque_Click(object sender, EventArgs e)
        {
            if (estoqueForms.Visible == false)
            {
                EsconderAbas();

                estoqueForms.TopLevel = false;
                estoqueForms.Dock = DockStyle.Fill;
                this.panelPrincipal.Controls.Add(estoqueForms);
                this.panelPrincipal.Tag = estoqueForms;
                estoqueForms.Show();
                estoqueForms.CarregarTabela();
            }
        }

        private void botaoVendas_Click(object sender, EventArgs e)
        {
            if (vendaForms.Visible == false)
            {
                EsconderAbas();

                vendaForms.TopLevel = false;
                vendaForms.Dock = DockStyle.Fill;
                this.panelPrincipal.Controls.Add(vendaForms);
                this.panelPrincipal.Tag = estoqueForms;
                vendaForms.Show();
            }
        }

        private void botaoFornecedores_Click(object sender, EventArgs e)
        {
            if (fornecedores.Visible == false)
            {
                EsconderAbas();

                fornecedores.TopLevel = false;
                fornecedores.Dock = DockStyle.Fill;
                this.panelPrincipal.Controls.Add(fornecedores);
                this.panelPrincipal.Tag = fornecedores;
                fornecedores.Show();
            }
        }

        public void EsconderAbas()
        {
            imagemPrincipal.Visible = false;
            estoqueForms.Visible = false;
            vendaForms.Visible = false;
            fornecedores.Visible = false;
            dashboard.Visible = false;
        }

    }
}
