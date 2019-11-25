using System;
namespace Inheritance
{
    public class Cello : IPen
    {
        public string Color {get;set;}
        private bool isOpen = false;
        public bool Close(){
            isOpen = false;
            Console.WriteLine("Closed for writing");
            return isOpen;
        }


        public bool Open(){
            isOpen = true;
            Console.WriteLine("Open for writing");
            return isOpen;
        }

        public void Write(string text){
            if(isOpen){
                Console.WriteLine(text);
            }else{
                Console.WriteLine("CLOSED!!!!");
            }
        }
    }
}