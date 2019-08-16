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

namespace BoomUI
{
    public partial class frmMain : Form

    {
        BoomTrackingContext _context;
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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
            this.locationDataGridView.Refresh();
            this.boomDataGridView.Refresh();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _context = new  BoomTrackingContext();
            _context.Locations.Load();
            this.LocationbindingSource.DataSource =
                _context.Locations.Local.ToBindingList();

        }
    }
}
