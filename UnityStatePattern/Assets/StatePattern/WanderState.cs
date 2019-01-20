using System;
using UnityEngine;

namespace CharacterStateControl
{
    public class WanderState : ICharacter
    {
        private Character _characterBaseState;
        private Vector3 _destination;

        public WanderState(Character character)
        {
            _characterBaseState = character;
            _destination = GetRandomDestination();
            Debug.Log("I'm in the Wander State!");
        }

        public void HandleMovement(Vector3 position)
        {
            if (DestinationReached(position, _destination))
            {
                _characterBaseState.SetState(new WaitState(_characterBaseState));
            }

            _characterBaseState.MoveTowards(_destination);
        }

        public void Update()
        {
            
        }

        public Vector3 GetRandomDestination()
        {
            return new Vector3(
                UnityEngine.Random.Range(1, 15),
                0f,
                UnityEngine.Random.Range(1, 15));
        }

        public bool DestinationReached(Vector3 currentPosition, Vector3 destination)
        {
            return Vector3.Distance(currentPosition, destination) < 0.5f;
        }
    }
}