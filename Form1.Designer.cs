namespace Boids
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
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudBoundary = new System.Windows.Forms.NumericUpDown();
            this.nudRate = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPredators = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudFlockStrength = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAlignStrength = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudPredatorSpeed = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudBorder = new System.Windows.Forms.NumericUpDown();
            this.nudSight = new System.Windows.Forms.NumericUpDown();
            this.nudSpace = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPredators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlockStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlignStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPredatorSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count";
            // 
            // nudCount
            // 
            this.nudCount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCount.Location = new System.Drawing.Point(198, 79);
            this.nudCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCount.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(180, 26);
            this.nudCount.TabIndex = 1;
            this.nudCount.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate (ms)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Boundary (px²)";
            // 
            // nudBoundary
            // 
            this.nudBoundary.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudBoundary.Location = new System.Drawing.Point(198, 151);
            this.nudBoundary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudBoundary.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBoundary.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudBoundary.Name = "nudBoundary";
            this.nudBoundary.Size = new System.Drawing.Size(180, 26);
            this.nudBoundary.TabIndex = 4;
            this.nudBoundary.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // nudRate
            // 
            this.nudRate.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudRate.Location = new System.Drawing.Point(198, 115);
            this.nudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudRate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRate.Name = "nudRate";
            this.nudRate.Size = new System.Drawing.Size(180, 26);
            this.nudRate.TabIndex = 5;
            this.nudRate.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(231, 617);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 46);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Predators";
            // 
            // nudPredators
            // 
            this.nudPredators.Location = new System.Drawing.Point(198, 187);
            this.nudPredators.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudPredators.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPredators.Name = "nudPredators";
            this.nudPredators.Size = new System.Drawing.Size(180, 26);
            this.nudPredators.TabIndex = 8;
            this.nudPredators.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 461);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Algorithm Constants";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 511);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Flock Strength";
            // 
            // nudFlockStrength
            // 
            this.nudFlockStrength.DecimalPlaces = 3;
            this.nudFlockStrength.Increment = new decimal(new int[] {
            25,
            0,
            0,
            196608});
            this.nudFlockStrength.Location = new System.Drawing.Point(198, 509);
            this.nudFlockStrength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudFlockStrength.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudFlockStrength.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            196608});
            this.nudFlockStrength.Name = "nudFlockStrength";
            this.nudFlockStrength.Size = new System.Drawing.Size(180, 26);
            this.nudFlockStrength.TabIndex = 11;
            this.nudFlockStrength.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 547);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Align Strength";
            // 
            // nudAlignStrength
            // 
            this.nudAlignStrength.DecimalPlaces = 2;
            this.nudAlignStrength.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudAlignStrength.Location = new System.Drawing.Point(198, 545);
            this.nudAlignStrength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAlignStrength.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAlignStrength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudAlignStrength.Name = "nudAlignStrength";
            this.nudAlignStrength.Size = new System.Drawing.Size(180, 26);
            this.nudAlignStrength.TabIndex = 13;
            this.nudAlignStrength.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 583);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Predator Speed Divisor";
            // 
            // nudPredatorSpeed
            // 
            this.nudPredatorSpeed.DecimalPlaces = 1;
            this.nudPredatorSpeed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPredatorSpeed.Location = new System.Drawing.Point(198, 581);
            this.nudPredatorSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudPredatorSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPredatorSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPredatorSpeed.Name = "nudPredatorSpeed";
            this.nudPredatorSpeed.Size = new System.Drawing.Size(180, 26);
            this.nudPredatorSpeed.TabIndex = 15;
            this.nudPredatorSpeed.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Basic Settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 249);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Boid Constants";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 403);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Speed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 367);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Space";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 331);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Sight";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 295);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Border";
            // 
            // nudSpeed
            // 
            this.nudSpeed.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSpeed.Location = new System.Drawing.Point(198, 401);
            this.nudSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSpeed.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(180, 26);
            this.nudSpeed.TabIndex = 22;
            this.nudSpeed.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // nudBorder
            // 
            this.nudBorder.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBorder.Location = new System.Drawing.Point(198, 293);
            this.nudBorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudBorder.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudBorder.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudBorder.Name = "nudBorder";
            this.nudBorder.Size = new System.Drawing.Size(180, 26);
            this.nudBorder.TabIndex = 23;
            this.nudBorder.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudSight
            // 
            this.nudSight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSight.Location = new System.Drawing.Point(198, 329);
            this.nudSight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSight.Maximum = new decimal(new int[] {
            225,
            0,
            0,
            0});
            this.nudSight.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudSight.Name = "nudSight";
            this.nudSight.Size = new System.Drawing.Size(180, 26);
            this.nudSight.TabIndex = 24;
            this.nudSight.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // nudSpace
            // 
            this.nudSpace.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSpace.Location = new System.Drawing.Point(198, 365);
            this.nudSpace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSpace.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudSpace.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSpace.Name = "nudSpace";
            this.nudSpace.Size = new System.Drawing.Size(180, 26);
            this.nudSpace.TabIndex = 30;
            this.nudSpace.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 689);
            this.Controls.Add(this.nudSpace);
            this.Controls.Add(this.nudSight);
            this.Controls.Add(this.nudBorder);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudPredatorSpeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudAlignStrength);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudFlockStrength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudPredators);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nudRate);
            this.Controls.Add(this.nudBoundary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Boids";
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoundary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPredators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlockStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlignStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPredatorSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudBoundary;
        private System.Windows.Forms.NumericUpDown nudRate;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPredators;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudFlockStrength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudAlignStrength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudPredatorSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.NumericUpDown nudBorder;
        private System.Windows.Forms.NumericUpDown nudSight;
        private System.Windows.Forms.NumericUpDown nudSpace;
    }
}

