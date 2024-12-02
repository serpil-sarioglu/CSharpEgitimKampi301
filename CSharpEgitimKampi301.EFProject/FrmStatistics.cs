using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            // Toplam Lokasyon Sayısı
            lblLocationCount.Text = db.Location.Count().ToString();

            // Toplam Kapasite
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();

            // Rehber Sayısı
            lblGuideCount.Text = db.Guide.Count().ToString();

            // Ortalama Kapasite
            lblAvgCapacity.Text = Math.Round(db.Location.Average(x => x.Capacity) ?? 0).ToString();

            // Ortalama Tur Fiyatı 
            lblAvgLocationPrice.Text = (db.Location.Average(x => x.Price) ?? 0).ToString("N2", CultureInfo.GetCultureInfo("tr-TR")) + " ₺";

            // Eklenen son ülke
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();

            // Kapadokya Turunun Kapasitesi
            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            // Ülke bazında ortalama tur kapasitesi
            lblTurkiyeCapacityAvg.Text = Math.Round(db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity) ?? 0).ToString();

            // Roma gezisinin rehberinin ismi
            var romeGuideId = db.Location.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            // En yüksek kapasiteli tur
            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();   

            // En yüksek fiyatlı tur
            var maxPrice = db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPrice).Select(y=>y.City).FirstOrDefault().ToString();

            // Ayşegül Çınar rehberin tur sayısı
            var guideIdByNameAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == guideIdByNameAysegulCinar).Count().ToString();    
        }
    }
}
