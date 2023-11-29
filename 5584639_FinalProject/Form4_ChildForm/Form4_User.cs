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
    public partial class Form4_User : Form
    {
        DataTable mytable1;
        string seller_id;
        Form4 parentForm;

        public Form4_User(string id, Form4 parentForm)
        {
            InitializeComponent();

            seller_id = id;
            this.parentForm = parentForm;
        }
        private void Form4_User_Load(object sender, EventArgs e)
        {
            sellerTableAdapter1.Fill(dataSet11.SELLER); // DataSet의 customer 테이블 채우기

            mytable1 = dataSet11.Tables["SELLER"];

            string filter = String.Format("SELLER_ID = '{0}'", seller_id);
            DataRow[] foundRows = mytable1.Select(filter);

            if (foundRows.Length > 0)
            {
                DataRow customerRow = foundRows[0];
                label5.Text = customerRow["SELLER_ID"].ToString();
                label6.Text = customerRow["SELLER_PASSWORD"].ToString();
                label7.Text = customerRow["SELLER_NAME"].ToString();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("정말 계정을 삭제하시겠습니까?", "계정 삭제", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string filter = String.Format("SELLER_ID = '{0}'", seller_id);
                DataRow[] foundRows = mytable1.Select(filter);

                if (foundRows.Length > 0)
                {
                    DataRow sellerRow = foundRows[0];
                    sellerRow.Delete();

                    // DataSet을 데이터베이스에 반영합니다.
                    sellerTableAdapter1.Update(dataSet11.SELLER);

                    MessageBox.Show("계정이 삭제되었습니다.");

                    // 이후 필요한 작업을 수행합니다.
                    // 예를 들어, Form3_User를 닫고 로그인 화면으로 돌아갈 수 있습니다.
                    this.Close();
                    parentForm.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                // 'No'를 클릭한 경우 아무 작업도 수행하지 않습니다.
            }
        }

        
    }
}
