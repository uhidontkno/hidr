namespace hidr
{
    partial class cmdbypass
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
            this.title = new MaterialSkin.Controls.MaterialLabel();
            this.caption = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Depth = 0;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.title.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.title.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.MouseState = MaterialSkin.MouseState.HOVER;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(317, 46);
            this.title.TabIndex = 3;
            this.title.Text = "CMD Bypasser";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // caption
            // 
            this.caption.Depth = 0;
            this.caption.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.caption.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.caption.Location = new System.Drawing.Point(12, 55);
            this.caption.MouseState = MaterialSkin.MouseState.HOVER;
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(321, 26);
            this.caption.TabIndex = 4;
            this.caption.Text = "Bypass Command Prompt Restrictions.";
            this.caption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(19, 87);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(310, 36);
            this.materialButton1.TabIndex = 5;
            this.materialButton1.Text = "Method 1: Batch Script";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(19, 218);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(310, 36);
            this.materialButton3.TabIndex = 7;
            this.materialButton3.Text = "Method 2: Powershell";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(16, 193);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(187, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "If this suffices your needs:";
            // 
            // cmdbypass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 279);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.caption);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "cmdbypass";
            this.ShowIcon = false;
            this.Text = "CMD Bypasser";
            this.Load += new System.EventHandler(this.cmdbypass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel title;
        private MaterialSkin.Controls.MaterialLabel caption;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}