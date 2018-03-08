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
            this.lblRepType = new System.Windows.Forms.Label();
            this.lblConvert = new System.Windows.Forms.Label();
            this.lblYourAnswer = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.radUnsigned = new System.Windows.Forms.RadioButton();
            this.radTwosComp = new System.Windows.Forms.RadioButton();
            this.radOnesComp = new System.Windows.Forms.RadioButton();
            this.radSigned = new System.Windows.Forms.RadioButton();
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
            // radUnsigned
            // 
            this.radUnsigned.AutoSize = true;
            this.radUnsigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUnsigned.Location = new System.Drawing.Point(18, 187);
            this.radUnsigned.Name = "radUnsigned";
            this.radUnsigned.Size = new System.Drawing.Size(121, 29);
            this.radUnsigned.TabIndex = 14;
            this.radUnsigned.TabStop = true;
            this.radUnsigned.Text = "Unsigned";
            this.radUnsigned.UseVisualStyleBackColor = true;
            // 
            // radTwosComp
            // 
            this.radTwosComp.AutoSize = true;
            this.radTwosComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTwosComp.Location = new System.Drawing.Point(18, 292);
            this.radTwosComp.Name = "radTwosComp";
            this.radTwosComp.Size = new System.Drawing.Size(211, 29);
            this.radTwosComp.TabIndex = 15;
            this.radTwosComp.TabStop = true;
            this.radTwosComp.Text = "Two\'s Complement";
            this.radTwosComp.UseVisualStyleBackColor = true;
            // 
            // radOnesComp
            // 
            this.radOnesComp.AutoSize = true;
            this.radOnesComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOnesComp.Location = new System.Drawing.Point(18, 257);
            this.radOnesComp.Name = "radOnesComp";
            this.radOnesComp.Size = new System.Drawing.Size(211, 29);
            this.radOnesComp.TabIndex = 16;
            this.radOnesComp.TabStop = true;
            this.radOnesComp.Text = "One\'s Complement";
            this.radOnesComp.UseVisualStyleBackColor = true;
            // 
            // radSigned
            // 
            this.radSigned.AutoSize = true;
            this.radSigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSigned.Location = new System.Drawing.Point(18, 222);
            this.radSigned.Name = "radSigned";
            this.radSigned.Size = new System.Drawing.Size(169, 29);
            this.radSigned.TabIndex = 17;
            this.radSigned.TabStop = true;
            this.radSigned.Text = "Signed Integer";
            this.radSigned.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 344);
            this.Controls.Add(this.radSigned);
            this.Controls.Add(this.radOnesComp);
            this.Controls.Add(this.radTwosComp);
            this.Controls.Add(this.radUnsigned);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblYourAnswer);
            this.Controls.Add(this.lblConvert);
            this.Controls.Add(this.lblRepType);
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
        private System.Windows.Forms.Label lblRepType;
        private System.Windows.Forms.Label lblConvert;
        private System.Windows.Forms.Label lblYourAnswer;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.RadioButton radUnsigned;
        private System.Windows.Forms.RadioButton radTwosComp;
        private System.Windows.Forms.RadioButton radOnesComp;
        private System.Windows.Forms.RadioButton radSigned;
    }
}

