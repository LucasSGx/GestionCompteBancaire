using CompteBancaireLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                RemplirLaListe();
            }
        }

        private void RemplirLaListe()
        {
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
                listeTransaction.Items[0].Selected = true;
            }
        }

        public String Fichier { get; set; }
        public GestionDeCompte()
        {
            InitializeComponent();
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

                Transaction t = (Transaction)unElement.Tag;

                DialogResult dr = MessageBox.Show("Etes vous sur ? ", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    listeTransaction.Items.Remove( unElement );
                    if (listeTransaction.Items.Count > 0)
                    {
                        listeTransaction.Items[0].Selected = true;
                    }
                }

            }
        }
    }
}
