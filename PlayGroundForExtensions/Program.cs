using static System.Console;
using Spectre.Console;
WriteLine();

// AnsiConsole.Markup("[underline red]Hello[/] World!");
// WriteLine();
// AnsiConsole.Write(new Columns(
//             new Text("Item 1"),
//             new Text("Item 2")
//         ));
// var columns = new List<Text>(){
//     new Text("Item 1", new Style(Color.Red, Color.Black)),
//     new Text("Item 2", new Style(Color.Green, Color.Black)),
//     new Text("Item 3", new Style(Color.Blue, Color.Black))
// };

// // Renders each item with own style
// AnsiConsole.Write(new Columns(columns));

var panel = new Panel("Hello World");
// Sets the padding
panel.Padding = new Padding(2, 2, 2, 2);
panel.Header = new PanelHeader("Some text");
panel.Border = BoxBorder.Ascii;
panel.Border = BoxBorder.Square;
panel.Border = BoxBorder.Rounded;
panel.Border = BoxBorder.Heavy;
panel.Border = BoxBorder.Double;
panel.Border = BoxBorder.None;

panel.Expand = true;

WriteLine();
