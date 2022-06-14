namespace Processor.WindowsFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAX = new System.Windows.Forms.TextBox();
            this.textBoxBX = new System.Windows.Forms.TextBox();
            this.textBoxCX = new System.Windows.Forms.TextBox();
            this.textBoxDX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnMOV = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.axResult = new System.Windows.Forms.Label();
            this.bxResult = new System.Windows.Forms.Label();
            this.cxResult = new System.Windows.Forms.Label();
            this.dxResult = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnXCHG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAX
            // 
            this.textBoxAX.Location = new System.Drawing.Point(60, 38);
            this.textBoxAX.Name = "textBoxAX";
            this.textBoxAX.Size = new System.Drawing.Size(100, 23);
            this.textBoxAX.TabIndex = 0;
            // 
            // textBoxBX
            // 
            this.textBoxBX.Location = new System.Drawing.Point(232, 38);
            this.textBoxBX.Name = "textBoxBX";
            this.textBoxBX.Size = new System.Drawing.Size(100, 23);
            this.textBoxBX.TabIndex = 1;
            // 
            // textBoxCX
            // 
            this.textBoxCX.Location = new System.Drawing.Point(437, 38);
            this.textBoxCX.Name = "textBoxCX";
            this.textBoxCX.Size = new System.Drawing.Size(100, 23);
            this.textBoxCX.TabIndex = 2;
            // 
            // textBoxDX
            // 
            this.textBoxDX.Location = new System.Drawing.Point(628, 38);
            this.textBoxDX.Name = "textBoxDX";
            this.textBoxDX.Size = new System.Drawing.Size(100, 23);
            this.textBoxDX.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "AX";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "BX";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "CX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(666, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "DX";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.listBox1.Location = new System.Drawing.Point(171, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.listBox2.Location = new System.Drawing.Point(476, 122);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 94);
            this.listBox2.TabIndex = 9;
            // 
            // btnMOV
            // 
            this.btnMOV.Location = new System.Drawing.Point(257, 257);
            this.btnMOV.Name = "btnMOV";
            this.btnMOV.Size = new System.Drawing.Size(75, 23);
            this.btnMOV.TabIndex = 10;
            this.btnMOV.Text = "MOV";
            this.btnMOV.UseVisualStyleBackColor = true;
            this.btnMOV.Click += new System.EventHandler(this.btnMOV_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "RESULT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "AX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "BX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "CX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(666, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "DX";
            // 
            // axResult
            // 
            this.axResult.AutoSize = true;
            this.axResult.Location = new System.Drawing.Point(100, 392);
            this.axResult.Name = "axResult";
            this.axResult.Size = new System.Drawing.Size(0, 15);
            this.axResult.TabIndex = 16;
            // 
            // bxResult
            // 
            this.bxResult.AutoSize = true;
            this.bxResult.Location = new System.Drawing.Point(270, 392);
            this.bxResult.Name = "bxResult";
            this.bxResult.Size = new System.Drawing.Size(0, 15);
            this.bxResult.TabIndex = 17;
            // 
            // cxResult
            // 
            this.cxResult.AutoSize = true;
            this.cxResult.Location = new System.Drawing.Point(476, 392);
            this.cxResult.Name = "cxResult";
            this.cxResult.Size = new System.Drawing.Size(0, 15);
            this.cxResult.TabIndex = 18;
            // 
            // dxResult
            // 
            this.dxResult.AutoSize = true;
            this.dxResult.Location = new System.Drawing.Point(666, 392);
            this.dxResult.Name = "dxResult";
            this.dxResult.Size = new System.Drawing.Size(0, 15);
            this.dxResult.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "CEL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(518, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "ŹRÓDŁO";
            // 
            // btnXCHG
            // 
            this.btnXCHG.Location = new System.Drawing.Point(423, 257);
            this.btnXCHG.Name = "btnXCHG";
            this.btnXCHG.Size = new System.Drawing.Size(75, 23);
            this.btnXCHG.TabIndex = 22;
            this.btnXCHG.Text = "XCHG";
            this.btnXCHG.UseVisualStyleBackColor = true;
            this.btnXCHG.Click += new System.EventHandler(this.btnXCHG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXCHG);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dxResult);
            this.Controls.Add(this.cxResult);
            this.Controls.Add(this.bxResult);
            this.Controls.Add(this.axResult);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMOV);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDX);
            this.Controls.Add(this.textBoxCX);
            this.Controls.Add(this.textBoxBX);
            this.Controls.Add(this.textBoxAX);
            this.Name = "Form1";
            this.Text = "Emulator PW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAX;
        private System.Windows.Forms.TextBox textBoxBX;
        private System.Windows.Forms.TextBox textBoxCX;
        private System.Windows.Forms.TextBox textBoxDX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnMOV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label axResult;
        private System.Windows.Forms.Label bxResult;
        private System.Windows.Forms.Label cxResult;
        private System.Windows.Forms.Label dxResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnXCHG;
    }
}
