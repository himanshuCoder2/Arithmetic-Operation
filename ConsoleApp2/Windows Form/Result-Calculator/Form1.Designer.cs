
namespace Result_Calculator
{
    partial class Marksheet
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
            this.label1 = new System.Windows.Forms.Label();
            this.textEnglish = new System.Windows.Forms.TextBox();
            this.textMath = new System.Windows.Forms.TextBox();
            this.textHistory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblPercentageOP = new System.Windows.Forms.Label();
            this.TotalOp = new System.Windows.Forms.Label();
            this.txtTotalOp = new System.Windows.Forms.TextBox();
            this.txtPercentageOp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "English";
            // 
            // textEnglish
            // 
            this.textEnglish.Location = new System.Drawing.Point(307, 89);
            this.textEnglish.Name = "textEnglish";
            this.textEnglish.Size = new System.Drawing.Size(261, 31);
            this.textEnglish.TabIndex = 1;
            // 
            // textMath
            // 
            this.textMath.Location = new System.Drawing.Point(307, 155);
            this.textMath.Name = "textMath";
            this.textMath.Size = new System.Drawing.Size(261, 31);
            this.textMath.TabIndex = 2;
            // 
            // textHistory
            // 
            this.textHistory.Location = new System.Drawing.Point(307, 215);
            this.textHistory.Name = "textHistory";
            this.textHistory.Size = new System.Drawing.Size(261, 31);
            this.textHistory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Math";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "History";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(157, 391);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(118, 25);
            this.lblPercentage.TabIndex = 8;
            this.lblPercentage.Text = "Percentage %";
            // 
            // lblPercentageOP
            // 
            this.lblPercentageOP.AutoSize = true;
            this.lblPercentageOP.Location = new System.Drawing.Point(326, 391);
            this.lblPercentageOP.Name = "lblPercentageOP";
            this.lblPercentageOP.Size = new System.Drawing.Size(0, 25);
            this.lblPercentageOP.TabIndex = 9;
            // 
            // TotalOp
            // 
            this.TotalOp.AutoSize = true;
            this.TotalOp.Location = new System.Drawing.Point(257, 343);
            this.TotalOp.Name = "TotalOp";
            this.TotalOp.Size = new System.Drawing.Size(0, 25);
            this.TotalOp.TabIndex = 10;
            // 
            // txtTotalOp
            // 
            this.txtTotalOp.Location = new System.Drawing.Point(307, 337);
            this.txtTotalOp.Name = "txtTotalOp";
            this.txtTotalOp.Size = new System.Drawing.Size(261, 31);
            this.txtTotalOp.TabIndex = 11;
            // 
            // txtPercentageOp
            // 
            this.txtPercentageOp.Location = new System.Drawing.Point(307, 391);
            this.txtPercentageOp.Name = "txtPercentageOp";
            this.txtPercentageOp.Size = new System.Drawing.Size(261, 31);
            this.txtPercentageOp.TabIndex = 12;
            // 
            // Marksheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 479);
            this.Controls.Add(this.txtPercentageOp);
            this.Controls.Add(this.txtTotalOp);
            this.Controls.Add(this.TotalOp);
            this.Controls.Add(this.lblPercentageOP);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textHistory);
            this.Controls.Add(this.textMath);
            this.Controls.Add(this.textEnglish);
            this.Controls.Add(this.label1);
            this.Name = "Marksheet";
            this.Text = "Marksheet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEnglish;
        private System.Windows.Forms.TextBox textMath;
        private System.Windows.Forms.TextBox textHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblPercentageOP;
        private System.Windows.Forms.Label TotalOp;
        private System.Windows.Forms.TextBox txtTotalOp;
        private System.Windows.Forms.TextBox txtPercentageOp;
    }
}

