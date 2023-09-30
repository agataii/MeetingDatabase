public class Database
{
    public User[] Users = new User[]
    {
        new User("Agatai","Kulkaiyr","agataii","male","kulkaiyr0107@gmail.com","12345"),
        new Moderator("Moderator", "Moderator","Moderator","Moderator","Moderator", "Moderator")
    };

    public void PrintMainMenu()
    {
        Console.Clear();

        Console.WriteLine($"==== ГЛАВНОЕ МЕНЮ ====\n" +
                          "1. Зарегистрировать пользователя\n" +
                          "2. Авторизовать пользователя\n" +
                          "3. Показать никнейм всех пользователей\n" +
                          "======================");

        switch (InputCommand())
        {
            case 1:
                UserSignUp();
                break;
            case 2:
                UserLogIn();
                break;
            case 3:
                PrintAllUsers();
                break;
            default:
                break;
        }
    }

    public static int InputCommand()
    {
        Console.Write("Выберите команду: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public void WaitEnterForContinue()
    {
        Console.WriteLine("Press Enter for continue...");

        ConsoleKeyInfo keyInfo = Console.ReadKey();

        if (keyInfo.Key != ConsoleKey.Enter)
        {
            WaitEnterForContinue();
        }

    }

    public void PrintAllUsers()
    {
        Console.Clear();
        for (int i = 0; i < Users.Length; i++)
        {
            User user = Users[i];

            Console.WriteLine($"{i + 1}. {user.Nickname}");
        }
        WaitEnterForContinue();
    }

    public void UserSignUp()
    {
        Console.Clear();
        Console.WriteLine("== РЕГИСТРАЦИЯ ==");
        Console.Write("Введите имя:");
        string firstName = Console.ReadLine();
        Console.Write("Введите фамилию:");
        string lastName = Console.ReadLine();
        Console.Write("Введите никнейм:");
        string nickname = Console.ReadLine();
        Console.Write("Введите пол:");
        string gender = Console.ReadLine();
        Console.Write("Введите эл. почту:");
        string email = Console.ReadLine();
        Console.Write("Введите пароль");
        string password = Console.ReadLine();

        User newUser
            = new User(firstName, lastName, nickname, gender, email, password);

        User[] tempUsers = new User[Users.Length + 1];

        for (int i = 0; i < Users.Length; i++)
        {
            tempUsers[i] = Users[i];
        }

        tempUsers[Users.Length] = newUser;
        Users = tempUsers;

        Console.WriteLine($"Регистрация прошла успешна!");

        WaitEnterForContinue();
        PrintMainMenu();
    }

    public void UserLogIn()
    {
        Console.Clear();
        Console.WriteLine("== АВТОРИЗАЦИЯ ==");
        Console.Write("Введите никнейм или эмейл: ");
        string nicknameOrEmail = Console.ReadLine();
        Console.Write("Введите пароль:");
        string password = Console.ReadLine();

        foreach (User user in Users)
        {
            if (nicknameOrEmail == user.Nickname || nicknameOrEmail == user.Email)
            {
                if (password == user.Password)
                {
                    Console.WriteLine("Авторизация прошла успешно");

                    WaitEnterForContinue();

                    if (user is Moderator)
                    {
                        Moderator moderator= (Moderator)user;

                        moderator.PrintMenu();
                    }
                    else
                    {
                        user.PrintMenu();
                    }
                    return;
                }
            }
        }

        Console.WriteLine("Логин или пароль был введен не правильно!");
        
        WaitEnterForContinue();

        PrintMainMenu();
    }
}
