namespace WindowsForm
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
            this.txOne = new System.Windows.Forms.TextBox();
            this.txTwo = new System.Windows.Forms.TextBox();
            this.lbOut = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSubtract = new System.Windows.Forms.Button();
            this.btMultiply = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ckMale = new System.Windows.Forms.CheckBox();
            this.ckFemale = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btBrowes = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txOne
            // 
            this.txOne.Location = new System.Drawing.Point(234, 115);
            this.txOne.Name = "txOne";
            this.txOne.Size = new System.Drawing.Size(100, 20);
            this.txOne.TabIndex = 2;
            // 
            // txTwo
            // 
            this.txTwo.Location = new System.Drawing.Point(360, 115);
            this.txTwo.Name = "txTwo";
            this.txTwo.Size = new System.Drawing.Size(100, 20);
            this.txTwo.TabIndex = 3;
            // 
            // lbOut
            // 
            this.lbOut.AutoSize = true;
            this.lbOut.Location = new System.Drawing.Point(542, 121);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(35, 13);
            this.lbOut.TabIndex = 4;
            this.lbOut.Text = "label1";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(234, 184);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "ADD";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // btSubtract
            // 
            this.btSubtract.Location = new System.Drawing.Point(234, 225);
            this.btSubtract.Name = "btSubtract";
            this.btSubtract.Size = new System.Drawing.Size(75, 23);
            this.btSubtract.TabIndex = 6;
            this.btSubtract.Text = "SUBTRACT";
            this.btSubtract.UseVisualStyleBackColor = true;
            this.btSubtract.Click += new System.EventHandler(this.BtSubtract_Click);
            // 
            // btMultiply
            // 
            this.btMultiply.Location = new System.Drawing.Point(234, 274);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(75, 23);
            this.btMultiply.TabIndex = 7;
            this.btMultiply.Text = "MULTIPLY";
            this.btMultiply.UseVisualStyleBackColor = true;
            this.btMultiply.Click += new System.EventHandler(this.BtMultiply_Click);
            // 
            // btDivide
            // 
            this.btDivide.Location = new System.Drawing.Point(234, 318);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(75, 23);
            this.btDivide.TabIndex = 8;
            this.btDivide.Text = "DIVIDE";
            this.btDivide.UseVisualStyleBackColor = true;
            this.btDivide.Click += new System.EventHandler(this.BtDivide_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ckMale
            // 
            this.ckMale.AutoSize = true;
            this.ckMale.Location = new System.Drawing.Point(360, 230);
            this.ckMale.Name = "ckMale";
            this.ckMale.Size = new System.Drawing.Size(49, 17);
            this.ckMale.TabIndex = 10;
            this.ckMale.Text = "Male";
            this.ckMale.UseVisualStyleBackColor = true;
            // 
            // ckFemale
            // 
            this.ckFemale.AutoSize = true;
            this.ckFemale.Location = new System.Drawing.Point(360, 254);
            this.ckFemale.Name = "ckFemale";
            this.ckFemale.Size = new System.Drawing.Size(60, 17);
            this.ckFemale.TabIndex = 11;
            this.ckFemale.Text = "Female";
            this.ckFemale.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "ENTER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btPlay
            // 
            this.btPlay.Location = new System.Drawing.Point(536, 318);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 23);
            this.btPlay.TabIndex = 13;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.BtPlay_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(626, 318);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 14;
            this.btStop.Text = "STOP";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // btBrowes
            // 
            this.btBrowes.Location = new System.Drawing.Point(722, 274);
            this.btBrowes.Name = "btBrowes";
            this.btBrowes.Size = new System.Drawing.Size(75, 23);
            this.btBrowes.TabIndex = 15;
            this.btBrowes.Text = "Browse";
            this.btBrowes.UseVisualStyleBackColor = true;
            this.btBrowes.Click += new System.EventHandler(this.BtBrowes_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(545, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btBrowes);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ckFemale);
            this.Controls.Add(this.ckMale);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btMultiply);
            this.Controls.Add(this.btSubtract);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbOut);
            this.Controls.Add(this.txTwo);
            this.Controls.Add(this.txOne);
            this.Name = "Form1";
            this.Text = "MY TEST C SHARP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txOne;
        private System.Windows.Forms.TextBox txTwo;
        private System.Windows.Forms.Label lbOut;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSubtract;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckMale;
        private System.Windows.Forms.CheckBox ckFemale;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btBrowes;
        private System.Windows.Forms.TextBox textBox1;
    }
}

