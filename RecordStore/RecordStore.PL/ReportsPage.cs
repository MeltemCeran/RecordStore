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
        public ReportsPage()
        {
            InitializeComponent();
        }
        public void GetInActiveAlbumsForm()
        {
            var unitOfWork = new UnitOfWork();


            dgvQuery1.DataSource = unitOfWork.Albums.InActiveAlbums;
                  
        }
        private void ReportsPage_Load(object sender, EventArgs e)
        {
            GetInActiveAlbumsForm();
        }
    }
}
