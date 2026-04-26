using System.ComponentModel;
using System.Dynamic;

namespace FinalProject;

class Program
{
    static void Main(string[] args)
    {
        int attempts = 100;
        
        
        do{
        
        var room_info = new Dictionary <int, int>();
        room_info.Add(101,2);
        room_info.Add(102,2);
        room_info.Add(103,2);
        room_info.Add(104,2);
        room_info.Add(105,2);
        room_info.Add(108,3);
        room_info.Add(110,4);

        var res_rooms = new Dictionary <int, int>();
        room_info.Add(106,3);
        room_info.Add(107,3);
        room_info.Add(109,3);

        //Display Student's Name
        Console.WriteLine("---CIDM2315 Final Project: Cristian Rivas---");
        Console.WriteLine("---Welcome to Buff Hotel---");
        
        //User Login
        Console.WriteLine("-->Please input username: ");
        string username = Console.ReadLine();
        Console.WriteLine("-->Please input password: ");
        string password = Console.ReadLine();

        if (username == "alice")
        {
            if (password == "alice123")
            {
                Console.WriteLine("-->Login Successfully");
            }
            else
            {
                Console.WriteLine("Wrong Username/Password");
            }
            
        }
        
        else
        {
            Console.WriteLine("Wrong Username/Password");
        }

        
        //Show Main Menu
        Console.WriteLine("--> Please Select:\n 1.Show Available Rooms\n 2.Check-In\n 3.Show Reserved Room\n 4.Check Out\n 5.Log Out");
        string selection = Console.ReadLine();

        //Option 1
        if (selection == "1")
        {
            Console.WriteLine("Showing Available Rooms: ");
            foreach (var room in room_info)
                {
                    Console.WriteLine("Room Number: {0}; Capacity: {1}", room.Key, room.Value);
                }
        }

        //Option 2 
        else if (selection == "2")
        {
            Console.WriteLine("-->Input Number of People");
            string guests = Console.ReadLine();
            int Guests = Convert.ToInt32(guests);

            if (Guests > 5)
            {
                Console.WriteLine("--> No suitable rooms at this time");
            }
            
        }

        else if (selection == "3")
        {
            Console.WriteLine("------Reserved Rooms------");
            foreach (var res in res_rooms)
                {
                    Console.WriteLine("Room Number: {0}; Capacity: {1}", res.Key, res.Value);
                }
        }

        else if (selection == "4")
        {
            Console.WriteLine("--->Please input room number: ");
            int room_number = Convert.ToInt32(Console.ReadLine());
            
        }

        else if (selection == "5")
            {
                Console.WriteLine("Log out of System");
                attempts--;
                break;
            }
        
        
        
        else
        {
            Console.WriteLine("Not a valid selection");
            attempts--;
            break;
        }

        }
        while(attempts > 0);

    }

    /*static void CheckAccount()
    {
        Console.WriteLine("-->Please input username: ");
        string username = Console.ReadLine();
        Console.WriteLine("-->Please input password: ");
        string password = Console.ReadLine();

        if (username == "alice")
        {
            if (password == "alice123")
            {
                Console.WriteLine("-->Login Successfully");
            }
            else
            {
                Console.WriteLine("Wrong Username/Password");
            }
            
        }
        
        else
        {
            Console.WriteLine("Wrong Username/Password");
        }
    

    }*/
}


    }
}
