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
    public partial class Form2 : Form
    {
        DataTable mytable1;
        DataTable mytable2;

        Form1 form1; // Form1의 인스턴스를 저장할 필드

        public Form2(Form1 form1)
        {
            InitializeComponent();

            this.form1 = form1; // Form1의 인스턴스를 저장
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            customerTableAdapter1.Fill(dataSet11.CUSTOMER); // DataSet의 customer 테이블 채우기
            sellerTableAdapter1.Fill(dataSet11.SELLER); // DataSet의 seller 테이블 채우기

            mytable1 = dataSet11.Tables["CUSTOMER"];
            mytable2 = dataSet11.Tables["SELLER"];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filter = String.Format("CUSTOMER_ID = '{0}'", textBox1.Text);
            DataRow[] foundRows = mytable1.Select(filter);

            if (foundRows.Length > 0)
            {
                // textBox1.Text와 일치하는 CUSTOMER_ID를 가진 행이 있다면, 
                // foundRows는 해당 행(들)을 참조합니다. 
                MessageBox.Show("이미 존재하는 ID입니다. 다른 ID를 입력해주세요.");
            }
            else
            {
                // textBox1.Text와 일치하는 CUSTOMER_ID를 가진 행이 없다면, 
                // 새로운 회원 정보를 추가합니다.
                DataRow newRow = mytable1.NewRow();
                newRow["CUSTOMER_ID"] = textBox1.Text;
                newRow["CUSTOMER_PASSWORD"] = textBox2.Text;
                newRow["CUSTOMER_NAME"] = textBox3.Text;
                newRow["CUSTOMER_RATING"] = "일반";
                mytable1.Rows.Add(newRow);

                // DataSet을 데이터베이스에 반영합니다.
                customerTableAdapter1.Update(dataSet11.CUSTOMER);

                customerTableAdapter1.Fill(dataSet11.CUSTOMER); // DataSet의 customer 테이블 채우기

                MessageBox.Show("회원가입이 완료되었습니다.");
            }

            // 회원가입이 완료되면 Form1의 DataTable을 갱신
            form1.RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filter = String.Format("SELLER_ID = '{0}'", textBox4.Text);
            DataRow[] foundRows = mytable2.Select(filter);

            if (foundRows.Length > 0)
            {
                // textBox1.Text와 일치하는 CUSTOMER_ID를 가진 행이 있다면, 
                // foundRows는 해당 행(들)을 참조합니다. 
                MessageBox.Show("이미 존재하는 ID입니다. 다른 ID를 입력해주세요.");
            }
            else
            {
                // textBox1.Text와 일치하는 CUSTOMER_ID를 가진 행이 없다면, 
                // 새로운 회원 정보를 추가합니다.
                DataRow newRow = mytable2.NewRow();
                newRow["SELLER_ID"] = textBox4.Text;
                newRow["SELLER_PASSWORD"] = textBox5.Text;
                newRow["SELLER_NAME"] = textBox6.Text;
                mytable2.Rows.Add(newRow);

                // DataSet을 데이터베이스에 반영합니다.
                sellerTableAdapter1.Update(dataSet11.SELLER);

                sellerTableAdapter1.Fill(dataSet11.SELLER); // DataSet의 seller 테이블 채우기

                MessageBox.Show("회원가입이 완료되었습니다.");
            }

            // 회원가입이 완료되면 Form1의 DataTable을 갱신
            form1.RefreshData();
        }
    }
}
