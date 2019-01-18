using System;

namespace ByteDev.GuidGenerator.Ui
{
	public class GuidFormatter
	{
		public bool IsUppercase { get;  set; }
		public bool HasBracketWrapped { get; set; }
		public bool HasHyphens { get; set; }

	    public bool IsGuidEmpty
	    {
            get { return Guid == Guid.Empty; }
	    }

	    public Guid Guid { get; set; }

	    public GuidFormatter(Guid guid)
		{
			Guid = guid;
		}

	    public string GetAsFormatted()
	    {
            var guid = Guid.ToString();

            guid = ModifyCase(guid);
            guid = ModifyBrackets(guid);
            guid = ModifyHyphens(guid);

            return guid;
        }

	    public override string ToString()
	    {
	        return GetAsFormatted();
	    }

	    private string ModifyHyphens(string guid)
		{
			if(!HasHyphens)
			{
				guid = guid.Replace("-", string.Empty);
			}
			return guid;
		}

		private string ModifyBrackets(string guid)
		{
			if(HasBracketWrapped)
			{
				guid = "{" + guid + "}";
			}
			return guid;
		}

		private string ModifyCase(string guid)
		{
		    return IsUppercase ? guid.ToUpper() : guid.ToLower();
		}
	}
}