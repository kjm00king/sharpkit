/*Generated by SharpKit 5 v5.00.0000*/
$(OnReady);
function OnReady()
{
    var tooltips = $("[title]").tooltip();
    $("<button>").text("Show help").button().click(function ()
    {
        tooltips.tooltip("open");
    }).insertAfter("form");
};