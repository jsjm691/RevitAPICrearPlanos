namespace TFMCrearPlanosJS
{
    partial class formViewList
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
            this.selectViewList = new System.Windows.Forms.CheckedListBox();
            this.btnCreateSheets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectViewList
            // 
            this.selectViewList.CheckOnClick = true;
            this.selectViewList.FormattingEnabled = true;
            this.selectViewList.Location = new System.Drawing.Point(12, 12);
            this.selectViewList.Name = "selectViewList";
            this.selectViewList.Size = new System.Drawing.Size(266, 259);
            this.selectViewList.TabIndex = 0;
            // 
            // btnCreateSheets
            // 
            this.btnCreateSheets.Location = new System.Drawing.Point(12, 294);
            this.btnCreateSheets.Name = "btnCreateSheets";
            this.btnCreateSheets.Size = new System.Drawing.Size(75, 38);
            this.btnCreateSheets.TabIndex = 1;
            this.btnCreateSheets.Text = "Create Sheets";
            this.btnCreateSheets.UseVisualStyleBackColor = true;
            this.btnCreateSheets.Click += new System.EventHandler(this.btnCreateSheets_Click);
            // 
            // formViewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 357);
            this.Controls.Add(this.btnCreateSheets);
            this.Controls.Add(this.selectViewList);
            this.Name = "formViewList";
            this.Text = "formViewList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox selectViewList;
        private System.Windows.Forms.Button btnCreateSheets;
    }
}