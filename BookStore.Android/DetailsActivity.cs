
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BookStore.Android
{
	[Activity (Label = "DetailsActivity")]			
	public class DetailsActivity : Activity
	{
		private TextView bookNameTextView;
		private ImageView bookCoverImageView;

		Book selectedBook;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			this.SetContentView (Android.Resource.Layout.Details);

			bookNameTextView = FindViewById (Android.Resource.Id.bookNameTextView2) as TextView;
			bookCoverImageView = FindViewById(Android.Resource.Id.bookCoverImageView) as ImageView;

			selectedBook = new Book ();
			selectedBook.Name = Intent.Extras.GetString ("selected_book");
			selectedBook.ImageId = Intent.Extras.GetInt ("selected_image_id");

			bookNameTextView.Text = selectedBook.Name;
			bookCoverImageView.SetImageResource (selectedBook.ImageId);
		}
	}
}

