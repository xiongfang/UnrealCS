#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=256)]
	public partial struct FClothingAssetData
	{
		/// <summary>User-defined asset name</summary>
		[FieldOffset(0)]
		public FName AssetName;
		[FieldOffset(16)]
		public FString ApexFileName;
		/// <summary>the flag whether cloth physics properties are changed from UE4 editor or not</summary>
		public bool bClothPropertiesChanged
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(36)]
		public FClothPhysicsProperties PhysicsProperties;
		
	}
	
}
#endif
#endif
