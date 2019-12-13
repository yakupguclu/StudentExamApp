namespace OgrenciSinav
{
    partial class AnaForm
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
            this.rtSoruMetin = new System.Windows.Forms.RichTextBox();
            this.rbSikA = new System.Windows.Forms.RadioButton();
            this.rbSikC = new System.Windows.Forms.RadioButton();
            this.rbSikB = new System.Windows.Forms.RadioButton();
            this.rbSikD = new System.Windows.Forms.RadioButton();
            this.btnGEC = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rtSoruMetin
            // 
            this.rtSoruMetin.Location = new System.Drawing.Point(12, 12);
            this.rtSoruMetin.Name = "rtSoruMetin";
            this.rtSoruMetin.Size = new System.Drawing.Size(1263, 152);
            this.rtSoruMetin.TabIndex = 2;
            this.rtSoruMetin.Text = "";
            // 
            // rbSikA
            // 
            this.rbSikA.AutoSize = true;
            this.rbSikA.Location = new System.Drawing.Point(39, 194);
            this.rbSikA.Name = "rbSikA";
            this.rbSikA.Size = new System.Drawing.Size(38, 21);
            this.rbSikA.TabIndex = 3;
            this.rbSikA.TabStop = true;
            this.rbSikA.Text = "A";
            this.rbSikA.UseVisualStyleBackColor = true;
            // 
            // rbSikC
            // 
            this.rbSikC.AutoSize = true;
            this.rbSikC.Location = new System.Drawing.Point(39, 237);
            this.rbSikC.Name = "rbSikC";
            this.rbSikC.Size = new System.Drawing.Size(38, 21);
            this.rbSikC.TabIndex = 4;
            this.rbSikC.TabStop = true;
            this.rbSikC.Text = "C";
            this.rbSikC.UseVisualStyleBackColor = true;
            // 
            // rbSikB
            // 
            this.rbSikB.AutoSize = true;
            this.rbSikB.Location = new System.Drawing.Point(310, 194);
            this.rbSikB.Name = "rbSikB";
            this.rbSikB.Size = new System.Drawing.Size(38, 21);
            this.rbSikB.TabIndex = 5;
            this.rbSikB.TabStop = true;
            this.rbSikB.Text = "B";
            this.rbSikB.UseVisualStyleBackColor = true;
            // 
            // rbSikD
            // 
            this.rbSikD.AutoSize = true;
            this.rbSikD.Location = new System.Drawing.Point(310, 237);
            this.rbSikD.Name = "rbSikD";
            this.rbSikD.Size = new System.Drawing.Size(39, 21);
            this.rbSikD.TabIndex = 6;
            this.rbSikD.TabStop = true;
            this.rbSikD.Text = "D";
            this.rbSikD.UseVisualStyleBackColor = true;
            // 
            // btnGEC
            // 
            this.btnGEC.Location = new System.Drawing.Point(158, 276);
            this.btnGEC.Name = "btnGEC";
            this.btnGEC.Size = new System.Drawing.Size(140, 34);
            this.btnGEC.TabIndex = 7;
            this.btnGEC.Text = "GEÇ";
            this.btnGEC.UseVisualStyleBackColor = true;
            this.btnGEC.Click += new System.EventHandler(this.btnGEC_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(576, 276);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 196);
            this.listBox1.TabIndex = 8;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 602);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGEC);
            this.Controls.Add(this.rbSikD);
            this.Controls.Add(this.rbSikB);
            this.Controls.Add(this.rbSikC);
            this.Controls.Add(this.rbSikA);
            this.Controls.Add(this.rtSoruMetin);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtSoruMetin;
        private System.Windows.Forms.RadioButton rbSikA;
        private System.Windows.Forms.RadioButton rbSikC;
        private System.Windows.Forms.RadioButton rbSikB;
        private System.Windows.Forms.RadioButton rbSikD;
        private System.Windows.Forms.Button btnGEC;
        private System.Windows.Forms.ListBox listBox1;
    }
}