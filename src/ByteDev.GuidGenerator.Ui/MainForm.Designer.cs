namespace ByteDev.GuidGenerator.Ui
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.generateNewGuidButton = new System.Windows.Forms.Button();
            this.guidTextBox = new System.Windows.Forms.TextBox();
            this.bracketsCheckBox = new System.Windows.Forms.CheckBox();
            this.uppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.hyphensCheckBox = new System.Windows.Forms.CheckBox();
            this.guidLengthLabel = new System.Windows.Forms.Label();
            this.copyToClipboardButton = new System.Windows.Forms.Button();
            this.emptyGuidButton = new System.Windows.Forms.Button();
            this.combButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generateNewGuidButton
            // 
            this.generateNewGuidButton.Location = new System.Drawing.Point(213, 79);
            this.generateNewGuidButton.Name = "generateNewGuidButton";
            this.generateNewGuidButton.Size = new System.Drawing.Size(75, 23);
            this.generateNewGuidButton.TabIndex = 0;
            this.generateNewGuidButton.Text = "Generate";
            this.generateNewGuidButton.UseVisualStyleBackColor = true;
            this.generateNewGuidButton.Click += new System.EventHandler(this.generateNewGuidButton_Click);
            // 
            // guidTextBox
            // 
            this.guidTextBox.Location = new System.Drawing.Point(12, 12);
            this.guidTextBox.Name = "guidTextBox";
            this.guidTextBox.Size = new System.Drawing.Size(357, 20);
            this.guidTextBox.TabIndex = 1;
            this.guidTextBox.TextChanged += new System.EventHandler(this.guidTextBox_TextChanged);
            this.guidTextBox.DoubleClick += new System.EventHandler(this.guidTextBox_DoubleClick);
            // 
            // bracketsCheckBox
            // 
            this.bracketsCheckBox.AutoSize = true;
            this.bracketsCheckBox.Location = new System.Drawing.Point(12, 47);
            this.bracketsCheckBox.Name = "bracketsCheckBox";
            this.bracketsCheckBox.Size = new System.Drawing.Size(68, 17);
            this.bracketsCheckBox.TabIndex = 2;
            this.bracketsCheckBox.Text = "Brackets";
            this.bracketsCheckBox.UseVisualStyleBackColor = true;
            this.bracketsCheckBox.CheckedChanged += new System.EventHandler(this.bracketsCheckBox_CheckedChanged);
            // 
            // uppercaseCheckBox
            // 
            this.uppercaseCheckBox.AutoSize = true;
            this.uppercaseCheckBox.Location = new System.Drawing.Point(86, 47);
            this.uppercaseCheckBox.Name = "uppercaseCheckBox";
            this.uppercaseCheckBox.Size = new System.Drawing.Size(78, 17);
            this.uppercaseCheckBox.TabIndex = 3;
            this.uppercaseCheckBox.Text = "Uppercase";
            this.uppercaseCheckBox.UseVisualStyleBackColor = true;
            this.uppercaseCheckBox.CheckedChanged += new System.EventHandler(this.uppercaseCheckBox_CheckedChanged);
            // 
            // hyphensCheckBox
            // 
            this.hyphensCheckBox.AutoSize = true;
            this.hyphensCheckBox.Checked = true;
            this.hyphensCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hyphensCheckBox.Location = new System.Drawing.Point(170, 47);
            this.hyphensCheckBox.Name = "hyphensCheckBox";
            this.hyphensCheckBox.Size = new System.Drawing.Size(68, 17);
            this.hyphensCheckBox.TabIndex = 4;
            this.hyphensCheckBox.Text = "Hyphens";
            this.hyphensCheckBox.UseVisualStyleBackColor = true;
            this.hyphensCheckBox.CheckedChanged += new System.EventHandler(this.hyphensCheckBox_CheckedChanged);
            // 
            // guidLengthLabel
            // 
            this.guidLengthLabel.AutoSize = true;
            this.guidLengthLabel.Location = new System.Drawing.Point(332, 48);
            this.guidLengthLabel.Name = "guidLengthLabel";
            this.guidLengthLabel.Size = new System.Drawing.Size(37, 13);
            this.guidLengthLabel.TabIndex = 5;
            this.guidLengthLabel.Text = "Len: 0";
            this.guidLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.Location = new System.Drawing.Point(12, 79);
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(75, 23);
            this.copyToClipboardButton.TabIndex = 6;
            this.copyToClipboardButton.Text = "Copy";
            this.copyToClipboardButton.UseVisualStyleBackColor = true;
            this.copyToClipboardButton.Click += new System.EventHandler(this.copyToClipboardButton_Click);
            // 
            // emptyGuidButton
            // 
            this.emptyGuidButton.Location = new System.Drawing.Point(132, 79);
            this.emptyGuidButton.Name = "emptyGuidButton";
            this.emptyGuidButton.Size = new System.Drawing.Size(75, 23);
            this.emptyGuidButton.TabIndex = 7;
            this.emptyGuidButton.Text = "Empty";
            this.emptyGuidButton.UseVisualStyleBackColor = true;
            this.emptyGuidButton.Click += new System.EventHandler(this.emptyGuidButton_Click);
            // 
            // combButton
            // 
            this.combButton.Location = new System.Drawing.Point(294, 79);
            this.combButton.Name = "combButton";
            this.combButton.Size = new System.Drawing.Size(75, 23);
            this.combButton.TabIndex = 8;
            this.combButton.Text = "COMB";
            this.combButton.UseVisualStyleBackColor = true;
            this.combButton.Click += new System.EventHandler(this.combButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 114);
            this.Controls.Add(this.combButton);
            this.Controls.Add(this.emptyGuidButton);
            this.Controls.Add(this.copyToClipboardButton);
            this.Controls.Add(this.guidLengthLabel);
            this.Controls.Add(this.hyphensCheckBox);
            this.Controls.Add(this.uppercaseCheckBox);
            this.Controls.Add(this.bracketsCheckBox);
            this.Controls.Add(this.guidTextBox);
            this.Controls.Add(this.generateNewGuidButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateNewGuidButton;
        private System.Windows.Forms.TextBox guidTextBox;
        internal System.Windows.Forms.CheckBox bracketsCheckBox;
        internal System.Windows.Forms.CheckBox uppercaseCheckBox;
		internal System.Windows.Forms.CheckBox hyphensCheckBox;
		private System.Windows.Forms.Label guidLengthLabel;
		private System.Windows.Forms.Button copyToClipboardButton;
        private System.Windows.Forms.Button emptyGuidButton;
        private System.Windows.Forms.Button combButton;
    }
}

