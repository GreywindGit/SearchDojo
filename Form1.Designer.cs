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
            this.SuspendLayout();
            // 
            // tbPattern
            // 
            this.tbPattern.Location = new System.Drawing.Point(73, 380);
            this.tbPattern.Name = "tbPattern";
            this.tbPattern.Size = new System.Drawing.Size(242, 22);
            this.tbPattern.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(350, 379);
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
            this.labelText.Location = new System.Drawing.Point(21, 5);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(35, 17);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "Text";
            // 
            // labelMatches
            // 
            this.labelMatches.AutoSize = true;
            this.labelMatches.Location = new System.Drawing.Point(350, 5);
            this.labelMatches.Name = "labelMatches";
            this.labelMatches.Size = new System.Drawing.Size(61, 17);
            this.labelMatches.TabIndex = 5;
            this.labelMatches.Text = "Matches";
            // 
            // labelSearchPattern
            // 
            this.labelSearchPattern.AutoSize = true;
            this.labelSearchPattern.Location = new System.Drawing.Point(12, 383);
            this.labelSearchPattern.Name = "labelSearchPattern";
            this.labelSearchPattern.Size = new System.Drawing.Size(54, 17);
            this.labelSearchPattern.TabIndex = 6;
            this.labelSearchPattern.Text = "Pattern";
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(21, 28);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(294, 320);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            // 
            // lvMatches
            // 
            this.lvMatches.Location = new System.Drawing.Point(350, 28);
            this.lvMatches.Name = "lvMatches";
            this.lvMatches.Size = new System.Drawing.Size(282, 320);
            this.lvMatches.TabIndex = 7;
            this.lvMatches.UseCompatibleStateImageBehavior = false;
            this.lvMatches.View = System.Windows.Forms.View.List;
            // 
            // Matcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 449);
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
    }
}

