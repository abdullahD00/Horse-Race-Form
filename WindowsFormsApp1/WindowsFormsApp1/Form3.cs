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
    public partial class Form3 : Form
    {
        public Form3()
        {

            InitializeComponent();
            label6.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            textBox1.Visible = false;
            label7.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            textBox2.Visible = false;
            label8.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            textBox3.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label5.Visible = false;
            comboBox1.Text = "3";
            comboBox1.Visible = false;
        }
            int birincininbahisi;
            int ikincininbahisi;
            int ucuncununbahisi;
        int birinciatınsolauzaklık;
        int ikinciatınsolauzaklık;
        int ucuncuatınsolauzaklık;
        int bitiscizgisi;
        int birincigenis;
        int ikincigenis;
        int ucuncugenis;
        Random karma = new Random();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1")
            {
                label6.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                textBox1.Visible = true;
                label7.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                textBox2.Visible = false;
                label8.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                textBox3.Visible = false;

                button1.Visible = true;
                button2.Visible = true;

            }
            if (comboBox1.Text == "2")
            {
                label6.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                textBox1.Visible = true;
                label7.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                textBox2.Visible = true;
                label8.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                textBox3.Visible = false;

                button1.Visible = true;
                button2.Visible = true;
            }
            if (comboBox1.Text == "3")
            {
                label6.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                textBox1.Visible = true;
                label7.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                textBox2.Visible = true;
                label8.Visible = true;
                radioButton7.Visible = true;
                radioButton8.Visible = true;
                radioButton9.Visible = true;
                textBox3.Visible = true;

                button1.Visible = true;
                button2.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Enabled == true )
            {
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Enabled == true)
            {
                radioButton1.Enabled = false;
                radioButton3.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Enabled == true)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            birincininbahisi = Convert.ToInt32(textBox1.Text);
            textBox1.Enabled = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Enabled == true)
            {
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Enabled ==true)
            {
                radioButton6.Enabled = false;
                radioButton4.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Enabled==true)
            {
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ikincininbahisi = Convert.ToInt32(textBox2.Text);
            textBox2.Enabled = false;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton9.Enabled==true)
            {
                radioButton7.Enabled = false;
                radioButton8.Enabled = false;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Enabled == true)
            {
                radioButton9.Enabled = false;
                radioButton7.Enabled = false;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton7.Enabled==true)
            {
                radioButton8.Enabled = false;
                radioButton9.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ucuncununbahisi = Convert.ToInt32(textBox3.Text);
            textBox3.Enabled = false;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            birinciatınsolauzaklık = pictureBox1.Left;
            ikinciatınsolauzaklık = pictureBox2.Left;
            ucuncuatınsolauzaklık = pictureBox3.Left;
            birincigenis = pictureBox1.Width;
            ikincigenis = pictureBox2.Width;
            ucuncugenis = pictureBox3.Width;
            bitiscizgisi = label4.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + karma.Next(5, 20);
            pictureBox2.Left = pictureBox2.Left + karma.Next(5, 20);
            pictureBox3.Left = pictureBox3.Left + karma.Next(5, 20);

            if(pictureBox1.Left + pictureBox1.Width >= bitiscizgisi )
             {  
                timer1.Enabled = false;
                label9.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label10.Text = "1.AT KAZANDI";
                label10.Visible = true;
                if (radioButton1.Enabled == true)
                {
                    birincininbahisi = birincininbahisi + ikincininbahisi + ucuncununbahisi ;
                    label14.Text = birincininbahisi.ToString();
                }
                if(radioButton6.Enabled==true)
                {
                    ikincininbahisi = ikincininbahisi + birincininbahisi + ucuncununbahisi ;
                    label15.Text = ikincininbahisi.ToString();
                }
                if (radioButton9.Enabled == true)
                {
                    ucuncununbahisi = ucuncununbahisi + birincininbahisi + ikincininbahisi ;
                    label16.Text = ucuncununbahisi.ToString();
                }
                


            }
            if(pictureBox2.Left + pictureBox2.Width >=bitiscizgisi)
            {
                timer1.Enabled = false;
                label9.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label10.Text = "2.AT KAZANDI";
                label10.Visible = true;
                if(radioButton2.Enabled==true)
                {
                    birincininbahisi = birincininbahisi + ikincininbahisi+ucuncununbahisi ;
                    label14.Text = birincininbahisi.ToString();
                }
                if(radioButton5.Enabled==true)
                {
                    ikincininbahisi = ikincininbahisi + birincininbahisi+ucuncununbahisi ;
                    label15.Text = ikincininbahisi.ToString();
                }
                if(radioButton8.Enabled==true)
                {
                    ucuncununbahisi = ucuncununbahisi + birincininbahisi + ikincininbahisi ;
                    label16.Text = ucuncununbahisi.ToString();
                }

                
            }
            if(pictureBox3.Left + pictureBox3.Width >= bitiscizgisi )
            {
                timer1.Enabled = false;
                label9.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label10.Text = "3.AT KAZANDI";
                label10.Visible = true;

                if (radioButton3.Enabled == true)
                {
                    birincininbahisi = birincininbahisi + ikincininbahisi + ucuncununbahisi ;
                    label14.Text = birincininbahisi.ToString();
                }
                if(radioButton4.Enabled==true)
                {
                    ikincininbahisi = ikincininbahisi + birincininbahisi + ucuncununbahisi ;
                    label15.Text = ikincininbahisi.ToString();
                }
                if(radioButton7.Enabled==true)
                {
                    ucuncununbahisi = ucuncununbahisi + birincininbahisi + ikincininbahisi ;
                    label16.Text = ucuncununbahisi.ToString();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
