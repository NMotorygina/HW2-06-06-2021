using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Client client1 = new Client();
            
            Console.Write("Введите имя пользователя - ");
            client1.name = Console.ReadLine();
            Console.Write("Введите телефон пользователя - ");
            client1.phone = Console.ReadLine();
            
            Account account = new Account("123456789", 0, client1);
            Operations(account);
        }
        static void Operations(Account account)
        {
            Console.Write("Выберите действие: 1. Внести деньги, 2. Снять деньги, 3. Закрыть счет - ");
            int choice = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            switch (choice)
            {
                case 1:
                    Console.Write("Введите сумму - ");
                    sum = Convert.ToDouble(Console.ReadLine());
                    account.SetBalance(account.GetBalance() + sum);
                    PrintAccount(account);
                    Operations(account);
                    break;
                case 2:
                    Console.Write("Введите сумму - ");
                    sum = Convert.ToDouble(Console.ReadLine());
                    if ((account.GetBalance() - sum) >= 0)
                    {
                        account.SetBalance(account.GetBalance() - sum);
                        PrintAccount(account);
                    }
                    else
                    {
                        Console.WriteLine($"Сумма превышает доступный остаток!!!, доступно для снятия - {account.GetBalance()}");
                        Console.WriteLine();
                    }
                    Operations(account);
                    break;
                case 3:
                    account.name = null;
                    account.phone = null;
                    account.number = null;
                    account.SetBalance(0);
                    Console.WriteLine("Счет закрыт!");
                    break;
            }
        }
        static void PrintAccount(Account account)
        {
            Console.WriteLine($"ФИО - {account.name}, телефон - {account.phone}");
            Console.WriteLine($"№ счета - {account.number}, остаток денежных средств - {account.GetBalance()}");
            Console.WriteLine();
        }
    }
}