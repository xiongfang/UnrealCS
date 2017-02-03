using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPawnNoiseEmitterComponent:UActorComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MakeNoise(IntPtr _this,IntPtr NoiseMaker,float Loudness,ref FVector NoiseLocation);
/// <summary>
/// Cache noises instigated by the owning pawn for AI sensing
/// @param NoiseMaker - is the actual actor which made the noise
/// @param Loudness - is the relative loudness of the noise (0.0 to 1.0)
/// @param NoiseLocation - is the position of the noise
/// </summary>
public  void MakeNoise(AActor NoiseMaker,float Loudness,FVector NoiseLocation)
{
	CheckIsValid();
	MakeNoise(_this.Get(),NoiseMaker,Loudness,ref NoiseLocation);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
