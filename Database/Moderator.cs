public class Moderator : User
{
    public Moderator(string firstName, string lastName, string nickName, string gender, string email, string password) : 
        base(firstName, lastName, nickName, gender, email, password)
    { 

    }

    public void DeleteMessage() 
    { 

    }
    public void MakeWarn() 
    { 

    }
    public void MakeBan() 
    { 

    }
    public void PrintMenu() 
    { 
        base.PrintMenu();

        Console.WriteLine(
                          $"5. Удалить сообщение\n" +
                          $"6. Выдать предупреждение\n" +
                          $"7. Выдать БАН\n" +
                          $"===================");

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
            case 5:
                DeleteMessage();
                break;
            case 6:
                MakeWarn();
                break;
            case 7:
                MakeBan();
                break;
            default:
                break;
        }
    }

}

