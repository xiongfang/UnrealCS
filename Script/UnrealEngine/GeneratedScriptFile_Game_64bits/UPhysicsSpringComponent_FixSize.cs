#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPhysicsSpringComponent
	{
		static readonly int SpringStiffness__Offset;
		public float SpringStiffness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpringStiffness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpringStiffness__Offset, false);}
			
		}
		
		static readonly int SpringDamping__Offset;
		public float SpringDamping
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpringDamping__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpringDamping__Offset, false);}
			
		}
		
		static readonly int SpringLengthAtRest__Offset;
		public float SpringLengthAtRest
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpringLengthAtRest__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpringLengthAtRest__Offset, false);}
			
		}
		
		static readonly int SpringRadius__Offset;
		public float SpringRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpringRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpringRadius__Offset, false);}
			
		}
		
		static readonly int SpringChannel__Offset;
		public ECollisionChannel SpringChannel
		{
			get{ CheckIsValid();return (ECollisionChannel)Marshal.PtrToStructure(_this.Get()+SpringChannel__Offset, typeof(ECollisionChannel));}
			
		}
		
		static readonly int bIgnoreSelf__Offset;
		public bool bIgnoreSelf
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreSelf__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreSelf__Offset, 1,0,1,255);}
			
		}
		
		static readonly int SpringCompression__Offset;
		public float SpringCompression
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpringCompression__Offset, typeof(float));}
			
		}
		
		static UPhysicsSpringComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PhysicsSpringComponent");
			SpringStiffness__Offset=GetPropertyOffset(NativeClassPtr,"SpringStiffness");
			SpringDamping__Offset=GetPropertyOffset(NativeClassPtr,"SpringDamping");
			SpringLengthAtRest__Offset=GetPropertyOffset(NativeClassPtr,"SpringLengthAtRest");
			SpringRadius__Offset=GetPropertyOffset(NativeClassPtr,"SpringRadius");
			SpringChannel__Offset=GetPropertyOffset(NativeClassPtr,"SpringChannel");
			bIgnoreSelf__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreSelf");
			SpringCompression__Offset=GetPropertyOffset(NativeClassPtr,"SpringCompression");
			
		}
		
	}
	
}
#endif
#endif
