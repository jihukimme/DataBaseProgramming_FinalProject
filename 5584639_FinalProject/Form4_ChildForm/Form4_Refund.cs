using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5584639_FinalProject.Form4_ChildForm
{
    public partial class Form4_Refund : Form
    {

        string seller_id;
        DataTable mytable1;
        DataTable mytable2;
        DataTable mytable3;
        public Form4_Refund(string id)
        {
            InitializeComponent();

            seller_id = id;

            refundTableAdapter1.Fill(dataSet11.REFUND); // DataSet의 seller 테이블 채우기
            mytable1 = dataSet11.Tables["REFUND"];
            purchaseTableAdapter1.Fill(dataSet11.PURCHASE);
            mytable2 = dataSet11.Tables["PURCHASE"];
            itemTableAdapter1.Fill(dataSet11.ITEM);
            mytable3 = dataSet11.Tables["ITEM"];
        }

        private void Form4_Refund_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.PURCHASE_ITEM_VIEW' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.refunD_ITEM_VIEWTableAdapter1.Fill(this.dataSet11.REFUND_ITEM_VIEW);

            //해당 seller_id의 구매내역만 보여줌.
            rEFUNDITEMVIEWBindingSource.Filter = $"SELLER_ID = '{seller_id}'";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // 환불승인 정보 업데이트
            if (dataGridView1.CurrentRow != null)
            {
                // 현재 선택된 행의 'CUSTOMER_ID', 'ITEM_ID', 'REFUND_ALLOW' 셀 값을 가져옵니다.
                string itemId = dataGridView1.CurrentRow.Cells["ITEM_ID"].Value.ToString();
                string customerId = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                // REFUND 테이블에서 해당 ITEM_ID를 가져옵니다.
                DataRow[] refundRow = mytable1.Select($"CUSTOMER_ID = '{customerId}' AND ITEM_ID = '{itemId}'");
                string refundAllow = comboBox1.Text; //콤보박스에서 선택한 값 사용
                string customer_refundAllow = refundRow[0]["REFUND_ALLOW"].ToString();
                int refundItemCount = Convert.ToInt32(refundRow[0]["REFUND_ITEM_COUNT"]);

                //환불승인한 상품을 다시 대기상태로 바꿀려고 할 경우
                if (customer_refundAllow == "승인")
                {
                    MessageBox.Show("이미 환불승인한 상품의 처리를 바꿀 수 없습니다.");
                    return;
                }

                // 콤보박스에서 아무런 값을 선택하지 않았을 경우
                if (string.IsNullOrEmpty(refundAllow))
                {
                    MessageBox.Show("환불승인 상태를 선택 후 진행해주세요.");
                    return;
                }

                // 'REFUND' 테이블에서 해당 'CUSTOMER_ID'와 'ITEM_ID'를 가지는 행을 찾습니다.
                DataRow[] rows = dataSet11.Tables["REFUND"].Select($"CUSTOMER_ID = '{customerId}' AND ITEM_ID = '{itemId}'");

                // 해당 행의 'REFUND_ALLOW' 값을 DataGridView에서 선택한 값으로 업데이트합니다.
                foreach (DataRow row in rows)
                {
                    row["REFUND_ALLOW"] = refundAllow;
                }

                // 콤보박스에서 '승인'을 선택한 경우
                if (refundAllow == "승인")
                {
                    string filter = String.Format($"CUSTOMER_ID = '{customerId}' AND ITEM_ID = '{itemId}'");
                    DataRow[] foundRows = mytable2.Select(filter);

                    if (foundRows.Length > 0)
                    {
                        DataRow purchaseRefundRow = foundRows[0];
                        purchaseRefundRow.Delete();

                        // ITEM 테이블의 ITEM_COUNT를 업데이트합니다.
                        DataRow[] itemRow = mytable3.Select($"ITEM_ID = '{itemId}'");
                        itemRow[0]["ITEM_COUNT"] = Convert.ToInt32(itemRow[0]["ITEM_COUNT"]) + refundItemCount;

                        // DataSet을 데이터베이스에 반영합니다.
                        purchaseTableAdapter1.Update(dataSet11.PURCHASE);
                        itemTableAdapter1.Update(dataSet11.ITEM);

                        MessageBox.Show("상품이 환불되었습니다.");
                    }
                }

                // 변경 사항을 DataSet에 적용합니다.
                this.refundTableAdapter1.Update(this.dataSet11.REFUND);
                //this.purchaseTableAdapter1.Update(this.dataSet11.PURCHASE);
                MessageBox.Show("환불승인 상태가 업데이트 되었습니다.");

                // DataGridView를 다시 로드합니다.
                this.refunD_ITEM_VIEWTableAdapter1.Fill(this.dataSet11.REFUND_ITEM_VIEW);
            }
            else
            {
                // 셀이 선택되지 않았을 때 메시지 표시
                MessageBox.Show("승인 상태를 변경하려면 셀을 선택하고 실행해주세요.");
            }
        }
    }
}
