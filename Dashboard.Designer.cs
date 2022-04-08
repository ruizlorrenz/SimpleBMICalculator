namespace SimpleBMICalculator {
    partial class bmiCalculatorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.programNameTextbox = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightFeetTextbox = new System.Windows.Forms.TextBox();
            this.weightTextbox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.classificationLabel = new System.Windows.Forms.Label();
            this.heightInchesTextbox = new System.Windows.Forms.TextBox();
            this.feetLabel = new System.Windows.Forms.Label();
            this.inchesLabel = new System.Windows.Forms.Label();
            this.modeButton = new System.Windows.Forms.Button();
            this.modeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // programNameTextbox
            // 
            this.programNameTextbox.AutoSize = true;
            this.programNameTextbox.Location = new System.Drawing.Point(12, 9);
            this.programNameTextbox.Name = "programNameTextbox";
            this.programNameTextbox.Size = new System.Drawing.Size(130, 24);
            this.programNameTextbox.TabIndex = 0;
            this.programNameTextbox.Text = "BMI Calculator";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(15, 51);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(70, 24);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height ";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(15, 94);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(110, 24);
            this.weightLabel.TabIndex = 2;
            this.weightLabel.Text = "Weight (lbs)";
            // 
            // heightFeetTextbox
            // 
            this.heightFeetTextbox.Location = new System.Drawing.Point(104, 51);
            this.heightFeetTextbox.Name = "heightFeetTextbox";
            this.heightFeetTextbox.Size = new System.Drawing.Size(21, 29);
            this.heightFeetTextbox.TabIndex = 3;
            // 
            // weightTextbox
            // 
            this.weightTextbox.Location = new System.Drawing.Point(137, 94);
            this.weightTextbox.Name = "weightTextbox";
            this.weightTextbox.Size = new System.Drawing.Size(55, 29);
            this.weightTextbox.TabIndex = 4;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(15, 205);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 24);
            this.resultLabel.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(74, 140);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(110, 40);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // classificationLabel
            // 
            this.classificationLabel.AutoSize = true;
            this.classificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classificationLabel.Location = new System.Drawing.Point(16, 241);
            this.classificationLabel.Name = "classificationLabel";
            this.classificationLabel.Size = new System.Drawing.Size(0, 16);
            this.classificationLabel.TabIndex = 7;
            // 
            // heightInchesTextbox
            // 
            this.heightInchesTextbox.Location = new System.Drawing.Point(160, 51);
            this.heightInchesTextbox.Name = "heightInchesTextbox";
            this.heightInchesTextbox.Size = new System.Drawing.Size(24, 29);
            this.heightInchesTextbox.TabIndex = 8;
            // 
            // feetLabel
            // 
            this.feetLabel.AutoSize = true;
            this.feetLabel.Location = new System.Drawing.Point(133, 54);
            this.feetLabel.Name = "feetLabel";
            this.feetLabel.Size = new System.Drawing.Size(18, 24);
            this.feetLabel.TabIndex = 9;
            this.feetLabel.Text = "ft";
            // 
            // inchesLabel
            // 
            this.inchesLabel.AutoSize = true;
            this.inchesLabel.Location = new System.Drawing.Point(190, 54);
            this.inchesLabel.Name = "inchesLabel";
            this.inchesLabel.Size = new System.Drawing.Size(25, 24);
            this.inchesLabel.TabIndex = 10;
            this.inchesLabel.Text = "in";
            // 
            // modeButton
            // 
            this.modeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeButton.Location = new System.Drawing.Point(221, 9);
            this.modeButton.Name = "modeButton";
            this.modeButton.Size = new System.Drawing.Size(72, 29);
            this.modeButton.TabIndex = 11;
            this.modeButton.Text = "Imperial";
            this.modeButton.UseVisualStyleBackColor = true;
            this.modeButton.Click += new System.EventHandler(this.modeButton_Click);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLabel.Location = new System.Drawing.Point(170, 15);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(45, 16);
            this.modeLabel.TabIndex = 12;
            this.modeLabel.Text = "Mode:";
            // 
            // bmiCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 264);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.modeButton);
            this.Controls.Add(this.inchesLabel);
            this.Controls.Add(this.feetLabel);
            this.Controls.Add(this.heightInchesTextbox);
            this.Controls.Add(this.classificationLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.weightTextbox);
            this.Controls.Add(this.heightFeetTextbox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.programNameTextbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "bmiCalculatorForm";
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label programNameTextbox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox heightFeetTextbox;
        private System.Windows.Forms.TextBox weightTextbox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label classificationLabel;
        private System.Windows.Forms.TextBox heightInchesTextbox;
        private System.Windows.Forms.Label feetLabel;
        private System.Windows.Forms.Label inchesLabel;
        private System.Windows.Forms.Button modeButton;
        private System.Windows.Forms.Label modeLabel;
    }
}

