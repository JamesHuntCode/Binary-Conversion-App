namespace BinaryConversionApplication
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.cbUnsigned = new System.Windows.Forms.CheckBox();
            this.lblRepType = new System.Windows.Forms.Label();
            this.cbOnesComp = new System.Windows.Forms.CheckBox();
            this.cbSigned = new System.Windows.Forms.CheckBox();
            this.cbTwosComp = new System.Windows.Forms.CheckBox();
            this.lblConvert = new System.Windows.Forms.Label();
            this.lblYourAnswer = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(463, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(480, 39);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Binary Conversion Application";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(1185, 9);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(117, 16);
            this.lblCopyright.TabIndex = 1;
            this.lblCopyright.Text = "James Hunt - 2018";
            // 
            // cbUnsigned
            // 
            this.cbUnsigned.AutoSize = true;
            this.cbUnsigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnsigned.Location = new System.Drawing.Point(12, 174);
            this.cbUnsigned.Name = "cbUnsigned";
            this.cbUnsigned.Size = new System.Drawing.Size(128, 29);
            this.cbUnsigned.TabIndex = 4;
            this.cbUnsigned.Text = "Unsigned ";
            this.cbUnsigned.UseVisualStyleBackColor = true;
            // 
            // lblRepType
            // 
            this.lblRepType.AutoSize = true;
            this.lblRepType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepType.Location = new System.Drawing.Point(12, 127);
            this.lblRepType.Name = "lblRepType";
            this.lblRepType.Size = new System.Drawing.Size(358, 31);
            this.lblRepType.TabIndex = 5;
            this.lblRepType.Text = "Select Representation Type:";
            // 
            // cbOnesComp
            // 
            this.cbOnesComp.AutoSize = true;
            this.cbOnesComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOnesComp.Location = new System.Drawing.Point(12, 244);
            this.cbOnesComp.Name = "cbOnesComp";
            this.cbOnesComp.Size = new System.Drawing.Size(212, 29);
            this.cbOnesComp.TabIndex = 6;
            this.cbOnesComp.Text = "One\'s Complement";
            this.cbOnesComp.UseVisualStyleBackColor = true;
            // 
            // cbSigned
            // 
            this.cbSigned.AutoSize = true;
            this.cbSigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSigned.Location = new System.Drawing.Point(12, 209);
            this.cbSigned.Name = "cbSigned";
            this.cbSigned.Size = new System.Drawing.Size(170, 29);
            this.cbSigned.TabIndex = 7;
            this.cbSigned.Text = "Signed Integer";
            this.cbSigned.UseVisualStyleBackColor = true;
            // 
            // cbTwosComp
            // 
            this.cbTwosComp.AutoSize = true;
            this.cbTwosComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTwosComp.Location = new System.Drawing.Point(12, 279);
            this.cbTwosComp.Name = "cbTwosComp";
            this.cbTwosComp.Size = new System.Drawing.Size(212, 29);
            this.cbTwosComp.TabIndex = 8;
            this.cbTwosComp.Text = "Two\'s Complement";
            this.cbTwosComp.UseVisualStyleBackColor = true;
            // 
            // lblConvert
            // 
            this.lblConvert.AutoSize = true;
            this.lblConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvert.Location = new System.Drawing.Point(564, 127);
            this.lblConvert.Name = "lblConvert";
            this.lblConvert.Size = new System.Drawing.Size(262, 31);
            this.lblConvert.TabIndex = 9;
            this.lblConvert.Text = "Convert To Decimal:";
            // 
            // lblYourAnswer
            // 
            this.lblYourAnswer.AutoSize = true;
            this.lblYourAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourAnswer.Location = new System.Drawing.Point(1125, 127);
            this.lblYourAnswer.Name = "lblYourAnswer";
            this.lblYourAnswer.Size = new System.Drawing.Size(177, 31);
            this.lblYourAnswer.TabIndex = 10;
            this.lblYourAnswer.Text = "Your Answer:";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(570, 214);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(256, 59);
            this.btnConvert.TabIndex = 11;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(1126, 231);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(110, 25);
            this.lblAnswer.TabIndex = 13;
            this.lblAnswer.Text = "OUTPUT..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 330);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblYourAnswer);
            this.Controls.Add(this.lblConvert);
            this.Controls.Add(this.cbTwosComp);
            this.Controls.Add(this.cbSigned);
            this.Controls.Add(this.cbOnesComp);
            this.Controls.Add(this.lblRepType);
            this.Controls.Add(this.cbUnsigned);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.CheckBox cbUnsigned;
        private System.Windows.Forms.Label lblRepType;
        private System.Windows.Forms.CheckBox cbOnesComp;
        private System.Windows.Forms.CheckBox cbSigned;
        private System.Windows.Forms.CheckBox cbTwosComp;
        private System.Windows.Forms.Label lblConvert;
        private System.Windows.Forms.Label lblYourAnswer;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblAnswer;
    }
}

