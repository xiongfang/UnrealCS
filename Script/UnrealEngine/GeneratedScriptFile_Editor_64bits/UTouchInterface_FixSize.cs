#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Defines an interface by which touch input can be controlled using any number of buttons and virtual joysticks</summary>
	public partial class UTouchInterface
	{
		static readonly int Controls__Offset;
		public TStructArray<FTouchInputControl> Controls
		{
			get{ CheckIsValid();return new TStructArray<FTouchInputControl>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Controls__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Controls__Offset, false);}
			
		}
		
		static readonly int ActiveOpacity__Offset;
		/// <summary>Opacity (0.0 - 1.0) of all controls while any control is active</summary>
		public float ActiveOpacity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ActiveOpacity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ActiveOpacity__Offset, false);}
			
		}
		
		static readonly int InactiveOpacity__Offset;
		/// <summary>Opacity (0.0 - 1.0) of all controls while no controls are active</summary>
		public float InactiveOpacity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InactiveOpacity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InactiveOpacity__Offset, false);}
			
		}
		
		static readonly int TimeUntilDeactive__Offset;
		/// <summary>How long after user interaction will all controls fade out to Inactive Opacity</summary>
		public float TimeUntilDeactive
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TimeUntilDeactive__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TimeUntilDeactive__Offset, false);}
			
		}
		
		static readonly int TimeUntilReset__Offset;
		/// <summary>How long after going inactive will controls reset/recenter themselves (0.0 will disable this feature)</summary>
		public float TimeUntilReset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TimeUntilReset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TimeUntilReset__Offset, false);}
			
		}
		
		static readonly int ActivationDelay__Offset;
		/// <summary>How long after joystick enabled for touch (0.0 will disable this feature)</summary>
		public float ActivationDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ActivationDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ActivationDelay__Offset, false);}
			
		}
		
		static readonly int bPreventRecenter__Offset;
		/// <summary>Whether to prevent joystick re-center</summary>
		public bool bPreventRecenter
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPreventRecenter__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPreventRecenter__Offset, 1,0,1,255);}
			
		}
		
		static readonly int StartupDelay__Offset;
		/// <summary>Delay at startup before virtual joystick is drawn</summary>
		public float StartupDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StartupDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartupDelay__Offset, false);}
			
		}
		
		static UTouchInterface()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TouchInterface");
			Controls__Offset=GetPropertyOffset(NativeClassPtr,"Controls");
			ActiveOpacity__Offset=GetPropertyOffset(NativeClassPtr,"ActiveOpacity");
			InactiveOpacity__Offset=GetPropertyOffset(NativeClassPtr,"InactiveOpacity");
			TimeUntilDeactive__Offset=GetPropertyOffset(NativeClassPtr,"TimeUntilDeactive");
			TimeUntilReset__Offset=GetPropertyOffset(NativeClassPtr,"TimeUntilReset");
			ActivationDelay__Offset=GetPropertyOffset(NativeClassPtr,"ActivationDelay");
			bPreventRecenter__Offset=GetPropertyOffset(NativeClassPtr,"bPreventRecenter");
			StartupDelay__Offset=GetPropertyOffset(NativeClassPtr,"StartupDelay");
			
		}
		
	}
	
}
#endif
#endif
