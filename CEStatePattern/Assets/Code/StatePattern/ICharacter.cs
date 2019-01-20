using System;
using CryEngine;

namespace CharacterStateControl
{
    public interface ICharacter
    {
        void HandleMovement(Vector3 position);
    }
}