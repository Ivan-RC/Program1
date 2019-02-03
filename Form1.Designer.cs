namespace IvanRivas_CST117Program1
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
            this.btn_Convert = new System.Windows.Forms.Button();
            this.label1WeightOnEarth = new System.Windows.Forms.Label();
            this.label2WeightOnCancri55e = new System.Windows.Forms.Label();
            this.txtbox1_WeightOnEarth = new System.Windows.Forms.TextBox();
            this.txtbox2_WeightOnCancri55e = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Convert
            // 
            this.btn_Convert.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Convert.Location = new System.Drawing.Point(315, 201);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(90, 65);
            this.btn_Convert.TabIndex = 0;
            this.btn_Convert.Text = "Convert\r\nWeight !";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // label1WeightOnEarth
            // 
            this.label1WeightOnEarth.AutoSize = true;
            this.label1WeightOnEarth.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1WeightOnEarth.Location = new System.Drawing.Point(227, 76);
            this.label1WeightOnEarth.Name = "label1WeightOnEarth";
            this.label1WeightOnEarth.Size = new System.Drawing.Size(134, 38);
            this.label1WeightOnEarth.TabIndex = 1;
            this.label1WeightOnEarth.Text = "Enter your weight \r\non Earth.";
            // 
            // label2WeightOnCancri55e
            // 
            this.label2WeightOnCancri55e.AutoSize = true;
            this.label2WeightOnCancri55e.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2WeightOnCancri55e.Location = new System.Drawing.Point(227, 142);
            this.label2WeightOnCancri55e.Name = "label2WeightOnCancri55e";
            this.label2WeightOnCancri55e.Size = new System.Drawing.Size(111, 38);
            this.label2WeightOnCancri55e.TabIndex = 2;
            this.label2WeightOnCancri55e.Text = "Your weight on\r\nCancri 55 e.";
            // 
            // txtbox1_WeightOnEarth
            // 
            this.txtbox1_WeightOnEarth.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox1_WeightOnEarth.Location = new System.Drawing.Point(378, 87);
            this.txtbox1_WeightOnEarth.Name = "txtbox1_WeightOnEarth";
            this.txtbox1_WeightOnEarth.Size = new System.Drawing.Size(100, 27);
            this.txtbox1_WeightOnEarth.TabIndex = 3;
            // 
            // txtbox2_WeightOnCancri55e
            // 
            this.txtbox2_WeightOnCancri55e.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox2_WeightOnCancri55e.Location = new System.Drawing.Point(378, 153);
            this.txtbox2_WeightOnCancri55e.Name = "txtbox2_WeightOnCancri55e";
            this.txtbox2_WeightOnCancri55e.Size = new System.Drawing.Size(100, 27);
            this.txtbox2_WeightOnCancri55e.TabIndex = 4;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(215, 201);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(90, 65);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(423, 201);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(90, 65);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txtbox2_WeightOnCancri55e);
            this.Controls.Add(this.txtbox1_WeightOnEarth);
            this.Controls.Add(this.label2WeightOnCancri55e);
            this.Controls.Add(this.label1WeightOnEarth);
            this.Controls.Add(this.btn_Convert);
            this.Name = "Form1";
            this.Text = "HumanWeightToCancri55e";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Label label1WeightOnEarth;
        private System.Windows.Forms.Label label2WeightOnCancri55e;
        private System.Windows.Forms.TextBox txtbox1_WeightOnEarth;
        private System.Windows.Forms.TextBox txtbox2_WeightOnCancri55e;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Clear;
    }
}

