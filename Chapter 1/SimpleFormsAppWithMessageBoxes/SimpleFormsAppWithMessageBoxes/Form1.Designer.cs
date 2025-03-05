namespace SimpleFormsAppWithMessageBoxes
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
            label1 = new Label();
            firstName = new TextBox();
            middleName = new TextBox();
            lastName = new TextBox();
            Suffix = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 21);
            label1.TabIndex = 0;
            label1.Text = "Simple Form Application";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // firstName
            // 
            firstName.Location = new Point(84, 91);
            firstName.Name = "firstName";
            firstName.Size = new Size(164, 23);
            firstName.TabIndex = 1;
            firstName.TextChanged += textBox1_TextChanged;
            // 
            // middleName
            // 
            middleName.Location = new Point(84, 167);
            middleName.Name = "middleName";
            middleName.Size = new Size(164, 23);
            middleName.TabIndex = 2;
            middleName.TextChanged += textBox2_TextChanged;
            // 
            // lastName
            // 
            lastName.Location = new Point(84, 233);
            lastName.Name = "lastName";
            lastName.Size = new Size(164, 23);
            lastName.TabIndex = 3;
            // 
            // Suffix
            // 
            Suffix.Location = new Point(84, 305);
            Suffix.Name = "Suffix";
            Suffix.Size = new Size(164, 23);
            Suffix.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(125, 355);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 73);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "First Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 149);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 7;
            label3.Text = "Middle Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 215);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 8;
            label4.Text = "Last Name";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 287);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 9;
            label5.Text = "Suffix";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(Suffix);
            Controls.Add(lastName);
            Controls.Add(middleName);
            Controls.Add(firstName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox firstName;
        private TextBox middleName;
        private TextBox lastName;
        private TextBox Suffix;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
