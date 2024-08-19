
public class InfoWindowController : NSWindowController
{
    public InfoWindowController(string info)
    {
        var window = new NSWindow
        (
            new CoreGraphics.CGRect(0, 0, 400, 200),
            NSWindowStyle.Closable | NSWindowStyle.Titled | NSWindowStyle.Resizable,
            NSBackingStore.Buffered,
            false
        );

        window.Title = "Patient Information";
        ContentViewController = new InfoViewController(info);

        this.Window = window;
    }
}

public class InfoViewController : NSViewController
{
    private string info;

    public InfoViewController(string info)
    {
        this.info = info;
    }

    public override void LoadView()
    {
        View = new NSView(new CoreGraphics.CGRect(0, 0, 400, 200));

        var textView = new NSTextView(View.Frame)
        {
            Editable = false,
            Value = info,
            AutoresizingMask = NSViewResizingMask.WidthSizable | NSViewResizingMask.HeightSizable
        };

        View.AddSubview(textView);
    }
}