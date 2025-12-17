using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var mediator = new Mediator();

        var email = new EmailModule();
        var log = new LogModule();
        var bonus = new BonusModule();

        mediator.Register(email);
        mediator.Register(log);
        mediator.Register(bonus);

        mediator.Configure("USER_REGISTERED", new List<string> { "Email", "Log", "Bonus" });
        mediator.Configure("USER_DELETED", new List<string> { "Log" });

        while (true)
        {
            Console.WriteLine("Введите событие (USER_REGISTERED / USER_DELETED / exit):");
            string eventName = Console.ReadLine();
            if (eventName == "exit") break;

            Console.WriteLine("Введите имя пользователя:");
            string userName = Console.ReadLine();

            mediator.Send(eventName, userName);
            Console.WriteLine();
        }
    }
}
