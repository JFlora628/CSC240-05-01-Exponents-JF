namespace Exponents
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
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.DirectionLbl = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.GoBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(92, 45);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(100, 20);
            this.NumberBox.TabIndex = 0;
            // 
            // DirectionLbl
            // 
            this.DirectionLbl.AutoSize = true;
            this.DirectionLbl.Location = new System.Drawing.Point(92, 27);
            this.DirectionLbl.Name = "DirectionLbl";
            this.DirectionLbl.Size = new System.Drawing.Size(85, 13);
            this.DirectionLbl.TabIndex = 3;
            this.DirectionLbl.Text = "Enter an integer:";
            // 
            // xOutputLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(102, 181);
            this.ResultLabel.Name = "xOutputLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Visible = false;
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(105, 96);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(75, 67);
            this.GoBtn.TabIndex = 6;
            this.GoBtn.Text = "Go!";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(105, 212);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 7;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.DirectionLbl);
            this.Controls.Add(this.NumberBox);
            this.Name = "Form1";
            this.Text = "Exponents Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label DirectionLbl;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.Button ResetBtn;
    }
}

