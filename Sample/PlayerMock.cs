using System;
using UnityEngine;

namespace HatchStudio.ServiceLocator
{
    public class PlayerMock : MonoBehaviour
    {
        private IAudioService _audioService;
        private void Start()
        {
            ServiceLocator.ForSceneOf(this).Get(out _audioService);
            _audioService.PlaySound("Start");
        }
    }
}