using System;
using UnityEngine;

namespace CharacterStateControl
{
    public class Character
    {
        public GameObject characterObject;
        private ICharacter _state;

        public Character()
        {
            _state = new WanderState(this);
        }

        public void SetState(ICharacter newState)
        {
            _state = newState;
        }

        public void Update()
        {
            _state.HandleMovement(characterObject.transform.position);
        }

        private Vector3 GetDirection(Vector3 destination)
        {
            return (destination - characterObject.transform.position).normalized;
        }

        public void MoveTowards(Vector3 destination)
        {
            var direction = GetDirection(destination);
            characterObject.transform.Translate(direction * Time.deltaTime * 1f);
        }
    }
}
