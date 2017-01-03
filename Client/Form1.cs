using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Middleware;

namespace Client
{
    public partial class Form1 : Form
    {

        private DataSet dataset;
        private Clprocessus oPr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dB_A2_WS2DataSet.TB_A2_WS2'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tB_A2_WS2TableAdapter.Fill(this.dB_A2_WS2DataSet.TB_A2_WS2);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.oPr.insert_update(textBoxId.Text, textBoxNom.Text, textBoxPrenom.Text,'i');
            this.dataset = this.oPr.afficher("row");
            this.dataGridView1.DataSource = this.dataset.Tables["row"];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxNom.Clear();
            textBoxPrenom.Clear();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataset = this.oPr.rechercherNom("row", "");
            this.dataGridView1.DataSource = this.dataset.Tables["row"];
        }

        private void button_suprrimer_Click(object sender, EventArgs e)
        {
            this.oPr.deletById();
            this.dataGridView1.DataSource = this.dataset.Tables["row"];
        }

        private void button_charger_Click(object sender, EventArgs e)
        {
            this.dataset = this.oPr.afficher("row");
            this.dataGridView1.DataSource = this.dataset.Tables["row"];
        }
    }
}
