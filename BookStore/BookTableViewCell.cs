using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BookStore
{
	partial class BookTableViewCell : UITableViewCell
	{
		private Book bookData;
		public Book BookData
		{
			get { return bookData; }
			set 
			{
				bookData = value;

				bookAuthorLabel.Text = bookData.Author;
				bookNameLabel.Text = bookData.Name;
				bookYearLabel.Text = bookData.Year.ToString ();
				bookPublisherLabel.Text = bookData.Publisher;
			}
		}

		public BookTableViewCell (IntPtr handle) : base (handle)
		{
		}
	}
}
