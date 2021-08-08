namespace PortfolioTask1._2
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
            this.btnHello = new System.Windows.Forms.Button();
            this.btnBye = new System.Windows.Forms.Button();
            this.labelHelloBye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(91, 108);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(177, 87);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Click to say hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBye
            // 
            this.btnBye.Location = new System.Drawing.Point(471, 108);
            this.btnBye.Name = "btnBye";
            this.btnBye.Size = new System.Drawing.Size(168, 87);
            this.btnBye.TabIndex = 1;
            this.btnBye.Text = "Click to say goodbye";
            this.btnBye.UseVisualStyleBackColor = true;
            this.btnBye.Click += new System.EventHandler(this.btnBye_Click);
            // 
            // labelHelloBye
            // 
            this.labelHelloBye.AutoSize = true;
            this.labelHelloBye.Location = new System.Drawing.Point(335, 324);
            this.labelHelloBye.Name = "labelHelloBye";
            this.labelHelloBye.Size = new System.Drawing.Size(70, 25);
            this.labelHelloBye.TabIndex = 2;
            this.labelHelloBye.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHelloBye);
            this.Controls.Add(this.btnBye);
            this.Controls.Add(this.btnHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnBye;
        private System.Windows.Forms.Label labelHelloBye;
    }
}

