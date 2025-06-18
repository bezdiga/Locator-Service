using UnityEngine;

namespace HatchStudio.ServiceLocator
{
    public class ServiceLocatorSample : MonoBehaviour
    {
        void Awake()
        {
            ServiceLocator.ForSceneOf(this).Register<IAudioService>(new AudioService());
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }

    public interface IAudioService
    {
        void PlaySound(string soundName);
    }
    public class AudioService : IAudioService
    {
        public void PlaySound(string soundName)
        {
            Debug.Log($"Playing sound: {soundName}");
        }
    }
}
