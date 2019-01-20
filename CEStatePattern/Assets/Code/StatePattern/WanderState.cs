using System;
using CryEngine;

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
            Log.ToConsole("I'm in the Wander State!");
        }
        
        public void HandleMovement(Vector3 position)
        {
            if (DestinationReached(position, _destination))
            {
                _characterBaseState.SetState(new WaitState(_characterBaseState));
            }

            _characterBaseState.MoveToward(_destination);
        }

        public Vector3 GetRandomDestination()
        {
            return new Vector3(
                CryEngine.Random.Range(1, 15),
                CryEngine.Random.Range(1, 15),
                32f);
        }

        private double Distance(Vector3 a, Vector3 b)
        {
            Vector3 difference = new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
            double distance = Math.Sqrt(Math.Pow(difference.x, 2f) + Math.Pow(difference.y, 2f) + Math.Pow(difference.z, 2f));
            return distance;
        }

        public bool DestinationReached(Vector3 currentPosition, Vector3 destination)
        {
            return Distance(currentPosition, destination) < 0.5f;
        }
    }
}