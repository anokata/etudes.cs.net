using System.Collections.Generic;
using System.Collections;

public class Node
{
    public string name { set; get; }
    public Node(string n)
    {
        name = n;
    }
}

public class Edge
{
    public string start { set; get; }
    public string end { set; get; }

    public Edge(string s, string e)
    {
        start = s;
        end = e; 
    }
}

public class Attr
{
    public string name { set; get; }
    public string value { set; get; }

    public Attr(string n, string v)
    {
        name = n;
        value = v;
    }
}

public class Graph : IEnumerable<Node>
{
    public List<Node> Nodes {
        set; get;
    }
    public List<Edge> Edges {
        set; get;
    }
    public List<Attr> Attrs {
        set; get;
    }
    public Graph()
    {
    }
    public Graph(Node n)
    {
        Nodes.Add(n);
    }

    public void Add(Node n)
    {
        Nodes.Add(n);
    }
    public void Add(Attr a)
    {
        Attrs.Add(a);
    }
    public void Add(Edge e)
    {
        Edges.Add(e);
    }
    public void Add(string a, string b)
    {
        Attrs.Add(new Attr(a, b));
    }

    IEnumerator<Node> IEnumerable<Node>.GetEnumerator()
    {
        return GetEnumerator();
    }
    public IEnumerator<Node> GetEnumerator() { 
        return Nodes.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}