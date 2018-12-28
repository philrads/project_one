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
            this.listView1 = new System.Windows.Forms.ListView();
            this.FileNameC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilePathC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelRunBtn = new System.Windows.Forms.Button();
            this.SaveListBtn = new System.Windows.Forms.Button();
            this.LoadListBtn = new System.Windows.Forms.Button();
            this.delSelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "LABEL_1";
            // 
            // AddBtn_1
            // 
            this.AddBtn_1.Location = new System.Drawing.Point(439, 13);
            this.AddBtn_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn_1.Name = "AddBtn_1";
            this.AddBtn_1.Size = new System.Drawing.Size(138, 28);
            this.AddBtn_1.TabIndex = 1;
            this.AddBtn_1.Text = "Add program...";
            this.AddBtn_1.UseVisualStyleBackColor = true;
            this.AddBtn_1.Click += new System.EventHandler(this.AddBtn_1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileNameC,
            this.FilePathC});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(16, 47);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(561, 338);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FileNameC
            // 
            this.FileNameC.Text = "Filename";
            this.FileNameC.Width = 100;
            // 
            // FilePathC
            // 
            this.FilePathC.Text = "Filepath";
            this.FilePathC.Width = 300;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Brown;
            this.imageList1.Images.SetKeyName(0, "HAPPYFACE - Copy.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SelRunBtn
            // 
            this.SelRunBtn.Location = new System.Drawing.Point(584, 47);
            this.SelRunBtn.Name = "SelRunBtn";
            this.SelRunBtn.Size = new System.Drawing.Size(143, 40);
            this.SelRunBtn.TabIndex = 5;
            this.SelRunBtn.Text = "Run selected";
            this.SelRunBtn.UseVisualStyleBackColor = true;
            this.SelRunBtn.Click += new System.EventHandler(this.SelRunBtn_Click);
            // 
            // SaveListBtn
            // 
            this.SaveListBtn.Location = new System.Drawing.Point(584, 362);
            this.SaveListBtn.Name = "SaveListBtn";
            this.SaveListBtn.Size = new System.Drawing.Size(143, 23);
            this.SaveListBtn.TabIndex = 6;
            this.SaveListBtn.Text = "Save list";
            this.SaveListBtn.UseVisualStyleBackColor = true;
            this.SaveListBtn.Click += new System.EventHandler(this.SaveListBtn_Click);
            // 
            // LoadListBtn
            // 
            this.LoadListBtn.Location = new System.Drawing.Point(584, 333);
            this.LoadListBtn.Name = "LoadListBtn";
            this.LoadListBtn.Size = new System.Drawing.Size(143, 23);
            this.LoadListBtn.TabIndex = 7;
            this.LoadListBtn.Text = "Load list";
            this.LoadListBtn.UseVisualStyleBackColor = true;
            this.LoadListBtn.Click += new System.EventHandler(this.LoadListBtn_Click);
            // 
            // delSelBtn
            // 
            this.delSelBtn.Location = new System.Drawing.Point(584, 93);
            this.delSelBtn.Name = "delSelBtn";
            this.delSelBtn.Size = new System.Drawing.Size(143, 40);
            this.delSelBtn.TabIndex = 8;
            this.delSelBtn.Text = "Delete selected";
            this.delSelBtn.UseVisualStyleBackColor = true;
            this.delSelBtn.Click += new System.EventHandler(this.delSelBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 396);
            this.Controls.Add(this.delSelBtn);
            this.Controls.Add(this.LoadListBtn);
            this.Controls.Add(this.SaveListBtn);
            this.Controls.Add(this.SelRunBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.AddBtn_1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SoftwareManager [v.1228]";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBtn_1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SelRunBtn;
        private System.Windows.Forms.ColumnHeader FileNameC;
        private System.Windows.Forms.ColumnHeader FilePathC;
        private System.Windows.Forms.Button SaveListBtn;
        private System.Windows.Forms.Button LoadListBtn;
        private System.Windows.Forms.Button delSelBtn;
    }
}

