#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleSizeScale
	{
		static readonly int SizeScale__Offset;
		/// <summary>
		/// The amount the BaseSize should be scaled before being used as the size of the particle.
		/// The value is retrieved using the RelativeTime of the particle during its update.
		/// NOTE: this module overrides any size adjustments made prior to this module in that frame.
		/// </summary>
		public FRawDistributionVector SizeScale
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+SizeScale__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SizeScale__Offset, false);}
			
		}
		
		static readonly int EnableX__Offset;
		/// <summary>Ignored</summary>
		public bool EnableX
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), EnableX__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), EnableX__Offset, 1,0,1,1);}
			
		}
		
		static readonly int EnableY__Offset;
		/// <summary>Ignored</summary>
		public bool EnableY
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), EnableY__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), EnableY__Offset, 1,0,2,2);}
			
		}
		
		static readonly int EnableZ__Offset;
		/// <summary>Ignored</summary>
		public bool EnableZ
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), EnableZ__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), EnableZ__Offset, 1,0,4,4);}
			
		}
		
		static UParticleModuleSizeScale()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleSizeScale");
			SizeScale__Offset=GetPropertyOffset(NativeClassPtr,"SizeScale");
			EnableX__Offset=GetPropertyOffset(NativeClassPtr,"EnableX");
			EnableY__Offset=GetPropertyOffset(NativeClassPtr,"EnableY");
			EnableZ__Offset=GetPropertyOffset(NativeClassPtr,"EnableZ");
			
		}
		
	}
	
}
#endif
#endif
