namespace CFFM_Technical_Exercises
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
            this.lowerText = new System.Windows.Forms.TextBox();
            this.upperText = new System.Windows.Forms.TextBox();
            this.lower = new System.Windows.Forms.Label();
            this.upper = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.displayResults = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lowerText
            // 
            this.lowerText.Location = new System.Drawing.Point(110, 51);
            this.lowerText.Name = "lowerText";
            this.lowerText.Size = new System.Drawing.Size(100, 20);
            this.lowerText.TabIndex = 0;
            // 
            // upperText
            // 
            this.upperText.Location = new System.Drawing.Point(554, 51);
            this.upperText.Name = "upperText";
            this.upperText.Size = new System.Drawing.Size(100, 20);
            this.upperText.TabIndex = 1;
            // 
            // lower
            // 
            this.lower.AutoSize = true;
            this.lower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lower.Location = new System.Drawing.Point(117, 16);
            this.lower.Name = "lower";
            this.lower.Size = new System.Drawing.Size(87, 13);
            this.lower.TabIndex = 2;
            this.lower.Text = "Lower Bounds";
            // 
            // upper
            // 
            this.upper.AutoSize = true;
            this.upper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upper.Location = new System.Drawing.Point(560, 16);
            this.upper.Name = "upper";
            this.upper.Size = new System.Drawing.Size(87, 13);
            this.upper.TabIndex = 3;
            this.upper.Text = "Upper Bounds";
            // 
            // runButton
            // 
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.Location = new System.Drawing.Point(340, 114);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 4;
            this.runButton.Text = "Go";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // displayResults
            // 
            this.displayResults.Location = new System.Drawing.Point(43, 164);
            this.displayResults.Multiline = true;
            this.displayResults.Name = "displayResults";
            this.displayResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayResults.Size = new System.Drawing.Size(694, 227);
            this.displayResults.TabIndex = 5;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(340, 415);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.displayResults);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.upper);
            this.Controls.Add(this.lower);
            this.Controls.Add(this.upperText);
            this.Controls.Add(this.lowerText);
            this.Name = "Form1";
            this.Text = "Ex 1 User Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lowerText;
        private System.Windows.Forms.TextBox upperText;
        private System.Windows.Forms.Label lower;
        private System.Windows.Forms.Label upper;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox displayResults;
        private System.Windows.Forms.Button closeButton;
    }
}

