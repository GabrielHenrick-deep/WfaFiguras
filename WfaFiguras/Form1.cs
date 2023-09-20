using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WfaFiguras.recurses;

namespace WfaFiguras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.branco;
            ocultaPainel();
            GerarGradeListViewArea();
        }
        private void ocultaPainel()
        {
            panel1.Visible = false;
        }
        private void GerarGradeListViewArea()
        {
            listView1.Columns.Add("Nome", 70).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Lado", 60).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Altura", 60).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Base", 60).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Raio", 60).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Area", 100).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Perimetro", 100).TextAlign = HorizontalAlignment.Center;
            listView1.View = View.Details;
        }

        private void button_calcular_MouseClick(object sender, MouseEventArgs e)
        {
            if(rbQuadrado.Checked == true)
            {
                Formas objFormas = new Quadrado("Quadrado", Convert.ToDouble(tbTop.Text));
                InserirAreaQuadradoListView(objFormas);
            }
            if(rbRetangulo.Checked == true)
            {
                Formas objFormas = new Retangulo("Retangulo", Convert.ToDouble(tbTop.Text), Convert.ToDouble(tbDown.Text));
                InserirAreaRetanguloListView(objFormas);
            }
            if(rbTriangulo.Checked == true)
            {
                Formas objFormas = new Triangulo("Triangulo", Convert.ToDouble(tbTop.Text), Convert.ToDouble(tbDown.Text));
                InserirAreaTrianguloListView(objFormas);
            }
            if(rbCirculo.Checked == true)
            {
                Formas objFormas = new Circulo("Circulo", Convert.ToDouble(tbTop.Text));
                InserirAreaCirculoListView(objFormas);
            }
        }
        private void InserirAreaQuadradoListView(Formas objFormas)
        {
            string[] formasGeos = new string[7];
            formasGeos[0] = objFormas.Nome;
            formasGeos[1] = tbTop.Text;
            formasGeos[5] = Convert.ToString(objFormas.Area());
            formasGeos[6] = Convert.ToString(objFormas.Perimetro());
            listView1.Items.Add(new ListViewItem(formasGeos));
        }
        private void InserirAreaRetanguloListView(Formas objFormas)
        {
            string[] formasGeos = new string[7];

            formasGeos[0] = objFormas.Nome;
            formasGeos[2] = tbTop.Text;
            formasGeos[3] = tbDown.Text;
            formasGeos[5] = Convert.ToString(objFormas.Area());
            formasGeos[6] = Convert.ToString(objFormas.Perimetro());
            listView1.Items.Add(new ListViewItem(formasGeos));
        }
        private void InserirAreaTrianguloListView(Formas objFormas)
        {
            string[] formasGeos = new string[7];
            formasGeos[0] = objFormas.Nome;
            formasGeos[2] = tbTop.Text;
            formasGeos[3] = tbDown.Text;
            formasGeos[5] = Convert.ToString(objFormas.Area());
            formasGeos[6] = objFormas.Perimetro().ToString("0.00");
            listView1.Items.Add(new ListViewItem(formasGeos));
        }
        private void InserirAreaCirculoListView(Formas objFormas)
        {
            string[] formasGeos = new string[7];

            formasGeos[0] = objFormas.Nome;
            formasGeos[4] = tbTop.Text;
            formasGeos[5] = objFormas.Area().ToString("0.00");
            formasGeos[6] = objFormas.Perimetro().ToString("0.00");
            listView1.Items.Add(new ListViewItem(formasGeos));
        }

        private void rbQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.quadrado;
            label_top.Text = "Lado";
            label_Down.Text = " ";
            label_top.Enabled = true;
            label_Down.Enabled = false;
            tbDown.Enabled = false;
            panel1.Visible = true;
        }

        private void rbRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.retangulo;
            label_top.Text = "Base";
            label_Down.Text = "Altura";
            label_top.Enabled = true;
            label_Down.Enabled = true;
            tbDown.Enabled = true;
            panel1.Visible = true;
        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.triangulo;
            label_top.Text = "Base";
            label_Down.Text = "Altura";
            label_top.Enabled = true;
            label_Down.Enabled = true;
            tbDown.Enabled = true;
            panel1.Visible = true;
        }

        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.circulo;
            label_top.Text = "Raio";
            label_Down.Text = " ";
            label_top.Enabled = true;
            label_Down.Enabled = false;
            tbDown.Enabled = false;
            panel1.Visible = true;
        }
    }
}
