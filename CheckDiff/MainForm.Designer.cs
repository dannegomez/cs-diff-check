/*
 * Created by SharpDevelop.
 * User: Daniel Gomez Ortega
 * Date: 2015-01-08
 * Time: 16:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CheckDiff
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.RichTextBox();
            this.btnCheckDiff = new System.Windows.Forms.Button();
            this.textBoxDiff = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chkboxL1and2L = new System.Windows.Forms.CheckBox();
            this.chkBoxL1inL2 = new System.Windows.Forms.CheckBox();
            this.chkBoxL2inL1 = new System.Windows.Forms.CheckBox();
            this.btnCheckDuplicates = new System.Windows.Forms.Button();
            this.chkBoxL1eqL2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 365);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "List 1:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(208, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "List 2:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 365);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "";
            // 
            // btnCheckDiff
            // 
            this.btnCheckDiff.Location = new System.Drawing.Point(406, 36);
            this.btnCheckDiff.Name = "btnCheckDiff";
            this.btnCheckDiff.Size = new System.Drawing.Size(204, 42);
            this.btnCheckDiff.TabIndex = 4;
            this.btnCheckDiff.Text = "Check Diff";
            this.btnCheckDiff.UseVisualStyleBackColor = true;
            this.btnCheckDiff.Click += new System.EventHandler(this.btnCheckDiffClick);
            // 
            // textBoxDiff
            // 
            this.textBoxDiff.Location = new System.Drawing.Point(406, 203);
            this.textBoxDiff.Name = "textBoxDiff";
            this.textBoxDiff.Size = new System.Drawing.Size(204, 193);
            this.textBoxDiff.TabIndex = 5;
            this.textBoxDiff.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 402);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(597, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // chkboxL1and2L
            // 
            this.chkboxL1and2L.Checked = true;
            this.chkboxL1and2L.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxL1and2L.Location = new System.Drawing.Point(406, 97);
            this.chkboxL1and2L.Name = "chkboxL1and2L";
            this.chkboxL1and2L.Size = new System.Drawing.Size(104, 24);
            this.chkboxL1and2L.TabIndex = 7;
            this.chkboxL1and2L.Text = "List1 <> List2";
            this.chkboxL1and2L.UseVisualStyleBackColor = true;
            this.chkboxL1and2L.CheckedChanged += new System.EventHandler(this.ChkboxL1and2LCheckedChanged);
            // 
            // chkBoxL1inL2
            // 
            this.chkBoxL1inL2.Location = new System.Drawing.Point(406, 116);
            this.chkBoxL1inL2.Name = "chkBoxL1inL2";
            this.chkBoxL1inL2.Size = new System.Drawing.Size(104, 24);
            this.chkBoxL1inL2.TabIndex = 8;
            this.chkBoxL1inL2.Text = "List1 > List2";
            this.chkBoxL1inL2.UseVisualStyleBackColor = true;
            this.chkBoxL1inL2.CheckedChanged += new System.EventHandler(this.ChkBoxL1inL2CheckedChanged);
            // 
            // chkBoxL2inL1
            // 
            this.chkBoxL2inL1.Location = new System.Drawing.Point(406, 136);
            this.chkBoxL2inL1.Name = "chkBoxL2inL1";
            this.chkBoxL2inL1.Size = new System.Drawing.Size(104, 24);
            this.chkBoxL2inL1.TabIndex = 9;
            this.chkBoxL2inL1.Text = "List1 < List2";
            this.chkBoxL2inL1.UseVisualStyleBackColor = true;
            this.chkBoxL2inL1.CheckedChanged += new System.EventHandler(this.ChkBoxL2inL1CheckedChanged);
            // 
            // btnCheckDuplicates
            // 
            this.btnCheckDuplicates.Location = new System.Drawing.Point(406, 9);
            this.btnCheckDuplicates.Name = "btnCheckDuplicates";
            this.btnCheckDuplicates.Size = new System.Drawing.Size(204, 23);
            this.btnCheckDuplicates.TabIndex = 10;
            this.btnCheckDuplicates.Text = "Check Duplicates";
            this.btnCheckDuplicates.UseVisualStyleBackColor = true;
            this.btnCheckDuplicates.Click += new System.EventHandler(this.CheckDuplicatesClick);
            // 
            // chkBoxL1eqL2
            // 
            this.chkBoxL1eqL2.Location = new System.Drawing.Point(406, 157);
            this.chkBoxL1eqL2.Name = "chkBoxL1eqL2";
            this.chkBoxL1eqL2.Size = new System.Drawing.Size(104, 24);
            this.chkBoxL1eqL2.TabIndex = 11;
            this.chkBoxL1eqL2.Text = "List1 == List2";
            this.chkBoxL1eqL2.UseVisualStyleBackColor = true;
            this.chkBoxL1eqL2.CheckedChanged += new System.EventHandler(this.ChkBoxL1eqL2CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Diff options:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Result:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 437);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkBoxL1eqL2);
            this.Controls.Add(this.btnCheckDuplicates);
            this.Controls.Add(this.chkBoxL2inL1);
            this.Controls.Add(this.chkBoxL1inL2);
            this.Controls.Add(this.chkboxL1and2L);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxDiff);
            this.Controls.Add(this.btnCheckDiff);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "MainForm";
            this.Text = "CheckDiff";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.CheckBox chkBoxL1eqL2;
		private System.Windows.Forms.Button btnCheckDuplicates;
		private System.Windows.Forms.CheckBox chkBoxL2inL1;
		private System.Windows.Forms.CheckBox chkBoxL1inL2;
		private System.Windows.Forms.CheckBox chkboxL1and2L;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.RichTextBox textBoxDiff;
		private System.Windows.Forms.Button btnCheckDiff;
		private System.Windows.Forms.RichTextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
