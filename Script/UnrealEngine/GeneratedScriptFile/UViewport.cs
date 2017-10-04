using System;
namespace UnrealEngine
{
	public partial class UViewport:UContentWidget
	{
		public extern AActor Spawn(TSubclassOf<AActor>  ActorClass);
		public extern void SetViewRotation(FRotator Rotation);
		public extern FRotator GetViewRotation();
		public extern void SetViewLocation(FVector Location);
		public extern FVector GetViewLocation();
		public extern UWorld GetViewportWorld();
		public FLinearColor BackgroundColor;
		
		
	}
	
}
