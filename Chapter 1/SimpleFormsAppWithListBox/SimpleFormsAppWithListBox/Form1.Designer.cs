namespace SimpleFormsAppWithListBox
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
            listBox = new ListBox();
            textBox = new TextBox();
            add = new Button();
            remove = new Button();
            clear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(27, 84);
            listBox.Name = "listBox";
            listBox.Size = new Size(189, 214);
            listBox.TabIndex = 0;
            // 
            // textBox
            // 
            textBox.Location = new Point(244, 84);
            textBox.Name = "textBox";
            textBox.Size = new Size(100, 23);
            textBox.TabIndex = 1;
            // 
            // add
            // 
            add.Location = new Point(244, 122);
            add.Name = "add";
            add.Size = new Size(100, 23);
            add.TabIndex = 2;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // remove
            // 
            remove.Location = new Point(244, 164);
            remove.Name = "remove";
            remove.Size = new Size(100, 23);
            remove.TabIndex = 3;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // clear
            // 
            clear.Location = new Point(244, 212);
            clear.Name = "clear";
            clear.Size = new Size(100, 23);
            clear.TabIndex = 4;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(307, 30);
            label1.TabIndex = 5;
            label1.Text = "Programming Language Names";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 385);
            Controls.Add(label1);
            Controls.Add(clear);
            Controls.Add(remove);
            Controls.Add(add);
            Controls.Add(textBox);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private TextBox textBox;
        private Button add;
        private Button remove;
        private Button clear;
        private Label label1;
    }
}
