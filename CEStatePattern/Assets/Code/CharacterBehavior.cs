using System;
using CryEngine;
using CharacterStateControl;

namespace CryEngine.Game
{
	[EntityComponent(Guid="245d2c61-5cec-be4a-c673-17c7cbd5ee35")]
	public class CharacterBehavior : EntityComponent
	{
        private Character _character;
		/// <summary>
		/// Called at the start of the game.
		/// </summary>
		protected override void OnGameplayStart()
		{
            _character = new Character();
            _character.CharacterObject = this.Entity;
		}

		/// <summary>
		/// Called once every frame when the game is running.
		/// </summary>
		/// <param name="frameTime">The time difference between this and the previous frame.</param>
		protected override void OnUpdate(float frameTime)
		{
            _character.Update();
        }
	}
}