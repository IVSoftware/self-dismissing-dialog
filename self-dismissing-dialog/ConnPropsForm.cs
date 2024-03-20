using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace self_dismissing_dialog
{
    public partial class ConnPropsForm : Form
    {
        public ConnPropsForm() => InitializeComponent();
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if(Visible)
            {
                _ = ExecAutoClose();
            }
        }
        private async Task ExecAutoClose()
        {
            int remaining = 10;
            do
            {
                label1.Text = $"Closing in {remaining:d2}";
                await Task.Delay(TimeSpan.FromSeconds(1));
                remaining--;
            } while(Visible && remaining > 0);
            DialogResult = DialogResult.OK;
        }
    }
}
