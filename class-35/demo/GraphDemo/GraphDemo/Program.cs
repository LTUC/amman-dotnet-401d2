namespace GraphDemo
{
	public class Program
	{
		static void Main(string[] args)
		{
			Graph<string> graph = new Graph<string>();

			Vertex<string> a = graph.AddVertex("Amman");
			Vertex<string> b = graph.AddVertex("Irbid");
			Vertex<string> c = graph.AddVertex("Salt");

			// Complete graph
			graph.AddUnDirectEdge(a, b);
			graph.AddUnDirectEdge(b, c);
			graph.AddUnDirectEdge(c, a);

			graph.Print();
		}
	}
}