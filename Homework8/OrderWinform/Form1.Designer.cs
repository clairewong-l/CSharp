namespace OrderWinform
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.combo = new System.Windows.Forms.ComboBox();
            this.searchValue = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_newOrder = new System.Windows.Forms.Button();
            this.button_modifyOrder = new System.Windows.Forms.Button();
            this.button_deleteOrder = new System.Windows.Forms.Button();
            this.button_importOrder = new System.Windows.Forms.Button();
            this.button_exportOrder = new System.Windows.Forms.Button();
            this.orderDateGrid = new System.Windows.Forms.DataGridView();
            this.itemDataGrid = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDateGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Items.AddRange(new object[] {
            "全部订单",
            "订单号",
            "客户名",
            "商品名"});
            this.combo.Location = new System.Drawing.Point(12, 12);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(106, 20);
            this.combo.TabIndex = 0;
            // 
            // searchValue
            // 
            this.searchValue.Location = new System.Drawing.Point(148, 11);
            this.searchValue.Name = "searchValue";
            this.searchValue.Size = new System.Drawing.Size(122, 21);
            this.searchValue.TabIndex = 1;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(301, 9);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(52, 23);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "查询";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 57);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.orderDateGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.itemDataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(524, 364);
            this.splitContainer1.SplitterDistance = 174;
            this.splitContainer1.TabIndex = 3;
            // 
            // button_newOrder
            // 
            this.button_newOrder.Location = new System.Drawing.Point(574, 57);
            this.button_newOrder.Name = "button_newOrder";
            this.button_newOrder.Size = new System.Drawing.Size(75, 23);
            this.button_newOrder.TabIndex = 4;
            this.button_newOrder.Text = "新建订单";
            this.button_newOrder.UseVisualStyleBackColor = true;
            this.button_newOrder.Click += new System.EventHandler(this.button_newOrder_Click);
            // 
            // button_modifyOrder
            // 
            this.button_modifyOrder.Location = new System.Drawing.Point(574, 86);
            this.button_modifyOrder.Name = "button_modifyOrder";
            this.button_modifyOrder.Size = new System.Drawing.Size(75, 23);
            this.button_modifyOrder.TabIndex = 5;
            this.button_modifyOrder.Text = "修改订单";
            this.button_modifyOrder.UseVisualStyleBackColor = true;
            this.button_modifyOrder.Click += new System.EventHandler(this.button_modifyOrder_Click);
            // 
            // button_deleteOrder
            // 
            this.button_deleteOrder.Location = new System.Drawing.Point(574, 115);
            this.button_deleteOrder.Name = "button_deleteOrder";
            this.button_deleteOrder.Size = new System.Drawing.Size(75, 23);
            this.button_deleteOrder.TabIndex = 6;
            this.button_deleteOrder.Text = "删除订单";
            this.button_deleteOrder.UseVisualStyleBackColor = true;
            this.button_deleteOrder.Click += new System.EventHandler(this.button_deleteOrder_Click);
            // 
            // button_importOrder
            // 
            this.button_importOrder.Location = new System.Drawing.Point(574, 173);
            this.button_importOrder.Name = "button_importOrder";
            this.button_importOrder.Size = new System.Drawing.Size(75, 23);
            this.button_importOrder.TabIndex = 8;
            this.button_importOrder.Text = "导入订单";
            this.button_importOrder.UseVisualStyleBackColor = true;
            this.button_importOrder.Click += new System.EventHandler(this.button_importOrder_Click);
            // 
            // button_exportOrder
            // 
            this.button_exportOrder.Location = new System.Drawing.Point(574, 144);
            this.button_exportOrder.Name = "button_exportOrder";
            this.button_exportOrder.Size = new System.Drawing.Size(75, 23);
            this.button_exportOrder.TabIndex = 7;
            this.button_exportOrder.Text = "导出订单";
            this.button_exportOrder.UseVisualStyleBackColor = true;
            this.button_exportOrder.Click += new System.EventHandler(this.button_exportOrder_Click);
            // 
            // orderDateGrid
            // 
            this.orderDateGrid.AllowUserToAddRows = false;
            this.orderDateGrid.AutoGenerateColumns = false;
            this.orderDateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDateGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.orderDateGrid.DataSource = this.orderBindingSource;
            this.orderDateGrid.Location = new System.Drawing.Point(0, 0);
            this.orderDateGrid.Name = "orderDateGrid";
            this.orderDateGrid.RowTemplate.Height = 23;
            this.orderDateGrid.Size = new System.Drawing.Size(521, 168);
            this.orderDateGrid.TabIndex = 0;
            // 
            // itemDataGrid
            // 
            this.itemDataGrid.AllowUserToAddRows = false;
            this.itemDataGrid.AutoGenerateColumns = false;
            this.itemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.itemDataGrid.DataSource = this.itemBindingSource;
            this.itemDataGrid.Location = new System.Drawing.Point(0, -4);
            this.itemDataGrid.Name = "itemDataGrid";
            this.itemDataGrid.RowTemplate.Height = 23;
            this.itemDataGrid.Size = new System.Drawing.Size(521, 190);
            this.itemDataGrid.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.Width = 120;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "客户";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "订单时间";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总金额";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 120;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderApp.Order);
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "商品号";
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "商品";
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            this.goodsNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "总价";
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Items";
            this.itemBindingSource.DataSource = this.orderBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_importOrder);
            this.Controls.Add(this.button_exportOrder);
            this.Controls.Add(this.button_deleteOrder);
            this.Controls.Add(this.button_modifyOrder);
            this.Controls.Add(this.button_newOrder);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.searchValue);
            this.Controls.Add(this.combo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDateGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.TextBox searchValue;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_newOrder;
        private System.Windows.Forms.Button button_modifyOrder;
        private System.Windows.Forms.Button button_deleteOrder;
        private System.Windows.Forms.Button button_importOrder;
        private System.Windows.Forms.Button button_exportOrder;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView orderDateGrid;
        private System.Windows.Forms.DataGridView itemDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

