public class User
{
    public string AccountType;
    public string FirstName;
    public string LastName;
    public string Nickname;
    public string Gender;
    public string Email;
    public string Password;
    public int SecondPassedCount => (int)(RegisterDate - DateTime.Now).TotalSeconds;
    public DateTime RegisterDate;

    public User(string firstName, string lastName, string nickName, string gender, string email, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        Nickname = nickName;
        Gender = gender;
        Email = email;
        Password = password;
        RegisterDate = DateTime.Now;
    }

    public void PrintMessage()
    {

    }

    public void ChangePassword()
    {

    }
    public void ChangeEmail()
    {

    }
    public void ChangeNickname()
    {

    }
    public void PrintMenu()
    {
        Console.WriteLine($"====== Меню ======\n" +
                          $"1. Написать\n" +
                          $"2. Изменить пароль\n" +
                          $"3. Изменить Email\n" +
                          $"4. Изменить Никнейм\n" +
                          $"===================");

        if(this.GetType() == typeof(User))
        {
            Console.WriteLine();
            switch (Database.InputCommand())
            {
                case 1:
                    PrintMessage();
                    break;
                case 2:
                    ChangePassword();
                    break;
                case 3:
                    ChangeEmail();
                    break;
                case 4:
                    ChangeNickname();
                    break;
                default:
                    break;
            }
        }
        
    }
}