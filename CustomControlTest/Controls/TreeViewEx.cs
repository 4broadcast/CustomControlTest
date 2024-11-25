using Microsoft.UI.Xaml.Controls;

namespace CustomControlTest.Controls;

public sealed class TreeViewEx : TreeView
{
    public TreeViewEx()
    {
        DefaultStyleKey = typeof(TreeViewEx);
    }

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
    }
}