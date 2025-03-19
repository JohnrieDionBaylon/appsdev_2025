namespace SimpleFormsAppWithComboBox
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            movieCheckedListBox = new CheckedListBox();
            favoriteListBox = new ListBox();
            removeButton = new Button();
            clearButton = new Button();
            genreComboBox = new ComboBox();
            addButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 0;
            label1.Text = "Simple Favorite Movie Picker";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 58);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 58);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Movie List";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(314, 58);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 3;
            label4.Text = "My Favorite Movie List";
            // 
            // movieCheckedListBox
            // 
            movieCheckedListBox.FormattingEnabled = true;
            movieCheckedListBox.Location = new Point(169, 75);
            movieCheckedListBox.Name = "movieCheckedListBox";
            movieCheckedListBox.Size = new Size(120, 94);
            movieCheckedListBox.TabIndex = 5;
            movieCheckedListBox.SelectedIndexChanged += movieCheckedListBox_SelectedIndexChanged;
            // 
            // favoriteListBox
            // 
            favoriteListBox.FormattingEnabled = true;
            favoriteListBox.ItemHeight = 15;
            favoriteListBox.Location = new Point(314, 76);
            favoriteListBox.Name = "favoriteListBox";
            favoriteListBox.Size = new Size(149, 94);
            favoriteListBox.TabIndex = 6;
            favoriteListBox.SelectedIndexChanged += favoriteListBox_SelectedIndexChanged;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(469, 75);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 7;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(469, 104);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 8;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // genreComboBox
            // 
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Location = new Point(24, 76);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(121, 23);
            genreComboBox.TabIndex = 10;
            genreComboBox.SelectedIndexChanged += genreComboBox_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(169, 175);
            addButton.Name = "addButton";
            addButton.Size = new Size(120, 23);
            addButton.TabIndex = 11;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(24, 105);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 12;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 232);
            Controls.Add(button1);
            Controls.Add(addButton);
            Controls.Add(genreComboBox);
            Controls.Add(clearButton);
            Controls.Add(removeButton);
            Controls.Add(favoriteListBox);
            Controls.Add(movieCheckedListBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Movie Form App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckedListBox movieCheckedListBox;
        private ListBox favoriteListBox;
        private Button removeButton;
        private Button clearButton;
        private ComboBox genreComboBox;
        private Button addButton;
        private Button button1;
    }
}
