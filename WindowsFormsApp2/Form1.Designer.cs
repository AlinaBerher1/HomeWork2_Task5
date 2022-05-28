namespace WindowsFormsApp2
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
            this.buttonByte = new System.Windows.Forms.Button();
            this.buttonSbyte = new System.Windows.Forms.Button();
            this.buttonShort = new System.Windows.Forms.Button();
            this.buttonUshort = new System.Windows.Forms.Button();
            this.buttonInt = new System.Windows.Forms.Button();
            this.buttonUint = new System.Windows.Forms.Button();
            this.buttonLong = new System.Windows.Forms.Button();
            this.buttonUlong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonByte
            // 
            this.buttonByte.Location = new System.Drawing.Point(70, 40);
            this.buttonByte.Name = "buttonByte";
            this.buttonByte.Size = new System.Drawing.Size(75, 23);
            this.buttonByte.TabIndex = 8;
            this.buttonByte.Text = "Byte";
            this.buttonByte.Click += new System.EventHandler(this.buttonByte_Click_1);
            // 
            // buttonSbyte
            // 
            this.buttonSbyte.Location = new System.Drawing.Point(189, 40);
            this.buttonSbyte.Name = "buttonSbyte";
            this.buttonSbyte.Size = new System.Drawing.Size(75, 23);
            this.buttonSbyte.TabIndex = 8;
            this.buttonSbyte.Text = "Sbyte";
            this.buttonSbyte.Click += new System.EventHandler(this.buttonSbyte_Click_1);
            // 
            // buttonShort
            // 
            this.buttonShort.Location = new System.Drawing.Point(312, 40);
            this.buttonShort.Name = "buttonShort";
            this.buttonShort.Size = new System.Drawing.Size(75, 23);
            this.buttonShort.TabIndex = 8;
            this.buttonShort.Text = "Short";
            this.buttonShort.Click += new System.EventHandler(this.buttonShort_Click_1);
            // 
            // buttonUshort
            // 
            this.buttonUshort.Location = new System.Drawing.Point(453, 40);
            this.buttonUshort.Name = "buttonUshort";
            this.buttonUshort.Size = new System.Drawing.Size(75, 23);
            this.buttonUshort.TabIndex = 8;
            this.buttonUshort.Text = "Ushort";
            this.buttonUshort.Click += new System.EventHandler(this.buttonUshort_Click_1);
            // 
            // buttonInt
            // 
            this.buttonInt.Location = new System.Drawing.Point(70, 107);
            this.buttonInt.Name = "buttonInt";
            this.buttonInt.Size = new System.Drawing.Size(75, 23);
            this.buttonInt.TabIndex = 8;
            this.buttonInt.Text = "Int";
            this.buttonInt.Click += new System.EventHandler(this.buttonInt_Click);
            // 
            // buttonUint
            // 
            this.buttonUint.Location = new System.Drawing.Point(189, 107);
            this.buttonUint.Name = "buttonUint";
            this.buttonUint.Size = new System.Drawing.Size(75, 23);
            this.buttonUint.TabIndex = 8;
            this.buttonUint.Text = "Uint";
            this.buttonUint.Click += new System.EventHandler(this.buttonUint_Click_1);
            // 
            // buttonLong
            // 
            this.buttonLong.Location = new System.Drawing.Point(312, 107);
            this.buttonLong.Name = "buttonLong";
            this.buttonLong.Size = new System.Drawing.Size(75, 23);
            this.buttonLong.TabIndex = 8;
            this.buttonLong.Text = "Long";
            this.buttonLong.Click += new System.EventHandler(this.buttonLong_Click_1);
            // 
            // buttonUlong
            // 
            this.buttonUlong.Location = new System.Drawing.Point(453, 107);
            this.buttonUlong.Name = "buttonUlong";
            this.buttonUlong.Size = new System.Drawing.Size(75, 23);
            this.buttonUlong.TabIndex = 0;
            this.buttonUlong.Text = "Ulong";
            this.buttonUlong.Click += new System.EventHandler(this.buttonUlong_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUlong);
            this.Controls.Add(this.buttonLong);
            this.Controls.Add(this.buttonUint);
            this.Controls.Add(this.buttonInt);
            this.Controls.Add(this.buttonUshort);
            this.Controls.Add(this.buttonShort);
            this.Controls.Add(this.buttonSbyte);
            this.Controls.Add(this.buttonByte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonByte;
        private System.Windows.Forms.Button buttonSbyte;
        private System.Windows.Forms.Button buttonShort;
        private System.Windows.Forms.Button buttonUshort;
        private System.Windows.Forms.Button buttonInt;
        private System.Windows.Forms.Button buttonUint;
        private System.Windows.Forms.Button buttonLong;
        private System.Windows.Forms.Button buttonUlong;
    }
}

