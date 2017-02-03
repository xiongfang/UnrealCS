#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// The Retainer Box renders children widgets to a render target first before
	/// later rendering that render target to the screen.  This allows both frequency
	/// and phase to be controlled so that the UI can actually render less often than the
	/// frequency of the main game render.  It also has the side benefit of allow materials
	/// to be applied to the render target after drawing the widgets to apply a simple post process.
	/// * Single Child
	/// * Caching / Performance
	/// </summary>
	public partial class URetainerBox
	{
		static readonly int Phase__Offset;
		/// <summary>
		/// The Phase this widget will draw on.
		/// If the Phase is 0, and the PhaseCount is 1, the widget will be drawn fresh every frame.
		/// If the Phase were 0, and the PhaseCount were 2, this retainer would draw a fresh frame every
		/// other frame.  So in a 60Hz game, the UI would render at 30Hz.
		/// </summary>
		public int Phase
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Phase__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Phase__Offset, false);}
			
		}
		
		static readonly int PhaseCount__Offset;
		/// <summary>
		/// The PhaseCount controls how many phases are possible know what to modulus the current frame
		/// count by to determine if this is the current frame to draw the widget on.
		/// If the Phase is 0, and the PhaseCount is 1, the widget will be drawn fresh every frame.
		/// If the Phase were 0, and the PhaseCount were 2, this retainer would draw a fresh frame every
		/// other frame.  So in a 60Hz game, the UI would render at 30Hz.
		/// </summary>
		public int PhaseCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PhaseCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PhaseCount__Offset, false);}
			
		}
		
		static readonly int EffectMaterial__Offset;
		/// <summary>
		/// The effect to optionally apply to the render target.  We will set the texture sampler based on the name
		/// set in the @TextureParameter property.
		/// If you want to adjust transparency of the final image, make sure you set Blend Mode to AlphaComposite (Pre-Multiplied Alpha)
		/// and make sure to multiply the alpha you're apply across the surface to the color and the alpha of the render target, otherwise
		/// you won't see the expected color.
		/// </summary>
		public UMaterialInterface EffectMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + EffectMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + EffectMaterial__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + EffectMaterial__Offset, value._this.Get()); }
			
		}
		
		static readonly int TextureParameter__Offset;
		/// <summary>The texture sampler parameter of the @EffectMaterial, that we'll set to the render target.</summary>
		public FName TextureParameter
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+TextureParameter__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TextureParameter__Offset, false);}
			
		}
		
		static URetainerBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("RetainerBox");
			Phase__Offset=GetPropertyOffset(NativeClassPtr,"Phase");
			PhaseCount__Offset=GetPropertyOffset(NativeClassPtr,"PhaseCount");
			EffectMaterial__Offset=GetPropertyOffset(NativeClassPtr,"EffectMaterial");
			TextureParameter__Offset=GetPropertyOffset(NativeClassPtr,"TextureParameter");
			
		}
		
	}
	
}
#endif
#endif
