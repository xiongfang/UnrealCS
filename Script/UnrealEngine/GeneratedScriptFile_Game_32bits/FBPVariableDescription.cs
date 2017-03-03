#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=196)]
	public partial struct FBPVariableDescription
	{
		[FieldOffset(0)]
		public FName VarName;
		[FieldOffset(8)]
		public FGuid VarGuid;
		[FieldOffset(24)]
		public FEdGraphPinType VarType;
		[FieldOffset(128)]
		public FString FriendlyName;
		[FieldOffset(140)]
		public FText Category;
		[FieldOffset(152)]
		public ulong PropertyFlags;
		[FieldOffset(160)]
		public FName RepNotifyFunc;
		[FieldOffset(168)]
		public ELifetimeCondition ReplicationCondition;
		public TStructArray<FBPVariableMetaDataEntry> MetaDataArray
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBPVariableMetaDataEntry>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+172, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+172, false);}}}
			
		}
		[FieldOffset(184)]
		public FString DefaultValue;
		
	}
	
}
#endif
#endif
