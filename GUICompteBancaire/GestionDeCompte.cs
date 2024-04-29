using CompteBancaireLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICompteBancaire
{
    public partial class GestionDeCompte : Form
    {
        private CompteAvecSauvegarde _compte;
        public CompteAvecSauvegarde Compte
        {
            set
            {
                _compte = value;
                Text = _compte.Proprietaire + " ; " + _compte.Numero;
                RemplirLaListe(false);
            }
        }

        private void RemplirLaListe( bool debut )
        {
            listeTransaction.Items.Clear();
            foreach (Transaction t in _compte.Transactions)
            { 
                ListViewItem unElement = new ListViewItem();
                unElement.Text = t.Date.ToString("dd/MM/yyyy");
                unElement.SubItems.Add(t.Montant.ToString("N2"));
                unElement.SubItems.Add(t.Notes);
                unElement.Tag = t;

                listeTransaction.Items.Add(unElement);
            }
            if (listeTransaction.Items.Count > 0)
            {
                if (debut)
                {

                    listeTransaction.Items[0].Selected = true;
                }else
                {
                    listeTransaction.Items[listeTransaction.Items.Count - 1].Selected = true;
                }
            }
        }

        public String Fichier { get; set; }
        public GestionDeCompte()
        {
            InitializeComponent();
            listeTransaction.ListViewItemSorter = new TrieurDeTransaction();
        }

        private void listeTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listeTransaction.SelectedItems.Count > 0)
            {
                ListViewItem unElement = listeTransaction.SelectedItems[0];
                Transaction t = (Transaction)unElement.Tag;
                textBoxMontant.Text = t.Montant.ToString("N2");
                textBoxNotes.Text = t.Notes;
                pickerDate.Value = t.Date;
            }
            else
            {
                textBoxMontant.Text = "";
                textBoxNotes.Text = "";
                pickerDate.Value = DateTime.Now;
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (listeTransaction.SelectedItems.Count > 0)
            {
                ListViewItem unElement = listeTransaction.SelectedItems[0];
                if (unElement.Index > 0)
                {


                    Transaction t = (Transaction)unElement.Tag;

                    DialogResult dr = MessageBox.Show("Etes vous sur ? ", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        listeTransaction.Items.Remove(unElement);
                        if (listeTransaction.Items.Count > 0)
                        {
                            listeTransaction.Items[0].Selected = true;
                        }
                    }
                }

            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            listeTransaction.Enabled = false;
            supprimer.Enabled = false;

            pickerDate.Value = DateTime.Now;
            textBoxMontant.Text = "";
            textBoxNotes.Text = "";
            pickerDate.Focus();

            panelZoom.Enabled = true;
            buttonValider.Visible = true;
            buttonAjouter.Visible = false;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            bool correct = true;
            labelErreur.Text = "";
            decimal montant;
            if(!decimal.TryParse(textBoxMontant.Text, out montant))
            {
                //Erreur
                labelErreur.Text = "Le montant n'est pas correct.";
                correct = false;
            }
            Transaction t = (Transaction)listeTransaction.Items[0].Tag;
            if(pickerDate.Value < t.Date) {
                //Erreur
                labelErreur.Text += " La date est avant le solde initial.";
                correct = false;

            }
            if (correct)
            {
                if(montant > 0)
                {
                    _compte.FaireDepot( montant, pickerDate.Value, textBoxNotes.Text );
                }
                else
                {
                    _compte.FaireRetrait(-1*montant, pickerDate.Value, textBoxNotes.Text);
                }
                RemplirLaListe(false);
            }
            else
            {

                return;
            }
            labelErreur.Text = "";
            panelZoom.Enabled = false;
            buttonValider.Visible = false;
            buttonAjouter.Visible = true;
            listeTransaction.Enabled = true;
            supprimer.Enabled = true;
        }
    }

    internal class TrieurDeTransaction : IComparer
    {
        public int Compare(object? x, object? y)
        {
            ListViewItem elem1 = (ListViewItem)x;
            ListViewItem elem2 = (ListViewItem)y;

            DateTime date1 = DateTime.ParseExact(elem1.Text,"dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact(elem2.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            return DateTime.Compare(date1,date2);
        }
    }
}
