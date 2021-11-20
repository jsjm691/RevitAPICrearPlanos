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
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(261, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(261, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 33);
            this.button4.TabIndex = 5;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Check All";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // formViewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(358, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}