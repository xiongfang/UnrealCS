using System;
namespace UnrealEngine
{
	/// <summary>
	/// The state passed into OnPaint that we can expose as a single painting structure to blueprints to
	/// allow script code to override OnPaint behavior.
	/// </summary>
	public partial struct FNamedSlotBinding
	{
		public FName Name;
		public UWidget Content;
		
	}
	
}
