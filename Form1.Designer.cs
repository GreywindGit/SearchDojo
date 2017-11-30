namespace SearchDojo
{
    partial class Matcher
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
            this.tbPattern = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.labelMatches = new System.Windows.Forms.Label();
            this.labelSearchPattern = new System.Windows.Forms.Label();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.lvMatches = new System.Windows.Forms.ListView();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tbPattern
            // 
            this.tbPattern.Location = new System.Drawing.Point(73, 488);
            this.tbPattern.Name = "tbPattern";
            this.tbPattern.Size = new System.Drawing.Size(242, 22);
            this.tbPattern.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(353, 487);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(139, 21);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(35, 17);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "Text";
            // 
            // labelMatches
            // 
            this.labelMatches.AutoSize = true;
            this.labelMatches.Location = new System.Drawing.Point(453, 18);
            this.labelMatches.Name = "labelMatches";
            this.labelMatches.Size = new System.Drawing.Size(61, 17);
            this.labelMatches.TabIndex = 5;
            this.labelMatches.Text = "Matches";
            // 
            // labelSearchPattern
            // 
            this.labelSearchPattern.AutoSize = true;
            this.labelSearchPattern.Location = new System.Drawing.Point(12, 493);
            this.labelSearchPattern.Name = "labelSearchPattern";
            this.labelSearchPattern.Size = new System.Drawing.Size(54, 17);
            this.labelSearchPattern.TabIndex = 6;
            this.labelSearchPattern.Text = "Pattern";
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(24, 54);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(390, 397);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            // 
            // lvMatches
            // 
            this.lvMatches.Location = new System.Drawing.Point(456, 63);
            this.lvMatches.Name = "lvMatches";
            this.lvMatches.Size = new System.Drawing.Size(400, 388);
            this.lvMatches.TabIndex = 7;
            this.lvMatches.UseCompatibleStateImageBehavior = false;
            this.lvMatches.View = System.Windows.Forms.View.List;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(24, 18);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(99, 23);
            this.btnOpenFile.TabIndex = 8;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Text Files | *.txt";
            // 
            // Matcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 547);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lvMatches);
            this.Controls.Add(this.labelSearchPattern);
            this.Controls.Add(this.labelMatches);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.tbPattern);
            this.Name = "Matcher";
            this.Text = "Matcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPattern;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelMatches;
        private System.Windows.Forms.Label labelSearchPattern;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.ListView lvMatches;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

