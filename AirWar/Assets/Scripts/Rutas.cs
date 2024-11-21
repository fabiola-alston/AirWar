using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Rutas : MonoBehaviour
{
    public class Node
    {
        public string Name {get; set;}
        public bool IsHangar {get; set;}
        public float LandingCost => IsHangar ? 200 : 100;

    }

    public class Edge
    {
        public Node Destination {get; set;}
        public float Distance {get; set;}
        public bool IsInteroceanic {get; set;}
        public float Weight => Distance * (IsInteroceanic ? 2.0f : 1.0f); 


    }

    public class Graph
    {
        public Dictionary<Node, List<Edge>> AdjacencyList {get;} = new();

        public void AddNode(Node node)
        {
            if (!AdjacencyList.ContainsKey(node))
            {
                AdjacencyList[node] = new List<Edge>();
            }
        }

        public void AddEdge(Node from, Node to, float distance, bool isInteroceanic)
        {
            var edge = new Edge {Destination=to, Distance=distance, IsInteroceanic=isInteroceanic};
            AdjacencyList[from].Add(edge);

        }

        public void GenerateRandomGraph(int nodeCount, int edgeCount)
        {
            System.Random random = new System.Random();
            var nodes = new List<Node>();

            for (int i = 0; i < nodeCount; i++)
            {
                var node = new Node
                {
                    Name = $"Node: {i}",
                    IsHangar = random.Next(2) == 0

                };
                nodes.Add(node);
                AddNode(node);
            }

            for (int i = 0; i < edgeCount; i++)
            {
                var from = nodes[random.Next(nodes.Count)];
                var to = nodes[random.Next(nodes.Count)];

                if (from!=to)
                {
                    float distance = (float)(random.NextDouble() * 1000);
                    bool isInteroceanic = random.Next(2) == 0;

                }

            }
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
