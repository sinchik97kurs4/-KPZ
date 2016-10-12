using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void URL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return") { BrowserComponent.Navigate("http://www." + URL.Text); }
        }

        private void BrowserComponent_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Check_url();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_MouseUp(object sender, MouseEventArgs e)
        {




        }

        private void tabPage2_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == tabControl1.TabCount - 1)
            {
                TabPage tp = new TabPage();
                tp.Text = "Home page";
                tabControl1.Controls.Add(tp);
                TabPage temp = new TabPage();
                temp = tabControl1.TabPages[tabControl1.TabCount - 1];
                tabControl1.TabPages[tabControl1.TabCount - 1] = tabControl1.TabPages[tabControl1.TabCount - 2];
                tabControl1.TabPages[tabControl1.TabCount - 2] = temp;
                tabControl1.SelectTab(tabControl1.TabCount - 2);
                WebBrowser wb = new WebBrowser() { ScriptErrorsSuppressed = true };
                wb.Parent = tabControl1.SelectedTab;
                wb.Dock = DockStyle.Fill;
                wb.Navigate("https://google.com");
            }

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WebBrowser wb = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            wb.GoForward();
            Check_url();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WebBrowser wb = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            wb.GoBack();
            Check_url();
        }

        private void tabControl1_KeyUp(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedTab!= tabControl1.TabPages[0])
            {
                if ((tabControl1.SelectedIndex != tabControl1.TabCount - 1) && (e.KeyCode == Keys.Escape))
                {
                    tabControl1.TabPages.Remove(tabControl1.SelectedTab);

                }
            }
            //if (tabControl1.SelectedIndex)
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            WebBrowser wb = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            wb.Refresh();
            Check_url();
        }

      public void Check_url()
        {

            WebBrowser wb = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            tabControl1.SelectedTab.Text = wb.DocumentTitle;
            URL.Text = wb.Url.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            WebBrowser wb = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            wb.Stop();
            Check_url();
        }

        public void Switch()
        {
            if(Labe)
        }
        private void button7_Click(object sender, EventArgs e)
        {
        

        }
    }
}
