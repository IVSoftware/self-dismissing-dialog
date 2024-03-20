
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
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BeginInvoke(() => Text = ConnPropsForm.ShowDialog(this).ToString());

            await Task.Delay(TimeSpan.FromSeconds(5));
            ConnPropsForm.DialogResult = DialogResult.Abort;
        }
        ConnPropsForm ConnPropsForm = new ConnPropsForm();
    }
}
