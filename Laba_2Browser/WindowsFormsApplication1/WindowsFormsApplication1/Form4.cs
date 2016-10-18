using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        LinkedList<Bookmark> marks;
        Bookmark[] MarksArray;

        public Form4()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (File.Exists("marks.bin"))
            {
                File.Delete("marks.bin");
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {

                    dataGridView1.Rows.RemoveAt(i);

                }
            }
            MessageBox.Show("Folder clear.");
        }

        private void Form4_Load(object sender, EventArgs e)
        {



            if (File.Exists(Application.CommonAppDataPath + "marks.bin"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(Application.CommonAppDataPath + "marks.bin", FileMode.OpenOrCreate);

                marks = (LinkedList<Bookmark>)bf.Deserialize(fs);

                fs.Close();



                MarksArray = marks.ToArray();

                for (int i = 0; i < MarksArray.Count(); i++)
                {

                    dataGridView1.Rows.Add(MarksArray[i].title, MarksArray[i].url);

                }
            }
            else
            {
                MessageBox.Show("No Bookmarks.");

            }


        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
