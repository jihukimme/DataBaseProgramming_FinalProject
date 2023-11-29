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


    public partial class Form3_Item : Form
    {
    
        DataTable mytable1;
        DataTable mytable2;
        DataTable mytable3;

        string customer_id;

        public Form3_Item(string id)
        {
            InitializeComponent();

            customer_id = id;

            cartTableAdapter1.Fill(dataSet11.CART); // DataSet의 seller 테이블 채우기
            mytable1 = dataSet11.Tables["CART"];
            itemTableAdapter1.Fill(dataSet11.ITEM); // DataSet의 seller 테이블 채우기
            mytable2 = dataSet11.Tables["ITEM"];
            reviewTableAdapter1.Fill(dataSet11.REVIEW); // DataSet의 seller 테이블 채우기
            mytable3 = dataSet11.Tables["REVIEW"];

        }

        private void Form3_Item_Load(object sender, EventArgs e)
        {
            this.itemTableAdapter1.Fill(this.dataSet11.ITEM);

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            //상품검색
            if (iTEMBindingSource.Filter != null)
            {
                iTEMBindingSource.RemoveFilter();
                iconButton3.Text = "검색";
            }
            else
            {
                // 문자열 타입의 모든 컬럼에 대해 textBox1.Text를 포함하는지 검사하여 필터를 만듭니다.
                var textColumns = mytable2.Columns.Cast<DataColumn>()
                    .Where(col => col.DataType == typeof(string))
                    .Select(col => $"{col.ColumnName} LIKE '%{textBox1.Text}%'");

                string filter = string.Join(" OR ", textColumns);

                // 만약 textBox1.Text를 포함하는 데이터가 있다면 해당 행을 필터링합니다.
                if (mytable2.AsEnumerable().Any(row => row.ItemArray.Any(item => item.ToString().Contains(textBox1.Text))))
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //장바구니 담기
            // DataGridView에서 선택한 행을 가져옵니다.
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;


            // 선택한 행이 없으면 함수를 종료합니다.
            if (selectedRow == null) return;

            // 선택한 행에서 ITEM_ID를 가져옵니다.
            string item_id = selectedRow.Cells["ITEM_ID"].Value.ToString();

            // ITEM 테이블에서 item_id와 일치하는 ITEM_COUNT 값을 가져옵니다.
            DataRow[] itemRows = mytable2.Select($"ITEM_ID = '{item_id}'");
            if (itemRows.Length == 0)
            {
                MessageBox.Show("해당 아이템을 찾을 수 없습니다.");
                return;
            }
            int item_count = Convert.ToInt32(itemRows[0]["ITEM_COUNT"]);


            // textBox2에서 아이템의 수량을 가져옵니다.
            if (!int.TryParse(textBox2.Text, out int CartItemCount))
            {
                MessageBox.Show("상품의 수량이 올바르지 않습니다.");
                return;
            }

            // ITEM_COUNT가 CartItemCount보다 적을 경우 장바구니에 담을 수 없습니다.
            if (item_count < CartItemCount)
            {
                MessageBox.Show("재고가 부족합니다.");
                return;
            }

            // CUSTOMER_ID와 ITEM_ID를 키로 갖는 CART table에서 중복되는 값이 있는지 확인합니다.
            DataRow[] existingRows = mytable1.Select($"CUSTOMER_ID = '{customer_id}' AND ITEM_ID = '{item_id}'");

            // 중복되는 값이 없으면 CART table에 추가합니다.
            if (existingRows.Length == 0)
            {
                DataRow newRow = mytable1.NewRow();
                newRow["CUSTOMER_ID"] = customer_id;
                newRow["ITEM_ID"] = item_id;
                newRow["CART_ITEM_COUNT"] = CartItemCount;
                mytable1.Rows.Add(newRow);

                // 변경사항을 데이터베이스에 반영합니다.
                cartTableAdapter1.Update(dataSet11.CART);

                MessageBox.Show("장바구니에 담았습니다.");
                textBox2.Clear();
            }
            else
            {
                // 중복되는 값이 있으면 이미 cart에 담겨있다는 메시지를 출력합니다.
                MessageBox.Show("이미 장바구니에 담긴 상품입니다.");
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //선택한 상품의 후기 보기
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;


            // 선택한 행이 없으면 함수를 종료합니다.
            if (selectedRow == null) return;

            // 선택한 행에서 ITEM_ID를 가져옵니다.
            string item_id = selectedRow.Cells["ITEM_ID"].Value.ToString();

            // REVIEW 테이블에서 item_id와 일치하는 REVIEW_CONTENT 값을 가져옵니다.
            DataRow[] reviewRows = mytable3.Select($"ITEM_ID = '{item_id}'");
            if (reviewRows.Length == 0)
            {
                MessageBox.Show("해당 아이템에 등록된 리뷰가 없습니다.");
                return;
            }

            // ListBox를 초기화합니다.
            listBox1.Items.Clear();

            // 리뷰를 ListBox에 추가합니다.
            foreach (DataRow row in reviewRows)
            {
                string customer_id = row["CUSTOMER_ID"].ToString();
                string review_content = row["REVIEW_CONTENT"].ToString();
                listBox1.Items.Add($"고객 ID: {customer_id} - 후기: {review_content}");
            }
        }
    }
}
