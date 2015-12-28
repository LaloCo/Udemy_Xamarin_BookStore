using System;
using System.Collections.Generic;
using Android.App;
using Android.Widget;

namespace BookStore.Android
{
	public class BooksAdapter : BaseAdapter
	{
		public List<Book> books;
		Activity activity;

		public BooksAdapter (Activity activity)
		{
			books = new List<Book> ();
			this.activity = activity;
		}

		public override int Count {
			get {
				return books.Count;
			}
		}

		public override global::Android.Views.View GetView (int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent)
		{
			var view = convertView ?? activity.LayoutInflater.Inflate (Android.Resource.Layout.BookCell, parent, false);

			var nameLabel = view.FindViewById<TextView> (Android.Resource.Id.bookNameTextView);
			var authorLabel = view.FindViewById<TextView> (Android.Resource.Id.bookAuthorTextView);
			var publisherLabel = view.FindViewById<TextView> (Android.Resource.Id.bookPublisherTextView);
			var yearLabel = view.FindViewById<TextView> (Android.Resource.Id.bookYearTextView);

			var data = books [position];

			nameLabel.Text = data.Name;
			authorLabel.Text = data.Author;
			publisherLabel.Text = data.Publisher;
			yearLabel.Text = data.Year.ToString ();

			return view;
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return null;
		}

		public override long GetItemId (int position)
		{
			return books [position].Id;
		}
	}
}

