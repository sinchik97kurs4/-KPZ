namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BrowserComponent = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BrowserComponent);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1269, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BrowserComponent
            // 
            this.BrowserComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserComponent.Location = new System.Drawing.Point(3, 3);
            this.BrowserComponent.MinimumSize = new System.Drawing.Size(20, 20);
            this.BrowserComponent.Name = "BrowserComponent";
            this.BrowserComponent.Size = new System.Drawing.Size(1263, 388);
            this.BrowserComponent.TabIndex = 0;
            this.BrowserComponent.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.BrowserComponent.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.BrowserComponent_DocumentCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 128);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1277, 420);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyUp);
            this.tabControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1269, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "+";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabPage2_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.SearchText);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.URL);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 119);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(1221, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 50);
            this.button8.TabIndex = 20;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Search
            // 
            this.Search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Search.AutoSize = true;
            this.Search.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Search.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Search.Location = new System.Drawing.Point(1181, 65);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(99, 43);
            this.Search.TabIndex = 18;
            this.Search.Text = "Google";
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(1015, 61);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 53);
            this.button7.TabIndex = 17;
            this.button7.Text = "Switch";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // SearchText
            // 
            this.SearchText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchText.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchText.Location = new System.Drawing.Point(1015, 6);
            this.SearchText.MaximumSize = new System.Drawing.Size(10000, 50);
            this.SearchText.MinimumSize = new System.Drawing.Size(200, 50);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(200, 41);
            this.SearchText.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Cofing;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(902, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 50);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Stop;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(140, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 50);
            this.button4.TabIndex = 13;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.reload;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(75, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 50);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.next_button;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(205, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 50);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.back_button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 50);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // URL
            // 
            this.URL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URL.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.URL.Location = new System.Drawing.Point(270, 9);
            this.URL.MaximumSize = new System.Drawing.Size(10000, 50);
            this.URL.MinimumSize = new System.Drawing.Size(200, 50);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(626, 41);
            this.URL.TabIndex = 1;
            this.URL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URL_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 560);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser BrowserComponent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

