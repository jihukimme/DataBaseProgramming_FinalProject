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
    public partial class Form3_Cart : Form
    {

        DataTable mytable1;
        DataTable mytable2;
        DataTable mytable3;
        string customer_id;

        public Form3_Cart(string id)
        {
            InitializeComponent();

            cartTableAdapter1.Fill(dataSet11.CART); // DataSet의 seller 테이블 채우기
            mytable1 = dataSet11.Tables["CART"];
            itemTableAdapter1.Fill(dataSet11.ITEM); // DataSet의 seller 테이블 채우기
            mytable2 = dataSet11.Tables["ITEM"];
            purchaseTableAdapter1.Fill(dataSet11.PURCHASE); // DataSet의 seller 테이블 채우기
            mytable3 = dataSet11.Tables["PURCHASE"];

            customer_id = id;
        }

        private void Form3_Cart_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.PURCHASE_ITEM_VIEW' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.carT_ITEM_VIEWTableAdapter1.Fill(this.dataSet11.CART_ITEM_VIEW);

            //해당 customer_id의 장바구니만 보여줌.
            cARTITEMVIEWBindingSource.Filter = $"CUSTOMER_ID = '{customer_id}'";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = true;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            //장바구니 담은 상품 삭제
            // 사용자에게 삭제를 확인하는 메시지를 보여줍니다.
            DialogResult dialogResult = MessageBox.Show("정말로 선택한 상품을 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // 선택된 모든 행의 ITEM_ID를 가져와 CART 테이블에서 찾아 삭제합니다.
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string itemId = row.Cells["ITEM_ID"].Value.ToString();  // ITEM_ID 컬럼명이 실제 컬럼명과 일치하는지 확인해주세요.
                    DataRow[] rowsToDelete = mytable1.Select($"ITEM_ID = '{itemId}'");  // ITEM_ID 필드명이 실제 필드명과 일치하는지 확인해주세요.

                    foreach (DataRow rowToDelete in rowsToDelete)
                    {
                        rowToDelete.Delete();
                    }
                }

                // 데이터베이스에 변경 사항을 반영합니다.
                cartTableAdapter1.Update(dataSet11.CART);

                // DataGridView에 변경된 내용을 반영하기 위해 데이터를 다시 로드합니다.
                this.carT_ITEM_VIEWTableAdapter1.Fill(this.dataSet11.CART_ITEM_VIEW);
            }
            else if (dialogResult == DialogResult.No)
            {
                // 삭제를 취소합니다.
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //장바구니에 담은 상품 구매
            // 사용자에게 구매를 확인하는 메시지를 보여줍니다.
            DialogResult dialogResult = MessageBox.Show("정말로 선택한 상품을 구매하시겠습니까?", "구매 확인", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // 선택된 모든 행의 ITEM_ID를 가져와 PURCHASE 테이블에 추가하고 ITEM 테이블의 ITEM_COUNT를 업데이트합니다.
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string itemId = row.Cells["ITEM_ID"].Value.ToString();

                    // PURCHASE 테이블에서 CUSTOMER_ID와 ITEM_ID를 확인합니다.
                    DataRow[] existingPurchases = mytable3.Select($"CUSTOMER_ID = '{customer_id}' AND ITEM_ID = '{itemId}'");
                    if (existingPurchases.Length > 0)
                    {
                        MessageBox.Show("이미 구매한 상품입니다.");
                        continue;  // 이미 구매한 상품이므로 다음 상품으로 넘어갑니다.
                    }

                    // CART 테이블에서 CART_ITEM_COUNT를 가져옵니다.
                    DataRow[] cartRow = mytable1.Select($"ITEM_ID = '{itemId}'");
                    int cartItemCount = Convert.ToInt32(cartRow[0]["CART_ITEM_COUNT"]);

                    // ITEM 테이블의 ITEM_COUNT를 업데이트합니다.
                    DataRow[] itemRow = mytable2.Select($"ITEM_ID = '{itemId}'");
                    itemRow[0]["ITEM_COUNT"] = Convert.ToInt32(itemRow[0]["ITEM_COUNT"]) - cartItemCount;

                    //ITEM 테이블에서 ITEM_PRICE를 가져옵니다.
                    int cartItemPrice = Convert.ToInt32(itemRow[0]["ITEM_PRICE"]);

                    // PURCHASE 테이블에 데이터를 추가합니다.
                    DataRow purchaseRow = mytable3.NewRow();
                    purchaseRow["CUSTOMER_ID"] = customer_id;
                    purchaseRow["ITEM_ID"] = itemId;
                    purchaseRow["PURCHASE_PRICE"] = cartItemPrice;
                    purchaseRow["PURCHASE_ITEM_COUNT"] = cartItemCount;
                    mytable3.Rows.Add(purchaseRow);

                    
                    //장바구니에서 삭제
                    cartRow[0].Delete();
                }

                // 데이터베이스에 변경 사항을 반영합니다.
                purchaseTableAdapter1.Update(dataSet11.PURCHASE);
                itemTableAdapter1.Update(dataSet11.ITEM);
                cartTableAdapter1.Update(dataSet11.CART); // 장바구니에서 해당 상품을 삭제한 후, 데이터베이스에 변경사항을 반영합니다.


                // DataGridView에 변경된 내용을 반영하기 위해 데이터를 다시 로드합니다.
                this.carT_ITEM_VIEWTableAdapter1.Fill(this.dataSet11.CART_ITEM_VIEW);
            }
            else if (dialogResult == DialogResult.No)
            {
                // 구매를 취소합니다.
            }
        }
    }
}
