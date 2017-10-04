using System;
namespace UnrealEngine
{
	/// <summary>Parameters that apply to a destructible actor.</summary>
	public partial struct FDestructibleParameters
	{
		/// <summary>Parameters that pertain to chunk damage.  See DestructibleDamageParameters.</summary>
		public FDestructibleDamageParameters DamageParameters;
		/// <summary>Parameters that pertain to chunk debris-level settings.  See DestructibleDebrisParameters.</summary>
		public FDestructibleDebrisParameters DebrisParameters;
		/// <summary>Parameters that are less-often used.  See DestructibleAdvancedParameters.</summary>
		public FDestructibleAdvancedParameters AdvancedParameters;
		/// <summary>Special hierarchy depths for various behaviors.</summary>
		public FDestructibleSpecialHierarchyDepths SpecialHierarchyDepths;
		/// <summary>A collection of flags defined in DestructibleParametersFlag.</summary>
		public FDestructibleParametersFlag Flags;
		
	}
	
}
