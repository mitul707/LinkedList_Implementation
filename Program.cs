using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation_LinkList
{
    public class List
    {
        int size;
        Node head;
        Node current;

        public List()
        {
            size = 0;
            head = null;
        }

        public void Add(object data)
        {
            size++;
            Node node = new Node();
            Node temp = head;
            Node prev = temp;
            node.data = data;

            if (head == null)
            {
                head = node;
            }
            else
            {
                /*if (temp.next == null)
                {
                    if (int.Parse(temp.data.ToString()) > int.Parse(data.ToString()))
                    {
                        node.next = temp;
                        head = node;
                    }
                    else
                    {
                        temp.next = node;
                    }
                }*/
                
                while (true)
                {
                    if (int.Parse(temp.data.ToString()) <= int.Parse(data.ToString()))
                    {
                        if (temp.next != null)
                        {
                            prev = temp;
                            temp = temp.next;
                        }
                        else
                        {
                            temp.next = node;
                            break;
                        }
                    }
                    else
                    {
                        if (head != temp)
                        {
                            prev.next = node;
                            node.next = temp;
                            //temp.next = node;
                            break;
                        }
                        else
                        {
                            node.next = temp;
                            head = node;
                            break;
                        }
                    }
                }
            }

            current = node;            
        }

        public Node Retrieve(int pos)
        {
            Node temp_node = head;
            Node ret_node = null;

            int count = 0;

            while (temp_node != null)
            {
                if (count == pos - 1)
                {
                    ret_node = temp_node;
                    break;
                }
                else
                {
                    count++;
                    temp_node = temp_node.next;
                }
            }

            return ret_node;
        }

        public bool Delete(int pos)
        {
            Node temp_node = head;
            Node last_node = null;

            int count = 0;

            while (pos > 1 && pos <= size - 1)
            {
                if (count == pos - 1)
                {
                    last_node.next = temp_node.next;
                    return true;
                }

                count++;
                last_node = temp_node;
                temp_node = temp_node.next;                
            }

            return false;
        }

        public void Reverse_Link_List()
        {
            Node curr_node = head;
            Node nxt_node = null;
            Node prev = null;


            while (curr_node.next != null)
            {
                nxt_node = curr_node.next;
                curr_node.next = prev;
                prev = curr_node;
                curr_node = nxt_node;
            }            
        }

        static void Main(string[] args)
        {
            List obj = new List();
            while (true)
            {
                Console.WriteLine("Insert a new node to the linked list??? Y or N");
                string c = Console.ReadLine();

                if (c == "N" || c == "n")
                {
                    break;
                }

                Console.WriteLine("Enter num to insert....");

                string num = Console.ReadLine();

                obj.Add(num);

            }

            List obj1 = new List();
            while (true)
            {
                Console.WriteLine("Insert a new node to the second linked list??? Y or N");
                string c = Console.ReadLine();

                if (c == "N" || c == "n")
                {
                    break;
                }

                Console.WriteLine("Enter num to insert....");
                string num = Console.ReadLine();
                obj1.Add(num);
            }

            Console.WriteLine("Sorted Linked List");
            Node node;
            node = obj.head;

            while (node.next != null)
            {
                Console.Write(node.data);
                Console.Write("->");
                node = node.next;
            }
            Console.WriteLine(node.data);

            Console.WriteLine("Sorted Linked List 2");

            Node node1 = obj1.head;

            while (node1.next != null)
            {
                Console.Write(node1.data);
                Console.Write("->");
                node1 = node1.next;
            }
            Console.Write(node1.data);

            Console.WriteLine("Merging Link Lists....");

            Node node_merge = obj.head;

            while (node_merge.next != null)
            {
                node_merge = node_merge.next;
            }

            Node node_merge2 = obj1.head;
            node_merge.next = node_merge2;

            node_merge = obj.head;
            while (node_merge.next != null)
            {
                Console.Write(node_merge.data);
                Console.Write("->");
                node_merge = node_merge.next;
            }
            Console.Write(node_merge.data);

            Console.Read();
        }
    }

    public class Node
    {
        public object data;
        public Node next;
    }
}
