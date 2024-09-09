// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Kardinero
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton addFileButton { get; set; }

		[Outlet]
		AppKit.NSButton findInfo { get; set; }

		[Outlet]
		AppKit.NSButtonCell getCSV { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (addFileButton != null) {
				addFileButton.Dispose ();
				addFileButton = null;
			}

			if (findInfo != null) {
				findInfo.Dispose ();
				findInfo = null;
			}

			if (getCSV != null) {
				getCSV.Dispose ();
				getCSV = null;
			}
		}
	}
}
