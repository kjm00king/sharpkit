/*Generated by SharpKit 5 v4.30.1000*/
$(OnReady);
function OnReady()
{
    $("#menu").menu(
    {
        select: function (e, ui)
        {
            var link = ui.item.children("a:first");
            if (link.attr("target") || e.metaKey || e.shiftKey || e.ctrlKey)
            {
                return;
            }
            window.location.href = link.attr("href");
        }
    });
};