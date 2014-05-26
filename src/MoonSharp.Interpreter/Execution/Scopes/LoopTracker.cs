﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Execution
{
	interface ILoop
	{
		void CompileBreak(Chunk bc);
	}


	class LoopTracker
	{
		public List<ILoop> Loops = new List<ILoop>();
	}
}
