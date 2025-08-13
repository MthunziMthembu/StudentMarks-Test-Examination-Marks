namespace Student_marks
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
            lblName = new Label();
            lblTest = new Label();
            lblAssignment = new Label();
            txtName = new TextBox();
            txtTest = new TextBox();
            txtAssignment = new TextBox();
            btnClick = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(419, 45);
            lblName.TabIndex = 0;
            lblName.Text = "ENTER YOUR NAME";
            lblName.Click += lblName_Click;
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Font = new Font("Modern No. 20", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTest.Location = new Point(0, 71);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(406, 41);
            lblTest.TabIndex = 1;
            lblTest.Text = "ENTER TEST MARK";
            // 
            // lblAssignment
            // 
            lblAssignment.AutoSize = true;
            lblAssignment.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAssignment.Location = new Point(0, 124);
            lblAssignment.Name = "lblAssignment";
            lblAssignment.Size = new Size(573, 45);
            lblAssignment.TabIndex = 2;
            lblAssignment.Text = "ENTER ASSIGNMENT MARK";
            // 
            // txtName
            // 
            txtName.Location = new Point(636, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 31);
            txtName.TabIndex = 3;
            // 
            // txtTest
            // 
            txtTest.Location = new Point(636, 66);
            txtTest.Name = "txtTest";
            txtTest.Size = new Size(219, 31);
            txtTest.TabIndex = 4;
            // 
            // txtAssignment
            // 
            txtAssignment.Location = new Point(636, 124);
            txtAssignment.Name = "txtAssignment";
            txtAssignment.Size = new Size(219, 31);
            txtAssignment.TabIndex = 5;
            // 
            // btnClick
            // 
            btnClick.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClick.Location = new Point(72, 207);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(805, 145);
            btnClick.TabIndex = 6;
            btnClick.Text = "DO YOU QUALIFY FOR AN EXCURSION?";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 621);
            Controls.Add(btnClick);
            Controls.Add(txtAssignment);
            Controls.Add(txtTest);
            Controls.Add(txtName);
            Controls.Add(lblAssignment);
            Controls.Add(lblTest);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblTest;
        private Label lblAssignment;
        private TextBox txtName;
        private TextBox txtTest;
        private TextBox txtAssignment;
        private Button btnClick;
    }
}
