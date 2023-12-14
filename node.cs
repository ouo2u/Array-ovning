namespace Array_ovning
{
    public class Node
    {
       private int value;
       private Node next;

       public Node Next{
           get{return next;}
           set{next=value;}
        }

        public int Value{
            get{return value;}
           set{this.value=value;}

        }

        public Node(int value){
            this.value=value;
        }

    }
}