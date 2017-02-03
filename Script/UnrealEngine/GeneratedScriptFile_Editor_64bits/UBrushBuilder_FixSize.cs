#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Base class of UnrealEd brush builders.
	/// Tips for writing brush builders:
	/// - Always validate the user-specified and call BadParameters function
	///   if anything is wrong, instead of actually building geometry.
	///   If you build an invalid brush due to bad user parameters, you'll
	///   cause an extraordinary amount of pain for the poor user.
	/// - When generating polygons with more than 3 vertices, BE SURE all the
	///   polygon's vertices are coplanar!  Out-of-plane polygons will cause
	///   geometry to be corrupted.
	/// </summary>
	public partial class UBrushBuilder
	{
		static readonly int BitmapFilename__Offset;
		public FString BitmapFilename
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+BitmapFilename__Offset, typeof(FString));}
			
		}
		
		static readonly int ToolTip__Offset;
		/// <summary>localized FString that will be displayed as the name of this brush builder in the editor</summary>
		public FString ToolTip
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+ToolTip__Offset, typeof(FString));}
			
		}
		
		static readonly int NotifyBadParams__Offset;
		/// <summary>If false, disabled the bad param notifications</summary>
		public bool NotifyBadParams
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), NotifyBadParams__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int Vertices__Offset;
		public TStructArray<FVector> Vertices
		{
			get{ CheckIsValid();return new TStructArray<FVector>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Vertices__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Vertices__Offset, false);}
			
		}
		
		static readonly int Polys__Offset;
		public TStructArray<FBuilderPoly> Polys
		{
			get{ CheckIsValid();return new TStructArray<FBuilderPoly>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Polys__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Polys__Offset, false);}
			
		}
		
		static readonly int Layer__Offset;
		public FName Layer
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+Layer__Offset, typeof(FName));}
			
		}
		
		static readonly int MergeCoplanars__Offset;
		public bool MergeCoplanars
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), MergeCoplanars__Offset, 1, 0, 1, 1);}
			
		}
		
		static UBrushBuilder()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BrushBuilder");
			BitmapFilename__Offset=GetPropertyOffset(NativeClassPtr,"BitmapFilename");
			ToolTip__Offset=GetPropertyOffset(NativeClassPtr,"ToolTip");
			NotifyBadParams__Offset=GetPropertyOffset(NativeClassPtr,"NotifyBadParams");
			Vertices__Offset=GetPropertyOffset(NativeClassPtr,"Vertices");
			Polys__Offset=GetPropertyOffset(NativeClassPtr,"Polys");
			Layer__Offset=GetPropertyOffset(NativeClassPtr,"Layer");
			MergeCoplanars__Offset=GetPropertyOffset(NativeClassPtr,"MergeCoplanars");
			
		}
		
	}
	
}
#endif
#endif
