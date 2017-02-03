#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDeviceProfile
	{
		static readonly int DeviceType__Offset;
		/// <summary>The type of this profile, I.e. IOS, Windows, PS4 etc</summary>
		public FString DeviceType
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+DeviceType__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DeviceType__Offset, false);}
			
		}
		
		static readonly int BaseProfileName__Offset;
		/// <summary>The name of the parent profile of this object</summary>
		public FString BaseProfileName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+BaseProfileName__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BaseProfileName__Offset, false);}
			
		}
		
		static readonly int Parent__Offset;
		/// <summary>The parent object of this profile, it is the object matching this DeviceType with the BaseProfileName</summary>
		public UObject Parent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Parent__Offset); if (v == IntPtr.Zero)return null; UObject retValue = new UObject(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CVars__Offset;
		/// <summary>The collection of CVars which is set from this profile</summary>
		public TStructArray<FString> CVars
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CVars__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CVars__Offset, false);}
			
		}
		
		static UDeviceProfile()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DeviceProfile");
			DeviceType__Offset=GetPropertyOffset(NativeClassPtr,"DeviceType");
			BaseProfileName__Offset=GetPropertyOffset(NativeClassPtr,"BaseProfileName");
			Parent__Offset=GetPropertyOffset(NativeClassPtr,"Parent");
			CVars__Offset=GetPropertyOffset(NativeClassPtr,"CVars");
			
		}
		
	}
	
}
#endif
#endif
