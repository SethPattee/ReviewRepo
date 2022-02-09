using System;

namespace Friends
{
    internal class Program

    {


        enum Friendstate
        {
            Acquaintance,
            GoodFriend,
            BestFriend,
            SomeoneFromClass,
            Degrading,
            Girlfriend
        };
        struct Friend
        {
            public Friendstate State;
            public string Name;
            public string From;
            public int NumOfSibs;
            public string Hobbies;
            public string Major;
            private int Age;

        };
        class SetttingFriendState
        {

            static void Main(string[] args)
            {
                const int MAX_FRIENDS = 150;
                Friend[] FriendArray = new Friend[MAX_FRIENDS];

                Console.WriteLine("Hello World!");

                Friend Jacob;
                Jacob = new Friend();
                Jacob.State = Friendstate.BestFriend;
                Jacob.From = "Payson Utah";

                Friend Shawn;
                Shawn = new Friend();
                Shawn.State = Friendstate.BestFriend;
                Shawn.From = "The Unitas";

                FriendArray[0] = Jacob;
                FriendArray[1] = Shawn;

                PrintInfo(FriendArray[0]);



            }

            public void PrintInfo(Friend a)
            {
                Console.WriteLine("Name: " + a.Name);
                Console.WriteLine("Friend State: " + a.State);
                Console.WriteLine("From: " + a.From);
                
            }


        }
    }
}