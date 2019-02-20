/*
 * @lc app=leetcode id=133 lang=csharp
 *
 * [133] Clone Graph
 *
 * https://leetcode.com/problems/clone-graph/description/
 *
 * algorithms
 * Medium (25.12%)
 * Total Accepted:    197.7K
 * Total Submissions: 787K
 * Testcase Example:  '{}'
 *
 * Given the head of a graph, return a deep copy (clone) of the graph. Each
 * node in the graph contains a label (int) and a list
 * (List[UndirectedGraphNode]) of its neighbors. There is an edge between the
 * given node and each of the nodes in its neighbors.
 * 
 * 
 * OJ's undirected graph serialization (so you can understand error output):
 * 
 * Nodes are labeled uniquely.
 * We use # as a separator for each node, and , as a separator for node label
 * and each neighbor of the node.
 * 
 * 
 * 
 * As an example, consider the serialized graph {0,1,2#1,2#2,2}.
 * 
 * The graph has a total of three nodes, and therefore contains three parts as
 * separated by #.
 * 
 * 
 * First node is labeled as 0. Connect node 0 to both nodes 1 and 2.
 * Second node is labeled as 1. Connect node 1 to node 2.
 * Third node is labeled as 2. Connect node 2 to node 2 (itself), thus forming
 * a self-cycle.
 * 
 * 
 * 
 * 
 * Visually, the graph looks like the following:
 * 
 * 
 * ⁠      1
 * ⁠     / \
 * ⁠    /   \
 * ⁠   0 --- 2
 * ⁠        / \
 * ⁠        \_/
 * 
 * 
 * Note: The information about the tree serialization is only meant so that you
 * can understand error output if you get a wrong answer. You don't need to
 * understand the serialization to solve the problem.
 * 
 * 
 */
/**
 * Definition for undirected graph.
 * public class UndirectedGraphNode {
 *     public int label;
 *     public IList<UndirectedGraphNode> neighbors;
 *     public UndirectedGraphNode(int x) { label = x; neighbors = new List<UndirectedGraphNode>(); }
 * };
 */
public class Solution {
    public UndirectedGraphNode CloneGraph(UndirectedGraphNode node) {
        if(node == null)
        {
            return null;
        }

        // 初始条件
        // 循环访问
        //  出队
        //  访问当前节点
        //  入队邻居节点
    }
}
