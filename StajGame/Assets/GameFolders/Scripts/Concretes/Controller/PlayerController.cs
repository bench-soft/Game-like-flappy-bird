using StajGame.Atesetme;
using StajGame.HareketKontrol;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StajGame.Controller
{
    public class PlayerController : MonoBehaviour
    {
        
        Rigidbody2D _rigidbody2D;
        LaunchAtes _launchProjectile;
   
        bool _isSolMouseClicked;
        Ziplama _zipla;
        PcInputKontroller _input;
        AudioSource _audioSource;
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _zipla = GetComponent<Ziplama>();
            _launchProjectile = GetComponent<LaunchAtes>();
            _audioSource = GetComponent<AudioSource>();
            _input = new PcInputKontroller();
            
        }

        private void Update()
        {
            if (_input.LeftMouseClickDown)
            {
                _isSolMouseClicked = true;
            }

            if (_input.RightMouseClickDown)
            {
                _launchProjectile.LaunchAction();
            }
             
        }

        private void FixedUpdate()
        {
            if (_isSolMouseClicked)
            {
                _zipla.ZiplamaAction(_rigidbody2D);
                _audioSource.Play();
                _isSolMouseClicked = false;
            }
        }

        
    }
}

