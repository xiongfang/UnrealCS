#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundSubmix
	{
		static readonly int ChildSubmixes__Offset;
		/// <summary>Child submixes to this sound mix</summary>
		public TObjectArray<USoundSubmix>  ChildSubmixes
		{
					get{ CheckIsValid();return new TObjectArray<USoundSubmix>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChildSubmixes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChildSubmixes__Offset, false);}
			
		}
		
		static readonly int ParentSubmix__Offset;
		public USoundSubmix ParentSubmix
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ParentSubmix__Offset); if (v == IntPtr.Zero)return null; USoundSubmix retValue = new USoundSubmix(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SubmixEffectChain__Offset;
		public TObjectArray<USoundEffectSubmixPreset>  SubmixEffectChain
		{
					get{ CheckIsValid();return new TObjectArray<USoundEffectSubmixPreset>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SubmixEffectChain__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SubmixEffectChain__Offset, false);}
			
		}
		
		static readonly int OutputWetLevel__Offset;
		/// <summary>The output wet level to use for the output of this submix in parent submixes</summary>
		public float OutputWetLevel
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OutputWetLevel__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OutputWetLevel__Offset, false);}
			
		}
		
		static USoundSubmix()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundSubmix");
			ChildSubmixes__Offset=GetPropertyOffset(NativeClassPtr,"ChildSubmixes");
			ParentSubmix__Offset=GetPropertyOffset(NativeClassPtr,"ParentSubmix");
			SubmixEffectChain__Offset=GetPropertyOffset(NativeClassPtr,"SubmixEffectChain");
			OutputWetLevel__Offset=GetPropertyOffset(NativeClassPtr,"OutputWetLevel");
			
		}
		
	}
	
}
#endif
#endif
