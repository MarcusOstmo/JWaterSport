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
        private KundList Dykarkurser;
        public JavaWaterSportGUI()
        {
            InitializeComponent();
            AktuellaKunder = new KundList();
            Dykarkurser = new KundList();
            initListView();
        }

        private void initListView()
        {
            lvwAktuellaKunder.FullRowSelect = true;
            lvwAktuellaKunder.GridLines = true;
            lvwDykarkurser.FullRowSelect = true;
            lvwDykarkurser.GridLines = true;
            // Add Columns
            lvwAktuellaKunder.Columns.Add("Förnamn", -2, HorizontalAlignment.Left);
            lvwAktuellaKunder.Columns.Add("Efternamn", -2, HorizontalAlignment.Left);
            lvwAktuellaKunder.Columns.Add("Adress           ", -2, HorizontalAlignment.Left);
            lvwAktuellaKunder.Columns.Add("Telefon          ", -2, HorizontalAlignment.Left);
            lvwAktuellaKunder.Columns.Add("Fullt Paket Bokat (Tid)", -2, HorizontalAlignment.Left);
            lvwAktuellaKunder.Columns.Add("Bokad Dykarkurs (Datum & Tid)", -2, HorizontalAlignment.Left);
            lvwDykarkurser.Columns.Add("Datum", -2, HorizontalAlignment.Left);
            lvwDykarkurser.Columns.Add("Dykinstruktör och tid", -2, HorizontalAlignment.Left);
            updateListView();
        }

        private void updateListView()
        {
            lvwAktuellaKunder.Items.Clear();
            lvwDykarkurser.Items.Clear();
            string[] columnsAktuellaKunder = new string[6];
            string[] columnsDykarkurser = new string[2];
            ListViewItem itemAktuellaKunder;
            ListViewItem itemDykarkurser;
            for (int i = 0; i < AktuellaKunder.Count(); i++)
            {
                columnsAktuellaKunder[0] = AktuellaKunder.Get(i).getFörnamn();
                columnsAktuellaKunder[1] = AktuellaKunder.Get(i).getEfternamn();
                columnsAktuellaKunder[2] = AktuellaKunder.Get(i).getAdress();
                columnsAktuellaKunder[3] = AktuellaKunder.Get(i).getTelefon();
                //columnsAktuellaKunder[4] = AktuellaKunder.Get(i).getFulltPaketOchPakettid();
                //columnsAktuellaKunder[5] = AktuellaKunder.Get(i).getTidDykarkursOchDykinstruktör();
                itemAktuellaKunder = new ListViewItem(columnsAktuellaKunder);
                lvwAktuellaKunder.Items.Add(itemAktuellaKunder);
            }
            for (int i = 0; i < Dykarkurser.Count(); i++)
            {
                columnsDykarkurser[0] = Dykarkurser.Get(i).getDatum();
                columnsDykarkurser[1] = Dykarkurser.Get(i).getTidDykarkursOchDykinstruktör();
                itemDykarkurser = new ListViewItem(columnsDykarkurser);
                lvwDykarkurser.Items.Add(itemDykarkurser);
            }
        }

        //private void addTestData()
        //{
        //    Dykarkurs item = new Dykarkurs("2015-06-04", "10.00-13.00", "Kevin Lundberg");
        //    Dykarkurser.Add(item);
        //    item = new Dykarkurs("2015-07-04","10-13.00","Marcus Östmo");
        //    Dykarkurser.Add(item);
        //    updateListView();
        //}

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
                Kund item = new Kund(tbxFörnamn.Text, tbxEfternamn.Text, tbxAdress.Text, tbxTelefon.Text);
                AktuellaKunder.Add(item);
                updateListView();
            }
            
        }

        private void btnÄndraKunduppgifter_Click(object sender, EventArgs e)
        {

        }

        private void btnBokaDykarkurs_Click(object sender, EventArgs e)
        {
            Dykarkurs item = new Dykarkurs((string)cbxTidDykarkurs.SelectedItem, (string)cbxDykinstruktör.SelectedItem);
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
