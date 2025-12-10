namespace WebView2App;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        InitializeAsync();
    }

    private async void InitializeAsync()
    {
        await webView21!.EnsureCoreWebView2Async(null);
    }

    private void BtnLoadUrl_Click(object? sender, EventArgs e)
    {
        if (webView21 != null && webView21.CoreWebView2 != null)
        {
            webView21.CoreWebView2.Navigate("https://jobup.ch");
        }
    }
}
