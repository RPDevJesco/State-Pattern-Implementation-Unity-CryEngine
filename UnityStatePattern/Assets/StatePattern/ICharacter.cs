using System;
using UnityEngine;

namespace CharacterStateControl
{
    public interface ICharacter
    {
        void Update();

        void HandleMovement(Vector3 position);
    }
}
