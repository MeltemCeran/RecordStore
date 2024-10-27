using RecordStore.BLL.Managers.Concrete;
using RecordStore.BLL.Models.Concrete;
using RecordStore.DAL.Context;
using RecordStore.DAL.Services.Concrete;
using RecordStore.DAL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RecordStore.PL
{
    public partial class AlbumPage : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        AlbumModel selectedAlbum;
        public AlbumPage()
        {
            InitializeComponent();
        }

        private void AlbumPage_Load(object sender, EventArgs e)
        {
            GetAlbumList();
        }
        public void FormClear()
        {
            txtAlbumName.Clear();
            txtArtist.Clear();
            txtDiscount.Clear();
            txtPrice.Clear();
        }
        public void GetAlbumList()
        {
            using (AlbumManager albumManager = new AlbumManager())
            {
                dgvAlbums.DataSource = albumManager.GetAll();

            }
        }

        private void dgvAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedAlbum = (AlbumModel)dgvAlbums.SelectedRows[0].DataBoundItem;
            txtAlbumName.Text = selectedAlbum.Name;
            txtArtist.Text = selectedAlbum.Singers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAlbumName.Text))
            {
                MessageBox.Show("Lütfen 'Albüm Adı' kısmınızı doldurunuz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtArtist.Text))
            {
                MessageBox.Show("Lütfen 'Sanatçı' kısmınızı doldurunuz.");
                return;
            }

            if (!double.TryParse(txtPrice.Text, out double albumPrice))
            {
                MessageBox.Show("Lütfen geçerli bir 'Fiyat' değeri giriniz.");
                return;
            }
            if (!double.TryParse(txtPrice.Text, out double discount))
            {
                MessageBox.Show("Lütfen geçerli bir 'İndirim' değeri giriniz.");
                return;
            }

            using (AlbumManager albumManager = new AlbumManager())
            {
                AlbumModel album = new AlbumModel();
                album.Name = txtAlbumName.Text;
                album.Singers = txtArtist.Text;
                album.Price = Convert.ToDouble(txtPrice.Text);
                album.CreatedDate = DateTime.Now;
                albumManager.Add(album);
                if (string.IsNullOrEmpty(txtDiscount.Text))
                {
                    album.Discount = 1.00;
                }
                else
                {
                    album.Discount = Convert.ToDouble(txtDiscount.Text);
                }
                album.PublishedDate = DateOnly.FromDateTime(dtpPublishedDate.Value);

                if (albumManager.Save() > 0)
                {
                    albumManager.Save();
                    GetAlbumList();
                }
                else
                {
                    MessageBox.Show("Album eklenemedi.");
                }
                FormClear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (AlbumManager albumManager = new AlbumManager())
            {
                if (selectedAlbum != null)
                {
                    albumManager.Delete(selectedAlbum);

                    if (albumManager.Save() > 0)
                    {
                        selectedAlbum.DeletedDate = DateTime.Now;
                        selectedAlbum.IsActive = false;
                        MessageBox.Show("Albüm silindi");

                        GetAlbumList();
                    }
                    else
                    {
                        MessageBox.Show("Albüm silinemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen seçim yapınız.");
                }
                FormClear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (AlbumManager albumManager = new AlbumManager())
            {
                if (selectedAlbum != null)
                {
                    string newAlbumName = txtAlbumName.Text;
                    if (string.IsNullOrWhiteSpace(newAlbumName))
                    {
                        MessageBox.Show("Lütfen 'Albüm' kısmını doldurunuz.");
                    }
                    string newSingerName = txtArtist.Text;
                    if (string.IsNullOrWhiteSpace(newSingerName))
                    {
                        MessageBox.Show("Lütfen 'Sanatçı' kısmını doldurunuz.");
                    }

                    if (!double.TryParse(txtDiscount.Text, out double newDiscount))
                    {
                        MessageBox.Show("Lütfen 'İndirim' kısmını doldurunuz");
                        return;
                    }

                    if (!double.TryParse(txtPrice.Text, out double newPrice))
                    {
                        MessageBox.Show("Lütfen 'Fiyat' kısmını doldurunuz");
                        return;
                    }

                    selectedAlbum.Name = newAlbumName;
                    selectedAlbum.Singers = newSingerName;
                    selectedAlbum.Price = newPrice;
                    selectedAlbum.Discount = newDiscount;
                    selectedAlbum.UpdatedDate = DateTime.Now;

                    albumManager.Update(selectedAlbum);

                    if (albumManager.Save() > 0)
                    {

                        GetAlbumList(); // Listeyi yenile
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme sırasında hata oldu.");
                    }
                }
                else
                {
                    MessageBox.Show("Güncellemek için albüm seçiniz");
                    return;
                }

                FormClear(); // Formu temizle
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var dbContext = new RecordStoreDbContext(); // Kendi DbContext sınıfınızı kullanın
            var unitOfWork = new UnitOfWork(dbContext); // IUnitOfWork uyumlu nesne
            var reportService = new ReportService(unitOfWork); // IReportService uyumlu nesne
            var reportManager = new ReportManager(reportService); // IReportManager uyumlu nesne

            ReportPages reportPage = new ReportPages(reportManager);
            reportPage.ShowDialog();
        }
    }
}
