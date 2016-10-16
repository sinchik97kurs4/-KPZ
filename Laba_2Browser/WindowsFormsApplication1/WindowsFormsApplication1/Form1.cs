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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApplication1
{
    [Serializable]
    struct Story
    {
   public string title, url, dateTime;
    }



    [Serializable]
    struct Bookmark
    {
        public string title, url;
        
    }



    public partial class Form1 : Form
    {
        public Form2 MenuForm;

        LinkedList<Story> History = new LinkedList<Story>();

        LinkedList<Bookmark> Marks = new LinkedList<Bookmark>();


        public void Check_url()
        {
            WebBrowser wb = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            tabControl1.SelectedTab.Text = wb.DocumentTitle;
            URL.Text = wb.Url.AbsoluteUri;



            if (!File.Exists("story.bin"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("story.bin", FileMode.OpenOrCreate);

                Story story = new Story();
                story.url = wb.Url.AbsoluteUri;
                story.title = wb.DocumentTitle;
                story.dateTime = DateTime.Now.ToString();
                History.AddLast(story);
                bf.Serialize(fs, History);
                fs.Close();
              

            }
            else
            {

                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("story.bin", FileMode.OpenOrCreate);
                History = (LinkedList<Story>)bf.Deserialize(fs);
                Story story = new Story();
                story.url = wb.Url.AbsoluteUri;
                story.title = wb.DocumentTitle;
                story.dateTime = DateTime.Now.ToString();
                History.AddLast(story);
                bf.Serialize(fs, History);
                fs.Close();
              

            }






            
            
            

        }

        public void Switch()
        {
            if (Search.Text == "Google")
            {
                Search.Text = "Yandex";
            }
            else
            {
                Search.Text = "Google";
            }
        }

        public Form1()
        {
            InitializeComponent();

            MenuForm = new Form2();
            MenuForm.Owner = this;
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

   
        private void button4_Click(object sender, EventArgs e)
        {

            WebBrowser wb = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            wb.Stop();
            Check_url();
        }

       
        private void button7_Click(object sender, EventArgs e)
        {

            Switch();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
       
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            MenuForm.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (Search.Text == "Google")
            {

                WebBrowser wb = (WebBrowser)tabControl1.SelectedTab.Controls[0];
                wb.Navigate("https://www.google.com.ua/?gfe_rd=cr&ei=NzgCWLPgGZLGZO2Ml_AC&gws_rd=ssl#q=" + SearchText.Text);

            }
            else
            {

                WebBrowser wb = (WebBrowser)tabControl1.SelectedTab.Controls[0];
                wb.Navigate("https://yandex.ua/search/?lr=10347&msid=1476540805.94971.22895.21554&text=" + SearchText.Text);


            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
           

            WebBrowser wb = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            tabControl1.SelectedTab.Text = wb.DocumentTitle;
          



            if (!File.Exists("marks.bin"))
            {

                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("marks.bin", FileMode.OpenOrCreate);
                Bookmark mark = new Bookmark();
                mark.url = wb.Url.AbsoluteUri;


         //       mark.url = wb.Url.OriginalString;



                mark.title = wb.DocumentTitle;
              

                Marks.AddLast(mark);
                bf.Serialize(fs, Marks);   // Не хоче серіалізувати  поле url  об*єктів списку.
                fs.Close();

                /*****************************************/
                Console.WriteLine("Obj Url = " + mark.url);
                Console.WriteLine("Web URl = " + wb.Url.AbsoluteUri);
                /****************************************  Перевірка даних які серіалізуються.    */

            }
            else
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("marks.bin", FileMode.OpenOrCreate);

                Marks = (LinkedList<Bookmark>)bf.Deserialize(fs);

             




                Bookmark mark = new Bookmark();
                mark.url = wb.Url.AbsoluteUri;
                mark.title = wb.DocumentTitle;
                Marks.AddLast(mark);
                bf.Serialize(fs, Marks); // Не хоче серіалізувати  поле url  об*єктів списку.
                fs.Close();


                /*****************************************/
                Console.WriteLine("Obj Url = " + mark.url);
                Console.WriteLine("Web URl = " + wb.Url.AbsoluteUri);
                Console.WriteLine("Colletcion URl = " + Marks.Last.Value.url);
                /****************************************  Перевірка даних які серіалізуються.    */ 


            }



        }
    }
}
