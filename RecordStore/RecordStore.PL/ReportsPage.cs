using RecordStore.BLL.Managers.Abstract;
using RecordStore.BLL.Managers.Concrete;
using RecordStore.BLL.Models.Concrete;
using RecordStore.DAL.Entities.Concrete;
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

namespace RecordStore.PL
{
    public partial class ReportsPage : Form
    {
        private readonly IReportManager _reportManager;
        public ReportsPage(IReportManager reportManager)
        {
            InitializeComponent();
            _reportManager = reportManager;
        }
        public void GetInActiveAlbumsForm()
        {
            dgvQuery1.DataSource = _reportManager.TakeInActiveAlbums();
            dgvQuery2.DataSource = _reportManager.TakeActiveAlbums();
            dgvQuery3.DataSource = _reportManager.TakeDiscountedAlbums();
            dgvQuery4.DataSource = _reportManager.TakeLastAddedAlbums();

        }
        private void ReportsPage_Load(object sender, EventArgs e)
        {
            GetInActiveAlbumsForm();
        }
    }
}
