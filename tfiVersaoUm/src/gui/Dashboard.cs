using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace tfiVersaoUm
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        void grafico()
        {
            cartesianChart1.Series = new SeriesCollection
    {
                 new LineSeries
                 {
                     Title = "",
                     Values = new ChartValues<double> { 1, 1, 2, 3 ,5, 4, 8, 10, 3, 4 },
                     PointGeometry = null,
                     AreaLimit = 0
                 },
                    new LineSeries
                    {
                        Title = "",
                        Values = new ChartValues<double> { 5, 4, 8, 2 ,9, 7, 2, 7, 5, 10 },
                        PointGeometry = null,
                        AreaLimit = 0
                    },
                     new LineSeries
                    {
                       Title = "",
                       Values = new ChartValues<double> { 8, 5, 10, 7 ,5, 1, 5, 1, 9, 2 },
                       PointGeometry = null,
                       AreaLimit = 0
                    }
            };
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
        }

        void MaisVendidos()
        {
            try
            {
                List<IProduto> ListaAuxiliar = ArquivoEstoque.ListaProdutos.ToList();

                // ordenar lista a partir do produto mais vendido
                ListaAuxiliar.Sort();

                IProduto A = ListaAuxiliar[0];
                IProduto B = ListaAuxiliar[1];
                IProduto C = ListaAuxiliar[2];
                IProduto D = ListaAuxiliar[3];
                IProduto E = ListaAuxiliar[4];

                Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

                string nomeA = A.Nome;
                string nomeB = B.Nome;
                string nomeC = C.Nome;
                string nomeD = D.Nome;
                string nomeE = E.Nome;

                double valorA = A.QuantidadeVendida;
                double valorB = B.QuantidadeVendida;
                double valorC = C.QuantidadeVendida;
                double valorD = D.QuantidadeVendida;
                double valorE = E.QuantidadeVendida;

                pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = nomeA,
                    Values = new ChartValues<double> {valorA},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    PushOut = 5, // se destacar das demais partes
                    //Fill = System.Windows.Media.Brushes.Green // cor da parte A
                },
                new PieSeries
                {
                    Title = nomeB,
                    Values = new ChartValues<double> {valorB},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                },
                new PieSeries
                {
                    Title = nomeC,
                    Values = new ChartValues<double> {valorC},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                },
                new PieSeries
                {
                    Title = nomeD,
                    Values = new ChartValues<double> {valorD},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                },
                new PieSeries
                {
                    Title = nomeE,
                    Values = new ChartValues<double> {valorE},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                }
            };

                // local que a legenda do gráfico aparecerá
                pieChart1.LegendLocation = LegendLocation.Bottom;
            }
            catch { }
        }

        public void AtualizarComponentes()
        {
            MaisVendidos();
            grafico();
            labelSaldo.Text = "R$ " + ArquivoFinanceiro.LerArquivoSaldo().ToString("F2");
            labelSaldoEstoque.Text = "R$ " + SaldoEstoque().ToString("F2");
        }

        public double SaldoEstoque()
        {
            double saldoEstoque = 0;

            try
            {
                foreach (IProduto produto in ArquivoEstoque.ListaProdutos)
                {
                    saldoEstoque += produto.Preco * produto.Quantidade;
                }       
            }
            catch { }

            return saldoEstoque;
        }

    }
}
