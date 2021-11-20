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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formViewList));
            this.selectViewList = new System.Windows.Forms.CheckedListBox();
            this.btnCreateSheets = new System.Windows.Forms.Button();
            this.btnResetSelection = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectViewList
            // 
            this.selectViewList.CheckOnClick = true;
            this.selectViewList.FormattingEnabled = true;
            this.selectViewList.Location = new System.Drawing.Point(12, 18);
            this.selectViewList.Name = "selectViewList";
            this.selectViewList.Size = new System.Drawing.Size(241, 259);
            this.selectViewList.TabIndex = 0;
            // 
            // btnCreateSheets
            // 
            this.btnCreateSheets.Font = new System.Drawing.Font("Lucida Sans", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSheets.Location = new System.Drawing.Point(261, 98);
            this.btnCreateSheets.Name = "btnCreateSheets";
            this.btnCreateSheets.Size = new System.Drawing.Size(87, 33);
            this.btnCreateSheets.TabIndex = 1;
            this.btnCreateSheets.Text = "Create Sheets";
            this.btnCreateSheets.UseVisualStyleBackColor = true;
            this.btnCreateSheets.Click += new System.EventHandler(this.btnCreateSheets_Click);
            // 
            // btnResetSelection
            // 
            this.btnResetSelection.Font = new System.Drawing.Font("Lucida Sans", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSelection.Location = new System.Drawing.Point(261, 58);
            this.btnResetSelection.Name = "btnResetSelection";
            this.btnResetSelection.Size = new System.Drawing.Size(87, 33);
            this.btnResetSelection.TabIndex = 3;
            this.btnResetSelection.Text = "Reset";
            this.btnResetSelection.UseVisualStyleBackColor = true;
            this.btnResetSelection.Click += new System.EventHandler(this.btnResetSelection_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(261, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Font = new System.Drawing.Font("Lucida Sans", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.Location = new System.Drawing.Point(261, 18);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(87, 33);
            this.btnSelectAll.TabIndex = 7;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // formViewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(358, 296);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnResetSelection);
            this.Controls.Add(this.btnCreateSheets);
            this.Controls.Add(this.selectViewList);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formViewList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Views On Sheets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox selectViewList;
        private System.Windows.Forms.Button btnCreateSheets;
        private System.Windows.Forms.Button btnResetSelection;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelectAll;
    }
}