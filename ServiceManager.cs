using System;
using System.Collections.Generic;
using UnityEngine;


namespace HatchStudio.ServiceLocator
{

    public class ServiceManager
    {
        private readonly Dictionary<Type, object> _service = new();
        public IEnumerable<object> Services => _service.Values;

        public ServiceManager Get<T>(out T service) where T : class
        {
            if (_service.TryGetValue(typeof(T), out var value))
            {
                service = value as T;
                return this;
            }

            service = null;
            throw new ArgumentException("Service not found: " + typeof(T).Name);
        }

        public bool TryGet<T>(out T service) where T : class
        {
            if (_service.TryGetValue(typeof(T), out var value))
            {
                service = value as T;
                return true;
            }

            service = null;
            return false;
        }

        public ServiceManager Register<T>(T service)
        {
            if (service == null)
                throw new ArgumentNullException(nameof(service), "Service cannot be null");

            var type = typeof(T);
            if (_service.ContainsKey(type))
                throw new ArgumentException("Service already registered: " + type.Name);

            _service[type] = service;
            return this;
        }
        public ServiceManager Register(Type type, object service) {
            if (!type.IsInstanceOfType(service)) {
                throw new ArgumentException("Type of service does not match type of service interface", nameof(service));
            }
            
            if (!_service.TryAdd(type, service)) {
                Debug.LogError($"ServiceManager.Register: Service of type {type.FullName} already registered");
            }
            
            return this;
        }
    }
}
