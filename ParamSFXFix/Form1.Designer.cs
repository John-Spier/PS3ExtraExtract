namespace ParamSFXFix
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInputPick = new System.Windows.Forms.Button();
            this.btnOutputPick = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtPkgPref = new System.Windows.Forms.TextBox();
            this.txtPkgSuf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcessExtra = new System.Windows.Forms.Button();
            this.btnProcessDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOtherSuf = new System.Windows.Forms.TextBox();
            this.textOtherPref = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVidSuf = new System.Windows.Forms.TextBox();
            this.txtVidPref = new System.Windows.Forms.TextBox();
            this.btnRecursiveMove = new System.Windows.Forms.Button();
            this.radSuf = new System.Windows.Forms.RadioButton();
            this.radPref = new System.Windows.Forms.RadioButton();
            this.boxNameFix = new System.Windows.Forms.CheckBox();
            this.lstErrorList = new System.Windows.Forms.ListBox();
            this.browseInput = new System.Windows.Forms.FolderBrowserDialog();
            this.browseOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(347, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnInputPick
            // 
            this.btnInputPick.Location = new System.Drawing.Point(366, 12);
            this.btnInputPick.Name = "btnInputPick";
            this.btnInputPick.Size = new System.Drawing.Size(191, 20);
            this.btnInputPick.TabIndex = 1;
            this.btnInputPick.Text = "Select Input PS3_EXTRA Dir";
            this.btnInputPick.UseVisualStyleBackColor = true;
            this.btnInputPick.Click += new System.EventHandler(this.btnInputPick_Click);
            // 
            // btnOutputPick
            // 
            this.btnOutputPick.Location = new System.Drawing.Point(432, 38);
            this.btnOutputPick.Name = "btnOutputPick";
            this.btnOutputPick.Size = new System.Drawing.Size(104, 20);
            this.btnOutputPick.TabIndex = 3;
            this.btnOutputPick.Text = "Choose Output Dir";
            this.btnOutputPick.UseVisualStyleBackColor = true;
            this.btnOutputPick.Click += new System.EventHandler(this.btnOutputPick_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 38);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(347, 20);
            this.txtOutput.TabIndex = 2;
            // 
            // txtPkgPref
            // 
            this.txtPkgPref.Location = new System.Drawing.Point(12, 64);
            this.txtPkgPref.Name = "txtPkgPref";
            this.txtPkgPref.Size = new System.Drawing.Size(347, 20);
            this.txtPkgPref.TabIndex = 4;
            // 
            // txtPkgSuf
            // 
            this.txtPkgSuf.Location = new System.Drawing.Point(12, 90);
            this.txtPkgSuf.Name = "txtPkgSuf";
            this.txtPkgSuf.Size = new System.Drawing.Size(347, 20);
            this.txtPkgSuf.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "PKG Prefix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "PKG Suffix";
            // 
            // btnProcessExtra
            // 
            this.btnProcessExtra.Location = new System.Drawing.Point(432, 114);
            this.btnProcessExtra.Name = "btnProcessExtra";
            this.btnProcessExtra.Size = new System.Drawing.Size(125, 20);
            this.btnProcessExtra.TabIndex = 8;
            this.btnProcessExtra.Text = "Rename/Move Files";
            this.btnProcessExtra.UseVisualStyleBackColor = true;
            this.btnProcessExtra.Click += new System.EventHandler(this.btnProcessExtra_Click);
            // 
            // btnProcessDir
            // 
            this.btnProcessDir.Location = new System.Drawing.Point(432, 68);
            this.btnProcessDir.Name = "btnProcessDir";
            this.btnProcessDir.Size = new System.Drawing.Size(125, 40);
            this.btnProcessDir.TabIndex = 13;
            this.btnProcessDir.Text = "Rename/Move Files - no PS3_EXTRA";
            this.btnProcessDir.UseVisualStyleBackColor = true;
            this.btnProcessDir.Click += new System.EventHandler(this.btnProcessDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "P3T Suffix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "P3T Prefix";
            // 
            // txtOtherSuf
            // 
            this.txtOtherSuf.Location = new System.Drawing.Point(12, 143);
            this.txtOtherSuf.Name = "txtOtherSuf";
            this.txtOtherSuf.Size = new System.Drawing.Size(347, 20);
            this.txtOtherSuf.TabIndex = 10;
            // 
            // textOtherPref
            // 
            this.textOtherPref.Location = new System.Drawing.Point(12, 117);
            this.textOtherPref.Name = "textOtherPref";
            this.textOtherPref.Size = new System.Drawing.Size(347, 20);
            this.textOtherPref.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "MP4 Suffix";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "MP4 Prefix";
            // 
            // txtVidSuf
            // 
            this.txtVidSuf.Location = new System.Drawing.Point(12, 197);
            this.txtVidSuf.Name = "txtVidSuf";
            this.txtVidSuf.Size = new System.Drawing.Size(347, 20);
            this.txtVidSuf.TabIndex = 16;
            // 
            // txtVidPref
            // 
            this.txtVidPref.Location = new System.Drawing.Point(12, 171);
            this.txtVidPref.Name = "txtVidPref";
            this.txtVidPref.Size = new System.Drawing.Size(347, 20);
            this.txtVidPref.TabIndex = 15;
            // 
            // btnRecursiveMove
            // 
            this.btnRecursiveMove.Location = new System.Drawing.Point(432, 143);
            this.btnRecursiveMove.Name = "btnRecursiveMove";
            this.btnRecursiveMove.Size = new System.Drawing.Size(125, 40);
            this.btnRecursiveMove.TabIndex = 14;
            this.btnRecursiveMove.Text = "Rename/Move Files Recursively";
            this.btnRecursiveMove.UseVisualStyleBackColor = true;
            this.btnRecursiveMove.Click += new System.EventHandler(this.btnRecursiveMove_Click);
            // 
            // radSuf
            // 
            this.radSuf.AutoSize = true;
            this.radSuf.Location = new System.Drawing.Point(542, 40);
            this.radSuf.Name = "radSuf";
            this.radSuf.Size = new System.Drawing.Size(32, 17);
            this.radSuf.TabIndex = 19;
            this.radSuf.Text = "S";
            this.radSuf.UseVisualStyleBackColor = true;
            // 
            // radPref
            // 
            this.radPref.AutoSize = true;
            this.radPref.Checked = true;
            this.radPref.Location = new System.Drawing.Point(365, 40);
            this.radPref.Name = "radPref";
            this.radPref.Size = new System.Drawing.Size(64, 17);
            this.radPref.TabIndex = 20;
            this.radPref.TabStop = true;
            this.radPref.Text = "A: Prefix";
            this.radPref.UseVisualStyleBackColor = true;
            // 
            // boxNameFix
            // 
            this.boxNameFix.AutoSize = true;
            this.boxNameFix.Location = new System.Drawing.Point(432, 196);
            this.boxNameFix.Name = "boxNameFix";
            this.boxNameFix.Size = new System.Drawing.Size(120, 17);
            this.boxNameFix.TabIndex = 21;
            this.boxNameFix.Text = "Automatic Name Fix";
            this.boxNameFix.UseVisualStyleBackColor = true;
            // 
            // lstErrorList
            // 
            this.lstErrorList.FormattingEnabled = true;
            this.lstErrorList.Location = new System.Drawing.Point(12, 226);
            this.lstErrorList.Name = "lstErrorList";
            this.lstErrorList.Size = new System.Drawing.Size(544, 238);
            this.lstErrorList.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 482);
            this.Controls.Add(this.lstErrorList);
            this.Controls.Add(this.boxNameFix);
            this.Controls.Add(this.radPref);
            this.Controls.Add(this.radSuf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVidSuf);
            this.Controls.Add(this.txtVidPref);
            this.Controls.Add(this.btnRecursiveMove);
            this.Controls.Add(this.btnProcessDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOtherSuf);
            this.Controls.Add(this.textOtherPref);
            this.Controls.Add(this.btnProcessExtra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPkgSuf);
            this.Controls.Add(this.txtPkgPref);
            this.Controls.Add(this.btnOutputPick);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnInputPick);
            this.Controls.Add(this.txtInput);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PS3_Extra Extractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnInputPick;
        private System.Windows.Forms.Button btnOutputPick;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtPkgPref;
        private System.Windows.Forms.TextBox txtPkgSuf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcessExtra;
        private System.Windows.Forms.Button btnProcessDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOtherSuf;
        private System.Windows.Forms.TextBox textOtherPref;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVidSuf;
        private System.Windows.Forms.TextBox txtVidPref;
        private System.Windows.Forms.Button btnRecursiveMove;
        private System.Windows.Forms.RadioButton radSuf;
        private System.Windows.Forms.RadioButton radPref;
        private System.Windows.Forms.CheckBox boxNameFix;
        private System.Windows.Forms.ListBox lstErrorList;
        private System.Windows.Forms.FolderBrowserDialog browseInput;
        private System.Windows.Forms.FolderBrowserDialog browseOutput;
    }
}

