namespace ComboBox
{
    partial class FormMain
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
            comboBox = new System.Windows.Forms.ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(12, 12);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(229, 28);
            comboBox.TabIndex = 0;
            comboBox.TabStop = false;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 88);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(398, 36);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 2;
            label1.Text = "Vybraná možnost:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 135);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox);
            Name = "Form1";
            Text = "Windows Forms ComboBox";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private TextBox textBox1;
        private Label label1;
    }
}
