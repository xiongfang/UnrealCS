#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Utility component for drawing a view frustum. Origin is at the component location, frustum points down position X axis.</summary>
	public partial class UDrawFrustumComponent
	{
		static readonly int FrustumColor__Offset;
		/// <summary>Color to draw the wireframe frustum.</summary>
		public FColor FrustumColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+FrustumColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FrustumColor__Offset, false);}
			
		}
		
		static readonly int FrustumAngle__Offset;
		/// <summary>
		/// Angle of longest dimension of view shape.
		/// If the angle is 0 then an orthographic projection is used
		/// </summary>
		public float FrustumAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FrustumAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FrustumAngle__Offset, false);}
			
		}
		
		static readonly int FrustumAspectRatio__Offset;
		/// <summary>Ratio of horizontal size over vertical size.</summary>
		public float FrustumAspectRatio
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FrustumAspectRatio__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FrustumAspectRatio__Offset, false);}
			
		}
		
		static readonly int FrustumStartDist__Offset;
		/// <summary>Distance from origin to start drawing the frustum.</summary>
		public float FrustumStartDist
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FrustumStartDist__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FrustumStartDist__Offset, false);}
			
		}
		
		static readonly int FrustumEndDist__Offset;
		/// <summary>Distance from origin to stop drawing the frustum.</summary>
		public float FrustumEndDist
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FrustumEndDist__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FrustumEndDist__Offset, false);}
			
		}
		
		static readonly int Texture__Offset;
		/// <summary>optional texture to show on the near plane</summary>
		public UTexture Texture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Texture__Offset); if (v == IntPtr.Zero)return null; UTexture retValue = new UTexture(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Texture__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Texture__Offset, value._this.Get()); }
			
		}
		
		static UDrawFrustumComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DrawFrustumComponent");
			FrustumColor__Offset=GetPropertyOffset(NativeClassPtr,"FrustumColor");
			FrustumAngle__Offset=GetPropertyOffset(NativeClassPtr,"FrustumAngle");
			FrustumAspectRatio__Offset=GetPropertyOffset(NativeClassPtr,"FrustumAspectRatio");
			FrustumStartDist__Offset=GetPropertyOffset(NativeClassPtr,"FrustumStartDist");
			FrustumEndDist__Offset=GetPropertyOffset(NativeClassPtr,"FrustumEndDist");
			Texture__Offset=GetPropertyOffset(NativeClassPtr,"Texture");
			
		}
		
	}
	
}
#endif
#endif
