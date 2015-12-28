using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace BookStore.Android
{
	[Activity (Label = "BookStore.Android", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : ListActivity
	{
		List<Book> bookList;
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			Xamarin.Insights.Initialize (XamarinInsights.ApiKey, this);
			base.OnCreate (savedInstanceState);

			this.ListView.ItemClick += ListView_ItemClick;

			bookList = new List<Book> ();

			bookList.Add (new Book () {
				Author = "J.K. Rowling",
				Name = "Harry Potter and the Sorcerer's Stone",
				Publisher = "Bloomsbury",
				Year = 1997,
				ImageId = Android.Resource.Drawable.HP1
			});
			bookList.Add (new Book () {
				Author = "J.K. Rowling",
				Name = "Harry Potter and the Chamber of Secrets",
				Publisher = "Bloomsbury",
				Year = 1998,
				ImageId = Android.Resource.Drawable.HP2
			});
			bookList.Add (new Book () {
				Author = "J.K. Rowling",
				Name = "Harry Potter and the Prisoner of Azkaban",
				Publisher = "Bloomsbury",
				Year = 1999,
				ImageId = Android.Resource.Drawable.HP3
			});

			var listAdapter = new BooksAdapter (this);
			listAdapter.books = bookList;
			ListAdapter = listAdapter;
		}

		void ListView_ItemClick (object sender, AdapterView.ItemClickEventArgs e)
		{
			if (e != null)
			{
				var selectedBook = bookList [e.Position];
				var intent = new global::Android.Content.Intent(this, typeof(DetailsActivity));

				Bundle bundle = new Bundle ();
				bundle.PutString ("selected_book", selectedBook.Name);
				bundle.PutInt ("selected_image_id", selectedBook.ImageId);

				intent.PutExtras (bundle);

				StartActivity(intent);
			}
			else
			{
				return;
			}
		}
	}

	public class Book
	{
		public long Id;
		public string Name;
		public string Author;
		public string Publisher;
		public int Year;
		public int ImageId;

		public override string ToString ()
		{
			return string.Format ("{0} - {1} - {2} - {3}", this.Name, this.Author, this.Publisher, this.Year);
		}
	}
}
