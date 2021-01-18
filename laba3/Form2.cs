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
    public partial class Form2 : Form
    {
        public Form1 form;
        public Form2()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rectagle = new Rectangle(int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            ShapeContainer.AddFigure(rectagle);
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(Init.pen, float.Parse(textBox3.Text), float.Parse(textBox4.Text), float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            Init.pictureBox.Image = Init.bitmap;
            this.Visible = false;
            form.Visible = true;

        }
    }
}
