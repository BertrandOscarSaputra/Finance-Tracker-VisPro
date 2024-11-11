namespace Finance_Tracker_1
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPasswordAdmin = new System.Windows.Forms.TextBox();
            this.lblPasswordAdmin = new System.Windows.Forms.Label();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.lblUserAdmin = new System.Windows.Forms.Label();
            this.txtUserAdmin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtPasswordAdmin
            // 
            this.txtPasswordAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPasswordAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordAdmin.Location = new System.Drawing.Point(289, 229);
            this.txtPasswordAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswordAdmin.Name = "txtPasswordAdmin";
            this.txtPasswordAdmin.PasswordChar = '*';
            this.txtPasswordAdmin.Size = new System.Drawing.Size(316, 26);
            this.txtPasswordAdmin.TabIndex = 5;
            this.txtPasswordAdmin.TextChanged += new System.EventHandler(this.txtPasswordAdmin_TextChanged);
            // 
            // lblPasswordAdmin
            // 
            this.lblPasswordAdmin.AutoSize = true;
            this.lblPasswordAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordAdmin.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPasswordAdmin.Location = new System.Drawing.Point(284, 173);
            this.lblPasswordAdmin.Name = "lblPasswordAdmin";
            this.lblPasswordAdmin.Size = new System.Drawing.Size(189, 29);
            this.lblPasswordAdmin.TabIndex = 6;
            this.lblPasswordAdmin.Text = "Enter Password:";
            this.lblPasswordAdmin.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLoginAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoginAdmin.Location = new System.Drawing.Point(289, 299);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(134, 54);
            this.btnLoginAdmin.TabIndex = 7;
            this.btnLoginAdmin.Text = "LogIn";
            this.btnLoginAdmin.UseVisualStyleBackColor = false;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // lblUserAdmin
            // 
            this.lblUserAdmin.AutoSize = true;
            this.lblUserAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.lblUserAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAdmin.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblUserAdmin.Location = new System.Drawing.Point(280, 47);
            this.lblUserAdmin.Name = "lblUserAdmin";
            this.lblUserAdmin.Size = new System.Drawing.Size(193, 29);
            this.lblUserAdmin.TabIndex = 8;
            this.lblUserAdmin.Text = "Enter Username:";
            // 
            // txtUserAdmin
            // 
            this.txtUserAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtUserAdmin.Location = new System.Drawing.Point(289, 95);
            this.txtUserAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserAdmin.Name = "txtUserAdmin";
            this.txtUserAdmin.Size = new System.Drawing.Size(316, 26);
            this.txtUserAdmin.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(473, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUserAdmin);
            this.Controls.Add(this.lblUserAdmin);
            this.Controls.Add(this.btnLoginAdmin);
            this.Controls.Add(this.lblPasswordAdmin);
            this.Controls.Add(this.txtPasswordAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPasswordAdmin;
        private System.Windows.Forms.Label lblPasswordAdmin;
        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.Label lblUserAdmin;
        private System.Windows.Forms.TextBox txtUserAdmin;
        private System.Windows.Forms.Button button1;
    }
}