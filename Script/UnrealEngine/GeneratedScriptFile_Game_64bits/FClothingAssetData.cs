#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=240)]
	public partial struct FClothingAssetData
	{
		[FieldOffset(0)]
		public FName AssetName;
		[FieldOffset(8)]
		public FString ApexFileName;
		public bool bClothPropertiesChanged
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 24, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 24, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(28)]
		public FClothPhysicsProperties PhysicsProperties;
		public TStructArray<int> ApexToUnrealBoneMapping
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+112, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+112, false);}}}
			
		}
		
	}
	
}
#endif
#endif
