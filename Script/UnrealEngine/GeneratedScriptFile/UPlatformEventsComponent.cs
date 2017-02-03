using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPlatformEventsComponent:UActorComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SupportsConvertibleLaptops(IntPtr _this);
/// <summary>
/// Check whether the platform supports convertible laptops.
/// Note: This does not necessarily mean that the platform is a convertible laptop.
/// For example, convertible laptops running Windows 7 or older will return false,
/// and regular laptops running Windows 8 or newer will return true.
/// @return true for convertible laptop platforms, false otherwise.
/// @see IsInLaptopMode, IsInTabletMode
/// </summary>
public  bool SupportsConvertibleLaptops()
{
	CheckIsValid();
	int ___ret = SupportsConvertibleLaptops(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsInTabletMode(IntPtr _this);
/// <summary>
/// Check whether a convertible laptop is laptop mode.
/// @return true if in tablet mode, false otherwise or if not a convertible laptop.
/// @see IsInLaptopMode, SupportsConvertibleLaptops
/// </summary>
public  bool IsInTabletMode()
{
	CheckIsValid();
	int ___ret = IsInTabletMode(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsInLaptopMode(IntPtr _this);
/// <summary>
/// Check whether a convertible laptop is laptop mode.
/// @return true if in laptop mode, false otherwise or if not a convertible laptop.
/// @see IsInTabletMode, SupportsConvertibleLaptops
/// </summary>
public  bool IsInLaptopMode()
{
	CheckIsValid();
	int ___ret = IsInLaptopMode(_this.Get());
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
