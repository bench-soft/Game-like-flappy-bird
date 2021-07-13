using StajGame.Abstracts.Spawner;
using StajGame.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StajGame.Spawner
{
    public class EngelSpawner : AnaSpawner
    {
        

        [SerializeField] EnemyKontroller[] enemies;

        
        

        protected override void Spawner()
        {
            int enemyIndex = Random.Range(0, enemies.Length);
            Instantiate(enemies[enemyIndex], this.transform); 
        }

        
    }
}

