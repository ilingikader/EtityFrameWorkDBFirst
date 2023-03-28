using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtityFrameWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NORTHWNDEntities db = new NORTHWNDEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();
            UrunListesi(db);

            cmb_kategoriler.DataSource = db.Categories.ToList();
            cmb_kategoriler.DisplayMember = "CategoryName";
            cmb_kategoriler.ValueMember = "CategoryID";

            cmb_tedarikciler.DataSource = db.Suppliers.ToList();
            cmb_tedarikciler.DisplayMember = "CompanyName";//"SirketAdı";
            cmb_tedarikciler.ValueMember = "SupplierID";

        }

        private void UrunListesi(NORTHWNDEntities db)
        {
           // dgv_Urunler.DataSource = db.Products.ToList();
            var sonuc1 = db.Products.Join(db.Categories, u => u.CategoryID, k => k.CategoryID,
            (urn, kat) => new { urn.ProductID, urn.ProductName, urn.UnitPrice, urn.UnitsInStock, kat.CategoryName });
            
            var sonuc2 = db.Products.Join(db.Suppliers, u => u.SupplierID, t => t.SupplierID,
            (urn, ted) => new { urn.ProductID, urn.ProductName, urn.UnitPrice, urn.UnitsInStock, ted.SupplierID, ted.CompanyName });

            var sonuc3 = db.Products.Join(db.Categories, u => u.CategoryID, k => k.CategoryID,
            (urn, kat) => new { urn, kat.CategoryName }).Join(db.Suppliers, prd => prd.urn.ProductID,
            t => t.SupplierID, (urun, ted) => new
            {
                urun.urn.ProductID,
                urun.urn.ProductName,
                urun.urn.UnitPrice,
                urun.urn.UnitsInStock,
                urun.urn.SupplierID,
                urun.urn.CategoryID,
                urun.CategoryName,
                ted.CompanyName
            });


            var sonuc4 = from urun in db.Products
                         select new
                         {
                             urun.ProductID,
                             urun.ProductName,
                             urun.UnitPrice,
                         };

            var sonuc5 = from urun in db.Products
                         join kat in db.Categories
                         on urun.CategoryID equals kat.CategoryID
                         join ted in db.Suppliers
                         on urun.SupplierID equals ted.SupplierID
                         select new { urun.ProductID, urun.ProductName, urun.UnitPrice, urun.UnitsInStock, kat.CategoryName, ted.CompanyName };
            dgv_Urunler.DataSource = sonuc5.ToList();

            // { urn.ProductID, urn.ProductName, urn.UnitPrice, urn.UnitsInStock, kat.CategoryName }).Join(db.Suppliers, prd => prd.urn.SupplierID, t => t.SupplierID, (urun, ted) => new {urun.}


            //dgv_Urunler.DataSource = sonuc1.ToList();
            //dgv_Urunler.DataSource = sonuc2.ToList();
            //dgv_Urunler.DataSource = sonuc3.ToList();
            dgv_Urunler.DataSource = sonuc4.ToList();

        }

        private void but_ekle_Click(object sender, EventArgs e)
        {
            Products u=new Products();
            u.ProductName = textBox_urunadi.Text;
            u.UnitsInStock=(short)nud_stok.Value;
            u.UnitPrice=nud_fiyat.Value;
            u.CategoryID = (int)cmb_kategoriler.SelectedValue;
            u.SupplierID=(int)cmb_kategoriler.SelectedValue;

            
            db.Products.Add(u);
            db.SaveChanges();
            dgv_Urunler.DataSource= db.Products.ToList();


        }

        private void dgv_Urunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_urunadi.Text = dgv_Urunler.CurrentRow.Cells["ProductName"].Value.ToString();
            nud_fiyat.Value = (decimal)dgv_Urunler.CurrentRow.Cells["UnitPrice"].Value;
            nud_stok.Value = (short)dgv_Urunler.CurrentRow.Cells["UnitsInStock"].Value;
            cmb_kategoriler.SelectedValue = dgv_Urunler.CurrentRow.Cells["CategoryID"].Value;
            cmb_tedarikciler.SelectedValue = dgv_Urunler.CurrentRow.Cells["SupplierID"].Value;
            textBox_urunadi.Tag = dgv_Urunler.CurrentRow.Cells["ProductID"].Value;


        }

        private void but_guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_urunadi.Tag);
            Products u=db.Products.FirstOrDefault(i => i.ProductID == id);
            if(u != null)
            {
                u.ProductName = textBox_urunadi.Text;
                u.UnitPrice = nud_fiyat.Value;
                u.UnitsInStock =(short) nud_stok.Value;
                u.CategoryID = (int)cmb_kategoriler.SelectedValue;
                u.SupplierID = (int)cmb_tedarikciler.SelectedValue;

            }
            dgv_Urunler.DataSource=db.Products.ToList();
        }

        private void text_ara_TextChanged(object sender, EventArgs e)
        {
            dgv_Urunler.DataSource = db.Products.Where(x=>x.ProductName.Contains(text_ara.Text)).ToList();
        }

        private void radioBut_artan_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Urunler.DataSource=db.Products.OrderBy(x=>x.UnitPrice).ToList();
        }

        private void radioBut_azalan_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Urunler.DataSource = db.Products.OrderByDescending(x => x.UnitPrice).ToList();
        }

        private void radioBut_varsayılan_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Urunler.DataSource = db.Products.ToList();
        }

        private void but_ilk10_Click(object sender, EventArgs e)
        {
            dgv_Urunler.DataSource=db.Products.Take(10).ToList();
        }

        private void but_son10_Click(object sender, EventArgs e)
        {
            dgv_Urunler.DataSource=db.Products.Take(10).OrderByDescending(x=>x.ProductID).ToList();
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgv_Urunler.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgv_Urunler.CurrentRow.Cells["ProductID"].Value);
                Products u = db.Products.FirstOrDefault(i => i.ProductID == id);
                if (u != null)
                {
                    db.Products.Remove(u);
                    db.SaveChanges();
                }
            }
            dgv_Urunler.DataSource=db.Products.ToList();

           
        }

        private void but_rapor_Click(object sender, EventArgs e)
        {
            Rapor rf=new Rapor();
            rf.ShowDialog();//
        }
    }
}
