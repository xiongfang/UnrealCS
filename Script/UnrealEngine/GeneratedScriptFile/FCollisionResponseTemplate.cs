using System;
namespace UnrealEngine
{
	/// <summary>Structure for collision response templates.</summary>
	public partial struct FCollisionResponseTemplate
	{
		public FName Name;
		public ECollisionEnabled CollisionEnabled;
		public FName ObjectTypeName;
		/// <summary>Help message for collision profile *</summary>
		public FString HelpMessage;
		/// <summary>Help message for collision profile *</summary>
		public bool bCanModify;
		
	}
	
}
