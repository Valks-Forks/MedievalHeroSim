
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Godot;
using Pawn;
using Pawn.Action.Ability;
using Item;
using System;
using Interactable;

namespace Pawn.Action.Ability {
	public class AbilityBuilder {
		private Ability ability;
		public AbilityBuilder(PawnController ownerPawnController, System.Action<IInteractable?> executable, Predicate<PawnController> canBeUsedPredicate)
    	{
        	ability = new Ability(ownerPawnController, executable, canBeUsedPredicate);
    	}
		public static AbilityBuilder Start(PawnController pawnController, System.Action<IInteractable?> executable, Predicate<PawnController> canBeUsedPredicate) {
			return new AbilityBuilder(pawnController, executable, canBeUsedPredicate);
		}

		public AbilityBuilder MaxRange(float range) {
			ability.MaxRange = range;
			return this;
		}

		public AbilityBuilder Animation(AnimationName animationName) {
			ability.AnimationToPlay = animationName;
			return this;
		}

		//Sets looping to be true
		public AbilityBuilder AnimationPlayLength(int milliseconds) {
			ability.SetAnimationPlayLength(milliseconds);
			return this;
		}

		public AbilityBuilder HeldItem(IItem? item) {
			ability.HeldItem = item;
			return this;
		}

		public IAbility Finish() {
			return ability;
		}

		public AbilityBuilder Name(string name) {
			ability.Name = name;
			return this;
		}

		public AbilityBuilder CooldownMilliseconds(int milliseconds) {
			ability.CooldownMilliseconds = milliseconds;
			return this;
		}
		
	}
}