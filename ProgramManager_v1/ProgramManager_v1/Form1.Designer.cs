namespace ProgramManager_v1
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
            this.AddBtn_1 = new System.Windows.Forms.Button();
            this.RunBtn_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "LABEL_1";
            // 
            // AddBtn_1
            // 
            this.AddBtn_1.Location = new System.Drawing.Point(242, 16);
            this.AddBtn_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn_1.Name = "AddBtn_1";
            this.AddBtn_1.Size = new System.Drawing.Size(75, 23);
            this.AddBtn_1.TabIndex = 1;
            this.AddBtn_1.Text = "Add...";
            this.AddBtn_1.UseVisualStyleBackColor = true;
            this.AddBtn_1.Click += new System.EventHandler(this.AddBtn_1_Click);
            // 
            // RunBtn_1
            // 
            this.RunBtn_1.Location = new System.Drawing.Point(323, 16);
            this.RunBtn_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RunBtn_1.Name = "RunBtn_1";
            this.RunBtn_1.Size = new System.Drawing.Size(75, 23);
            this.RunBtn_1.TabIndex = 2;
            this.RunBtn_1.Text = "Run";
            this.RunBtn_1.UseVisualStyleBackColor = true;
            this.RunBtn_1.Click += new System.EventHandler(this.RunBtn_1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 291);
            this.Controls.Add(this.RunBtn_1);
            this.Controls.Add(this.AddBtn_1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBtn_1;
        private System.Windows.Forms.Button RunBtn_1;
    }
}

