namespace Finance_Tracker_1
{
    partial class Budget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Budget));
            this.labeladdtransaction = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSetBudget = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.richDesc1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateStartBudget = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.Label();
            this.dateEndBudget = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labeladdtransaction
            // 
            this.labeladdtransaction.AutoSize = true;
            this.labeladdtransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladdtransaction.Location = new System.Drawing.Point(335, 41);
            this.labeladdtransaction.Name = "labeladdtransaction";
            this.labeladdtransaction.Size = new System.Drawing.Size(217, 46);
            this.labeladdtransaction.TabIndex = 29;
            this.labeladdtransaction.Text = "Set Budget";
            this.labeladdtransaction.Click += new System.EventHandler(this.labeladdtransaction_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.IndianRed;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBack.Location = new System.Drawing.Point(343, 442);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(91, 49);
            this.buttonBack.TabIndex = 41;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSetBudget
            // 
            this.buttonSetBudget.BackColor = System.Drawing.Color.Lime;
            this.buttonSetBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetBudget.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSetBudget.Location = new System.Drawing.Point(139, 442);
            this.buttonSetBudget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSetBudget.Name = "buttonSetBudget";
            this.buttonSetBudget.Size = new System.Drawing.Size(91, 49);
            this.buttonSetBudget.TabIndex = 40;
            this.buttonSetBudget.Text = "Set";
            this.buttonSetBudget.UseVisualStyleBackColor = false;
            this.buttonSetBudget.Click += new System.EventHandler(this.buttonSetBudget_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Description";
            // 
            // richDesc1
            // 
            this.richDesc1.Location = new System.Drawing.Point(555, 293);
            this.richDesc1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richDesc1.Name = "richDesc1";
            this.richDesc1.Size = new System.Drawing.Size(285, 102);
            this.richDesc1.TabIndex = 37;
            this.richDesc1.Text = "";
            this.richDesc1.TextChanged += new System.EventHandler(this.richDesc1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Start_Date";
            // 
            // dateStartBudget
            // 
            this.dateStartBudget.Location = new System.Drawing.Point(555, 208);
            this.dateStartBudget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateStartBudget.Name = "dateStartBudget";
            this.dateStartBudget.Size = new System.Drawing.Size(273, 26);
            this.dateStartBudget.TabIndex = 34;
            this.dateStartBudget.ValueChanged += new System.EventHandler(this.dateStartBudget_ValueChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(139, 379);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(224, 26);
            this.txtAmount.TabIndex = 33;
            // 
            // txtCategory
            // 
            this.txtCategory.AutoSize = true;
            this.txtCategory.Location = new System.Drawing.Point(135, 255);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(73, 20);
            this.txtCategory.TabIndex = 43;
            this.txtCategory.Text = "Category";
            // 
            // dateEndBudget
            // 
            this.dateEndBudget.Location = new System.Drawing.Point(555, 132);
            this.dateEndBudget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateEndBudget.Name = "dateEndBudget";
            this.dateEndBudget.Size = new System.Drawing.Size(273, 26);
            this.dateEndBudget.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "End_Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 134);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 26);
            this.txtName.TabIndex = 47;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Kredit Rumah",
            "Kredit Kendaraan",
            "Tabungan Pendidikan",
            "Tabungan Bulanan",
            "Pendidikan",
            "Belanja Rumah Tangga",
            "Transportasi",
            "Tagihan Listrik",
            "Tagihan Air",
            "Lainnya"});
            this.cbCategory.Location = new System.Drawing.Point(139, 293);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(224, 28);
            this.cbCategory.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Hutang",
            "Tabungan",
            "Konsumsi Rutin Bulanan"});
            this.cbType.Location = new System.Drawing.Point(139, 208);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(224, 28);
            this.cbType.TabIndex = 50;
            // 
            // Budget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.ControlBox = false;
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateEndBudget);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSetBudget);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richDesc1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateStartBudget);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.labeladdtransaction);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Budget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget";
            this.Load += new System.EventHandler(this.Budget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labeladdtransaction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSetBudget;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richDesc1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateStartBudget;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label txtCategory;
        private System.Windows.Forms.DateTimePicker dateEndBudget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbType;
    }
}