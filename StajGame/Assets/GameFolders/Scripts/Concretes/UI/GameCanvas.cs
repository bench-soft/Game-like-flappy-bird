﻿using StajGame.Atesetme;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StajGame.UI
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;

        private void Awake()
        {
            gameOverPanel = transform.GetChild(1).gameObject;
        }

        private void Start()
        {
            Dead dead = FindObjectOfType<Dead>();
            dead.OnDead += HandleOnDead;
            
        }

        private void HandleOnDead()
        {
            gameOverPanel.SetActive(true);
        }
    }
}

