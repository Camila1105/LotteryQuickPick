using lottery;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var quickpick = new QuickPick();
quickpick.GenerateTicket();
app.Run(); 


