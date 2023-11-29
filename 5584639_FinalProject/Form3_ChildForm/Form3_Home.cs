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
    public partial class Form3_Home : Form
    {

        string customer_id;
        public Form3_Home(string id)
        {
            InitializeComponent();

            customer_id = id;

            announcementTableAdapter1.Fill(dataSet11.ANNOUNCEMENT); // DataSet의 seller 테이블 채우기
            
        }

        private void Form3_Home_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.PURCHASE_ITEM_VIEW' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.announcementTableAdapter1.Fill(this.dataSet11.ANNOUNCEMENT);

            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }
    }
}
