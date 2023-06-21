using DbFirst_Nortwind.Models;

namespace DbFirst_Nortwind
{
    public partial class Form1 : Form
    {
        NorthwindContext _db;
        public Form1()
        {
            InitializeComponent();
            _db = new NorthwindContext();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DGVFill();
            btnEkle.Click += Click;  //butonun click olay� tetiklendi�inde click metodu cal�sacak.
            btnSil.Click += Click;
            btnGuncelle.Click += Click;
        }
        private void Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            object tag = btn.Tag;
            switch (tag)
            {
                case "1": CustomerCreate(); break;
                case "2": CustomerUpdate(); break;
                case "3": CustomerDelete(); break;
            }
            DGVFill();
        }
        private void CustomerDelete()
        {
            string id = txtCustomerId.Text.Trim();
            string companyName = txtSirketAdi.Text.Trim();
            try
            {
                Customer deleteCustomer = _db.Customers.FirstOrDefault(x => x.CustomerId == id);
                _db.Customers.Remove(deleteCustomer);
                _db.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Silinecek m��teriyi se�in");;
            }
        }
        private void CustomerUpdate()
        {
            string id = txtCustomerId.Text.Trim();
            string companyName = txtSirketAdi.Text.Trim();
            try
            {
                Customer customer = _db.Customers.Find(id);
                if (customer != null && !string.IsNullOrWhiteSpace(companyName))
                {
                    customer.CompanyName = companyName;
                    _db.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("G�ncellenecek m��teri se�in!");
            }
        }

        private void CustomerCreate()
        {
            string id = txtCustomerId.Text.Trim(),
                   companyName = txtSirketAdi.Text.Trim();
            try
            {
                if (!string.IsNullOrWhiteSpace(companyName) && !string.IsNullOrWhiteSpace(id))
                {
                    Customer customer = new Customer()
                    {
                        CustomerId = id,
                        CompanyName = companyName
                    };
                    _db.Customers.Add(customer);
                    _db.SaveChanges();//veritaban�na kaydetmek i�in
                }
                else
                    MessageBox.Show("�irket Id'si ve/veya Ad� girin.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kay�t mevcut oldu�u i�in eklenemedi"); ;
            }
        }

        private void DGVFill() //hepsinde bu metot �al�asacak.
        {
            dgvCustomerList.DataSource = _db.Customers.ToList();
            txtCustomerId.Clear();
            txtSirketAdi.Clear();
        }

        private void dgvCustomerList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtCustomerId.Enabled = false;

            DataGridViewRow selectedRow = dgvCustomerList.Rows[rowIndex]; //se�ilen sat�r�n bilgilerini al�yoruz.

            txtCustomerId.Text = selectedRow.Cells["CustomerId"].Value.ToString();//se�ilen sat�rda bulunan CustomerId h�cresinin degerini alma.
            txtSirketAdi.Text = selectedRow.Cells["CompanyName"].Value.ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomerId.Clear();
            txtSirketAdi.Clear();
            txtCustomerId.Enabled = true;
            int selectedIndex = dgvCustomerList.SelectedRows[0].Index;//secili satir.Hangi satirin secili oldugunu sayi olarak de�iskende tutar.
            dgvCustomerList.Rows[selectedIndex].Selected = false;

        }
    }
}