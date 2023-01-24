using System;

namespace User_PassProject
{
    internal class User_PassProject
    {
        private static void Main(string[] args)
        {
            string username, password, confirmed_password, passcheck1, passcheck2, userandpasshappy, userorpasschange, newusername, newpassword;

            Console.WriteLine("Hey new user! To start, create an account with us: ");
            Console.Write("Username: "); username = Console.ReadLine();
            Console.Write("Password: "); password = Console.ReadLine();
            Console.Write("Confirm your password once more: "); confirmed_password = Console.ReadLine();
            if (password == confirmed_password)
            {
                Console.WriteLine("Your account has been created with the username " + username + " and the password " + password + ". Are you happy with that?");
                userandpasshappy = Console.ReadLine();
                if (userandpasshappy == "yes")
                {
                    Console.WriteLine("Welcome " + username + ".");
                }
                else if (userandpasshappy == "no")
                {
                    Console.WriteLine("What would you like to change?");
                    Console.WriteLine("Type Username or Password: ");
                    userorpasschange = Console.ReadLine();
                    if (userorpasschange == "Username")
                    {
                        Console.Write("New Username: "); newusername = Console.ReadLine();
                        Console.WriteLine("Your old username was " + username + ". Your new username is " + newusername + ".");
                        Console.WriteLine("Account Information: ");
                        Console.WriteLine("Username: " + newusername + " Password: " + password);
                        Console.WriteLine("Welcome " + newusername + ".");
                    }
                    if (userorpasschange == "Password")
                    {
                        Console.Write("New Password: "); newpassword = Console.ReadLine();
                        Console.WriteLine("Your old password was " + password + ". Your new password is " + newpassword + ".");
                        Console.WriteLine("Account Information: ");
                        Console.WriteLine("Username: " + username + " Password: " + newpassword);
                        Console.WriteLine("Welcome " + username + ".");
                    }
                }
            }
            else if (password != confirmed_password)
            {
                Console.WriteLine("That won't work! You have 2 tries remaining: ");
                passcheck1 = Console.ReadLine();
                if (passcheck1 == password)
                {
                    Console.WriteLine("Success.");
                }
                else if (passcheck1 != password)
                {
                    Console.WriteLine("You have 1 try remaining: ");
                    passcheck2 = Console.ReadLine();
                    if (passcheck2 == password)
                    {
                        Console.WriteLine("Success.");
                    }
                    else
                    {
                        Console.WriteLine("You were locked out.");
                    }
                }
            }
        }
    }
}