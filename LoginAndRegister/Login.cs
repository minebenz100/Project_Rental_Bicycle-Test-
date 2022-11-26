using System.Globalization;
public class Login {

     static Register register;
        public void Menu(){
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("||                                   ||");
                Console.WriteLine("||     BICYCLE RENTAL SYSTEM 2022    ||");
                Console.WriteLine("||                                   ||");
                Console.WriteLine("=======================================");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Register User");
                Console.WriteLine("2. Login");
                Console.Write("Input Menu:");
                string input = Console.ReadLine();

            if (input == "2"){
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("=======================================");
                Console.WriteLine("||                                   ||");
                Console.WriteLine("||             Login Menu            ||");
                Console.WriteLine("||                                   ||");
                Console.WriteLine("=======================================");
                Print_login();
                //return "Login";
                    
            }
            else if (input == "1"){
                registerMenu();
                //return "register";

            }
            //return null;
        }

        static void registerMenu(){
            Login.register = new Register();
            Login.register.ShowRegisterScreen();
        }

        static void Print_login(){
            string Username,Password;
                Console.WriteLine("Input Username");
                Username = Console.ReadLine();
                Console.WriteLine("Input Passworld");
                Password = Console.ReadLine();
                bool Check = Database.check_Login(Username,Password);
                if(Check == true){
                    Database.AddUsernameLogin(Username);
                    Console.WriteLine("Welcome to Program");
                    MainMenu main = new MainMenu();
                    main.ShowMainMenuScreen();
                }
                else{
                    Print_login();
                }
        }
}