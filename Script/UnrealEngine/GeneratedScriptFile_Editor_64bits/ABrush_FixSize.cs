#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ABrush
	{
		static readonly int BrushType__Offset;
		/// <summary>Type of brush</summary>
		public EBrushType BrushType
		{
			get{ CheckIsValid();return (EBrushType)Marshal.PtrToStructure(_this.Get()+BrushType__Offset, typeof(EBrushType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrushType__Offset, false);}
			
		}
		
		static readonly int BrushColor__Offset;
		/// <summary>Information.</summary>
		public FColor BrushColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+BrushColor__Offset, typeof(FColor));}
			
		}
		
		static readonly int PolyFlags__Offset;
		public int PolyFlags
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PolyFlags__Offset, typeof(int));}
			
		}
		
		static readonly int bColored__Offset;
		public bool bColored
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bColored__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bSolidWhenSelected__Offset;
		public bool bSolidWhenSelected
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSolidWhenSelected__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bPlaceableFromClassBrowser__Offset;
		/// <summary>If true, this brush class can be placed using the class browser like other simple class types</summary>
		public bool bPlaceableFromClassBrowser
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPlaceableFromClassBrowser__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bNotForClientOrServer__Offset;
		/// <summary>If true, this brush is a builder or otherwise does not need to be loaded into the game</summary>
		public bool bNotForClientOrServer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNotForClientOrServer__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int Brush__Offset;
		public UModel Brush
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Brush__Offset); if (v == IntPtr.Zero)return null; UModel retValue = new UModel(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BrushComponent__Offset;
		public UBrushComponent BrushComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BrushComponent__Offset); if (v == IntPtr.Zero)return null; UBrushComponent retValue = new UBrushComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + BrushComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + BrushComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int BrushBuilder__Offset;
		public UBrushBuilder BrushBuilder
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BrushBuilder__Offset); if (v == IntPtr.Zero)return null; UBrushBuilder retValue = new UBrushBuilder(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + BrushBuilder__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + BrushBuilder__Offset, value._this.Get()); }
			
		}
		
		static readonly int bInManipulation__Offset;
		/// <summary>Flag set when we are in a manipulation (scaling, translation, brush builder param change etc.)</summary>
		public bool bInManipulation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInManipulation__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int SavedSelections__Offset;
		/// <summary>
		/// Stores selection information from geometry mode.  This is the only information that we can't
		/// regenerate by looking at the source brushes following an undo operation.
		/// </summary>
		public TStructArray<FGeomSelection> SavedSelections
		{
			get{ CheckIsValid();return new TStructArray<FGeomSelection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SavedSelections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SavedSelections__Offset, false);}
			
		}
		
		static ABrush()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Brush");
			BrushType__Offset=GetPropertyOffset(NativeClassPtr,"BrushType");
			BrushColor__Offset=GetPropertyOffset(NativeClassPtr,"BrushColor");
			PolyFlags__Offset=GetPropertyOffset(NativeClassPtr,"PolyFlags");
			bColored__Offset=GetPropertyOffset(NativeClassPtr,"bColored");
			bSolidWhenSelected__Offset=GetPropertyOffset(NativeClassPtr,"bSolidWhenSelected");
			bPlaceableFromClassBrowser__Offset=GetPropertyOffset(NativeClassPtr,"bPlaceableFromClassBrowser");
			bNotForClientOrServer__Offset=GetPropertyOffset(NativeClassPtr,"bNotForClientOrServer");
			Brush__Offset=GetPropertyOffset(NativeClassPtr,"Brush");
			BrushComponent__Offset=GetPropertyOffset(NativeClassPtr,"BrushComponent");
			BrushBuilder__Offset=GetPropertyOffset(NativeClassPtr,"BrushBuilder");
			bInManipulation__Offset=GetPropertyOffset(NativeClassPtr,"bInManipulation");
			SavedSelections__Offset=GetPropertyOffset(NativeClassPtr,"SavedSelections");
			
		}
		
	}
	
}
#endif
#endif
