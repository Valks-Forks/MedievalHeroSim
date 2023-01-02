using System;
using Serilog;
using System.Collections.Generic;
using Pawn.Tasks;
using Pawn.Action;
using Pawn.Controller;
namespace Pawn.Goal {
	public class WanderGoal : IPawnGoal
	{
		public ITask GetTask(PawnController pawnController) {
			int sideLength = 50;
			Random random = new Random();
			float x = (float) ((random.NextDouble() * sideLength) - (sideLength/2));
			float z = (float) ((random.NextDouble() * sideLength) - (sideLength/2));
			int waitTimeMilliseconds = 2000;
			return new StaticPointTask(new WaitAction(pawnController, 3000),  1.5f, new Godot.Vector3(x,5,z));
		}
	}
}