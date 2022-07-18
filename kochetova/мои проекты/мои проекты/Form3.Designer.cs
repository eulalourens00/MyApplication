
namespace мои_проекты
{
    partial class Form3
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.LblFirst = new System.Windows.Forms.Label();
            this.LblSecond = new System.Windows.Forms.Label();
            this.Increment = new System.Windows.Forms.Button();
            this.Decrement = new System.Windows.Forms.Button();
            this.Increase = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 68);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 0;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(12, 129);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 13);
            this.linkLabel2.TabIndex = 1;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(231, 64);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(140, 20);
            this.txtFirst.TabIndex = 2;
            this.txtFirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(231, 112);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(140, 20);
            this.txtSecond.TabIndex = 3;
            this.txtSecond.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // LblFirst
            // 
            this.LblFirst.AutoSize = true;
            this.LblFirst.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblFirst.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblFirst.Location = new System.Drawing.Point(31, 56);
            this.LblFirst.Name = "LblFirst";
            this.LblFirst.Size = new System.Drawing.Size(161, 28);
            this.LblFirst.TabIndex = 4;
            this.LblFirst.Text = "Первое число:";
            // 
            // LblSecond
            // 
            this.LblSecond.AutoSize = true;
            this.LblSecond.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSecond.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblSecond.Location = new System.Drawing.Point(33, 103);
            this.LblSecond.Name = "LblSecond";
            this.LblSecond.Size = new System.Drawing.Size(159, 28);
            this.LblSecond.TabIndex = 5;
            this.LblSecond.Text = "Второе число:";
            // 
            // Increment
            // 
            this.Increment.BackColor = System.Drawing.Color.LightPink;
            this.Increment.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Increment.Location = new System.Drawing.Point(15, 199);
            this.Increment.Name = "Increment";
            this.Increment.Size = new System.Drawing.Size(93, 91);
            this.Increment.TabIndex = 6;
            this.Increment.Text = "+";
            this.Increment.UseVisualStyleBackColor = false;
            this.Increment.Click += new System.EventHandler(this.btn_click);
            // 
            // Decrement
            // 
            this.Decrement.BackColor = System.Drawing.Color.LightPink;
            this.Decrement.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decrement.Location = new System.Drawing.Point(128, 199);
            this.Decrement.Name = "Decrement";
            this.Decrement.Size = new System.Drawing.Size(96, 91);
            this.Decrement.TabIndex = 7;
            this.Decrement.Text = "-";
            this.Decrement.UseVisualStyleBackColor = false;
            this.Decrement.Click += new System.EventHandler(this.btn_click);
            // 
            // Increase
            // 
            this.Increase.BackColor = System.Drawing.Color.LightPink;
            this.Increase.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Increase.Location = new System.Drawing.Point(250, 199);
            this.Increase.Name = "Increase";
            this.Increase.Size = new System.Drawing.Size(96, 91);
            this.Increase.TabIndex = 8;
            this.Increase.Text = "*";
            this.Increase.UseVisualStyleBackColor = false;
            this.Increase.Click += new System.EventHandler(this.btn_click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.LightPink;
            this.Divide.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Divide.Location = new System.Drawing.Point(381, 199);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(96, 91);
            this.Divide.TabIndex = 9;
            this.Divide.Text = ":";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.btn_click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblResult.Location = new System.Drawing.Point(21, 365);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(203, 46);
            this.LblResult.TabIndex = 10;
            this.LblResult.Text = "Результат:";
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtResult.Location = new System.Drawing.Point(306, 365);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(40, 46);
            this.txtResult.TabIndex = 11;
            this.txtResult.Text = "0";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(489, 493);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Increase);
            this.Controls.Add(this.Decrement);
            this.Controls.Add(this.Increment);
            this.Controls.Add(this.LblSecond);
            this.Controls.Add(this.LblFirst);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Form3";
            this.Text = "kalkulator";
            this.Click += new System.EventHandler(this.btn_click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label LblFirst;
        private System.Windows.Forms.Label LblSecond;
        private System.Windows.Forms.Button Increment;
        private System.Windows.Forms.Button Decrement;
        private System.Windows.Forms.Button Increase;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label txtResult;
    }
}