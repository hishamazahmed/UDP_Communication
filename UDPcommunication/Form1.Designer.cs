namespace UDPcommunication
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
            this.btnGetTemp = new System.Windows.Forms.Button();
            this.brnShowTemp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetTemp
            // 
            this.btnGetTemp.Location = new System.Drawing.Point(125, 58);
            this.btnGetTemp.Name = "btnGetTemp";
            this.btnGetTemp.Size = new System.Drawing.Size(126, 57);
            this.btnGetTemp.TabIndex = 0;
            this.btnGetTemp.Text = "Get Temp";
            this.btnGetTemp.UseVisualStyleBackColor = true;
            this.btnGetTemp.Click += new System.EventHandler(this.btnGetTemp_Click);
            // 
            // brnShowTemp
            // 
            this.brnShowTemp.Location = new System.Drawing.Point(125, 154);
            this.brnShowTemp.Name = "brnShowTemp";
            this.brnShowTemp.Size = new System.Drawing.Size(126, 57);
            this.brnShowTemp.TabIndex = 1;
            this.brnShowTemp.Text = "Show Temp";
            this.brnShowTemp.UseVisualStyleBackColor = true;
            this.brnShowTemp.Click += new System.EventHandler(this.brnShowTemp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 253);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 72);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 416);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.brnShowTemp);
            this.Controls.Add(this.btnGetTemp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetTemp;
        private System.Windows.Forms.Button brnShowTemp;
        private System.Windows.Forms.TextBox textBox1;
    }
}

