namespace flatResponsivDesign
{
    partial class ArrayForm
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
            this.Btn1DArr = new System.Windows.Forms.Button();
            this.Btn2DArr = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.BtnInputNum = new System.Windows.Forms.Button();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn1DArr
            // 
            this.Btn1DArr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1DArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1DArr.Location = new System.Drawing.Point(12, 97);
            this.Btn1DArr.Name = "Btn1DArr";
            this.Btn1DArr.Size = new System.Drawing.Size(167, 58);
            this.Btn1DArr.TabIndex = 0;
            this.Btn1DArr.Text = "1D Array";
            this.Btn1DArr.UseVisualStyleBackColor = true;
            this.Btn1DArr.Click += new System.EventHandler(this.Btn1DArr_Click);
            // 
            // Btn2DArr
            // 
            this.Btn2DArr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2DArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2DArr.Location = new System.Drawing.Point(12, 180);
            this.Btn2DArr.Name = "Btn2DArr";
            this.Btn2DArr.Size = new System.Drawing.Size(167, 58);
            this.Btn2DArr.TabIndex = 1;
            this.Btn2DArr.Text = "2D Array";
            this.Btn2DArr.UseVisualStyleBackColor = true;
            this.Btn2DArr.Click += new System.EventHandler(this.Btn2DArr_Click);
            // 
            // listBox
            // 
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(205, 97);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(372, 377);
            this.listBox.TabIndex = 2;
            // 
            // BtnInputNum
            // 
            this.BtnInputNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInputNum.Location = new System.Drawing.Point(12, 34);
            this.BtnInputNum.Name = "BtnInputNum";
            this.BtnInputNum.Size = new System.Drawing.Size(166, 52);
            this.BtnInputNum.TabIndex = 3;
            this.BtnInputNum.Text = "Input Number";
            this.BtnInputNum.UseVisualStyleBackColor = true;
            this.BtnInputNum.Click += new System.EventHandler(this.BtnInputNum_Click);
            // 
            // TxtNumber
            // 
            this.TxtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumber.Location = new System.Drawing.Point(205, 50);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(365, 36);
            this.TxtNumber.TabIndex = 4;
            // 
            // ArrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 518);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.BtnInputNum);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.Btn2DArr);
            this.Controls.Add(this.Btn1DArr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArrayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1DArr;
        private System.Windows.Forms.Button Btn2DArr;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button BtnInputNum;
        private System.Windows.Forms.TextBox TxtNumber;
    }
}