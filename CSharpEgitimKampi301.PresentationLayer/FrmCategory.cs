using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme başarılı!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Silme başarılı!");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var category = _categoryService.TGetById(id);
            dataGridView1.DataSource = category;


            //if (int.TryParse(txtCategoryId.Text, out int id))
            //{
            //    var category = _categoryService.TGetById(id);

            //    if (category != null)
            //    {
            //        // Tekil bir nesne olduğu için bir ICollection'a (liste vb.) eklemeliyiz.  
            //        var categoryList = new List<Category> { category }; // Category sınıfına göre değiştirin.  
            //        dataGridView1.DataSource = categoryList;  // DataGridView'a liste ataması yapıyoruz.  
            //    }
            //    else
            //    {
            //        MessageBox.Show("Kategori bulunamadı.");
            //        dataGridView1.DataSource = null; // Eğer kategori yoksa, DataGridView'ı sıfırlıyoruz.  
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen geçerli bir kategori ID'si girin.");
            //    dataGridView1.DataSource = null; // Hatalı giriş yapılırsa DataGridView'ı sıfırlıyoruz.  
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedId = int.Parse(txtCategoryId.Text);
            var updatedValue = _categoryService.TGetById(updatedId);
            updatedValue.CategoryName = txtCategoryName.Text;
            updatedValue.CategoryStatus = true;
            _categoryService.TUpdate(updatedValue);
            MessageBox.Show("Güncelleme başarılı!");
        }
    }
}
