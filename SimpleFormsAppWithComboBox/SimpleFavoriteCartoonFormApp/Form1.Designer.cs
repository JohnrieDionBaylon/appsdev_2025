namespace SimpleFavoriteCartoonFormApp
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            clrBtn_Click = new Button();
            vwBtn_Click = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(435, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(458, 369);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.Font = new Font("Magneto", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DeepPink;
            textBox1.Location = new Point(532, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 32);
            textBox1.TabIndex = 1;
            textBox1.Text = "Favorite Cartoon Picker";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // clrBtn_Click
            // 
            clrBtn_Click.BackColor = SystemColors.ActiveCaptionText;
            clrBtn_Click.Font = new Font("Magneto", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clrBtn_Click.ForeColor = Color.DeepPink;
            clrBtn_Click.Location = new Point(173, 301);
            clrBtn_Click.Name = "clrBtn_Click";
            clrBtn_Click.Size = new Size(151, 29);
            clrBtn_Click.TabIndex = 2;
            clrBtn_Click.Text = "Clear";
            clrBtn_Click.UseVisualStyleBackColor = false;
            clrBtn_Click.Click += clrBtn_Click_Click;
            // 
            // vwBtn_Click
            // 
            vwBtn_Click.BackColor = SystemColors.ActiveCaptionText;
            vwBtn_Click.Font = new Font("Magneto", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vwBtn_Click.ForeColor = Color.DeepPink;
            vwBtn_Click.Location = new Point(173, 197);
            vwBtn_Click.Name = "vwBtn_Click";
            vwBtn_Click.Size = new Size(151, 29);
            vwBtn_Click.TabIndex = 3;
            vwBtn_Click.Text = "View";
            vwBtn_Click.UseVisualStyleBackColor = false;
            vwBtn_Click.Click += vwBtn_Click_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InactiveCaptionText;
            comboBox1.Font = new Font("Magneto", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.DeepPink;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(173, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 30);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Characters";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1159, 501);
            Controls.Add(comboBox1);
            Controls.Add(vwBtn_Click);
            Controls.Add(clrBtn_Click);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button clrBtn_Click;
        private Button vwBtn_Click;
        private ComboBox comboBox1;
    }
}
