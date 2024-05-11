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
            ListaDropVagoni = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)contPasseggeri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewVagoni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)indexVagone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Carica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nPostiCounter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nSpostati).BeginInit();
            SuspendLayout();
            // 
            // MostraBigl
            // 
            MostraBigl.Location = new Point(32, 58);
            MostraBigl.Margin = new Padding(3, 2, 3, 2);
            MostraBigl.Name = "MostraBigl";
            MostraBigl.Size = new Size(127, 27);
            MostraBigl.TabIndex = 0;
            MostraBigl.Text = "Mostra Biglietto";
            MostraBigl.UseVisualStyleBackColor = true;
            MostraBigl.Click += MostraBigl_Click;
            // 
            // CreaBigl
            // 
            CreaBigl.Location = new Point(32, 27);
            CreaBigl.Margin = new Padding(3, 2, 3, 2);
            CreaBigl.Name = "CreaBigl";
            CreaBigl.Size = new Size(127, 27);
            CreaBigl.TabIndex = 0;
            CreaBigl.Text = "Crea Biglietto";
            CreaBigl.Click += CreaBigl_Click;
            // 
            // bottoneSali
            // 
            bottoneSali.Location = new Point(297, 387);
            bottoneSali.Margin = new Padding(3, 2, 3, 2);
            bottoneSali.Name = "bottoneSali";
            bottoneSali.Size = new Size(82, 22);
            bottoneSali.TabIndex = 1;
            bottoneSali.Text = "Fai salire";
            bottoneSali.UseVisualStyleBackColor = true;
            bottoneSali.Click += bottoneSali_Click;
            // 
            // contPasseggeri
            // 
            contPasseggeri.Location = new Point(297, 414);
            contPasseggeri.Margin = new Padding(3, 2, 3, 2);
            contPasseggeri.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            contPasseggeri.Name = "contPasseggeri";
            contPasseggeri.Size = new Size(170, 23);
            contPasseggeri.TabIndex = 2;
            // 
            // ViewVagoni
            // 
            ViewVagoni.AllowUserToAddRows = false;
            ViewVagoni.AllowUserToDeleteRows = false;
            ViewVagoni.AllowUserToResizeColumns = false;
            ViewVagoni.AllowUserToResizeRows = false;
            ViewVagoni.ColumnHeadersHeight = 29;
            ViewVagoni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ViewVagoni.Columns.AddRange(new DataGridViewColumn[] { Vagoni, Passeggeri });
            ViewVagoni.Location = new Point(483, 238);
            ViewVagoni.Margin = new Padding(3, 2, 3, 2);
            ViewVagoni.MultiSelect = false;
            ViewVagoni.Name = "ViewVagoni";
            ViewVagoni.ReadOnly = true;
            ViewVagoni.RowHeadersWidth = 51;
            ViewVagoni.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ViewVagoni.Size = new Size(304, 201);
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
            scendiBottone.Location = new Point(386, 387);
            scendiBottone.Margin = new Padding(3, 2, 3, 2);
            scendiBottone.Name = "scendiBottone";
            scendiBottone.Size = new Size(82, 22);
            scendiBottone.TabIndex = 3;
            scendiBottone.Text = "Fai scendere";
            scendiBottone.UseVisualStyleBackColor = true;
            scendiBottone.Click += scendiBottone_Click;
            // 
            // ElimBiglietto
            // 
            ElimBiglietto.Location = new Point(32, 90);
            ElimBiglietto.Name = "ElimBiglietto";
            ElimBiglietto.Size = new Size(127, 27);
            ElimBiglietto.TabIndex = 4;
            ElimBiglietto.Text = "Elimina Biglietto";
            ElimBiglietto.UseVisualStyleBackColor = true;
            ElimBiglietto.Click += ElimBiglietto_Click;
            // 
            // SpostaUtente
            // 
            SpostaUtente.Location = new Point(32, 123);
            SpostaUtente.Name = "SpostaUtente";
            SpostaUtente.Size = new Size(127, 25);
            SpostaUtente.TabIndex = 5;
            SpostaUtente.Text = "Spostati nel vagone";
            SpostaUtente.UseVisualStyleBackColor = true;
            SpostaUtente.Click += SpostaUtente_Click;
            // 
            // ListaDropVagoni
            // 
            ListaDropVagoni.DropDownStyle = ComboBoxStyle.DropDownList;
            ListaDropVagoni.FormattingEnabled = true;
            ListaDropVagoni.Location = new Point(165, 125);
            ListaDropVagoni.Name = "ListaDropVagoni";
            ListaDropVagoni.Size = new Size(121, 23);
            ListaDropVagoni.TabIndex = 6;
            // 
            // collegaWifi
            // 
            collegaWifi.Location = new Point(32, 154);
            collegaWifi.Name = "collegaWifi";
            collegaWifi.Size = new Size(127, 27);
            collegaWifi.TabIndex = 7;
            collegaWifi.Text = "Collega WiFi";
            collegaWifi.UseVisualStyleBackColor = true;
            collegaWifi.Click += collegaWifi_Click;
            // 
            // togliVagone
            // 
            togliVagone.Location = new Point(345, 263);
            togliVagone.Name = "togliVagone";
            togliVagone.Size = new Size(121, 24);
            togliVagone.TabIndex = 8;
            togliVagone.Text = "Rimuovi Vagone";
            togliVagone.UseVisualStyleBackColor = true;
            togliVagone.Click += togliVagone_Click;
            // 
            // ListaVagoniRim
            // 
            ListaVagoniRim.DropDownStyle = ComboBoxStyle.DropDownList;
            ListaVagoniRim.FormattingEnabled = true;
            ListaVagoniRim.Location = new Point(221, 263);
            ListaVagoniRim.Name = "ListaVagoniRim";
            ListaVagoniRim.Size = new Size(121, 23);
            ListaVagoniRim.TabIndex = 9;
            // 
            // mettiVagone
            // 
            mettiVagone.Location = new Point(345, 331);
            mettiVagone.Name = "mettiVagone";
            mettiVagone.Size = new Size(121, 25);
            mettiVagone.TabIndex = 10;
            mettiVagone.Text = "Aggiungi Vagone";
            mettiVagone.UseVisualStyleBackColor = true;
            mettiVagone.Click += mettiVagone_Click;
            // 
            // indexVagone
            // 
            indexVagone.Location = new Point(424, 304);
            indexVagone.Margin = new Padding(3, 2, 3, 2);
            indexVagone.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            indexVagone.Name = "indexVagone";
            indexVagone.Size = new Size(42, 23);
            indexVagone.TabIndex = 11;
            // 
            // tipiVagone
            // 
            tipiVagone.DropDownStyle = ComboBoxStyle.DropDownList;
            tipiVagone.FormattingEnabled = true;
            tipiVagone.Location = new Point(297, 303);
            tipiVagone.Name = "tipiVagone";
            tipiVagone.Size = new Size(121, 23);
            tipiVagone.TabIndex = 12;
            // 
            // PresaBtn
            // 
            PresaBtn.Location = new Point(35, 186);
            PresaBtn.Margin = new Padding(3, 2, 3, 2);
            PresaBtn.Name = "PresaBtn";
            PresaBtn.Size = new Size(124, 25);
            PresaBtn.TabIndex = 13;
            PresaBtn.Text = "Attacco presa";
            PresaBtn.UseVisualStyleBackColor = true;
            PresaBtn.Click += PresaBtn_Click;
            // 
            // Carica
            // 
            Carica.Anchor = AnchorStyles.None;
            Carica.Image = (Image)resources.GetObject("Carica.Image");
            Carica.Location = new Point(308, 24);
            Carica.Margin = new Padding(3, 2, 3, 2);
            Carica.Name = "Carica";
            Carica.Size = new Size(171, 187);
            Carica.TabIndex = 14;
            Carica.TabStop = false;
            // 
            // nPostiCounter
            // 
            nPostiCounter.Location = new Point(297, 331);
            nPostiCounter.Margin = new Padding(3, 2, 3, 2);
            nPostiCounter.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nPostiCounter.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            nPostiCounter.Name = "nPostiCounter";
            nPostiCounter.Size = new Size(42, 23);
            nPostiCounter.TabIndex = 13;
            nPostiCounter.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // spostaTanti
            // 
            spostaTanti.Location = new Point(170, 386);
            spostaTanti.Name = "spostaTanti";
            spostaTanti.Size = new Size(121, 23);
            spostaTanti.TabIndex = 14;
            spostaTanti.Text = "Sposta";
            spostaTanti.UseVisualStyleBackColor = true;
            spostaTanti.Click += spostaTanti_Click;
            // 
            // ListaVagoniAtt
            // 
            ListaVagoniAtt.DropDownStyle = ComboBoxStyle.DropDownList;
            ListaVagoniAtt.FormattingEnabled = true;
            ListaVagoniAtt.Location = new Point(210, 413);
            ListaVagoniAtt.Name = "ListaVagoniAtt";
            ListaVagoniAtt.Size = new Size(81, 23);
            ListaVagoniAtt.TabIndex = 15;
            // 
            // nSpostati
            // 
            nSpostati.Location = new Point(257, 412);
            nSpostati.Margin = new Padding(3, 2, 3, 2);
            nSpostati.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nSpostati.Name = "nSpostati";
            nSpostati.Size = new Size(34, 23);
            nSpostati.TabIndex = 16;
            // 
            // Gestore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Carica);
            Controls.Add(PresaBtn);
            Controls.Add(nSpostati);
            Controls.Add(ListaVagoniAtt);
            Controls.Add(spostaTanti);
            Controls.Add(nPostiCounter);
            Controls.Add(tipiVagone);
            Controls.Add(indexVagone);
            Controls.Add(mettiVagone);
            Controls.Add(ListaVagoniRim);
            Controls.Add(togliVagone);
            Controls.Add(collegaWifi);
            Controls.Add(ListaDropVagoni);
            Controls.Add(SpostaUtente);
            Controls.Add(ElimBiglietto);
            Controls.Add(scendiBottone);
            Controls.Add(contPasseggeri);
            Controls.Add(bottoneSali);
            Controls.Add(ViewVagoni);
            Controls.Add(CreaBigl);
            Controls.Add(MostraBigl);
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
        private ComboBox ListaDropVagoni;
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
    }
}