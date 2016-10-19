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

namespace TextEditor
{
    public partial class Form1 : Form
    {
        FontDialog font_choice;

        public void Save_F(string Path, TextUnit unit)
        {
            var bf = new BinaryFormatter();
            var fs = new FileStream(Path,FileMode.OpenOrCreate);
            bf.Serialize(fs, unit);
            fs.Close();

        }

        public TextUnit Load_F(string Path)
        {
            TextUnit temp;
            var bf = new BinaryFormatter();
            var fs = new FileStream(Path, FileMode.OpenOrCreate);
            temp = (TextUnit)   bf.Deserialize(fs);
            fs.Close();
            return temp;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {


            TabForm frm = new TabForm();
            frm.Show();
            frm.MdiParent = this;
            this.LayoutMdi(MdiLayout.Cascade);
            this.LayoutMdi(MdiLayout.TileHorizontal);
            this.LayoutMdi(MdiLayout.TileVertical);
            this.LayoutMdi(MdiLayout.ArrangeIcons);
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Editor Files(*.ef)|*.ef";
            of.Title = "Open File";
            of.InitialDirectory= Application.StartupPath;
            var result = of.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextUnit unit = Load_F(of.FileName);
                frm.Controls[0].Font = unit.font;
                frm.Controls[0].Text = unit.text;
                frm.path = of.FileName;


            }


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) { 
            var temp_form = (TabForm)ActiveMdiChild;
            if (temp_form.path == null)
            {
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Editor Files(*.ef)|*.ef";
                sd.Title = "Save file to...";
                sd.InitialDirectory = Application.UserAppDataPath;
                var result = sd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (ActiveMdiChild == null) { MessageBox.Show("Nothing to save."); }
                    else
                    {
                        TextUnit unit = new TextUnit();
                        unit.font = ActiveMdiChild.Controls[0].Font;
                        unit.text = ActiveMdiChild.Controls[0].Text;
                        Save_F(sd.FileName, unit);
                    }
                }

            }
            else
            {
                TextUnit unit = new TextUnit();
                unit.text = temp_form.Controls[0].Text;
                unit.font = temp_form.Controls[0].Font;
                Save_F(temp_form.path, unit);



            }
            }



        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TabForm frm = new TabForm();
            frm.Show();
            frm.MdiParent = this;
            this.LayoutMdi(MdiLayout.Cascade);
            this.LayoutMdi(MdiLayout.TileHorizontal);
            this.LayoutMdi(MdiLayout.TileVertical);
            this.LayoutMdi(MdiLayout.ArrangeIcons);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            font_choice = fontDialog1;
            
            var res= font_choice.ShowDialog();
            if (res == DialogResult.OK && ActiveMdiChild!=null) { 
            ActiveMdiChild.Controls[0].Font = font_choice.Font;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) { 

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Editor Files(*.ef)|*.ef";
            sd.Title = "Save file to...";
            sd.InitialDirectory = Application.UserAppDataPath;
            var result = sd.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (ActiveMdiChild == null) { MessageBox.Show("Nothing to save."); }
                else
                {
                    TextUnit unit = new TextUnit();
                    unit.font = ActiveMdiChild.Controls[0].Font;
                    unit.text = ActiveMdiChild.Controls[0].Text;
                    Save_F(sd.FileName, unit);
                }
               }
        }


            }
        }
    [Serializable]
    public class TextUnit
    {
     public   string text;
     public Font font;
    }

}
