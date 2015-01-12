using System;
using JWS.Controler;
using JWS.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JWS.View
{
    public partial class JavaWaterSportGUI : Form
    {
        private KundList AktuellaKunder;
        public JavaWaterSportGUI()
        {
            InitializeComponent();
            AktuellaKunder = new KundList();
            initListView();
        }

        private void initListView()
        {
            lvwAktuellaKunder.FullRowSelect = true;
            lvwAktuellaKunder.GridLines = true;
            // Add Columns
            lvwAktuellaKunder.Columns.Add("Förnamn", -2, HorizontalAlignment.Left);
            lvwAktuellaKunder.Columns.Add("Efternamn", -2, HorizontalAlignment.Left);
            lvwAktuellaKunder.Columns.Add("Adress          ", -2, HorizontalAlignment.Left);
            lvwAktuellaKunder.Columns.Add("Telefon         ", -2, HorizontalAlignment.Left);
            lvwAktuellaKunder.Columns.Add("Fullt Paket Bokat (Tid)", -2, HorizontalAlignment.Left);
            lvwAktuellaKunder.Columns.Add("Bokad Dykarkurs (Tid)", -2, HorizontalAlignment.Left);
            updateListView();
        }

        private void updateListView()
        {
            lvwAktuellaKunder.Items.Clear();
            string[] columns = new string[6];
            ListViewItem item;
            for (int i = 0; i < AktuellaKunder.Count(); i++)
            {
                columns[0] = AktuellaKunder.Get(i).getFörnamn();
                columns[1] = AktuellaKunder.Get(i).getEfternamn();
                columns[2] = AktuellaKunder.Get(i).getAdress();
                columns[3] = AktuellaKunder.Get(i).getTelefon();
                columns[4] = AktuellaKunder.Get(i).getFulltPaketOchPakettid();
                item = new ListViewItem(columns);
                lvwAktuellaKunder.Items.Add(item);
            }
        }

        private void btnRegistreraKund_Click(object sender, EventArgs e)
        {
            if (cbxFulltPaket.Checked == true && cbxFulltPaketTid.Text == "Välj hyrtid")
            {
                MessageBox.Show("Ange tid utrustning ska hyras!");
            }
            if (cbxFulltPaket.Checked == false && ( cbxFulltPaketTid.Text == "1 h" || cbxFulltPaketTid.Text == "2 h" || cbxFulltPaketTid.Text == "3 h"))
            {
                MessageBox.Show("Du kan inte ange hyrtid på utrustning du inte hyrt!");
            }
            else
            {
                Kund item = new Kund(tbxFörnamn.Text, tbxEfternamn.Text, tbxAdress.Text, tbxTelefon.Text, (string)cbxFulltPaketTid.SelectedItem, cbxFulltPaket.Checked);
                AktuellaKunder.Add(item);
                updateListView();
            }
            
        }

        private void btnÄndraKunduppgifter_Click(object sender, EventArgs e)
        {

        }

        private void btnBokaDykarkurs_Click(object sender, EventArgs e)
        {

        }

        private void btnÄndraKursuppgifter_Click(object sender, EventArgs e)
        {

        }

        private void btnTaBortKund_Click(object sender, EventArgs e)
        {

        }

        private void btnSkrivUtKund_Click(object sender, EventArgs e)
        {

        }
    }
}
