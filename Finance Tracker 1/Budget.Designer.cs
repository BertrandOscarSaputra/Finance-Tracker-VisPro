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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.Label();
            this.dateEndBudget = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Location = new System.Drawing.Point(336, 458);
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
            this.buttonSetBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSetBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetBudget.Location = new System.Drawing.Point(142, 458);
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
            this.label6.Location = new System.Drawing.Point(540, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Description";
            // 
            // richDesc1
            // 
            this.richDesc1.Location = new System.Drawing.Point(544, 144);
            this.richDesc1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richDesc1.Name = "richDesc1";
            this.richDesc1.Size = new System.Drawing.Size(285, 102);
            this.richDesc1.TabIndex = 37;
            this.richDesc1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Start_Date";
            // 
            // dateStartBudget
            // 
            this.dateStartBudget.Location = new System.Drawing.Point(138, 220);
            this.dateStartBudget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateStartBudget.Name = "dateStartBudget";
            this.dateStartBudget.Size = new System.Drawing.Size(224, 26);
            this.dateStartBudget.TabIndex = 34;
            this.dateStartBudget.ValueChanged += new System.EventHandler(this.dateStartBudget_ValueChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(138, 130);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(224, 26);
            this.txtAmount.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 373);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 26);
            this.textBox1.TabIndex = 42;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCategory
            // 
            this.txtCategory.AutoSize = true;
            this.txtCategory.Location = new System.Drawing.Point(138, 339);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(73, 20);
            this.txtCategory.TabIndex = 43;
            this.txtCategory.Text = "Category";
            // 
            // dateEndBudget
            // 
            this.dateEndBudget.Location = new System.Drawing.Point(142, 295);
            this.dateEndBudget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateEndBudget.Name = "dateEndBudget";
            this.dateEndBudget.Size = new System.Drawing.Size(224, 26);
            this.dateEndBudget.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "End_Date";
            // 
            // Budget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateEndBudget);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtCategory;
        private System.Windows.Forms.DateTimePicker dateEndBudget;
        private System.Windows.Forms.Label label3;
    }
}