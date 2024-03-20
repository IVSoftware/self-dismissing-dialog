
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
                    Text = ConnPropsForm.ShowDialog(this).ToString();
                }
            };
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Text = ConnPropsForm.ShowDialog(this).ToString();
        }
        ConnPropsForm ConnPropsForm = new ConnPropsForm();
    }
}
