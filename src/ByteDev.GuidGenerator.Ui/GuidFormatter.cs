using System;
using ByteDev.ValueTypes;

namespace ByteDev.GuidGenerator.Ui
{
	public class GuidFormatter
	{
		public bool IsUppercase { get; set; }

		public bool HasBracketWrapped { get; set; }

		public bool HasHyphens { get; set; }

        public Guid Guid { get; }

        public GuidFormatter(Guid guid)
		{
			Guid = guid;
		}

	    public string GetAsFormatted()
        {
            GuidStringFlags flags = 0;

            if (IsUppercase)
                flags |= GuidStringFlags.UpperCase;

            if (HasBracketWrapped)
                flags |= GuidStringFlags.Brackets;

            if (!HasHyphens)
                flags |= GuidStringFlags.NoDelimiters;

            return flags == 0 ? Guid.ToString() : Guid.ToString(flags);
        }
    }
}