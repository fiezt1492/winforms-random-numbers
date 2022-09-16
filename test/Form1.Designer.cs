namespace test
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.lbNumbers = new System.Windows.Forms.Label();
            this.listNumbersLength = new System.Windows.Forms.Label();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnDemSo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(12, 12);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Sinh";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lbNumbers
            // 
            this.lbNumbers.AutoSize = true;
            this.lbNumbers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNumbers.Location = new System.Drawing.Point(12, 38);
            this.lbNumbers.MaximumSize = new System.Drawing.Size(1500, 0);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(48, 17);
            this.lbNumbers.TabIndex = 1;
            this.lbNumbers.Text = "Day so";
            // 
            // listNumbersLength
            // 
            this.listNumbersLength.AutoSize = true;
            this.listNumbersLength.Location = new System.Drawing.Point(255, 17);
            this.listNumbersLength.Name = "listNumbersLength";
            this.listNumbersLength.Size = new System.Drawing.Size(41, 15);
            this.listNumbersLength.TabIndex = 2;
            this.listNumbersLength.Text = "Do dai";
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(93, 12);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(75, 23);
            this.btnQuickSort.TabIndex = 3;
            this.btnQuickSort.Text = "QuickSort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnDemSo
            // 
            this.btnDemSo.Location = new System.Drawing.Point(174, 13);
            this.btnDemSo.Name = "btnDemSo";
            this.btnDemSo.Size = new System.Drawing.Size(75, 23);
            this.btnDemSo.TabIndex = 4;
            this.btnDemSo.Text = "Dem So";
            this.btnDemSo.UseVisualStyleBackColor = true;
            this.btnDemSo.Click += new System.EventHandler(this.btnDemSo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(792, 358);
            this.Controls.Add(this.btnDemSo);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.listNumbersLength);
            this.Controls.Add(this.lbNumbers);
            this.Controls.Add(this.btnRandom);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRandom;
        private Label lbNumbers;
        private Label listNumbersLength;
        private Button btnQuickSort;
        private Button btnDemSo;
    }
}