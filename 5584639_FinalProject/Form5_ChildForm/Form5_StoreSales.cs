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
    public partial class Form5_StoreSales : Form
    {
        DataTable mytable1;

        public Form5_StoreSales()
        {
            InitializeComponent();

            sellerTableAdapter1.Fill(dataSet11.SELLER); // DataSet의 seller 테이블 채우기
            mytable1 = dataSet11.Tables["SELLER"];
        }

        private void Form5_StoreSales_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.ITEM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.sellerTableAdapter1.Fill(this.dataSet11.SELLER);

            // TODO: 이 코드는 데이터를 'dataSet1.VIEW21' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.storE_PRICE_SUMTableAdapter1.Fill(this.dataSet11.STORE_PRICE_SUM);

            DataView dv = new DataView(this.dataSet11.STORE_PRICE_SUM);

            // 합계를 계산합니다.
            int totalSalesSum = 0;
            int totalSalesCountSum = 0;

            foreach (DataRowView rowView in dv)
            {
                DataRow row = rowView.Row;

                // NULL 값은 0으로 처리합니다.
                int sales = row["TOTAL_SALES"] == DBNull.Value ? 0 : Convert.ToInt32(row["TOTAL_SALES"]);
                int salesCount = row["TOTAL_SALES_COUNT"] == DBNull.Value ? 0 : Convert.ToInt32(row["TOTAL_SALES_COUNT"]);

                totalSalesSum += sales;
                totalSalesCountSum += salesCount;
            }

            // 합계를 표시합니다.
            label4.Text = totalSalesSum.ToString();
            label5.Text = totalSalesCountSum.ToString();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //상품 판매액 검색
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("상품판매액을 보려면 셀을 선택하고 실행해주세요.");
            }

            // 현재 선택된 행의 'ITEM_ID' 값을 가져옵니다.
            string sellerId = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            DateTime dateTime1 = dateTimePicker1.Value;
            DateTime dateTime2 = dateTimePicker2.Value;

            DataView dv = new DataView(this.dataSet11.STORE_PRICE_SUM);
            dv.RowFilter = $"CHART_DATE >= #{dateTime1:M/dd/yyyy}# AND CHART_DATE <= #{dateTime2:M/dd/yyyy}# AND SELLER_ID = '{sellerId}'";

            // 합계를 계산합니다.
            int totalSalesSum = 0;
            int totalSalesCountSum = 0;

            foreach (DataRowView rowView in dv)
            {
                DataRow row = rowView.Row;

                // NULL 값은 0으로 처리합니다.
                int sales = row["TOTAL_SALES"] == DBNull.Value ? 0 : Convert.ToInt32(row["TOTAL_SALES"]);
                int salesCount = row["TOTAL_SALES_COUNT"] == DBNull.Value ? 0 : Convert.ToInt32(row["TOTAL_SALES_COUNT"]);

                totalSalesSum += sales;
                totalSalesCountSum += salesCount;
            }

            // 합계를 표시합니다.
            label4.Text = totalSalesSum.ToString();
            label5.Text = totalSalesCountSum.ToString();

            // 차트의 데이터 소스를 설정합니다.
            chart1.DataSource = dv;


            // 차트를 다시 그립니다.
            chart1.DataBind();
        }
    }
}
