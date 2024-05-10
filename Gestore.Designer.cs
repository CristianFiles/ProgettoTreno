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
            MostraBigl = new Button();
            CreaBigl = new Button();
            bottoneSali = new Button();
            contPasseggeri = new NumericUpDown();
            ViewVagoni = new DataGridView();
            Vagoni = new DataGridViewButtonColumn();
            Passeggeri = new DataGridViewTextBoxColumn();
            scendiBottone = new Button();
            ((System.ComponentModel.ISupportInitialize)contPasseggeri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewVagoni).BeginInit();
            SuspendLayout();
            // 
            // MostraBigl
            // 
            MostraBigl.Location = new Point(32, 70);
            MostraBigl.Margin = new Padding(3, 2, 3, 2);
            MostraBigl.Name = "MostraBigl";
            MostraBigl.Size = new Size(127, 22);
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
            CreaBigl.Size = new Size(127, 22);
            CreaBigl.TabIndex = 0;
            CreaBigl.Text = "Crea Biglietto";
            CreaBigl.Click += CreaBigl_Click;
            // 
            // bottoneSali
            // 
            bottoneSali.Location = new Point(285, 34);
            bottoneSali.Margin = new Padding(3, 2, 3, 2);
            bottoneSali.Name = "bottoneSali";
            bottoneSali.Size = new Size(82, 22);
            bottoneSali.TabIndex = 1;
            bottoneSali.Text = "Sali";
            bottoneSali.UseVisualStyleBackColor = true;
            bottoneSali.Click += bottoneSali_Click;
            // 
            // contPasseggeri
            // 
            contPasseggeri.Location = new Point(285, 61);
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
            ViewVagoni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ViewVagoni.Columns.AddRange(new DataGridViewColumn[] { Vagoni, Passeggeri });
            ViewVagoni.Location = new Point(32, 217);
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
            scendiBottone.Location = new Point(373, 34);
            scendiBottone.Margin = new Padding(3, 2, 3, 2);
            scendiBottone.Name = "scendiBottone";
            scendiBottone.Size = new Size(82, 22);
            scendiBottone.TabIndex = 3;
            scendiBottone.Text = "Scendi";
            scendiBottone.UseVisualStyleBackColor = true;
            scendiBottone.Click += scendiBottone_Click;
            // 
            // Gestore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scendiBottone);
            Controls.Add(contPasseggeri);
            Controls.Add(bottoneSali);
            Controls.Add(ViewVagoni);
            Controls.Add(CreaBigl);
            Controls.Add(MostraBigl);
            Name = "Gestore";
            Text = "Gestore";
            Load += Gestore_Load;
            ((System.ComponentModel.ISupportInitialize)contPasseggeri).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewVagoni).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button MostraBigl;
        private Button CreaBigl;

        private Button bottoneSali;
        private NumericUpDown numericUpDown1;
        private NumericUpDown contPasseggeri;

        private DataGridView ViewVagoni;
        private DataGridViewButtonColumn Vagoni;
        private DataGridViewTextBoxColumn Passeggeri;
        private Button scendiBottone;
    }
}