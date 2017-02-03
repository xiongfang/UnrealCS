#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UWindDirectionalSourceComponent
	{
		static readonly int Strength__Offset;
		public float Strength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Strength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Strength__Offset, false);}
			
		}
		
		static readonly int Speed__Offset;
		public float Speed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Speed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Speed__Offset, false);}
			
		}
		
		static readonly int MinGustAmount__Offset;
		public float MinGustAmount
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinGustAmount__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinGustAmount__Offset, false);}
			
		}
		
		static readonly int MaxGustAmount__Offset;
		public float MaxGustAmount
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxGustAmount__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxGustAmount__Offset, false);}
			
		}
		
		static readonly int Radius__Offset;
		public float Radius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Radius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Radius__Offset, false);}
			
		}
		
		static readonly int bPointWind__Offset;
		public bool bPointWind
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPointWind__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPointWind__Offset, 1,0,1,1);}
			
		}
		
		static UWindDirectionalSourceComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WindDirectionalSourceComponent");
			Strength__Offset=GetPropertyOffset(NativeClassPtr,"Strength");
			Speed__Offset=GetPropertyOffset(NativeClassPtr,"Speed");
			MinGustAmount__Offset=GetPropertyOffset(NativeClassPtr,"MinGustAmount");
			MaxGustAmount__Offset=GetPropertyOffset(NativeClassPtr,"MaxGustAmount");
			Radius__Offset=GetPropertyOffset(NativeClassPtr,"Radius");
			bPointWind__Offset=GetPropertyOffset(NativeClassPtr,"bPointWind");
			
		}
		
	}
	
}
#endif
#endif
