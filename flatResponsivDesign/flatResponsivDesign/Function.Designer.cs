namespace flatResponsivDesign
{
    partial class Function
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aValueTxt = new System.Windows.Forms.TextBox();
            this.bValueTxt = new System.Windows.Forms.TextBox();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.subtractBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.FuncBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "A value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "B value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total";
            // 
            // aValueTxt
            // 
            this.aValueTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aValueTxt.Location = new System.Drawing.Point(118, 117);
            this.aValueTxt.Name = "aValueTxt";
            this.aValueTxt.Size = new System.Drawing.Size(434, 30);
            this.aValueTxt.TabIndex = 1;
            // 
            // bValueTxt
            // 
            this.bValueTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bValueTxt.Location = new System.Drawing.Point(118, 168);
            this.bValueTxt.Name = "bValueTxt";
            this.bValueTxt.Size = new System.Drawing.Size(434, 30);
            this.bValueTxt.TabIndex = 2;
            // 
            // totalTxt
            // 
            this.totalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxt.Location = new System.Drawing.Point(118, 222);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.ReadOnly = true;
            this.totalTxt.Size = new System.Drawing.Size(434, 30);
            this.totalTxt.TabIndex = 9;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(26, 286);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(127, 64);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // subtractBtn
            // 
            this.subtractBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractBtn.Location = new System.Drawing.Point(159, 286);
            this.subtractBtn.Name = "subtractBtn";
            this.subtractBtn.Size = new System.Drawing.Size(127, 64);
            this.subtractBtn.TabIndex = 10;
            this.subtractBtn.Text = "Subtract";
            this.subtractBtn.UseVisualStyleBackColor = true;
            this.subtractBtn.Click += new System.EventHandler(this.subtractBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyBtn.Location = new System.Drawing.Point(292, 286);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(127, 64);
            this.multiplyBtn.TabIndex = 11;
            this.multiplyBtn.Text = "Times";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.multiplyBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBtn.Location = new System.Drawing.Point(425, 286);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(127, 64);
            this.divideBtn.TabIndex = 12;
            this.divideBtn.Text = "Divide";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // FuncBtn
            // 
            this.FuncBtn.Location = new System.Drawing.Point(159, 44);
            this.FuncBtn.Name = "FuncBtn";
            this.FuncBtn.Size = new System.Drawing.Size(127, 57);
            this.FuncBtn.TabIndex = 13;
            this.FuncBtn.Text = "Function";
            this.FuncBtn.UseVisualStyleBackColor = true;
            this.FuncBtn.Click += new System.EventHandler(this.FuncBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(292, 44);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(127, 57);
            this.NextBtn.TabIndex = 13;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // Function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 447);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.FuncBtn);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.subtractBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.bValueTxt);
            this.Controls.Add(this.aValueTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Function";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Function";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aValueTxt;
        private System.Windows.Forms.TextBox bValueTxt;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button subtractBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button FuncBtn;
        private System.Windows.Forms.Button NextBtn;
    }
}