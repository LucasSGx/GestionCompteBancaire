using CompteBancaireLib;

namespace GUICompteBancaire
{
    public partial class FenetrePrincipale : Form
    {
        public FenetrePrincipale()
        {
            InitializeComponent();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichier CSV (.csv)|*.csv|Fichiers JSON (.json)|*.json|Tous les fichiers (*.*)|*.*";
            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fichier = ofd.FileName;
                string ext = Path.GetExtension(fichier).ToLower();
                CompteAvecSauvegarde compte = null;
                try
                {
                    if (ext == ".csv")
                    {
                        compte = CompteAvecSauvegarde.LireCSV(fichier);
                    }
                    else if (ext == " .json")
                    {
                        compte = CompteAvecSauvegarde.LireJSON(fichier);
                    }
                    else
                    {
                        MessageBox.Show("Type de fichier inconnu.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //
                    bool found = false;
                    foreach (GestionDeCompte gc in this.MdiChildren)
                    {
                        if (gc.Fichier == fichier)
                        {
                            found = true; 
                            gc.Activate();
                            break;

                        }
                    }
                    if (!found)
                    {
                        GestionDeCompte nouvelleFenetre = new GestionDeCompte();
                        nouvelleFenetre.Fichier = fichier;
                        nouvelleFenetre.Compte = compte;
                        nouvelleFenetre.MdiParent = this;
                        nouvelleFenetre.Show();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
