using System;

public class EmailModule : IModule
{
    public string Name => "Email";

    public void Handle(string eventName, string data)
    {
        Console.WriteLine("[Email] Новое событие: " + eventName + ", данные: " + data);
    }
}

public class LogModule : IModule
{
    public string Name => "Log";

    public void Handle(string eventName, string data)
    {
        Console.WriteLine("[Log] Событие " + eventName + " записано: " + data);
    }
}

public class BonusModule : IModule
{
    public string Name => "Bonus";

    public void Handle(string eventName, string data)
    {
        Console.WriteLine("[Bonus] Начислен бонус за " + eventName + " пользователю: " + data);
    }
}
