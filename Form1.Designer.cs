namespace WebBrowser
{
    partial class WebBrowser
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.webControls = new System.Windows.Forms.MenuStrip();
            this.navegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.webWindow = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.searchHistoryTxt = new System.Windows.Forms.TextBox();
            this.webControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // webControls
            // 
            this.webControls.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.webControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegarToolStripMenuItem});
            this.webControls.Location = new System.Drawing.Point(0, 0);
            this.webControls.Name = "webControls";
            this.webControls.Size = new System.Drawing.Size(1262, 27);
            this.webControls.TabIndex = 0;
            this.webControls.Text = "menuStrip1";
            // 
            // navegarToolStripMenuItem
            // 
            this.navegarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.atrásToolStripMenuItem,
            this.adelanteToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.navegarToolStripMenuItem.Name = "navegarToolStripMenuItem";
            this.navegarToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.navegarToolStripMenuItem.Text = "Navegar";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // atrásToolStripMenuItem
            // 
            this.atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            this.atrásToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.atrásToolStripMenuItem.Text = "Atrás";
            this.atrásToolStripMenuItem.Click += new System.EventHandler(this.atrásToolStripMenuItem_Click);
            // 
            // adelanteToolStripMenuItem
            // 
            this.adelanteToolStripMenuItem.Name = "adelanteToolStripMenuItem";
            this.adelanteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adelanteToolStripMenuItem.Text = "Adelante";
            this.adelanteToolStripMenuItem.Click += new System.EventHandler(this.adelanteToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // linkComboBox
            // 
            this.linkComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.linkComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.linkComboBox.FormattingEnabled = true;
            this.linkComboBox.Items.AddRange(new object[] {
            "https://google.com/",
            "https://youtube.com/",
            "https://duckduckgo.com/"});
            this.linkComboBox.Location = new System.Drawing.Point(12, 27);
            this.linkComboBox.Name = "linkComboBox";
            this.linkComboBox.Size = new System.Drawing.Size(1156, 23);
            this.linkComboBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1174, 25);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(76, 27);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // webWindow
            // 
            this.webWindow.AllowExternalDrop = true;
            this.webWindow.CreationProperties = null;
            this.webWindow.DefaultBackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.webWindow.Location = new System.Drawing.Point(12, 57);
            this.webWindow.Name = "webWindow";
            this.webWindow.Size = new System.Drawing.Size(1235, 604);
            this.webWindow.Source = new System.Uri("https://www.duckduckgo.com", System.UriKind.Absolute);
            this.webWindow.TabIndex = 7;
            this.webWindow.ZoomFactor = 1D;
            // 
            // searchHistoryTxt
            // 
            this.searchHistoryTxt.Location = new System.Drawing.Point(12, 27);
            this.searchHistoryTxt.Multiline = true;
            this.searchHistoryTxt.Name = "searchHistoryTxt";
            this.searchHistoryTxt.Size = new System.Drawing.Size(399, 490);
            this.searchHistoryTxt.TabIndex = 8;
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.searchHistoryTxt);
            this.Controls.Add(this.webWindow);
            this.Controls.Add(this.linkComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.webControls);
            this.Name = "WebBrowser";
            this.Text = "Web Browser";
            this.Resize += new System.EventHandler(this.WebBrowser_Resize);
            this.webControls.ResumeLayout(false);
            this.webControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip webControls;
        private System.Windows.Forms.ComboBox linkComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ToolStripMenuItem navegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adelanteToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webWindow;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.TextBox searchHistoryTxt;
    }
}

