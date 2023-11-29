
namespace _5584639_FinalProject.Form4_ChildForm
{
    partial class Form4_Refund
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ITEM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMCATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFUNDPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFUNDITEMCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFUNDALLOWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sELLERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFUNDITEMVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new _5584639_FinalProject.DataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.refundTableAdapter1 = new _5584639_FinalProject.DataSet1TableAdapters.REFUNDTableAdapter();
            this.purchaseTableAdapter1 = new _5584639_FinalProject.DataSet1TableAdapters.PURCHASETableAdapter();
            this.itemTableAdapter1 = new _5584639_FinalProject.DataSet1TableAdapters.ITEMTableAdapter();
            this.refunD_ITEM_VIEWTableAdapter1 = new _5584639_FinalProject.DataSet1TableAdapters.REFUND_ITEM_VIEWTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFUNDITEMVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1556, 941);
            this.panel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 18F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEM_ID,
            this.iTEMIDDataGridViewTextBoxColumn,
            this.cUSTOMERIDDataGridViewTextBoxColumn,
            this.iTEMNAMEDataGridViewTextBoxColumn,
            this.iTEMCATEGORYDataGridViewTextBoxColumn,
            this.rEFUNDPRICEDataGridViewTextBoxColumn,
            this.rEFUNDITEMCOUNTDataGridViewTextBoxColumn,
            this.rEFUNDALLOWDataGridViewTextBoxColumn,
            this.iTEMCOUNTDataGridViewTextBoxColumn,
            this.iTEMPRICEDataGridViewTextBoxColumn,
            this.sELLERIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEFUNDITEMVIEWBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 14F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 40;
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
            // iTEMIDDataGridViewTextBoxColumn
            // 
            this.iTEMIDDataGridViewTextBoxColumn.DataPropertyName = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.HeaderText = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iTEMIDDataGridViewTextBoxColumn.Name = "iTEMIDDataGridViewTextBoxColumn";
            this.iTEMIDDataGridViewTextBoxColumn.Visible = false;
            this.iTEMIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // cUSTOMERIDDataGridViewTextBoxColumn
            // 
            this.cUSTOMERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cUSTOMERIDDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_ID";
            this.cUSTOMERIDDataGridViewTextBoxColumn.HeaderText = "요청고객";
            this.cUSTOMERIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cUSTOMERIDDataGridViewTextBoxColumn.Name = "cUSTOMERIDDataGridViewTextBoxColumn";
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
            // rEFUNDPRICEDataGridViewTextBoxColumn
            // 
            this.rEFUNDPRICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rEFUNDPRICEDataGridViewTextBoxColumn.DataPropertyName = "REFUND_PRICE";
            this.rEFUNDPRICEDataGridViewTextBoxColumn.HeaderText = "환불가격";
            this.rEFUNDPRICEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rEFUNDPRICEDataGridViewTextBoxColumn.Name = "rEFUNDPRICEDataGridViewTextBoxColumn";
            // 
            // rEFUNDITEMCOUNTDataGridViewTextBoxColumn
            // 
            this.rEFUNDITEMCOUNTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rEFUNDITEMCOUNTDataGridViewTextBoxColumn.DataPropertyName = "REFUND_ITEM_COUNT";
            this.rEFUNDITEMCOUNTDataGridViewTextBoxColumn.HeaderText = "환불수량";
            this.rEFUNDITEMCOUNTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rEFUNDITEMCOUNTDataGridViewTextBoxColumn.Name = "rEFUNDITEMCOUNTDataGridViewTextBoxColumn";
            // 
            // rEFUNDALLOWDataGridViewTextBoxColumn
            // 
            this.rEFUNDALLOWDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rEFUNDALLOWDataGridViewTextBoxColumn.DataPropertyName = "REFUND_ALLOW";
            dataGridViewCellStyle5.NullValue = "대기";
            this.rEFUNDALLOWDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.rEFUNDALLOWDataGridViewTextBoxColumn.HeaderText = "환불승인";
            this.rEFUNDALLOWDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rEFUNDALLOWDataGridViewTextBoxColumn.Name = "rEFUNDALLOWDataGridViewTextBoxColumn";
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
            // iTEMPRICEDataGridViewTextBoxColumn
            // 
            this.iTEMPRICEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_PRICE";
            this.iTEMPRICEDataGridViewTextBoxColumn.HeaderText = "ITEM_PRICE";
            this.iTEMPRICEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iTEMPRICEDataGridViewTextBoxColumn.Name = "iTEMPRICEDataGridViewTextBoxColumn";
            this.iTEMPRICEDataGridViewTextBoxColumn.Visible = false;
            this.iTEMPRICEDataGridViewTextBoxColumn.Width = 150;
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
            // rEFUNDITEMVIEWBindingSource
            // 
            this.rEFUNDITEMVIEWBindingSource.DataMember = "REFUND_ITEM_VIEW";
            this.rEFUNDITEMVIEWBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1556, 77);
            this.panel2.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("굴림", 22F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 44;
            this.comboBox1.Items.AddRange(new object[] {
            "대기",
            "승인"});
            this.comboBox1.Location = new System.Drawing.Point(703, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 52);
            this.comboBox1.TabIndex = 14;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.SkyBlue;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("굴림", 15F);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 38;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(845, 6);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(284, 66);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.Text = "환불 처리하기";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 16F);
            this.label1.Location = new System.Drawing.Point(86, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "콤보박스에서 승인상태 선택 후 처리.";
            // 
            // refundTableAdapter1
            // 
            this.refundTableAdapter1.ClearBeforeFill = true;
            // 
            // purchaseTableAdapter1
            // 
            this.purchaseTableAdapter1.ClearBeforeFill = true;
            // 
            // itemTableAdapter1
            // 
            this.itemTableAdapter1.ClearBeforeFill = true;
            // 
            // refunD_ITEM_VIEWTableAdapter1
            // 
            this.refunD_ITEM_VIEWTableAdapter1.ClearBeforeFill = true;
            // 
            // Form4_Refund
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1556, 1018);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form4_Refund";
            this.Text = "Form4_Refund";
            this.Load += new System.EventHandler(this.Form4_Refund_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFUNDITEMVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataSet1TableAdapters.REFUNDTableAdapter refundTableAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataSet1TableAdapters.PURCHASETableAdapter purchaseTableAdapter1;
        private DataSet1TableAdapters.ITEMTableAdapter itemTableAdapter1;
        private System.Windows.Forms.BindingSource rEFUNDITEMVIEWBindingSource;
        private DataSet1TableAdapters.REFUND_ITEM_VIEWTableAdapter refunD_ITEM_VIEWTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMCATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFUNDPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFUNDITEMCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFUNDALLOWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sELLERIDDataGridViewTextBoxColumn;
    }
}