using StajGame.Abstracts.Spawner;
using StajGame.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StajGame.Spawner
{
    public class RedDragonSpawner : AnaSpawner
    {
       

        [SerializeField] EnemyKontroller enemy;

        protected override void Spawner()
        {
            Instantiate(enemy, this.transform);
        }

       

       
    }

    
}
