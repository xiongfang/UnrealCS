#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundClass
	{
		static readonly int Properties__Offset;
		/// <summary>Configurable properties like volume and priority.</summary>
		public FSoundClassProperties Properties
		{
			get{ CheckIsValid();return (FSoundClassProperties)Marshal.PtrToStructure(_this.Get()+Properties__Offset, typeof(FSoundClassProperties));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Properties__Offset, false);}
			
		}
		
		static readonly int ChildClasses__Offset;
		public TObjectArray<USoundClass>  ChildClasses
		{
					get{ CheckIsValid();return new TObjectArray<USoundClass>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChildClasses__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChildClasses__Offset, false);}
			
		}
		
		static readonly int PassiveSoundMixModifiers__Offset;
		/// <summary>SoundMix Modifiers to activate automatically when a sound of this class is playing.</summary>
		public TStructArray<FPassiveSoundMixModifier> PassiveSoundMixModifiers
		{
			get{ CheckIsValid();return new TStructArray<FPassiveSoundMixModifier>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PassiveSoundMixModifiers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PassiveSoundMixModifiers__Offset, false);}
			
		}
		
		static readonly int ParentClass__Offset;
		public USoundClass ParentClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ParentClass__Offset); if (v == IntPtr.Zero)return null; USoundClass retValue = new USoundClass(); retValue._this = v; return retValue; }
			
		}
		
		static USoundClass()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundClass");
			Properties__Offset=GetPropertyOffset(NativeClassPtr,"Properties");
			ChildClasses__Offset=GetPropertyOffset(NativeClassPtr,"ChildClasses");
			PassiveSoundMixModifiers__Offset=GetPropertyOffset(NativeClassPtr,"PassiveSoundMixModifiers");
			ParentClass__Offset=GetPropertyOffset(NativeClassPtr,"ParentClass");
			
		}
		
	}
	
}
#endif
#endif
