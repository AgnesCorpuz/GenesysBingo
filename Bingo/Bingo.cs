using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Bingo : Form
    {
        int[] arr = Enumerable.Range(1, 75).ToArray();
        string[] bingo = new string[75];
        List<string> drawsList = new List<string>();
        private bool pause = false;

        public Bingo()
        {
            InitializeComponent();            
        }

        private void Bingo_Load(object sender, System.EventArgs e)
        {
            for (int i = 0; i <= (arr.Length - 1); i++)
            {
                if (arr[i] > 0) { bingo[i] = "B" + arr[i]; }
                if (arr[i] > 15) { bingo[i] = "I" + arr[i]; }
                if (arr[i] > 30) { bingo[i] = "N" + arr[i]; }
                if (arr[i] > 45) { bingo[i] = "G" + arr[i]; }
                if (arr[i] > 60) { bingo[i] = "O" + arr[i]; }
            }

            FixControls();
        }

        private void FixControls()
        {
            panel1.Height = panel1.Parent.Height - tabControl.Height;
            panel1.Width = panel1.Parent.Width;

            lblLetter.Left = (lblLetter.Parent.Width - lblLetter.Width - lblNumber.Width) / 2;
            lblLetter.Top = ((lblLetter.Parent.Height - lblLetter.Height) / 2) + 30;

            lblNumber.Left = lblLetter.Left + lblLetter.Width + 10;
            lblNumber.Top = lblLetter.Top;

            lblDrawsLeft.Left = (lblDrawsLeft.Parent.Width - lblDrawsLeft.Width) / 2;
            lblDrawsLeft.Top = lblLetter.Top + lblLetter.Height + 10;

            btnGenerate.Left = lblNumber.Width + lblNumber.Left + 10;
            btnGenerate.Top = lblLetter.Top;

            btnClear.Left = lblNumber.Width + lblNumber.Left + 10;
            btnClear.Top = btnGenerate.Top + btnGenerate.Height + 10;

            txtAll.Width = tabControl.Width;
            txtAll.Height = tabControl.Height;
            lblDrawn.Width = tabControl.Width;
            lblDrawn.Height = tabControl.Height;
            lblDrawn.MaximumSize = new Size(tabControl.Width, tabControl.Height);
            txtAll.MaximumSize = new Size(tabControl.Width, tabControl.Height);
        }

        private void Bingo_SizeChanged(object sender, EventArgs e)
        {
            FixControls();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!pause)
            {
                tmMain1.Interval = 50;
                tmMain1.Enabled = true;
                tmMain2.Interval = 100;
                tmMain2.Enabled = true;
                pause = true;
                btnGenerate.Text = "Stop";

                if (drawsList.Count == 75)
                {
                    btnGenerate.Enabled = false;
                    lblDrawsLeft.Text = "Draws Left: 0";
                }
                else if (drawsList.Count >= 65)
                {
                    lblDrawsLeft.ForeColor = Color.Red;
                }

                lblDrawsLeft.Text = "Draws Left: " + (74 - drawsList.Count);
            }
            else
            {
                tmCtrl1.Enabled = true;
                btnGenerate.Enabled = false;
                pause = false;
            }
        }

        private void show()
        {
            if (Convert.ToInt32(lblNumber.Text) > 0) { lblLetter.Text = "B"; }
            if (Convert.ToInt32(lblNumber.Text) > 15) { lblLetter.Text = "I"; }
            if (Convert.ToInt32(lblNumber.Text) > 30) { lblLetter.Text = "N"; }
            if (Convert.ToInt32(lblNumber.Text) > 45) { lblLetter.Text = "G"; }
            if (Convert.ToInt32(lblNumber.Text) > 60) { lblLetter.Text = "O"; }

            string drawn = lblDrawn.Text;
            lblDrawn.Text = drawn + lblLetter.Text + lblNumber.Text + "  ";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = true;

            string allText = txtAll.Text + " \r\n \r\n" + lblDrawn.Text;
            txtAll.Text = allText.TrimStart();

            lblLetter.Text = "--";
            lblNumber.Text = "--";
            lblDrawn.Text = "";
            lblDrawsLeft.Text = "Draws Left: 75";
            lblDrawsLeft.ForeColor = Color.Black;
            lblLetter.ForeColor = Color.Black;
            lblNumber.ForeColor = Color.Black;

            drawsList = new List<string>();
        }

        private void tmMain1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string draw = bingo.ToArray()[rnd.Next(0, bingo.Length)];

            while (drawsList.Contains(draw, StringComparer.Ordinal) && drawsList.Count > 1)
            {
                draw = bingo.ToArray()[rnd.Next(0, bingo.Length)];
            }

            lblLetter.Text = draw[0].ToString();           
            lblLetter.ForeColor = Color.Red;            
            lblNumber.ForeColor = Color.Red;
        }

        private void tmCtrl1_Tick(object sender, EventArgs e)
        {
            tmMain1.Interval += 40;
            if (tmMain1.Interval >= 400)
            {
                lblLetter.ForeColor = Color.Green;
                tmMain1.Enabled = false;
                tmCtrl1.Enabled = false;
            }
        }

        private void tmMain2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string draw = string.Empty;

            switch (lblLetter.Text)
            {
                case "B":
                    draw = bingo.ToArray()[rnd.Next(0, 14)];

                    while (drawsList.Contains(draw, StringComparer.Ordinal) && drawsList.Count > 1)
                    {
                        draw = bingo.ToArray()[rnd.Next(0, 14)];
                    }
                    break;
                case "I":
                    draw = bingo.ToArray()[rnd.Next(15, 29)];

                    while (drawsList.Contains(draw, StringComparer.Ordinal) && drawsList.Count > 1)
                    {
                        draw = bingo.ToArray()[rnd.Next(15, 29)];
                    }
                    break;
                case "N":
                    draw = bingo.ToArray()[rnd.Next(30, 44)];

                    while (drawsList.Contains(draw, StringComparer.Ordinal) && drawsList.Count > 1)
                    {
                        draw = bingo.ToArray()[rnd.Next(30, 44)];
                    }
                    break;
                case "G":
                    draw = bingo.ToArray()[rnd.Next(45, 59)];

                    while (drawsList.Contains(draw, StringComparer.Ordinal) && drawsList.Count > 1)
                    {
                        draw = bingo.ToArray()[rnd.Next(45, 59)];
                    }
                    break;
                case "O":
                    draw = bingo.ToArray()[rnd.Next(60, 74)];

                    while (drawsList.Contains(draw, StringComparer.Ordinal) && drawsList.Count > 1)
                    {
                        draw = bingo.ToArray()[rnd.Next(60, 74)];
                    }
                    break;
            }

            lblNumber.Text = draw.Remove(0, 1);

            if (tmMain1.Enabled == false)
            {
                tmMain2.Interval += 40;
                if (tmMain2.Interval >= 400)
                {
                    tmCtrl2.Enabled = true;
                }
            }            
        }

        private void tmCtrl2_Tick(object sender, EventArgs e)
        {
            lblNumber.ForeColor = Color.Green;
            tmMain2.Enabled = false;
            tmCtrl2.Enabled = false;
            btnGenerate.Text = "Generate";
            btnGenerate.Enabled = true;

            show();
            drawsList.Add(lblLetter.Text + lblNumber.Text);
        }
    }
}
