using System;
namespace UnrealEngine
{
	public partial struct FAssetEditorOrbitCameraPosition
	{
		/// <summary>Whether or not this has been set to a valid value</summary>
		public bool bIsSet;
		/// <summary>The position to orbit the camera around</summary>
		public FVector CamOrbitPoint;
		/// <summary>The distance of the camera from the orbit point</summary>
		public FVector CamOrbitZoom;
		/// <summary>The rotation to apply around the orbit point</summary>
		public FRotator CamOrbitRotation;
		
	}
	
}
