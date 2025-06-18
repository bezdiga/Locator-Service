using UnityEngine;

namespace HatchStudio.ServiceLocator
{
    public class ServiceLocatorGlobal : Bootstrapper
    {
        [SerializeField] bool dontDestroyOnLoad = true;
        protected override void Bootstrap()
        {
            Container.ConfigureAsGlobal(dontDestroyOnLoad);
        }
    }
}