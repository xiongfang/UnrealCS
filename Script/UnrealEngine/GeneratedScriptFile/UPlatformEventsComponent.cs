using System;
namespace UnrealEngine
{
	public partial class UPlatformEventsComponent:UActorComponent
	{
		/// <summary>
		/// Check whether the platform supports convertible laptops.
		/// Note: This does not necessarily mean that the platform is a convertible laptop.
		/// For example, convertible laptops running Windows 7 or older will return false,
		/// and regular laptops running Windows 8 or newer will return true.
		/// @return true for convertible laptop platforms, false otherwise.
		/// @see IsInLaptopMode, IsInTabletMode
		/// </summary>
		public extern bool SupportsConvertibleLaptops();
		/// <summary>
		/// Check whether a convertible laptop is laptop mode.
		/// @return true if in tablet mode, false otherwise or if not a convertible laptop.
		/// @see IsInLaptopMode, SupportsConvertibleLaptops
		/// </summary>
		public extern bool IsInTabletMode();
		/// <summary>
		/// Check whether a convertible laptop is laptop mode.
		/// @return true if in laptop mode, false otherwise or if not a convertible laptop.
		/// @see IsInTabletMode, SupportsConvertibleLaptops
		/// </summary>
		public extern bool IsInLaptopMode();
		
	}
	
}
