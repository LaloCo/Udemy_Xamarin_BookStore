// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BookStore
{
	[Register ("BookTableViewCell")]
	partial class BookTableViewCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel bookAuthorLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel bookNameLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel bookPublisherLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel bookYearLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (bookAuthorLabel != null) {
				bookAuthorLabel.Dispose ();
				bookAuthorLabel = null;
			}
			if (bookNameLabel != null) {
				bookNameLabel.Dispose ();
				bookNameLabel = null;
			}
			if (bookPublisherLabel != null) {
				bookPublisherLabel.Dispose ();
				bookPublisherLabel = null;
			}
			if (bookYearLabel != null) {
				bookYearLabel.Dispose ();
				bookYearLabel = null;
			}
		}
	}
}
