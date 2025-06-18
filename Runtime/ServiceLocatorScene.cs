namespace HatchStudio.ServiceLocator
{
    public class ServiceLocatorScene : Bootstrapper
    {
        protected override void Bootstrap()
        {
            Container.ConfigureForScene();
        }
    }
}