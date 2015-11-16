using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = int.Parse(this.textBox1.Text);

            Function1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = int.Parse(this.textBox1.Text);
            Function2();
        }

        private void Function1()
        {
            for (int i = 0; i < count; i++)
            {
                File.Create(Application.StartupPath+ @"\Test\aaa" + i + ".txt");
            }
        }


        private void Function2()
        {
            for (int i = 0; i < count; i++)
            {
                this.Text = i.ToString();
            }
        }


    }
}
