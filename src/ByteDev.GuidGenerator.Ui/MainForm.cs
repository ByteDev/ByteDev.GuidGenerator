using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ByteDev.GuidGenerator.Ui
{
    public partial class MainForm : Form
    {
        private const string AppName = "Guid Generator";

        private GuidFormatter _guidFormatter;
        private Color _origTextBackColor;
        private Color _origTextForeColor;

        public MainForm()
        {
            InitializeComponent();
        }

		private void MainForm_Load(object sender, EventArgs e)
		{
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version; 
            
            Text = $"{AppName} {version.Major}.{version.Minor}";

            _origTextBackColor = guidTextBox.BackColor;
            _origTextForeColor = guidTextBox.ForeColor;

            CreateGuidFormatter(Guid.NewGuid());
            UpdateGuidText();
        }

        private void generateNewGuidButton_Click(object sender, EventArgs e)
        {
            CreateGuidFormatter(Guid.NewGuid());
            UpdateGuidText();
        }

        private void emptyGuidButton_Click(object sender, EventArgs e)
        {
            CreateGuidFormatter(Guid.Empty);
            UpdateGuidText();
        }

        private void combButton_Click(object sender, EventArgs e)
        {
            CreateCombGuidFormatter();
            UpdateGuidText();
        }

        private void copyToClipboardButton_Click(object sender, EventArgs e)
		{
			CopyGuidToClipBoard();
		}

        private void bracketsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			_guidFormatter.HasBracketWrapped = ((CheckBox)sender).Checked;
			UpdateGuidText();
		}

        private void uppercaseCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			_guidFormatter.IsUppercase = ((CheckBox)sender).Checked;
			UpdateGuidText();
		}

        private void hyphensCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			_guidFormatter.HasHyphens = ((CheckBox)sender).Checked;
			UpdateGuidText();
		}

        private void guidTextBox_TextChanged(object sender, EventArgs e)
        {
            Guid guid;

            var input = guidTextBox.Text
                .Replace("{", string.Empty)
                .Replace("}", string.Empty);

            if (!Guid.TryParse(input, out guid))
            {
                guidTextBox.BackColor = Color.Red;
                guidTextBox.ForeColor = Color.White;

                UpdateTextLengthLabel();
            }
            else
            {
                guidTextBox.BackColor = _origTextBackColor;
                guidTextBox.ForeColor = _origTextForeColor;

                CreateGuidFormatter(guid);

                guidTextBox.Text = _guidFormatter.GetAsFormatted();
            }
        }

        private void guidTextBox_DoubleClick(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void CreateGuidFormatter(Guid guid)
        {
            _guidFormatter = new GuidFormatter(guid)
            {
                IsUppercase = uppercaseCheckBox.Checked,
                HasBracketWrapped = bracketsCheckBox.Checked,
                HasHyphens = hyphensCheckBox.Checked
            };
        }

        private void CreateCombGuidFormatter()
        {
            if (_guidFormatter == null)
            {
                CreateGuidFormatter(Guid.NewGuid().Comb());
            }
            else
            {
                if (!_guidFormatter.Guid.IsEmpty())
                {
                    var newGuid = _guidFormatter.Guid.Comb();
                    CreateGuidFormatter(newGuid);
                }
            }
        }

        private void UpdateGuidText()
        {
            if (_guidFormatter.Guid.IsEmpty())
            {
                uppercaseCheckBox.Checked = false;
                uppercaseCheckBox.Enabled = false;
            }
            else
            {
                uppercaseCheckBox.Enabled = true;
            }
            
            guidTextBox.Text = _guidFormatter.GetAsFormatted();

            UpdateTextLengthLabel();
        }

        private void UpdateTextLengthLabel()
        {
            guidLengthLabel.Text = @"Len: " + guidTextBox.Text.Length.ToString(CultureInfo.InvariantCulture);
        }

        private void CopyGuidToClipBoard()
		{
			Clipboard.SetDataObject(guidTextBox.Text, true);
		}
    }
}
