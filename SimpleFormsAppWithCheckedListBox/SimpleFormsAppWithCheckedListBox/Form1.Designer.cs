namespace SimpleFormsAppWithCheckedListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            checkedListBox = new CheckedListBox();
            listBox = new ListBox();
            textBox2 = new TextBox();
            addBtn_CLick = new Button();
            dltBtn_Click = new Button();
            clrBtn_Click = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Goudy Stout", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(275, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(599, 35);
            textBox1.TabIndex = 0;
            textBox1.Text = "Favorite Movie Picker App";
            // 
            // checkedListBox
            // 
            checkedListBox.BackColor = SystemColors.AppWorkspace;
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(116, 170);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(284, 202);
            checkedListBox.TabIndex = 1;
            checkedListBox.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // listBox
            // 
            listBox.BackColor = SystemColors.AppWorkspace;
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(531, 170);
            listBox.Name = "listBox";
            listBox.Size = new Size(331, 204);
            listBox.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Gloucester MT Extra Condensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(163, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            textBox2.Text = " Movies / Series List";
            // 
            // addBtn_CLick
            // 
            addBtn_CLick.Location = new Point(203, 404);
            addBtn_CLick.Name = "addBtn_CLick";
            addBtn_CLick.Size = new Size(94, 29);
            addBtn_CLick.TabIndex = 4;
            addBtn_CLick.Text = "ADD";
            addBtn_CLick.UseVisualStyleBackColor = true;
            addBtn_CLick.Click += addBtn_CLick_Click;
            // 
            // dltBtn_Click
            // 
            dltBtn_Click.Location = new Point(927, 205);
            dltBtn_Click.Name = "dltBtn_Click";
            dltBtn_Click.Size = new Size(120, 29);
            dltBtn_Click.TabIndex = 5;
            dltBtn_Click.Text = "REMOVE";
            dltBtn_Click.UseVisualStyleBackColor = true;
            dltBtn_Click.Click += dltBtn_Click_Click;
            // 
            // clrBtn_Click
            // 
            clrBtn_Click.Location = new Point(927, 300);
            clrBtn_Click.Name = "clrBtn_Click";
            clrBtn_Click.Size = new Size(120, 29);
            clrBtn_Click.TabIndex = 6;
            clrBtn_Click.Text = "CLEAR ALL";
            clrBtn_Click.UseVisualStyleBackColor = true;
            clrBtn_Click.Click += clrBtn_Click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1118, 509);
            Controls.Add(clrBtn_Click);
            Controls.Add(dltBtn_Click);
            Controls.Add(addBtn_CLick);
            Controls.Add(textBox2);
            Controls.Add(listBox);
            Controls.Add(checkedListBox);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private CheckedListBox checkedListBox;
        private ListBox listBox;
        private TextBox textBox2;
        private Button addBtn_CLick;
        private Button dltBtn_Click;
        private Button clrBtn_Click;
    }
}
