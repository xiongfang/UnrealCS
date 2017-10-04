using System;
namespace UnrealEngine
{
	public partial class UParticleModulePivotOffset:UParticleModuleLocationBase
	{
		/// <summary>Offset applied in UV space to the particle vertex positions. Defaults to (0.5,0.5) putting the pivot in the centre of the partilce.</summary>
		public FVector2D PivotOffset;
		
		
	}
	
}
