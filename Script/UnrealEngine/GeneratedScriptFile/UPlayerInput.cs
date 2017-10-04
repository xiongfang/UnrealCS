using System;
namespace UnrealEngine
{
	public partial class UPlayerInput:UObject
	{
		/// <summary>Exec function to reset mouse smoothing values</summary>
		public extern void ClearSmoothing();
		/// <summary>Exec function to invert an axis mapping</summary>
		public extern void InvertAxis(FName AxisName);
		/// <summary>Exec function to invert an axis key</summary>
		public extern void InvertAxisKey(FKey AxisKey);
		/// <summary>Exec function to add a debug exec command</summary>
		public extern void SetBind(FName BindName,FString Command);
		/// <summary>Exec function to change the mouse sensitivity</summary>
		public extern void SetMouseSensitivity(float Sensitivity);
		
	}
	
}
