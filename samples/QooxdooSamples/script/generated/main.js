/*Generated by SharpKit 5 v5.00.7000*/
function Main()
{
    var button = new qx.ui.form.Button("click me");
    var root = qx.core.Init.getApplication().getRoot();
    root.add(button, {left: 50, top: 50});
    button.addListener("execute", function (a)
    {
        var wnd = new qx.ui.window.Window("my window", null);
        wnd.setShowClose(false);
        wnd.setShowMaximize(false);
        wnd.setShowMinimize(false);
        wnd.moveTo(200, 50);
        wnd.setWidth(250);
        wnd.setHeight(300);
        var layout = new qx.ui.layout.Grid(0, 0);
        layout.setRowFlex(1, 1);
        layout.setColumnFlex(0, 1);
        wnd.setLayout(layout);
        wnd.setContentPadding(0, 0, 0, 0);
        var toolbar = new qx.ui.toolbar.ToolBar();
        wnd.add(toolbar, {row: 0, column: 0, colSpan: 2});
        var reloadButton = new qx.ui.toolbar.Button("Reload");
        toolbar.add(reloadButton);
        reloadButton.setToolTipText("Reload the tweets.");
        reloadButton.addListener("execute", function (e)
        {
            wnd.debug("reload");
        }, wnd);
        var list = new qx.ui.form.List();
        wnd.add(list, {row: 1, column: 0, colSpan: 2});
        var postButton = new qx.ui.form.Button("Post");
        var textarea = new qx.ui.form.TextArea();
        wnd.add(textarea, {row: 2, column: 0});
        textarea.setPlaceholder("Enter your message here...");
        textarea.addListener("input", function (e)
        {
            var value = e.getData();
            postButton.setEnabled(value.length < 140 && value.length > 0);
        }, wnd);
        wnd.add(postButton, {row: 2, column: 1});
        postButton.setToolTipText("Post wnd message on identi.ca");
        postButton.addListener("execute", function (e)
        {
            wnd.debug("post: " + textarea.getValue());
        }, wnd);
        postButton.setWidth(60);
        postButton.setEnabled(false);
        wnd.open();
    });
};