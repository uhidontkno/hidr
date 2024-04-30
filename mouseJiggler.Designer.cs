namespace hidr
{
    partial class mouseJiggler
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
            this.jiggleButton = new MaterialSkin.Controls.MaterialButton();
            this.clickSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.optionsText = new MaterialSkin.Controls.MaterialLabel();
            this.keyPressSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.card = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.card.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Depth = 0;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.title.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.title.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.title.Location = new System.Drawing.Point(7, 9);
            this.title.MouseState = MaterialSkin.MouseState.HOVER;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(317, 93);
            this.title.TabIndex = 2;
            this.title.Text = "Virtual Mouse Jiggler";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // caption
            // 
            this.caption.Depth = 0;
            this.caption.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.caption.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.caption.Location = new System.Drawing.Point(7, 102);
            this.caption.MouseState = MaterialSkin.MouseState.HOVER;
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(311, 26);
            this.caption.TabIndex = 3;
            this.caption.Text = "Self explanatory.";
            this.caption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // jiggleButton
            // 
            this.jiggleButton.AutoSize = false;
            this.jiggleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jiggleButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.jiggleButton.Depth = 0;
            this.jiggleButton.HighEmphasis = true;
            this.jiggleButton.Icon = null;
            this.jiggleButton.Location = new System.Drawing.Point(13, 266);
            this.jiggleButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.jiggleButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.jiggleButton.Name = "jiggleButton";
            this.jiggleButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.jiggleButton.Size = new System.Drawing.Size(300, 36);
            this.jiggleButton.TabIndex = 4;
            this.jiggleButton.Text = "Start Jiggling";
            this.jiggleButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.jiggleButton.UseAccentColor = false;
            this.jiggleButton.UseVisualStyleBackColor = true;
            this.jiggleButton.Click += new System.EventHandler(this.jiggleButton_Click);
            // 
            // clickSwitch
            // 
            this.clickSwitch.AutoSize = true;
            this.clickSwitch.Depth = 0;
            this.clickSwitch.Location = new System.Drawing.Point(15, 160);
            this.clickSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.clickSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.clickSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.clickSwitch.Name = "clickSwitch";
            this.clickSwitch.Ripple = true;
            this.clickSwitch.Size = new System.Drawing.Size(164, 37);
            this.clickSwitch.TabIndex = 5;
            this.clickSwitch.Text = "Random Clicks";
            this.clickSwitch.UseVisualStyleBackColor = true;
            // 
            // optionsText
            // 
            this.optionsText.AutoSize = true;
            this.optionsText.Depth = 0;
            this.optionsText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.optionsText.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.optionsText.Location = new System.Drawing.Point(24, 143);
            this.optionsText.MouseState = MaterialSkin.MouseState.HOVER;
            this.optionsText.Name = "optionsText";
            this.optionsText.Size = new System.Drawing.Size(61, 17);
            this.optionsText.TabIndex = 6;
            this.optionsText.Text = "OPTIONS";
            // 
            // keyPressSwitch
            // 
            this.keyPressSwitch.AutoSize = true;
            this.keyPressSwitch.Depth = 0;
            this.keyPressSwitch.Location = new System.Drawing.Point(15, 197);
            this.keyPressSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.keyPressSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.keyPressSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.keyPressSwitch.Name = "keyPressSwitch";
            this.keyPressSwitch.Ripple = true;
            this.keyPressSwitch.Size = new System.Drawing.Size(202, 37);
            this.keyPressSwitch.TabIndex = 7;
            this.keyPressSwitch.Text = "Random Keypresses";
            this.keyPressSwitch.UseVisualStyleBackColor = true;
            // 
            // card
            // 
            this.card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.card.Controls.Add(this.materialLabel4);
            this.card.Depth = 0;
            this.card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.card.Location = new System.Drawing.Point(9, 9);
            this.card.Margin = new System.Windows.Forms.Padding(14);
            this.card.MouseState = MaterialSkin.MouseState.HOVER;
            this.card.Name = "card";
            this.card.Padding = new System.Windows.Forms.Padding(14);
            this.card.Size = new System.Drawing.Size(201, 47);
            this.card.TabIndex = 8;
            this.card.Visible = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel4.Location = new System.Drawing.Point(17, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(138, 17);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Hold down F7 to stop.";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mouseJiggler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 319);
            this.Controls.Add(this.card);
            this.Controls.Add(this.keyPressSwitch);
            this.Controls.Add(this.optionsText);
            this.Controls.Add(this.clickSwitch);
            this.Controls.Add(this.jiggleButton);
            this.Controls.Add(this.caption);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "mouseJiggler";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Mouse Jiggler";
            this.Load += new System.EventHandler(this.mouseJiggler_Load);
            this.card.ResumeLayout(false);
            this.card.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel title;
        private MaterialSkin.Controls.MaterialLabel caption;
        private MaterialSkin.Controls.MaterialButton jiggleButton;
        private MaterialSkin.Controls.MaterialSwitch clickSwitch;
        private MaterialSkin.Controls.MaterialLabel optionsText;
        private MaterialSkin.Controls.MaterialSwitch keyPressSwitch;
        private MaterialSkin.Controls.MaterialCard card;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}