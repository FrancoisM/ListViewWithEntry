using Xamarin.Forms;

namespace ListViewWithEntry
{
	public class MainPage : BaseContentPage<MainViewModel>
	{
		public MainPage()
		{
			var listView = new ListView
			{
				VerticalOptions = LayoutOptions.StartAndExpand,
				ItemTemplate = new DataTemplate(typeof(CustomTextCell))
			};
			listView.SetBinding(ListView.ItemsSourceProperty, nameof(ViewModel.TextCollection));

			var textEntry = new Entry
			{
				Placeholder = "Enter Text Then Press Done",
				ReturnType = ReturnType.Done,
				Margin = new Thickness(10, 5)
			};
			textEntry.SetBinding(Entry.ReturnCommandProperty, nameof(ViewModel.EntryReturnCommand));
			textEntry.SetBinding(Entry.ReturnCommandParameterProperty, new Binding(nameof(Entry.Text), source: textEntry));

			var absoluteLayout = new AbsoluteLayout();
			absoluteLayout.Children.Add(listView, new Rectangle(0, 0, 1, 1), AbsoluteLayoutFlags.All);
			absoluteLayout.Children.Add(textEntry, new Rectangle(0.5, 1, 1, AbsoluteLayout.AutoSize), 
			                            AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional);

			Content = new ScrollView { Content = absoluteLayout };
		}
	}
}
