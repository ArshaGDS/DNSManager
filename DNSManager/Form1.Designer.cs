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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBoxDNS = new MaterialSkin.Controls.MaterialComboBox();
            textBoxName = new MaterialSkin.Controls.MaterialTextBox2();
            textBoxDNS1 = new MaterialSkin.Controls.MaterialTextBox2();
            textBoxDNS2 = new MaterialSkin.Controls.MaterialTextBox2();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            buttonClearDNS = new MaterialSkin.Controls.MaterialButton();
            buttonApplyDNS = new MaterialSkin.Controls.MaterialButton();
            buttonEdit = new MaterialSkin.Controls.MaterialButton();
            buttonDelete = new MaterialSkin.Controls.MaterialButton();
            buttonAdd = new MaterialSkin.Controls.MaterialButton();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            githubLink = new MaterialSkin.Controls.MaterialLabel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
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
            resources.ApplyResources(comboBoxDNS, "comboBoxDNS");
            comboBoxDNS.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxDNS.FormattingEnabled = true;
            comboBoxDNS.MouseState = MaterialSkin.MouseState.OUT;
            comboBoxDNS.Name = "comboBoxDNS";
            comboBoxDNS.StartIndex = 0;
            comboBoxDNS.TextChanged += comboBoxDNS_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.AnimateReadOnly = false;
            resources.ApplyResources(textBoxName, "textBoxName");
            textBoxName.CharacterCasing = CharacterCasing.Normal;
            textBoxName.Depth = 0;
            textBoxName.HideSelection = true;
            textBoxName.LeadingIcon = null;
            textBoxName.MaxLength = 32767;
            textBoxName.MouseState = MaterialSkin.MouseState.OUT;
            textBoxName.Name = "textBoxName";
            textBoxName.PasswordChar = '\0';
            textBoxName.ReadOnly = false;
            textBoxName.SelectedText = "";
            textBoxName.SelectionLength = 0;
            textBoxName.SelectionStart = 0;
            textBoxName.ShortcutsEnabled = true;
            textBoxName.TabStop = false;
            textBoxName.TextAlign = HorizontalAlignment.Left;
            textBoxName.TrailingIcon = null;
            textBoxName.UseSystemPasswordChar = false;
            // 
            // textBoxDNS1
            // 
            textBoxDNS1.AnimateReadOnly = false;
            resources.ApplyResources(textBoxDNS1, "textBoxDNS1");
            textBoxDNS1.CharacterCasing = CharacterCasing.Normal;
            textBoxDNS1.Depth = 0;
            textBoxDNS1.HideSelection = true;
            textBoxDNS1.LeadingIcon = null;
            textBoxDNS1.MaxLength = 32767;
            textBoxDNS1.MouseState = MaterialSkin.MouseState.OUT;
            textBoxDNS1.Name = "textBoxDNS1";
            textBoxDNS1.PasswordChar = '\0';
            textBoxDNS1.ReadOnly = false;
            textBoxDNS1.SelectedText = "";
            textBoxDNS1.SelectionLength = 0;
            textBoxDNS1.SelectionStart = 0;
            textBoxDNS1.ShortcutsEnabled = true;
            textBoxDNS1.TabStop = false;
            textBoxDNS1.TextAlign = HorizontalAlignment.Left;
            textBoxDNS1.TrailingIcon = null;
            textBoxDNS1.UseSystemPasswordChar = false;
            // 
            // textBoxDNS2
            // 
            textBoxDNS2.AnimateReadOnly = false;
            resources.ApplyResources(textBoxDNS2, "textBoxDNS2");
            textBoxDNS2.CharacterCasing = CharacterCasing.Normal;
            textBoxDNS2.Depth = 0;
            textBoxDNS2.HideSelection = true;
            textBoxDNS2.LeadingIcon = null;
            textBoxDNS2.MaxLength = 32767;
            textBoxDNS2.MouseState = MaterialSkin.MouseState.OUT;
            textBoxDNS2.Name = "textBoxDNS2";
            textBoxDNS2.PasswordChar = '\0';
            textBoxDNS2.ReadOnly = false;
            textBoxDNS2.SelectedText = "";
            textBoxDNS2.SelectionLength = 0;
            textBoxDNS2.SelectionStart = 0;
            textBoxDNS2.ShortcutsEnabled = true;
            textBoxDNS2.TabStop = false;
            textBoxDNS2.TextAlign = HorizontalAlignment.Left;
            textBoxDNS2.TrailingIcon = null;
            textBoxDNS2.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialLabel5);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Controls.Add(textBoxName);
            materialCard1.Controls.Add(textBoxDNS2);
            materialCard1.Controls.Add(comboBoxDNS);
            materialCard1.Controls.Add(textBoxDNS1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            resources.ApplyResources(materialCard1, "materialCard1");
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            // 
            // materialLabel5
            // 
            resources.ApplyResources(materialLabel5, "materialLabel5");
            materialLabel5.Depth = 0;
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            // 
            // materialLabel3
            // 
            resources.ApplyResources(materialLabel3, "materialLabel3");
            materialLabel3.Depth = 0;
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            // 
            // materialLabel2
            // 
            resources.ApplyResources(materialLabel2, "materialLabel2");
            materialLabel2.Depth = 0;
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            // 
            // materialLabel1
            // 
            resources.ApplyResources(materialLabel1, "materialLabel1");
            materialLabel1.Depth = 0;
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(materialDivider3);
            materialCard2.Controls.Add(buttonClearDNS);
            materialCard2.Controls.Add(buttonApplyDNS);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            resources.ApplyResources(materialCard2, "materialCard2");
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            // 
            // materialDivider3
            // 
            materialDivider3.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider3.Depth = 0;
            resources.ApplyResources(materialDivider3, "materialDivider3");
            materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider3.Name = "materialDivider3";
            // 
            // buttonClearDNS
            // 
            resources.ApplyResources(buttonClearDNS, "buttonClearDNS");
            buttonClearDNS.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonClearDNS.Depth = 0;
            buttonClearDNS.HighEmphasis = true;
            buttonClearDNS.Icon = null;
            buttonClearDNS.MouseState = MaterialSkin.MouseState.HOVER;
            buttonClearDNS.Name = "buttonClearDNS";
            buttonClearDNS.NoAccentTextColor = Color.Empty;
            buttonClearDNS.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            buttonClearDNS.UseAccentColor = false;
            buttonClearDNS.UseVisualStyleBackColor = true;
            buttonClearDNS.Click += buttonClearDNS_Click;
            // 
            // buttonApplyDNS
            // 
            resources.ApplyResources(buttonApplyDNS, "buttonApplyDNS");
            buttonApplyDNS.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonApplyDNS.Depth = 0;
            buttonApplyDNS.HighEmphasis = true;
            buttonApplyDNS.Icon = null;
            buttonApplyDNS.MouseState = MaterialSkin.MouseState.HOVER;
            buttonApplyDNS.Name = "buttonApplyDNS";
            buttonApplyDNS.NoAccentTextColor = Color.Empty;
            buttonApplyDNS.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            buttonApplyDNS.UseAccentColor = false;
            buttonApplyDNS.UseVisualStyleBackColor = true;
            buttonApplyDNS.Click += buttonApplyDNS_Click;
            // 
            // buttonEdit
            // 
            resources.ApplyResources(buttonEdit, "buttonEdit");
            buttonEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonEdit.Depth = 0;
            buttonEdit.HighEmphasis = true;
            buttonEdit.Icon = null;
            buttonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            buttonEdit.Name = "buttonEdit";
            buttonEdit.NoAccentTextColor = Color.Empty;
            buttonEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            buttonEdit.UseAccentColor = false;
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            resources.ApplyResources(buttonDelete, "buttonDelete");
            buttonDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonDelete.Depth = 0;
            buttonDelete.HighEmphasis = true;
            buttonDelete.Icon = null;
            buttonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            buttonDelete.Name = "buttonDelete";
            buttonDelete.NoAccentTextColor = Color.Empty;
            buttonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            buttonDelete.UseAccentColor = false;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            resources.ApplyResources(buttonAdd, "buttonAdd");
            buttonAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonAdd.Depth = 0;
            buttonAdd.HighEmphasis = true;
            buttonAdd.Icon = null;
            buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            buttonAdd.Name = "buttonAdd";
            buttonAdd.NoAccentTextColor = Color.Empty;
            buttonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            buttonAdd.UseAccentColor = false;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // materialLabel4
            // 
            resources.ApplyResources(materialLabel4, "materialLabel4");
            materialLabel4.Depth = 0;
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            // 
            // githubLink
            // 
            resources.ApplyResources(githubLink, "githubLink");
            githubLink.Cursor = Cursors.Hand;
            githubLink.Depth = 0;
            githubLink.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            githubLink.MouseState = MaterialSkin.MouseState.HOVER;
            githubLink.Name = "githubLink";
            githubLink.Click += githubLink_Click;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(materialDivider2);
            materialCard3.Controls.Add(materialDivider1);
            materialCard3.Controls.Add(buttonEdit);
            materialCard3.Controls.Add(buttonAdd);
            materialCard3.Controls.Add(buttonDelete);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            resources.ApplyResources(materialCard3, "materialCard3");
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            // 
            // materialDivider2
            // 
            materialDivider2.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider2.Depth = 0;
            resources.ApplyResources(materialDivider2, "materialDivider2");
            materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            resources.ApplyResources(materialDivider1, "materialDivider1");
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard3);
            Controls.Add(githubLink);
            Controls.Add(materialLabel4);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            FormStyle = FormStyles.ActionBar_None;
            MaximizeBox = false;
            Name = "Form1";
            Sizable = false;
            Resize += Form1_Resize;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel githubLink;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
    }
}