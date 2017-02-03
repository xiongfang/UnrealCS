#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A drawing canvas.</summary>
	public partial class UCanvas
	{
		static readonly int OrgX__Offset;
		/// <summary>Modifiable properties.</summary>
		public float OrgX
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OrgX__Offset, typeof(float));}
			
		}
		
		static readonly int OrgY__Offset;
		/// <summary>Origin for drawing in X.</summary>
		public float OrgY
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OrgY__Offset, typeof(float));}
			
		}
		
		static readonly int ClipX__Offset;
		/// <summary>Origin for drawing in Y.</summary>
		public float ClipX
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ClipX__Offset, typeof(float));}
			
		}
		
		static readonly int ClipY__Offset;
		/// <summary>Bottom right clipping region.</summary>
		public float ClipY
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ClipY__Offset, typeof(float));}
			
		}
		
		static readonly int DrawColor__Offset;
		/// <summary>Bottom right clipping region.</summary>
		public FColor DrawColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+DrawColor__Offset, typeof(FColor));}
			
		}
		
		static readonly int bCenterX__Offset;
		/// <summary>Color for drawing.</summary>
		public bool bCenterX
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCenterX__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bCenterY__Offset;
		/// <summary>Whether to center the text horizontally (about CurX)</summary>
		public bool bCenterY
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCenterY__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bNoSmooth__Offset;
		/// <summary>Whether to center the text vertically (about CurY)</summary>
		public bool bNoSmooth
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNoSmooth__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int SizeX__Offset;
		/// <summary>Don't bilinear filter.</summary>
		public int SizeX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SizeX__Offset, typeof(int));}
			
		}
		
		static readonly int SizeY__Offset;
		/// <summary>Zero-based actual dimensions X.</summary>
		public int SizeY
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SizeY__Offset, typeof(int));}
			
		}
		
		static readonly int ColorModulate__Offset;
		/// <summary>Internal.</summary>
		public FPlane ColorModulate
		{
			get{ CheckIsValid();return (FPlane)Marshal.PtrToStructure(_this.Get()+ColorModulate__Offset, typeof(FPlane));}
			
		}
		
		static readonly int DefaultTexture__Offset;
		public UTexture2D DefaultTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int GradientTexture0__Offset;
		/// <summary>Default texture to use</summary>
		public UTexture2D GradientTexture0
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GradientTexture0__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ReporterGraph__Offset;
		/// <summary>Helper class to render 2d graphs on canvas</summary>
		public UReporterGraph ReporterGraph
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ReporterGraph__Offset); if (v == IntPtr.Zero)return null; UReporterGraph retValue = new UReporterGraph(); retValue._this = v; return retValue; }
			
		}
		
		static UCanvas()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Canvas");
			OrgX__Offset=GetPropertyOffset(NativeClassPtr,"OrgX");
			OrgY__Offset=GetPropertyOffset(NativeClassPtr,"OrgY");
			ClipX__Offset=GetPropertyOffset(NativeClassPtr,"ClipX");
			ClipY__Offset=GetPropertyOffset(NativeClassPtr,"ClipY");
			DrawColor__Offset=GetPropertyOffset(NativeClassPtr,"DrawColor");
			bCenterX__Offset=GetPropertyOffset(NativeClassPtr,"bCenterX");
			bCenterY__Offset=GetPropertyOffset(NativeClassPtr,"bCenterY");
			bNoSmooth__Offset=GetPropertyOffset(NativeClassPtr,"bNoSmooth");
			SizeX__Offset=GetPropertyOffset(NativeClassPtr,"SizeX");
			SizeY__Offset=GetPropertyOffset(NativeClassPtr,"SizeY");
			ColorModulate__Offset=GetPropertyOffset(NativeClassPtr,"ColorModulate");
			DefaultTexture__Offset=GetPropertyOffset(NativeClassPtr,"DefaultTexture");
			GradientTexture0__Offset=GetPropertyOffset(NativeClassPtr,"GradientTexture0");
			ReporterGraph__Offset=GetPropertyOffset(NativeClassPtr,"ReporterGraph");
			
		}
		
	}
	
}
#endif
#endif
