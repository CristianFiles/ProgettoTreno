﻿namespace ProgettoTreno
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
            TipiBiglietti.FormattingEnabled = true;
            TipiBiglietti.Items.AddRange(new object[] { "Seconda classe", "Prima classe" });
            TipiBiglietti.Location = new Point(25, 90);
            TipiBiglietti.Name = "TipiBiglietti";
            TipiBiglietti.Size = new Size(121, 23);
            TipiBiglietti.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(TipiBiglietti);
            Controls.Add(NuovoBiglietto);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Biglietteria";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button NuovoBiglietto;
        private ComboBox TipiBiglietti;
    }
}
