#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleParameterDynamic
	{
		static readonly int DynamicParams__Offset;
		/// <summary>The dynamic parameters this module uses.</summary>
		public TStructArray<FEmitterDynamicParameter> DynamicParams
		{
			get{ CheckIsValid();return new TStructArray<FEmitterDynamicParameter>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DynamicParams__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DynamicParams__Offset, false);}
			
		}
		
		static readonly int UpdateFlags__Offset;
		/// <summary>Flags for optimizing update</summary>
		public int UpdateFlags
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+UpdateFlags__Offset, typeof(int));}
			
		}
		
		static readonly int bUsesVelocity__Offset;
		public bool bUsesVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsesVelocity__Offset, 1, 0, 1, 1);}
			
		}
		
		static UParticleModuleParameterDynamic()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleParameterDynamic");
			DynamicParams__Offset=GetPropertyOffset(NativeClassPtr,"DynamicParams");
			UpdateFlags__Offset=GetPropertyOffset(NativeClassPtr,"UpdateFlags");
			bUsesVelocity__Offset=GetPropertyOffset(NativeClassPtr,"bUsesVelocity");
			
		}
		
	}
	
}
#endif
#endif
