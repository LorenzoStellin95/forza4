namespace connect4
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniziaLaPartitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNIZIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rINIZIALAPARTITAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSCIESALVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameGiocatore2 = new System.Windows.Forms.TextBox();
            this.usernameGiocatore1 = new System.Windows.Forms.TextBox();
            this.nomeGiocatore2 = new System.Windows.Forms.Label();
            this.nomeGiocatore1 = new System.Windows.Forms.Label();
            this.contatoreVittorie = new System.Windows.Forms.Label();
            this.avviso = new System.Windows.Forms.Label();
            this.coloreG1 = new System.Windows.Forms.PictureBox();
            this.coloreG2 = new System.Windows.Forms.PictureBox();
            this.colG1 = new System.Windows.Forms.Label();
            this.colG2 = new System.Windows.Forms.Label();
            this.temaLabel = new System.Windows.Forms.Label();
            this.temaBianco = new System.Windows.Forms.PictureBox();
            this.sfondoTemaBianco = new System.Windows.Forms.PictureBox();
            this.temaScuro = new System.Windows.Forms.PictureBox();
            this.sfondoTemaScuro = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coloreG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloreG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaBianco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfondoTemaBianco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaScuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfondoTemaScuro)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniziaLaPartitaToolStripMenuItem,
            this.eSCIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniziaLaPartitaToolStripMenuItem
            // 
            this.iniziaLaPartitaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNIZIAToolStripMenuItem,
            this.rINIZIALAPARTITAToolStripMenuItem});
            this.iniziaLaPartitaToolStripMenuItem.Name = "iniziaLaPartitaToolStripMenuItem";
            this.iniziaLaPartitaToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.iniziaLaPartitaToolStripMenuItem.Text = "Inizia la partita";
            // 
            // iNIZIAToolStripMenuItem
            // 
            this.iNIZIAToolStripMenuItem.Name = "iNIZIAToolStripMenuItem";
            this.iNIZIAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iNIZIAToolStripMenuItem.Text = "Inizia";
            this.iNIZIAToolStripMenuItem.Click += new System.EventHandler(this.iNIZIAToolStripMenuItem_Click);
            this.iNIZIAToolStripMenuItem.Paint += new System.Windows.Forms.PaintEventHandler(this.connect4_Paint);
            // 
            // rINIZIALAPARTITAToolStripMenuItem
            // 
            this.rINIZIALAPARTITAToolStripMenuItem.Name = "rINIZIALAPARTITAToolStripMenuItem";
            this.rINIZIALAPARTITAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rINIZIALAPARTITAToolStripMenuItem.Text = "Rinizia la partita";
            this.rINIZIALAPARTITAToolStripMenuItem.Click += new System.EventHandler(this.rINIZIALAPARTITAToolStripMenuItem_Click);
            this.rINIZIALAPARTITAToolStripMenuItem.Paint += new System.Windows.Forms.PaintEventHandler(this.connect4_Paint);
            // 
            // eSCIToolStripMenuItem
            // 
            this.eSCIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eSCIESALVAToolStripMenuItem});
            this.eSCIToolStripMenuItem.Name = "eSCIToolStripMenuItem";
            this.eSCIToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.eSCIToolStripMenuItem.Text = "Esci";
            // 
            // eSCIESALVAToolStripMenuItem
            // 
            this.eSCIESALVAToolStripMenuItem.Name = "eSCIESALVAToolStripMenuItem";
            this.eSCIESALVAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eSCIESALVAToolStripMenuItem.Text = "Esci e salva";
            this.eSCIESALVAToolStripMenuItem.Click += new System.EventHandler(this.eSCIESALVAToolStripMenuItem_Click);
            // 
            // usernameGiocatore2
            // 
            this.usernameGiocatore2.Location = new System.Drawing.Point(178, 453);
            this.usernameGiocatore2.Margin = new System.Windows.Forms.Padding(2);
            this.usernameGiocatore2.MaxLength = 12;
            this.usernameGiocatore2.Name = "usernameGiocatore2";
            this.usernameGiocatore2.Size = new System.Drawing.Size(111, 20);
            this.usernameGiocatore2.TabIndex = 3;
            // 
            // usernameGiocatore1
            // 
            this.usernameGiocatore1.Location = new System.Drawing.Point(178, 421);
            this.usernameGiocatore1.Margin = new System.Windows.Forms.Padding(2);
            this.usernameGiocatore1.MaxLength = 12;
            this.usernameGiocatore1.Name = "usernameGiocatore1";
            this.usernameGiocatore1.Size = new System.Drawing.Size(111, 20);
            this.usernameGiocatore1.TabIndex = 0;
            // 
            // nomeGiocatore2
            // 
            this.nomeGiocatore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeGiocatore2.ForeColor = System.Drawing.Color.Black;
            this.nomeGiocatore2.Location = new System.Drawing.Point(12, 447);
            this.nomeGiocatore2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomeGiocatore2.Name = "nomeGiocatore2";
            this.nomeGiocatore2.Size = new System.Drawing.Size(161, 28);
            this.nomeGiocatore2.TabIndex = 5;
            this.nomeGiocatore2.Text = "Inserisci nome G2";
            // 
            // nomeGiocatore1
            // 
            this.nomeGiocatore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeGiocatore1.ForeColor = System.Drawing.Color.Black;
            this.nomeGiocatore1.Location = new System.Drawing.Point(15, 419);
            this.nomeGiocatore1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomeGiocatore1.Name = "nomeGiocatore1";
            this.nomeGiocatore1.Size = new System.Drawing.Size(158, 28);
            this.nomeGiocatore1.TabIndex = 1;
            this.nomeGiocatore1.Text = "Inserisci nome G1";
            // 
            // contatoreVittorie
            // 
            this.contatoreVittorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contatoreVittorie.ForeColor = System.Drawing.Color.Black;
            this.contatoreVittorie.Location = new System.Drawing.Point(46, 382);
            this.contatoreVittorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contatoreVittorie.Name = "contatoreVittorie";
            this.contatoreVittorie.Size = new System.Drawing.Size(326, 27);
            this.contatoreVittorie.TabIndex = 7;
            this.contatoreVittorie.Text = "label1";
            // 
            // avviso
            // 
            this.avviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avviso.ForeColor = System.Drawing.Color.Gray;
            this.avviso.Location = new System.Drawing.Point(308, 436);
            this.avviso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avviso.Name = "avviso";
            this.avviso.Size = new System.Drawing.Size(130, 28);
            this.avviso.TabIndex = 8;
            this.avviso.Text = "max 12 caratteri";
            // 
            // coloreG1
            // 
            this.coloreG1.BackColor = System.Drawing.Color.Red;
            this.coloreG1.Location = new System.Drawing.Point(554, 39);
            this.coloreG1.Name = "coloreG1";
            this.coloreG1.Size = new System.Drawing.Size(28, 28);
            this.coloreG1.TabIndex = 9;
            this.coloreG1.TabStop = false;
            // 
            // coloreG2
            // 
            this.coloreG2.BackColor = System.Drawing.Color.Yellow;
            this.coloreG2.Location = new System.Drawing.Point(554, 83);
            this.coloreG2.Name = "coloreG2";
            this.coloreG2.Size = new System.Drawing.Size(28, 28);
            this.coloreG2.TabIndex = 10;
            this.coloreG2.TabStop = false;
            // 
            // colG1
            // 
            this.colG1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colG1.ForeColor = System.Drawing.Color.Black;
            this.colG1.Location = new System.Drawing.Point(587, 39);
            this.colG1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.colG1.Name = "colG1";
            this.colG1.Size = new System.Drawing.Size(84, 28);
            this.colG1.TabIndex = 11;
            this.colG1.Text = "colore G1";
            // 
            // colG2
            // 
            this.colG2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colG2.ForeColor = System.Drawing.Color.Black;
            this.colG2.Location = new System.Drawing.Point(587, 83);
            this.colG2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.colG2.Name = "colG2";
            this.colG2.Size = new System.Drawing.Size(84, 28);
            this.colG2.TabIndex = 12;
            this.colG2.Text = "colore G2";
            // 
            // temaLabel
            // 
            this.temaLabel.BackColor = System.Drawing.Color.Transparent;
            this.temaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temaLabel.ForeColor = System.Drawing.Color.Black;
            this.temaLabel.Location = new System.Drawing.Point(610, 413);
            this.temaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.temaLabel.Name = "temaLabel";
            this.temaLabel.Size = new System.Drawing.Size(61, 23);
            this.temaLabel.TabIndex = 13;
            this.temaLabel.Text = "Tema";
            // 
            // temaBianco
            // 
            this.temaBianco.BackColor = System.Drawing.Color.White;
            this.temaBianco.Location = new System.Drawing.Point(590, 443);
            this.temaBianco.Name = "temaBianco";
            this.temaBianco.Size = new System.Drawing.Size(28, 28);
            this.temaBianco.TabIndex = 14;
            this.temaBianco.TabStop = false;
            this.temaBianco.Click += new System.EventHandler(this.temaBianco_Click);
            // 
            // sfondoTemaBianco
            // 
            this.sfondoTemaBianco.BackColor = System.Drawing.Color.Black;
            this.sfondoTemaBianco.Location = new System.Drawing.Point(586, 439);
            this.sfondoTemaBianco.Name = "sfondoTemaBianco";
            this.sfondoTemaBianco.Size = new System.Drawing.Size(37, 37);
            this.sfondoTemaBianco.TabIndex = 16;
            this.sfondoTemaBianco.TabStop = false;
            // 
            // temaScuro
            // 
            this.temaScuro.BackColor = System.Drawing.Color.Black;
            this.temaScuro.Location = new System.Drawing.Point(652, 443);
            this.temaScuro.Name = "temaScuro";
            this.temaScuro.Size = new System.Drawing.Size(28, 28);
            this.temaScuro.TabIndex = 17;
            this.temaScuro.TabStop = false;
            this.temaScuro.Click += new System.EventHandler(this.temaScuro_Click);
            // 
            // sfondoTemaScuro
            // 
            this.sfondoTemaScuro.BackColor = System.Drawing.Color.White;
            this.sfondoTemaScuro.Location = new System.Drawing.Point(648, 439);
            this.sfondoTemaScuro.Name = "sfondoTemaScuro";
            this.sfondoTemaScuro.Size = new System.Drawing.Size(37, 37);
            this.sfondoTemaScuro.TabIndex = 18;
            this.sfondoTemaScuro.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 483);
            this.Controls.Add(this.temaScuro);
            this.Controls.Add(this.sfondoTemaScuro);
            this.Controls.Add(this.temaBianco);
            this.Controls.Add(this.temaLabel);
            this.Controls.Add(this.colG2);
            this.Controls.Add(this.colG1);
            this.Controls.Add(this.coloreG2);
            this.Controls.Add(this.coloreG1);
            this.Controls.Add(this.avviso);
            this.Controls.Add(this.contatoreVittorie);
            this.Controls.Add(this.nomeGiocatore2);
            this.Controls.Add(this.usernameGiocatore2);
            this.Controls.Add(this.nomeGiocatore1);
            this.Controls.Add(this.usernameGiocatore1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.sfondoTemaBianco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(719, 522);
            this.Name = "Form1";
            this.Text = "connect4";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.connect4_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.connect4_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coloreG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloreG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaBianco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfondoTemaBianco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaScuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfondoTemaScuro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eSCIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSCIESALVAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniziaLaPartitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNIZIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rINIZIALAPARTITAToolStripMenuItem;
        private System.Windows.Forms.TextBox usernameGiocatore2;
        private System.Windows.Forms.TextBox usernameGiocatore1;
        private System.Windows.Forms.Label nomeGiocatore2;
        private System.Windows.Forms.Label nomeGiocatore1;
        private System.Windows.Forms.Label contatoreVittorie;
        private System.Windows.Forms.Label avviso;
        private System.Windows.Forms.PictureBox coloreG1;
        private System.Windows.Forms.PictureBox coloreG2;
        private System.Windows.Forms.Label colG1;
        private System.Windows.Forms.Label colG2;
        private System.Windows.Forms.Label temaLabel;
        private System.Windows.Forms.PictureBox temaBianco;
        private System.Windows.Forms.PictureBox sfondoTemaBianco;
        private System.Windows.Forms.PictureBox temaScuro;
        private System.Windows.Forms.PictureBox sfondoTemaScuro;
    }
}