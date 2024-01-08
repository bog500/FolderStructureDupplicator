namespace FolderStructureDupplicator
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
            this.txtFolderSource = new System.Windows.Forms.TextBox();
            this.txtFolderDest = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFolderSource
            // 
            this.txtFolderSource.Location = new System.Drawing.Point(64, 72);
            this.txtFolderSource.Name = "txtFolderSource";
            this.txtFolderSource.Size = new System.Drawing.Size(403, 20);
            this.txtFolderSource.TabIndex = 0;
            this.txtFolderSource.Text = "J:\\Folder1";
            // 
            // txtFolderDest
            // 
            this.txtFolderDest.Location = new System.Drawing.Point(64, 140);
            this.txtFolderDest.Name = "txtFolderDest";
            this.txtFolderDest.Size = new System.Drawing.Size(396, 20);
            this.txtFolderDest.TabIndex = 1;
            this.txtFolderDest.Text = "J:\\Folder2";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(494, 72);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 88);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start dupplication";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 247);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtFolderDest);
            this.Controls.Add(this.txtFolderSource);
            this.Name = "Form1";
            this.Text = "FolderStructureDupplicator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolderSource;
        private System.Windows.Forms.TextBox txtFolderDest;
        private System.Windows.Forms.Button btnStart;
    }
}

