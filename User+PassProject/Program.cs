using System;

namespace User_PassProject
{
    internal class User_PassProject
    {
        private static void Main(string[] args)
        {
            // Declare login and change login variables
            string username, password, confirmed_password, passcheck1, passcheck2, passhappy, newpassword;
            // Initiate a new user
            Console.WriteLine("Hey new user! To start, create an account with us: ");
            Console.Write("Username: "); username = Console.ReadLine();
            Console.Write("Password: "); password = Console.ReadLine();
            Console.Write("Confirm your password: "); confirmed_password = Console.ReadLine();
            // Initial password confirmation
            if (password == confirmed_password)
            {
                Console.WriteLine("Your account has been created with the username " + username + " and the password " + password + ". Are you happy with your password?");
                passhappy = Console.ReadLine();
                // If user is content, let them continue
                if (passhappy == "yes")
                {
                    Console.WriteLine("Welcome " + username + ".");
                }
                // If user is unhappy, prompt them to change their Password
                else if (passhappy == "no")
                {
                    Console.WriteLine("New Password: ");
                    newpassword = Console.ReadLine();

                    Console.WriteLine("Your old password was " + password + ". Your new password is " + newpassword + ".");
                    Console.WriteLine("Account Information: ");
                    Console.WriteLine("Username: " + username + " Password: " + newpassword);
                }
            }
            // If user is unable to confirm their password, run conditionals for two guesses
            else if (password != confirmed_password)
            {
                Console.WriteLine("That won't work! You have 2 tries remaining: ");
                passcheck1 = Console.ReadLine();
                if (passcheck1 == password)
                {
                    Console.WriteLine("Success.");
                    return;
                }
                else if (passcheck1 != password)
                {
                    Console.WriteLine("You have 1 try remaining: ");
                    passcheck2 = Console.ReadLine();
                    // Final password check. If user guesses correct, they are logged in.
                    if (passcheck2 == password)
                    {
                        Console.WriteLine("Success.");
                        return;
                    }
                    // If user is unable to guess, they are locked out
                    else
                    {
                        Console.WriteLine("You were locked out.");
                        return;
                    }
                }
            }
        }
    }
}