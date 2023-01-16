namespace EcommerceConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> userList = new List<User>();
            userList.Add(new User("mustafa", "123", 60000));
            userList.Add(new User("ahmed", "123", 30000));


            Cart myCart = new Cart();

        
    Console.WriteLine("Please Choose one of the Folowing.");
                Console.WriteLine("1 for Login");
                Console.WriteLine("2 for SignUp");

                int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;  true; i++)
            {
            

                if(input == 1 )
                {
                    for (int j = 0;true ; j++)
                    {
                        Console.Write("Enter Your username: ");
                        string username = Console.ReadLine();
                        Console.Write("Enter Your Password: ");
                        string password = Console.ReadLine();

                        User currentUser = null;
                        foreach (User user in userList)
                        {
                            if (user.UserName == username && user.CheckPassword(password))
                            {
                                currentUser = user; break;

                            }
                        }
                        if (currentUser is null)
                        {
                            Console.WriteLine("Wrong Username or Password");
                            continue;
                        }
                        myCart.AssignUser(currentUser);

                        Console.WriteLine("Please Choose what you want to buy: ");
                        Console.WriteLine("1 for Labtop");
                        Console.WriteLine("2 for Smartphone");
                        Console.WriteLine("3 for Accessories");

                        input = Convert.ToInt32(Console.ReadLine());

                        if(input == 1)
                        {
                            Laptop laptop = new Laptop("Dell XPS",45000,"Dell",3);
                            
                            myCart.AddProduct(laptop);
                        }
                        else if(input == 2)
                        {
                            SmartPhone phone = new SmartPhone("Samsoung S20",20000,2022,OperatingSystem.Android);
                            myCart.AddProduct(phone);
                        }else if (input == 3)
                        {
                            Accessories accessory = new Accessories("Headphone A22", 5000, Color.Black, AccessoryType.Headphone);
                            myCart.AddProduct(accessory);
                        }

                        Console.WriteLine("Please Enter 1 To Check out or 2 to cancel: ");
                        int option = 0;
                        do
                        {
                            option = Convert.ToInt32(Console.ReadLine());
                            if (input == 1)
                            {
                                myCart.Checkout();
                                

                            }
                            else
                            {
                                option = 0;
                                myCart.Cancel();
                                Console.WriteLine("You canceled the process.");
                                break;
                            }
                        } while (input!=2);


                    }


                }
                else
                {
                    Console.Write("Enter Your username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter Your Password: ");
                    string password = Console.ReadLine();
                    Console.Write("Enter Your Balance: ");
                    int initialBalance = Convert.ToInt32(Console.ReadLine());

                    User newUser = new User(username, password,initialBalance);
                    newUser.AddBalance(initialBalance);

                    userList.Add(newUser);
                }

            }


          
        }
    }
}