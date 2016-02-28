﻿using System;
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
                    ChangeTegEnd(i, ref line);

                if (line[i] == '<' && line[i + 1] == 'a')
                    ChangeTegStart(i, ref line);
            }

            richTextBoxOutput.Text = line;
        }

        private void ChangeTegEnd(int startIndex, ref string line)
        {

        }

        private void ChangeTegStart(int startIndex, ref string line)
        {           
            
        }
    }
}
