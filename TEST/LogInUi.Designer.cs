namespace TEST
{
    partial class LogInUi
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
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_designation = new System.Windows.Forms.ComboBox();
            this.label_designation = new System.Windows.Forms.Label();
            this.button_logIn = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_username.Location = new System.Drawing.Point(34, 42);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(155, 24);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "USERNAME    :";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(33, 101);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(156, 24);
            this.label_password.TabIndex = 0;
            this.label_password.Text = "PASSWORD    :";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(219, 42);
            this.textBox_username.Multiline = true;
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(253, 24);
            this.textBox_username.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(219, 101);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(253, 24);
            this.textBox_password.TabIndex = 2;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.comboBox_designation);
            this.groupBox1.Controls.Add(this.label_username);
            this.groupBox1.Controls.Add(this.label_designation);
            this.groupBox1.Controls.Add(this.label_password);
            this.groupBox1.Controls.Add(this.button_logIn);
            this.groupBox1.Controls.Add(this.textBox_username);
            this.groupBox1.Controls.Add(this.button_Refresh);
            this.groupBox1.Controls.Add(this.textBox_password);
            this.groupBox1.Controls.Add(this.button_Cancel);
            this.groupBox1.Location = new System.Drawing.Point(286, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // comboBox_designation
            // 
            this.comboBox_designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_designation.FormattingEnabled = true;
            this.comboBox_designation.Items.AddRange(new object[] {
            "ADMIN",
            "TEACHER",
            "STUDENT"});
            this.comboBox_designation.Location = new System.Drawing.Point(219, 156);
            this.comboBox_designation.Name = "comboBox_designation";
            this.comboBox_designation.Size = new System.Drawing.Size(252, 28);
            this.comboBox_designation.TabIndex = 3;
            // 
            // label_designation
            // 
            this.label_designation.AutoSize = true;
            this.label_designation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_designation.Location = new System.Drawing.Point(33, 160);
            this.label_designation.Name = "label_designation";
            this.label_designation.Size = new System.Drawing.Size(155, 24);
            this.label_designation.TabIndex = 0;
            this.label_designation.Text = "DESIGNATION:";
            // 
            // button_logIn
            // 
            this.button_logIn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_logIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logIn.Image = global::TEST.Properties.Resources.Ok_icon;
            this.button_logIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_logIn.Location = new System.Drawing.Point(332, 225);
            this.button_logIn.Name = "button_logIn";
            this.button_logIn.Size = new System.Drawing.Size(122, 27);
            this.button_logIn.TabIndex = 4;
            this.button_logIn.Text = "LOG IN";
            this.button_logIn.UseVisualStyleBackColor = true;
            this.button_logIn.Click += new System.EventHandler(this.button_logIn_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Image = global::TEST.Properties.Resources.Actions_view_refresh_icon;
            this.button_Refresh.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_Refresh.Location = new System.Drawing.Point(183, 225);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(117, 27);
            this.button_Refresh.TabIndex = 5;
            this.button_Refresh.Text = "REFRESH";
            this.button_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.Image = global::TEST.Properties.Resources.delete_1_icon;
            this.button_Cancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_Cancel.Location = new System.Drawing.Point(38, 225);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(113, 27);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "CANCEL ";
            this.button_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::TEST.Properties.Resources.icon7;
            this.pictureBox1.Location = new System.Drawing.Point(34, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LogInUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(792, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogInUi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_logIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_designation;
        private System.Windows.Forms.Label label_designation;
    }
}

