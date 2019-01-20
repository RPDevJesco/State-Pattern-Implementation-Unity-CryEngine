using System;
using UnityEngine;

namespace CharacterStateControl
{
    public class WaitState : ICharacter
    {
        private Character _characterBaseState;
        private float _timer = 0f;

        public WaitState(Character character)
        {
            _characterBaseState = character;
            Debug.Log("I'm in the Wait State!");
        }

        public void HandleMovement(Vector3 position)
        {
            _timer += Time.deltaTime;

            if (_timer > 5f)
            {
                _characterBaseState.SetState(new WanderState(_characterBaseState));
            }
        }

        public void Update()
        {
            
        }
    }
}