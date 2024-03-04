using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;

namespace Mover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "" || fromBox.Text == "" || toBox.Text == "")
            {
                outputBox.Clear();
                outputBox.Text += "Поля должны быть заполнены";
            }
            else if (!int.TryParse(fromBox.Text, out int a))
            {
                outputBox.Clear();
                outputBox.Text += "Значение \"a\" должно являться числом";
            }
            else if (!int.TryParse(toBox.Text, out int b))
            {
                outputBox.Clear();
                outputBox.Text += "Значение \"b\" должно являться числом";
            }
            else if (b < a || a <= 0 || b <= 0)
            {
                outputBox.Clear();
                outputBox.Text += "Значение \"a\" и \"b\" должны быть положительными и образовывать отрезок";
            }
            else if (a > inputBox.Text.Split().Length || b > inputBox.Text.Split().Length)
            {
                outputBox.Clear();
                outputBox.Text += "Значение \"a\" и \"b\" не должны превышать количество слов";
            }
            else
            {
                try
                {
                    string phrase = inputBox.Text;
                    string wordsNum = phrase.Trim();
                    wordsNum = wordsNum.ToLower();
                    wordsNum = Regex.Replace(wordsNum, @"\s+", " ");
                    List<string> words = wordsNum.Split(' ').ToList();
                    Console.WriteLine(words);
                    List<string> words2 = words.GetRange(a - 1, b - a + 1);

                    words.RemoveRange(a - 1, b - a + 1);
                    words2.AddRange(words);

                    outputBox.Text = string.Join(' ', words2);
                }
                catch (System.Exception exception)
                {
                    outputBox.Text += "Ошибка";
                }
            }
        }

    }
}
