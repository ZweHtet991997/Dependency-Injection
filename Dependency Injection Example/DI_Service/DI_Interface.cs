namespace Dependency_Injection_Example.DI_Service
{
    public interface ITransientService
    {
        Guid GetId();
    }

    public interface IScopedService
    {
        Guid GetId();
    }

    public interface ISingletonService
    {
        Guid GetId();
    }
}
