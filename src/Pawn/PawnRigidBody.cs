using Godot;
using System;
using Serilog;
using Pawn;
namespace Pawn {
	public partial class PawnRigidBody : RigidBody3D
	{
		[Export] private NodePath PawnControllerPath = (NodePath) "..";
		public override void _Ready()
		{
			if(PawnControllerPath == null || PawnControllerPath == "") {
				Log.Error("YOU FORGOT TO SET PAWNCONTROLLER PATH IN PawnRigidBody.cs");
			}
		}

		public PawnController GetPawnController() {
			return this.GetNode<PawnController>(PawnControllerPath);
		}
	}
}
