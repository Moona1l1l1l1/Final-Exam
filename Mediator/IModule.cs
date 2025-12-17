public interface IModule
{
    string Name { get; }
    void Handle(string eventName, string data);
}
