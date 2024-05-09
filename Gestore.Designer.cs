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
            ViewVagoni = new DataGridView();
            Vagoni = new DataGridViewButtonColumn();
            Passeggeri = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ViewVagoni).BeginInit();
            SuspendLayout();
            // 
            // MostraBigl
            // 
            MostraBigl.Location = new Point(36, 93);
            MostraBigl.Name = "MostraBigl";
            MostraBigl.Size = new Size(145, 29);
            MostraBigl.TabIndex = 0;
            MostraBigl.Text = "Mostra Biglietto";
            MostraBigl.UseVisualStyleBackColor = true;
            MostraBigl.Click += MostraBigl_Click;
            // 
            // CreaBigl
            // 
            CreaBigl.Location = new Point(36, 36);
            CreaBigl.Name = "CreaBigl";
            CreaBigl.Size = new Size(145, 29);
            CreaBigl.TabIndex = 0;
            CreaBigl.Text = "Crea Biglietto";
            CreaBigl.Click += CreaBigl_Click;
            // 
            // ViewVagoni
            // 
            ViewVagoni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewVagoni.Columns.AddRange(new DataGridViewColumn[] { Vagoni, Passeggeri });
            ViewVagoni.Location = new Point(45, 342);
            ViewVagoni.Name = "ViewVagoni";
            ViewVagoni.RowHeadersWidth = 51;
            ViewVagoni.Size = new Size(300, 188);
            ViewVagoni.TabIndex = 2;
            // 
            // Vagoni
            // 
            Vagoni.HeaderText = "Vagoni";
            Vagoni.MinimumWidth = 6;
            Vagoni.Name = "Vagoni";
            Vagoni.Width = 125;
            // 
            // Passeggeri
            // 
            Passeggeri.HeaderText = "Passeggeri";
            Passeggeri.MinimumWidth = 6;
            Passeggeri.Name = "Passeggeri";
            Passeggeri.Width = 125;
            // 
            // Gestore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(ViewVagoni);
            Controls.Add(CreaBigl);
            Controls.Add(MostraBigl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Gestore";
            Text = "Gestore";
            Load += Gestore_Load;
            ((System.ComponentModel.ISupportInitialize)ViewVagoni).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button MostraBigl;
        private Button CreaBigl;
        private DataGridView ViewVagoni;
        private DataGridViewButtonColumn Vagoni;
        private DataGridViewTextBoxColumn Passeggeri;
    }
}