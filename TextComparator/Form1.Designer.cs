namespace TextComparator
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
            this.aFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aLoadButton = new System.Windows.Forms.Button();
            this.aFileContentTextBox = new System.Windows.Forms.TextBox();
            this.bFileContentTextBox = new System.Windows.Forms.TextBox();
            this.bLoadButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bFilePathTextBox = new System.Windows.Forms.TextBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.showDiffsButton = new System.Windows.Forms.Button();
            this.addCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // aFilePathTextBox
            // 
            this.aFilePathTextBox.Location = new System.Drawing.Point(53, 12);
            this.aFilePathTextBox.Name = "aFilePathTextBox";
            this.aFilePathTextBox.Size = new System.Drawing.Size(485, 20);
            this.aFilePathTextBox.TabIndex = 0;
            this.aFilePathTextBox.Text = "E:\\Navid\\Temp\\18-12-11-09-35\\rpd1111\\traj05.txt";
            this.aFilePathTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.aFilePathTextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File A:";
            // 
            // aLoadButton
            // 
            this.aLoadButton.Location = new System.Drawing.Point(544, 10);
            this.aLoadButton.Name = "aLoadButton";
            this.aLoadButton.Size = new System.Drawing.Size(75, 23);
            this.aLoadButton.TabIndex = 2;
            this.aLoadButton.Text = "Open";
            this.aLoadButton.UseVisualStyleBackColor = true;
            this.aLoadButton.Click += new System.EventHandler(this.aLoadButton_Click);
            // 
            // aFileContentTextBox
            // 
            this.aFileContentTextBox.AllowDrop = true;
            this.aFileContentTextBox.Location = new System.Drawing.Point(13, 47);
            this.aFileContentTextBox.Multiline = true;
            this.aFileContentTextBox.Name = "aFileContentTextBox";
            this.aFileContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.aFileContentTextBox.Size = new System.Drawing.Size(606, 583);
            this.aFileContentTextBox.TabIndex = 3;
            this.aFileContentTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.aFileContentTextBox_DragDrop);
            this.aFileContentTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.aFileContentTextBox_DragEnter);
            // 
            // bFileContentTextBox
            // 
            this.bFileContentTextBox.AllowDrop = true;
            this.bFileContentTextBox.Location = new System.Drawing.Point(681, 47);
            this.bFileContentTextBox.Multiline = true;
            this.bFileContentTextBox.Name = "bFileContentTextBox";
            this.bFileContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bFileContentTextBox.Size = new System.Drawing.Size(606, 583);
            this.bFileContentTextBox.TabIndex = 7;
            this.bFileContentTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.bFileContentTextBox_DragDrop);
            this.bFileContentTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.bFileContentTextBox_DragEnter);
            // 
            // bLoadButton
            // 
            this.bLoadButton.Location = new System.Drawing.Point(1212, 10);
            this.bLoadButton.Name = "bLoadButton";
            this.bLoadButton.Size = new System.Drawing.Size(75, 23);
            this.bLoadButton.TabIndex = 6;
            this.bLoadButton.Text = "Open";
            this.bLoadButton.UseVisualStyleBackColor = true;
            this.bLoadButton.Click += new System.EventHandler(this.bLoadButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File B:";
            // 
            // bFilePathTextBox
            // 
            this.bFilePathTextBox.Location = new System.Drawing.Point(721, 12);
            this.bFilePathTextBox.Name = "bFilePathTextBox";
            this.bFilePathTextBox.Size = new System.Drawing.Size(485, 20);
            this.bFilePathTextBox.TabIndex = 4;
            this.bFilePathTextBox.Text = "E:\\Navid\\Temp\\18-12-09-17-20\\rpd1111\\traj05.txt";
            this.bFilePathTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bFilePathTextBox_KeyUp);
            // 
            // compareButton
            // 
            this.compareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareButton.Location = new System.Drawing.Point(620, 47);
            this.compareButton.Margin = new System.Windows.Forms.Padding(0);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(60, 46);
            this.compareButton.TabIndex = 8;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // showDiffsButton
            // 
            this.showDiffsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDiffsButton.Location = new System.Drawing.Point(620, 102);
            this.showDiffsButton.Margin = new System.Windows.Forms.Padding(0);
            this.showDiffsButton.Name = "showDiffsButton";
            this.showDiffsButton.Size = new System.Drawing.Size(60, 46);
            this.showDiffsButton.TabIndex = 8;
            this.showDiffsButton.Text = "Show Diffs";
            this.showDiffsButton.UseVisualStyleBackColor = true;
            this.showDiffsButton.Click += new System.EventHandler(this.showDiffsButton_Click);
            // 
            // addCheckBox
            // 
            this.addCheckBox.AutoSize = true;
            this.addCheckBox.Location = new System.Drawing.Point(621, 613);
            this.addCheckBox.Name = "addCheckBox";
            this.addCheckBox.Size = new System.Drawing.Size(61, 17);
            this.addCheckBox.TabIndex = 9;
            this.addCheckBox.Text = "Multifile";
            this.addCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 642);
            this.Controls.Add(this.addCheckBox);
            this.Controls.Add(this.showDiffsButton);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.bFileContentTextBox);
            this.Controls.Add(this.bLoadButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bFilePathTextBox);
            this.Controls.Add(this.aFileContentTextBox);
            this.Controls.Add(this.aLoadButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aFilePathTextBox);
            this.MaximumSize = new System.Drawing.Size(1315, 680);
            this.MinimumSize = new System.Drawing.Size(1315, 680);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aFilePathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aLoadButton;
        private System.Windows.Forms.TextBox aFileContentTextBox;
        private System.Windows.Forms.TextBox bFileContentTextBox;
        private System.Windows.Forms.Button bLoadButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bFilePathTextBox;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.Button showDiffsButton;
        private System.Windows.Forms.CheckBox addCheckBox;
    }
}

