using System;

namespace ByteDev.GuidGenerator.Ui
{
    public class GuidFormatterFactory
    {
        private readonly MainForm _form;

        public GuidFormatterFactory(MainForm form)
        {
            _form = form;
        }

        public GuidFormatter CreateFor(Guid guid)
        {
            return new GuidFormatter(guid)
            {
                IsUppercase = _form.uppercaseCheckBox.Checked,
                HasBracketWrapped = _form.bracketsCheckBox.Checked,
                HasHyphens = _form.hyphensCheckBox.Checked
            };
        }
    }
}