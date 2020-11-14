
namespace Dice
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
            this.button1 = new System.Windows.Forms.Button();
            this.DiceNumber1 = new System.Windows.Forms.Label();
            this.DiceNumber3 = new System.Windows.Forms.Label();
            this.DiceNumber2 = new System.Windows.Forms.Label();
            this.DiceSum = new System.Windows.Forms.Label();
            this.DiceEqual = new System.Windows.Forms.Label();
            this.DiceStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(150, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Roll your dices";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiceNumber1
            // 
            this.DiceNumber1.AutoSize = true;
            this.DiceNumber1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiceNumber1.Location = new System.Drawing.Point(150, 103);
            this.DiceNumber1.Name = "DiceNumber1";
            this.DiceNumber1.Size = new System.Drawing.Size(26, 29);
            this.DiceNumber1.TabIndex = 1;
            this.DiceNumber1.Text = "";
            // 
            // DiceNumber3
            // 
            this.DiceNumber3.AutoSize = true;
            this.DiceNumber3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiceNumber3.Location = new System.Drawing.Point(321, 103);
            this.DiceNumber3.Name = "DiceNumber3";
            this.DiceNumber3.Size = new System.Drawing.Size(26, 29);
            this.DiceNumber3.TabIndex = 2;
            this.DiceNumber3.Text = "";
            // 
            // DiceNumber2
            // 
            this.DiceNumber2.AutoSize = true;
            this.DiceNumber2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiceNumber2.Location = new System.Drawing.Point(235, 103);
            this.DiceNumber2.Name = "DiceNumber2";
            this.DiceNumber2.Size = new System.Drawing.Size(26, 29);
            this.DiceNumber2.TabIndex = 3;
            this.DiceNumber2.Text = "";
            // 
            // DiceSum
            // 
            this.DiceSum.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiceSum.Location = new System.Drawing.Point(-4, 180);
            this.DiceSum.Name = "DiceSum";
            this.DiceSum.Size = new System.Drawing.Size(524, 29);
            this.DiceSum.TabIndex = 4;
            this.DiceSum.Text = "Sum";
            this.DiceSum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DiceEqual
            // 
            this.DiceEqual.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiceEqual.Location = new System.Drawing.Point(-4, 232);
            this.DiceEqual.Name = "DiceEqual";
            this.DiceEqual.Size = new System.Drawing.Size(524, 29);
            this.DiceEqual.TabIndex = 5;
            this.DiceEqual.Text = "Sum";
            this.DiceEqual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DiceStats
            // 
            this.DiceStats.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiceStats.Location = new System.Drawing.Point(-4, 286);
            this.DiceStats.Name = "DiceStats";
            this.DiceStats.Size = new System.Drawing.Size(524, 29);
            this.DiceStats.TabIndex = 6;
            this.DiceStats.Text = "Status";
            this.DiceStats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 403);
            this.Controls.Add(this.DiceStats);
            this.Controls.Add(this.DiceEqual);
            this.Controls.Add(this.DiceSum);
            this.Controls.Add(this.DiceNumber2);
            this.Controls.Add(this.DiceNumber3);
            this.Controls.Add(this.DiceNumber1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Dices";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DiceNumber1;
        private System.Windows.Forms.Label DiceNumber3;
        private System.Windows.Forms.Label DiceNumber2;
        private System.Windows.Forms.Label DiceSum;
        private System.Windows.Forms.Label DiceEqual;
        private System.Windows.Forms.Label DiceStats;
    }
}

