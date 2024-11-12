namespace Finance_Tracker_1
{
    partial class AddTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransaction));
            this.labeladdtransaction = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.dateTransaction = new System.Windows.Forms.DateTimePicker();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richDesc = new System.Windows.Forms.RichTextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labeladdtransaction
            // 
            this.labeladdtransaction.AutoSize = true;
            this.labeladdtransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladdtransaction.Location = new System.Drawing.Point(290, 60);
            this.labeladdtransaction.Name = "labeladdtransaction";
            this.labeladdtransaction.Size = new System.Drawing.Size(334, 46);
            this.labeladdtransaction.TabIndex = 8;
            this.labeladdtransaction.Text = "+Add Transaction";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(122, 288);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(224, 26);
            this.txtType.TabIndex = 10;
            this.txtType.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTransaction
            // 
            this.dateTransaction.Location = new System.Drawing.Point(122, 192);
            this.dateTransaction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTransaction.Name = "dateTransaction";
            this.dateTransaction.Size = new System.Drawing.Size(224, 26);
            this.dateTransaction.TabIndex = 11;
            this.dateTransaction.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(122, 382);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(224, 26);
            this.txtCategory.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Transaction Type (income, expense)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Category";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // richDesc
            // 
            this.richDesc.Location = new System.Drawing.Point(504, 306);
            this.richDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richDesc.Name = "richDesc";
            this.richDesc.Size = new System.Drawing.Size(285, 102);
            this.richDesc.TabIndex = 18;
            this.richDesc.Text = "";
            this.richDesc.TextChanged += new System.EventHandler(this.richDesc_TextChanged_1);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(503, 192);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(224, 26);
            this.txtAmount.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Description";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 32);
            this.label7.TabIndex = 22;
            this.label7.Text = "Your Balance: ";
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnter.Location = new System.Drawing.Point(503, 489);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(91, 49);
            this.buttonEnter.TabIndex = 23;
            this.buttonEnter.Text = "Add";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Location = new System.Drawing.Point(698, 489);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(91, 49);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 601);
            this.ControlBox = false;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.dateTransaction);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.labeladdtransaction);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTransaction";
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeladdtransaction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.DateTimePicker dateTransaction;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richDesc;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonBack;
    }
}