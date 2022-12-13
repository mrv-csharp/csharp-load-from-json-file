// LOAD FROM JSON FILE DEMO by MR. V
// Demo of how to load data from a JSON file
#nullable disable

// Import JSON module
using System.Text.Json;

// Read data from file as a json string
string jsonString = File.ReadAllText("point-data.json");

// The Deserialize method will convert a json string to data
List<Point> points = JsonSerializer.Deserialize<List<Point>>(jsonString);

// Verify Contents of points
foreach (Point point in points)
{
    Console.WriteLine(point);
}

class Point
{
    // Properties
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public override string ToString()
    {
        return $"({this.X},{this.Y})";
    }
}