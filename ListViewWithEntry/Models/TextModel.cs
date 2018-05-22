using System;

namespace ListViewWithEntry
{
    public class TextModel
    {
		public string DateAsText => Date.ToLocalTime().ToString();

		public string Text { get; set; }
		public DateTimeOffset Date { get; set; }
    }
}
