﻿using SimpleGame.Engine.Engine.AnimationSystem;
using SimpleGame.Engine.Engine.Core.Domain;

namespace SimpleGame.Engine.Engine.EntitieSystem.Entities
{
    public abstract class AnimatedGameEntity : SpriteGameEntity
    {
        private readonly Animator _animator;

        protected AnimatedGameEntity(Sprite sprite, Animator animator) : base(sprite)
        {
            _animator = animator;
        }
        
        public override void Update()
        {
            _animator.UpdateAnimation(this);
        }
    }
}
