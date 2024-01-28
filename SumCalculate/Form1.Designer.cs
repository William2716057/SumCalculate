namespace SumCalculate
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
            btnCalculate = new Button();
            inputA = new TextBox();
            inputB = new TextBox();
            lblResult = new Label();
            ModCalc = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(317, 155);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(172, 29);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate Sum";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // inputA
            // 
            inputA.Location = new Point(227, 102);
            inputA.Name = "inputA";
            inputA.Size = new Size(125, 27);
            inputA.TabIndex = 1;
            // 
            // inputB
            // 
            inputB.Location = new Point(452, 102);
            inputB.Name = "inputB";
            inputB.Size = new Size(125, 27);
            inputB.TabIndex = 2;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(374, 273);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result";
            lblResult.Click += lblResult_Click;
            // 
            // ModCalc
            // 
            ModCalc.Location = new Point(317, 219);
            ModCalc.Name = "ModCalc";
            ModCalc.Size = new Size(172, 29);
            ModCalc.TabIndex = 4;
            ModCalc.Text = "Calculate Modulo";
            ModCalc.UseVisualStyleBackColor = true;
            ModCalc.Click += ModCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ModCalc);
            Controls.Add(lblResult);
            Controls.Add(inputB);
            Controls.Add(inputA);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private TextBox inputA;
        private TextBox inputB;
        private Label lblResult;
        private Button ModCalc;
    }
}
