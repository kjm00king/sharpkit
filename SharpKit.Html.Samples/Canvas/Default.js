/*Generated by SharpKit 5 v4.28.5000*/
function btn_click(e)
{
    var canvas=document.getElementsByTagName("canvas")[0];
    var ctx=canvas.getContext("2d");
    ctx.beginPath();
    ctx.arc(75,75,10,0,Math.PI * 2,true);
    ctx.closePath();
    ctx.fill();
};
