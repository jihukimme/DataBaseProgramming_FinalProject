using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5584639_FinalProject
{
    public partial class Form1 : Form
    {

        DataTable mytable1;
        DataTable mytable2;
        DataTable mytable3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customerTableAdapter1.Fill(dataSet11.CUSTOMER); // DataSet의 customer 테이블 채우기
            sellerTableAdapter1.Fill(dataSet11.SELLER); // DataSet의 seller 테이블 채우기
            adminTableAdapter1.Fill(dataSet11.ADMIN); // DataSet의 ADMIN 테이블 채우기
                                                        // connection이 close 된 상태에서 다음과 같이 DataSet의 사용
            mytable1 = dataSet11.Tables["CUSTOMER"];
            mytable2 = dataSet11.Tables["SELLER"];
            mytable3 = dataSet11.Tables["ADMIN"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filter = String.Format("ADMIN_ID = '{0}' AND ADMIN_PASSWORD = '{1}'", textBox5.Text, textBox6.Text);
            DataRow[] foundRows = mytable3.Select(filter);

            if (foundRows.Length > 0)
            {
                MessageBox.Show("로그인 성공");
                //관리자 폼 열기
                Form5 form5 = new Form5();
                form5.Show();

                textBox5.Clear();
                textBox6.Clear();
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filter = String.Format("CUSTOMER_ID = '{0}' AND CUSTOMER_PASSWORD = '{1}'", textBox1.Text, textBox2.Text);
            DataRow[] foundRows = mytable1.Select(filter);

            if (foundRows.Length > 0)
            {
                MessageBox.Show("로그인 성공");
                //회원 폼 열기
                Form3 form3 = new Form3(textBox1.Text);
                form3.Show();

                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filter = String.Format("SELLER_ID = '{0}' AND SELLER_PASSWORD = '{1}'", textBox3.Text, textBox4.Text);
            DataRow[] foundRows = mytable2.Select(filter);

            if (foundRows.Length > 0)
            {
                MessageBox.Show("로그인 성공");
                //판매자 폼 열기
                Form4 form4 = new Form4(textBox3.Text);
                form4.Show();

                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //회원가입 폼 열기
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        public void RefreshData()
        {
            // 로그인 정보를 갱신하는 코드를 작성하세요.
            // 예를 들면, 다음과 같이 DataTable을 다시 로드하는 코드를 사용할 수 있습니다.
            this.customerTableAdapter1.Fill(this.dataSet11.CUSTOMER);
            this.sellerTableAdapter1.Fill(this.dataSet11.SELLER);
        }
    }
}
