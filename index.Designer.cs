namespace hidr
{
    partial class index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.themeBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // themeBtn
            // 
            this.themeBtn.AutoEllipsis = true;
            this.themeBtn.AutoSize = false;
            this.themeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.themeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.themeBtn.Depth = 0;
            this.themeBtn.FlatAppearance.BorderSize = 4;
            this.themeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeBtn.HighEmphasis = true;
            this.themeBtn.Icon = null;
            this.themeBtn.Location = new System.Drawing.Point(218, 30);
            this.themeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.themeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeBtn.Name = "themeBtn";
            this.themeBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.themeBtn.Size = new System.Drawing.Size(62, 27);
            this.themeBtn.TabIndex = 1;
            this.themeBtn.Text = "theme";
            this.themeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.themeBtn.UseAccentColor = true;
            this.themeBtn.UseVisualStyleBackColor = true;
            this.themeBtn.Click += new System.EventHandler(this.themeBtn_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 366);
            this.Controls.Add(this.themeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "index";
            this.Text = "hidr";
            this.Load += new System.EventHandler(this.index_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton themeBtn;
    }
}

