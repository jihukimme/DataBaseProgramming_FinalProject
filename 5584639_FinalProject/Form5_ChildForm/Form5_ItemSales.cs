using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5584639_FinalProject.Form5_ChildForm
{
    public partial class Form5_ItemSales : Form
    {
        DataTable mytable1;

        public Form5_ItemSales()
        {
            InitializeComponent();

            itemTableAdapter1.Fill(dataSet11.ITEM); // DataSet의 seller 테이블 채우기
            mytable1 = dataSet11.Tables["ITEM"];
        }
        private void Form5_ItemSales_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.ITEM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.itemTableAdapter1.Fill(this.dataSet11.ITEM);

            // TODO: 이 코드는 데이터를 'dataSet1.VIEW21' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.purchasE_REFUND_COUNT_SUMTableAdapter1.Fill(this.dataSet11.PURCHASE_REFUND_COUNT_SUM);

            DataView dv = new DataView(this.dataSet11.PURCHASE_REFUND_COUNT_SUM);

            // 합계를 계산합니다.
            int totalPurchaseCount = 0;
            int totalRefundCount = 0;

            foreach (DataRowView rowView in dv)
            {
                DataRow row = rowView.Row;

                // NULL 값은 0으로 처리합니다.
                int purchaseCount = row["TOTAL_PURCHASE_COUNT"] == DBNull.Value ? 0 : Convert.ToInt32(row["TOTAL_PURCHASE_COUNT"]);
                int refundCount = row["TOTAL_REFUND_COUNT"] == DBNull.Value ? 0 : Convert.ToInt32(row["TOTAL_REFUND_COUNT"]);

                totalPurchaseCount += purchaseCount;
                totalRefundCount += refundCount;
            }

            // 합계를 표시합니다.
            label4.Text = totalPurchaseCount.ToString();
            label5.Text = totalRefundCount.ToString();
        }
        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            //검색
            if (iTEMBindingSource.Filter != null)
            {
                iTEMBindingSource.RemoveFilter();
                iconButton3.Text = "검색";
            }
            else
            {
                // 문자열 타입의 모든 컬럼에 대해 textBox1.Text를 포함하는지 검사하여 필터를 만듭니다.
                var textColumns = mytable1.Columns.Cast<DataColumn>()
                    .Where(col => col.DataType == typeof(string))
                    .Select(col => $"{col.ColumnName} LIKE '%{textBox1.Text}%'");

                string filter = string.Join(" OR ", textColumns);

                // 만약 textBox1.Text를 포함하는 데이터가 있다면 해당 행을 필터링합니다.
                if (mytable1.AsEnumerable().Any(row => row.ItemArray.Any(item => item.ToString().Contains(textBox1.Text))))
                {
                    iTEMBindingSource.Filter = filter;
                    iconButton3.Text = "검색해제";
                }
                else
                {
                    // 포함하는 데이터가 없으면 메시지를 표시합니다.
                    MessageBox.Show("일치하는 상품이 없습니다.");
                    textBox1.Clear();
                }
            }
        }
        
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            //상품 판매액 검색
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("상품판매액을 보려면 셀을 선택하고 실행해주세요.");
            }

            // 현재 선택된 행의 'ITEM_ID' 값을 가져옵니다.
            string itemId = dataGridView1.CurrentRow.Cells["ITEM_ID"].Value.ToString();

            DateTime dateTime1 = dateTimePicker1.Value;
            DateTime dateTime2 = dateTimePicker2.Value;

            DataView dv = new DataView(this.dataSet11.PURCHASE_REFUND_COUNT_SUM);
            dv.RowFilter = $"CHART_DATE >= #{dateTime1:M/dd/yyyy}# AND CHART_DATE <= #{dateTime2:M/dd/yyyy}# AND ITEM_ID = '{itemId}'";

            // 합계를 계산합니다.
            int totalPurchaseCount = 0;
            int totalRefundCount = 0;

            foreach (DataRowView rowView in dv)
            {
                DataRow row = rowView.Row;

                // NULL 값은 0으로 처리합니다.
                int purchaseCount = row["TOTAL_PURCHASE_COUNT"] == DBNull.Value ? 0 : Convert.ToInt32(row["TOTAL_PURCHASE_COUNT"]);
                int refundCount = row["TOTAL_REFUND_COUNT"] == DBNull.Value ? 0 : Convert.ToInt32(row["TOTAL_REFUND_COUNT"]);

                totalPurchaseCount += purchaseCount;
                totalRefundCount += refundCount;
            }

            // 합계를 표시합니다.
            label4.Text = totalPurchaseCount.ToString();
            label5.Text = totalRefundCount.ToString();

            // 차트의 데이터 소스를 설정합니다.
            chart1.DataSource = dv;


            // 차트를 다시 그립니다.
            chart1.DataBind();
        }
       

       
    }
}
