using StajGame.Enum;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StajGame.HareketKontrol
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Hareketleyci : MonoBehaviour
    {
        Rigidbody2D _rigidbody2D;
        [SerializeField] float moveSpeed = 5f;
        [SerializeField] DirectionEnum direction;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            Vector2 selectDirection;
            if (direction == DirectionEnum.Left)
            {
                selectDirection = Vector2.left;
            }
            else
            {
                selectDirection = Vector2.right;
            }
            _rigidbody2D.velocity = selectDirection * moveSpeed;
        }

        
    }
}

