#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=248)]
	public partial struct FBPVariableDescription
	{
		[FieldOffset(0)]
		public FName VarName;
		[FieldOffset(8)]
		public FGuid VarGuid;
		[FieldOffset(24)]
		public FEdGraphPinType VarType;
		[FieldOffset(152)]
		public FString FriendlyName;
		[FieldOffset(168)]
		public FText Category;
		[FieldOffset(192)]
		public ulong PropertyFlags;
		[FieldOffset(200)]
		public FName RepNotifyFunc;
		[FieldOffset(208)]
		public ELifetimeCondition ReplicationCondition;
		public TStructArray<FBPVariableMetaDataEntry> MetaDataArray
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBPVariableMetaDataEntry>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+216, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+216, false);}}}
			
		}
		[FieldOffset(232)]
		public FString DefaultValue;
		
	}
	
}
#endif
#endif
