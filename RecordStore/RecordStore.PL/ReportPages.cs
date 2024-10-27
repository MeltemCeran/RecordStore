using RecordStore.BLL.Managers.Abstract;
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
    public partial class ReportPages : Form
    {
        private readonly IReportManager _reportManager;
        public ReportPages(IReportManager reportManager)
        {
            InitializeComponent();
            _reportManager = reportManager;
        }
        public void GetInActiveAlbumsForm()
        {
            dgvQuery1.DataSource = _reportManager.TakeActiveAlbums();
            dgvQuery2.DataSource = _reportManager.TakeInActiveAlbums();
            dgvQuery3.DataSource = _reportManager.TakeDiscountedAlbums();
            dgvQuery4.DataSource = _reportManager.TakeLastAddedAlbums();

        }
        private void ReportPages_Load(object sender, EventArgs e)
        {
            GetInActiveAlbumsForm();
        }
    }
}
