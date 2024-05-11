using System.Data;
using System.Xml;

namespace dovizuyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guncelle();
            adlariGuncelle();
            timer1.Interval = 10000;
            timer1.Enabled = true;
        }

        private void adlariGuncelle()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    listBox1.Items.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }
        }

        private void guncelle()
        {
            XmlTextReader rdr = new XmlTextReader("https://www.tcmb.gov.tr/kurlar/today.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(rdr);
            dataGridView1.DataSource = ds.Tables["Currency"];
            label9.Text = DateTime.Now.ToString();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sno = listBox1.SelectedIndex;
            string dCinsi = dataGridView1.Rows[sno].Cells[1].Value.ToString();
            label5.Text = dCinsi;
            string alis = dataGridView1.Rows[sno].Cells[3].Value.ToString();
            string satis = dataGridView1.Rows[sno].Cells[4].Value.ToString();
            textBox1.Text = alis;
            textBox3.Text = satis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "ALIÞ";
            label7.Text = "0";
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double alis = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                double miktar = Convert.ToDouble(textBox2.Text.Replace(".", ","));
                double snc = alis * miktar;
                label7.Text = snc.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "SATIÞ";
            label7.Text = "0";
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                double alis = Convert.ToDouble(textBox3.Text.Replace(".", ","));
                double miktar = Convert.ToDouble(textBox4.Text.Replace(".", ","));
                double snc = alis * miktar;
                label7.Text = snc.ToString();
            }
        }
    }
}
