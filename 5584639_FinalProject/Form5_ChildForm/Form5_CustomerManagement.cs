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
    public partial class Form5_CustomerManagement : Form
    {
        DataTable mytable1;

        public Form5_CustomerManagement()
        {
            InitializeComponent();

            customerTableAdapter1.Fill(dataSet11.CUSTOMER); // DataSet의 seller 테이블 채우기
            mytable1 = dataSet11.Tables["CUSTOMER"];
        }

        private void Form5_CustomerManagement_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.ITEM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.customerTableAdapter1.Fill(this.dataSet11.CUSTOMER);

            // TODO: 이 코드는 데이터를 'dataSet1.VIEW21' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.customeR_PRICE_SUMTableAdapter1.Fill(this.dataSet11.CUSTOMER_PRICE_SUM);

            DataView dv = new DataView(this.dataSet11.CUSTOMER_PRICE_SUM);

            // 합계를 계산합니다.
            int totalPurchase = 0;
            int totalRefund = 0;

            foreach (DataRowView rowView in dv)
            {
                DataRow row = rowView.Row;

                // NULL 값은 0으로 처리합니다.
                int purchase = row["TOTAL_PURCHASE_PRICE"] == DBNull.Value ? 0 : Convert.ToInt32(row["TOTAL_PURCHASE_PRICE"]);
                int refund = row["TOTAL_REFUND_PRICE"] == DBNull.Value ? 0 : Convert.ToInt32(row["TOTAL_REFUND_PRICE"]);

                totalPurchase += purchase;
                totalRefund += refund;
            }

            // 합계를 표시합니다.
            label4.Text = totalPurchase.ToString();
            label5.Text = totalRefund.ToString();
        }
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            //상품 판매액 검색
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("상품판매액을 보려면 셀을 선택하고 실행해주세요.");
            }

            // 현재 선택된 행의 'ITEM_ID' 값을 가져옵니다.
            string customerId = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            DateTime dateTime1 = dateTimePicker1.Value;
            DateTime dateTime2 = dateTimePicker2.Value;

            DataView dv = new DataView(this.dataSet11.CUSTOMER_PRICE_SUM);
            dv.RowFilter = $"CHART_DATE >= #{dateTime1:M/dd/yyyy}# AND CHART_DATE <= #{dateTime2:M/dd/yyyy}# AND CUSTOMER_ID = '{customerId}'";

            // 합계를 계산합니다.
            int totalPurchase = 0;
            int totalRefund = 0;

            foreach (DataRowView rowView in dv)
            {
                DataRow row = rowView.Row;

                // NULL 값은 0으로 처리합니다.
                int purchase = row["TOTAL_PURCHASE_PRICE"] == DBNull.Value ? 0 : Convert.ToInt32(row["TOTAL_PURCHASE_PRICE"]);
                int refund = row["TOTAL_REFUND_PRICE"] == DBNull.Value ? 0 : Convert.ToInt32(row["TOTAL_REFUND_PRICE"]);

                totalPurchase += purchase;
                totalRefund += refund;
            }

            // 합계를 표시합니다.
            label4.Text = totalPurchase.ToString();
            label5.Text = totalRefund.ToString();

            // 차트의 데이터 소스를 설정합니다.
            chart1.DataSource = dv;


            // 차트를 다시 그립니다.
            chart1.DataBind();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // 고객 등급 설정
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("고객 등급을 설정하려면 셀을 선택하고 실행해주세요.");
                return;
            }

            // 현재 선택된 행의 'CUSTOMER_ID' 값을 가져옵니다.
            string customerId = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            // 콤보박스에서 선택한 등급을 가져옵니다.
            string customerRating = comboBox1.Text;

            // 'CUSTOMER' 테이블에서 해당 'CUSTOMER_ID'를 가지는 행을 찾습니다.
            DataRow[] rows = mytable1.Select($"CUSTOMER_ID = '{customerId}'");

            // 해당 행의 'CUSTOMER_RATING' 값을 콤보박스에서 선택한 값으로 업데이트합니다.
            foreach (DataRow row in rows)
            {
                row["CUSTOMER_RATING"] = customerRating;
            }

            // 변경 사항을 데이터베이스에 반영합니다.
            customerTableAdapter1.Update(dataSet11.CUSTOMER);

            MessageBox.Show("고객 등급이 업데이트 되었습니다.");

            // DataGridView를 다시 로드합니다.
            customerTableAdapter1.Fill(dataSet11.CUSTOMER);
        }

        
    }
}
