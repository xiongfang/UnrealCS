#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Allows thousands of items to be displayed in a list.  Generates widgets dynamically for each item.</summary>
	public partial class UListView
	{
		static readonly int ItemHeight__Offset;
		/// <summary>The height of each widget</summary>
		public float ItemHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ItemHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ItemHeight__Offset, false);}
			
		}
		
		static readonly int Items__Offset;
		/// <summary>The list of items to generate widgets for</summary>
		public TObjectArray<UObject>  Items
		{
					get{ CheckIsValid();return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Items__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Items__Offset, false);}
			
		}
		
		static readonly int SelectionMode__Offset;
		/// <summary>The selection method for the list</summary>
		public ESelectionMode SelectionMode
		{
			get{ CheckIsValid();return (ESelectionMode)Marshal.PtrToStructure(_this.Get()+SelectionMode__Offset, typeof(ESelectionMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SelectionMode__Offset, false);}
			
		}
		
		static UListView()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ListView");
			ItemHeight__Offset=GetPropertyOffset(NativeClassPtr,"ItemHeight");
			Items__Offset=GetPropertyOffset(NativeClassPtr,"Items");
			SelectionMode__Offset=GetPropertyOffset(NativeClassPtr,"SelectionMode");
			
		}
		
	}
	
}
#endif
#endif
