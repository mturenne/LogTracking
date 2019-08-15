using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoomTracking
{
    public partial class frmMain : Form
    {
        BoomTrackingContext _context;
        public frmMain()
        {
            InitializeComponent();
        }

       

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            _context = new BoomTrackingContext();
            _context.Locations.Load();
            this.locationBindingSource.DataSource =
                _context.Locations.Local.ToBindingList();
            repositoryItemComboBox1.Items.AddRange(locationBindingSource);
            _context.Logs.Load();
            _context.BoomGear.Load();
            _context.BoomSticks.Load();
            _context.Booms.Load();

            this.boomsBindingSource1.DataSource =
                _context.Booms.Local.ToBindingList();
            this.logBindingSource.DataSource =
                _context.Logs.Local.ToBindingList();
            this.boomGearBindingSource.DataSource =
                _context.BoomGear.Local.ToBindingList();
            this.boomStickBindingSource.DataSource =
                _context.BoomSticks.Local.ToBindingList();
            repositoryItemComboBox2.Items.AddRange(boomsBindingSource1);

        }

        private void locationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            foreach (var boom in _context.Booms.Local.ToList())
            {
                if (boom.Location == null)
                {
                    _context.Booms.Remove(boom);
                }

            }
            this._context.SaveChanges();

            this.locationGridControl.Refresh();
            this.boomsGridControl.Refresh();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._context.Dispose();
        }

    }
}
