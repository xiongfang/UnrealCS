using System;
namespace UnrealEngine
{
	public partial class UNavModifierComponent:UNavRelevantComponent
	{
		public extern void SetAreaClass(TSubclassOf<UNavArea>  NewAreaClass);
		public TSubclassOf<UNavArea>  AreaClass;
		
		/// <summary>box extent used ONLY when owning actor doesn't have collision component</summary>
		public FVector FailsafeExtent;
		
		
	}
	
}
