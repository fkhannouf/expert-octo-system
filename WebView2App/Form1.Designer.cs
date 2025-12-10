#nullable enable
namespace WebView2App;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer? components = null;
    private Microsoft.Web.WebView2.WinForms.WebView2? webView21;
    private Button? btnLoadUrl;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        if (disposing && webView21 != null)
        {
            webView21.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
        btnLoadUrl = new Button();
        ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
        SuspendLayout();
        
        // 
        // webView21
        // 
        webView21.AllowExternalDrop = true;
        webView21.CreationProperties = null;
        webView21.DefaultBackgroundColor = Color.White;
        webView21.Location = new Point(12, 60);
        webView21.Name = "webView21";
        webView21.Size = new Size(776, 378);
        webView21.TabIndex = 0;
        webView21.ZoomFactor = 1D;
        
        // 
        // btnLoadUrl
        // 
        btnLoadUrl.Location = new Point(12, 12);
        btnLoadUrl.Name = "btnLoadUrl";
        btnLoadUrl.Size = new Size(200, 40);
        btnLoadUrl.TabIndex = 1;
        btnLoadUrl.Text = "Charger URL (jobup.ch)";
        btnLoadUrl.UseVisualStyleBackColor = true;
        btnLoadUrl.Click += BtnLoadUrl_Click;
        
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnLoadUrl);
        Controls.Add(webView21);
        Name = "Form1";
        Text = "WebView2 Demo - JobUp.ch";
        ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
        ResumeLayout(false);
    }

    #endregion
}
