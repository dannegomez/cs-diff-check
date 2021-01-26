/*
 * Created by SharpDevelop.
 * User: Daniel Gomez Ortega
 * Date: 2015-01-08
 * Time: 16:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CheckDiff
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        //array of lines in lists
        string[] text1, text2;

        //
        bool firstLine = true;

        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
        }

        void btnCheckDiffClick(object sender, EventArgs e)
        {
            //reset
            clearOutput();
            progressBar1.Value = 0;

            //get text
            text1 = textBox1.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            text2 = textBox2.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            int progress_step_values = 0;

            //Text1 <> Text2
            if (chkboxL1and2L.Checked)
            {
                progress_step_values = (int)100 / (text1.Length + text2.Length);

                for (int i = 0; i < text1.Length; i++)
                {
                    bool exist = false;
                    for (int ii = 0; ii < text2.Length; ii++)
                    {
                        //MessageBox.Show("text1=" + text1[i] + " == " + text2[ii]);
                        if (text1[i].Equals(text2[ii]))
                        {
                            exist = true;
                            break;
                        }
                    }

                    if (!exist)
                    {
                        printOutput(text1[i]);
                    }

                    progressBar1.Value += progress_step_values;
                }

                for (int i = 0; i < text2.Length; i++)
                {
                    bool exist = false;
                    for (int ii = 0; ii < text1.Length; ii++)
                    {
                        //MessageBox.Show("text2=" + text2[i] + " == " + text1[ii]);
                        if (text2[i].Equals(text1[ii]))
                        {
                            exist = true;
                            break;
                        }
                    }

                    if (!exist)
                    {
                        printOutput(text2[i]);
                    }

                    progressBar1.Value += progress_step_values;
                }

            }

            //Text1 >> Text2
            if (chkBoxL1inL2.Checked)
            {
                progress_step_values = (int)100 / text1.Length;

                for (int i = 0; i < text1.Length; i++)
                {
                    bool exist = false;
                    for (int ii = 0; ii < text2.Length; ii++)
                    {
                        //MessageBox.Show("text1=" + text1[i] + " == " + text2[ii]);
                        if (text1[i].Equals(text2[ii]))
                        {
                            exist = true;
                            break;
                        }
                    }

                    if (!exist)
                    {
                        printOutput(text1[i]);
                    }

                    progressBar1.Value += progress_step_values;
                }
            }


            //Text2 >> Text1
            if (chkBoxL2inL1.Checked)
            {
                progress_step_values = (int)100 / text2.Length;

                for (int i = 0; i < text2.Length; i++)
                {
                    bool exist = false;
                    for (int ii = 0; ii < text1.Length; ii++)
                    {
                        //MessageBox.Show("text2=" + text2[i] + " == " + text1[ii]);
                        if (text2[i].Equals(text1[ii]))
                        {
                            exist = true;
                            break;
                        }
                    }

                    if (!exist)
                    {
                        printOutput(text2[i]);
                    }

                    progressBar1.Value += progress_step_values;
                }

            }

            //Text1 == Text2
            if (chkBoxL1eqL2.Checked)
            {
                progress_step_values = (int)100 / text2.Length;

                for (int i = 0; i < text1.Length; i++)
                {
                    bool exist = false;
                    for (int ii = 0; ii < text2.Length; ii++)
                    {
                        //MessageBox.Show("text2=" + text2[i] + " == " + text1[ii]);
                        if (text1[i].Equals(text2[ii]))
                        {
                            exist = true;
                            break;
                        }
                    }

                    if (exist)
                    {
                        printOutput(text1[i]);
                    }

                    progressBar1.Value += progress_step_values;
                }

            }

            //set to 100% in case of 99%
            progressBar1.Value = 100;
        }

        void ChkboxL1and2LCheckedChanged(object sender, EventArgs e)
        {
            if (chkboxL1and2L.Checked)
            {
                chkBoxL1inL2.Checked = false;
                chkBoxL2inL1.Checked = false;
                chkBoxL1eqL2.Checked = false;
            }
        }

        void ChkBoxL1inL2CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxL1inL2.Checked)
            {
                chkboxL1and2L.Checked = false;
                chkBoxL2inL1.Checked = false;
                chkBoxL1eqL2.Checked = false;
            }
        }

        void ChkBoxL2inL1CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxL2inL1.Checked)
            {
                chkboxL1and2L.Checked = false;
                chkBoxL1inL2.Checked = false;
                chkBoxL1eqL2.Checked = false;
            }
        }

        void ChkBoxL1eqL2CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxL1eqL2.Checked)
            {
                chkboxL1and2L.Checked = false;
                chkBoxL1inL2.Checked = false;
                chkBoxL2inL1.Checked = false;
            }
        }

        void CheckDuplicatesClick(object sender, EventArgs e)
        {
            clearOutput();
            CheckDuplicatesInList("List 1", textBox1.Text);
            CheckDuplicatesInList("List 2", textBox2.Text);
        }

        void CheckDuplicatesInList(string list, string inputText)
        {
            string[] text = inputText.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            var dict = new Dictionary<String, int>();

            foreach (var value in text)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }

            foreach (var pair in dict)
            {
                if (pair.Value > 1)
                {
                    printOutput(list + ": " + pair.Key + " = " + pair.Value);
                }
            }
        }

        void clearOutput()
        {
            textBoxDiff.Text = "";
            firstLine = true;
        }

        void printOutput(string text)
        {
            if (firstLine)
            {
                firstLine = false;
            }
            else
            {
                textBoxDiff.Text += "\n";
            }

            textBoxDiff.Text += text;
        }

    }
}
