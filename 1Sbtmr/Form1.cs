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

namespace _1Sbtmr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void button1_Click_1(object sender, EventArgs e)
        {
            

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "*.txt";
            saveFile.Filter = "Test files|*.txt";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName, true))
                {
                    sw.WriteLine(label1.Text);
                    sw.WriteLine(textBox1.Text);
                    sw.WriteLine(label2.Text);
                    sw.WriteLine(textBox2.Text);
                    sw.WriteLine(label3.Text);
                    sw.WriteLine(textBox3.Text);
                    sw.WriteLine(label4.Text);
                    sw.WriteLine(textBox4.Text);
                    sw.WriteLine(label5.Text);
                    sw.WriteLine(textBox5.Text);
                    sw.WriteLine(label6.Text);
                    sw.WriteLine(textBox6.Text);
                    sw.WriteLine(label7.Text);
                    sw.WriteLine(textBox7.Text);
                    sw.Close();
                    
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();

                MessageBox.Show("Файл сохранен.");
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
      

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        
                        label1.Text = sr.ReadLine();
                        textBox1.Text = sr.ReadLine();
                        label2.Text = sr.ReadLine();
                        textBox2.Text = sr.ReadLine();
                        label3.Text = sr.ReadLine();
                        textBox3.Text = sr.ReadLine();
                        label4.Text = sr.ReadLine();
                        textBox4.Text = sr.ReadLine();
                        label5.Text = sr.ReadLine();
                        textBox5.Text = sr.ReadLine();
                        label6.Text = sr.ReadLine();
                        textBox6.Text = sr.ReadLine();
                        label7.Text = sr.ReadLine();
                        textBox7.Text = sr.ReadLine();

                        sr.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Выбранный файл не существует.");
                }
            }
        }


    }

}
