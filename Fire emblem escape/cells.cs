namespace project{
   public struct Cell{
      public  Cell(){
         david1=false;

         david2=false;

         david3=false;

         david4=false;

         visited=false;


         Finish=false;
 
         player=null;
         
      }
        public bool wall;
   public int row;
   public int col;

   public Lord ?player;
   public bool visited;
   public string sprite;

   public bool david1;
   public bool david2;

   public bool david3;

   public bool david4;

   public bool Finish;

   public int maxRow;

   public int maxCol;

   public bool guard;

   public int life;

   public int damage;

   public bool dragon;

   public bool fire;

   public bool tree;

   public bool solid;

   public bool death;
   }
}