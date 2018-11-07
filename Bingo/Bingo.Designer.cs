namespace Bingo
{
    partial class Bingo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bingo));
            this.lblLetter = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblDrawn = new System.Windows.Forms.Label();
            this.tmMain1 = new System.Windows.Forms.Timer(this.components);
            this.tmCtrl1 = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAll = new System.Windows.Forms.TextBox();
            this.lblDrawsLeft = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumber = new System.Windows.Forms.Label();
            this.tmMain2 = new System.Windows.Forms.Timer(this.components);
            this.tmCtrl2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLetter
            // 
            this.lblLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter.ForeColor = System.Drawing.Color.Black;
            this.lblLetter.Location = new System.Drawing.Point(153, 62);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(240, 248);
            this.lblLetter.TabIndex = 0;
            this.lblLetter.Text = "--";
            this.lblLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(775, 62);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(128, 75);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblDrawn
            // 
            this.lblDrawn.AutoSize = true;
            this.lblDrawn.BackColor = System.Drawing.Color.Transparent;
            this.lblDrawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawn.ForeColor = System.Drawing.Color.Black;
            this.lblDrawn.Location = new System.Drawing.Point(6, 3);
            this.lblDrawn.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lblDrawn.Name = "lblDrawn";
            this.lblDrawn.Size = new System.Drawing.Size(0, 29);
            this.lblDrawn.TabIndex = 2;
            // 
            // tmMain1
            // 
            this.tmMain1.Interval = 10;
            this.tmMain1.Tick += new System.EventHandler(this.tmMain1_Tick);
            // 
            // tmCtrl1
            // 
            this.tmCtrl1.Interval = 500;
            this.tmCtrl1.Tick += new System.EventHandler(this.tmCtrl1_Tick);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(775, 152);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 75);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAll
            // 
            this.txtAll.BackColor = System.Drawing.SystemColors.Window;
            this.txtAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAll.Location = new System.Drawing.Point(0, 0);
            this.txtAll.MaximumSize = new System.Drawing.Size(1000, 0);
            this.txtAll.Multiline = true;
            this.txtAll.Name = "txtAll";
            this.txtAll.ReadOnly = true;
            this.txtAll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAll.Size = new System.Drawing.Size(1000, 0);
            this.txtAll.TabIndex = 1;
            // 
            // lblDrawsLeft
            // 
            this.lblDrawsLeft.AutoSize = true;
            this.lblDrawsLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDrawsLeft.Location = new System.Drawing.Point(413, 320);
            this.lblDrawsLeft.Name = "lblDrawsLeft";
            this.lblDrawsLeft.Size = new System.Drawing.Size(118, 22);
            this.lblDrawsLeft.TabIndex = 6;
            this.lblDrawsLeft.Text = "Draws Left:  75";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblNumber);
            this.panel1.Controls.Add(this.lblDrawsLeft);
            this.panel1.Controls.Add(this.lblLetter);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 487);
            this.panel1.TabIndex = 7;
            // 
            // lblNumber
            // 
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Black;
            this.lblNumber.Location = new System.Drawing.Point(399, 62);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(334, 248);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.Text = "--";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmMain2
            // 
            this.tmMain2.Interval = 10;
            this.tmMain2.Tick += new System.EventHandler(this.tmMain2_Tick);
            // 
            // tmCtrl2
            // 
            this.tmCtrl2.Interval = 500;
            this.tmCtrl2.Tick += new System.EventHandler(this.tmCtrl2_Tick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.Location = new System.Drawing.Point(0, 484);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1094, 150);
            this.tabControl.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblDrawn);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1086, 117);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Drawn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtAll);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1086, 117);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Draws";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Bingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 634);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bingo";
            this.Text = "Bingo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bingo_Load);
            this.SizeChanged += new System.EventHandler(this.Bingo_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblDrawn;
        private System.Windows.Forms.Timer tmMain1;
        private System.Windows.Forms.Timer tmCtrl1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDrawsLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAll;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Timer tmMain2;
        private System.Windows.Forms.Timer tmCtrl2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

