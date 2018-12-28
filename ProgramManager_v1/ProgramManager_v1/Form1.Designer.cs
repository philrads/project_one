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
            this.DelSelBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.RunAllBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(44, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLACEHOLDER TEXT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddBtn_1
            // 
            this.AddBtn_1.Location = new System.Drawing.Point(329, 16);
            this.AddBtn_1.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn_1.Name = "AddBtn_1";
            this.AddBtn_1.Size = new System.Drawing.Size(104, 23);
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
            this.listView1.Location = new System.Drawing.Point(12, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(422, 275);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SelRunBtn
            // 
            this.SelRunBtn.Location = new System.Drawing.Point(438, 43);
            this.SelRunBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SelRunBtn.Name = "SelRunBtn";
            this.SelRunBtn.Size = new System.Drawing.Size(107, 32);
            this.SelRunBtn.TabIndex = 5;
            this.SelRunBtn.Text = "Run selected";
            this.SelRunBtn.UseVisualStyleBackColor = true;
            this.SelRunBtn.Click += new System.EventHandler(this.SelRunBtn_Click);
            // 
            // SaveListBtn
            // 
            this.SaveListBtn.Location = new System.Drawing.Point(438, 299);
            this.SaveListBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveListBtn.Name = "SaveListBtn";
            this.SaveListBtn.Size = new System.Drawing.Size(107, 19);
            this.SaveListBtn.TabIndex = 6;
            this.SaveListBtn.Text = "Save list";
            this.SaveListBtn.UseVisualStyleBackColor = true;
            this.SaveListBtn.Click += new System.EventHandler(this.SaveListBtn_Click);
            // 
            // LoadListBtn
            // 
            this.LoadListBtn.Location = new System.Drawing.Point(438, 276);
            this.LoadListBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LoadListBtn.Name = "LoadListBtn";
            this.LoadListBtn.Size = new System.Drawing.Size(107, 19);
            this.LoadListBtn.TabIndex = 7;
            this.LoadListBtn.Text = "Load list";
            this.LoadListBtn.UseVisualStyleBackColor = true;
            this.LoadListBtn.Click += new System.EventHandler(this.LoadListBtn_Click);
            // 
            // DelSelBtn
            // 
            this.DelSelBtn.Location = new System.Drawing.Point(438, 81);
            this.DelSelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DelSelBtn.Name = "DelSelBtn";
            this.DelSelBtn.Size = new System.Drawing.Size(107, 32);
            this.DelSelBtn.TabIndex = 8;
            this.DelSelBtn.Text = "Delete selected";
            this.DelSelBtn.UseVisualStyleBackColor = true;
            this.DelSelBtn.Click += new System.EventHandler(this.DelSelBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(438, 137);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(58, 22);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Clear all";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // RunAllBtn
            // 
            this.RunAllBtn.Location = new System.Drawing.Point(438, 164);
            this.RunAllBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RunAllBtn.Name = "RunAllBtn";
            this.RunAllBtn.Size = new System.Drawing.Size(58, 22);
            this.RunAllBtn.TabIndex = 10;
            this.RunAllBtn.Text = "Run all";
            this.RunAllBtn.UseVisualStyleBackColor = true;
            this.RunAllBtn.Click += new System.EventHandler(this.RunAllBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 340);
            this.Controls.Add(this.RunAllBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DelSelBtn);
            this.Controls.Add(this.LoadListBtn);
            this.Controls.Add(this.SaveListBtn);
            this.Controls.Add(this.SelRunBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.AddBtn_1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SoftwareManager [v.1228]";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button DelSelBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button RunAllBtn;
    }
}

