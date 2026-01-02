namespace ListBox
{
    partial class FormListBox
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
            listBoxMain = new System.Windows.Forms.ListBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonDeleteAll = new Button();
            textBoxAddItem = new TextBox();
            textBoxActItem = new TextBox();
            labelActItem = new Label();
            SuspendLayout();
            // 
            // listBoxMain
            // 
            listBoxMain.FormattingEnabled = true;
            listBoxMain.Location = new Point(399, 19);
            listBoxMain.Name = "listBoxMain";
            listBoxMain.Size = new Size(357, 184);
            listBoxMain.TabIndex = 0;
            listBoxMain.SelectedValueChanged += listBoxMain_SelectedValueChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(299, 19);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Přidej";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(299, 54);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Odeber";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonDeleteAll
            // 
            buttonDeleteAll.Location = new Point(299, 89);
            buttonDeleteAll.Name = "buttonDeleteAll";
            buttonDeleteAll.Size = new Size(94, 29);
            buttonDeleteAll.TabIndex = 3;
            buttonDeleteAll.Text = "Smaž vše";
            buttonDeleteAll.UseVisualStyleBackColor = true;
            buttonDeleteAll.Click += buttonDeleteAll_Click;
            // 
            // textBoxAddItem
            // 
            textBoxAddItem.Location = new Point(28, 21);
            textBoxAddItem.Name = "textBoxAddItem";
            textBoxAddItem.Size = new Size(261, 27);
            textBoxAddItem.TabIndex = 4;
            // 
            // textBoxActItem
            // 
            textBoxActItem.Location = new Point(28, 177);
            textBoxActItem.Name = "textBoxActItem";
            textBoxActItem.ReadOnly = true;
            textBoxActItem.Size = new Size(261, 27);
            textBoxActItem.TabIndex = 5;
            // 
            // labelActItem
            // 
            labelActItem.AutoSize = true;
            labelActItem.Location = new Point(28, 154);
            labelActItem.Name = "labelActItem";
            labelActItem.Size = new Size(106, 20);
            labelActItem.TabIndex = 6;
            labelActItem.Text = "Aktuální prvek:";
            // 
            // FormListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 225);
            Controls.Add(labelActItem);
            Controls.Add(textBoxActItem);
            Controls.Add(textBoxAddItem);
            Controls.Add(buttonDeleteAll);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxMain);
            Name = "FormListBox";
            Text = "Windows Forms ListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMain;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonDeleteAll;
        private TextBox textBoxAddItem;
        private TextBox textBoxActItem;
        private Label labelActItem;
    }
}
