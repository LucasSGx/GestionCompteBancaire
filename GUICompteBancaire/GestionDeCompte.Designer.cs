namespace GUICompteBancaire
{
    partial class GestionDeCompte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listeTransaction = new ListView();
            columnDate = new ColumnHeader();
            columnMontant = new ColumnHeader();
            columnNotes = new ColumnHeader();
            label1 = new Label();
            pickerDate = new DateTimePicker();
            label2 = new Label();
            textBoxMontant = new TextBox();
            label3 = new Label();
            textBoxNotes = new TextBox();
            statusStrip1 = new StatusStrip();
            labelSolde = new ToolStripStatusLabel();
            panelZoom = new Panel();
            supprimer = new Button();
            buttonAjouter = new Button();
            buttonValider = new Button();
            labelErreur = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            panelZoom.SuspendLayout();
            SuspendLayout();
            // 
            // listeTransaction
            // 
            listeTransaction.Columns.AddRange(new ColumnHeader[] { columnDate, columnMontant, columnNotes });
            listeTransaction.FullRowSelect = true;
            listeTransaction.GridLines = true;
            listeTransaction.Location = new Point(12, 30);
            listeTransaction.MultiSelect = false;
            listeTransaction.Name = "listeTransaction";
            listeTransaction.Size = new Size(396, 408);
            listeTransaction.TabIndex = 0;
            listeTransaction.UseCompatibleStateImageBehavior = false;
            listeTransaction.View = View.Details;
            listeTransaction.SelectedIndexChanged += listeTransaction_SelectedIndexChanged;
            // 
            // columnDate
            // 
            columnDate.Text = "Date";
            columnDate.Width = 120;
            // 
            // columnMontant
            // 
            columnMontant.Text = "Montant";
            columnMontant.TextAlign = HorizontalAlignment.Right;
            columnMontant.Width = 160;
            // 
            // columnNotes
            // 
            columnNotes.Text = "Notes";
            columnNotes.Width = 250;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 4);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Date";
            // 
            // pickerDate
            // 
            pickerDate.Location = new Point(30, 34);
            pickerDate.Name = "pickerDate";
            pickerDate.Size = new Size(259, 23);
            pickerDate.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 77);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Montant";
            // 
            // textBoxMontant
            // 
            textBoxMontant.Location = new Point(30, 111);
            textBoxMontant.Name = "textBoxMontant";
            textBoxMontant.Size = new Size(259, 23);
            textBoxMontant.TabIndex = 4;
            textBoxMontant.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 165);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "Notes";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(30, 198);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.ScrollBars = ScrollBars.Both;
            textBoxNotes.Size = new Size(259, 121);
            textBoxNotes.TabIndex = 6;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelSolde, labelErreur });
            statusStrip1.Location = new Point(0, 562);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(930, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelSolde
            // 
            labelSolde.Name = "labelSolde";
            labelSolde.Size = new Size(0, 17);
            // 
            // panelZoom
            // 
            panelZoom.Controls.Add(textBoxNotes);
            panelZoom.Controls.Add(label1);
            panelZoom.Controls.Add(pickerDate);
            panelZoom.Controls.Add(label3);
            panelZoom.Controls.Add(label2);
            panelZoom.Controls.Add(textBoxMontant);
            panelZoom.Location = new Point(429, 30);
            panelZoom.Name = "panelZoom";
            panelZoom.Size = new Size(340, 376);
            panelZoom.TabIndex = 8;
            // 
            // supprimer
            // 
            supprimer.Location = new Point(437, 450);
            supprimer.Name = "supprimer";
            supprimer.Size = new Size(75, 23);
            supprimer.TabIndex = 9;
            supprimer.Text = "Supprimer";
            supprimer.UseVisualStyleBackColor = true;
            supprimer.Click += supprimer_Click;
            // 
            // buttonAjouter
            // 
            buttonAjouter.Location = new Point(694, 450);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(75, 23);
            buttonAjouter.TabIndex = 10;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(694, 450);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 11;
            buttonValider.Text = "Ajouter";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Visible = false;
            buttonValider.Click += buttonValider_Click;
            // 
            // labelErreur
            // 
            labelErreur.ForeColor = Color.Red;
            labelErreur.Name = "labelErreur";
            labelErreur.Size = new Size(0, 17);
            // 
            // GestionDeCompte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 584);
            Controls.Add(buttonValider);
            Controls.Add(buttonAjouter);
            Controls.Add(supprimer);
            Controls.Add(panelZoom);
            Controls.Add(statusStrip1);
            Controls.Add(listeTransaction);
            Name = "GestionDeCompte";
            Text = "GestionDeCompte";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panelZoom.ResumeLayout(false);
            panelZoom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listeTransaction;
        private ColumnHeader columnDate;
        private ColumnHeader columnMontant;
        private ColumnHeader columnNotes;
        private Label label1;
        private DateTimePicker pickerDate;
        private Label label2;
        private TextBox textBoxMontant;
        private Label label3;
        private TextBox textBoxNotes;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelSolde;
        private Panel panelZoom;
        private Button supprimer;
        private Button buttonAjouter;
        private Button buttonValider;
        private ToolStripStatusLabel labelErreur;
    }
}