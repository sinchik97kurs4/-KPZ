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
    public partial class Form3 : Form
    {
        LinkedList<Story> History = new LinkedList<Story>();
        Story []HistoryArray; 
        public Form3()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete("story.bin");
          
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                
                    dataGridView1.Rows.RemoveAt(i);
                
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            if (!File.Exists("story.bin"))
            {
                MessageBox.Show("Story is clear");

            }
            else
            {

                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("story.bin", FileMode.OpenOrCreate);
                History = (LinkedList<Story>)bf.Deserialize(fs);
                fs.Close();
                HistoryArray = History.ToArray();

                for (int i = 0; i < HistoryArray.Count(); i++)
                {
                    dataGridView1.Rows.Add(HistoryArray[i].title, HistoryArray[i].dateTime, HistoryArray[i].url);

                }

            }

        }
    }
}
