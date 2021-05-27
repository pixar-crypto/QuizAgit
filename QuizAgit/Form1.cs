using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuizAgit
{
    public partial class MasterBarang023 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6BBLR561;Initial Catalog=QuizMahasiswa;Integrated Security=True;");

        public MasterBarang023()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void btnSave_Click(object sender, EventArgs e)
        {
            int idbarang = int.Parse(txtID.Text);
            string namabarang = txtNamaBarang.Text;
            int harga = int.Parse(txtHarga.Text);
            int stok = int.Parse(txtStok.Text);
            string namasupplier = txtNamaSupplier.Text;
            var data = new tbl_barang
            {
                id_barang = idbarang,
                nama_barang = namabarang,
                harga = harga,
                stok = stok,
                nama_supplier = namasupplier
            };
            db.tbl_barangs.InsertOnSubmit(data);
            db.SubmitChanges();
            MessageBox.Show("Save Successfully");
            txtNamaBarang.Clear();
            txtHarga.Clear();
            txtStok.Clear();
            txtNamaSupplier.Clear();
            LoadData();
        }

        void LoadData()
        {
            var st = from tb in db.tbl_barangs select tb;
            dataGridView1.DataSource = st;
        }

        private void MasterBarang023_Load(object sender, EventArgs e)
        {
           
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max (cast (id_barang as int)), 0) +1 from tbl_barang", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtID.Text = dt.Rows[0][0].ToString();
            LoadData();
        }
    }
}
