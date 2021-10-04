using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace git_activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
              private void button1_Click(object sender, EventArgs e)
        {
                string path =@".\Untitled.txt";
                if(File.Exists(path)){
                    using(StreamReader reader= new StreamReader(path)){
                        string text;
                        while((text = reader.ReadLine()) != null){
                             listBox1.Items.Add(text);
                        }
                    }
                }
        }
    }
}
