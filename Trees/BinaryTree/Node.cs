namespace DataStructures.Trees.BinaryTree
{
    public class Node<T>
    {
        public bool IsLeaf => (Left == null && Right == null);
        public Node()
        {
 

        }
        public Node(T value) 
        {
            Value = value;
        }
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node<T> Parent { get; set; }
        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
