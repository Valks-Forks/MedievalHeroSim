using System.Runtime.CompilerServices;
using System.Globalization;
using Godot;
using System;
using System.Collections.Generic;
using Serilog;
using Pawn.Action;
using Pawn.Tasks;
using Pawn;
using Worlds;
using Interactable;
using Util;
using Item;

namespace GUI.DebugInspector.Display
{
	public interface IDisplay
	{
		public List<IDisplay> GetChildDisplays();
		public List<string> GetDetails();
		public string Name { get; }
	}
}
