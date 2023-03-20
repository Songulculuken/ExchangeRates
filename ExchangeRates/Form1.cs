using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace ExchangeRates
{
    public partial class Form1 : Form
    {
        soncuEntities db = new soncuEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            

        }
        public void ExchangeRatesGet()
        {
            
            try
            {
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

                decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
                lbl_usd.Text = dolar.ToString();
                lbl_eur.Text = euro.ToString();

            }
            catch (XmlException xml)
            {
                timer1.Stop();
                MessageBox.Show(xml.ToString());
            }
            
            ExchangeRates e = new ExchangeRates();
            
            e.Kur = lbl_dolar.Text;
            e.Deger = Convert.ToSingle(lbl_usd.Text);
            e.Tarih = DateTime.Now;
            db.ExchangeRates.Add(e);
            db.SaveChanges();

            ExchangeRates d = new ExchangeRates();
            d.Kur = lbl_euro.Text;
            d.Deger = Convert.ToSingle(lbl_eur.Text);
            d.Tarih = DateTime.Now;
            db.ExchangeRates.Add(d);
            db.SaveChanges();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            ExchangeRatesGet();
        }
    }
}
