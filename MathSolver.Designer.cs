namespace hidr
{
    partial class MathSolver
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.problem = new MaterialSkin.Controls.MaterialTextBox2();
            this.output = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.operation = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(13, 50);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(349, 20);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Solve, simplify, or factorize anything.";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(13, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(344, 41);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Math Solver";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // problem
            // 
            this.problem.AnimateReadOnly = false;
            this.problem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.problem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.problem.Depth = 0;
            this.problem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.problem.HelperText = "Enter a problem";
            this.problem.HideSelection = true;
            this.problem.Hint = "Enter a problem";
            this.problem.LeadingIcon = null;
            this.problem.Location = new System.Drawing.Point(132, 75);
            this.problem.MaxLength = 32767;
            this.problem.MouseState = MaterialSkin.MouseState.OUT;
            this.problem.Name = "problem";
            this.problem.PasswordChar = '\0';
            this.problem.ReadOnly = false;
            this.problem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.problem.SelectedText = "";
            this.problem.SelectionLength = 0;
            this.problem.SelectionStart = 0;
            this.problem.ShortcutsEnabled = true;
            this.problem.Size = new System.Drawing.Size(230, 36);
            this.problem.TabIndex = 5;
            this.problem.TabStop = false;
            this.problem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.problem.TrailingIcon = null;
            this.problem.UseAccent = false;
            this.problem.UseSystemPasswordChar = false;
            this.problem.UseTallSize = false;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Font = new System.Drawing.Font("Consolas", 10F);
            this.output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.output.Location = new System.Drawing.Point(12, 214);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(350, 139);
            this.output.TabIndex = 6;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(12, 191);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(322, 20);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Output:";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // operation
            // 
            this.operation.AutoResize = false;
            this.operation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.operation.Depth = 0;
            this.operation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.operation.DropDownHeight = 118;
            this.operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operation.DropDownWidth = 121;
            this.operation.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.operation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.operation.FormattingEnabled = true;
            this.operation.Hint = "Operation";
            this.operation.IntegralHeight = false;
            this.operation.ItemHeight = 29;
            this.operation.Items.AddRange(new object[] {
            "Solve",
            "Simplify",
            "Factorize"});
            this.operation.Location = new System.Drawing.Point(12, 76);
            this.operation.MaxDropDownItems = 4;
            this.operation.MouseState = MaterialSkin.MouseState.OUT;
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(114, 35);
            this.operation.StartIndex = 0;
            this.operation.TabIndex = 8;
            this.operation.UseTallSize = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(15, 124);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(342, 36);
            this.materialButton1.TabIndex = 9;
            this.materialButton1.Text = "GIMME ANSWERS";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // MathSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 365);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.output);
            this.Controls.Add(this.problem);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MathSolver";
            this.Text = "Math Solver";
            this.Load += new System.EventHandler(this.MathSolver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 problem;
        private System.Windows.Forms.TextBox output;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox operation;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}