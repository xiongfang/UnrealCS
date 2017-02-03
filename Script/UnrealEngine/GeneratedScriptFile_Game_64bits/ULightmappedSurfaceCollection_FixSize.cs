#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ULightmappedSurfaceCollection
	{
		static readonly int SourceModel__Offset;
		public UModel SourceModel
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SourceModel__Offset); if (v == IntPtr.Zero)return null; UModel retValue = new UModel(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SourceModel__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SourceModel__Offset, value._this.Get()); }
			
		}
		
		static readonly int Surfaces__Offset;
		public TStructArray<int> Surfaces
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Surfaces__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Surfaces__Offset, false);}
			
		}
		
		static ULightmappedSurfaceCollection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LightmappedSurfaceCollection");
			SourceModel__Offset=GetPropertyOffset(NativeClassPtr,"SourceModel");
			Surfaces__Offset=GetPropertyOffset(NativeClassPtr,"Surfaces");
			
		}
		
	}
	
}
#endif
#endif
