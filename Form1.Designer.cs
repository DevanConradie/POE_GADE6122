
namespace GADES2
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
            this.rtxtMap = new System.Windows.Forms.RichTextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnAttackDown = new System.Windows.Forms.Button();
            this.btnAttackLeft = new System.Windows.Forms.Button();
            this.btnAttackRight = new System.Windows.Forms.Button();
            this.btnAttackUp = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtMap
            // 
            this.rtxtMap.Location = new System.Drawing.Point(148, 12);
            this.rtxtMap.Name = "rtxtMap";
            this.rtxtMap.Size = new System.Drawing.Size(808, 299);
            this.rtxtMap.TabIndex = 0;
            this.rtxtMap.Text = "";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(1234, 155);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(54, 23);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(1270, 198);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(54, 23);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(1192, 198);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(54, 23);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(1234, 237);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(54, 23);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnAttackDown
            // 
            this.btnAttackDown.Location = new System.Drawing.Point(52, 174);
            this.btnAttackDown.Name = "btnAttackDown";
            this.btnAttackDown.Size = new System.Drawing.Size(54, 23);
            this.btnAttackDown.TabIndex = 8;
            this.btnAttackDown.Text = "v";
            this.btnAttackDown.UseVisualStyleBackColor = true;
            this.btnAttackDown.Click += new System.EventHandler(this.btnAttackDown_Click);
            // 
            // btnAttackLeft
            // 
            this.btnAttackLeft.Location = new System.Drawing.Point(12, 145);
            this.btnAttackLeft.Name = "btnAttackLeft";
            this.btnAttackLeft.Size = new System.Drawing.Size(54, 23);
            this.btnAttackLeft.TabIndex = 7;
            this.btnAttackLeft.Text = "<";
            this.btnAttackLeft.UseVisualStyleBackColor = true;
            this.btnAttackLeft.Click += new System.EventHandler(this.btnAttackLeft_Click);
            // 
            // btnAttackRight
            // 
            this.btnAttackRight.Location = new System.Drawing.Point(88, 146);
            this.btnAttackRight.Name = "btnAttackRight";
            this.btnAttackRight.Size = new System.Drawing.Size(54, 23);
            this.btnAttackRight.TabIndex = 6;
            this.btnAttackRight.Text = ">";
            this.btnAttackRight.UseVisualStyleBackColor = true;
            this.btnAttackRight.Click += new System.EventHandler(this.btnAttackRight_Click);
            // 
            // btnAttackUp
            // 
            this.btnAttackUp.Location = new System.Drawing.Point(52, 116);
            this.btnAttackUp.Name = "btnAttackUp";
            this.btnAttackUp.Size = new System.Drawing.Size(54, 23);
            this.btnAttackUp.TabIndex = 5;
            this.btnAttackUp.Text = "^";
            this.btnAttackUp.UseVisualStyleBackColor = true;
            this.btnAttackUp.Click += new System.EventHandler(this.btnAttackUp_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(1192, 116);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 15);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "score:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1249, 298);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1133, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnAttackDown);
            this.Controls.Add(this.btnAttackLeft);
            this.Controls.Add(this.btnAttackRight);
            this.Controls.Add(this.btnAttackUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.rtxtMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtMap;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnAttackDown;
        private System.Windows.Forms.Button btnAttackLeft;
        private System.Windows.Forms.Button btnAttackRight;
        private System.Windows.Forms.Button btnAttackUp;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
    }
}

