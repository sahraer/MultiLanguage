using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //appData.WriteXml(string.Format("{0}/data.xml", Application.StartupPath));
            //ResourceWriter ren = new ResourceWriter(Application.StartupPath + "/resource.en-US.resources");
            //ResourceWriter rde = new ResourceWriter(Application.StartupPath + "/resource.de-DE.resources");
            //ResourceWriter fr = new ResourceWriter(Application.StartupPath + "/resource.fr-FR.resources");

            //foreach (AppData.LanguageRow row in appData.Language.Rows)
            //{
            //    ren.AddResource(row.ID, row.English);
            //    rde.AddResource(row.ID, row.German);
            //    fr.AddResource(row.ID, row.French);
            //}
            //ren.Generate();
            //ren.Close();
            //rde.Generate();
            //rde.Close();
            //fr.Generate();
            //fr.Close();
            //MessageBox.Show("Successfuly saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            appData.ReadXml(string.Format("{0}/data.xml", Application.StartupPath));
            comboBox1.Items.Add("en-US");
            comboBox1.Items.Add("de-DE");
            comboBox1.Items.Add("fr-FR");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            appData.ReadXml(string.Format("{0}/data.xml", Application.StartupPath));
            var selected = comboBox1.SelectedItem;
            CultureInfo cultureInfo = new CultureInfo(selected.ToString());
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            ResourceManager rm = ResourceManager.CreateFileBasedResourceManager("resource", Application.StartupPath, null);
            if (rm.GetString("002") != null)
            {
                label1.Text = rm.GetString("002");
                //radioButton1.Text = rm.GetString("02");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)

            {

                //seçili satırı siliyoruz.


                //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                //appData.ReadXml(string.Format("{0}/data.xml", Application.StartupPath));
                //File.Delete()

            }

            else

            {

                MessageBox.Show("Lüffen Silinecek Satırı Seçin!");

            }
        }
    }
}

