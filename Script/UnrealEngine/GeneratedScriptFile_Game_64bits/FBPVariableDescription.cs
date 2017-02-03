#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=192)]
	public partial struct FBPVariableDescription
	{
		[FieldOffset(0)]
		public FName VarName;
		[FieldOffset(8)]
		public FGuid VarGuid;
		[FieldOffset(24)]
		public FEdGraphPinType VarType;
		[FieldOffset(104)]
		public FString FriendlyName;
		[FieldOffset(120)]
		public FText Category;
		[FieldOffset(144)]
		public ulong PropertyFlags;
		[FieldOffset(152)]
		public FName RepNotifyFunc;
		public TStructArray<FBPVariableMetaDataEntry> MetaDataArray
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBPVariableMetaDataEntry>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+160, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+160, false);}}}
			
		}
		[FieldOffset(176)]
		public FString DefaultValue;
		
	}
	
}
#endif
#endif
