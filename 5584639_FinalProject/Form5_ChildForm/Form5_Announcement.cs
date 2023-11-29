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
    public partial class Form5_Announcement : Form
    {
        public Form5_Announcement()
        {
            InitializeComponent();
        }

        private void Form5_Announcement_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.ITEM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.announcementTableAdapter1.Fill(this.dataSet11.ANNOUNCEMENT);

            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //공지 입력
            //입력
            this.aNNOUNCEMENTBindingSource.AddNew();
            dataGridView1.CurrentRow.Cells[1].Value = DateTime.Now;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //공지 저장
            this.announcementTableAdapter1.Update(this.dataSet11.ANNOUNCEMENT);

            try
            {
                this.aNNOUNCEMENTBindingSource.EndEdit();
                int ret = this.announcementTableAdapter1.Update(this.dataSet11.ANNOUNCEMENT);
                if (ret >= 0)
                    MessageBox.Show("업데이트 성공!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("업데이트 실패");
            }

            announcementTableAdapter1.Update(dataSet11.ANNOUNCEMENT);
            // DataGridView에 변경된 내용을 반영하기 위해 데이터를 다시 로드합니다.
            this.announcementTableAdapter1.Fill(this.dataSet11.ANNOUNCEMENT);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            //공지 삭제
            DialogResult dialogResult = MessageBox.Show("정말 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.aNNOUNCEMENTBindingSource.RemoveCurrent();
                MessageBox.Show("해당 공지가 삭제되었습니다.");
            }
            else if (dialogResult == DialogResult.No)
            {
                //삭제하지 않음
            }

            announcementTableAdapter1.Update(dataSet11.ANNOUNCEMENT);
            // DataGridView에 변경된 내용을 반영하기 위해 데이터를 다시 로드합니다.
            this.announcementTableAdapter1.Fill(this.dataSet11.ANNOUNCEMENT);
        }
    }
}
