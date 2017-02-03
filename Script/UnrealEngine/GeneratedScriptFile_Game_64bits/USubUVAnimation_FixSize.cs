#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USubUVAnimation
	{
		static readonly int SubUVTexture__Offset;
		public UTexture2D SubUVTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SubUVTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SubUVTexture__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SubUVTexture__Offset, value._this.Get()); }
			
		}
		
		static readonly int SubImages_Horizontal__Offset;
		public int SubImages_Horizontal
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SubImages_Horizontal__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubImages_Horizontal__Offset, false);}
			
		}
		
		static readonly int SubImages_Vertical__Offset;
		public int SubImages_Vertical
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SubImages_Vertical__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubImages_Vertical__Offset, false);}
			
		}
		
		static readonly int BoundingMode__Offset;
		public ESubUVBoundingVertexCount BoundingMode
		{
			get{ CheckIsValid();return (ESubUVBoundingVertexCount)Marshal.PtrToStructure(_this.Get()+BoundingMode__Offset, typeof(ESubUVBoundingVertexCount));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BoundingMode__Offset, false);}
			
		}
		
		static readonly int OpacitySourceMode__Offset;
		public EOpacitySourceMode OpacitySourceMode
		{
			get{ CheckIsValid();return (EOpacitySourceMode)Marshal.PtrToStructure(_this.Get()+OpacitySourceMode__Offset, typeof(EOpacitySourceMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OpacitySourceMode__Offset, false);}
			
		}
		
		static readonly int AlphaThreshold__Offset;
		public float AlphaThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AlphaThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AlphaThreshold__Offset, false);}
			
		}
		
		static USubUVAnimation()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SubUVAnimation");
			SubUVTexture__Offset=GetPropertyOffset(NativeClassPtr,"SubUVTexture");
			SubImages_Horizontal__Offset=GetPropertyOffset(NativeClassPtr,"SubImages_Horizontal");
			SubImages_Vertical__Offset=GetPropertyOffset(NativeClassPtr,"SubImages_Vertical");
			BoundingMode__Offset=GetPropertyOffset(NativeClassPtr,"BoundingMode");
			OpacitySourceMode__Offset=GetPropertyOffset(NativeClassPtr,"OpacitySourceMode");
			AlphaThreshold__Offset=GetPropertyOffset(NativeClassPtr,"AlphaThreshold");
			
		}
		
	}
	
}
#endif
#endif
