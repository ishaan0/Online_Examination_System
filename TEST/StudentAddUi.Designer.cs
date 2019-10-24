namespace TEST
{
    partial class StudentAddUi
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
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_student_id = new System.Windows.Forms.Label();
            this.listView_student_info = new System.Windows.Forms.ListView();
            this.columnHeader_student_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_student_password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_student_info = new System.Windows.Forms.Label();
            this.button_student_refresh = new System.Windows.Forms.Button();
            this.button_student_remove = new System.Windows.Forms.Button();
            this.button_student_add = new System.Windows.Forms.Button();
            this.textBox_student_id = new System.Windows.Forms.TextBox();
            this.label_student_remaining = new System.Windows.Forms.Label();
            this.button_finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(241, 121);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(396, 31);
            this.textBox_password.TabIndex = 1;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(28, 127);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(114, 25);
            this.label_password.TabIndex = 35;
            this.label_password.Text = "Password";
            // 
            // label_student_id
            // 
            this.label_student_id.AutoSize = true;
            this.label_student_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_student_id.ForeColor = System.Drawing.Color.White;
            this.label_student_id.Location = new System.Drawing.Point(28, 46);
            this.label_student_id.Name = "label_student_id";
            this.label_student_id.Size = new System.Drawing.Size(119, 25);
            this.label_student_id.TabIndex = 34;
            this.label_student_id.Text = "Student Id";
            // 
            // listView_student_info
            // 
            this.listView_student_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_student_id,
            this.columnHeader_student_password});
            this.listView_student_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_student_info.FullRowSelect = true;
            this.listView_student_info.GridLines = true;
            this.listView_student_info.Location = new System.Drawing.Point(33, 222);
            this.listView_student_info.Name = "listView_student_info";
            this.listView_student_info.Size = new System.Drawing.Size(604, 257);
            this.listView_student_info.TabIndex = 33;
            this.listView_student_info.UseCompatibleStateImageBehavior = false;
            this.listView_student_info.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_student_id
            // 
            this.columnHeader_student_id.Text = "             Student Id";
            this.columnHeader_student_id.Width = 339;
            // 
            // columnHeader_student_password
            // 
            this.columnHeader_student_password.Text = "Password";
            this.columnHeader_student_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_student_password.Width = 261;
            // 
            // label_student_info
            // 
            this.label_student_info.AutoSize = true;
            this.label_student_info.BackColor = System.Drawing.Color.White;
            this.label_student_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_student_info.Location = new System.Drawing.Point(265, 177);
            this.label_student_info.Name = "label_student_info";
            this.label_student_info.Size = new System.Drawing.Size(159, 29);
            this.label_student_info.TabIndex = 32;
            this.label_student_info.Text = "Student  Info";
            // 
            // button_student_refresh
            // 
            this.button_student_refresh.BackColor = System.Drawing.Color.Chocolate;
            this.button_student_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_student_refresh.Location = new System.Drawing.Point(663, 389);
            this.button_student_refresh.Name = "button_student_refresh";
            this.button_student_refresh.Size = new System.Drawing.Size(102, 68);
            this.button_student_refresh.TabIndex = 4;
            this.button_student_refresh.Text = "Refresh";
            this.button_student_refresh.UseVisualStyleBackColor = false;
            this.button_student_refresh.Click += new System.EventHandler(this.button_student_refresh_Click);
            // 
            // button_student_remove
            // 
            this.button_student_remove.BackColor = System.Drawing.Color.Red;
            this.button_student_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_student_remove.Location = new System.Drawing.Point(663, 263);
            this.button_student_remove.Name = "button_student_remove";
            this.button_student_remove.Size = new System.Drawing.Size(102, 68);
            this.button_student_remove.TabIndex = 3;
            this.button_student_remove.Text = "Remove";
            this.button_student_remove.UseVisualStyleBackColor = false;
            this.button_student_remove.Click += new System.EventHandler(this.button_student_remove_Click);
            // 
            // button_student_add
            // 
            this.button_student_add.BackColor = System.Drawing.Color.LimeGreen;
            this.button_student_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_student_add.ForeColor = System.Drawing.Color.Black;
            this.button_student_add.Location = new System.Drawing.Point(663, 46);
            this.button_student_add.Name = "button_student_add";
            this.button_student_add.Size = new System.Drawing.Size(102, 44);
            this.button_student_add.TabIndex = 2;
            this.button_student_add.Text = "ADD";
            this.button_student_add.UseVisualStyleBackColor = false;
            this.button_student_add.Click += new System.EventHandler(this.button_student_add_Click);
            // 
            // textBox_student_id
            // 
            this.textBox_student_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_student_id.Location = new System.Drawing.Point(241, 46);
            this.textBox_student_id.Name = "textBox_student_id";
            this.textBox_student_id.Size = new System.Drawing.Size(396, 31);
            this.textBox_student_id.TabIndex = 0;
            // 
            // label_student_remaining
            // 
            this.label_student_remaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_student_remaining.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_student_remaining.Location = new System.Drawing.Point(33, 13);
            this.label_student_remaining.Name = "label_student_remaining";
            this.label_student_remaining.Size = new System.Drawing.Size(732, 23);
            this.label_student_remaining.TabIndex = 37;
            this.label_student_remaining.Text = "50 Student data remaining";
            this.label_student_remaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_finish
            // 
            this.button_finish.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_finish.Enabled = false;
            this.button_finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_finish.Location = new System.Drawing.Point(663, 108);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(102, 44);
            this.button_finish.TabIndex = 5;
            this.button_finish.Text = "Finish";
            this.button_finish.UseVisualStyleBackColor = false;
            this.button_finish.Click += new System.EventHandler(this.button_finish_Click);
            // 
            // StudentAddUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(792, 499);
            this.Controls.Add(this.button_finish);
            this.Controls.Add(this.label_student_remaining);
            this.Controls.Add(this.textBox_student_id);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_student_id);
            this.Controls.Add(this.listView_student_info);
            this.Controls.Add(this.label_student_info);
            this.Controls.Add(this.button_student_refresh);
            this.Controls.Add(this.button_student_remove);
            this.Controls.Add(this.button_student_add);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentAddUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentAddUi";
            this.Load += new System.EventHandler(this.StudentAddUi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_student_id;
        private System.Windows.Forms.ListView listView_student_info;
        private System.Windows.Forms.ColumnHeader columnHeader_student_id;
        private System.Windows.Forms.Label label_student_info;
        private System.Windows.Forms.Button button_student_refresh;
        private System.Windows.Forms.Button button_student_remove;
        private System.Windows.Forms.Button button_student_add;
        private System.Windows.Forms.TextBox textBox_student_id;
        private System.Windows.Forms.ColumnHeader columnHeader_student_password;
        private System.Windows.Forms.Label label_student_remaining;
        private System.Windows.Forms.Button button_finish;
    }
}