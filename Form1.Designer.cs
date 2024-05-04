namespace ProgettoTreno
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NuovoBiglietto = new Button();
            TipiBiglietti = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            destinazione = new ComboBox();
            SuspendLayout();
            // 
            // NuovoBiglietto
            // 
            NuovoBiglietto.Location = new Point(25, 386);
            NuovoBiglietto.Margin = new Padding(3, 2, 3, 2);
            NuovoBiglietto.Name = "NuovoBiglietto";
            NuovoBiglietto.Size = new Size(111, 29);
            NuovoBiglietto.TabIndex = 0;
            NuovoBiglietto.Text = "Nuovo Biglietto";
            NuovoBiglietto.UseVisualStyleBackColor = true;
            NuovoBiglietto.Click += NuovoBiglietto_Click;
            // 
            // TipiBiglietti
            // 
            TipiBiglietti.DropDownStyle = ComboBoxStyle.DropDownList;
            TipiBiglietti.FormattingEnabled = true;
            TipiBiglietti.Location = new Point(25, 89);
            TipiBiglietti.Name = "TipiBiglietti";
            TipiBiglietti.Size = new Size(121, 23);
            TipiBiglietti.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 71);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 2;
            label1.Text = "Scegli il tipo di biglietto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 129);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 3;
            label2.Text = "scegli destinazione";
            // 
            // destinazione
            // 
            destinazione.DropDownStyle = ComboBoxStyle.DropDownList;
            destinazione.FormattingEnabled = true;
            destinazione.Items.AddRange(new object[] { "Abruzzo", "Basilicata", "Calabria", "Campania", "Emilia Romagna", "Friuli Venezia Giulia", "Lazio ", "Liguria", "Lombardia", "Marche", "Molise", "Piemonte", "Puglia", "Sardegna ", "Sicilia ", "Toscana", "Trentino Alto Adige", "Umbria", "Val D'aosta", "Veneto" });
            destinazione.Location = new Point(28, 150);
            destinazione.Name = "destinazione";
            destinazione.Size = new Size(121, 23);
            destinazione.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(destinazione);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TipiBiglietti);
            Controls.Add(NuovoBiglietto);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Biglietteria";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NuovoBiglietto;
        private ComboBox TipiBiglietti;
        private Label label1;
        private Label label2;
        private ComboBox destinazione;
    }
}
