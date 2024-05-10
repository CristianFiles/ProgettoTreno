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
            dest = new ComboBox();
            passeggero = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // NuovoBiglietto
            // 
            NuovoBiglietto.Location = new Point(29, 515);
            NuovoBiglietto.Name = "NuovoBiglietto";
            NuovoBiglietto.Size = new Size(127, 39);
            NuovoBiglietto.TabIndex = 0;
            NuovoBiglietto.Text = "Nuovo Biglietto";
            NuovoBiglietto.UseVisualStyleBackColor = true;
            NuovoBiglietto.Click += NuovoBiglietto_Click;
            // 
            // TipiBiglietti
            // 
            TipiBiglietti.DropDownStyle = ComboBoxStyle.DropDownList;
            TipiBiglietti.FormattingEnabled = true;
            TipiBiglietti.Location = new Point(29, 119);
            TipiBiglietti.Margin = new Padding(3, 4, 3, 4);
            TipiBiglietti.Name = "TipiBiglietti";
            TipiBiglietti.Size = new Size(138, 28);
            TipiBiglietti.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 95);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 2;
            label1.Text = "Scegli il tipo di biglietto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 172);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 3;
            label2.Text = "Scegli destinazione";
            // 
            // dest
            // 
            dest.DropDownStyle = ComboBoxStyle.DropDownList;
            dest.FormattingEnabled = true;
            dest.Location = new Point(32, 200);
            dest.Margin = new Padding(3, 4, 3, 4);
            dest.Name = "dest";
            dest.Size = new Size(138, 28);
            dest.TabIndex = 4;
            // 
            // passeggero
            // 
            passeggero.Location = new Point(32, 281);
            passeggero.Name = "passeggero";
            passeggero.Size = new Size(138, 27);
            passeggero.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 243);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 6;
            label3.Text = "Nome e cognome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 588);
            Controls.Add(label3);
            Controls.Add(passeggero);
            Controls.Add(dest);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TipiBiglietti);
            Controls.Add(NuovoBiglietto);
            Name = "Form1";
            Text = "Biglietteria";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NuovoBiglietto;
        private ComboBox TipiBiglietti;
        private Label label1;
        private Label label2;
        private ComboBox dest;
        private TextBox passeggero;
        private Label label3;
    }
}
