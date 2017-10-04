using System;
namespace UnrealEngine
{
	/// <summary>This struct is serialized using native serialization so any changes to it require a package version bump.</summary>
	public partial struct FFontCharacter
	{
		public int StartU;
		public int StartV;
		public int USize;
		public int VSize;
		public byte TextureIndex;
		public int VerticalOffset;
		
	}
	
}
