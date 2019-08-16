using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BoomUI
{
    public partial class BoomsUI : Form
    {
        BoomTrackingContext _context;
        public BoomsUI()
        {
            InitializeComponent();
        }

        private void BoomUI_Load(object sender, EventArgs e)
        {
            _context = new BoomTrackingContext();
            _context.Booms.Load();
            boomsBindingSource.DataSource =
                _context.Booms.Local.ToBindingList();
        }

        private void saveToolstrip_Click(object sender, EventArgs e)
        {
            this.Validate();

            _context.SaveChanges();
            BoomsDataGridView.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _context.Dispose();
        }
    }
}
