using System.Text;

var name = "Gordon";
var message = "Hello, " + name + "!";
var message2 = string.Format("Hello, {0} {1}!", name, DateTime.Now);
var message3 = $"Hello, {name}!";

var messageBuilder = new StringBuilder();
messageBuilder.Append("Hello, ");
messageBuilder.Append(name);
messageBuilder.Append("!");

messageBuilder.AppendLine();


System.Console.WriteLine(message);






