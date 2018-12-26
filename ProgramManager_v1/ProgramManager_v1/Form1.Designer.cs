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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn_1 = new System.Windows.Forms.Button();
            this.RunBtn_1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelRunBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(49, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "LABEL_1";
            // 
            // AddBtn_1
            // 
            this.AddBtn_1.Location = new System.Drawing.Point(243, 16);
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
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(16, 47);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(381, 338);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Brown;
            this.imageList1.Images.SetKeyName(0, "HAPPYFACE - Copy.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SelRunBtn
            // 
            this.SelRunBtn.Location = new System.Drawing.Point(404, 47);
            this.SelRunBtn.Name = "SelRunBtn";
            this.SelRunBtn.Size = new System.Drawing.Size(112, 40);
            this.SelRunBtn.TabIndex = 5;
            this.SelRunBtn.Text = "Run selected";
            this.SelRunBtn.UseVisualStyleBackColor = true;
            this.SelRunBtn.Click += new System.EventHandler(this.SelRunBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 390);
            this.Controls.Add(this.SelRunBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.RunBtn_1);
            this.Controls.Add(this.AddBtn_1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "SoftwareMangment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBtn_1;
        private System.Windows.Forms.Button RunBtn_1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SelRunBtn;
    }
}

