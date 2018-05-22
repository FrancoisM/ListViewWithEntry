using Xamarin.Forms;
namespace ListViewWithEntry
{
	public class CustomTextCell : TextCell
    {
        public CustomTextCell()
        {
			this.SetBinding(TextProperty, nameof(TextModel.Text));
			this.SetBinding(DetailProperty, nameof(TextModel.DateAsText));
        }      
    }
}
