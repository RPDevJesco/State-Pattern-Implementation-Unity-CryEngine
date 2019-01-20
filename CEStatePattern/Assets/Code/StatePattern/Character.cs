using System;
using CryEngine;

namespace CharacterStateControl
{
    public class Character
    {
        public Entity CharacterObject;
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
            _state.HandleMovement(CharacterObject.Position);
        }

        private Vector3 GetDirection(Vector3 destination)
        {
            return (destination - CharacterObject.Position).Normalized;
        }

        public void MoveToward(Vector3 destination)
        {
            var direction = GetDirection(destination);
            CharacterObject.Position += direction * FrameTime.Delta * 1f;
        }
    }
}