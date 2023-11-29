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
    public partial class Form5_ItemManagement : Form
    {
        DataTable mytable1;
        DataTable mytable2;

        public Form5_ItemManagement()
        {
            InitializeComponent();

            itemTableAdapter1.Fill(dataSet11.ITEM); // DataSet의 seller 테이블 채우기
            mytable1 = dataSet11.Tables["ITEM"];
            announcementTableAdapter1.Fill(dataSet11.ANNOUNCEMENT); // DataSet의 seller 테이블 채우기
            mytable2 = dataSet11.Tables["ANNOUNCEMENT"];
        }

        private void Form5_ItemManagement_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.ITEM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.itemTableAdapter1.Fill(this.dataSet11.ITEM);
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
       
        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            //삭제
            DialogResult dialogResult = MessageBox.Show("정말 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.iTEMBindingSource.RemoveCurrent();
                MessageBox.Show("해당 상품이 삭제되었습니다.");
            }
            else if (dialogResult == DialogResult.No)
            {
                //삭제하지 않음
            }

            itemTableAdapter1.Update(dataSet11.ITEM);
            // DataGridView에 변경된 내용을 반영하기 위해 데이터를 다시 로드합니다.
            this.itemTableAdapter1.Fill(this.dataSet11.ITEM);
        }

        private bool isNewItem;
        private string prevPrice;
        private string changedPrice;
       
        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            //입력
            this.iTEMBindingSource.AddNew();
            isNewItem = true; // 새로운 행을 추가했음을 표시합니다.
        }
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            //저장
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("선택된 행이 없습니다.");
                return;
            }

            string itemId = dataGridView1.CurrentRow.Cells["ITEM_ID"].Value.ToString();

            try
            {
                this.iTEMBindingSource.EndEdit();
                int ret = this.itemTableAdapter1.Update(this.dataSet11.ITEM);

                // mytable1에 최신 데이터를 로드합니다.
                this.itemTableAdapter1.Fill(this.dataSet11.ITEM);

                if (ret >= 0)
                    MessageBox.Show("업데이트 성공!");
                else
                    MessageBox.Show("업데이트 실패: 데이터를 정확하게 입력하세요!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("업데이트 실패: " + ex.Message);
            }

            itemTableAdapter1.Update(dataSet11.ITEM);
            // DataGridView에 변경된 내용을 반영하기 위해 데이터를 다시 로드합니다.
            this.itemTableAdapter1.Fill(this.dataSet11.ITEM);
        }
        

       
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 4) // 가정: ITEM_PRICE가 4번째 컬럼인 경우
            {
                prevPrice = dataGridView1.CurrentRow.Cells[e.ColumnIndex].Value.ToString();
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.EndEdit(); // 편집을 끝내고 변경 내용을 커밋합니다.

            if (e.ColumnIndex == 4) // 가정: ITEM_PRICE가 4번째 컬럼인 경우
            {
                changedPrice = dataGridView1.CurrentRow.Cells[e.ColumnIndex].Value.ToString();

                string itemName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (string.Compare(prevPrice, changedPrice) != 0 && !string.IsNullOrEmpty(prevPrice))
                {
                    DataRow announcementRow = mytable2.NewRow();
                    announcementRow["CURRENT_TIME"] = DateTime.Now;
                    announcementRow["TITLE"] = "가격변경 공지";
                    announcementRow["CONTENT"] = itemName + "의 가격이 " + prevPrice + "원에서 " + changedPrice + "원으로 변경되었습니다.";

                    mytable2.Rows.Add(announcementRow);
                    // 데이터베이스에 변경 사항을 반영합니다.
                    announcementTableAdapter1.Update(dataSet11.ANNOUNCEMENT);
                    // mytable2에 최신 데이터를 로드합니다.
                    announcementTableAdapter1.Fill(dataSet11.ANNOUNCEMENT);
                }
            }
        }
         private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (isNewItem && e.ColumnIndex == 2) // 가정: ITEM_NAME이 2번째 컬럼인 경우
            {
                string itemName = dataGridView1.CurrentRow.Cells[e.ColumnIndex].Value.ToString();

                DataRow announcementRow = mytable2.NewRow();
                announcementRow["CURRENT_TIME"] = DateTime.Now;
                announcementRow["TITLE"] = "상품입고 공지";
                announcementRow["CONTENT"] = itemName + "가 새로 추가되었습니다.";

                mytable2.Rows.Add(announcementRow);
                // 데이터베이스에 변경 사항을 반영합니다.
                announcementTableAdapter1.Update(dataSet11.ANNOUNCEMENT);
                // mytable2에 최신 데이터를 로드합니다.
                announcementTableAdapter1.Fill(dataSet11.ANNOUNCEMENT);

                isNewItem = false; // 새로운 행 추가 상태를 초기화합니다.
            }
        }

        
    }
}
