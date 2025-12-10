namespace WebView2App;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        // Fire-and-forget pattern with proper exception handling
        _ = InitializeAsync();
    }

    private async Task InitializeAsync()
    {
        try
        {
            await webView21!.EnsureCoreWebView2Async(null);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Failed to initialize WebView2. Please ensure that the WebView2 Runtime is installed.\n\nError: {ex.Message}",
                "WebView2 Initialization Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void BtnLoadUrl_Click(object? sender, EventArgs e)
    {
        if (webView21 != null && webView21.CoreWebView2 != null)
        {
            webView21.CoreWebView2.Navigate("https://jobup.ch");
        }
    }
}
