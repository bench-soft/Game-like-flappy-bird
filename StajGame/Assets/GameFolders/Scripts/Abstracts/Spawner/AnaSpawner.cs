using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StajGame.Abstracts.Spawner
{
    public abstract class AnaSpawner : MonoBehaviour
    {
        [Range(2f, 5f)]
        [SerializeField] float maxSpawTime = 3f;
        [Range(0.3f, 1.5f)]
        [SerializeField] float minSpawTime = 1f;

        float _currentSpawTime;
        float _timeBoundary;

        private void Start()
        {
            ResetTimes();
        }
        private void Update()
        {
            _currentSpawTime += Time.deltaTime;

            if (_currentSpawTime > _timeBoundary)
            {
                Spawner();
                ResetTimes();
            }

        }

        protected abstract void Spawner();
        

        private void ResetTimes()
        {
            _currentSpawTime = 0f;
            _timeBoundary = Random.Range(maxSpawTime, maxSpawTime);
        }

    }
}

