/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    $("#rerun").button().click(function(e)
    {
        alert("Running the last action");
    }).next().button(
    {
        text:false,
        icons:{primary:"ui-icon-triangle-1-s"}
    }).click(function(e)
    {
        alert("Could display a menu to select an action");
    }).parent().buttonset();
};