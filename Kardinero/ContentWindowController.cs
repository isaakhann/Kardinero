using AppKit;

public class ContentWindowController : NSWindowController
{
    public ContentWindowController(string content)
    {
        var window = new NSWindow
        (
            new CoreGraphics.CGRect(0, 0, 600, 400),
            NSWindowStyle.Closable | NSWindowStyle.Titled | NSWindowStyle.Resizable,
            NSBackingStore.Buffered,
            false
        );

        window.Title = "File Content";
        ContentViewController = new ContentViewController(content);

        this.Window = window;
    }
}

public class ContentViewController : NSViewController
{
    private string content;

    public ContentViewController(string content)
    {
        this.content = content;
    }

    public override void LoadView()
    {
        View = new NSView(new CoreGraphics.CGRect(0, 0, 600, 400));

        var textView = new NSTextView(View.Frame)
        {
            Editable = false,
            Value = content,
            AutoresizingMask = NSViewResizingMask.WidthSizable | NSViewResizingMask.HeightSizable
        };

        View.AddSubview(textView);
    }
}
