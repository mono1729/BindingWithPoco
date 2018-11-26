namespace BindingWithPoco
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label discontinuedLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label quantityPerUnitLabel;
            System.Windows.Forms.Label reorderLevelLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label unitsInStockLabel;
            System.Windows.Forms.Label unitsOnOrderLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityPerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discontinuedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.categoryIDTextBox = new System.Windows.Forms.TextBox();
            this.discontinuedCheckBox = new System.Windows.Forms.CheckBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.quantityPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.supplierIDTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.unitsInStockTextBox = new System.Windows.Forms.TextBox();
            this.unitsOnOrderTextBox = new System.Windows.Forms.TextBox();
            categoryIDLabel = new System.Windows.Forms.Label();
            discontinuedLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            quantityPerUnitLabel = new System.Windows.Forms.Label();
            reorderLevelLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            unitsInStockLabel = new System.Windows.Forms.Label();
            unitsOnOrderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(24, 239);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(68, 12);
            categoryIDLabel.TabIndex = 5;
            categoryIDLabel.Text = "Category ID:";
            // 
            // discontinuedLabel
            // 
            discontinuedLabel.AutoSize = true;
            discontinuedLabel.Location = new System.Drawing.Point(24, 266);
            discontinuedLabel.Name = "discontinuedLabel";
            discontinuedLabel.Size = new System.Drawing.Size(73, 12);
            discontinuedLabel.TabIndex = 7;
            discontinuedLabel.Text = "Discontinued:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(24, 294);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 12);
            productIDLabel.TabIndex = 9;
            productIDLabel.Text = "Product ID:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(24, 319);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(79, 12);
            productNameLabel.TabIndex = 11;
            productNameLabel.Text = "Product Name:";
            // 
            // quantityPerUnitLabel
            // 
            quantityPerUnitLabel.AutoSize = true;
            quantityPerUnitLabel.Location = new System.Drawing.Point(24, 344);
            quantityPerUnitLabel.Name = "quantityPerUnitLabel";
            quantityPerUnitLabel.Size = new System.Drawing.Size(96, 12);
            quantityPerUnitLabel.TabIndex = 13;
            quantityPerUnitLabel.Text = "Quantity Per Unit:";
            // 
            // reorderLevelLabel
            // 
            reorderLevelLabel.AutoSize = true;
            reorderLevelLabel.Location = new System.Drawing.Point(249, 240);
            reorderLevelLabel.Name = "reorderLevelLabel";
            reorderLevelLabel.Size = new System.Drawing.Size(78, 12);
            reorderLevelLabel.TabIndex = 15;
            reorderLevelLabel.Text = "Reorder Level:";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(249, 265);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(63, 12);
            supplierIDLabel.TabIndex = 17;
            supplierIDLabel.Text = "Supplier ID:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(249, 290);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(58, 12);
            unitPriceLabel.TabIndex = 19;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // unitsInStockLabel
            // 
            unitsInStockLabel.AutoSize = true;
            unitsInStockLabel.Location = new System.Drawing.Point(249, 315);
            unitsInStockLabel.Name = "unitsInStockLabel";
            unitsInStockLabel.Size = new System.Drawing.Size(80, 12);
            unitsInStockLabel.TabIndex = 21;
            unitsInStockLabel.Text = "Units In Stock:";
            // 
            // unitsOnOrderLabel
            // 
            unitsOnOrderLabel.AutoSize = true;
            unitsOnOrderLabel.Location = new System.Drawing.Point(249, 340);
            unitsOnOrderLabel.Name = "unitsOnOrderLabel";
            unitsOnOrderLabel.Size = new System.Drawing.Size(84, 12);
            unitsOnOrderLabel.TabIndex = 23;
            unitsOnOrderLabel.Text = "Units On Order:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add row";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modify first row productname";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.quantityPerUnitDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.unitsInStockDataGridViewTextBoxColumn,
            this.unitsOnOrderDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn,
            this.discontinuedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(776, 184);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            // 
            // quantityPerUnitDataGridViewTextBoxColumn
            // 
            this.quantityPerUnitDataGridViewTextBoxColumn.DataPropertyName = "QuantityPerUnit";
            this.quantityPerUnitDataGridViewTextBoxColumn.HeaderText = "QuantityPerUnit";
            this.quantityPerUnitDataGridViewTextBoxColumn.Name = "quantityPerUnitDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // unitsInStockDataGridViewTextBoxColumn
            // 
            this.unitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.HeaderText = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.Name = "unitsInStockDataGridViewTextBoxColumn";
            // 
            // unitsOnOrderDataGridViewTextBoxColumn
            // 
            this.unitsOnOrderDataGridViewTextBoxColumn.DataPropertyName = "UnitsOnOrder";
            this.unitsOnOrderDataGridViewTextBoxColumn.HeaderText = "UnitsOnOrder";
            this.unitsOnOrderDataGridViewTextBoxColumn.Name = "unitsOnOrderDataGridViewTextBoxColumn";
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            // 
            // discontinuedDataGridViewCheckBoxColumn
            // 
            this.discontinuedDataGridViewCheckBoxColumn.DataPropertyName = "Discontinued";
            this.discontinuedDataGridViewCheckBoxColumn.HeaderText = "Discontinued";
            this.discontinuedDataGridViewCheckBoxColumn.Name = "discontinuedDataGridViewCheckBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(BindingWithPoco.Product);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 19);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // categoryIDTextBox
            // 
            this.categoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "CategoryID", true));
            this.categoryIDTextBox.Location = new System.Drawing.Point(126, 236);
            this.categoryIDTextBox.Name = "categoryIDTextBox";
            this.categoryIDTextBox.Size = new System.Drawing.Size(104, 19);
            this.categoryIDTextBox.TabIndex = 6;
            // 
            // discontinuedCheckBox
            // 
            this.discontinuedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSource1, "Discontinued", true));
            this.discontinuedCheckBox.Location = new System.Drawing.Point(126, 261);
            this.discontinuedCheckBox.Name = "discontinuedCheckBox";
            this.discontinuedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.discontinuedCheckBox.TabIndex = 8;
            this.discontinuedCheckBox.Text = "checkBox1";
            this.discontinuedCheckBox.UseVisualStyleBackColor = true;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(126, 291);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(104, 19);
            this.productIDTextBox.TabIndex = 10;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(126, 316);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(104, 19);
            this.productNameTextBox.TabIndex = 12;
            // 
            // quantityPerUnitTextBox
            // 
            this.quantityPerUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "QuantityPerUnit", true));
            this.quantityPerUnitTextBox.Location = new System.Drawing.Point(126, 341);
            this.quantityPerUnitTextBox.Name = "quantityPerUnitTextBox";
            this.quantityPerUnitTextBox.Size = new System.Drawing.Size(104, 19);
            this.quantityPerUnitTextBox.TabIndex = 14;
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ReorderLevel", true));
            this.reorderLevelTextBox.Location = new System.Drawing.Point(351, 237);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(104, 19);
            this.reorderLevelTextBox.TabIndex = 16;
            // 
            // supplierIDTextBox
            // 
            this.supplierIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "SupplierID", true));
            this.supplierIDTextBox.Location = new System.Drawing.Point(351, 262);
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.Size = new System.Drawing.Size(104, 19);
            this.supplierIDTextBox.TabIndex = 18;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(351, 287);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(104, 19);
            this.unitPriceTextBox.TabIndex = 20;
            // 
            // unitsInStockTextBox
            // 
            this.unitsInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "UnitsInStock", true));
            this.unitsInStockTextBox.Location = new System.Drawing.Point(351, 312);
            this.unitsInStockTextBox.Name = "unitsInStockTextBox";
            this.unitsInStockTextBox.Size = new System.Drawing.Size(104, 19);
            this.unitsInStockTextBox.TabIndex = 22;
            // 
            // unitsOnOrderTextBox
            // 
            this.unitsOnOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "UnitsOnOrder", true));
            this.unitsOnOrderTextBox.Location = new System.Drawing.Point(351, 337);
            this.unitsOnOrderTextBox.Name = "unitsOnOrderTextBox";
            this.unitsOnOrderTextBox.Size = new System.Drawing.Size(104, 19);
            this.unitsOnOrderTextBox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 373);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(this.categoryIDTextBox);
            this.Controls.Add(discontinuedLabel);
            this.Controls.Add(this.discontinuedCheckBox);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(quantityPerUnitLabel);
            this.Controls.Add(this.quantityPerUnitTextBox);
            this.Controls.Add(reorderLevelLabel);
            this.Controls.Add(this.reorderLevelTextBox);
            this.Controls.Add(supplierIDLabel);
            this.Controls.Add(this.supplierIDTextBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(unitsInStockLabel);
            this.Controls.Add(this.unitsInStockTextBox);
            this.Controls.Add(unitsOnOrderLabel);
            this.Controls.Add(this.unitsOnOrderTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityPerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsOnOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn discontinuedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox categoryIDTextBox;
        private System.Windows.Forms.CheckBox discontinuedCheckBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox quantityPerUnitTextBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.TextBox supplierIDTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox unitsInStockTextBox;
        private System.Windows.Forms.TextBox unitsOnOrderTextBox;
    }
}

