using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Grupparbete_Marshall.Methods;

namespace Grupparbete_Marshall.Classes
{
    class User
    {
        public static List<User> userList = new List<User>();

        public static void InitializeUserList()
        {
            new Classes.User("Anders Andersson", 30, "Exempeladress 1", 40010, 0, 0, 0);
            new Classes.User("Anders Johansson", 30, "Exempeladress 2", 40010, 0, 0, 0);
            new Classes.User("Anders Göransson", 30, "Exempeladress 3", 40010, 0, 0, 5);
            new Classes.User("Anders Nilsson", 30, "Exempeladress 4", 40010, 0, 0, 0);
            new Classes.User("Anders Olsson", 30, "Exempeladress 5", 40010, 0, 0, 0);
        }

        private int _id;
        private string _name;
        private int _age;
        private string _streetAddress;
        private int _postNumber;
        private int _numberOfSearch = 0;
        private int _foundMarschall = 0;
        private int _lostLighters = 0;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public User()
        {
        }

        public User(string n, int a, string s, int p, int ns, int f, int l)
        {
            this._id = userList.Count + 1;
            this._name = n;
            this._age = a;
            this._streetAddress = s;
            this._postNumber = p;
            this._numberOfSearch = ns;
            this._foundMarschall = f;
            this._lostLighters = l;
            userList.Add(this);
        }

        public User(string n, int a, string s, int p)
        {
            this._id = userList.Count + 1;
            this._name = n;
            this._age = a;
            this._streetAddress = s;
            this._postNumber = p;
            userList.Add(this);
        }

        public static void PrintUser(User user)
        {

            Console.WriteLine("ID:{0}", user._id);
            Console.WriteLine("Name:{0}", user._name);
            Console.WriteLine("Age:{0}", user._age);
            Console.WriteLine("Street Adress:{0}", user._streetAddress);
            Console.WriteLine("Post Number:{0}", user._postNumber);
            Console.WriteLine("Number Of Seach:{0}", user._numberOfSearch);
            Console.WriteLine("Found Marchall:{0}", user._foundMarschall);
            Console.WriteLine("Lost Lighters:{0}", user._lostLighters);

        }

        public static string GetUserName(User user)
        {
            return user._name;
        }
        public static User GetUserById(int id)
        {
            foreach (User u in userList)
            {
                if (u._id == id)
                {
                    return u;
                }
            }

            Console.WriteLine("That was not a valid ID, try again..");
            return null;
        }

        public static void AddSearch(User user)
        {
            user = GetUserById(LoginUser.currentUser._id);
            user._numberOfSearch++;
        }

        public static void AddFoundMarshall(User user)
        {
            user = GetUserById(LoginUser.currentUser._id);
            user._foundMarschall++;
        }

        public static void AddLostLighter(User user)
        {
            user = GetUserById(LoginUser.currentUser._id);
            user._lostLighters++;

            Console.WriteLine("Lost lighter has been recorded");


            Console.WriteLine("\n Press any key to return to Main menu");
            Console.ReadKey();
            Menus.MenuAtLogin.LoginMenu();
        }

        public static void EditUserMethod(User user)
        {
            int userInput = 0;

            do
            {
                Console.WriteLine("Välj vad vill du ändra: ");
                Console.WriteLine("1. Ändra namn");
                Console.WriteLine("2. Ändra ålder");
                Console.WriteLine("3. Ändra adress");

                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Du måste välja ett nummer ifrån menyn. Tryck på valfri tangent för att försöka igen: ");
                }

            } while (userInput == 0);

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Ändra namn: ");
                    LoginUser.currentUser._name = Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Ändra ålder: ");
                    LoginUser.currentUser._age = Convert.ToInt32(Console.ReadLine());
                    break;

                case 3:
                    Console.WriteLine("Ändra address: ");
                    LoginUser.currentUser._streetAddress = Console.ReadLine();
                    break;
            }

            Menus.MenuAtLogin.LoginMenu();
        }


        public static void LighterHighScore()

        {
            User TopScores = new User();
            foreach (var users in userList)
            {
                if (users == null)
                {
                    break;
                }
                if (users._lostLighters > TopScores._lostLighters)

                {

                    {

                    TopScores = users;
                }
            }

            PrintUser(TopScores);

        }

        public static void FoundMaschallScore()
        { 

         User TopScores = new User();
         foreach (var users in userList)
         { 
          
              if (users == null) 
             {  
                break; 
              }
              if (users._foundMarschall > TopScores._foundMarschall)
              {
                    TopScores = users;
              }
        
         } PrintUser(TopScores);
         
         }
        
     

      
            
     }



           


        }


    }



