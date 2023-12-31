﻿using UnityEngine;

namespace CodeBase.Utilities.Rigidbody
{
    public class ClearRigidbody2DVelocity : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;

        private void FixedUpdate()
        {
            _rigidbody.velocity = default;
            _rigidbody.angularVelocity = default;
        }
    }
}