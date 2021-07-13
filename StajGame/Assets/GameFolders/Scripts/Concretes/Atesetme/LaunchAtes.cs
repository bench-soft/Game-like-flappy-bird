using StajGame.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StajGame.Atesetme
{
    public class LaunchAtes : MonoBehaviour
    {
        [SerializeField] AtesKontrol projectilePrefab;
        [SerializeField] Transform projectileTransform;
        [SerializeField] float delayProjectile = 1f;
        [SerializeField] GameObject atesParent;

        float _currentDelayTime = 0f;
        bool _canlaunch = false;

        private void Update()
        {
            _currentDelayTime += Time.deltaTime;

            if (_currentDelayTime > delayProjectile)
            {
                _canlaunch = true;
                _currentDelayTime = 0f;
            }
        }
        public void LaunchAction()
        {
            if (_canlaunch)
            {
                 AtesKontrol newProjectile =Instantiate(projectilePrefab, projectileTransform.position, projectileTransform.transform.rotation);
                newProjectile.transform.parent = atesParent.transform;
                _canlaunch = false;
            }
            
        }
    }

}
