namespace BinaryConversionApplication
{
    partial class frmMain
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
            this.radUnsigned = new System.Windows.Forms.RadioButton();
            this.radTwosComp = new System.Windows.Forms.RadioButton();
            this.radOnesComp = new System.Windows.Forms.RadioButton();
            this.radSigned = new System.Windows.Forms.RadioButton();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.radFloat = new System.Windows.Forms.RadioButton();
            this.radDecimal = new System.Windows.Forms.RadioButton();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.radFloatOut = new System.Windows.Forms.RadioButton();
            this.radDecimalOut = new System.Windows.Forms.RadioButton();
            this.radUnsignedOut = new System.Windows.Forms.RadioButton();
            this.radTwosOut = new System.Windows.Forms.RadioButton();
            this.radSignedOut = new System.Windows.Forms.RadioButton();
            this.radOnesOut = new System.Windows.Forms.RadioButton();
            this.txtInputBinary = new System.Windows.Forms.TextBox();
            this.lvlYourInput = new System.Windows.Forms.Label();
            this.txtOutputBinary = new System.Windows.Forms.TextBox();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(16, 11);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(605, 52);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Binary Conversion Application";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(813, 11);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(151, 20);
            this.lblCopyright.TabIndex = 1;
            this.lblCopyright.Text = "James Hunt / 2018";
            // 
            // lblRepType
            // 
            this.lblRepType.AutoSize = true;
            this.lblRepType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepType.Location = new System.Drawing.Point(18, 113);
            this.lblRepType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepType.Name = "lblRepType";
            this.lblRepType.Size = new System.Drawing.Size(233, 39);
            this.lblRepType.TabIndex = 5;
            this.lblRepType.Text = "Convert From:";
            // 
            // lblConvert
            // 
            this.lblConvert.AutoSize = true;
            this.lblConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvert.Location = new System.Drawing.Point(18, 448);
            this.lblConvert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConvert.Name = "lblConvert";
            this.lblConvert.Size = new System.Drawing.Size(194, 39);
            this.lblConvert.TabIndex = 9;
            this.lblConvert.Text = "Convert To:";
            // 
            // lblYourAnswer
            // 
            this.lblYourAnswer.AutoSize = true;
            this.lblYourAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourAnswer.Location = new System.Drawing.Point(707, 678);
            this.lblYourAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYourAnswer.Name = "lblYourAnswer";
            this.lblYourAnswer.Size = new System.Drawing.Size(220, 39);
            this.lblYourAnswer.TabIndex = 10;
            this.lblYourAnswer.Text = "Your Answer:";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(679, 416);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(289, 73);
            this.btnConvert.TabIndex = 11;
            this.btnConvert.Text = "Convert Values";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // radUnsigned
            // 
            this.radUnsigned.AutoSize = true;
            this.radUnsigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUnsigned.Location = new System.Drawing.Point(8, 18);
            this.radUnsigned.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radUnsigned.Name = "radUnsigned";
            this.radUnsigned.Size = new System.Drawing.Size(234, 35);
            this.radUnsigned.TabIndex = 14;
            this.radUnsigned.TabStop = true;
            this.radUnsigned.Text = "Unsigned Binary";
            this.radUnsigned.UseVisualStyleBackColor = true;
            // 
            // radTwosComp
            // 
            this.radTwosComp.AutoSize = true;
            this.radTwosComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTwosComp.Location = new System.Drawing.Point(8, 148);
            this.radTwosComp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTwosComp.Name = "radTwosComp";
            this.radTwosComp.Size = new System.Drawing.Size(266, 35);
            this.radTwosComp.TabIndex = 15;
            this.radTwosComp.TabStop = true;
            this.radTwosComp.Text = "Two\'s Complement";
            this.radTwosComp.UseVisualStyleBackColor = true;
            // 
            // radOnesComp
            // 
            this.radOnesComp.AutoSize = true;
            this.radOnesComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOnesComp.Location = new System.Drawing.Point(8, 105);
            this.radOnesComp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radOnesComp.Name = "radOnesComp";
            this.radOnesComp.Size = new System.Drawing.Size(265, 35);
            this.radOnesComp.TabIndex = 16;
            this.radOnesComp.TabStop = true;
            this.radOnesComp.Text = "One\'s Complement";
            this.radOnesComp.UseVisualStyleBackColor = true;
            // 
            // radSigned
            // 
            this.radSigned.AutoSize = true;
            this.radSigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSigned.Location = new System.Drawing.Point(8, 61);
            this.radSigned.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSigned.Name = "radSigned";
            this.radSigned.Size = new System.Drawing.Size(203, 35);
            this.radSigned.TabIndex = 17;
            this.radSigned.TabStop = true;
            this.radSigned.Text = "Signed Binary";
            this.radSigned.UseVisualStyleBackColor = true;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.radFloat);
            this.grpInput.Controls.Add(this.radDecimal);
            this.grpInput.Controls.Add(this.radUnsigned);
            this.grpInput.Controls.Add(this.radTwosComp);
            this.grpInput.Controls.Add(this.radSigned);
            this.grpInput.Controls.Add(this.radOnesComp);
            this.grpInput.Location = new System.Drawing.Point(16, 156);
            this.grpInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInput.Name = "grpInput";
            this.grpInput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInput.Size = new System.Drawing.Size(317, 277);
            this.grpInput.TabIndex = 19;
            this.grpInput.TabStop = false;
            // 
            // radFloat
            // 
            this.radFloat.AutoSize = true;
            this.radFloat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFloat.Location = new System.Drawing.Point(9, 234);
            this.radFloat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radFloat.Name = "radFloat";
            this.radFloat.Size = new System.Drawing.Size(96, 35);
            this.radFloat.TabIndex = 20;
            this.radFloat.TabStop = true;
            this.radFloat.Text = "Float";
            this.radFloat.UseVisualStyleBackColor = true;
            // 
            // radDecimal
            // 
            this.radDecimal.AutoSize = true;
            this.radDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDecimal.Location = new System.Drawing.Point(9, 191);
            this.radDecimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radDecimal.Name = "radDecimal";
            this.radDecimal.Size = new System.Drawing.Size(133, 35);
            this.radDecimal.TabIndex = 19;
            this.radDecimal.TabStop = true;
            this.radDecimal.Text = "Decimal";
            this.radDecimal.UseVisualStyleBackColor = true;
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.radFloatOut);
            this.grpOutput.Controls.Add(this.radDecimalOut);
            this.grpOutput.Controls.Add(this.radUnsignedOut);
            this.grpOutput.Controls.Add(this.radTwosOut);
            this.grpOutput.Controls.Add(this.radSignedOut);
            this.grpOutput.Controls.Add(this.radOnesOut);
            this.grpOutput.Location = new System.Drawing.Point(16, 491);
            this.grpOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOutput.Size = new System.Drawing.Size(317, 277);
            this.grpOutput.TabIndex = 20;
            this.grpOutput.TabStop = false;
            // 
            // radFloatOut
            // 
            this.radFloatOut.AutoSize = true;
            this.radFloatOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFloatOut.Location = new System.Drawing.Point(10, 235);
            this.radFloatOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radFloatOut.Name = "radFloatOut";
            this.radFloatOut.Size = new System.Drawing.Size(96, 35);
            this.radFloatOut.TabIndex = 19;
            this.radFloatOut.TabStop = true;
            this.radFloatOut.Text = "Float";
            this.radFloatOut.UseVisualStyleBackColor = true;
            // 
            // radDecimalOut
            // 
            this.radDecimalOut.AutoSize = true;
            this.radDecimalOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDecimalOut.Location = new System.Drawing.Point(9, 192);
            this.radDecimalOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radDecimalOut.Name = "radDecimalOut";
            this.radDecimalOut.Size = new System.Drawing.Size(133, 35);
            this.radDecimalOut.TabIndex = 18;
            this.radDecimalOut.TabStop = true;
            this.radDecimalOut.Text = "Decimal";
            this.radDecimalOut.UseVisualStyleBackColor = true;
            // 
            // radUnsignedOut
            // 
            this.radUnsignedOut.AutoSize = true;
            this.radUnsignedOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUnsignedOut.Location = new System.Drawing.Point(9, 19);
            this.radUnsignedOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radUnsignedOut.Name = "radUnsignedOut";
            this.radUnsignedOut.Size = new System.Drawing.Size(234, 35);
            this.radUnsignedOut.TabIndex = 14;
            this.radUnsignedOut.TabStop = true;
            this.radUnsignedOut.Text = "Unsigned Binary";
            this.radUnsignedOut.UseVisualStyleBackColor = true;
            // 
            // radTwosOut
            // 
            this.radTwosOut.AutoSize = true;
            this.radTwosOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTwosOut.Location = new System.Drawing.Point(9, 149);
            this.radTwosOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTwosOut.Name = "radTwosOut";
            this.radTwosOut.Size = new System.Drawing.Size(266, 35);
            this.radTwosOut.TabIndex = 15;
            this.radTwosOut.TabStop = true;
            this.radTwosOut.Text = "Two\'s Complement";
            this.radTwosOut.UseVisualStyleBackColor = true;
            // 
            // radSignedOut
            // 
            this.radSignedOut.AutoSize = true;
            this.radSignedOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSignedOut.Location = new System.Drawing.Point(9, 62);
            this.radSignedOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSignedOut.Name = "radSignedOut";
            this.radSignedOut.Size = new System.Drawing.Size(203, 35);
            this.radSignedOut.TabIndex = 17;
            this.radSignedOut.TabStop = true;
            this.radSignedOut.Text = "Signed Binary";
            this.radSignedOut.UseVisualStyleBackColor = true;
            // 
            // radOnesOut
            // 
            this.radOnesOut.AutoSize = true;
            this.radOnesOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOnesOut.Location = new System.Drawing.Point(9, 106);
            this.radOnesOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radOnesOut.Name = "radOnesOut";
            this.radOnesOut.Size = new System.Drawing.Size(265, 35);
            this.radOnesOut.TabIndex = 16;
            this.radOnesOut.TabStop = true;
            this.radOnesOut.Text = "One\'s Complement";
            this.radOnesOut.UseVisualStyleBackColor = true;
            // 
            // txtInputBinary
            // 
            this.txtInputBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputBinary.Location = new System.Drawing.Point(679, 209);
            this.txtInputBinary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputBinary.Name = "txtInputBinary";
            this.txtInputBinary.Size = new System.Drawing.Size(288, 37);
            this.txtInputBinary.TabIndex = 22;
            // 
            // lvlYourInput
            // 
            this.lvlYourInput.AutoSize = true;
            this.lvlYourInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlYourInput.Location = new System.Drawing.Point(671, 156);
            this.lvlYourInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlYourInput.Name = "lvlYourInput";
            this.lvlYourInput.Size = new System.Drawing.Size(279, 39);
            this.lvlYourInput.TabIndex = 23;
            this.lvlYourInput.Text = "Input Your Value:";
            // 
            // txtOutputBinary
            // 
            this.txtOutputBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputBinary.Location = new System.Drawing.Point(679, 724);
            this.txtOutputBinary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutputBinary.Name = "txtOutputBinary";
            this.txtOutputBinary.Size = new System.Drawing.Size(288, 37);
            this.txtOutputBinary.TabIndex = 24;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 783);
            this.Controls.Add(this.txtOutputBinary);
            this.Controls.Add(this.lvlYourInput);
            this.Controls.Add(this.txtInputBinary);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblYourAnswer);
            this.Controls.Add(this.lblConvert);
            this.Controls.Add(this.lblRepType);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Binary Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
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
        private System.Windows.Forms.RadioButton radUnsigned;
        private System.Windows.Forms.RadioButton radTwosComp;
        private System.Windows.Forms.RadioButton radOnesComp;
        private System.Windows.Forms.RadioButton radSigned;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.RadioButton radUnsignedOut;
        private System.Windows.Forms.RadioButton radTwosOut;
        private System.Windows.Forms.RadioButton radSignedOut;
        private System.Windows.Forms.RadioButton radOnesOut;
        private System.Windows.Forms.RadioButton radDecimalOut;
        private System.Windows.Forms.TextBox txtInputBinary;
        private System.Windows.Forms.Label lvlYourInput;
        private System.Windows.Forms.TextBox txtOutputBinary;
        private System.Windows.Forms.RadioButton radDecimal;
        private System.Windows.Forms.RadioButton radFloat;
        private System.Windows.Forms.RadioButton radFloatOut;
    }
}

