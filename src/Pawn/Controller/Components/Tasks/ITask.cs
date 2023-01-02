using System.Collections.Generic;
using Godot;
using Pawn.Action;

namespace Pawn.Tasks {
	public interface ITask {
		Vector3 GetTargetLocation();
		//The name of the action to be used
		IAction Action {get;}
		//Dictionary for the action ;arguments
		//TODO: target distance should be based off the Action
		float TargetDistance {get;}
		//Represents whether the task is valid or not
		bool IsValid {get;}
		//The state that the task is in
		TaskState TaskState {get; set;}
		//Tasks with Priority -1 will never get interruptted
		//Priority is the game as the goal postion in the goal list. 
		//Goals earlier in the list will have a lower priority
		int Priority {get; set;}
		
	}
	//The status that the task is in
	public enum TaskState { MOVING_TO, USING_ACTION, COMPLETED}
}