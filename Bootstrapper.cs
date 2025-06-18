using System;
using UnityEngine;

namespace HatchStudio.ServiceLocator
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(ServiceLocator))]
    public abstract class Bootstrapper : MonoBehaviour
    {
        private ServiceLocator _serviceLocator;
        internal ServiceLocator Container => _serviceLocator ?? (_serviceLocator = GetComponent<ServiceLocator>());

        private bool hasBeenBootstrapped;
        void Awake() => BootstrapOnDemand();
        
        public void BootstrapOnDemand() {
            if (hasBeenBootstrapped) return;
            hasBeenBootstrapped = true;
            Bootstrap();
        }
        
        protected abstract void Bootstrap();
    }
}