using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5584639_FinalProject.Form3_ChildForm
{
    public partial class Form3_Purchase : Form
    {

        DataTable mytable1;
        DataTable mytable2;
        DataTable mytable3;
        string customer_id;

        public Form3_Purchase(string id)
        {
            InitializeComponent();

            purchaseTableAdapter1.Fill(dataSet11.PURCHASE); // DataSet의 seller 테이블 채우기
            mytable1 = dataSet11.Tables["PURCHASE"];
            refundTableAdapter1.Fill(dataSet11.REFUND); // DataSet의 seller 테이블 채우기
            mytable2 = dataSet11.Tables["REFUND"];
            reviewTableAdapter1.Fill(dataSet11.REVIEW); // DataSet의 seller 테이블 채우기
            mytable3 = dataSet11.Tables["REVIEW"];

            customer_id = id;
        }
        private void Form3_Purchase_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.PURCHASE_ITEM_VIEW' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.purchasE_ITEM_VIEWTableAdapter1.Fill(this.dataSet11.PURCHASE_ITEM_VIEW);

            //해당 customer_id의 구매내역만 보여줌.
            pURCHASEITEMVIEWBindingSource.Filter = $"CUSTOMER_ID = '{customer_id}'";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //환불신청하기
            DialogResult dialogResult = MessageBox.Show("선택한 상품을 환불신청 하시겠습니까?", "환불신청 확인", MessageBoxButtons.YesNo);

            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            // 선택한 행에서 ITEM_ID를 가져옵니다.
            string itemId = selectedRow.Cells["ITEM_ID"].Value.ToString();

            // PURCHASE 테이블에서 PURCHASE_ITEM_COUNT를 가져옵니다.
            DataRow[] purchaseRow = mytable1.Select($"CUSTOMER_ID = '{customer_id}' AND ITEM_ID = '{itemId}'");
            int purchaseItemCount = Convert.ToInt32(purchaseRow[0]["PURCHASE_ITEM_COUNT"]);
            int purchasePrice = Convert.ToInt32(purchaseRow[0]["PURCHASE_PRICE"]);

            // PURCHASE 테이블에서 PURCHASE_DATE를 가져옵니다.
            string purchaseDate = purchaseRow[0]["PURCHASE_DATE"].ToString();

            if (string.IsNullOrEmpty(purchaseDate))
            {
                MessageBox.Show("구매일자 선택 후 구매확정을 한 후에 환불신청을 해주세요.");
                return;
            }

            if (dialogResult == DialogResult.Yes)
            {
                // REFUND 테이블에서 CUSTOMER_ID와 ITEM_ID를 확인합니다.
                DataRow[] existingRefunds = mytable2.Select($"CUSTOMER_ID = '{customer_id}' AND ITEM_ID = '{itemId}'");
                if (existingRefunds.Length > 0)
                {
                    MessageBox.Show("이미 환불 신청한 상품입니다.");
                    return;  // 이미 환불 신청한 상품이므로 함수를 종료합니다.
                }

                DataRow refundRow = mytable2.NewRow();
                refundRow["CUSTOMER_ID"] = customer_id;
                refundRow["ITEM_ID"] = itemId;
                refundRow["REFUND_ITEM_COUNT"] = purchaseItemCount;
                refundRow["REFUND_PRICE"] = purchasePrice;
                refundRow["REFUND_DATE"] = purchaseDate;
                mytable2.Rows.Add(refundRow);

                // 데이터베이스에 변경 사항을 반영합니다.
                refundTableAdapter1.Update(dataSet11.REFUND);

                // 환불 신청이 완료되었다는 메시지를 출력합니다.
                MessageBox.Show("환불 신청이 완료되었습니다.");
            }
            else if (dialogResult == DialogResult.No)
            {
                // 환불 신청을 취소합니다.
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            //구매확정하기 = 저장하기
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            string itemId = selectedRow.Cells["ITEM_ID"].Value.ToString();
            DateTime selectedDate = dateTimePicker1.Value.Date;  // dateTimePicker1에서 선택한 날짜를 가져옵니다.

            // 해당 사용자와 ITEM_ID를 가진 행을 PURCHASE 테이블에서 찾습니다.
            DataRow[] purchaseRows = mytable1.Select($"CUSTOMER_ID = '{customer_id}' AND ITEM_ID = '{itemId}'");

            if (purchaseRows.Length > 0)
            {
                DataRow purchaseRow = purchaseRows[0];  // 첫 번째 행을 가져옵니다.
                purchaseRow["PURCHASE_DATE"] = selectedDate;  // 해당 행의 PURCHASE_DATE를 업데이트합니다.

                try
                {
                    purchaseTableAdapter1.Update(dataSet11.PURCHASE);  // 업데이트된 내용을 PURCHASE 테이블에 반영합니다.
                    MessageBox.Show("구매 확정 성공!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("구매 확정 실패");
                }
            }
            else
            {
                MessageBox.Show("해당 상품을 찾을 수 없습니다.");
            }

            // 아래 라인은 PURCHASE 테이블에 변경 사항을 반영한 후에 추가합니다.
            this.purchasE_ITEM_VIEWTableAdapter1.Fill(this.dataSet11.PURCHASE_ITEM_VIEW);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //선택한 상품의 한줄후기 남기기
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            string itemId = selectedRow.Cells["ITEM_ID"].Value.ToString();

            // 후기를 추가하기 전에 해당 사용자가 이미 해당 상품에 대해 후기를 남겼는지 검사합니다.
            DataRow[] existingReviews = mytable3.Select($"CUSTOMER_ID = '{customer_id}' AND ITEM_ID = '{itemId}'");
            if (existingReviews.Length > 0)
            {
                MessageBox.Show("이미 후기를 남기셨습니다.");
            }
            else if (textBox1.Text != null)
            {
                DataRow reviewRow = mytable3.NewRow();
                reviewRow["CUSTOMER_ID"] = customer_id;
                reviewRow["ITEM_ID"] = itemId;
                reviewRow["REVIEW_CONTENT"] = textBox1.Text;
                mytable3.Rows.Add(reviewRow);

                // 데이터베이스에 변경 사항을 반영합니다.
                reviewTableAdapter1.Update(dataSet11.REVIEW);

                // 후기 등록이 완료되었다는 메시지를 출력합니다.
                MessageBox.Show("후기가 등록되었습니다.");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("후기를 입력한 후 버튼을 눌러주세요!");
            }
        }

    }
}
