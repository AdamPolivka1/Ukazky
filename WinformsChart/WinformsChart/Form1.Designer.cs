namespace WinformsChart
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
            comboBoxShowChart = new ComboBox();
            groupBox1 = new GroupBox();
            panelChart = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxShowChart
            // 
            comboBoxShowChart.FormattingEnabled = true;
            comboBoxShowChart.Location = new Point(6, 26);
            comboBoxShowChart.Name = "comboBoxShowChart";
            comboBoxShowChart.Size = new Size(238, 28);
            comboBoxShowChart.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxShowChart);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 68);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Zobrazit Graf";
            // 
            // panelChart
            // 
            panelChart.Location = new Point(12, 97);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(776, 341);
            panelChart.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelChart);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Grafy ve Windows Forms";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxShowChart;
        private GroupBox groupBox1;
        private Panel panelChart;
    }
}
