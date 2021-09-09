using System;
using System.Collections.Generic;
using System.Linq;
namespace FriendCircleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Friend a = new Friend("A");
            Friend b = new Friend("B");
            Friend c = new Friend("C");

            a.AddFriendship(b);
            b.AddFriendship(c);

            Console.WriteLine(a.CanBeConnected(c));
            Console.ReadLine();
        }
    }
    public class Friend
    {
        public string Email { get; private set; }

        public ICollection<Friend> Friends { get; private set; }

        public Friend(string email)
        {
            this.Email = email;
            this.Friends = new List<Friend>();
        }

        public void AddFriendship(Friend friend)
        {
            this.Friends.Add(friend);
            friend.Friends.Add(this);
        }

        public bool CanBeConnected(Friend friend)
        {
            try
            {
                return (this.Friends.Where(f => f.Friends.Contains(friend)).Count() > 0);
              
            }
            catch
            {
                return false;
            }
            

          
        }

    
    }


}
