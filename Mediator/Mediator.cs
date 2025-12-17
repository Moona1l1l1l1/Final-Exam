using System.Collections.Generic;

public class Mediator
{
    private Dictionary<string, IModule> modules = new();
    private Dictionary<string, List<string>> scenarios = new();

    public void Register(IModule module)
    {
        modules[module.Name] = module;
    }

    public void Configure(string eventName, List<string> moduleNames)
    {
        scenarios[eventName] = moduleNames;
    }

    public void Send(string eventName, string data)
    {
        if (!scenarios.ContainsKey(eventName)) return;

        foreach (var name in scenarios[eventName])
        {
            if (modules.ContainsKey(name))
                modules[name].Handle(eventName, data);
        }
    }
}
