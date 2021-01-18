using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Pen pen;
        private Rectangle rect;

        public Form1()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            this.pen = new Pen(Color.Black, 5);
            Init.bitmap= this.bitmap;
            Init.pictureBox = this.pictureBox1;
            Init.pen = this.pen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.GetType() == (new Rectangle()).GetType())
            {
                this.rect = (Rectangle)comboBox1.SelectedItem;
                this.rect.MoweTo(int.Parse(textBoxDx.Text), int.Parse(textBoxDy.Text));
            }
        }

        private void эллипсToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void прямоуголоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.form = this;
            f2.Show();
            this.Visible = false;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach(var i in ShapeContainer.figurelist)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void эллипсToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.GetType() == (new Rectangle()).GetType())
            {
                this.rect = (Rectangle)comboBox1.SelectedItem;
                this.rect.DeleteF(this.rect, true);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
