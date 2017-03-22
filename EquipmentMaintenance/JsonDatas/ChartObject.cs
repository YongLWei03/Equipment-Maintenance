using System.Collections.Generic;

namespace EquipmentMaintenance
{
    public class VerticalLine
    {
        public string Color { get; set; }
        public int Width { get; set; }
        public int Value { get; set; }
    }

    public class HorizontalLine
    {
        public string Color { get; set; }
        public int Width { get; set; }
        public int Value { get; set; }
        public string DashStyle { get; set; }
    }

    public class Graph
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public List<int> Data { get; set; }
    }

    public class Data
    {
        public List<Graph> Graph1 { get; set; }
        public List<Graph> Graph2 { get; set; }
        public List<Graph> Graph3 { get; set; }
    }

    public class RootObject
    {
        public List<string> xAsixCategories { get; set; }
        public List<VerticalLine> VerticalLines { get; set; }
        public List<HorizontalLine> HorizontalLines { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int Interval { get; set; }
        public Data Data { get; set; }
    }
}
