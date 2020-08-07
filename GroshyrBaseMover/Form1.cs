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

namespace GroshyrBaseMover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<List<double>> MatrixOfRotation(double a, double b, double y)
        {
            //This is rotM^T matrix
            List<List<double>> temp = new List<List<double>>();

            temp.Add(new List<double>());
            temp.Add(new List<double>());
            temp.Add(new List<double>());
            temp[0].Add(Math.Cos(a) * Math.Cos(b));
            temp[0].Add(Math.Sin(a) * Math.Cos(b));
            temp[0].Add(-Math.Sin(a));

            temp[1].Add(Math.Cos(a) * Math.Sin(b) * Math.Sin(y) - Math.Sin(a) * Math.Cos(y));
            temp[1].Add(Math.Sin(a) * Math.Sin(b) * Math.Sin(y) + Math.Cos(a) * Math.Cos(y));
            temp[1].Add(Math.Cos(b) * Math.Sin(y));

            temp[2].Add(Math.Cos(a) * Math.Sin(b) * Math.Cos(y) + Math.Sin(a) * Math.Sin(y));
            temp[2].Add(Math.Sin(a) * Math.Sin(b) * Math.Cos(y) - Math.Cos(a) * Math.Sin(y));
            temp[2].Add(Math.Cos(b) * Math.Cos(y));

            return temp;
        }
        private double TextToRads(string txt)
        {
            return Convert.ToDouble(txt) * Math.PI / 180.0;
        }
        private string[] ScanFile(string FileName)
        {
            string[] lines = File.ReadAllLines(FileName);
            List<string> poses = new List<string>(lines.Where(x => x.Replace(" ", "").Contains("pos=")));
            List<string> rotes = new List<string>();//(lines.Where(x => x.Replace(" ", "").Contains("rotate=")));
            bool EncounteredPos = false;
            foreach (var line in lines)
            {
                if (line.Replace(" ", "").Contains("pos="))
                {
                    if (EncounteredPos) rotes.Add("rotate=0,0,0");
                    EncounteredPos = true;
                }

                if (line.Replace(" ", "").Contains("rotate="))
                {
                    rotes.Add(line.Replace(" ", ""));
                    EncounteredPos = false;
                }
            }
            if (EncounteredPos) rotes.Add("rotate=0,0,0");

            List<List<double>> MatrixPos = new List<List<double>>();
            List<List<double>> MatrixPosRoted = new List<List<double>>();
            List<List<double>> MatrixRot = new List<List<double>>();

            foreach (var line in poses)
            {
                MatrixPos.Add(new List<double>(line.Replace(" ", "")
                    .Replace("pos=", "").Split(',')
                    .Select(x => Convert.ToDouble(x)).ToArray()));
            }
            foreach (var line in rotes)
            {
                MatrixRot.Add(new List<double>(line.Replace(" ", "")
                    .Replace("rotate=", "").Split(',')
                    .Select(x => Convert.ToDouble(x)).ToArray()));
            }

            List<List<double>> Rotation = MatrixOfRotation(
                TextToRads(textBox1_xrot.Text),
                TextToRads(textBox1_yrot.Text),
                TextToRads(textBox1_zrot.Text));

            //make relative coordinates.
            if (checkBox1_mot.Checked)
            {
                for (int i = 0; i < MatrixPos.Count(); i++)
                {
                    MatrixPos[i][0] -= Convert.ToDouble(textBox1_xmot.Text);
                    MatrixPos[i][1] -= Convert.ToDouble(textBox1_ymot.Text);
                    MatrixPos[i][2] -= Convert.ToDouble(textBox1_zmot.Text);
                }
            }
            else
            {
                double a = MatrixPos[0][0];
                double b = MatrixPos[0][1];
                double c = MatrixPos[0][2];
                for (int i = 0; i < MatrixPos.Count(); i++)
                {
                    MatrixPos[i][0] -= a;
                    MatrixPos[i][1] -= b;
                    MatrixPos[i][2] -= c;
                }
            }

            //rotate
            for (int i = 0; i < MatrixPos.Count(); i++)
            {
                MatrixPosRoted.Add(new List<double>());

                double temp = 0;
                for (int j = 0; j < 3; j++)
                    temp += MatrixPos[i][j] * Rotation[0][j];
                MatrixPosRoted[i].Add(temp);

                temp = 0;
                for (int j = 0; j < 3; j++)
                    temp += MatrixPos[i][j] * Rotation[1][j];
                MatrixPosRoted[i].Add(temp);

                temp = 0;
                for (int j = 0; j < 3; j++)
                    temp += MatrixPos[i][j] * Rotation[2][j];
                MatrixPosRoted[i].Add(temp);
            }

            //change rots
            for (int i = 0; i < MatrixRot.Count(); i++)
            {
                MatrixRot[i][0] += Convert.ToDouble(textBox1_xrot.Text);
                MatrixRot[i][1] += Convert.ToDouble(textBox1_yrot.Text);
                MatrixRot[i][2] += Convert.ToDouble(textBox1_zrot.Text);
            }

            //shift
            for (int i = 0; i < MatrixPosRoted.Count(); i++)
            {
                MatrixPosRoted[i][0] += Convert.ToDouble(textBox1_xpos.Text);
                MatrixPosRoted[i][1] += Convert.ToDouble(textBox1_ypos.Text);
                MatrixPosRoted[i][2] += Convert.ToDouble(textBox1_zpos.Text);
            }

            //end operation
            int PC = 0;
            int RC = 0;
            for (int i = 0; i < lines.Count(); i++)
            {
                if (lines[i].Replace(" ", "")
                    .Contains("rotate="))
                        {
                    for (int j = i; j < lines.Count()-1; j++)
                        lines[j] = lines[j + 1];
                        
                }
                lines[lines.Count() - 1] = "";
            }
                    for (int i = 0; i < lines.Count(); i++)
            {
                if (lines[i].Replace(" ", "")
                    .Contains("pos="))
                {
                    lines[i] = "pos = " + (int)(MatrixPosRoted[PC][0]) + ", " + (int)MatrixPosRoted[PC][1] + ", " + (int)MatrixPosRoted[PC][2];
                    lines[i] += "\r\nrotate = " + (int)MatrixRot[RC][0] + ", " + (int)MatrixRot[RC][1] + ", " + (int)MatrixRot[RC][2];
                    PC++; RC++;
                }
            }

            return lines;
        }
        private void button1_create_file_Click(object sender, EventArgs e)
        {
            try
            {
                var lines = ScanFile(textBox1_fileaddress.Text);
                System.IO.File.WriteAllLines("b.txt", lines);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void button1_process_Click(object sender, EventArgs e)
        {
            try
            {
                var lines = ScanFile(textBox1_fileaddress.Text);
            System.IO.File.WriteAllLines(textBox1_fileaddress.Text, lines);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void checkBox1_mot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1_mot.Checked)
            {
                textBox1_xmot.Visible = true;
                textBox1_ymot.Visible = true;
                textBox1_zmot.Visible = true;
            }
            else
            {
                textBox1_xmot.Visible = false;
                textBox1_ymot.Visible = false;
                textBox1_zmot.Visible = false;
            }
        }
    }
}
