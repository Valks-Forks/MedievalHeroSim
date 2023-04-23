using Godot;
using System;
using Serilog;
using Pawn.Controller;
namespace Pawn.Item {
	public partial class Equipment : IItem
	{
		public double Damage {get; set;} = 0;
		public double Defense {get; set;} = 0;
		public Node3D Mesh {get;}
		public EquipmentType EquipmentType{get; set;}
		public Equipment(Node3D mesh, EquipmentType equipmentType) {
			Mesh = mesh;
			EquipmentType = equipmentType;
		}
		public void QueueFree() {
			Mesh.QueueFree();
		}
	}

	public enum EquipmentType {
		HEAD, 
		CHEST, 
		LEGS, 
		FEET, 
		HANDS, 
		HELD,
		RING,// unimplemented
		}
}
