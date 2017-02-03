#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Set up and modify collision settings.</summary>
	public partial class UCollisionProfile
	{
		static readonly int Profiles__Offset;
		/// <summary>
		/// This is hacky, but without this edit tag, we can't get valid property handle
		/// and we can't save them properly to config, so we need this tag.
		/// </summary>
		public TStructArray<FCollisionResponseTemplate> Profiles
		{
			get{ CheckIsValid();return new TStructArray<FCollisionResponseTemplate>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Profiles__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Profiles__Offset, false);}
			
		}
		
		static readonly int DefaultChannelResponses__Offset;
		public TStructArray<FCustomChannelSetup> DefaultChannelResponses
		{
			get{ CheckIsValid();return new TStructArray<FCustomChannelSetup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DefaultChannelResponses__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DefaultChannelResponses__Offset, false);}
			
		}
		
		static readonly int EditProfiles__Offset;
		public TStructArray<FCustomProfile> EditProfiles
		{
			get{ CheckIsValid();return new TStructArray<FCustomProfile>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EditProfiles__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EditProfiles__Offset, false);}
			
		}
		
		static readonly int ProfileRedirects__Offset;
		public TStructArray<FRedirector> ProfileRedirects
		{
			get{ CheckIsValid();return new TStructArray<FRedirector>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ProfileRedirects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ProfileRedirects__Offset, false);}
			
		}
		
		static readonly int CollisionChannelRedirects__Offset;
		public TStructArray<FRedirector> CollisionChannelRedirects
		{
			get{ CheckIsValid();return new TStructArray<FRedirector>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CollisionChannelRedirects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CollisionChannelRedirects__Offset, false);}
			
		}
		
		static UCollisionProfile()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CollisionProfile");
			Profiles__Offset=GetPropertyOffset(NativeClassPtr,"Profiles");
			DefaultChannelResponses__Offset=GetPropertyOffset(NativeClassPtr,"DefaultChannelResponses");
			EditProfiles__Offset=GetPropertyOffset(NativeClassPtr,"EditProfiles");
			ProfileRedirects__Offset=GetPropertyOffset(NativeClassPtr,"ProfileRedirects");
			CollisionChannelRedirects__Offset=GetPropertyOffset(NativeClassPtr,"CollisionChannelRedirects");
			
		}
		
	}
	
}
#endif
#endif
