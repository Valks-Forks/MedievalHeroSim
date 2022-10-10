using Godot;
using System.Collections.Generic;

namespace Pawn.Tasks {
	public class StaticPointTask : ITask {
		private Vector3 targetPoint;

		public StaticPointTask(string _actionName,
								object _actionArgs,
								float _targetDistance,
								Vector3 _targetPoint) 
		{
			actionName = _actionName;
			actionArgs = _actionArgs;
			targetDistance = _targetDistance;
			targetPoint = _targetPoint;
		}
		public Vector3 GetTargetLocation(){
			return targetPoint;
		}
		public string actionName {get;}
		//Dictionary for the action ;arguments
		public object actionArgs {get;}
		//How close the pawn will attempt to get to the target before starting the action
		public float targetDistance {get;}
		//Represents whether the task is valid or not
		public bool isValid {get {return true;}}
	}
}