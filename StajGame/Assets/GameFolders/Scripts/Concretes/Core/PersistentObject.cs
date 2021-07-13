
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StajGame.Core
{
    public class PersistentObject : MonoBehaviour
    {
        [SerializeField] GameObject persistentPrefab;

        static bool _isFirstTime = true;

        private void Start()
        {
            if (_isFirstTime)
            {
                SpawnPersistentObject();
                _isFirstTime = false;
            }
            
        }

        private void SpawnPersistentObject()
        {
            GameObject newObject = Instantiate(persistentPrefab);
            DontDestroyOnLoad(newObject);
        }
    }
}

