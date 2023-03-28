using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EtityFrameWork
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        NORTHWNDEntities db = new NORTHWNDEntities();
        private void but_urunsatısraporu_Click(object sender, EventArgs e)
        {
            ///select u.ProductID,sum(sd.unitprice*sd.Quantity*(1-sd.Discount))ToplamTutar,
//            sum(sd.Quantity)ToplamAdet
//            from Products u
//inner join[Order Details] sd
//on sd.ProductID = u.ProductID
//group by u.ProductID

           //NORTHWNDEntities db= new NORTHWNDEntities();
            var sonuc = db.Products.Join
                (db.Order_Details, u => u.ProductID, s => s.ProductID, (urn, sd) => new
                { urn.ProductName, sd.UnitPrice, sd.Quantity, sd.Discount }).GroupBy(x => x.ProductName).Select
                (
                x => new 
                {
                    ProductName=x.Key,
                    ToplamTutar=x.Sum(y=>(float)y.UnitPrice*y.Quantity*(float)(1-y.Discount)),
                    ToplamAdet=x.Sum(y=>y.Quantity)
                });
            dgv_rapor.DataSource = sonuc.ToList();
            dgv_rapor.Columns["ProductName"].HeaderText = "Ürün Adı";
            
        }

        private void but_2_Click(object sender, EventArgs e)
        {
            dgv_rapor.DataSource = db.Products.Join(db.Order_Details, u => u.ProductID, s => s.ProductID, (urn, sd) => new

            {
                urn.Categories,
                urn.Suppliers,
                sd.UnitPrice,
                sd.Quantity,
                sd.Discount
            }).GroupBy(x => new
            {
                x.Categories.CategoryName,
                x.Suppliers.CompanyName
            }).Select(x => new
            {
                KategoriAdi=x.Key.CategoryName,
                TedarikciAdi=x.Key.CompanyName,
                ToplamTutar = x.Sum(y => (float)y.UnitPrice * y.Quantity * (float)(1 - y.Discount)),
                ToplamAdet = x.Sum(y => y.Quantity)
            }).ToList();

            dgv_rapor.Columns["KategoriAdi"].HeaderText = "Kategori Adı";
            dgv_rapor.Columns["TedarikciAdi"].HeaderText = "Tedarikçi Adı";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sonuc = from urun in db.Products
                        join sd in db.Order_Details
                        on urun.ProductID equals sd.ProductID
                        join satis in db.Orders
                        on sd.OrderID equals satis.OrderID
                        join musteri in db.Customers
                        on satis.CustomerID equals musteri.CustomerID
                        group new { urun, musteri } by new {urun.ProductName,musteri.CompanyName } into grup
                        
                        orderby grup.Key.ProductName
                        select new
                        {
                            ProductName = grup.Key.ProductName,
                            
                            CompanyName = grup.Key.CompanyName,
                            ToplamSatis = grup.Sum(x => x.urun.UnitPrice),
                            ToplamAdet = grup.Count()
                        };
            dgv_rapor.DataSource= sonuc.ToList();
        }
    }
}
