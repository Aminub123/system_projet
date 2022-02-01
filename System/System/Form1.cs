using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.DataSet1TableAdapters;
namespace System
{
    public partial class Form1 : Form
    {
        DataSet1 dsdataset = new DataSet1();
        miniTableAdapter adapter = new miniTableAdapter();
        //----------------------------------
        DataClasses1DataContext dsdata;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (txt_itemid.Text != "" && txt_itemname.Text != "" && txt_amountpaid.Text != "" && txt_change.Text != "")
            {
                int ip = -1;
                foreach (DataRow row in dsdataset.mini.Rows)
                {
                    if (row[0].ToString()==txt_itemid.Text)
                    {
                        ip = 1;
                    }
                }
                if (ip==-1)
                {
                    DataRow r = dsdataset.mini.NewRow();
                    r[0] =int.Parse(txt_itemid.Text);
                    r[1] =txt_itemname.Text.ToString();
                    r[2] = txt_amountpaid.Text;
                    r[3] =txt_change.Text;
                    dsdataset.mini.Rows.Add(r);
                    adapter.Update(dsdataset.mini);
                    afficher();
                }
                else { MessageBox.Show("votre id est déja trouver", "warning"); }
            }
            else { MessageBox.Show("verifier votre zones de texts","error"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            afficher();
        }

        private void afficher()
        {
            adapter.Fill(dsdataset.mini);
            dataGridView1.DataSource = dsdataset.mini;

        }

        private void txt_itemid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)||e.KeyChar==(char)Keys.Back)
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            mini modifier = new mini();
            if (txt_itemid.Text != "" && txt_itemname.Text != "" && txt_amountpaid.Text != "" && txt_change.Text != "")
            {
                dsdata = new DataClasses1DataContext();
                var table = from A in dsdata.minis where A.itemid == Convert.ToInt32(txt_itemid.Text) select A;
                if (table != null)
                {
                    modifier.itemid =int.Parse(txt_itemid.Text);
                    modifier = dsdata.minis.SingleOrDefault(A => A.itemid== modifier.itemid) ;
                    modifier.itemname =txt_itemname.Text;
                    modifier.amountpaid =int.Parse(txt_amountpaid.Text);
                    modifier.change =int.Parse(txt_change.Text);
                    dsdata.SubmitChanges();
                    afficher();
                }
                else { MessageBox.Show("your id didn't exists", "error"); }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
        }
    }
}
