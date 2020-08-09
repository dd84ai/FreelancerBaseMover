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

namespace FreelancerBaseMover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<List<double>> MatrixOfRotationX(double a)
        {
            //This is rotM^T matrix
            List<List<double>> temp = new List<List<double>>();

            temp.Add(new List<double>());
            temp.Add(new List<double>());
            temp.Add(new List<double>());

            temp[0].Add(1);
            temp[0].Add(0);
            temp[0].Add(0);

            temp[1].Add(0);
            temp[1].Add(Math.Cos(a));
            temp[1].Add(Math.Sin(a));

            temp[2].Add(0);
            temp[2].Add(-Math.Sin(a));
            temp[2].Add(Math.Cos(a));

            return temp;
        }
        private List<List<double>> MatrixOfRotationY(double a)
        {
            //This is rotM^T matrix
            List<List<double>> temp = new List<List<double>>();

            temp.Add(new List<double>());
            temp.Add(new List<double>());
            temp.Add(new List<double>());

            temp[0].Add(Math.Cos(a));
            temp[0].Add(0);
            temp[0].Add(-Math.Sin(a));

            temp[1].Add(0);
            temp[1].Add(1);
            temp[1].Add(0);

            temp[2].Add(Math.Sin(a));
            temp[2].Add(0);
            temp[2].Add(Math.Cos(a));

            return temp;
        }

        private List<List<double>> MatrixOfRotationZ(double a)
        {
            //This is rotM^T matrix
            List<List<double>> temp = new List<List<double>>();

            temp.Add(new List<double>());
            temp.Add(new List<double>());
            temp.Add(new List<double>());

            temp[0].Add(Math.Cos(a));
            temp[0].Add(Math.Sin(a));
            temp[0].Add(0);

            temp[1].Add(-Math.Sin(a));
            temp[1].Add(Math.Cos(a));
            temp[1].Add(0);

            temp[2].Add(0);
            temp[2].Add(0);
            temp[2].Add(1);

            return temp;
        }
        List<List<double>> rotate(List<List<double>> MatrixPos, List<List<double>> Rotation)
        {
            List<List<double>> MatrixPosRoted = new List<List<double>>();
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
            return MatrixPosRoted;
        }
        private double TextToRads(string txt)
        {
            return Convert.ToDouble(txt) * Math.PI / 180.0;
        }
        private string[] ScanFile(string FileName)
        {
            string[] lines = File.ReadAllLines(FileName);
            var tempic = lines.ToList();
            tempic.Add("");
            lines = tempic.ToArray();
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

            List<List<double>> RotationX = MatrixOfRotationX(
                TextToRads(textBox1_xrot.Text));
            List<List<double>> RotationY = MatrixOfRotationY(
                TextToRads(textBox1_yrot.Text));
            List<List<double>> RotationZ = MatrixOfRotationZ(
                TextToRads(textBox1_zrot.Text));

            //Default center.
            double Mother_a = 0, Mother_b = 0, Mother_c = 0;

            Mother_a = MatrixPos[0][0];
            Mother_b = MatrixPos[0][1];
            Mother_c = MatrixPos[0][2];
            /*bad default center, replace it to geimetrical center;
            int count = 0;
            foreach (var point in MatrixPos)
            {
                Mother_a += point[0];
                Mother_b += point[1];
                Mother_c += point[2];
                count++;
            }
            Mother_a /= count;
            Mother_b /= count;
            Mother_c /= count;*/

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
                for (int i = 0; i < MatrixPos.Count(); i++)
                {
                    MatrixPos[i][0] -= Mother_a;
                    MatrixPos[i][1] -= Mother_b;
                    MatrixPos[i][2] -= Mother_c;
                }
            }


            //rotate
            List<List<double>> MatrixPosRoted = rotate(MatrixPos,RotationX);
            MatrixPosRoted = rotate(MatrixPosRoted, RotationY);
            MatrixPosRoted = rotate(MatrixPosRoted, RotationZ);

            //change rots
            for (int i = 0; i < MatrixRot.Count(); i++)
            {
                MatrixRot[i][0] -= Convert.ToDouble(textBox1_xrot.Text);
                MatrixRot[i][1] -= Convert.ToDouble(textBox1_yrot.Text);
                MatrixRot[i][2] -= Convert.ToDouble(textBox1_zrot.Text);
            }

            //shift
            if (checkBox1_position.Checked)
                for (int i = 0; i < MatrixPosRoted.Count(); i++)
                {
                    MatrixPosRoted[i][0] += Convert.ToDouble(textBox1_xpos.Text);
                    MatrixPosRoted[i][1] += Convert.ToDouble(textBox1_ypos.Text);
                    MatrixPosRoted[i][2] += Convert.ToDouble(textBox1_zpos.Text);
                }
            else
            {
                for (int i = 0; i < MatrixPosRoted.Count(); i++)
                {
                    MatrixPosRoted[i][0] += Mother_a;
                    MatrixPosRoted[i][1] += Mother_b;
                    MatrixPosRoted[i][2] += Mother_c;
                }
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
                    lines[i] = "pos = " + Convert.ToInt32(Math.Round(MatrixPosRoted[PC][0])) + ", " + Convert.ToInt32(Math.Round(MatrixPosRoted[PC][1])) + ", " + Convert.ToInt32(Math.Round(MatrixPosRoted[PC][2]));
                    lines[i] += "\r\nrotate = " + Convert.ToInt32(Math.Round(MatrixRot[RC][0])) + ", " + Convert.ToInt32(Math.Round(MatrixRot[RC][1])) + ", " + Convert.ToInt32(Math.Round(MatrixRot[RC][2]));
                    PC++; RC++;
                }
            }

            //remove extra lines
            var sett = lines.ToList();
            while (sett[sett.Count - 1] == "")
                sett.RemoveAt(sett.Count - 1);

            lines = sett.ToArray();
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

        private void checkBox1_position_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1_position.Checked)
            {
                textBox1_xpos.Visible = true;
                textBox1_ypos.Visible = true;
                textBox1_zpos.Visible = true;
            }
            else
            {
                textBox1_xpos.Visible = false;
                textBox1_ypos.Visible = false;
                textBox1_zpos.Visible = false;
            }
        }
    }
}
