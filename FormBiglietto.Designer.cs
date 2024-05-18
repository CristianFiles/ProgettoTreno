namespace ProgettoTreno
{
    partial class FormBiglietto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBiglietto));
            NuovoBiglietto = new Button();
            TipiBiglietti = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dest = new ComboBox();
            passeggero = new TextBox();
            label3 = new Label();
            LabelBiglietti = new Label();
            loop = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // NuovoBiglietto
            // 
            NuovoBiglietto.BackColor = Color.Gray;
            NuovoBiglietto.Font = new Font("Yu Gothic UI", 9.75F);
            NuovoBiglietto.ForeColor = Color.WhiteSmoke;
            NuovoBiglietto.Location = new Point(30, 229);
            NuovoBiglietto.Margin = new Padding(3, 2, 3, 2);
            NuovoBiglietto.Name = "NuovoBiglietto";
            NuovoBiglietto.Size = new Size(111, 29);
            NuovoBiglietto.TabIndex = 0;
            NuovoBiglietto.Text = "Nuovo Biglietto";
            NuovoBiglietto.UseVisualStyleBackColor = false;
            NuovoBiglietto.Click += NuovoBiglietto_Click;
            // 
            // TipiBiglietti
            // 
            TipiBiglietti.BackColor = Color.Gray;
            TipiBiglietti.DropDownStyle = ComboBoxStyle.DropDownList;
            TipiBiglietti.FormattingEnabled = true;
            TipiBiglietti.Location = new Point(29, 43);
            TipiBiglietti.Name = "TipiBiglietti";
            TipiBiglietti.Size = new Size(122, 23);
            TipiBiglietti.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(149, 17);
            label1.TabIndex = 2;
            label1.Text = "Scegli il tipo di biglietto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(29, 69);
            label2.Name = "label2";
            label2.Size = new Size(122, 17);
            label2.TabIndex = 3;
            label2.Text = "Scegli destinazione";
            // 
            // dest
            // 
            dest.BackColor = Color.Gray;
            dest.DropDownStyle = ComboBoxStyle.DropDownList;
            dest.FormattingEnabled = true;
            dest.Location = new Point(30, 87);
            dest.Name = "dest";
            dest.Size = new Size(121, 23);
            dest.TabIndex = 4;
            // 
            // passeggero
            // 
            passeggero.BackColor = Color.Gray;
            passeggero.ForeColor = Color.WhiteSmoke;
            passeggero.Location = new Point(29, 130);
            passeggero.Margin = new Padding(3, 2, 3, 2);
            passeggero.Name = "passeggero";
            passeggero.Size = new Size(122, 23);
            passeggero.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(31, 113);
            label3.Name = "label3";
            label3.Size = new Size(117, 17);
            label3.TabIndex = 6;
            label3.Text = "Nome e cognome";
            // 
            // LabelBiglietti
            // 
            LabelBiglietti.AutoSize = true;
            LabelBiglietti.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            LabelBiglietti.ForeColor = Color.WhiteSmoke;
            LabelBiglietti.Location = new Point(29, 171);
            LabelBiglietti.Name = "LabelBiglietti";
            LabelBiglietti.Size = new Size(121, 17);
            LabelBiglietti.TabIndex = 8;
            LabelBiglietti.Text = "Numero biglietti: 0";
            // 
            // loop
            // 
            loop.Enabled = true;
            loop.Tick += loop_Tick;
            // 
            // FormBiglietto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(208, 281);
            Controls.Add(LabelBiglietti);
            Controls.Add(label3);
            Controls.Add(passeggero);
            Controls.Add(dest);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TipiBiglietti);
            Controls.Add(NuovoBiglietto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(224, 320);
            MinimumSize = new Size(224, 320);
            Name = "FormBiglietto";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label LabelBiglietti;
        private System.Windows.Forms.Timer loop;
    }
}
