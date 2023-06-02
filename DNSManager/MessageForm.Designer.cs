namespace DNSManager
{
    partial class MessageForm
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
            buttonDone = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            buttonCancel = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.AccessibleRole = AccessibleRole.None;
            buttonDone.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDone.Cursor = Cursors.Hand;
            buttonDone.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonDone.Depth = 0;
            buttonDone.HighEmphasis = true;
            buttonDone.Icon = null;
            buttonDone.Location = new Point(19, 139);
            buttonDone.Margin = new Padding(4, 6, 4, 6);
            buttonDone.MouseState = MaterialSkin.MouseState.HOVER;
            buttonDone.Name = "buttonDone";
            buttonDone.NoAccentTextColor = Color.Empty;
            buttonDone.Size = new Size(64, 36);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Done";
            buttonDone.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonDone.UseAccentColor = false;
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(19, 71);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(286, 62);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Message";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(19, 47);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(286, 26);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Title";
            materialLabel2.Visible = false;
            // 
            // buttonCancel
            // 
            buttonCancel.AccessibleRole = AccessibleRole.None;
            buttonCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonCancel.Depth = 0;
            buttonCancel.HighEmphasis = true;
            buttonCancel.Icon = null;
            buttonCancel.Location = new Point(228, 139);
            buttonCancel.Margin = new Padding(4, 6, 4, 6);
            buttonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            buttonCancel.Name = "buttonCancel";
            buttonCancel.NoAccentTextColor = Color.Empty;
            buttonCancel.Size = new Size(77, 36);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonCancel.UseAccentColor = false;
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Visible = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // MessageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 387);
            Controls.Add(buttonCancel);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(buttonDone);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            FormStyle = FormStyles.ActionBar_None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MessageForm";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterParent;
            Text = "MessageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonDone;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton buttonCancel;
    }
}