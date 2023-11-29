
namespace _5584639_FinalProject.Form3_ChildForm
{
    partial class Form3_Cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSet11 = new _5584639_FinalProject.DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ITEM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMCATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARTITEMCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sELLERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARTITEMVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartTableAdapter1 = new _5584639_FinalProject.DataSet1TableAdapters.CARTTableAdapter();
            this.itemTableAdapter1 = new _5584639_FinalProject.DataSet1TableAdapters.ITEMTableAdapter();
            this.carT_ITEM_VIEWTableAdapter1 = new _5584639_FinalProject.DataSet1TableAdapters.CART_ITEM_VIEWTableAdapter();
            this.purchaseTableAdapter1 = new _5584639_FinalProject.DataSet1TableAdapters.PURCHASETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARTITEMVIEWBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 18F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEM_ID,
            this.cUSTOMERIDDataGridViewTextBoxColumn,
            this.iTEMIDDataGridViewTextBoxColumn,
            this.iTEMNAMEDataGridViewTextBoxColumn,
            this.iTEMCATEGORYDataGridViewTextBoxColumn,
            this.cARTITEMCOUNTDataGridViewTextBoxColumn,
            this.iTEMPRICEDataGridViewTextBoxColumn,
            this.iTEMCOUNTDataGridViewTextBoxColumn,
            this.sELLERIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cARTITEMVIEWBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1556, 941);
            this.dataGridView1.TabIndex = 4;
            // 
            // ITEM_ID
            // 
            this.ITEM_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ITEM_ID.DataPropertyName = "ITEM_ID";
            this.ITEM_ID.HeaderText = "Column1";
            this.ITEM_ID.MinimumWidth = 8;
            this.ITEM_ID.Name = "ITEM_ID";
            this.ITEM_ID.Visible = false;
            // 
            // cUSTOMERIDDataGridViewTextBoxColumn
            // 
            this.cUSTOMERIDDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_ID";
            this.cUSTOMERIDDataGridViewTextBoxColumn.HeaderText = "CUSTOMER_ID";
            this.cUSTOMERIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cUSTOMERIDDataGridViewTextBoxColumn.Name = "cUSTOMERIDDataGridViewTextBoxColumn";
            this.cUSTOMERIDDataGridViewTextBoxColumn.Visible = false;
            this.cUSTOMERIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // iTEMIDDataGridViewTextBoxColumn
            // 
            this.iTEMIDDataGridViewTextBoxColumn.DataPropertyName = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.HeaderText = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iTEMIDDataGridViewTextBoxColumn.Name = "iTEMIDDataGridViewTextBoxColumn";
            this.iTEMIDDataGridViewTextBoxColumn.Visible = false;
            this.iTEMIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // iTEMNAMEDataGridViewTextBoxColumn
            // 
            this.iTEMNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iTEMNAMEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_NAME";
            this.iTEMNAMEDataGridViewTextBoxColumn.HeaderText = "상품";
            this.iTEMNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iTEMNAMEDataGridViewTextBoxColumn.Name = "iTEMNAMEDataGridViewTextBoxColumn";
            // 
            // iTEMCATEGORYDataGridViewTextBoxColumn
            // 
            this.iTEMCATEGORYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iTEMCATEGORYDataGridViewTextBoxColumn.DataPropertyName = "ITEM_CATEGORY";
            this.iTEMCATEGORYDataGridViewTextBoxColumn.HeaderText = "카테고리";
            this.iTEMCATEGORYDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iTEMCATEGORYDataGridViewTextBoxColumn.Name = "iTEMCATEGORYDataGridViewTextBoxColumn";
            // 
            // cARTITEMCOUNTDataGridViewTextBoxColumn
            // 
            this.cARTITEMCOUNTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cARTITEMCOUNTDataGridViewTextBoxColumn.DataPropertyName = "CART_ITEM_COUNT";
            this.cARTITEMCOUNTDataGridViewTextBoxColumn.HeaderText = "구매수량";
            this.cARTITEMCOUNTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cARTITEMCOUNTDataGridViewTextBoxColumn.Name = "cARTITEMCOUNTDataGridViewTextBoxColumn";
            // 
            // iTEMPRICEDataGridViewTextBoxColumn
            // 
            this.iTEMPRICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iTEMPRICEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_PRICE";
            this.iTEMPRICEDataGridViewTextBoxColumn.HeaderText = "가격";
            this.iTEMPRICEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iTEMPRICEDataGridViewTextBoxColumn.Name = "iTEMPRICEDataGridViewTextBoxColumn";
            // 
            // iTEMCOUNTDataGridViewTextBoxColumn
            // 
            this.iTEMCOUNTDataGridViewTextBoxColumn.DataPropertyName = "ITEM_COUNT";
            this.iTEMCOUNTDataGridViewTextBoxColumn.HeaderText = "ITEM_COUNT";
            this.iTEMCOUNTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iTEMCOUNTDataGridViewTextBoxColumn.Name = "iTEMCOUNTDataGridViewTextBoxColumn";
            this.iTEMCOUNTDataGridViewTextBoxColumn.Visible = false;
            this.iTEMCOUNTDataGridViewTextBoxColumn.Width = 150;
            // 
            // sELLERIDDataGridViewTextBoxColumn
            // 
            this.sELLERIDDataGridViewTextBoxColumn.DataPropertyName = "SELLER_ID";
            this.sELLERIDDataGridViewTextBoxColumn.HeaderText = "SELLER_ID";
            this.sELLERIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sELLERIDDataGridViewTextBoxColumn.Name = "sELLERIDDataGridViewTextBoxColumn";
            this.sELLERIDDataGridViewTextBoxColumn.Visible = false;
            this.sELLERIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // cARTITEMVIEWBindingSource
            // 
            this.cARTITEMVIEWBindingSource.DataMember = "CART_ITEM_VIEW";
            this.cARTITEMVIEWBindingSource.DataSource = this.dataSet11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.iconButton4);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1556, 77);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 16F);
            this.label1.Location = new System.Drawing.Point(63, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(863, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "여러상품 선택시 드래그 또는 Shift키를 누르고 선택하세요!";
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Crimson;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("굴림", 15F);
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 38;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(1228, 5);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Size = new System.Drawing.Size(151, 66);
            this.iconButton4.TabIndex = 10;
            this.iconButton4.Text = "삭제";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.SkyBlue;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("굴림", 15F);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 38;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(967, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(213, 66);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.Text = "구매하기";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1556, 941);
            this.panel1.TabIndex = 7;
            // 
            // cartTableAdapter1
            // 
            this.cartTableAdapter1.ClearBeforeFill = true;
            // 
            // itemTableAdapter1
            // 
            this.itemTableAdapter1.ClearBeforeFill = true;
            // 
            // carT_ITEM_VIEWTableAdapter1
            // 
            this.carT_ITEM_VIEWTableAdapter1.ClearBeforeFill = true;
            // 
            // purchaseTableAdapter1
            // 
            this.purchaseTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3_Cart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1556, 1018);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form3_Cart";
            this.Text = "Form3_Cart";
            this.Load += new System.EventHandler(this.Form3_Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARTITEMVIEWBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private DataSet1TableAdapters.CARTTableAdapter cartTableAdapter1;
        private System.Windows.Forms.Label label1;
        private DataSet1TableAdapters.ITEMTableAdapter itemTableAdapter1;
        private DataSet1TableAdapters.CART_ITEM_VIEWTableAdapter carT_ITEM_VIEWTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMCATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARTITEMCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sELLERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cARTITEMVIEWBindingSource;
        private DataSet1TableAdapters.PURCHASETableAdapter purchaseTableAdapter1;
    }
}