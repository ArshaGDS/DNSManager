namespace DNSManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxDNS = new MaterialSkin.Controls.MaterialComboBox();
            textBoxName = new MaterialSkin.Controls.MaterialTextBox2();
            textBoxDNS1 = new MaterialSkin.Controls.MaterialTextBox2();
            textBoxDNS2 = new MaterialSkin.Controls.MaterialTextBox2();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            buttonClearDNS = new MaterialSkin.Controls.MaterialButton();
            buttonApplyDNS = new MaterialSkin.Controls.MaterialButton();
            buttonEdit = new MaterialSkin.Controls.MaterialButton();
            buttonDelete = new MaterialSkin.Controls.MaterialButton();
            buttonAdd = new MaterialSkin.Controls.MaterialButton();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxDNS
            // 
            comboBoxDNS.AutoResize = false;
            comboBoxDNS.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxDNS.Depth = 0;
            comboBoxDNS.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxDNS.DropDownHeight = 174;
            comboBoxDNS.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDNS.DropDownWidth = 121;
            comboBoxDNS.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBoxDNS.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxDNS.FormattingEnabled = true;
            comboBoxDNS.IntegralHeight = false;
            comboBoxDNS.ItemHeight = 43;
            comboBoxDNS.Location = new Point(17, 274);
            comboBoxDNS.MaxDropDownItems = 4;
            comboBoxDNS.MouseState = MaterialSkin.MouseState.OUT;
            comboBoxDNS.Name = "comboBoxDNS";
            comboBoxDNS.Size = new Size(220, 49);
            comboBoxDNS.StartIndex = 0;
            comboBoxDNS.TabIndex = 4;
            comboBoxDNS.TextChanged += comboBoxDNS_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.AnimateReadOnly = false;
            textBoxName.BackgroundImageLayout = ImageLayout.None;
            textBoxName.CharacterCasing = CharacterCasing.Normal;
            textBoxName.Depth = 0;
            textBoxName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxName.HideSelection = true;
            textBoxName.LeadingIcon = null;
            textBoxName.Location = new Point(20, 35);
            textBoxName.MaxLength = 32767;
            textBoxName.MouseState = MaterialSkin.MouseState.OUT;
            textBoxName.Name = "textBoxName";
            textBoxName.PasswordChar = '\0';
            textBoxName.PrefixSuffixText = null;
            textBoxName.ReadOnly = false;
            textBoxName.RightToLeft = RightToLeft.No;
            textBoxName.SelectedText = "";
            textBoxName.SelectionLength = 0;
            textBoxName.SelectionStart = 0;
            textBoxName.ShortcutsEnabled = true;
            textBoxName.Size = new Size(220, 48);
            textBoxName.TabIndex = 1;
            textBoxName.TabStop = false;
            textBoxName.TextAlign = HorizontalAlignment.Left;
            textBoxName.TrailingIcon = null;
            textBoxName.UseSystemPasswordChar = false;
            // 
            // textBoxDNS1
            // 
            textBoxDNS1.AnimateReadOnly = false;
            textBoxDNS1.BackgroundImageLayout = ImageLayout.None;
            textBoxDNS1.CharacterCasing = CharacterCasing.Normal;
            textBoxDNS1.Depth = 0;
            textBoxDNS1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxDNS1.HideSelection = true;
            textBoxDNS1.LeadingIcon = null;
            textBoxDNS1.Location = new Point(17, 121);
            textBoxDNS1.MaxLength = 32767;
            textBoxDNS1.MouseState = MaterialSkin.MouseState.OUT;
            textBoxDNS1.Name = "textBoxDNS1";
            textBoxDNS1.PasswordChar = '\0';
            textBoxDNS1.PrefixSuffixText = null;
            textBoxDNS1.ReadOnly = false;
            textBoxDNS1.RightToLeft = RightToLeft.No;
            textBoxDNS1.SelectedText = "";
            textBoxDNS1.SelectionLength = 0;
            textBoxDNS1.SelectionStart = 0;
            textBoxDNS1.ShortcutsEnabled = true;
            textBoxDNS1.Size = new Size(220, 48);
            textBoxDNS1.TabIndex = 2;
            textBoxDNS1.TabStop = false;
            textBoxDNS1.TextAlign = HorizontalAlignment.Left;
            textBoxDNS1.TrailingIcon = null;
            textBoxDNS1.UseSystemPasswordChar = false;
            // 
            // textBoxDNS2
            // 
            textBoxDNS2.AnimateReadOnly = false;
            textBoxDNS2.BackgroundImageLayout = ImageLayout.None;
            textBoxDNS2.CharacterCasing = CharacterCasing.Normal;
            textBoxDNS2.Depth = 0;
            textBoxDNS2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxDNS2.HideSelection = true;
            textBoxDNS2.LeadingIcon = null;
            textBoxDNS2.Location = new Point(17, 208);
            textBoxDNS2.MaxLength = 32767;
            textBoxDNS2.MouseState = MaterialSkin.MouseState.OUT;
            textBoxDNS2.Name = "textBoxDNS2";
            textBoxDNS2.PasswordChar = '\0';
            textBoxDNS2.PrefixSuffixText = null;
            textBoxDNS2.ReadOnly = false;
            textBoxDNS2.RightToLeft = RightToLeft.No;
            textBoxDNS2.SelectedText = "";
            textBoxDNS2.SelectionLength = 0;
            textBoxDNS2.SelectionStart = 0;
            textBoxDNS2.ShortcutsEnabled = true;
            textBoxDNS2.Size = new Size(220, 48);
            textBoxDNS2.TabIndex = 3;
            textBoxDNS2.TabStop = false;
            textBoxDNS2.TextAlign = HorizontalAlignment.Left;
            textBoxDNS2.TrailingIcon = null;
            textBoxDNS2.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Controls.Add(textBoxName);
            materialCard1.Controls.Add(textBoxDNS2);
            materialCard1.Controls.Add(comboBoxDNS);
            materialCard1.Controls.Add(textBoxDNS1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 78);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(255, 340);
            materialCard1.TabIndex = 13;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(17, 186);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(112, 19);
            materialLabel3.TabIndex = 13;
            materialLabel3.Text = "Secondary DNS";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(20, 99);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(96, 19);
            materialLabel2.TabIndex = 13;
            materialLabel2.Text = "Primary DNS ";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(20, 13);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(79, 19);
            materialLabel1.TabIndex = 13;
            materialLabel1.Text = "DNS Name";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(buttonClearDNS);
            materialCard2.Controls.Add(buttonApplyDNS);
            materialCard2.Controls.Add(buttonEdit);
            materialCard2.Controls.Add(buttonDelete);
            materialCard2.Controls.Add(buttonAdd);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(17, 435);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(253, 129);
            materialCard2.TabIndex = 14;
            // 
            // buttonClearDNS
            // 
            buttonClearDNS.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonClearDNS.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonClearDNS.Depth = 0;
            buttonClearDNS.HighEmphasis = true;
            buttonClearDNS.Icon = null;
            buttonClearDNS.Location = new Point(136, 68);
            buttonClearDNS.Margin = new Padding(4, 6, 4, 6);
            buttonClearDNS.MouseState = MaterialSkin.MouseState.HOVER;
            buttonClearDNS.Name = "buttonClearDNS";
            buttonClearDNS.NoAccentTextColor = Color.Empty;
            buttonClearDNS.Size = new Size(99, 36);
            buttonClearDNS.TabIndex = 9;
            buttonClearDNS.Text = "Clear DNS";
            buttonClearDNS.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonClearDNS.UseAccentColor = false;
            buttonClearDNS.UseVisualStyleBackColor = true;
            buttonClearDNS.Click += buttonClearDNS_Click;
            // 
            // buttonApplyDNS
            // 
            buttonApplyDNS.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonApplyDNS.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonApplyDNS.Depth = 0;
            buttonApplyDNS.HighEmphasis = true;
            buttonApplyDNS.Icon = null;
            buttonApplyDNS.Location = new Point(18, 68);
            buttonApplyDNS.Margin = new Padding(4, 6, 4, 6);
            buttonApplyDNS.MouseState = MaterialSkin.MouseState.HOVER;
            buttonApplyDNS.Name = "buttonApplyDNS";
            buttonApplyDNS.NoAccentTextColor = Color.Empty;
            buttonApplyDNS.Size = new Size(99, 36);
            buttonApplyDNS.TabIndex = 8;
            buttonApplyDNS.Text = "Apply DNS";
            buttonApplyDNS.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonApplyDNS.UseAccentColor = false;
            buttonApplyDNS.UseVisualStyleBackColor = true;
            buttonApplyDNS.Click += buttonApplyDNS_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonEdit.Depth = 0;
            buttonEdit.HighEmphasis = true;
            buttonEdit.Icon = null;
            buttonEdit.Location = new Point(90, 20);
            buttonEdit.Margin = new Padding(4, 6, 4, 6);
            buttonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            buttonEdit.Name = "buttonEdit";
            buttonEdit.NoAccentTextColor = Color.Empty;
            buttonEdit.Size = new Size(64, 36);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Edit";
            buttonEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonEdit.UseAccentColor = false;
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonDelete.Depth = 0;
            buttonDelete.HighEmphasis = true;
            buttonDelete.Icon = null;
            buttonDelete.Location = new Point(162, 20);
            buttonDelete.Margin = new Padding(4, 6, 4, 6);
            buttonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            buttonDelete.Name = "buttonDelete";
            buttonDelete.NoAccentTextColor = Color.Empty;
            buttonDelete.Size = new Size(73, 36);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Delete";
            buttonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonDelete.UseAccentColor = false;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonAdd.Depth = 0;
            buttonAdd.HighEmphasis = true;
            buttonAdd.Icon = null;
            buttonAdd.Location = new Point(18, 20);
            buttonAdd.Margin = new Padding(4, 6, 4, 6);
            buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            buttonAdd.Name = "buttonAdd";
            buttonAdd.NoAccentTextColor = Color.Empty;
            buttonAdd.Size = new Size(64, 36);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Add";
            buttonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonAdd.UseAccentColor = false;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            materialLabel4.Location = new Point(19, 568);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(62, 14);
            materialLabel4.TabIndex = 15;
            materialLabel4.Text = "Version 0.1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 592);
            Controls.Add(materialLabel4);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            MaximizeBox = false;
            Name = "Form1";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DNS Manager";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox comboBoxDNS;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxName;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxDNS1;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxDNS2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton buttonClearDNS;
        private MaterialSkin.Controls.MaterialButton buttonApplyDNS;
        private MaterialSkin.Controls.MaterialButton buttonEdit;
        private MaterialSkin.Controls.MaterialButton buttonDelete;
        private MaterialSkin.Controls.MaterialButton buttonAdd;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}