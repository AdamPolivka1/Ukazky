namespace DGV2
{
    partial class FormDGV2
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAddColumns = new System.Windows.Forms.DataGridView();
            this.groupBoxAddColumn = new System.Windows.Forms.GroupBox();
            this.comboBoxColumnType = new System.Windows.Forms.ComboBox();
            this.labelColumnType = new System.Windows.Forms.Label();
            this.labelAddColumn = new System.Windows.Forms.Label();
            this.textBoxColumnAdd = new System.Windows.Forms.TextBox();
            this.buttonAddColumn = new System.Windows.Forms.Button();
            this.groupBoxDeleteColumn = new System.Windows.Forms.GroupBox();
            this.textBoxColumnDelete = new System.Windows.Forms.TextBox();
            this.labelDeleteColumn = new System.Windows.Forms.Label();
            this.buttonDeleteColumn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddColumns)).BeginInit();
            this.groupBoxAddColumn.SuspendLayout();
            this.groupBoxDeleteColumn.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAddColumns
            // 
            this.dataGridViewAddColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddColumns.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAddColumns.Name = "dataGridViewAddColumns";
            this.dataGridViewAddColumns.RowHeadersWidth = 51;
            this.dataGridViewAddColumns.RowTemplate.Height = 24;
            this.dataGridViewAddColumns.Size = new System.Drawing.Size(748, 285);
            this.dataGridViewAddColumns.TabIndex = 0;
            // 
            // groupBoxAddColumn
            // 
            this.groupBoxAddColumn.Controls.Add(this.comboBoxColumnType);
            this.groupBoxAddColumn.Controls.Add(this.labelColumnType);
            this.groupBoxAddColumn.Controls.Add(this.labelAddColumn);
            this.groupBoxAddColumn.Controls.Add(this.textBoxColumnAdd);
            this.groupBoxAddColumn.Controls.Add(this.buttonAddColumn);
            this.groupBoxAddColumn.Location = new System.Drawing.Point(12, 315);
            this.groupBoxAddColumn.Name = "groupBoxAddColumn";
            this.groupBoxAddColumn.Size = new System.Drawing.Size(369, 96);
            this.groupBoxAddColumn.TabIndex = 1;
            this.groupBoxAddColumn.TabStop = false;
            this.groupBoxAddColumn.Text = "Přidání sloupce";
            // 
            // comboBoxColumnType
            // 
            this.comboBoxColumnType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumnType.FormattingEnabled = true;
            this.comboBoxColumnType.Items.AddRange(new object[] {
            "TextBox",
            "Button",
            "CheckBox",
            "ComboBox",
            "Image"});
            this.comboBoxColumnType.Location = new System.Drawing.Point(119, 64);
            this.comboBoxColumnType.Name = "comboBoxColumnType";
            this.comboBoxColumnType.Size = new System.Drawing.Size(170, 24);
            this.comboBoxColumnType.TabIndex = 5;
            // 
            // labelColumnType
            // 
            this.labelColumnType.AutoSize = true;
            this.labelColumnType.Location = new System.Drawing.Point(7, 67);
            this.labelColumnType.Name = "labelColumnType";
            this.labelColumnType.Size = new System.Drawing.Size(85, 16);
            this.labelColumnType.TabIndex = 4;
            this.labelColumnType.Text = "Typ sloupce:";
            // 
            // labelAddColumn
            // 
            this.labelAddColumn.AutoSize = true;
            this.labelAddColumn.Location = new System.Drawing.Point(7, 32);
            this.labelAddColumn.Name = "labelAddColumn";
            this.labelAddColumn.Size = new System.Drawing.Size(100, 16);
            this.labelAddColumn.TabIndex = 3;
            this.labelAddColumn.Text = "Název sloupce:";
            // 
            // textBoxColumnAdd
            // 
            this.textBoxColumnAdd.Location = new System.Drawing.Point(119, 29);
            this.textBoxColumnAdd.Name = "textBoxColumnAdd";
            this.textBoxColumnAdd.Size = new System.Drawing.Size(250, 22);
            this.textBoxColumnAdd.TabIndex = 1;
            // 
            // buttonAddColumn
            // 
            this.buttonAddColumn.Location = new System.Drawing.Point(294, 64);
            this.buttonAddColumn.Name = "buttonAddColumn";
            this.buttonAddColumn.Size = new System.Drawing.Size(75, 23);
            this.buttonAddColumn.TabIndex = 0;
            this.buttonAddColumn.Text = "Přidej";
            this.buttonAddColumn.UseVisualStyleBackColor = true;
            this.buttonAddColumn.Click += new System.EventHandler(this.buttonAddColumn_Click);
            // 
            // groupBoxDeleteColumn
            // 
            this.groupBoxDeleteColumn.Controls.Add(this.textBoxColumnDelete);
            this.groupBoxDeleteColumn.Controls.Add(this.labelDeleteColumn);
            this.groupBoxDeleteColumn.Controls.Add(this.buttonDeleteColumn);
            this.groupBoxDeleteColumn.Location = new System.Drawing.Point(397, 315);
            this.groupBoxDeleteColumn.Name = "groupBoxDeleteColumn";
            this.groupBoxDeleteColumn.Size = new System.Drawing.Size(363, 96);
            this.groupBoxDeleteColumn.TabIndex = 2;
            this.groupBoxDeleteColumn.TabStop = false;
            this.groupBoxDeleteColumn.Text = "Smazání sloupce";
            // 
            // textBoxColumnDelete
            // 
            this.textBoxColumnDelete.Location = new System.Drawing.Point(110, 29);
            this.textBoxColumnDelete.Name = "textBoxColumnDelete";
            this.textBoxColumnDelete.Size = new System.Drawing.Size(250, 22);
            this.textBoxColumnDelete.TabIndex = 5;
            // 
            // labelDeleteColumn
            // 
            this.labelDeleteColumn.AutoSize = true;
            this.labelDeleteColumn.Location = new System.Drawing.Point(6, 32);
            this.labelDeleteColumn.Name = "labelDeleteColumn";
            this.labelDeleteColumn.Size = new System.Drawing.Size(100, 16);
            this.labelDeleteColumn.TabIndex = 4;
            this.labelDeleteColumn.Text = "Název sloupce:";
            // 
            // buttonDeleteColumn
            // 
            this.buttonDeleteColumn.Location = new System.Drawing.Point(285, 65);
            this.buttonDeleteColumn.Name = "buttonDeleteColumn";
            this.buttonDeleteColumn.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteColumn.TabIndex = 0;
            this.buttonDeleteColumn.Text = "Smaž";
            this.buttonDeleteColumn.UseVisualStyleBackColor = true;
            this.buttonDeleteColumn.Click += new System.EventHandler(this.buttonDeleteColumn_Click);
            // 
            // FormDGV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 419);
            this.Controls.Add(this.groupBoxDeleteColumn);
            this.Controls.Add(this.groupBoxAddColumn);
            this.Controls.Add(this.dataGridViewAddColumns);
            this.Name = "FormDGV2";
            this.Text = "DGV 2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddColumns)).EndInit();
            this.groupBoxAddColumn.ResumeLayout(false);
            this.groupBoxAddColumn.PerformLayout();
            this.groupBoxDeleteColumn.ResumeLayout(false);
            this.groupBoxDeleteColumn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAddColumns;
        private System.Windows.Forms.GroupBox groupBoxAddColumn;
        private System.Windows.Forms.Button buttonAddColumn;
        private System.Windows.Forms.Label labelAddColumn;
        private System.Windows.Forms.TextBox textBoxColumnAdd;
        private System.Windows.Forms.Label labelColumnType;
        private System.Windows.Forms.ComboBox comboBoxColumnType;
        private System.Windows.Forms.GroupBox groupBoxDeleteColumn;
        private System.Windows.Forms.Button buttonDeleteColumn;
        private System.Windows.Forms.Label labelDeleteColumn;
        private System.Windows.Forms.TextBox textBoxColumnDelete;
    }
}

