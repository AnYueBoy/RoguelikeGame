using UFramework.Core;

public class ProvideInputManager : IServiceProvider
{
    public void Register()
    {
        App.Singleton<InputManager>();
    }

    public void Init()
    {
    }
}