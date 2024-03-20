
namespace self_dismissing_dialog
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Disposed += (sender, e) =>ConnPropsForm.Dispose();
            buttonShow.Click += (sender, e) =>
            {
                if (!ConnPropsForm.Visible)
                {
                    ConnPropsForm.ShowDialog();
                }
            };
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ConnPropsForm.ShowDialog(this);
        }
        ConnPropsForm ConnPropsForm = new ConnPropsForm();
    }
}
