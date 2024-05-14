namespace StudentInfoApplication
{
    partial class Form1
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
            txtStudentID = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            lbStudentID = new ListBox();
            lbFirstName = new ListBox();
            lbLastName = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(33, 91);
            txtStudentID.Margin = new Padding(3, 4, 3, 4);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(209, 27);
            txtStudentID.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(325, 91);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(214, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(626, 91);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(226, 27);
            txtFirstName.TabIndex = 2;
            txtFirstName.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 40);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 3;
            label1.Text = "Student ID *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(365, 40);
            label2.Name = "label2";
            label2.Size = new Size(136, 32);
            label2.TabIndex = 4;
            label2.Text = "Last Name*";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(673, 40);
            label3.Name = "label3";
            label3.Size = new Size(146, 32);
            label3.TabIndex = 5;
            label3.Text = "First Name *";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(687, 144);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(112, 41);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbStudentID
            // 
            lbStudentID.FormattingEnabled = true;
            lbStudentID.ItemHeight = 20;
            lbStudentID.Location = new Point(33, 265);
            lbStudentID.Margin = new Padding(3, 4, 3, 4);
            lbStudentID.Name = "lbStudentID";
            lbStudentID.Size = new Size(209, 304);
            lbStudentID.TabIndex = 7;
            // 
            // lbFirstName
            // 
            lbFirstName.FormattingEnabled = true;
            lbFirstName.ItemHeight = 20;
            lbFirstName.Location = new Point(325, 265);
            lbFirstName.Margin = new Padding(3, 4, 3, 4);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(209, 304);
            lbFirstName.TabIndex = 8;
            // 
            // lbLastName
            // 
            lbLastName.FormattingEnabled = true;
            lbLastName.ItemHeight = 20;
            lbLastName.Location = new Point(643, 265);
            lbLastName.Margin = new Padding(3, 4, 3, 4);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(209, 304);
            lbLastName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 215);
            label4.Name = "label4";
            label4.Size = new Size(186, 32);
            label4.TabIndex = 10;
            label4.Text = "Student ID List *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(656, 215);
            label5.Name = "label5";
            label5.Size = new Size(185, 32);
            label5.TabIndex = 11;
            label5.Text = "Last Name List *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(351, 215);
            label6.Name = "label6";
            label6.Size = new Size(188, 32);
            label6.TabIndex = 12;
            label6.Text = "First Name List *";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbLastName);
            Controls.Add(lbFirstName);
            Controls.Add(lbStudentID);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Student Info";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentID;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ListBox lbStudentID;
        private ListBox lbFirstName;
        private ListBox lbLastName;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}