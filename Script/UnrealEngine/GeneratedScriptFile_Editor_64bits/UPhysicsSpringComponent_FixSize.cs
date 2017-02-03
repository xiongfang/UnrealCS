#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Note: this component is still work in progress. Uses raycast springs for simple vehicle forces
	///    Used with objects that have physics to create a spring down the X direction
	///    ie. point X in the direction you want generate spring.
	/// </summary>
	public partial class UPhysicsSpringComponent
	{
		static readonly int SpringStiffness__Offset;
		/// <summary>Specifies how much strength the spring has. The higher the SpringStiffness the more force the spring can push on a body with.</summary>
		public float SpringStiffness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpringStiffness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpringStiffness__Offset, false);}
			
		}
		
		static readonly int SpringDamping__Offset;
		/// <summary>Specifies how quickly the spring can absorb energy of a body. The higher the damping the less oscillation</summary>
		public float SpringDamping
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpringDamping__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpringDamping__Offset, false);}
			
		}
		
		static readonly int SpringLengthAtRest__Offset;
		/// <summary>Determines how long the spring will be along the X-axis at rest. The spring will apply 0 force on a body when it's at rest.</summary>
		public float SpringLengthAtRest
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpringLengthAtRest__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpringLengthAtRest__Offset, false);}
			
		}
		
		static readonly int SpringRadius__Offset;
		/// <summary>Determines the radius of the spring.</summary>
		public float SpringRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpringRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpringRadius__Offset, false);}
			
		}
		
		static readonly int SpringChannel__Offset;
		/// <summary>Strength of thrust force applied to the base object.</summary>
		public ECollisionChannel SpringChannel
		{
			get{ CheckIsValid();return (ECollisionChannel)Marshal.PtrToStructure(_this.Get()+SpringChannel__Offset, typeof(ECollisionChannel));}
			
		}
		
		static readonly int bIgnoreSelf__Offset;
		/// <summary>If true, the spring will ignore all components in its own actor</summary>
		public bool bIgnoreSelf
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreSelf__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreSelf__Offset, 1,0,1,255);}
			
		}
		
		static readonly int SpringCompression__Offset;
		/// <summary>The current compression of the spring. A spring at rest will have SpringCompression 0.</summary>
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
