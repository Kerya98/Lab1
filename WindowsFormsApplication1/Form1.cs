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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(File.Open("index.html", FileMode.Open), Encoding.GetEncoding(1251));
            String line = sr.ReadToEnd();
            sr.Close();
            richTextBoxInput.Text = line;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '<' && line[i + 1] == '/' && line[i + 2] == 'a' && line[i + 3] == '>')
                    ChangeTegEnd(i, "</a>".Length, ref line);

                if (line[i] == '<' && line[i + 1] == 'a')
                    ChangeTegStart(i, "<a href".Length, ref line);
            }

            richTextBoxOutput.Text = line;
        }

        private void ChangeTegEnd(int startIndex, int length, ref string line)
        {
            line = line.Remove(startIndex, length);
            line = line.Insert(startIndex, "[/URL]");
        }



        private void ChangeTegStart(int startIndex, int length, ref string line)
        {
            line = line.Remove(startIndex, length);
            line = line.Insert(startIndex, "[URL");

            Boolean flag = true;
            int i = 0;
            while (flag)
            {
                if (line[startIndex + i] == '"' && line[startIndex + i + 1] == '>')
                {
                    flag = false;
                    line = line.Remove(startIndex + i, 2);
                    line = line.Insert(startIndex + i, "]");
                }
                i++;
            }
        }
    }
}
