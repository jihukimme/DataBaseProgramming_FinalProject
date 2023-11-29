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
    public partial class Form3_Refund : Form
    {
        string customer_id;

        DataTable mytable1;

        public Form3_Refund(string id)
        {
            InitializeComponent();

            customer_id = id;

            refundTableAdapter1.Fill(dataSet11.REFUND); // DataSet의 seller 테이블 채우기
            mytable1 = dataSet11.Tables["REFUND"];
        }

        private void Form3_Refund_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.PURCHASE_ITEM_VIEW' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.refunD_ITEM_VIEWTableAdapter1.Fill(this.dataSet11.REFUND_ITEM_VIEW);

            //해당 customer_id의 구매내역만 보여줌.
            rEFUNDITEMVIEWBindingSource.Filter = $"CUSTOMER_ID = '{customer_id}'";
        }
    }
}
