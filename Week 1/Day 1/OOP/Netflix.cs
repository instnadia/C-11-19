using System;
using System.Collections.Generic;

namespace Day_1
{
    public class Netflix
    {
        List<Movies> library;
        string owner;
        string email;
        int password;
        public Netflix(string email, int password, string ownerOfAccount)
        {
            library = new List<Movies>();
            this.email = email;
            this.password = password;
            this.owner = ownerOfAccount;
        }
        public string ShowOwner
        {
            get
            {
                return owner;
            }
            set
            {
                if (value.Length > 2)
                {
                    this.owner = value;
                }
            }
        }
        public void showLibrary()
        {
            int i = 1;
            foreach (var item in this.library){
                Console.WriteLine(i + ". " + item.name);
                i++;
            }
        }

        public void addToPlaylist(Movies movietoadd)
        {
            this.library.Add(movietoadd);
        }

    }
}