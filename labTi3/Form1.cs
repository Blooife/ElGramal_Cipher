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

namespace labTi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public byte[] ReadFile(string filePath)
        {
            List<byte> list = new List<byte>();
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                    list.Add(reader.ReadByte());
            }

            return list.ToArray();
        }

        public void WriteFile(string filePath, byte[] bytes)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    writer.Write(bytes[i]);
                }
            }
        }

        Program.ElGramal elGramal = new Program.ElGramal();

        private void button1_Click(object sender, EventArgs e)
        {
            long k, x;
            if (richTextBox1.Text != "")
            {
                if (Int64.TryParse(textBoxK.Text, out k) && Int64.TryParse(textBoxX.Text, out x))
                {
                    if (x > 1 && x < elGramal.p - 1)
                    {
                        if (elGramal.isCoPrime(k, elGramal.p - 1) && k>1 && x < elGramal.p-1)
                        {
                            if (comboBoxG.SelectedIndex > -1)
                            {
                                elGramal.k = k;
                                elGramal.x = x;
                                elGramal.g = elGramal.primeRoots[comboBoxG.SelectedIndex];
                                elGramal.Encrypt();
                                int bd = 0;
                                if (elGramal.cipherS.Length / 2 > 1000)
                                {
                                    bd = 500;
                                }
                                else
                                {
                                    bd = elGramal.cipherS.Length / 2;
                                }

                                textBoxY.Text = elGramal.y.ToString();
                                richTextBox2.Text = "";
                                for (int i = 0; i < bd; i++)
                                {
                                    richTextBox2.AppendText($"{elGramal.cipherS[i<<1]} {elGramal.cipherS[(i<<1)+1]} | ");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Не выбрано g");
                            }
                        }
                        else
                        {
                            MessageBox.Show("некорректное k");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введён x<2 или >p-2");
                    }
                }
                else
                {
                    MessageBox.Show("Введён некорректный k или x");
                }
            }
            else
            {
                MessageBox.Show("Не открыт никакой файл");
            }
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ButCalcG_Click(object sender, EventArgs e)
        {
            long p;
            if (Int64.TryParse(textBoxP.Text, out p))
            {
                if (elGramal.isPrime(p))
                {
                    if (p > 255)
                    {
                        elGramal.p = p;
                        elGramal.GetAllPrimeDivs(p - 1);
                        elGramal.GetAllPrimeRoots(p);
                        foreach (var obj in elGramal.primeRoots)
                        {
                            comboBoxG.Items.Add(obj);
                        }
                        comboBoxG.SelectedIndex = 0;
                        lNum.Text = elGramal.primeRoots.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("p должно быть больше 255");

                    }
                }
                else
                {
                    MessageBox.Show("Вы ввели непростое число.");
                }
            }
            else
            {
                MessageBox.Show("Введено некорректное значение p");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public byte[] OpenFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return null;
            string filePath = openFileDialog1.FileName;
            var pl = ReadFile(filePath);
            MessageBox.Show("Файл прочитан успешно");
            return pl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            elGramal.plaintextB = OpenFile();
            int bd = 0;
            if (elGramal.plaintextB.Length > 1000)
            {
                bd = 1000;
            }
            else
            {
                bd = elGramal.plaintextB.Length;
            }

            richTextBox1.Text = "";
            for (int i = 0; i < bd; i++)
            {
                richTextBox1.AppendText(elGramal.plaintextB[i].ToString() + " ");
            }
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            elGramal.cipherB = OpenFile();
            int bd = 0;
            if (elGramal.cipherB.Length / 4 > 1000)
            {
                bd = 250;
            }
            else
            {
                bd = elGramal.cipherB.Length / 4;
            }

            richTextBox3.Text = "";
            for (int i = 0; i < bd; i++)
            {
                byte a1 = elGramal.cipherB[i<<2];
                byte a2 = elGramal.cipherB[(i << 2) + 1];
                byte b1 = elGramal.cipherB[(i << 2) + 2];
                byte b2 = elGramal.cipherB[(i << 2) + 3];
                short a = (short)((a2 << 8) | a1);
                short b = (short)((b2 << 8) | b1);
                richTextBox3.AppendText(a.ToString() + " " + b.ToString()+" | ");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            long p, x;
            if (richTextBox3.Text != "")
            {
                if (Int64.TryParse(textBoxPC.Text, out p) && Int64.TryParse(textBoxXC.Text, out x))
                {
                    if (elGramal.isPrime(p))
                    {
                        if (p > 255)
                        {
                            elGramal.p = p; 
                            if (x > 1 && x < elGramal.p - 1)
                            {
                                elGramal.x = x;
                                elGramal.Decrypt();
                                int bd = 0;
                                if (elGramal.plaintextB.Length > 1000)
                                {
                                    bd = 1000;
                                }
                                else
                                {
                                    bd = elGramal.plaintextB.Length;
                                }

                                richTextBox4.Text = "";
                                for (int i = 0; i < bd; i++)
                                {
                                    richTextBox4.AppendText(elGramal.plaintextB[i].ToString()+" ");
                                }
                            }
                            else
                            {
                                MessageBox.Show("x должно быть больше 1 и меньше p-1");
                            }
                        }
                        else MessageBox.Show("p должно быть больше 255");
                    }
                    else
                    {
                        MessageBox.Show("p должго быть простым.");
                    }
                }
                else
                {
                    MessageBox.Show("Некорректно введены p или x");
                }
            }
            else
            {
                MessageBox.Show("Не открыт никакой файл");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filePath = saveFileDialog1.FileName;
            try
            {
                WriteFile(filePath, elGramal.plaintextB);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка, возможно ещё ничего не расшифрованно");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filePath = saveFileDialog1.FileName;
            try
            {
                WriteFile(filePath, elGramal.cipherB);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка, возможно ещё ничего не зашифрованно");
            }
           
        }
    }
}