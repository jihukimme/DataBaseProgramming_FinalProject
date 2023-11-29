
namespace _5584639_FinalProject.Form3_ChildForm
{
    partial class Form3_Purchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ITEM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMCATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURCHASEITEMCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURCHASEPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURCHASEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sELLERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURCHASEITEMVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new _5584639_FinalProject.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.purchaseTableAdapter1 = new _5584639_FinalProject.DataSet1TableAdapters.PURCHASETableAdapter();
            this.refundTableAdapter1 = new _5584639_FinalProject.DataSet1TableAdapters.REFUNDTableAdapter();
            this.reviewTableAdapter1 = new _5584639_FinalProject.DataSet1TableAdapters.REVIEWTableAdapter();
            this.purchasE_ITEM_VIEWTableAdapter1 = new _5584639_FinalProject.DataSet1TableAdapters.PURCHASE_ITEM_VIEWTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEITEMVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.pURCHASEITEMCOUNTDataGridViewTextBoxColumn,
            this.pURCHASEPRICEDataGridViewTextBoxColumn,
            this.pURCHASEDATEDataGridViewTextBoxColumn,
            this.iTEMCOUNTDataGridViewTextBoxColumn,
            this.iTEMPRICEDataGridViewTextBoxColumn,
            this.sELLERIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pURCHASEITEMVIEWBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1556, 637);
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
            // pURCHASEITEMCOUNTDataGridViewTextBoxColumn
            // 
            this.pURCHASEITEMCOUNTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pURCHASEITEMCOUNTDataGridViewTextBoxColumn.DataPropertyName = "PURCHASE_ITEM_COUNT";
            this.pURCHASEITEMCOUNTDataGridViewTextBoxColumn.HeaderText = "구매수량";
            this.pURCHASEITEMCOUNTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pURCHASEITEMCOUNTDataGridViewTextBoxColumn.Name = "pURCHASEITEMCOUNTDataGridViewTextBoxColumn";
            // 
            // pURCHASEPRICEDataGridViewTextBoxColumn
            // 
            this.pURCHASEPRICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pURCHASEPRICEDataGridViewTextBoxColumn.DataPropertyName = "PURCHASE_PRICE";
            this.pURCHASEPRICEDataGridViewTextBoxColumn.HeaderText = "구매가격";
            this.pURCHASEPRICEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pURCHASEPRICEDataGridViewTextBoxColumn.Name = "pURCHASEPRICEDataGridViewTextBoxColumn";
            // 
            // pURCHASEDATEDataGridViewTextBoxColumn
            // 
            this.pURCHASEDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pURCHASEDATEDataGridViewTextBoxColumn.DataPropertyName = "PURCHASE_DATE";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = "XXXX-XX-XX";
            this.pURCHASEDATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.pURCHASEDATEDataGridViewTextBoxColumn.HeaderText = "구매일자";
            this.pURCHASEDATEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pURCHASEDATEDataGridViewTextBoxColumn.Name = "pURCHASEDATEDataGridViewTextBoxColumn";
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
            // pURCHASEITEMVIEWBindingSource
            // 
            this.pURCHASEITEMVIEWBindingSource.DataMember = "PURCHASE_ITEM_VIEW";
            this.pURCHASEITEMVIEWBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 714);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1556, 304);
            this.panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("굴림", 18F);
            this.textBox1.Location = new System.Drawing.Point(0, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1556, 243);
            this.textBox1.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("굴림", 15F);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 50;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(1556, 61);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "해당 상품의 한줄후기 남기기 Click!";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1556, 77);
            this.panel2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("굴림", 20F);
            this.dateTimePicker1.Font = new System.Drawing.Font("굴림", 20F);
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(492, 53);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.SkyBlue;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("굴림", 15F);
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 38;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(664, 5);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton3.Size = new System.Drawing.Size(279, 66);
            this.iconButton3.TabIndex = 10;
            this.iconButton3.Text = "구매 확정하기";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.OrangeRed;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("굴림", 15F);
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 38;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(964, 5);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(279, 66);
            this.iconButton2.TabIndex = 7;
            this.iconButton2.Text = "환불 신청하기";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // purchaseTableAdapter1
            // 
            this.purchaseTableAdapter1.ClearBeforeFill = true;
            // 
            // refundTableAdapter1
            // 
            this.refundTableAdapter1.ClearBeforeFill = true;
            // 
            // reviewTableAdapter1
            // 
            this.reviewTableAdapter1.ClearBeforeFill = true;
            // 
            // purchasE_ITEM_VIEWTableAdapter1
            // 
            this.purchasE_ITEM_VIEWTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3_Purchase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1556, 1018);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form3_Purchase";
            this.Text = "Form3_Purchase";
            this.Load += new System.EventHandler(this.Form3_Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEITEMVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.PURCHASETableAdapter purchaseTableAdapter1;
        private DataSet1TableAdapters.REFUNDTableAdapter refundTableAdapter1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private DataSet1TableAdapters.REVIEWTableAdapter reviewTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARTITEMCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pURCHASEITEMVIEWBindingSource;
        private DataSet1TableAdapters.PURCHASE_ITEM_VIEWTableAdapter purchasE_ITEM_VIEWTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMCATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pURCHASEITEMCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pURCHASEPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pURCHASEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sELLERIDDataGridViewTextBoxColumn;
    }
}