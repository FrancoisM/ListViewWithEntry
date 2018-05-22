using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

using Xamarin.Forms;

namespace ListViewWithEntry
{
	public class MainViewModel : BaseViewModel
	{
        #region Fields
        ICommand _entryReturnCommand;
		ObservableCollection<TextModel> _textCollection = new ObservableCollection<TextModel>();
		#endregion

		#region Properties
		public ICommand EntryReturnCommand => _entryReturnCommand ??
			(_entryReturnCommand = new Command<string>(ExecuteEntryReturnCommand));

		public ObservableCollection<TextModel> TextCollection
		{
			get => _textCollection;
			set => SetProperty(ref _textCollection, value);
		}
		#endregion

		#region Methods
		void ExecuteEntryReturnCommand(string text)
		{
			var textModel = new TextModel
			{
				Text = text,
				Date = DateTimeOffset.UtcNow
			};

			TextCollection.Add(textModel);
		}
		#endregion
	}
}
