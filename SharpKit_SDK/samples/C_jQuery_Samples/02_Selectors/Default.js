/*Generated by SharpKit 5 v4.28.9000*/
function jQuerySelectorsSample_Load()
{
    $(".MyExpander > #Header").mousedown(function(e)
    {
        $(this).siblings(".MyExpander > #Content").toggle();
    });
};
