using System.ComponentModel;
using System.Dynamic;
using System.Globalization;

namespace FinalProject;

class Program
{
    static void Main(string[] args)
    {
        int attempts = 100;
        int login_attempts = 100;
        int correct = 0;
        
        
        
        
        var room_info = new Dictionary <int, int>();
        room_info.Add(101,2);
        room_info.Add(102,2);
        room_info.Add(103,2);
        room_info.Add(104,2);
        room_info.Add(105,2);
        room_info.Add(108,3);
        room_info.Add(110,4);

        var res_rooms = new Dictionary <int, int>();
        res_rooms.Add(106,3);
        res_rooms.Add(107,3);
        res_rooms.Add(109,3);

       var res_names = new Dictionary <string, int>();
        res_names.Add("Bob", 106);
        res_names.Add("Cathy", 107);
        res_names.Add("Jack", 109);

        //Display Student's Name
        Console.WriteLine("---CIDM2315 Final Project: Cristian Rivas---");
        Console.WriteLine("---Welcome to Buff Hotel---");
        
        do
        {
            //User Login
            //I created a loop so that you don't have to keep entering dotnet run, it won't break the loop until the username and password are correct
            Console.WriteLine("-->Please input username: ");
            string username = Console.ReadLine();
            Console.WriteLine("-->Please input password: ");
            string password = Console.ReadLine();

            if (username == "alice")
            {
                if (password == "alice123")
                {
                    Console.WriteLine("-->Login Successfully");
                    break;
                }
                else
                {
                  Console.WriteLine("Pleaes try again");
                  
                }

            }
        }
        while(login_attempts > 0);
        
        
        do
        {
        
                //Show Main Menu
                Console.WriteLine("--> Please Select:\n 1.Show Available Rooms\n 2.Check-In\n 3.Show Reserved Room\n 4.Check Out\n 5.Log Out");
                string selection = Console.ReadLine();

                //Show Available Rooms
                if (selection == "1")
                {
                 Console.WriteLine("Showing Available Rooms: ");
                foreach (var room in room_info)
                {
                    Console.WriteLine("Room Number: {0}; Capacity: {1}", room.Key, room.Value);    
                }
                    Console.WriteLine("Number of Available Rooms: {0}",room_info.Count );

                }

                //Check-In 
                else if (selection == "2")
                {
                Console.WriteLine("-->Input Number of People");
                string guests = Console.ReadLine();
                int Guests = Convert.ToInt32(guests);
                int room_count = 0;

                if (Guests >= 5)
                    {
                    Console.WriteLine("--> No suitable rooms at this time");
                    } 
                
                else{
                foreach (var room in room_info)
                {
                 if (room.Value >= Guests && Guests != 5)
                            {
                                Console.WriteLine("Room Number: {0}; Capacity: {1}", room.Key, room.Value); 
                                room_count++;
                            }          
                }
                    Console.WriteLine("Number of Available Rooms: {0}",room_count);
                    Console.WriteLine("-->Input room number: ");
                    int Room_number = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("-->Input Customer Name: ");
                    string cust_name = Console.ReadLine();

                    Console.WriteLine("-->Input Customer Email: ");
                    string cust_email = Console.ReadLine();

                    Console.WriteLine("Check in successfull! Customer is assigned to room {0}", Room_number);

                    res_names.Add(cust_name, Room_number);
                    res_rooms.Add(Room_number, room_info[Room_number]);
                            
                    if (room_info.ContainsKey(Room_number))
                    {
                        room_info.Remove(Room_number);
                    }



                }
                
            
                }

                //Show Reserved Rooms
                else if (selection == "3")
                {
                Console.WriteLine("------Reserved Rooms------");
                foreach (var res in res_names)
                {
                    Console.WriteLine("Room Number: {0}; Customer: {1}", res.Value, res.Key);
                }
                }

                //Check-Out
                else if (selection == "4")
                {
                    Console.WriteLine("--->Please input room number: ");
                    int room_number = Convert.ToInt32(Console.ReadLine());

                    foreach (var res in res_names)
                    {
                        if (res_names.ContainsValue(room_number))
                        {
                        Console.WriteLine("--> Room: {0}; Customer: {1}", res.Value, res.Key);
                        correct = 1;
                        
                        }

                        else
                        {
                        Console.WriteLine("-->Could not find customer record of this rooom. Please select a valid room number!");
                        correct = 0;
                        break;
                        }           
                    }

                    if (correct == 1)
                    {
                        Console.WriteLine("\nPlease confirm the reservation is correct and press Y if it's correct!\n Press any other key to cancel check-out!");
                        
                        string check_out = Console.ReadLine();

                        if(check_out == "Y" || check_out == "y")
                            {
                            room_info.Add(room_number, res_rooms[room_number] );
                            res_rooms.Remove(room_number);
                            Console.WriteLine("-->Check-Out Successful");
                                                   
                            }
                            else
                            {
                                Console.WriteLine("-->Check-Out Cancelled! \n -->Please login again.");
                                break;
                            }
                
                
                            foreach (var res in res_names)
                            {
                            if (res.Value == room_number)
                            {
                                res_names.Remove(res.Key);
                                
                            }
                            }


                            Console.WriteLine("------Reserved Rooms------");
                            foreach (var res in res_names)
                            {
                                Console.WriteLine("Room Number: {0}; Customer: {1}", res.Value, res.Key);
                            }

                        }
                
                }

                
                //Log Out
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
}


