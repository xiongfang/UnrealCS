#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Describes the standard transformation of a widget</summary>
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FWidgetTransform
	{
		/// <summary>The amount to translate the widget in slate units</summary>
		[FieldOffset(0)]
		public FVector2D Translation;
		/// <summary>The scale to apply to the widget</summary>
		[FieldOffset(8)]
		public FVector2D Scale;
		/// <summary>The amount to shear the widget in slate units</summary>
		[FieldOffset(16)]
		public FVector2D Shear;
		/// <summary>The angle in degrees to rotate</summary>
		[FieldOffset(24)]
		public float Angle;
		
	}
	
}
#endif
#endif
