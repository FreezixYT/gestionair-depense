namespace gestionair_depenses
{
    partial class frmMain
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
            btnStats = new Button();
            btnAdd = new Button();
            btnsettings = new Button();
            lblRest = new Label();
            label1 = new Label();
            menuStrip2 = new MenuStrip();
            statistiqueToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem = new ToolStripMenuItem();
            parametresToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // btnStats
            // 
            btnStats.Location = new Point(113, 353);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(105, 32);
            btnStats.TabIndex = 1;
            btnStats.Text = "Stats";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(346, 353);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 32);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnsettings
            // 
            btnsettings.Location = new Point(551, 353);
            btnsettings.Name = "btnsettings";
            btnsettings.Size = new Size(105, 32);
            btnsettings.TabIndex = 3;
            btnsettings.Text = "Settings";
            btnsettings.UseVisualStyleBackColor = true;
            btnsettings.Click += btnsettings_Click;
            // 
            // lblRest
            // 
            lblRest.AutoSize = true;
            lblRest.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRest.Location = new Point(284, 84);
            lblRest.Name = "lblRest";
            lblRest.Size = new Size(237, 45);
            lblRest.TabIndex = 4;
            lblRest.Text = "Argent restant";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(355, 176);
            label1.Name = "label1";
            label1.Size = new Size(84, 65);
            label1.TabIndex = 5;
            label1.Text = "35";
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = SystemColors.ControlDark;
            menuStrip2.Items.AddRange(new ToolStripItem[] { statistiqueToolStripMenuItem, ajouterToolStripMenuItem, parametresToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 6;
            menuStrip2.Text = "menuStrip2";
            // 
            // statistiqueToolStripMenuItem
            // 
            statistiqueToolStripMenuItem.Name = "statistiqueToolStripMenuItem";
            statistiqueToolStripMenuItem.Size = new Size(74, 20);
            statistiqueToolStripMenuItem.Text = "Statistique";
            statistiqueToolStripMenuItem.Click += statistiqueToolStripMenuItem_Click;
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new Size(58, 20);
            ajouterToolStripMenuItem.Text = "Ajouter";
            ajouterToolStripMenuItem.Click += ajouterToolStripMenuItem_Click;
            // 
            // parametresToolStripMenuItem
            // 
            parametresToolStripMenuItem.Name = "parametresToolStripMenuItem";
            parametresToolStripMenuItem.Size = new Size(78, 20);
            parametresToolStripMenuItem.Text = "Parametres";
            parametresToolStripMenuItem.Click += parametresToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblRest);
            Controls.Add(btnsettings);
            Controls.Add(btnAdd);
            Controls.Add(btnStats);
            Controls.Add(menuStrip2);
            Name = "frmMain";
            Text = "HOME";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnStats;
        private Button btnAdd;
        private Button btnsettings;
        private Label lblRest;
        private Label label1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem statistiqueToolStripMenuItem;
        private ToolStripMenuItem ajouterToolStripMenuItem;
        private ToolStripMenuItem parametresToolStripMenuItem;
    }
}
