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
    public partial class Form4_Sales : Form
    {
        string seller_id;
        public Form4_Sales(string id)
        {
            InitializeComponent();

            seller_id = id;
        }

        private void Form4_Sales_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.PURCHASE_ITEM_VIEW' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pURCHASE_ITEM_VIEWTableAdapter.Fill(this.dataSet1.PURCHASE_ITEM_VIEW);


            //해당 seller_id의 구매내역만 보여줌.
            pURCHASEITEMVIEWBindingSource.Filter = $"SELLER_ID = '{seller_id}'";

            label2.Text = seller_id;
        }
    }
}
