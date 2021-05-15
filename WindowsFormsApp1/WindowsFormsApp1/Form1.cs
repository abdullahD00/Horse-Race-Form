using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.URL = "C:\\Users\\abdul\\Desktop\\work\\denemeler\\C#\\sinemasalonu\\foto ve müzik\\1.MP3";
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 nasıloynanır = new Form2();
            nasıloynanır.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 oyunsayfası = new Form3();
            oyunsayfası.Show();
            this.Hide();
        }
    }
}
