using System;
namespace UnrealEngine
{
	/// <summary>Describes the standard transformation of a widget</summary>
	public partial struct FWidgetTransform
	{
		/// <summary>The amount to translate the widget in slate units</summary>
		public FVector2D Translation;
		/// <summary>The scale to apply to the widget</summary>
		public FVector2D Scale;
		/// <summary>The amount to shear the widget in slate units</summary>
		public FVector2D Shear;
		/// <summary>The angle in degrees to rotate</summary>
		public float Angle;
		
	}
	
}
