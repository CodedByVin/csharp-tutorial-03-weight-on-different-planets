namespace youtube_prac4
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudWeightEarth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMoon = new System.Windows.Forms.Button();
            this.btnMars = new System.Windows.Forms.Button();
            this.btnJupiter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightEarth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight on Earth";
            // 
            // nudWeightEarth
            // 
            this.nudWeightEarth.DecimalPlaces = 2;
            this.nudWeightEarth.Location = new System.Drawing.Point(325, 98);
            this.nudWeightEarth.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudWeightEarth.Name = "nudWeightEarth";
            this.nudWeightEarth.Size = new System.Drawing.Size(73, 20);
            this.nudWeightEarth.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "How much do i weigh on";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJupiter);
            this.groupBox1.Controls.Add(this.btnMars);
            this.groupBox1.Controls.Add(this.btnMoon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(183, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planets";
            // 
            // btnMoon
            // 
            this.btnMoon.Location = new System.Drawing.Point(23, 41);
            this.btnMoon.Name = "btnMoon";
            this.btnMoon.Size = new System.Drawing.Size(75, 85);
            this.btnMoon.TabIndex = 0;
            this.btnMoon.Text = "Moon";
            this.btnMoon.UseVisualStyleBackColor = true;
            this.btnMoon.Click += new System.EventHandler(this.btnMoon_Click);
            // 
            // btnMars
            // 
            this.btnMars.Location = new System.Drawing.Point(142, 41);
            this.btnMars.Name = "btnMars";
            this.btnMars.Size = new System.Drawing.Size(75, 85);
            this.btnMars.TabIndex = 1;
            this.btnMars.Text = "Mars";
            this.btnMars.UseVisualStyleBackColor = true;
            this.btnMars.Click += new System.EventHandler(this.btnMars_Click);
            // 
            // btnJupiter
            // 
            this.btnJupiter.Location = new System.Drawing.Point(261, 41);
            this.btnJupiter.Name = "btnJupiter";
            this.btnJupiter.Size = new System.Drawing.Size(75, 85);
            this.btnJupiter.TabIndex = 2;
            this.btnJupiter.Text = "Jupiter";
            this.btnJupiter.UseVisualStyleBackColor = true;
            this.btnJupiter.Click += new System.EventHandler(this.btnJupiter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudWeightEarth);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightEarth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudWeightEarth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnJupiter;
        private System.Windows.Forms.Button btnMars;
        private System.Windows.Forms.Button btnMoon;
    }
}

