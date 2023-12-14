using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Array_ovning
{
    public class LinkedList
    {
        Node head;

        public void Add(int value){
            Node newNode= new Node(value);
            if(head is null){
                head= newNode;
                return;
            }
            Node current= head;

            for (;current.Next !=null ;current=current.Next)
            {}

            current.Next= newNode;
        }
        public void print(){
             Node current= head;

             for (;current.Next !=null ;current=current.Next)
            {
                Console.WriteLine(current.Value);
            }

        }
    }
}