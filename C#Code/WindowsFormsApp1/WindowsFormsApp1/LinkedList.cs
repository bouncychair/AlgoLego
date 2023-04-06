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
            if (newNodeHead.Equals(null))//checking for the possibility of head is null
            {
                newNodeHead = newNode;//setting newNode as head
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.next = newNode;//setting the last node
        }

        public Node GetLastNode()
        {
            Node temp = newNodeHead;
            while(temp.next != null)//checking for the next node as long as there are one
            {
                temp = temp.next;//settind the last node
            }
            return temp;
        }

        public void Insert_After_Certain_Node(Node prev_Node, string new_data)
        {
            if (prev_Node.Equals(null))//if inserted node is null, throw error message
            {
                MessageBox.Show("The given Node cannot be null");
                return;
            }
            Node newNode = new Node(new_data);//creating new node for insertion
            newNode.next = prev_Node.next;//setting new node to the inserted one
            prev_Node.next = newNode;//setting the inserted node as the "new" one.
        }

        public void Delete_Specific_Node(string key)
        {
            Node temp = newNodeHead;
            Node previous = null;
            if(!temp.Equals(null) && !temp.data.Equals(key))//if node that gets deleted is the head
            {
                newNodeHead = temp.next;//swap positions with the next
                return;
            }
            while(!temp.Equals(null) && !temp.data.Equals(key))//if wanted node is in the middle
            {
                //we connect the previous and next node
                previous = temp;
                temp = temp.next;
            }
            if (temp.Equals(null))//if list is empty stop and return
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
            newNodeHead = prev;//set last node to head 
        }


        

    }
}
