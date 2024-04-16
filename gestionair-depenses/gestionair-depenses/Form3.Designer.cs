namespace gestionair_depenses
{
    partial class frmAdd
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
            tbxMontant = new TextBox();
            tbxNom = new TextBox();
            dtpDate = new DateTimePicker();
            lblRest = new Label();
            lblMontant = new Label();
            label1 = new Label();
            lblCategorie = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            btnSend = new Button();
            tbxDescription = new TextBox();
            label2 = new Label();
            cbbCategorie = new ComboBox();
            cbbPersonnes = new ComboBox();
            SuspendLayout();
            // 
            // tbxMontant
            // 
            tbxMontant.Location = new Point(411, 121);
            tbxMontant.Name = "tbxMontant";
            tbxMontant.Size = new Size(121, 23);
            tbxMontant.TabIndex = 0;
            tbxMontant.TextChanged += tbxMontant_TextChanged;
            // 
            // tbxNom
            // 
            tbxNom.Location = new Point(411, 162);
            tbxNom.Name = "tbxNom";
            tbxNom.Size = new Size(121, 23);
            tbxNom.TabIndex = 1;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(291, 324);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(241, 23);
            dtpDate.TabIndex = 3;
            // 
            // lblRest
            // 
            lblRest.AutoSize = true;
            lblRest.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRest.Location = new Point(245, 40);
            lblRest.Name = "lblRest";
            lblRest.Size = new Size(330, 45);
            lblRest.TabIndex = 5;
            lblRest.Text = "Ajouter une dépense";
            // 
            // lblMontant
            // 
            lblMontant.AutoSize = true;
            lblMontant.BackColor = Color.Transparent;
            lblMontant.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMontant.Location = new Point(291, 121);
            lblMontant.Name = "lblMontant";
            lblMontant.Size = new Size(84, 25);
            lblMontant.TabIndex = 6;
            lblMontant.Text = "Montant";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 157);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 7;
            label1.Text = "Nom";
            // 
            // lblCategorie
            // 
            lblCategorie.AutoSize = true;
            lblCategorie.BackColor = Color.Transparent;
            lblCategorie.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategorie.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblCategorie.Location = new Point(291, 237);
            lblCategorie.Name = "lblCategorie";
            lblCategorie.Size = new Size(94, 25);
            lblCategorie.TabIndex = 12;
            lblCategorie.Text = "Catégorie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(291, 281);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 13;
            label3.Text = "Personne";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(291, 365);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(241, 54);
            btnSend.TabIndex = 15;
            btnSend.Text = "Ajouter";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // tbxDescription
            // 
            tbxDescription.Location = new Point(411, 200);
            tbxDescription.Multiline = true;
            tbxDescription.Name = "tbxDescription";
            tbxDescription.Size = new Size(121, 23);
            tbxDescription.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(291, 195);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 16;
            label2.Text = "Description";
            // 
            // cbbCategorie
            // 
            cbbCategorie.FormattingEnabled = true;
            cbbCategorie.Location = new Point(411, 242);
            cbbCategorie.Name = "cbbCategorie";
            cbbCategorie.Size = new Size(121, 23);
            cbbCategorie.TabIndex = 18;
            // 
            // cbbPersonnes
            // 
            cbbPersonnes.FormattingEnabled = true;
            cbbPersonnes.Location = new Point(411, 286);
            cbbPersonnes.Name = "cbbPersonnes";
            cbbPersonnes.Size = new Size(121, 23);
            cbbPersonnes.TabIndex = 19;
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbbPersonnes);
            Controls.Add(cbbCategorie);
            Controls.Add(tbxDescription);
            Controls.Add(label2);
            Controls.Add(btnSend);
            Controls.Add(label3);
            Controls.Add(lblCategorie);
            Controls.Add(label1);
            Controls.Add(lblMontant);
            Controls.Add(lblRest);
            Controls.Add(dtpDate);
            Controls.Add(tbxNom);
            Controls.Add(tbxMontant);
            Name = "frmAdd";
            Text = "Ajouter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxMontant;
        private TextBox tbxNom;
        private DateTimePicker dtpDate;
        private Label lblRest;
        private Label lblMontant;
        private Label label1;
        private Label lblCategorie;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private Button btnSend;
        private TextBox tbxDescription;
        private Label label2;
        private ComboBox cbbCategorie;
        private ComboBox cbbPersonnes;
    }
}