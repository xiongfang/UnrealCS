#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UWidgetAnimation
	{
		static readonly int OnAnimationStarted__Offset;
		/// <summary>Fires when the widget animation starts playing.</summary>
		public FMulticastScriptDelegate OnAnimationStarted
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnAnimationStarted__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnAnimationStarted__Offset, false);}
			
		}
		
		static readonly int OnAnimationFinished__Offset;
		/// <summary>Fires when the widget animation is finished.</summary>
		public FMulticastScriptDelegate OnAnimationFinished
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnAnimationFinished__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnAnimationFinished__Offset, false);}
			
		}
		
		static readonly int MovieScene__Offset;
		/// <summary>Pointer to the movie scene that controls this animation.</summary>
		public UMovieScene MovieScene
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MovieScene__Offset); if (v == IntPtr.Zero)return null; UMovieScene retValue = new UMovieScene(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AnimationBindings__Offset;
		public TStructArray<FWidgetAnimationBinding> AnimationBindings
		{
			get{ CheckIsValid();return new TStructArray<FWidgetAnimationBinding>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AnimationBindings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AnimationBindings__Offset, false);}
			
		}
		
		static UWidgetAnimation()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WidgetAnimation");
			OnAnimationStarted__Offset=GetPropertyOffset(NativeClassPtr,"OnAnimationStarted");
			OnAnimationFinished__Offset=GetPropertyOffset(NativeClassPtr,"OnAnimationFinished");
			MovieScene__Offset=GetPropertyOffset(NativeClassPtr,"MovieScene");
			AnimationBindings__Offset=GetPropertyOffset(NativeClassPtr,"AnimationBindings");
			
		}
		
	}
	
}
#endif
#endif
