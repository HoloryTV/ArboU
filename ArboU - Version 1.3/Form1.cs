using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ArboU___Version_1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            this.flatTabControl1.SelectedIndex = 1;
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            this.flatTabControl1.SelectedIndex = 2;
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            if (flatCheckBox7.Checked == true) 
            {
                if (radioButton1.Checked == true)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C" + "FORMAT " + flatComboBox1.Text + "/Y /FS:FAT32 /A:32k /V:Wii /Q";
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                }
                else
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C" + "FORMAT " + flatComboBox1.Text + "/Y /FS:FAT32 /A:64k /V:Wii /Q";
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                }
            }

            if (flatCheckBox1.Checked == true) System.IO.Compression.ZipFile.ExtractToDirectory(@"homebrews/loadiine.zip", flatComboBox1.Text);
            if (flatCheckBox2.Checked == true) System.IO.Compression.ZipFile.ExtractToDirectory(@"homebrews/hbl.zip", flatComboBox1.Text);
            if (flatCheckBox3.Checked == true) System.IO.Compression.ZipFile.ExtractToDirectory(@"homebrews/ftpiiu.zip", flatComboBox1.Text);
            if (flatCheckBox4.Checked == true) System.IO.Compression.ZipFile.ExtractToDirectory(@"homebrews/hbas.zip", flatComboBox1.Text);
            if (flatCheckBox1.Checked == true && flatCheckBox5.Checked == true) System.IO.Compression.ZipFile.ExtractToDirectory(@"homebrews/covers.zip", flatComboBox1.Text);
            if (flatCheckBox1.Checked == true && flatCheckBox6.Checked == true) System.IO.Compression.ZipFile.ExtractToDirectory(@"homebrews/www.zip", flatComboBox1.Text);
            if (flatCheckBox8.Checked == true) Process.Start("https://www.youtube.com/c/HoloryTV1?sub_confirmation=1");
        }
    }
}
