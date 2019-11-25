namespace Inheritance
{
    public class Squere : Shape
    {
        int side;
        public Squere(int n){
            side = n;
        }
        public override int GetArea(){
            return side*side;
        }
    }
}