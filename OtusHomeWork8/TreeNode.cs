

using System.Xml.Linq;

namespace OtusHomeWork8
{
    public class Tree
    {
        private Nodes _root;
        
        public void Add(Nodes next)
            {
                
                Nodes previous = null;

                if (_root == null)
                {
                    _root = new Nodes(next.Key, next.Value);
                }
                Nodes current = _root;
                while (current != null)
                {
                    previous = current;

                    if (next.Value > current.Value)
                        current = current.Right;
                    else current = current.Left;

                }
                if (previous.Value > next.Value)
                    previous.Left = next;
                else
                    previous.Right = next;
                next.Parent = previous;
            }

        public string Find(int key)
            {
                Nodes current = _root;

                while (current != null)
                {
                    if (current.Value == key)
                        return current.Key;
                    if (current.Value > key)
                        current = current.Left;
                    if (current.Value < key)
                        current = current.Right;
                }
            return "Nакой сотрудник не найден";
            }

        public void PrintTree()
        {
            _print(_root);
        }

        private void _print(Nodes node)
        {
            if (node.Left != null) 
                _print(node.Left);

            Console.WriteLine(node.Key + " " + node.Value);
            
            if (node.Right != null)
                _print(node.Right);
            
        }
    }
}
