using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StajGame.HareketKontrol
{
    public class Ziplama : MonoBehaviour
    {
        [SerializeField] float ziplamaForce;

        public void ZiplamaAction(Rigidbody2D rigidbody2D)
        {
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(Vector2.up * ziplamaForce);
        }
    }
}

