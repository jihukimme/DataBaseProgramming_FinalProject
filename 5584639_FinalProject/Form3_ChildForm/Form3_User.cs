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
    public partial class Form3_User : Form
    {

        DataTable mytable1;
        string customer_id;
        Form3 parentForm;
        public Form3_User(string id, Form3 parentForm)
        {
            InitializeComponent();

            customer_id = id;
            this.parentForm = parentForm;
        }

        private void Form3_User_Load(object sender, EventArgs e)
        {
            customerTableAdapter1.Fill(dataSet11.CUSTOMER); // DataSet의 customer 테이블 채우기

            mytable1 = dataSet11.Tables["CUSTOMER"];

            string filter = String.Format("CUSTOMER_ID = '{0}'", customer_id);
            DataRow[] foundRows = mytable1.Select(filter);

            if (foundRows.Length > 0)
            {
                DataRow customerRow = foundRows[0];
                label5.Text = customerRow["CUSTOMER_ID"].ToString();
                label6.Text = customerRow["CUSTOMER_PASSWORD"].ToString();
                label7.Text = customerRow["CUSTOMER_NAME"].ToString();
                label8.Text = customerRow["CUSTOMER_RATING"].ToString();
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("정말 계정을 삭제하시겠습니까?", "계정 삭제", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string filter = String.Format("CUSTOMER_ID = '{0}'", customer_id);
                DataRow[] foundRows = mytable1.Select(filter);

                if (foundRows.Length > 0)
                {
                    DataRow customerRow = foundRows[0];
                    customerRow.Delete();

                    // DataSet을 데이터베이스에 반영합니다.
                    customerTableAdapter1.Update(dataSet11.CUSTOMER);

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
