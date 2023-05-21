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
            comboBoxDNS = new ComboBox();
            textBoxName = new TextBox();
            textBoxDNS1 = new TextBox();
            textBoxDNS2 = new TextBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonApplyDNS = new Button();
            buttonClearDNS = new Button();
            SuspendLayout();
            // 
            // comboBoxDNS
            // 
            comboBoxDNS.FormattingEnabled = true;
            comboBoxDNS.Location = new Point(42, 152);
            comboBoxDNS.Name = "comboBoxDNS";
            comboBoxDNS.Size = new Size(304, 23);
            comboBoxDNS.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(42, 25);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(304, 23);
            textBoxName.TabIndex = 1;
            textBoxName.Text = "Name";
            // 
            // textBoxDNS1
            // 
            textBoxDNS1.Location = new Point(42, 67);
            textBoxDNS1.Name = "textBoxDNS1";
            textBoxDNS1.Size = new Size(304, 23);
            textBoxDNS1.TabIndex = 2;
            textBoxDNS1.Text = "DNS1";
            // 
            // textBoxDNS2
            // 
            textBoxDNS2.Location = new Point(42, 107);
            textBoxDNS2.Name = "textBoxDNS2";
            textBoxDNS2.Size = new Size(304, 23);
            textBoxDNS2.TabIndex = 3;
            textBoxDNS2.Text = "DNS2";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(46, 202);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(46, 231);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(46, 260);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonApplyDNS
            // 
            buttonApplyDNS.Location = new Point(271, 202);
            buttonApplyDNS.Name = "buttonApplyDNS";
            buttonApplyDNS.Size = new Size(75, 23);
            buttonApplyDNS.TabIndex = 7;
            buttonApplyDNS.Text = "ApplyDNS";
            buttonApplyDNS.UseVisualStyleBackColor = true;
            buttonApplyDNS.Click += buttonApplyDNS_Click;
            // 
            // buttonClearDNS
            // 
            buttonClearDNS.Location = new Point(271, 231);
            buttonClearDNS.Name = "buttonClearDNS";
            buttonClearDNS.Size = new Size(75, 23);
            buttonClearDNS.TabIndex = 8;
            buttonClearDNS.Text = "ClearDNS";
            buttonClearDNS.UseVisualStyleBackColor = true;
            buttonClearDNS.Click += buttonClearDNS_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 295);
            Controls.Add(buttonClearDNS);
            Controls.Add(buttonApplyDNS);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxDNS2);
            Controls.Add(textBoxDNS1);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxDNS);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDNS;
        private TextBox textBoxName;
        private TextBox textBoxDNS1;
        private TextBox textBoxDNS2;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonApplyDNS;
        private Button buttonClearDNS;
    }
}