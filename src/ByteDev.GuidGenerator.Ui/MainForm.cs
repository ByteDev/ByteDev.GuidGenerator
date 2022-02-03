using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ByteDev.ValueTypes;

namespace ByteDev.GuidGenerator.Ui
{
    public partial class MainForm : Form
    {
        private const string AppName = "Guid Generator";

        private GuidFormatter _guidFormatter;
        private GuidFormatterFactory _guidFormatterFactory;
        private Color _origTextBackColor;
        private Color _origTextForeColor;
        
        public MainForm()
        {
            InitializeComponent();
        }

		private void MainForm_Load(object sender, EventArgs e)
		{
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version; 
            
            Text = $@"{AppName} {version.Major}.{version.Minor}.{version.Revision}";

            _origTextBackColor = guidTextBox.BackColor;
            _origTextForeColor = guidTextBox.ForeColor;

            _guidFormatterFactory = new GuidFormatterFactory(this);

            _guidFormatter = _guidFormatterFactory.CreateFor(Guid.NewGuid());
            UpdateGuidText();
        }

        private void generateNewGuidButton_Click(object sender, EventArgs e)
        {
            _guidFormatter = _guidFormatterFactory.CreateFor(Guid.NewGuid());
            UpdateGuidText();
        }

        private void emptyGuidButton_Click(object sender, EventArgs e)
        {
            _guidFormatter = _guidFormatterFactory.CreateFor(Guid.Empty);
            UpdateGuidText();
        }

        private void combButton_Click(object sender, EventArgs e)
        {
            _guidFormatter = _guidFormatterFactory.CreateFor(_guidFormatter.Guid.Comb());
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
            var input = guidTextBox.Text
                .Replace("{", string.Empty)
                .Replace("}", string.Empty);

            if (!Guid.TryParse(input, out var guid))
            {
                guidTextBox.BackColor = Color.Red;
                guidTextBox.ForeColor = Color.White;

                UpdateTextLengthLabel();
            }
            else
            {
                guidTextBox.BackColor = _origTextBackColor;
                guidTextBox.ForeColor = _origTextForeColor;

                _guidFormatter = _guidFormatterFactory.CreateFor(guid);

                guidTextBox.Text = _guidFormatter.GetAsFormatted();
            }
        }

        private void guidTextBox_DoubleClick(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void UpdateGuidText()
        {
            if (_guidFormatter.Guid.IsEmpty())
            {
                uppercaseCheckBox.Checked = false;
                uppercaseCheckBox.Enabled = false;
                combButton.Enabled = false;
            }
            else
            {
                uppercaseCheckBox.Enabled = true;
                combButton.Enabled = true;
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
