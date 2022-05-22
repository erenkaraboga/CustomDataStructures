namespace DataStructures.Trees.BinaryTree
{
    public class Node<T>
    {
        public Node()
        {
            Left = new Node<T>();
            Right = new Node<T>();  

        }
        public Node(T value) : this()
        {
            Value = value;
        }
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
