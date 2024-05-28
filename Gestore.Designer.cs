namespace ProgettoTreno
{
    partial class Gestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestore));
            MostraBigl = new Button();
            CreaBigl = new Button();
            bottoneSali = new Button();
            contPasseggeri = new NumericUpDown();
            ViewVagoni = new DataGridView();
            Vagoni = new DataGridViewButtonColumn();
            Passeggeri = new DataGridViewTextBoxColumn();
            scendiBottone = new Button();
            ElimBiglietto = new Button();
            SpostaUtente = new Button();
            collegaWifi = new Button();
            togliVagone = new Button();
            ListaVagoniRim = new ComboBox();
            mettiVagone = new Button();
            indexVagone = new NumericUpDown();
            tipiVagone = new ComboBox();
            PresaBtn = new Button();
            Carica = new PictureBox();
            nPostiCounter = new NumericUpDown();
            spostaTanti = new Button();
            ListaVagoniAtt = new ComboBox();
            nSpostati = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)contPasseggeri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewVagoni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)indexVagone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Carica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nPostiCounter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nSpostati).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // MostraBigl
            // 
            MostraBigl.BackColor = Color.Gray;
            MostraBigl.Font = new Font("Yu Gothic UI", 9.75F);
            MostraBigl.ForeColor = Color.WhiteSmoke;
            MostraBigl.Location = new Point(32, 58);
            MostraBigl.Margin = new Padding(3, 2, 3, 2);
            MostraBigl.Name = "MostraBigl";
            MostraBigl.Size = new Size(135, 28);
            MostraBigl.TabIndex = 0;
            MostraBigl.Text = "Mostra Biglietto";
            MostraBigl.TextAlign = ContentAlignment.TopCenter;
            MostraBigl.UseVisualStyleBackColor = false;
            MostraBigl.Click += MostraBigl_Click;
            // 
            // CreaBigl
            // 
            CreaBigl.BackColor = Color.Gray;
            CreaBigl.Font = new Font("Yu Gothic UI", 9.75F);
            CreaBigl.ForeColor = Color.WhiteSmoke;
            CreaBigl.Location = new Point(32, 27);
            CreaBigl.Margin = new Padding(3, 2, 3, 2);
            CreaBigl.Name = "CreaBigl";
            CreaBigl.Size = new Size(135, 28);
            CreaBigl.TabIndex = 0;
            CreaBigl.Text = "Crea Biglietto";
            CreaBigl.TextAlign = ContentAlignment.TopCenter;
            CreaBigl.UseVisualStyleBackColor = false;
            CreaBigl.Click += CreaBigl_Click;
            // 
            // bottoneSali
            // 
            bottoneSali.BackColor = Color.Gray;
            bottoneSali.Font = new Font("Yu Gothic UI", 9.75F);
            bottoneSali.ForeColor = Color.WhiteSmoke;
            bottoneSali.Location = new Point(20, 51);
            bottoneSali.Margin = new Padding(3, 2, 3, 2);
            bottoneSali.Name = "bottoneSali";
            bottoneSali.Size = new Size(88, 28);
            bottoneSali.TabIndex = 1;
            bottoneSali.Text = "Salire";
            bottoneSali.TextAlign = ContentAlignment.TopCenter;
            bottoneSali.UseVisualStyleBackColor = false;
            bottoneSali.Click += bottoneSali_Click;
            // 
            // contPasseggeri
            // 
            contPasseggeri.BackColor = Color.DarkGray;
            contPasseggeri.ForeColor = Color.WhiteSmoke;
            contPasseggeri.Location = new Point(114, 55);
            contPasseggeri.Margin = new Padding(3, 2, 3, 2);
            contPasseggeri.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            contPasseggeri.Name = "contPasseggeri";
            contPasseggeri.Size = new Size(52, 23);
            contPasseggeri.TabIndex = 2;
            // 
            // ViewVagoni
            // 
            ViewVagoni.AllowUserToAddRows = false;
            ViewVagoni.AllowUserToDeleteRows = false;
            ViewVagoni.AllowUserToResizeColumns = false;
            ViewVagoni.AllowUserToResizeRows = false;
            ViewVagoni.Anchor = AnchorStyles.None;
            ViewVagoni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewVagoni.Columns.AddRange(new DataGridViewColumn[] { Vagoni, Passeggeri });
            ViewVagoni.Location = new Point(481, 219);
            ViewVagoni.Margin = new Padding(3, 2, 3, 2);
            ViewVagoni.MultiSelect = false;
            ViewVagoni.Name = "ViewVagoni";
            ViewVagoni.ReadOnly = true;
            ViewVagoni.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            ViewVagoni.Size = new Size(295, 220);
            ViewVagoni.TabIndex = 2;
            ViewVagoni.CellContentClick += ViewVagoni_CellContentClick;
            // 
            // Vagoni
            // 
            Vagoni.HeaderText = "Vagoni";
            Vagoni.MinimumWidth = 6;
            Vagoni.Name = "Vagoni";
            Vagoni.ReadOnly = true;
            Vagoni.Width = 125;
            // 
            // Passeggeri
            // 
            Passeggeri.HeaderText = "Passeggeri";
            Passeggeri.MinimumWidth = 6;
            Passeggeri.Name = "Passeggeri";
            Passeggeri.ReadOnly = true;
            Passeggeri.Width = 125;
            // 
            // scendiBottone
            // 
            scendiBottone.BackColor = Color.Gray;
            scendiBottone.Font = new Font("Yu Gothic UI", 9.75F);
            scendiBottone.ForeColor = Color.WhiteSmoke;
            scendiBottone.Location = new Point(20, 24);
            scendiBottone.Margin = new Padding(3, 2, 3, 2);
            scendiBottone.Name = "scendiBottone";
            scendiBottone.Size = new Size(88, 28);
            scendiBottone.TabIndex = 3;
            scendiBottone.Text = "Scendere";
            scendiBottone.TextAlign = ContentAlignment.TopCenter;
            scendiBottone.UseVisualStyleBackColor = false;
            scendiBottone.Click += scendiBottone_Click;
            // 
            // ElimBiglietto
            // 
            ElimBiglietto.BackColor = Color.Gray;
            ElimBiglietto.Font = new Font("Yu Gothic UI", 9.75F);
            ElimBiglietto.ForeColor = Color.WhiteSmoke;
            ElimBiglietto.Location = new Point(32, 90);
            ElimBiglietto.Name = "ElimBiglietto";
            ElimBiglietto.Size = new Size(135, 28);
            ElimBiglietto.TabIndex = 4;
            ElimBiglietto.Text = "Elimina Biglietto";
            ElimBiglietto.TextAlign = ContentAlignment.TopCenter;
            ElimBiglietto.UseVisualStyleBackColor = false;
            ElimBiglietto.Click += ElimBiglietto_Click;
            // 
            // SpostaUtente
            // 
            SpostaUtente.BackColor = Color.Gray;
            SpostaUtente.Font = new Font("Yu Gothic UI", 9.75F);
            SpostaUtente.ForeColor = Color.WhiteSmoke;
            SpostaUtente.Location = new Point(32, 123);
            SpostaUtente.Name = "SpostaUtente";
            SpostaUtente.Size = new Size(135, 28);
            SpostaUtente.TabIndex = 5;
            SpostaUtente.Text = "Spostati nel vagone";
            SpostaUtente.TextAlign = ContentAlignment.TopCenter;
            SpostaUtente.UseVisualStyleBackColor = false;
            SpostaUtente.Click += SpostaUtente_Click;
            // 
            // collegaWifi
            // 
            collegaWifi.BackColor = Color.Gray;
            collegaWifi.Font = new Font("Yu Gothic UI", 9.75F);
            collegaWifi.ForeColor = Color.WhiteSmoke;
            collegaWifi.Location = new Point(32, 154);
            collegaWifi.Name = "collegaWifi";
            collegaWifi.Size = new Size(135, 28);
            collegaWifi.TabIndex = 7;
            collegaWifi.Text = "Collega WiFi";
            collegaWifi.TextAlign = ContentAlignment.TopCenter;
            collegaWifi.UseVisualStyleBackColor = false;
            collegaWifi.Click += collegaWifi_Click;
            // 
            // togliVagone
            // 
            togliVagone.BackColor = Color.Gray;
            togliVagone.Font = new Font("Yu Gothic UI", 9.75F);
            togliVagone.ForeColor = Color.WhiteSmoke;
            togliVagone.Location = new Point(172, 19);
            togliVagone.Name = "togliVagone";
            togliVagone.Size = new Size(121, 28);
            togliVagone.TabIndex = 8;
            togliVagone.Text = "Rimuovi Vagone";
            togliVagone.TextAlign = ContentAlignment.TopCenter;
            togliVagone.UseVisualStyleBackColor = false;
            togliVagone.Click += togliVagone_Click;
            // 
            // ListaVagoniRim
            // 
            ListaVagoniRim.BackColor = Color.Gray;
            ListaVagoniRim.DropDownStyle = ComboBoxStyle.DropDownList;
            ListaVagoniRim.FormattingEnabled = true;
            ListaVagoniRim.Location = new Point(22, 22);
            ListaVagoniRim.Name = "ListaVagoniRim";
            ListaVagoniRim.Size = new Size(121, 23);
            ListaVagoniRim.TabIndex = 9;
            // 
            // mettiVagone
            // 
            mettiVagone.BackColor = Color.Gray;
            mettiVagone.Font = new Font("Yu Gothic UI", 9.75F);
            mettiVagone.ForeColor = Color.WhiteSmoke;
            mettiVagone.Location = new Point(172, 59);
            mettiVagone.Name = "mettiVagone";
            mettiVagone.Size = new Size(121, 28);
            mettiVagone.TabIndex = 10;
            mettiVagone.Text = "Aggiungi Vagone";
            mettiVagone.TextAlign = ContentAlignment.TopCenter;
            mettiVagone.UseVisualStyleBackColor = false;
            mettiVagone.Click += mettiVagone_Click;
            // 
            // indexVagone
            // 
            indexVagone.BackColor = Color.DarkGray;
            indexVagone.ForeColor = Color.WhiteSmoke;
            indexVagone.Location = new Point(251, 24);
            indexVagone.Margin = new Padding(3, 2, 3, 2);
            indexVagone.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            indexVagone.Name = "indexVagone";
            indexVagone.Size = new Size(42, 23);
            indexVagone.TabIndex = 11;
            // 
            // tipiVagone
            // 
            tipiVagone.BackColor = Color.DarkGray;
            tipiVagone.DropDownStyle = ComboBoxStyle.DropDownList;
            tipiVagone.FormattingEnabled = true;
            tipiVagone.Location = new Point(45, 23);
            tipiVagone.Name = "tipiVagone";
            tipiVagone.Size = new Size(121, 23);
            tipiVagone.TabIndex = 12;
            // 
            // PresaBtn
            // 
            PresaBtn.BackColor = Color.Gray;
            PresaBtn.Font = new Font("Yu Gothic UI", 9.75F);
            PresaBtn.ForeColor = Color.WhiteSmoke;
            PresaBtn.Location = new Point(32, 186);
            PresaBtn.Margin = new Padding(3, 2, 3, 2);
            PresaBtn.Name = "PresaBtn";
            PresaBtn.Size = new Size(135, 28);
            PresaBtn.TabIndex = 13;
            PresaBtn.Text = "Attacco presa";
            PresaBtn.TextAlign = ContentAlignment.TopCenter;
            PresaBtn.UseVisualStyleBackColor = false;
            PresaBtn.Click += PresaBtn_Click;
            // 
            // Carica
            // 
            Carica.Anchor = AnchorStyles.None;
            Carica.Image = (Image)resources.GetObject("Carica.Image");
            Carica.Location = new Point(-5, 221);
            Carica.Margin = new Padding(3, 2, 3, 2);
            Carica.Name = "Carica";
            Carica.Size = new Size(164, 187);
            Carica.TabIndex = 14;
            Carica.TabStop = false;
            // 
            // nPostiCounter
            // 
            nPostiCounter.BackColor = Color.Gray;
            nPostiCounter.ForeColor = Color.WhiteSmoke;
            nPostiCounter.Location = new Point(86, 63);
            nPostiCounter.Margin = new Padding(3, 2, 3, 2);
            nPostiCounter.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nPostiCounter.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            nPostiCounter.Name = "nPostiCounter";
            nPostiCounter.Size = new Size(42, 23);
            nPostiCounter.TabIndex = 13;
            nPostiCounter.Value = new decimal(new int[] { 12, 0, 0, 0 });
            nPostiCounter.ValueChanged += nPostiCounter_ValueChanged;
            // 
            // spostaTanti
            // 
            spostaTanti.BackColor = Color.Gray;
            spostaTanti.Font = new Font("Yu Gothic UI", 9.75F);
            spostaTanti.ForeColor = Color.WhiteSmoke;
            spostaTanti.Location = new Point(20, 50);
            spostaTanti.Name = "spostaTanti";
            spostaTanti.Size = new Size(134, 28);
            spostaTanti.TabIndex = 14;
            spostaTanti.Text = "Sposta";
            spostaTanti.TextAlign = ContentAlignment.TopCenter;
            spostaTanti.UseVisualStyleBackColor = false;
            spostaTanti.Click += spostaTanti_Click;
            // 
            // ListaVagoniAtt
            // 
            ListaVagoniAtt.BackColor = Color.DarkGray;
            ListaVagoniAtt.DropDownStyle = ComboBoxStyle.DropDownList;
            ListaVagoniAtt.FormattingEnabled = true;
            ListaVagoniAtt.Location = new Point(60, 22);
            ListaVagoniAtt.Name = "ListaVagoniAtt";
            ListaVagoniAtt.Size = new Size(94, 23);
            ListaVagoniAtt.TabIndex = 15;
            // 
            // nSpostati
            // 
            nSpostati.BackColor = Color.Gray;
            nSpostati.ForeColor = Color.WhiteSmoke;
            nSpostati.Location = new Point(20, 22);
            nSpostati.Margin = new Padding(3, 2, 3, 2);
            nSpostati.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nSpostati.Name = "nSpostati";
            nSpostati.Size = new Size(34, 23);
            nSpostati.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(185, 30);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 19;
            label3.Text = "Posizione:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(22, 65);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 20;
            label4.Text = "Capienza:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tipiVagone);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(indexVagone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nPostiCounter);
            groupBox1.Controls.Add(mettiVagone);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(6, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 104);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aggiunta vagone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 21;
            label2.Text = "Tipo:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ListaVagoniRim);
            groupBox2.Controls.Add(togliVagone);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(6, 132);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 59);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rimozione vagone";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ListaVagoniAtt);
            groupBox3.Controls.Add(spostaTanti);
            groupBox3.Controls.Add(nSpostati);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(6, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 99);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sposta in altro vagone";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(scendiBottone);
            groupBox4.Controls.Add(bottoneSali);
            groupBox4.Controls.Add(contPasseggeri);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(6, 127);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 100);
            groupBox4.TabIndex = 26;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rimuovi o aggiungi";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(groupBox1);
            groupBox5.Controls.Add(groupBox2);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(455, 8);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(336, 206);
            groupBox5.TabIndex = 27;
            groupBox5.TabStop = false;
            groupBox5.Text = "Gestione vagoni";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(groupBox3);
            groupBox6.Controls.Add(groupBox4);
            groupBox6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(242, 205);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(212, 234);
            groupBox6.TabIndex = 28;
            groupBox6.TabStop = false;
            groupBox6.Text = "Gestione passeggeri";
            // 
            // Gestore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(Carica);
            Controls.Add(PresaBtn);
            Controls.Add(collegaWifi);
            Controls.Add(SpostaUtente);
            Controls.Add(ElimBiglietto);
            Controls.Add(ViewVagoni);
            Controls.Add(CreaBigl);
            Controls.Add(MostraBigl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Gestore";
            Text = "Gestore";
            Load += Gestore_Load;
            ((System.ComponentModel.ISupportInitialize)contPasseggeri).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewVagoni).EndInit();
            ((System.ComponentModel.ISupportInitialize)indexVagone).EndInit();
            ((System.ComponentModel.ISupportInitialize)Carica).EndInit();
            ((System.ComponentModel.ISupportInitialize)nPostiCounter).EndInit();
            ((System.ComponentModel.ISupportInitialize)nSpostati).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button MostraBigl;
        private Button CreaBigl;

        private Button bottoneSali;
        private NumericUpDown contPasseggeri;

        private DataGridView ViewVagoni;
        private DataGridViewButtonColumn Vagoni;
        private DataGridViewTextBoxColumn Passeggeri;
        private Button scendiBottone;
        private Button ElimBiglietto;
        private Button SpostaUtente;
        private Button collegaWifi;
        private Button togliVagone;
        private ComboBox ListaVagoniRim;
        private Button mettiVagone;
        private NumericUpDown indexVagone;
        private ComboBox tipiVagone;
        private Button PresaBtn;
        private PictureBox Carica;
        private NumericUpDown nPostiCounter;
        private Button spostaTanti;
        private ComboBox ListaVagoniAtt;
        private NumericUpDown nSpostati;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
    }
}