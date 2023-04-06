using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class LinkedList
    {
        internal class Node
        {
            internal string data;
            internal Node next;
            
            public Node(string data)
            {
                this.data = data;
                this.next = null;
            }
        }

        private Node newNodeHead;

        public LinkedList()
        {
            this.newNodeHead = null;// first node is always null when iniciated
        }

        public void Insert_In_Front(string data)
        {
            Node newNode = new Node(data); //create new Npde
            newNode.next = newNodeHead;//new node's next points to the head
            newNodeHead = newNode;//we swap the old and new Node, since we add to the front
        }

        public void Inser_At_End(string data)
        {
            Node newNode = new Node(data);
            if (newNodeHead.Equals(null)){
                newNodeHead = newNode;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.next = newNode;
        }

        public Node GetLastNode()
        {
            Node temp = newNodeHead;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void Insert_After_Certain_Node(Node prev_Node, string new_data)
        {
            if (prev_Node.Equals(null))
            {
                MessageBox.Show("The given Node cannot be null");
                return;
            }
            Node newNode = new Node(new_data);
            newNode.next = prev_Node.next;
            prev_Node.next = newNode;
        }

        public void Delete_Specific_Node(string key)
        {
            Node temp = newNodeHead;
            Node previous = null;
            if(!temp.Equals(null) && !temp.data.Equals(key))
            {
                newNodeHead = temp.next;
                return;
            }
            while(!temp.Equals(null) && !temp.data.Equals(key))
            {
                previous = temp;
                temp = temp.next;
            }
            if (temp.Equals(null))
            {
                return;
            }
            previous.next = temp.next;
        }

        public void Reverse()
        {
            Node prev = null;
            Node current = newNodeHead;//essential end point
            Node temp = null;

            while (!current.Equals(null))//as long as its not null check
            {
                //going Node by node and swap the positions
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            newNodeHead = prev;
        }


        

    }
}
