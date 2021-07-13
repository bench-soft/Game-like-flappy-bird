using StajGame.Abstracts.Kontrol;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StajGame.Controller
{
    public class AtesKontrol : LifeKontrol
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            EnemyKontroller enemy = collision.GetComponent<EnemyKontroller>();

            if (enemy != null)
            {
                GameManager.Instance.ArtirScore();
                Destroy(enemy.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
}

