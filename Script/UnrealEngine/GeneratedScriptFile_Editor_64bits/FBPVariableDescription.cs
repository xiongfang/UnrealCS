#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct indicating a variable in the generated class</summary>
	[StructLayout(LayoutKind.Explicit,Size=264)]
	public partial struct FBPVariableDescription
	{
		/// <summary>Name of the variable</summary>
		[FieldOffset(0)]
		public FName VarName;
		/// <summary>A Guid that will remain constant even if the VarName changes</summary>
		[FieldOffset(12)]
		public FGuid VarGuid;
		/// <summary>Type of the variable</summary>
		[FieldOffset(32)]
		public FEdGraphPinType VarType;
		/// <summary>Friendly name of the variable</summary>
		[FieldOffset(168)]
		public FString FriendlyName;
		/// <summary>Category this variable should be in</summary>
		[FieldOffset(184)]
		public FText Category;
		/// <summary>Property flags for this variable - Changed from int32 to uint64</summary>
		[FieldOffset(208)]
		public ulong PropertyFlags;
		[FieldOffset(216)]
		public FName RepNotifyFunc;
		[FieldOffset(228)]
		public ELifetimeCondition ReplicationCondition;
		/// <summary>Metadata information for this variable</summary>
		public TStructArray<FBPVariableMetaDataEntry> MetaDataArray
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBPVariableMetaDataEntry>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+232, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+232, false);}}}
			
		}
		/// <summary>Optional new default value stored as string</summary>
		[FieldOffset(248)]
		public FString DefaultValue;
		
	}
	
}
#endif
#endif
