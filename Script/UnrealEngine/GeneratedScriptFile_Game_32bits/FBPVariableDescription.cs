#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=160)]
	public partial struct FBPVariableDescription
	{
		[FieldOffset(0)]
		public FName VarName;
		[FieldOffset(8)]
		public FGuid VarGuid;
		[FieldOffset(24)]
		public FEdGraphPinType VarType;
		[FieldOffset(96)]
		public FString FriendlyName;
		[FieldOffset(108)]
		public FText Category;
		[FieldOffset(120)]
		public ulong PropertyFlags;
		[FieldOffset(128)]
		public FName RepNotifyFunc;
		public TStructArray<FBPVariableMetaDataEntry> MetaDataArray
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBPVariableMetaDataEntry>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+136, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+136, false);}}}
			
		}
		[FieldOffset(148)]
		public FString DefaultValue;
		
	}
	
}
#endif
#endif
