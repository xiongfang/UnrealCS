#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// URig : that has rigging data for skeleton
	///         - used for retargeting
	///         - support to share different animations
	/// </summary>
	public partial class URig
	{
		static readonly int TransformBases__Offset;
		/// <summary>Skeleton bone tree - each contains name and parent index*</summary>
		public TStructArray<FTransformBase> TransformBases
		{
			get{ CheckIsValid();return new TStructArray<FTransformBase>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TransformBases__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TransformBases__Offset, false);}
			
		}
		
		static readonly int Nodes__Offset;
		/// <summary>Skeleton bone tree - each contains name and parent index*</summary>
		public TStructArray<FNode> Nodes
		{
			get{ CheckIsValid();return new TStructArray<FNode>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Nodes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Nodes__Offset, false);}
			
		}
		
		static URig()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Rig");
			TransformBases__Offset=GetPropertyOffset(NativeClassPtr,"TransformBases");
			Nodes__Offset=GetPropertyOffset(NativeClassPtr,"Nodes");
			
		}
		
	}
	
}
#endif
#endif
