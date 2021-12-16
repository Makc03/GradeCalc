namespace gradingcalc
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.CBRound = new System.Windows.Forms.CheckBox();
            this.LBItms = new System.Windows.Forms.ListBox();
            this.TBSubj = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBRec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBPoss = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(-9, -9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 89);
            this.button1.TabIndex = 9;
            this.button1.Text = "Grading Calculator  ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Indigo;
            this.btnCalc.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalc.Location = new System.Drawing.Point(-4, 265);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(282, 45);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate Total";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // CBRound
            // 
            this.CBRound.AutoSize = true;
            this.CBRound.ForeColor = System.Drawing.SystemColors.Control;
            this.CBRound.Location = new System.Drawing.Point(171, 191);
            this.CBRound.Name = "CBRound";
            this.CBRound.Size = new System.Drawing.Size(102, 17);
            this.CBRound.TabIndex = 3;
            this.CBRound.Text = "Round the toal?";
            this.CBRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CBRound.UseVisualStyleBackColor = true;
            // 
            // LBItms
            // 
            this.LBItms.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LBItms.FormattingEnabled = true;
            this.LBItms.Location = new System.Drawing.Point(9, 138);
            this.LBItms.Name = "LBItms";
            this.LBItms.Size = new System.Drawing.Size(148, 121);
            this.LBItms.TabIndex = 10;
            // 
            // TBSubj
            // 
            this.TBSubj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TBSubj.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.TBSubj.Location = new System.Drawing.Point(12, 102);
            this.TBSubj.Name = "TBSubj";
            this.TBSubj.Size = new System.Drawing.Size(100, 20);
            this.TBSubj.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Indigo;
            this.btnSave.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(166, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 45);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(163, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Points Scored";
            // 
            // TBRec
            // 
            this.TBRec.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TBRec.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.TBRec.Location = new System.Drawing.Point(166, 102);
            this.TBRec.Name = "TBRec";
            this.TBRec.Size = new System.Drawing.Size(100, 20);
            this.TBRec.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(163, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Possible";
            // 
            // TBPoss
            // 
            this.TBPoss.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TBPoss.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.TBPoss.Location = new System.Drawing.Point(166, 154);
            this.TBPoss.Name = "TBPoss";
            this.TBPoss.Size = new System.Drawing.Size(100, 20);
            this.TBPoss.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(274, 305);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBPoss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBRec);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.LBItms);
            this.Controls.Add(this.CBRound);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBSubj);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Grading Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.CheckBox CBRound;
        private System.Windows.Forms.ListBox LBItms;
        private System.Windows.Forms.TextBox TBSubj;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBRec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBPoss;
    }
}

