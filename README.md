A DefaultStyleKey will not be applied to a subclassed Microsoft control, in this case TreeView. It will be applied if you extend a lower class like Control or ContentControl.

However, if you add the style directly and explicitly in app.xaml, the style will be applied.
