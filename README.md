## Self-Closing Form

As I understand it, you want the form to self-close with `DialogResult.OK`. If the form is being shown modally (because `ShowDialog` was invoked on it) then you can set the dialog result directly and the form will close as a result. For example, when this form is shown by `ShowDialog` it will self-close after a 10-second countdown.

[![closing in 10][1]][1]

###### Self-Close
```
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
```
___

The calling method can do the same thing. Here, the main form aborts the countdown after 5 seconds the first time (only) that `ConnPropsForm` is shown.

###### External-Close
```
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
```

  [1]: https://i.stack.imgur.com/3c65T.png