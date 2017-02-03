using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetMathLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int LinePlaneIntersection_OriginNormal(IntPtr _this,ref FVector LineStart,ref FVector LineEnd,ref FVector PlaneOrigin,ref FVector PlaneNormal,out float T,out FVector Intersection);
/// <summary>
/// Computes the intersection point between a line and a plane.
/// @param               T - The t of the intersection between the line and the plane
/// @param               Intersection - The point of intersection between the line and the plane
/// @return              True if the intersection test was successful.
/// </summary>
public static bool LinePlaneIntersection_OriginNormal(FVector LineStart,FVector LineEnd,FVector PlaneOrigin,FVector PlaneNormal,out float T,out FVector Intersection)
{
	int ___ret = LinePlaneIntersection_OriginNormal(IntPtr.Zero,ref LineStart,ref LineEnd,ref PlaneOrigin,ref PlaneNormal,out T,out Intersection);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int LinePlaneIntersection(IntPtr _this,ref FVector LineStart,ref FVector LineEnd,ref FPlane APlane,out float T,out FVector Intersection);
/// <summary>
/// Computes the intersection point between a line and a plane.
/// @param               T - The t of the intersection between the line and the plane
/// @param               Intersection - The point of intersection between the line and the plane
/// @return              True if the intersection test was successful.
/// </summary>
public static bool LinePlaneIntersection(FVector LineStart,FVector LineEnd,FPlane APlane,out float T,out FVector Intersection)
{
	int ___ret = LinePlaneIntersection(IntPtr.Zero,ref LineStart,ref LineEnd,ref APlane,out T,out Intersection);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int PointsAreCoplanar(IntPtr _this,FVector[] Points,float Tolerance);
/// <summary>
/// Determines whether a given set of points are coplanar, with a tolerance. Any three points or less are always coplanar.
/// @param Points - The set of points to determine coplanarity for.
/// @param Tolerance - Larger numbers means more variance is allowed.
/// @return Whether the points are relatively coplanar, based on the tolerance
/// </summary>
public static bool PointsAreCoplanar(FVector[] Points,float Tolerance=0.100000f)
{
	int ___ret = PointsAreCoplanar(IntPtr.Zero,Points,Tolerance);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MinimumAreaRectangle(IntPtr _this,IntPtr WorldContextObject,FVector[] InVerts,ref FVector SampleSurfaceNormal,out FVector OutRectCenter,out FRotator OutRectRotation,out float OutSideLengthX,out float OutSideLengthY,int bDebugDraw);
/// <summary>
/// Finds the minimum area rectangle that encloses all of the points in InVerts
/// Uses algorithm found in http://www.geometrictools.com/Documentation/MinimumAreaRectangle.pdf
/// @param               InVerts - Points to enclose in the rectangle
/// @outparam    OutRectCenter - Center of the enclosing rectangle
/// @outparam    OutRectSideA - Vector oriented and sized to represent one edge of the enclosing rectangle, orthogonal to OutRectSideB
/// @outparam    OutRectSideB - Vector oriented and sized to represent one edge of the enclosing rectangle, orthogonal to OutRectSideA
/// </summary>
public static void MinimumAreaRectangle(UObject WorldContextObject,FVector[] InVerts,FVector SampleSurfaceNormal,out FVector OutRectCenter,out FRotator OutRectRotation,out float OutSideLengthX,out float OutSideLengthY,bool bDebugDraw=false)
{
	MinimumAreaRectangle(IntPtr.Zero,WorldContextObject,InVerts,ref SampleSurfaceNormal,out OutRectCenter,out OutRectRotation,out OutSideLengthX,out OutSideLengthY,bDebugDraw?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRandomStreamSeed(IntPtr _this,out FRandomStream Stream,int NewSeed);
/// <summary>Set the seed of a random stream to a specific number</summary>
public static void SetRandomStreamSeed(out FRandomStream Stream,int NewSeed)
{
	SetRandomStreamSeed(IntPtr.Zero,out Stream,NewSeed);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SeedRandomStream(IntPtr _this,out FRandomStream Stream);
/// <summary>Create a new random seed for a random stream</summary>
public static void SeedRandomStream(out FRandomStream Stream)
{
	SeedRandomStream(IntPtr.Zero,out Stream);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetRandomStream(IntPtr _this,ref FRandomStream Stream);
/// <summary>Reset a random stream</summary>
public static void ResetRandomStream(FRandomStream Stream)
{
	ResetRandomStream(IntPtr.Zero,ref Stream);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator RandomRotatorFromStream(IntPtr _this,int bRoll,ref FRandomStream Stream);
/// <summary>Create a random rotation</summary>
public static FRotator RandomRotatorFromStream(bool bRoll,FRandomStream Stream)
{
	FRotator ___ret = RandomRotatorFromStream(IntPtr.Zero,bRoll?1:0,ref Stream);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector RandomUnitVectorFromStream(IntPtr _this,ref FRandomStream Stream);
/// <summary>Returns a random vector with length of 1.0</summary>
public static FVector RandomUnitVectorFromStream(FRandomStream Stream)
{
	FVector ___ret = RandomUnitVectorFromStream(IntPtr.Zero,ref Stream);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float RandomFloatInRangeFromStream(IntPtr _this,float Min,float Max,ref FRandomStream Stream);
/// <summary>Generate a random number between Min and Max</summary>
public static float RandomFloatInRangeFromStream(float Min,float Max,FRandomStream Stream)
{
	float ___ret = RandomFloatInRangeFromStream(IntPtr.Zero,Min,Max,ref Stream);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float RandomFloatFromStream(IntPtr _this,ref FRandomStream Stream);
/// <summary>Returns a random float between 0 and 1</summary>
public static float RandomFloatFromStream(FRandomStream Stream)
{
	float ___ret = RandomFloatFromStream(IntPtr.Zero,ref Stream);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RandomBoolFromStream(IntPtr _this,ref FRandomStream Stream);
/// <summary>Returns a random bool</summary>
public static bool RandomBoolFromStream(FRandomStream Stream)
{
	int ___ret = RandomBoolFromStream(IntPtr.Zero,ref Stream);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RandomIntegerInRangeFromStream(IntPtr _this,int Min,int Max,ref FRandomStream Stream);
/// <summary>Return a random integer between Min and Max (>= Min and <= Max)</summary>
public static int RandomIntegerInRangeFromStream(int Min,int Max,FRandomStream Stream)
{
	int ___ret = RandomIntegerInRangeFromStream(IntPtr.Zero,Min,Max,ref Stream);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RandomIntegerFromStream(IntPtr _this,int Max,ref FRandomStream Stream);
/// <summary>Returns a uniformly distributed random number between 0 and Max - 1</summary>
public static int RandomIntegerFromStream(int Max,FRandomStream Stream)
{
	int ___ret = RandomIntegerFromStream(IntPtr.Zero,Max,ref Stream);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetVectorSpringState(IntPtr _this,out FVectorSpringState SpringState);
/// <summary>Resets the state of a given spring</summary>
public static void ResetVectorSpringState(out FVectorSpringState SpringState)
{
	ResetVectorSpringState(IntPtr.Zero,out SpringState);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetFloatSpringState(IntPtr _this,out FFloatSpringState SpringState);
/// <summary>Resets the state of a given spring</summary>
public static void ResetFloatSpringState(out FFloatSpringState SpringState)
{
	ResetFloatSpringState(IntPtr.Zero,out SpringState);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector VectorSpringInterp(IntPtr _this,ref FVector Current,ref FVector Target,out FVectorSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass);
/// <summary>
/// Uses a simple spring model to interpolate a vector from Current to Target.
/// @param Current                                Current value
/// @param Target                                 Target value
/// @param SpringState                    Data related to spring model (velocity, error, etc..) - Create a unique variable per spring
/// @param Stiffness                              How stiff the spring model is (more stiffness means more oscillation around the target value)
/// @param CriticalDampingFactor  How much damping to apply to the spring (0 means no damping, 1 means critically damped which means no oscillation)
/// @param Mass                                   Multiplier that acts like mass on a spring
/// </summary>
public static FVector VectorSpringInterp(FVector Current,FVector Target,out FVectorSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass=1.000000f)
{
	FVector ___ret = VectorSpringInterp(IntPtr.Zero,ref Current,ref Target,out SpringState,Stiffness,CriticalDampingFactor,DeltaTime,Mass);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float FloatSpringInterp(IntPtr _this,float Current,float Target,out FFloatSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass);
/// <summary>
/// Uses a simple spring model to interpolate a float from Current to Target.
/// @param Current                               Current value
/// @param Target                                Target value
/// @param SpringState                   Data related to spring model (velocity, error, etc..) - Create a unique variable per spring
/// @param Stiffness                             How stiff the spring model is (more stiffness means more oscillation around the target value)
/// @param CriticalDampingFactor How much damping to apply to the spring (0 means no damping, 1 means critically damped which means no oscillation)
/// @param Mass                                  Multiplier that acts like mass on a spring
/// </summary>
public static float FloatSpringInterp(float Current,float Target,out FFloatSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass=1.000000f)
{
	float ___ret = FloatSpringInterp(IntPtr.Zero,Current,Target,out SpringState,Stiffness,CriticalDampingFactor,DeltaTime,Mass);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FLinearColor CInterpTo(IntPtr _this,ref FLinearColor Current,ref FLinearColor Target,float DeltaTime,float InterpSpeed);
/// <summary>
/// Interpolates towards a varying target color smoothly.
/// @param               Current                 Current Color
/// @param               Target                  Target Color
/// @param               DeltaTime               Time since last tick
/// @param               InterpSpeed             Interpolation speed
/// @return              New interpolated Color
/// </summary>
public static FLinearColor CInterpTo(FLinearColor Current,FLinearColor Target,float DeltaTime,float InterpSpeed)
{
	FLinearColor ___ret = CInterpTo(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator RInterpTo_Constant(IntPtr _this,ref FRotator Current,ref FRotator Target,float DeltaTime,float InterpSpeed);
/// <summary>
/// Tries to reach Target rotation at a constant rate.
/// @param               Current                 Actual rotation
/// @param               Target                  Target rotation
/// @param               DeltaTime               Time since last tick
/// @param               InterpSpeed             Interpolation speed
/// @return              New interpolated position
/// </summary>
public static FRotator RInterpTo_Constant(FRotator Current,FRotator Target,float DeltaTime,float InterpSpeed)
{
	FRotator ___ret = RInterpTo_Constant(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator RInterpTo(IntPtr _this,ref FRotator Current,ref FRotator Target,float DeltaTime,float InterpSpeed);
/// <summary>
/// Tries to reach Target rotation based on Current rotation, giving a nice smooth feeling when rotating to Target rotation.
/// @param               Current                 Actual rotation
/// @param               Target                  Target rotation
/// @param               DeltaTime               Time since last tick
/// @param               InterpSpeed             Interpolation speed
/// @return              New interpolated position
/// </summary>
public static FRotator RInterpTo(FRotator Current,FRotator Target,float DeltaTime,float InterpSpeed)
{
	FRotator ___ret = RInterpTo(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D Vector2DInterpTo_Constant(IntPtr _this,ref FVector2D Current,ref FVector2D Target,float DeltaTime,float InterpSpeed);
/// <summary>
/// Tries to reach Target at a constant rate.
/// @param               Current                 Actual position
/// @param               Target                  Target position
/// @param               DeltaTime               Time since last tick
/// @param               InterpSpeed             Interpolation speed
/// @return              New interpolated position
/// </summary>
public static FVector2D Vector2DInterpTo_Constant(FVector2D Current,FVector2D Target,float DeltaTime,float InterpSpeed)
{
	FVector2D ___ret = Vector2DInterpTo_Constant(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D Vector2DInterpTo(IntPtr _this,ref FVector2D Current,ref FVector2D Target,float DeltaTime,float InterpSpeed);
/// <summary>
/// Tries to reach Target based on distance from Current position, giving a nice smooth feeling when tracking a position.
/// @param               Current                 Actual position
/// @param               Target                  Target position
/// @param               DeltaTime               Time since last tick
/// @param               InterpSpeed             Interpolation speed
/// @return              New interpolated position
/// </summary>
public static FVector2D Vector2DInterpTo(FVector2D Current,FVector2D Target,float DeltaTime,float InterpSpeed)
{
	FVector2D ___ret = Vector2DInterpTo(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector VInterpTo_Constant(IntPtr _this,ref FVector Current,ref FVector Target,float DeltaTime,float InterpSpeed);
/// <summary>
/// Tries to reach Target at a constant rate.
/// @param               Current                 Actual position
/// @param               Target                  Target position
/// @param               DeltaTime               Time since last tick
/// @param               InterpSpeed             Interpolation speed
/// @return              New interpolated position
/// </summary>
public static FVector VInterpTo_Constant(FVector Current,FVector Target,float DeltaTime,float InterpSpeed)
{
	FVector ___ret = VInterpTo_Constant(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector VInterpTo(IntPtr _this,ref FVector Current,ref FVector Target,float DeltaTime,float InterpSpeed);
/// <summary>
/// Tries to reach Target based on distance from Current position, giving a nice smooth feeling when tracking a position.
/// @param               Current                 Actual position
/// @param               Target                  Target position
/// @param               DeltaTime               Time since last tick
/// @param               InterpSpeed             Interpolation speed
/// @return              New interpolated position
/// </summary>
public static FVector VInterpTo(FVector Current,FVector Target,float DeltaTime,float InterpSpeed)
{
	FVector ___ret = VInterpTo(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float FInterpTo_Constant(IntPtr _this,float Current,float Target,float DeltaTime,float InterpSpeed);
/// <summary>
/// Tries to reach Target at a constant rate.
/// @param               Current                 Actual position
/// @param               Target                  Target position
/// @param               DeltaTime               Time since last tick
/// @param               InterpSpeed             Interpolation speed
/// @return              New interpolated position
/// </summary>
public static float FInterpTo_Constant(float Current,float Target,float DeltaTime,float InterpSpeed)
{
	float ___ret = FInterpTo_Constant(IntPtr.Zero,Current,Target,DeltaTime,InterpSpeed);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float FInterpTo(IntPtr _this,float Current,float Target,float DeltaTime,float InterpSpeed);
/// <summary>
/// Tries to reach Target based on distance from Current position, giving a nice smooth feeling when tracking a position.
/// @param               Current                 Actual position
/// @param               Target                  Target position
/// @param               DeltaTime               Time since last tick
/// @param               InterpSpeed             Interpolation speed
/// @return              New interpolated position
/// </summary>
public static float FInterpTo(float Current,float Target,float DeltaTime,float InterpSpeed)
{
	float ___ret = FInterpTo(IntPtr.Zero,Current,Target,DeltaTime,InterpSpeed);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_Vector2DVector2D(IntPtr _this,ref FVector2D A,ref FVector2D B,float ErrorTolerance);
/// <summary>Returns true if vector2D A is not equal to vector2D B (A != B) within a specified error tolerance</summary>
public static bool NotEqual_Vector2DVector2D(FVector2D A,FVector2D B,float ErrorTolerance=0.000100f)
{
	int ___ret = NotEqual_Vector2DVector2D(IntPtr.Zero,ref A,ref B,ErrorTolerance);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_Vector2DVector2D(IntPtr _this,ref FVector2D A,ref FVector2D B,float ErrorTolerance);
/// <summary>Returns true if vector2D A is equal to vector2D B (A == B) within a specified error tolerance</summary>
public static bool EqualEqual_Vector2DVector2D(FVector2D A,FVector2D B,float ErrorTolerance=0.000100f)
{
	int ___ret = EqualEqual_Vector2DVector2D(IntPtr.Zero,ref A,ref B,ErrorTolerance);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D Subtract_Vector2DFloat(IntPtr _this,ref FVector2D A,float B);
/// <summary>Returns Vector A subtracted by B</summary>
public static FVector2D Subtract_Vector2DFloat(FVector2D A,float B)
{
	FVector2D ___ret = Subtract_Vector2DFloat(IntPtr.Zero,ref A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D Add_Vector2DFloat(IntPtr _this,ref FVector2D A,float B);
/// <summary>Returns Vector A added by B</summary>
public static FVector2D Add_Vector2DFloat(FVector2D A,float B)
{
	FVector2D ___ret = Add_Vector2DFloat(IntPtr.Zero,ref A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D Divide_Vector2DFloat(IntPtr _this,ref FVector2D A,float B);
/// <summary>Returns Vector A divided by B</summary>
public static FVector2D Divide_Vector2DFloat(FVector2D A,float B=1.000000f)
{
	FVector2D ___ret = Divide_Vector2DFloat(IntPtr.Zero,ref A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D Multiply_Vector2DVector2D(IntPtr _this,ref FVector2D A,ref FVector2D B);
/// <summary>Element-wise Vector multiplication (Result = {A.x*B.x, A.y*B.y})</summary>
public static FVector2D Multiply_Vector2DVector2D(FVector2D A,FVector2D B)
{
	FVector2D ___ret = Multiply_Vector2DVector2D(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D Multiply_Vector2DFloat(IntPtr _this,ref FVector2D A,float B);
/// <summary>Returns Vector A scaled by B</summary>
public static FVector2D Multiply_Vector2DFloat(FVector2D A,float B)
{
	FVector2D ___ret = Multiply_Vector2DFloat(IntPtr.Zero,ref A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D Subtract_Vector2DVector2D(IntPtr _this,ref FVector2D A,ref FVector2D B);
/// <summary>Returns subtraction of Vector B from Vector A (A - B)</summary>
public static FVector2D Subtract_Vector2DVector2D(FVector2D A,FVector2D B)
{
	FVector2D ___ret = Subtract_Vector2DVector2D(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D Add_Vector2DVector2D(IntPtr _this,ref FVector2D A,ref FVector2D B);
/// <summary>Returns addition of Vector A and Vector B (A + B)</summary>
public static FVector2D Add_Vector2DVector2D(FVector2D A,FVector2D B)
{
	FVector2D ___ret = Add_Vector2DVector2D(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NearlyEqual_TransformTransform(IntPtr _this,ref FTransform A,ref FTransform B,float LocationTolerance,float RotationTolerance,float Scale3DTolerance);
/// <summary>
/// Returns true if transform A is nearly equal to B
/// @param LocationTolerance        How close position of transforms need to be to be considered equal
/// @param RotationTolerance        How close rotations of transforms need to be to be considered equal
/// @param Scale3DTolerance         How close scale of transforms need to be to be considered equal
/// </summary>
public static bool NearlyEqual_TransformTransform(FTransform A,FTransform B,float LocationTolerance=0.000100f,float RotationTolerance=0.000100f,float Scale3DTolerance=0.000100f)
{
	int ___ret = NearlyEqual_TransformTransform(IntPtr.Zero,ref A,ref B,LocationTolerance,RotationTolerance,Scale3DTolerance);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_TransformTransform(IntPtr _this,ref FTransform A,ref FTransform B);
/// <summary>Returns true if transform A is equal to transform B</summary>
public static bool EqualEqual_TransformTransform(FTransform A,FTransform B)
{
	int ___ret = EqualEqual_TransformTransform(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform TInterpTo(IntPtr _this,ref FTransform Current,ref FTransform Target,float DeltaTime,float InterpSpeed);
/// <summary>Tries to reach a target transform.</summary>
public static FTransform TInterpTo(FTransform Current,FTransform Target,float DeltaTime,float InterpSpeed)
{
	FTransform ___ret = TInterpTo(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform TEase(IntPtr _this,ref FTransform A,ref FTransform B,float Alpha,int EasingFunc,float BlendExp,int Steps);
/// <summary>Ease between A and B using a specified easing function.</summary>
public static FTransform TEase(FTransform A,FTransform B,float Alpha,EEasingFunc EasingFunc,float BlendExp=2.000000f,int Steps=2)
{
	FTransform ___ret = TEase(IntPtr.Zero,ref A,ref B,Alpha,(int)EasingFunc,BlendExp,Steps);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform TLerp(IntPtr _this,ref FTransform A,ref FTransform B,float Alpha,int InterpMode);
/// <summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1).</summary>
public static FTransform TLerp(FTransform A,FTransform B,float Alpha,ELerpInterpolationMode InterpMode=ELerpInterpolationMode.QuatInterp)
{
	FTransform ___ret = TLerp(IntPtr.Zero,ref A,ref B,Alpha,(int)InterpMode);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform InvertTransform(IntPtr _this,ref FTransform T);
/// <summary>
/// Returns the inverse of the given transform T.
/// Example: Given a LocalToWorld transform, WorldToLocal will be returned.
/// @param       T       The transform you wish to invert
/// @return      The inverse of T.
/// </summary>
public static FTransform InvertTransform(FTransform T)
{
	FTransform ___ret = InvertTransform(IntPtr.Zero,ref T);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform ConvertTransformToRelative(IntPtr _this,ref FTransform Transform,ref FTransform ParentTransform);
/// <summary>
/// Returns the given transform, converted to be relative to the given ParentTransform.
/// Example: AToB = ConvertTransformToRelative(AToWorld, BToWorld) to compute A relative to B.
/// @param               Transform               The transform you wish to convert
/// @param               ParentTransform The transform the conversion is relative to (in the same space as Transform)
/// @return              The new relative transform
/// </summary>
public static FTransform ConvertTransformToRelative(FTransform Transform,FTransform ParentTransform)
{
	FTransform ___ret = ConvertTransformToRelative(IntPtr.Zero,ref Transform,ref ParentTransform);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform ComposeTransforms(IntPtr _this,ref FTransform A,ref FTransform B);
/// <summary>
/// Compose two transforms in order: A * B.
/// Order matters when composing transforms:
/// A * B will yield a transform that logically first applies A then B to any subsequent transformation.
/// Example: LocalToWorld = ComposeTransforms(DeltaRotation, LocalToWorld) will change rotation in local space by DeltaRotation.
/// Example: LocalToWorld = ComposeTransforms(LocalToWorld, DeltaRotation) will change rotation in world space by DeltaRotation.
/// @return New transform: A * B
/// </summary>
public static FTransform ComposeTransforms(FTransform A,FTransform B)
{
	FTransform ___ret = ComposeTransforms(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector InverseTransformDirection(IntPtr _this,ref FTransform T,ref FVector Direction);
/// <summary>
/// Transform a direction vector by the inverse of the supplied transform - will not change its length.
/// For example, if T was an object's transform, would transform a direction from world space to local space.
/// </summary>
public static FVector InverseTransformDirection(FTransform T,FVector Direction)
{
	FVector ___ret = InverseTransformDirection(IntPtr.Zero,ref T,ref Direction);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector InverseTransformLocation(IntPtr _this,ref FTransform T,ref FVector Location);
/// <summary>
/// Transform a position by the inverse of the supplied transform.
/// For example, if T was an object's transform, would transform a position from world space to local space.
/// </summary>
public static FVector InverseTransformLocation(FTransform T,FVector Location)
{
	FVector ___ret = InverseTransformLocation(IntPtr.Zero,ref T,ref Location);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector TransformDirection(IntPtr _this,ref FTransform T,ref FVector Direction);
/// <summary>
/// Transform a direction vector by the supplied transform - will not change its length.
/// For example, if T was an object's transform, would transform a direction from local space to world space.
/// </summary>
public static FVector TransformDirection(FTransform T,FVector Direction)
{
	FVector ___ret = TransformDirection(IntPtr.Zero,ref T,ref Direction);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector TransformLocation(IntPtr _this,ref FTransform T,ref FVector Location);
/// <summary>
/// Transform a position by the supplied transform.
/// For example, if T was an object's transform, would transform a position from local space to world space.
/// </summary>
public static FVector TransformLocation(FTransform T,FVector Location)
{
	FVector ___ret = TransformLocation(IntPtr.Zero,ref T,ref Location);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_NameName(IntPtr _this,string A,string B);
/// <summary>Returns true if A and B are not equal (A != B)</summary>
public static bool NotEqual_NameName(string A,string B)
{
	int ___ret = NotEqual_NameName(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_NameName(IntPtr _this,string A,string B);
/// <summary>Returns true if A and B are equal (A == B)</summary>
public static bool EqualEqual_NameName(string A,string B)
{
	int ___ret = EqualEqual_NameName(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int ClassIsChildOf(IntPtr _this,IntPtr TestClass,IntPtr ParentClass);
/// <summary>
/// Determine if a class is a child of another class.
/// @return      true if TestClass == ParentClass, or if TestClass is a child of ParentClass; false otherwise, or if either
///                      the value for either parameter is 'None'.
/// </summary>
public static bool ClassIsChildOf(TSubclassOf<UObject>  TestClass,TSubclassOf<UObject>  ParentClass)
{
	int ___ret = ClassIsChildOf(IntPtr.Zero,TestClass.NativeClass,ParentClass.NativeClass);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_ClassClass(IntPtr _this,IntPtr A,IntPtr B);
/// <summary>Returns true if A and B are not equal (A != B)</summary>
public static bool NotEqual_ClassClass(UClass A,UClass B)
{
	int ___ret = NotEqual_ClassClass(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_ClassClass(IntPtr _this,IntPtr A,IntPtr B);
/// <summary>Returns true if A and B are equal (A == B)</summary>
public static bool EqualEqual_ClassClass(UClass A,UClass B)
{
	int ___ret = EqualEqual_ClassClass(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_ObjectObject(IntPtr _this,IntPtr A,IntPtr B);
/// <summary>Returns true if A and B are not equal (A != B)</summary>
public static bool NotEqual_ObjectObject(UObject A,UObject B)
{
	int ___ret = NotEqual_ObjectObject(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_ObjectObject(IntPtr _this,IntPtr A,IntPtr B);
/// <summary>Returns true if A and B are equal (A == B)</summary>
public static bool EqualEqual_ObjectObject(UObject A,UObject B)
{
	int ___ret = EqualEqual_ObjectObject(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Conv_RotatorToVector(IntPtr _this,ref FRotator InRot);
/// <summary>Get the X direction vector after this rotation</summary>
public static FVector Conv_RotatorToVector(FRotator InRot)
{
	FVector ___ret = Conv_RotatorToVector(IntPtr.Zero,ref InRot);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator Conv_VectorToRotator(IntPtr _this,ref FVector InVec);
/// <summary>Create a rotator which orients X along the supplied direction vector</summary>
public static FRotator Conv_VectorToRotator(FVector InVec)
{
	FRotator ___ret = Conv_VectorToRotator(IntPtr.Zero,ref InVec);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator MakeRotationFromAxes(IntPtr _this,ref FVector Forward,ref FVector Right,ref FVector Up);
/// <summary>Build a reference frame from three axes</summary>
public static FRotator MakeRotationFromAxes(FVector Forward,FVector Right,FVector Up)
{
	FRotator ___ret = MakeRotationFromAxes(IntPtr.Zero,ref Forward,ref Right,ref Up);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SelectClass(IntPtr _this,IntPtr A,IntPtr B,int bSelectA);
/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
public static UClass SelectClass(UClass A,UClass B,bool bSelectA)
{
	IntPtr ___ret = SelectClass(IntPtr.Zero,A,B,bSelectA?1:0);
	if(___ret==IntPtr.Zero) return null; UClass ___ret2= new UClass(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SelectObject(IntPtr _this,IntPtr A,IntPtr B,int bSelectA);
/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
public static UObject SelectObject(UObject A,UObject B,bool bSelectA)
{
	IntPtr ___ret = SelectObject(IntPtr.Zero,A,B,bSelectA?1:0);
	if(___ret==IntPtr.Zero) return null; UObject ___ret2= new UObject(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform SelectTransform(IntPtr _this,ref FTransform A,ref FTransform B,int bPickA);
/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
public static FTransform SelectTransform(FTransform A,FTransform B,bool bPickA)
{
	FTransform ___ret = SelectTransform(IntPtr.Zero,ref A,ref B,bPickA?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FLinearColor SelectColor(IntPtr _this,ref FLinearColor A,ref FLinearColor B,int bPickA);
/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
public static FLinearColor SelectColor(FLinearColor A,FLinearColor B,bool bPickA)
{
	FLinearColor ___ret = SelectColor(IntPtr.Zero,ref A,ref B,bPickA?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator SelectRotator(IntPtr _this,ref FRotator A,ref FRotator B,int bPickA);
/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
public static FRotator SelectRotator(FRotator A,FRotator B,bool bPickA)
{
	FRotator ___ret = SelectRotator(IntPtr.Zero,ref A,ref B,bPickA?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector SelectVector(IntPtr _this,ref FVector A,ref FVector B,int bPickA);
/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
public static FVector SelectVector(FVector A,FVector B,bool bPickA)
{
	FVector ___ret = SelectVector(IntPtr.Zero,ref A,ref B,bPickA?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float SelectFloat(IntPtr _this,float A,float B,int bPickA);
/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
public static float SelectFloat(float A,float B,bool bPickA)
{
	float ___ret = SelectFloat(IntPtr.Zero,A,B,bPickA?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SelectInt(IntPtr _this,int A,int B,int bPickA);
/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
public static int SelectInt(int A,int B,bool bPickA)
{
	int ___ret = SelectInt(IntPtr.Zero,A,B,bPickA?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string SelectString(IntPtr _this,string A,string B,int bPickA);
/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
public static string SelectString(string A,string B,bool bPickA)
{
	string ___ret = SelectString(IntPtr.Zero,A,B,bPickA?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RGBToHSV_Vector(IntPtr _this,ref FLinearColor RGB,out FLinearColor HSV);
/// <summary>Converts a RGB linear color to HSV (where H is in R, S is in G, and V is in B)</summary>
public static void RGBToHSV_Vector(FLinearColor RGB,out FLinearColor HSV)
{
	RGBToHSV_Vector(IntPtr.Zero,ref RGB,out HSV);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void HSVToRGB_Vector(IntPtr _this,ref FLinearColor HSV,out FLinearColor RGB);
/// <summary>Converts a HSV linear color (where H is in R, S is in G, and V is in B) to RGB</summary>
public static void HSVToRGB_Vector(FLinearColor HSV,out FLinearColor RGB)
{
	HSVToRGB_Vector(IntPtr.Zero,ref HSV,out RGB);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RGBToHSV(IntPtr _this,ref FLinearColor InColor,out float H,out float S,out float V,out float A);
/// <summary>Breaks apart a color into individual HSV components (as well as alpha)</summary>
public static void RGBToHSV(FLinearColor InColor,out float H,out float S,out float V,out float A)
{
	RGBToHSV(IntPtr.Zero,ref InColor,out H,out S,out V,out A);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FLinearColor HSVToRGB(IntPtr _this,float H,float S,float V,float A);
/// <summary>Make a color from individual color components (HSV space)</summary>
public static FLinearColor HSVToRGB(float H,float S,float V,float A=1.000000f)
{
	FLinearColor ___ret = HSVToRGB(IntPtr.Zero,H,S,V,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BreakColor(IntPtr _this,ref FLinearColor InColor,out float R,out float G,out float B,out float A);
/// <summary>Breaks apart a color into individual RGB components (as well as alpha)</summary>
public static void BreakColor(FLinearColor InColor,out float R,out float G,out float B,out float A)
{
	BreakColor(IntPtr.Zero,ref InColor,out R,out G,out B,out A);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FLinearColor MakeColor(IntPtr _this,float R,float G,float B,float A);
/// <summary>Make a color from individual color components (RGB space)</summary>
public static FLinearColor MakeColor(float R,float G,float B,float A=1.000000f)
{
	FLinearColor ___ret = MakeColor(IntPtr.Zero,R,G,B,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BreakRandomStream(IntPtr _this,ref FRandomStream InRandomStream,out int InitialSeed);
/// <summary>Breaks apart a random number generator</summary>
public static void BreakRandomStream(FRandomStream InRandomStream,out int InitialSeed)
{
	BreakRandomStream(IntPtr.Zero,ref InRandomStream,out InitialSeed);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRandomStream MakeRandomStream(IntPtr _this,int InitialSeed);
/// <summary>Makes a SRand-based random number generator</summary>
public static FRandomStream MakeRandomStream(int InitialSeed)
{
	FRandomStream ___ret = MakeRandomStream(IntPtr.Zero,InitialSeed);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BreakTransform(IntPtr _this,ref FTransform InTransform,out FVector Location,out FRotator Rotation,out FVector Scale);
/// <summary>Breaks apart a transform into location, rotation and scale</summary>
public static void BreakTransform(FTransform InTransform,out FVector Location,out FRotator Rotation,out FVector Scale)
{
	BreakTransform(IntPtr.Zero,ref InTransform,out Location,out Rotation,out Scale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform MakeTransform(IntPtr _this,ref FVector Location,ref FRotator Rotation,ref FVector Scale);
/// <summary>Make a transform from location, rotation and scale</summary>
public static FTransform MakeTransform(FVector Location,FRotator Rotation,FVector Scale)
{
	FTransform ___ret = MakeTransform(IntPtr.Zero,ref Location,ref Rotation,ref Scale);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BreakRotIntoAxes(IntPtr _this,ref FRotator InRot,out FVector X,out FVector Y,out FVector Z);
/// <summary>Breaks apart a rotator into its component axes</summary>
public static void BreakRotIntoAxes(FRotator InRot,out FVector X,out FVector Y,out FVector Z)
{
	BreakRotIntoAxes(IntPtr.Zero,ref InRot,out X,out Y,out Z);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BreakRotator(IntPtr _this,ref FRotator InRot,out float Roll,out float Pitch,out float Yaw);
/// <summary>Breaks apart a rotator into {Roll, Pitch, Yaw} angles in degrees</summary>
public static void BreakRotator(FRotator InRot,out float Roll,out float Pitch,out float Yaw)
{
	BreakRotator(IntPtr.Zero,ref InRot,out Roll,out Pitch,out Yaw);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator MakeRotFromZY(IntPtr _this,ref FVector Z,ref FVector Y);
/// <summary>Builds a matrix with given Z and Y axes. Z will remain fixed, Y may be changed minimally to enforce orthogonality. X will be computed. Inputs need not be normalized.</summary>
public static FRotator MakeRotFromZY(FVector Z,FVector Y)
{
	FRotator ___ret = MakeRotFromZY(IntPtr.Zero,ref Z,ref Y);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator MakeRotFromZX(IntPtr _this,ref FVector Z,ref FVector X);
/// <summary>Builds a matrix with given Z and X axes. Z will remain fixed, X may be changed minimally to enforce orthogonality. Y will be computed. Inputs need not be normalized.</summary>
public static FRotator MakeRotFromZX(FVector Z,FVector X)
{
	FRotator ___ret = MakeRotFromZX(IntPtr.Zero,ref Z,ref X);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator MakeRotFromYZ(IntPtr _this,ref FVector Y,ref FVector Z);
/// <summary>Builds a matrix with given Y and Z axes. Y will remain fixed, Z may be changed minimally to enforce orthogonality. X will be computed. Inputs need not be normalized.</summary>
public static FRotator MakeRotFromYZ(FVector Y,FVector Z)
{
	FRotator ___ret = MakeRotFromYZ(IntPtr.Zero,ref Y,ref Z);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator MakeRotFromYX(IntPtr _this,ref FVector Y,ref FVector X);
/// <summary>Builds a matrix with given Y and X axes. Y will remain fixed, X may be changed minimally to enforce orthogonality. Z will be computed. Inputs need not be normalized.</summary>
public static FRotator MakeRotFromYX(FVector Y,FVector X)
{
	FRotator ___ret = MakeRotFromYX(IntPtr.Zero,ref Y,ref X);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator MakeRotFromXZ(IntPtr _this,ref FVector X,ref FVector Z);
/// <summary>Builds a matrix with given X and Z axes. X will remain fixed, Z may be changed minimally to enforce orthogonality. Y will be computed. Inputs need not be normalized.</summary>
public static FRotator MakeRotFromXZ(FVector X,FVector Z)
{
	FRotator ___ret = MakeRotFromXZ(IntPtr.Zero,ref X,ref Z);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator MakeRotFromXY(IntPtr _this,ref FVector X,ref FVector Y);
/// <summary>Builds a matrix with given X and Y axes. X will remain fixed, Y may be changed minimally to enforce orthogonality. Z will be computed. Inputs need not be normalized.</summary>
public static FRotator MakeRotFromXY(FVector X,FVector Y)
{
	FRotator ___ret = MakeRotFromXY(IntPtr.Zero,ref X,ref Y);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator MakeRotFromZ(IntPtr _this,ref FVector Z);
/// <summary>Builds a rotation matrix given only a ZAxis. X and Y are unspecified but will be orthonormal. ZAxis need not be normalized.</summary>
public static FRotator MakeRotFromZ(FVector Z)
{
	FRotator ___ret = MakeRotFromZ(IntPtr.Zero,ref Z);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator MakeRotFromY(IntPtr _this,ref FVector Y);
/// <summary>Builds a rotation matrix given only a YAxis. X and Z are unspecified but will be orthonormal. YAxis need not be normalized.</summary>
public static FRotator MakeRotFromY(FVector Y)
{
	FRotator ___ret = MakeRotFromY(IntPtr.Zero,ref Y);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator MakeRotFromX(IntPtr _this,ref FVector X);
/// <summary>Builds a rotator given only a XAxis. Y and Z are unspecified but will be orthonormal. XAxis need not be normalized.</summary>
public static FRotator MakeRotFromX(FVector X)
{
	FRotator ___ret = MakeRotFromX(IntPtr.Zero,ref X);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator FindLookAtRotation(IntPtr _this,ref FVector Start,ref FVector Target);
/// <summary>Find a rotation for an object at Start location to point at Target location.</summary>
public static FRotator FindLookAtRotation(FVector Start,FVector Target)
{
	FRotator ___ret = FindLookAtRotation(IntPtr.Zero,ref Start,ref Target);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator MakeRotator(IntPtr _this,float Roll,float Pitch,float Yaw);
/// <summary>Makes a rotator {Roll, Pitch, Yaw} from rotation values supplied in degrees</summary>
public static FRotator MakeRotator(float Roll,float Pitch,float Yaw)
{
	FRotator ___ret = MakeRotator(IntPtr.Zero,Roll,Pitch,Yaw);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetYawPitchFromVector(IntPtr _this,ref FVector InVec,out float Yaw,out float Pitch);
/// <summary>Breaks a vector apart into Yaw, Pitch rotation values given in degrees. (non-clamped)</summary>
public static void GetYawPitchFromVector(FVector InVec,out float Yaw,out float Pitch)
{
	GetYawPitchFromVector(IntPtr.Zero,ref InVec,out Yaw,out Pitch);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector CreateVectorFromYawPitch(IntPtr _this,float Yaw,float Pitch,float Length);
/// <summary>Creates a directional vector from rotation values {Pitch, Yaw} supplied in degrees with specified Length</summary>
public static FVector CreateVectorFromYawPitch(float Yaw,float Pitch,float Length=1.000000f)
{
	FVector ___ret = CreateVectorFromYawPitch(IntPtr.Zero,Yaw,Pitch,Length);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetUpVector(IntPtr _this,ref FRotator InRot);
/// <summary>Rotate the world up vector by the given rotation</summary>
public static FVector GetUpVector(FRotator InRot)
{
	FVector ___ret = GetUpVector(IntPtr.Zero,ref InRot);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetRightVector(IntPtr _this,ref FRotator InRot);
/// <summary>Rotate the world right vector by the given rotation</summary>
public static FVector GetRightVector(FRotator InRot)
{
	FVector ___ret = GetRightVector(IntPtr.Zero,ref InRot);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetForwardVector(IntPtr _this,ref FRotator InRot);
/// <summary>Rotate the world forward vector by the given rotation</summary>
public static FVector GetForwardVector(FRotator InRot)
{
	FVector ___ret = GetForwardVector(IntPtr.Zero,ref InRot);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BreakVector2D(IntPtr _this,ref FVector2D InVec,out float X,out float Y);
/// <summary>Breaks a 2D vector apart into X, Y.</summary>
public static void BreakVector2D(FVector2D InVec,out float X,out float Y)
{
	BreakVector2D(IntPtr.Zero,ref InVec,out X,out Y);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D MakeVector2D(IntPtr _this,float X,float Y);
/// <summary>Makes a 2d vector {X, Y}</summary>
public static FVector2D MakeVector2D(float X,float Y)
{
	FVector2D ___ret = MakeVector2D(IntPtr.Zero,X,Y);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BreakVector(IntPtr _this,ref FVector InVec,out float X,out float Y,out float Z);
/// <summary>Breaks a vector apart into X, Y, Z</summary>
public static void BreakVector(FVector InVec,out float X,out float Y,out float Z)
{
	BreakVector(IntPtr.Zero,ref InVec,out X,out Y,out Z);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector MakeVector(IntPtr _this,float X,float Y,float Z);
/// <summary>Makes a vector {X, Y, Z}</summary>
public static FVector MakeVector(float X,float Y,float Z)
{
	FVector ___ret = MakeVector(IntPtr.Zero,X,Y,Z);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FLinearColor Conv_FloatToLinearColor(IntPtr _this,float InFloat);
/// <summary>Convert a float into a LinearColor, where each element is that float</summary>
public static FLinearColor Conv_FloatToLinearColor(float InFloat)
{
	FLinearColor ___ret = Conv_FloatToLinearColor(IntPtr.Zero,InFloat);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Conv_FloatToVector(IntPtr _this,float InFloat);
/// <summary>Convert a float into a vector, where each element is that float</summary>
public static FVector Conv_FloatToVector(float InFloat)
{
	FVector ___ret = Conv_FloatToVector(IntPtr.Zero,InFloat);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Conv_Vector2DToVector(IntPtr _this,ref FVector2D InVector2D,float Z);
/// <summary>Convert a Vector2D to a Vector</summary>
public static FVector Conv_Vector2DToVector(FVector2D InVector2D,float Z=0.000000f)
{
	FVector ___ret = Conv_Vector2DToVector(IntPtr.Zero,ref InVector2D,Z);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D Conv_VectorToVector2D(IntPtr _this,ref FVector InVector);
/// <summary>Convert a Vector to a Vector2D</summary>
public static FVector2D Conv_VectorToVector2D(FVector InVector)
{
	FVector2D ___ret = Conv_VectorToVector2D(IntPtr.Zero,ref InVector);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform Conv_VectorToTransform(IntPtr _this,ref FVector InLocation);
/// <summary>Convert a vector to a transform. Uses vector as location</summary>
public static FTransform Conv_VectorToTransform(FVector InLocation)
{
	FTransform ___ret = Conv_VectorToTransform(IntPtr.Zero,ref InLocation);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FColor Conv_LinearColorToColor(IntPtr _this,ref FLinearColor InLinearColor);
/// <summary>Converts a LinearColor to a color</summary>
public static FColor Conv_LinearColorToColor(FLinearColor InLinearColor)
{
	FColor ___ret = Conv_LinearColorToColor(IntPtr.Zero,ref InLinearColor);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FLinearColor Conv_ColorToLinearColor(IntPtr _this,ref FColor InColor);
/// <summary>Converts a color to LinearColor</summary>
public static FLinearColor Conv_ColorToLinearColor(FColor InColor)
{
	FLinearColor ___ret = Conv_ColorToLinearColor(IntPtr.Zero,ref InColor);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Conv_LinearColorToVector(IntPtr _this,ref FLinearColor InLinearColor);
/// <summary>Converts a LinearColor to a vector</summary>
public static FVector Conv_LinearColorToVector(FLinearColor InLinearColor)
{
	FVector ___ret = Conv_LinearColorToVector(IntPtr.Zero,ref InLinearColor);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FLinearColor Conv_VectorToLinearColor(IntPtr _this,ref FVector InVec);
/// <summary>Converts a vector to LinearColor</summary>
public static FLinearColor Conv_VectorToLinearColor(FVector InVec)
{
	FLinearColor ___ret = Conv_VectorToLinearColor(IntPtr.Zero,ref InVec);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Conv_ByteToInt(IntPtr _this,int InByte);
/// <summary>Converts a byte to an integer</summary>
public static int Conv_ByteToInt(byte InByte)
{
	int ___ret = Conv_ByteToInt(IntPtr.Zero,InByte);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Conv_BoolToByte(IntPtr _this,int InBool);
/// <summary>Converts a bool to a byte</summary>
public static byte Conv_BoolToByte(bool InBool)
{
	int ___ret = Conv_BoolToByte(IntPtr.Zero,InBool?1:0);
	return (byte)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Conv_BoolToFloat(IntPtr _this,int InBool);
/// <summary>Converts a bool to a float (0.0f or 1.0f)</summary>
public static float Conv_BoolToFloat(bool InBool)
{
	float ___ret = Conv_BoolToFloat(IntPtr.Zero,InBool?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Conv_BoolToInt(IntPtr _this,int InBool);
/// <summary>Converts a bool to an int</summary>
public static int Conv_BoolToInt(bool InBool)
{
	int ___ret = Conv_BoolToInt(IntPtr.Zero,InBool?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Conv_IntToBool(IntPtr _this,int InInt);
/// <summary>Converts a int to a bool</summary>
public static bool Conv_IntToBool(int InInt)
{
	int ___ret = Conv_IntToBool(IntPtr.Zero,InInt);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Conv_IntToByte(IntPtr _this,int InInt);
/// <summary>Converts an integer to a byte (if the integer is too large, returns the low 8 bits)</summary>
public static byte Conv_IntToByte(int InInt)
{
	int ___ret = Conv_IntToByte(IntPtr.Zero,InInt);
	return (byte)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Conv_IntToFloat(IntPtr _this,int InInt);
/// <summary>Converts an integer to a float</summary>
public static float Conv_IntToFloat(int InInt)
{
	float ___ret = Conv_IntToFloat(IntPtr.Zero,InInt);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Conv_ByteToFloat(IntPtr _this,int InByte);
/// <summary>Converts a byte to a float</summary>
public static float Conv_ByteToFloat(byte InByte)
{
	float ___ret = Conv_ByteToFloat(IntPtr.Zero,InByte);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int TimespanFromString(IntPtr _this,string TimespanString,out FTimespan Result);
/// <summary>Converts a time span string to a Timespan object</summary>
public static bool TimespanFromString(string TimespanString,out FTimespan Result)
{
	int ___ret = TimespanFromString(IntPtr.Zero,TimespanString,out Result);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimespan TimespanZeroValue(IntPtr _this);
/// <summary>Returns a zero time span value</summary>
public static FTimespan TimespanZeroValue()
{
	FTimespan ___ret = TimespanZeroValue(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float TimespanRatio(IntPtr _this,ref FTimespan A,ref FTimespan B);
/// <summary>Returns the ratio between two time spans (A / B), handles zero values</summary>
public static float TimespanRatio(FTimespan A,FTimespan B)
{
	float ___ret = TimespanRatio(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimespan TimespanMinValue(IntPtr _this);
/// <summary>Returns the minimum time span value</summary>
public static FTimespan TimespanMinValue()
{
	FTimespan ___ret = TimespanMinValue(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimespan TimespanMaxValue(IntPtr _this);
/// <summary>Returns the maximum time span value</summary>
public static FTimespan TimespanMaxValue()
{
	FTimespan ___ret = TimespanMaxValue(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimespan FromSeconds(IntPtr _this,float Seconds);
/// <summary>Returns a time span that represents the specified number of seconds</summary>
public static FTimespan FromSeconds(float Seconds)
{
	FTimespan ___ret = FromSeconds(IntPtr.Zero,Seconds);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimespan FromMinutes(IntPtr _this,float Minutes);
/// <summary>Returns a time span that represents the specified number of minutes</summary>
public static FTimespan FromMinutes(float Minutes)
{
	FTimespan ___ret = FromMinutes(IntPtr.Zero,Minutes);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimespan FromMilliseconds(IntPtr _this,float Milliseconds);
/// <summary>Returns a time span that represents the specified number of milliseconds</summary>
public static FTimespan FromMilliseconds(float Milliseconds)
{
	FTimespan ___ret = FromMilliseconds(IntPtr.Zero,Milliseconds);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimespan FromHours(IntPtr _this,float Hours);
/// <summary>Returns a time span that represents the specified number of hours</summary>
public static FTimespan FromHours(float Hours)
{
	FTimespan ___ret = FromHours(IntPtr.Zero,Hours);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimespan FromDays(IntPtr _this,float Days);
/// <summary>Returns a time span that represents the specified number of days</summary>
public static FTimespan FromDays(float Days)
{
	FTimespan ___ret = FromDays(IntPtr.Zero,Days);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetTotalSeconds(IntPtr _this,ref FTimespan A);
/// <summary>Returns the total number of seconds in A</summary>
public static float GetTotalSeconds(FTimespan A)
{
	float ___ret = GetTotalSeconds(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetTotalMinutes(IntPtr _this,ref FTimespan A);
/// <summary>Returns the total number of minutes in A</summary>
public static float GetTotalMinutes(FTimespan A)
{
	float ___ret = GetTotalMinutes(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetTotalMilliseconds(IntPtr _this,ref FTimespan A);
/// <summary>Returns the total number of milliseconds in A</summary>
public static float GetTotalMilliseconds(FTimespan A)
{
	float ___ret = GetTotalMilliseconds(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetTotalHours(IntPtr _this,ref FTimespan A);
/// <summary>Returns the total number of hours in A</summary>
public static float GetTotalHours(FTimespan A)
{
	float ___ret = GetTotalHours(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetTotalDays(IntPtr _this,ref FTimespan A);
/// <summary>Returns the total number of days in A</summary>
public static float GetTotalDays(FTimespan A)
{
	float ___ret = GetTotalDays(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetSeconds(IntPtr _this,ref FTimespan A);
/// <summary>Returns the seconds component of A</summary>
public static int GetSeconds(FTimespan A)
{
	int ___ret = GetSeconds(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetMinutes(IntPtr _this,ref FTimespan A);
/// <summary>Returns the minutes component of A</summary>
public static int GetMinutes(FTimespan A)
{
	int ___ret = GetMinutes(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetMilliseconds(IntPtr _this,ref FTimespan A);
/// <summary>Returns the milliseconds component of A</summary>
public static int GetMilliseconds(FTimespan A)
{
	int ___ret = GetMilliseconds(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetHours(IntPtr _this,ref FTimespan A);
/// <summary>Returns the hours component of A</summary>
public static int GetHours(FTimespan A)
{
	int ___ret = GetHours(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimespan GetDuration(IntPtr _this,ref FTimespan A);
/// <summary>Returns the absolute value of A</summary>
public static FTimespan GetDuration(FTimespan A)
{
	FTimespan ___ret = GetDuration(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetDays(IntPtr _this,ref FTimespan A);
/// <summary>Returns the days component of A</summary>
public static int GetDays(FTimespan A)
{
	int ___ret = GetDays(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int LessEqual_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
/// <summary>Returns true if A is less than or equal to B (A <= B)</summary>
public static bool LessEqual_TimespanTimespan(FTimespan A,FTimespan B)
{
	int ___ret = LessEqual_TimespanTimespan(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Less_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
/// <summary>Returns true if A is less than B (A < B)</summary>
public static bool Less_TimespanTimespan(FTimespan A,FTimespan B)
{
	int ___ret = Less_TimespanTimespan(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GreaterEqual_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
/// <summary>Returns true if A is greater than or equal to B (A >= B)</summary>
public static bool GreaterEqual_TimespanTimespan(FTimespan A,FTimespan B)
{
	int ___ret = GreaterEqual_TimespanTimespan(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Greater_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
/// <summary>Returns true if A is greater than B (A > B)</summary>
public static bool Greater_TimespanTimespan(FTimespan A,FTimespan B)
{
	int ___ret = Greater_TimespanTimespan(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
/// <summary>Returns true if the values are not equal (A != B)</summary>
public static bool NotEqual_TimespanTimespan(FTimespan A,FTimespan B)
{
	int ___ret = NotEqual_TimespanTimespan(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
/// <summary>Returns true if the values are equal (A == B)</summary>
public static bool EqualEqual_TimespanTimespan(FTimespan A,FTimespan B)
{
	int ___ret = EqualEqual_TimespanTimespan(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimespan Multiply_TimespanFloat(IntPtr _this,ref FTimespan A,float Scalar);
/// <summary>Scalar multiplication (A * s)</summary>
public static FTimespan Multiply_TimespanFloat(FTimespan A,float Scalar)
{
	FTimespan ___ret = Multiply_TimespanFloat(IntPtr.Zero,ref A,Scalar);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimespan Subtract_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
/// <summary>Subtraction (A - B)</summary>
public static FTimespan Subtract_TimespanTimespan(FTimespan A,FTimespan B)
{
	FTimespan ___ret = Subtract_TimespanTimespan(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimespan Add_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
/// <summary>Addition (A + B)</summary>
public static FTimespan Add_TimespanTimespan(FTimespan A,FTimespan B)
{
	FTimespan ___ret = Add_TimespanTimespan(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BreakTimespan(IntPtr _this,ref FTimespan InTimespan,out int Days,out int Hours,out int Minutes,out int Seconds,out int Milliseconds);
/// <summary>Breaks a Timespan into its components</summary>
public static void BreakTimespan(FTimespan InTimespan,out int Days,out int Hours,out int Minutes,out int Seconds,out int Milliseconds)
{
	BreakTimespan(IntPtr.Zero,ref InTimespan,out Days,out Hours,out Minutes,out Seconds,out Milliseconds);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimespan MakeTimespan(IntPtr _this,int Days,int Hours,int Minutes,int Seconds,int Milliseconds);
/// <summary>Makes a Timespan struct</summary>
public static FTimespan MakeTimespan(int Days,int Hours,int Minutes,int Seconds,int Milliseconds)
{
	FTimespan ___ret = MakeTimespan(IntPtr.Zero,Days,Hours,Minutes,Seconds,Milliseconds);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int DateTimeFromString(IntPtr _this,string DateTimeString,out FDateTime Result);
/// <summary>Converts a date string to a DateTime object</summary>
public static bool DateTimeFromString(string DateTimeString,out FDateTime Result)
{
	int ___ret = DateTimeFromString(IntPtr.Zero,DateTimeString,out Result);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int DateTimeFromIsoString(IntPtr _this,string IsoString,out FDateTime Result);
/// <summary>Converts a date string in ISO-8601 format to a DateTime object</summary>
public static bool DateTimeFromIsoString(string IsoString,out FDateTime Result)
{
	int ___ret = DateTimeFromIsoString(IntPtr.Zero,IsoString,out Result);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FDateTime UtcNow(IntPtr _this);
/// <summary>Returns the UTC date and time on this computer</summary>
public static FDateTime UtcNow()
{
	FDateTime ___ret = UtcNow(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FDateTime Today(IntPtr _this);
/// <summary>Returns the local date on this computer</summary>
public static FDateTime Today()
{
	FDateTime ___ret = Today(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FDateTime Now(IntPtr _this);
/// <summary>Returns the local date and time on this computer</summary>
public static FDateTime Now()
{
	FDateTime ___ret = Now(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FDateTime DateTimeMinValue(IntPtr _this);
/// <summary>Returns the minimum date and time value</summary>
public static FDateTime DateTimeMinValue()
{
	FDateTime ___ret = DateTimeMinValue(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FDateTime DateTimeMaxValue(IntPtr _this);
/// <summary>Returns the maximum date and time value</summary>
public static FDateTime DateTimeMaxValue()
{
	FDateTime ___ret = DateTimeMaxValue(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsLeapYear(IntPtr _this,int Year);
/// <summary>Returns whether given year is a leap year</summary>
public static bool IsLeapYear(int Year)
{
	int ___ret = IsLeapYear(IntPtr.Zero,Year);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int DaysInYear(IntPtr _this,int Year);
/// <summary>Returns the number of days in the given year</summary>
public static int DaysInYear(int Year)
{
	int ___ret = DaysInYear(IntPtr.Zero,Year);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int DaysInMonth(IntPtr _this,int Year,int Month);
/// <summary>Returns the number of days in the given year and month</summary>
public static int DaysInMonth(int Year,int Month)
{
	int ___ret = DaysInMonth(IntPtr.Zero,Year,Month);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsMorning(IntPtr _this,ref FDateTime A);
/// <summary>Returns whether A's time is in the morning</summary>
public static bool IsMorning(FDateTime A)
{
	int ___ret = IsMorning(IntPtr.Zero,ref A);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsAfternoon(IntPtr _this,ref FDateTime A);
/// <summary>Returns whether A's time is in the afternoon</summary>
public static bool IsAfternoon(FDateTime A)
{
	int ___ret = IsAfternoon(IntPtr.Zero,ref A);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetYear(IntPtr _this,ref FDateTime A);
/// <summary>Returns the year component of A</summary>
public static int GetYear(FDateTime A)
{
	int ___ret = GetYear(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimespan GetTimeOfDay(IntPtr _this,ref FDateTime A);
/// <summary>Returns the time elapsed since midnight of A</summary>
public static FTimespan GetTimeOfDay(FDateTime A)
{
	FTimespan ___ret = GetTimeOfDay(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetSecond(IntPtr _this,ref FDateTime A);
/// <summary>Returns the second component of A</summary>
public static int GetSecond(FDateTime A)
{
	int ___ret = GetSecond(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetMonth(IntPtr _this,ref FDateTime A);
/// <summary>Returns the month component of A</summary>
public static int GetMonth(FDateTime A)
{
	int ___ret = GetMonth(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetMinute(IntPtr _this,ref FDateTime A);
/// <summary>Returns the minute component of A</summary>
public static int GetMinute(FDateTime A)
{
	int ___ret = GetMinute(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetMillisecond(IntPtr _this,ref FDateTime A);
/// <summary>Returns the millisecond component of A</summary>
public static int GetMillisecond(FDateTime A)
{
	int ___ret = GetMillisecond(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetHour12(IntPtr _this,ref FDateTime A);
/// <summary>Returns the hour component of A (12h format)</summary>
public static int GetHour12(FDateTime A)
{
	int ___ret = GetHour12(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetHour(IntPtr _this,ref FDateTime A);
/// <summary>Returns the hour component of A (24h format)</summary>
public static int GetHour(FDateTime A)
{
	int ___ret = GetHour(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetDayOfYear(IntPtr _this,ref FDateTime A);
/// <summary>Returns the day of year of A</summary>
public static int GetDayOfYear(FDateTime A)
{
	int ___ret = GetDayOfYear(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetDay(IntPtr _this,ref FDateTime A);
/// <summary>Returns the day component of A (1 to 31)</summary>
public static int GetDay(FDateTime A)
{
	int ___ret = GetDay(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FDateTime GetDate(IntPtr _this,ref FDateTime A);
/// <summary>Returns the date component of A</summary>
public static FDateTime GetDate(FDateTime A)
{
	FDateTime ___ret = GetDate(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int LessEqual_DateTimeDateTime(IntPtr _this,ref FDateTime A,ref FDateTime B);
/// <summary>Returns true if A is less than or equal to B (A <= B)</summary>
public static bool LessEqual_DateTimeDateTime(FDateTime A,FDateTime B)
{
	int ___ret = LessEqual_DateTimeDateTime(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Less_DateTimeDateTime(IntPtr _this,ref FDateTime A,ref FDateTime B);
/// <summary>Returns true if A is less than B (A < B)</summary>
public static bool Less_DateTimeDateTime(FDateTime A,FDateTime B)
{
	int ___ret = Less_DateTimeDateTime(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GreaterEqual_DateTimeDateTime(IntPtr _this,ref FDateTime A,ref FDateTime B);
/// <summary>Returns true if A is greater than or equal to B (A >= B)</summary>
public static bool GreaterEqual_DateTimeDateTime(FDateTime A,FDateTime B)
{
	int ___ret = GreaterEqual_DateTimeDateTime(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Greater_DateTimeDateTime(IntPtr _this,ref FDateTime A,ref FDateTime B);
/// <summary>Returns true if A is greater than B (A > B)</summary>
public static bool Greater_DateTimeDateTime(FDateTime A,FDateTime B)
{
	int ___ret = Greater_DateTimeDateTime(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_DateTimeDateTime(IntPtr _this,ref FDateTime A,ref FDateTime B);
/// <summary>Returns true if the values are not equal (A != B)</summary>
public static bool NotEqual_DateTimeDateTime(FDateTime A,FDateTime B)
{
	int ___ret = NotEqual_DateTimeDateTime(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_DateTimeDateTime(IntPtr _this,ref FDateTime A,ref FDateTime B);
/// <summary>Returns true if the values are equal (A == B)</summary>
public static bool EqualEqual_DateTimeDateTime(FDateTime A,FDateTime B)
{
	int ___ret = EqualEqual_DateTimeDateTime(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimespan Subtract_DateTimeDateTime(IntPtr _this,ref FDateTime A,ref FDateTime B);
/// <summary>Subtraction (A - B)</summary>
public static FTimespan Subtract_DateTimeDateTime(FDateTime A,FDateTime B)
{
	FTimespan ___ret = Subtract_DateTimeDateTime(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FDateTime Subtract_DateTimeTimespan(IntPtr _this,ref FDateTime A,ref FTimespan B);
/// <summary>Subtraction (A - B)</summary>
public static FDateTime Subtract_DateTimeTimespan(FDateTime A,FTimespan B)
{
	FDateTime ___ret = Subtract_DateTimeTimespan(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FDateTime Add_DateTimeTimespan(IntPtr _this,ref FDateTime A,ref FTimespan B);
/// <summary>Addition (A + B)</summary>
public static FDateTime Add_DateTimeTimespan(FDateTime A,FTimespan B)
{
	FDateTime ___ret = Add_DateTimeTimespan(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BreakDateTime(IntPtr _this,ref FDateTime InDateTime,out int Year,out int Month,out int Day,out int Hour,out int Minute,out int Second,out int Millisecond);
/// <summary>Breaks a DateTime into its components</summary>
public static void BreakDateTime(FDateTime InDateTime,out int Year,out int Month,out int Day,out int Hour,out int Minute,out int Second,out int Millisecond)
{
	BreakDateTime(IntPtr.Zero,ref InDateTime,out Year,out Month,out Day,out Hour,out Minute,out Second,out Millisecond);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FDateTime MakeDateTime(IntPtr _this,int Year,int Month,int Day,int Hour,int Minute,int Second,int Millisecond);
/// <summary>Makes a DateTime struct</summary>
public static FDateTime MakeDateTime(int Year,int Month,int Day,int Hour=0,int Minute=0,int Second=0,int Millisecond=0)
{
	FDateTime ___ret = MakeDateTime(IntPtr.Zero,Year,Month,Day,Hour,Minute,Second,Millisecond);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FPlane MakePlaneFromPointAndNormal(IntPtr _this,ref FVector Point,ref FVector Normal);
/// <summary>
/// Creates a plane with a facing direction of Normal at the given Point
/// @param Point  A point on the plane
/// @param Normal  The Normal of the plane at Point
/// @return Plane instance
/// </summary>
public static FPlane MakePlaneFromPointAndNormal(FVector Point,FVector Normal)
{
	FPlane ___ret = MakePlaneFromPointAndNormal(IntPtr.Zero,ref Point,ref Normal);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FLinearColor Multiply_LinearColorFloat(IntPtr _this,ref FLinearColor A,float B);
/// <summary>Element-wise multiplication of a linear color by a float (F*R, F*G, F*B, F*A)</summary>
public static FLinearColor Multiply_LinearColorFloat(FLinearColor A,float B)
{
	FLinearColor ___ret = Multiply_LinearColorFloat(IntPtr.Zero,ref A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FLinearColor Multiply_LinearColorLinearColor(IntPtr _this,ref FLinearColor A,ref FLinearColor B);
/// <summary>Element-wise multiplication of two linear colors (R*R, G*G, B*B, A*A)</summary>
public static FLinearColor Multiply_LinearColorLinearColor(FLinearColor A,FLinearColor B)
{
	FLinearColor ___ret = Multiply_LinearColorLinearColor(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FLinearColor LinearColorLerpUsingHSV(IntPtr _this,ref FLinearColor A,ref FLinearColor B,float Alpha);
/// <summary>
/// Linearly interpolates between two colors by the specified Alpha amount (100% of A when Alpha=0 and 100% of B when Alpha=1).  The interpolation is performed in HSV color space taking the shortest path to the new color's hue.  This can give better results than a normal lerp, but is much more expensive.  The incoming colors are in RGB space, and the output color will be RGB.  The alpha value will also be interpolated.
/// @param       A               The color and alpha to interpolate from as linear RGBA
/// @param       B               The color and alpha to interpolate to as linear RGBA
/// @param       Alpha   Scalar interpolation amount (usually between 0.0 and 1.0 inclusive)
/// @return      The interpolated color in linear RGB space along with the interpolated alpha value
/// </summary>
public static FLinearColor LinearColorLerpUsingHSV(FLinearColor A,FLinearColor B,float Alpha)
{
	FLinearColor ___ret = LinearColorLerpUsingHSV(IntPtr.Zero,ref A,ref B,Alpha);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FLinearColor LinearColorLerp(IntPtr _this,ref FLinearColor A,ref FLinearColor B,float Alpha);
/// <summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
public static FLinearColor LinearColorLerp(FLinearColor A,FLinearColor B,float Alpha)
{
	FLinearColor ___ret = LinearColorLerp(IntPtr.Zero,ref A,ref B,Alpha);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float NormalizeAxis(IntPtr _this,float Angle);
/// <summary>
/// Clamps an angle to the range of [-180, 180].
/// @param Angle The Angle to clamp.
/// @return The clamped angle.
/// </summary>
public static float NormalizeAxis(float Angle)
{
	float ___ret = NormalizeAxis(IntPtr.Zero,Angle);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float ClampAxis(IntPtr _this,float Angle);
/// <summary>
/// Clamps an angle to the range of [0, 360].
/// @param Angle The angle to clamp.
/// @return The clamped angle.
/// </summary>
public static float ClampAxis(float Angle)
{
	float ___ret = ClampAxis(IntPtr.Zero,Angle);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator RotatorFromAxisAndAngle(IntPtr _this,ref FVector Axis,float Angle);
/// <summary>Create a rotation from an axis and and angle (in degrees)</summary>
public static FRotator RotatorFromAxisAndAngle(FVector Axis,float Angle)
{
	FRotator ___ret = RotatorFromAxisAndAngle(IntPtr.Zero,ref Axis,Angle);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator NormalizedDeltaRotator(IntPtr _this,ref FRotator A,ref FRotator B);
/// <summary>Normalized A-B</summary>
public static FRotator NormalizedDeltaRotator(FRotator A,FRotator B)
{
	FRotator ___ret = NormalizedDeltaRotator(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator REase(IntPtr _this,ref FRotator A,ref FRotator B,float Alpha,int bShortestPath,int EasingFunc,float BlendExp,int Steps);
/// <summary>Easeing  between A and B using a specified easing function</summary>
public static FRotator REase(FRotator A,FRotator B,float Alpha,bool bShortestPath,EEasingFunc EasingFunc,float BlendExp=2.000000f,int Steps=2)
{
	FRotator ___ret = REase(IntPtr.Zero,ref A,ref B,Alpha,bShortestPath?1:0,(int)EasingFunc,BlendExp,Steps);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator RLerp(IntPtr _this,ref FRotator A,ref FRotator B,float Alpha,int bShortestPath);
/// <summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
public static FRotator RLerp(FRotator A,FRotator B,float Alpha,bool bShortestPath)
{
	FRotator ___ret = RLerp(IntPtr.Zero,ref A,ref B,Alpha,bShortestPath?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator RandomRotator(IntPtr _this,int bRoll);
/// <summary>Generates a random rotation, with optional random roll.</summary>
public static FRotator RandomRotator(bool bRoll=false)
{
	FRotator ___ret = RandomRotator(IntPtr.Zero,bRoll?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetAxes(IntPtr _this,ref FRotator A,out FVector X,out FVector Y,out FVector Z);
/// <summary>Get the reference frame direction vectors (axes) described by this rotation</summary>
public static void GetAxes(FRotator A,out FVector X,out FVector Y,out FVector Z)
{
	GetAxes(IntPtr.Zero,ref A,out X,out Y,out Z);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator NegateRotator(IntPtr _this,ref FRotator A);
/// <summary>Negate a rotator</summary>
public static FRotator NegateRotator(FRotator A)
{
	FRotator ___ret = NegateRotator(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator ComposeRotators(IntPtr _this,ref FRotator A,ref FRotator B);
/// <summary>Combine 2 rotations to give you the resulting rotation</summary>
public static FRotator ComposeRotators(FRotator A,FRotator B)
{
	FRotator ___ret = ComposeRotators(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator Multiply_RotatorInt(IntPtr _this,ref FRotator A,int B);
/// <summary>Returns rotator representing rotator A scaled by B</summary>
public static FRotator Multiply_RotatorInt(FRotator A,int B)
{
	FRotator ___ret = Multiply_RotatorInt(IntPtr.Zero,ref A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator Multiply_RotatorFloat(IntPtr _this,ref FRotator A,float B);
/// <summary>Returns rotator representing rotator A scaled by B</summary>
public static FRotator Multiply_RotatorFloat(FRotator A,float B)
{
	FRotator ___ret = Multiply_RotatorFloat(IntPtr.Zero,ref A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_RotatorRotator(IntPtr _this,ref FRotator A,ref FRotator B,float ErrorTolerance);
/// <summary>Returns true if rotator A is not equal to rotator B (A != B) within a specified error tolerance</summary>
public static bool NotEqual_RotatorRotator(FRotator A,FRotator B,float ErrorTolerance=0.000100f)
{
	int ___ret = NotEqual_RotatorRotator(IntPtr.Zero,ref A,ref B,ErrorTolerance);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_RotatorRotator(IntPtr _this,ref FRotator A,ref FRotator B,float ErrorTolerance);
/// <summary>Returns true if rotator A is equal to rotator B (A == B) within a specified error tolerance</summary>
public static bool EqualEqual_RotatorRotator(FRotator A,FRotator B,float ErrorTolerance=0.000100f)
{
	int ___ret = EqualEqual_RotatorRotator(IntPtr.Zero,ref A,ref B,ErrorTolerance);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetDirectionUnitVector(IntPtr _this,ref FVector From,ref FVector To);
/// <summary>Find the unit direction vector from one position to another.</summary>
public static FVector GetDirectionUnitVector(FVector From,FVector To)
{
	FVector ___ret = GetDirectionUnitVector(IntPtr.Zero,ref From,ref To);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetVectorArrayAverage(IntPtr _this,FVector[] Vectors);
/// <summary>Find the average of an array of vectors</summary>
public static FVector GetVectorArrayAverage(FVector[] Vectors)
{
	FVector ___ret = GetVectorArrayAverage(IntPtr.Zero,Vectors);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetMaxElement(IntPtr _this,ref FVector A);
/// <summary>Find the maximum element (X, Y or Z) of a vector</summary>
public static float GetMaxElement(FVector A)
{
	float ___ret = GetMaxElement(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetMinElement(IntPtr _this,ref FVector A);
/// <summary>Find the minimum element (X, Y or Z) of a vector</summary>
public static float GetMinElement(FVector A)
{
	float ___ret = GetMinElement(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector ClampVectorSize(IntPtr _this,ref FVector A,float Min,float Max);
/// <summary>Clamp the vector size between a min and max length</summary>
public static FVector ClampVectorSize(FVector A,float Min,float Max)
{
	FVector ___ret = ClampVectorSize(IntPtr.Zero,ref A,Min,Max);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector NegateVector(IntPtr _this,ref FVector A);
/// <summary>Negate a vector.</summary>
public static FVector NegateVector(FVector A)
{
	FVector ___ret = NegateVector(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector ProjectVectorOnToPlane(IntPtr _this,ref FVector V,ref FVector PlaneNormal);
/// <summary>
/// Projects a vector onto a plane defined by a normalized vector (PlaneNormal).
/// @param  V Vector to project onto the plane.
/// @param  PlaneNormal Normal of the plane.
/// @return Vector projected onto the plane.
/// </summary>
public static FVector ProjectVectorOnToPlane(FVector V,FVector PlaneNormal)
{
	FVector ___ret = ProjectVectorOnToPlane(IntPtr.Zero,ref V,ref PlaneNormal);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector ProjectPointOnToPlane(IntPtr _this,ref FVector Point,ref FVector PlaneBase,ref FVector PlaneNormal);
/// <summary>
/// Projects a point onto a plane defined by a point on the plane and a plane normal.
/// @param  Point Point to project onto the plane.
/// @param  PlaneBase A point on the plane.
/// @param  PlaneNormal Normal of the plane.
/// @return Point projected onto the plane.
/// </summary>
public static FVector ProjectPointOnToPlane(FVector Point,FVector PlaneBase,FVector PlaneNormal)
{
	FVector ___ret = ProjectPointOnToPlane(IntPtr.Zero,ref Point,ref PlaneBase,ref PlaneNormal);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPointDistanceToLine(IntPtr _this,ref FVector Point,ref FVector LineOrigin,ref FVector LineDirection);
/// <summary>
/// Find the distance from a point to the closest point on an infinite line.
/// @param Point                  Point for which we find the distance to the closest point on the line.
/// @param LineOrigin             Point of reference on the line.
/// @param LineDirection  Direction of the line. Not required to be normalized.
/// @return The distance from the given point to the closest point on the line.
/// </summary>
public static float GetPointDistanceToLine(FVector Point,FVector LineOrigin,FVector LineDirection)
{
	float ___ret = GetPointDistanceToLine(IntPtr.Zero,ref Point,ref LineOrigin,ref LineDirection);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPointDistanceToSegment(IntPtr _this,ref FVector Point,ref FVector SegmentStart,ref FVector SegmentEnd);
/// <summary>
/// Find the distance from a point to the closest point on a segment.
/// @param Point                  Point for which we find the distance to the closest point on the segment.
/// @param SegmentStart   Start of the segment.
/// @param SegmentEnd             End of the segment.
/// @return The distance from the given point to the closest point on the segment.
/// </summary>
public static float GetPointDistanceToSegment(FVector Point,FVector SegmentStart,FVector SegmentEnd)
{
	float ___ret = GetPointDistanceToSegment(IntPtr.Zero,ref Point,ref SegmentStart,ref SegmentEnd);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector FindClosestPointOnLine(IntPtr _this,ref FVector Point,ref FVector LineOrigin,ref FVector LineDirection);
/// <summary>
/// Find the closest point on an infinite line to a given point.
/// @param Point                 Point for which we find the closest point on the line.
/// @param LineOrigin    Point of reference on the line.
/// @param LineDirection Direction of the line. Not required to be normalized.
/// @return The closest point on the line to the given point.
/// </summary>
public static FVector FindClosestPointOnLine(FVector Point,FVector LineOrigin,FVector LineDirection)
{
	FVector ___ret = FindClosestPointOnLine(IntPtr.Zero,ref Point,ref LineOrigin,ref LineDirection);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector FindClosestPointOnSegment(IntPtr _this,ref FVector Point,ref FVector SegmentStart,ref FVector SegmentEnd);
/// <summary>
/// Find the closest point on a segment to a given point.
/// @param Point                 Point for which we find the closest point on the segment.
/// @param SegmentStart  Start of the segment.
/// @param SegmentEnd    End of the segment.
/// @return The closest point on the segment to the given point.
/// </summary>
public static FVector FindClosestPointOnSegment(FVector Point,FVector SegmentStart,FVector SegmentEnd)
{
	FVector ___ret = FindClosestPointOnSegment(IntPtr.Zero,ref Point,ref SegmentStart,ref SegmentEnd);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void FindNearestPointsOnLineSegments(IntPtr _this,ref FVector Segment1Start,ref FVector Segment1End,ref FVector Segment2Start,ref FVector Segment2End,out FVector Segment1Point,out FVector Segment2Point);
/// <summary>
/// Find closest points between 2 segments.
/// @param       Segment1Start   Start of the 1st segment.
/// @param       Segment1End             End of the 1st segment.
/// @param       Segment2Start   Start of the 2nd segment.
/// @param       Segment2End             End of the 2nd segment.
/// @param       Segment1Point   Closest point on segment 1 to segment 2.
/// @param       Segment2Point   Closest point on segment 2 to segment 1.
/// </summary>
public static void FindNearestPointsOnLineSegments(FVector Segment1Start,FVector Segment1End,FVector Segment2Start,FVector Segment2End,out FVector Segment1Point,out FVector Segment2Point)
{
	FindNearestPointsOnLineSegments(IntPtr.Zero,ref Segment1Start,ref Segment1End,ref Segment2Start,ref Segment2End,out Segment1Point,out Segment2Point);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector ProjectVectorOnToVector(IntPtr _this,ref FVector V,ref FVector Target);
/// <summary>
/// Projects one vector (V) onto another (Target) and returns the projected vector.
/// If Target is nearly zero in length, returns the zero vector.
/// @param  V Vector to project.
/// @param  Target Vector on which we are projecting.
/// @return V projected on to Target.
/// </summary>
public static FVector ProjectVectorOnToVector(FVector V,FVector Target)
{
	FVector ___ret = ProjectVectorOnToVector(IntPtr.Zero,ref V,ref Target);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector MirrorVectorByNormal(IntPtr _this,ref FVector InVect,ref FVector InNormal);
/// <summary>Mirrors a vector by a normal</summary>
public static FVector MirrorVectorByNormal(FVector InVect,FVector InNormal)
{
	FVector ___ret = MirrorVectorByNormal(IntPtr.Zero,ref InVect,ref InNormal);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector RandomUnitVectorInConeWithYawAndPitch(IntPtr _this,ref FVector ConeDir,float MaxYawInDegrees,float MaxPitchInDegrees);
/// <summary>
/// RandomUnitVectorWithYawAndPitch
/// @param MaxYaw - The Yaw-angle of the cone (from ConeDir to horizontal-edge), in degrees.
/// @param MaxPitch - The Pitch-angle of the cone (from ConeDir to vertical-edge), in degrees.
/// </summary>
public static FVector RandomUnitVectorInConeWithYawAndPitch(FVector ConeDir,float MaxYawInDegrees,float MaxPitchInDegrees)
{
	FVector ___ret = RandomUnitVectorInConeWithYawAndPitch(IntPtr.Zero,ref ConeDir,MaxYawInDegrees,MaxPitchInDegrees);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector RandomUnitVectorInCone(IntPtr _this,ref FVector ConeDir,float ConeHalfAngle);
/// <summary>
/// Returns a random vector with length of 1, within the specified cone, with uniform random distribution.
/// @param ConeDir       The base "center" direction of the cone.
/// @param ConeHalfAngle         The half-angle of the cone (from ConeDir to edge), in radians.
/// </summary>
public static FVector RandomUnitVectorInCone(FVector ConeDir,float ConeHalfAngle)
{
	FVector ___ret = RandomUnitVectorInCone(IntPtr.Zero,ref ConeDir,ConeHalfAngle);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector RandomPointInBoundingBox(IntPtr _this,ref FVector Origin,ref FVector BoxExtent);
/// <summary>Returns a random point within the specified bounding box</summary>
public static FVector RandomPointInBoundingBox(FVector Origin,FVector BoxExtent)
{
	FVector ___ret = RandomPointInBoundingBox(IntPtr.Zero,ref Origin,ref BoxExtent);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector RandomUnitVector(IntPtr _this);
/// <summary>Returns a random vector with length of 1</summary>
public static FVector RandomUnitVector()
{
	FVector ___ret = RandomUnitVector(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector VEase(IntPtr _this,ref FVector A,ref FVector B,float Alpha,int EasingFunc,float BlendExp,int Steps);
/// <summary>Easeing  between A and B using a specified easing function</summary>
public static FVector VEase(FVector A,FVector B,float Alpha,EEasingFunc EasingFunc,float BlendExp=2.000000f,int Steps=2)
{
	FVector ___ret = VEase(IntPtr.Zero,ref A,ref B,Alpha,(int)EasingFunc,BlendExp,Steps);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector VLerp(IntPtr _this,ref FVector A,ref FVector B,float Alpha);
/// <summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
public static FVector VLerp(FVector A,FVector B,float Alpha)
{
	FVector ___ret = VLerp(IntPtr.Zero,ref A,ref B,Alpha);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D Normal2D(IntPtr _this,ref FVector2D A);
/// <summary>Returns a unit normal version of the vector2d A</summary>
public static FVector2D Normal2D(FVector2D A)
{
	FVector2D ___ret = Normal2D(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Normal(IntPtr _this,ref FVector A);
/// <summary>Returns a unit normal version of the FVector A</summary>
public static FVector Normal(FVector A)
{
	FVector ___ret = Normal(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float VSize2DSquared(IntPtr _this,ref FVector2D A);
/// <summary>Returns the squared length of a 2d FVector.</summary>
public static float VSize2DSquared(FVector2D A)
{
	float ___ret = VSize2DSquared(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float VSizeSquared(IntPtr _this,ref FVector A);
/// <summary>Returns the squared length of the FVector</summary>
public static float VSizeSquared(FVector A)
{
	float ___ret = VSizeSquared(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float VSize2D(IntPtr _this,ref FVector2D A);
/// <summary>Returns the length of a 2d FVector.</summary>
public static float VSize2D(FVector2D A)
{
	float ___ret = VSize2D(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float VSize(IntPtr _this,ref FVector A);
/// <summary>Returns the length of the FVector</summary>
public static float VSize(FVector A)
{
	float ___ret = VSize(IntPtr.Zero,ref A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float CrossProduct2D(IntPtr _this,ref FVector2D A,ref FVector2D B);
/// <summary>Returns the cross product of two 2d vectors</summary>
public static float CrossProduct2D(FVector2D A,FVector2D B)
{
	float ___ret = CrossProduct2D(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float DotProduct2D(IntPtr _this,ref FVector2D A,ref FVector2D B);
/// <summary>Returns the dot product of two 2d vectors</summary>
public static float DotProduct2D(FVector2D A,FVector2D B)
{
	float ___ret = DotProduct2D(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Cross_VectorVector(IntPtr _this,ref FVector A,ref FVector B);
/// <summary>Returns the cross product of two 3d vectors</summary>
public static FVector Cross_VectorVector(FVector A,FVector B)
{
	FVector ___ret = Cross_VectorVector(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Dot_VectorVector(IntPtr _this,ref FVector A,ref FVector B);
/// <summary>Returns the dot product of two 3d vectors</summary>
public static float Dot_VectorVector(FVector A,FVector B)
{
	float ___ret = Dot_VectorVector(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_VectorVector(IntPtr _this,ref FVector A,ref FVector B,float ErrorTolerance);
/// <summary>Returns true if vector A is not equal to vector B (A != B) within a specified error tolerance</summary>
public static bool NotEqual_VectorVector(FVector A,FVector B,float ErrorTolerance=0.000100f)
{
	int ___ret = NotEqual_VectorVector(IntPtr.Zero,ref A,ref B,ErrorTolerance);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_VectorVector(IntPtr _this,ref FVector A,ref FVector B,float ErrorTolerance);
/// <summary>Returns true if vector A is equal to vector B (A == B) within a specified error tolerance</summary>
public static bool EqualEqual_VectorVector(FVector A,FVector B,float ErrorTolerance=0.000100f)
{
	int ___ret = EqualEqual_VectorVector(IntPtr.Zero,ref A,ref B,ErrorTolerance);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector RotateAngleAxis(IntPtr _this,ref FVector InVect,float AngleDeg,ref FVector Axis);
/// <summary>Returns result of vector A rotated by AngleDeg around Axis</summary>
public static FVector RotateAngleAxis(FVector InVect,float AngleDeg,FVector Axis)
{
	FVector ___ret = RotateAngleAxis(IntPtr.Zero,ref InVect,AngleDeg,ref Axis);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GreaterGreater_VectorRotator(IntPtr _this,ref FVector A,ref FRotator B);
/// <summary>Returns result of vector A rotated by Rotator B</summary>
public static FVector GreaterGreater_VectorRotator(FVector A,FRotator B)
{
	FVector ___ret = GreaterGreater_VectorRotator(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector LessLess_VectorRotator(IntPtr _this,ref FVector A,ref FRotator B);
/// <summary>Returns result of vector A rotated by the inverse of Rotator B</summary>
public static FVector LessLess_VectorRotator(FVector A,FRotator B)
{
	FVector ___ret = LessLess_VectorRotator(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Subtract_VectorInt(IntPtr _this,ref FVector A,int B);
/// <summary>Subtracts an integer from each component of a vector</summary>
public static FVector Subtract_VectorInt(FVector A,int B)
{
	FVector ___ret = Subtract_VectorInt(IntPtr.Zero,ref A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Subtract_VectorFloat(IntPtr _this,ref FVector A,float B);
/// <summary>Subtracts a float from each component of a vector</summary>
public static FVector Subtract_VectorFloat(FVector A,float B)
{
	FVector ___ret = Subtract_VectorFloat(IntPtr.Zero,ref A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Subtract_VectorVector(IntPtr _this,ref FVector A,ref FVector B);
/// <summary>Vector subtraction</summary>
public static FVector Subtract_VectorVector(FVector A,FVector B)
{
	FVector ___ret = Subtract_VectorVector(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Add_VectorInt(IntPtr _this,ref FVector A,int B);
/// <summary>Adds an integer to each component of a vector</summary>
public static FVector Add_VectorInt(FVector A,int B)
{
	FVector ___ret = Add_VectorInt(IntPtr.Zero,ref A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Add_VectorFloat(IntPtr _this,ref FVector A,float B);
/// <summary>Adds a float to each component of a vector</summary>
public static FVector Add_VectorFloat(FVector A,float B)
{
	FVector ___ret = Add_VectorFloat(IntPtr.Zero,ref A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Add_VectorVector(IntPtr _this,ref FVector A,ref FVector B);
/// <summary>Vector addition</summary>
public static FVector Add_VectorVector(FVector A,FVector B)
{
	FVector ___ret = Add_VectorVector(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Divide_VectorVector(IntPtr _this,ref FVector A,ref FVector B);
/// <summary>Vector divide by vector</summary>
public static FVector Divide_VectorVector(FVector A,FVector B=default(FVector))
{
	FVector ___ret = Divide_VectorVector(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Divide_VectorInt(IntPtr _this,ref FVector A,int B);
/// <summary>Vector divide by an integer</summary>
public static FVector Divide_VectorInt(FVector A,int B=1)
{
	FVector ___ret = Divide_VectorInt(IntPtr.Zero,ref A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Divide_VectorFloat(IntPtr _this,ref FVector A,float B);
/// <summary>Vector divide by a float</summary>
public static FVector Divide_VectorFloat(FVector A,float B=1.000000f)
{
	FVector ___ret = Divide_VectorFloat(IntPtr.Zero,ref A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Multiply_VectorVector(IntPtr _this,ref FVector A,ref FVector B);
/// <summary>Element-wise Vector multiplication (Result = {A.x*B.x, A.y*B.y, A.z*B.z})</summary>
public static FVector Multiply_VectorVector(FVector A,FVector B)
{
	FVector ___ret = Multiply_VectorVector(IntPtr.Zero,ref A,ref B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Multiply_VectorInt(IntPtr _this,ref FVector A,int B);
/// <summary>Scales Vector A by B</summary>
public static FVector Multiply_VectorInt(FVector A,int B)
{
	FVector ___ret = Multiply_VectorInt(IntPtr.Zero,ref A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Multiply_VectorFloat(IntPtr _this,ref FVector A,float B);
/// <summary>Scales Vector A by B</summary>
public static FVector Multiply_VectorFloat(FVector A,float B)
{
	FVector ___ret = Multiply_VectorFloat(IntPtr.Zero,ref A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float FixedTurn(IntPtr _this,float InCurrent,float InDesired,float InDeltaRate);
/// <summary>
/// Returns a new rotation component value
/// @param InCurrent is the current rotation value
/// @param InDesired is the desired rotation value
/// @param  is the rotation amount to apply
/// @return a new rotation component value clamped in the range (-360,360)
/// </summary>
public static float FixedTurn(float InCurrent,float InDesired,float InDeltaRate)
{
	float ___ret = FixedTurn(IntPtr.Zero,InCurrent,InDesired,InDeltaRate);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float MakePulsatingValue(IntPtr _this,float InCurrentTime,float InPulsesPerSecond,float InPhase);
/// <summary>
/// Simple function to create a pulsating scalar value
/// @param  InCurrentTime  Current absolute time
/// @param  InPulsesPerSecond  How many full pulses per second?
/// @param  InPhase  Optional phase amount, between 0.0 and 1.0 (to synchronize pulses)
/// @return  Pulsating value (0.0-1.0)
/// </summary>
public static float MakePulsatingValue(float InCurrentTime,float InPulsesPerSecond=1.000000f,float InPhase=0.000000f)
{
	float ___ret = MakePulsatingValue(IntPtr.Zero,InCurrentTime,InPulsesPerSecond,InPhase);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float FInterpEaseInOut(IntPtr _this,float A,float B,float Alpha,float Exponent);
/// <summary>Interpolate between A and B, applying an ease in/out function.  Exp controls the degree of the curve.</summary>
public static float FInterpEaseInOut(float A,float B,float Alpha,float Exponent)
{
	float ___ret = FInterpEaseInOut(IntPtr.Zero,A,B,Alpha,Exponent);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float MultiplyByPi(IntPtr _this,float Value);
/// <summary>Multiplies the input value by pi.</summary>
public static float MultiplyByPi(float Value)
{
	float ___ret = MultiplyByPi(IntPtr.Zero,Value);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float MapRangeClamped(IntPtr _this,float Value,float InRangeA,float InRangeB,float OutRangeA,float OutRangeB);
/// <summary>Returns Value mapped from one range into another where the Value is clamped to the Input Range.  (e.g. 0.5 normalized from the range 0->1 to 0->50 would result in 25)</summary>
public static float MapRangeClamped(float Value,float InRangeA,float InRangeB,float OutRangeA,float OutRangeB)
{
	float ___ret = MapRangeClamped(IntPtr.Zero,Value,InRangeA,InRangeB,OutRangeA,OutRangeB);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float MapRangeUnclamped(IntPtr _this,float Value,float InRangeA,float InRangeB,float OutRangeA,float OutRangeB);
/// <summary>Returns Value mapped from one range into another.  (e.g. 20 normalized from the range 10->50 to 20->40 would result in 25)</summary>
public static float MapRangeUnclamped(float Value,float InRangeA,float InRangeB,float OutRangeA,float OutRangeB)
{
	float ___ret = MapRangeUnclamped(IntPtr.Zero,Value,InRangeA,InRangeB,OutRangeA,OutRangeB);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float NormalizeToRange(IntPtr _this,float Value,float RangeMin,float RangeMax);
/// <summary>Returns Value normalized to the given range.  (e.g. 20 normalized to the range 10->50 would result in 0.25)</summary>
public static float NormalizeToRange(float Value,float RangeMin,float RangeMax)
{
	float ___ret = NormalizeToRange(IntPtr.Zero,Value,RangeMin,RangeMax);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float SignOfFloat(IntPtr _this,float A);
/// <summary>Sign (float, returns -1 if A < 0, 0 if A is zero, and +1 if A > 0)</summary>
public static float SignOfFloat(float A)
{
	float ___ret = SignOfFloat(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int FMod(IntPtr _this,float Dividend,float Divisor,out float Remainder);
/// <summary>Returns the number of times Divisor will go into Dividend (i.e., Dividend divided by Divisor), as well as the remainder</summary>
public static int FMod(float Dividend,float Divisor,out float Remainder)
{
	int ___ret = FMod(IntPtr.Zero,Dividend,Divisor,out Remainder);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int FCeil(IntPtr _this,float A);
/// <summary>Rounds A to the smallest following integer</summary>
public static int FCeil(float A)
{
	int ___ret = FCeil(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int FTrunc(IntPtr _this,float A);
/// <summary>Rounds A to an integer with truncation towards zero.  (e.g. -1.7 truncated to -1, 2.8 truncated to 2)</summary>
public static int FTrunc(float A)
{
	int ___ret = FTrunc(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int FFloor(IntPtr _this,float A);
/// <summary>Rounds A to the largest previous integer</summary>
public static int FFloor(float A)
{
	int ___ret = FFloor(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Round(IntPtr _this,float A);
/// <summary>Rounds A to the nearest integer</summary>
public static int Round(float A)
{
	int ___ret = Round(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Ease(IntPtr _this,float A,float B,float Alpha,int EasingFunc,float BlendExp,int Steps);
/// <summary>Easeing  between A and B using a specified easing function</summary>
public static float Ease(float A,float B,float Alpha,EEasingFunc EasingFunc,float BlendExp=2.000000f,int Steps=2)
{
	float ___ret = Ease(IntPtr.Zero,A,B,Alpha,(int)EasingFunc,BlendExp,Steps);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float InverseLerp(IntPtr _this,float A,float B,float Value);
/// <summary>
/// Returns the percentage of the range B-A that corresponds to Value. E.g.,
///       A = 0, B = 8, Value = 3 : return value = 3/8, indicating Value is 3/8 from A to B
///       A = 8, B = 0, Value = 3 : return value = 5/8, indicating Value is 5/8 from A to B
/// Named InverseLerp because Lerp( A, B, InverseLerp(A, B, Value) ) == Value
/// @param A The "from" value this float could be, usually but not necessarily a minimum. Returned as 0.
/// @param B The "to" value this float could be, usually but not necessarily a maximum. Returned as 1.
/// @param Value A value intended to be normalized relative to B-A
/// @return A normalized value considering A and B.
/// </summary>
public static float InverseLerp(float A,float B,float Value)
{
	float ___ret = InverseLerp(IntPtr.Zero,A,B,Value);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Lerp(IntPtr _this,float A,float B,float Alpha);
/// <summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
public static float Lerp(float A,float B,float Alpha)
{
	float ___ret = Lerp(IntPtr.Zero,A,B,Alpha);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MinOfByteArray(IntPtr _this,byte[] ByteArray,out int IndexOfMinValue,out int MinValue);
/// <summary>Returns min of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
public static void MinOfByteArray(byte[] ByteArray,out int IndexOfMinValue,out byte MinValue)
{
	int MinValue_temp;
	MinOfByteArray(IntPtr.Zero,ByteArray,out IndexOfMinValue,out MinValue_temp);
	MinValue=(byte)MinValue_temp;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MaxOfByteArray(IntPtr _this,byte[] ByteArray,out int IndexOfMaxValue,out int MaxValue);
/// <summary>Returns max of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
public static void MaxOfByteArray(byte[] ByteArray,out int IndexOfMaxValue,out byte MaxValue)
{
	int MaxValue_temp;
	MaxOfByteArray(IntPtr.Zero,ByteArray,out IndexOfMaxValue,out MaxValue_temp);
	MaxValue=(byte)MaxValue_temp;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MinOfFloatArray(IntPtr _this,float[] FloatArray,out int IndexOfMinValue,out float MinValue);
/// <summary>Returns min of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
public static void MinOfFloatArray(float[] FloatArray,out int IndexOfMinValue,out float MinValue)
{
	MinOfFloatArray(IntPtr.Zero,FloatArray,out IndexOfMinValue,out MinValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MaxOfFloatArray(IntPtr _this,float[] FloatArray,out int IndexOfMaxValue,out float MaxValue);
/// <summary>Returns max of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
public static void MaxOfFloatArray(float[] FloatArray,out int IndexOfMaxValue,out float MaxValue)
{
	MaxOfFloatArray(IntPtr.Zero,FloatArray,out IndexOfMaxValue,out MaxValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MinOfIntArray(IntPtr _this,int[] IntArray,out int IndexOfMinValue,out int MinValue);
/// <summary>Returns min of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
public static void MinOfIntArray(int[] IntArray,out int IndexOfMinValue,out int MinValue)
{
	MinOfIntArray(IntPtr.Zero,IntArray,out IndexOfMinValue,out MinValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MaxOfIntArray(IntPtr _this,int[] IntArray,out int IndexOfMaxValue,out int MaxValue);
/// <summary>Returns max of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
public static void MaxOfIntArray(int[] IntArray,out int IndexOfMaxValue,out int MaxValue)
{
	MaxOfIntArray(IntPtr.Zero,IntArray,out IndexOfMaxValue,out MaxValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float FClamp(IntPtr _this,float Value,float Min,float Max);
/// <summary>Returns V clamped to be between A and B (inclusive)</summary>
public static float FClamp(float Value,float Min,float Max)
{
	float ___ret = FClamp(IntPtr.Zero,Value,Min,Max);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float FMax(IntPtr _this,float A,float B);
/// <summary>Returns the maximum value of A and B</summary>
public static float FMax(float A,float B)
{
	float ___ret = FMax(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float FMin(IntPtr _this,float A,float B);
/// <summary>Returns the minimum value of A and B</summary>
public static float FMin(float A,float B)
{
	float ___ret = FMin(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float ClampAngle(IntPtr _this,float AngleDegrees,float MinAngleDegrees,float MaxAngleDegrees);
/// <summary>
/// Clamps an arbitrary angle to be between the given angles.  Will clamp to nearest boundary.
/// @param MinAngleDegrees       "from" angle that defines the beginning of the range of valid angles (sweeping clockwise)
/// @param MaxAngleDegrees       "to" angle that defines the end of the range of valid angles
/// @return Returns clamped angle in the range -180..180.
/// </summary>
public static float ClampAngle(float AngleDegrees,float MinAngleDegrees,float MaxAngleDegrees)
{
	float ___ret = ClampAngle(IntPtr.Zero,AngleDegrees,MinAngleDegrees,MaxAngleDegrees);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float DegAtan2(IntPtr _this,float A,float B);
/// <summary>Returns the inverse tan (atan2) of A/B (result is in Degrees)</summary>
public static float DegAtan2(float A,float B)
{
	float ___ret = DegAtan2(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float DegAtan(IntPtr _this,float A);
/// <summary>Returns the inverse tan (atan) (result is in Degrees)</summary>
public static float DegAtan(float A)
{
	float ___ret = DegAtan(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float DegTan(IntPtr _this,float A);
/// <summary>Returns the tan of A (expects Degrees)</summary>
public static float DegTan(float A)
{
	float ___ret = DegTan(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float DegAcos(IntPtr _this,float A);
/// <summary>Returns the inverse cos (arccos) of A (result is in Degrees)</summary>
public static float DegAcos(float A)
{
	float ___ret = DegAcos(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float DegCos(IntPtr _this,float A);
/// <summary>Returns the cos of A (expects Degrees)</summary>
public static float DegCos(float A)
{
	float ___ret = DegCos(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float DegAsin(IntPtr _this,float A);
/// <summary>Returns the inverse sin (arcsin) of A (result is in Degrees)</summary>
public static float DegAsin(float A)
{
	float ___ret = DegAsin(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float DegSin(IntPtr _this,float A);
/// <summary>Returns the sin of A (expects Degrees)</summary>
public static float DegSin(float A)
{
	float ___ret = DegSin(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float RadiansToDegrees(IntPtr _this,float A);
/// <summary>Returns degrees value based on the input radians</summary>
public static float RadiansToDegrees(float A)
{
	float ___ret = RadiansToDegrees(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float DegreesToRadians(IntPtr _this,float A);
/// <summary>Returns radians value based on the input degrees</summary>
public static float DegreesToRadians(float A)
{
	float ___ret = DegreesToRadians(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetTAU(IntPtr _this);
/// <summary>Returns the value of TAU (= 2 * PI)</summary>
public static float GetTAU()
{
	float ___ret = GetTAU(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPI(IntPtr _this);
/// <summary>Returns the value of PI</summary>
public static float GetPI()
{
	float ___ret = GetPI(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float RandomFloatInRange(IntPtr _this,float Min,float Max);
/// <summary>Generate a random number between Min and Max</summary>
public static float RandomFloatInRange(float Min,float Max)
{
	float ___ret = RandomFloatInRange(IntPtr.Zero,Min,Max);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float RandomFloat(IntPtr _this);
/// <summary>Returns a random float between 0 and 1</summary>
public static float RandomFloat()
{
	float ___ret = RandomFloat(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Square(IntPtr _this,float A);
/// <summary>Returns square of A (A*A)</summary>
public static float Square(float A)
{
	float ___ret = Square(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Sqrt(IntPtr _this,float A);
/// <summary>Returns square root of A</summary>
public static float Sqrt(float A)
{
	float ___ret = Sqrt(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Loge(IntPtr _this,float A);
/// <summary>Returns natural log of A (if e^R == A, returns R)</summary>
public static float Loge(float A)
{
	float ___ret = Loge(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Exp(IntPtr _this,float A);
/// <summary>Returns exponential(e) to the power A (e^A)</summary>
public static float Exp(float A)
{
	float ___ret = Exp(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Atan2(IntPtr _this,float A,float B);
/// <summary>Returns the inverse tan (atan2) of A/B (result is in Radians)</summary>
public static float Atan2(float A,float B)
{
	float ___ret = Atan2(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Atan(IntPtr _this,float A);
/// <summary>Returns the inverse tan (atan) (result is in Radians)</summary>
public static float Atan(float A)
{
	float ___ret = Atan(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Tan(IntPtr _this,float A);
/// <summary>Returns the tan of A (expects Radians)</summary>
public static float Tan(float A)
{
	float ___ret = Tan(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Acos(IntPtr _this,float A);
/// <summary>Returns the inverse cosine (arccos) of A (result is in Radians)</summary>
public static float Acos(float A)
{
	float ___ret = Acos(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Cos(IntPtr _this,float A);
/// <summary>Returns the cosine of A (expects Radians)</summary>
public static float Cos(float A)
{
	float ___ret = Cos(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Asin(IntPtr _this,float A);
/// <summary>Returns the inverse sine (arcsin) of A (result is in Radians)</summary>
public static float Asin(float A)
{
	float ___ret = Asin(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Sin(IntPtr _this,float A);
/// <summary>Returns the sine of A (expects Radians)</summary>
public static float Sin(float A)
{
	float ___ret = Sin(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Abs(IntPtr _this,float A);
/// <summary>Returns the absolute (positive) value of A</summary>
public static float Abs(float A)
{
	float ___ret = Abs(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GridSnap_Float(IntPtr _this,float Location,float GridSize);
/// <summary>
/// Snaps a value to the nearest grid multiple. E.g.,
///             Location = 5.1, GridSize = 10.0 : return value = 10.0
/// If GridSize is 0 Location is returned
/// if GridSize is very small precision issues may occur.
/// </summary>
public static float GridSnap_Float(float Location,float GridSize)
{
	float ___ret = GridSnap_Float(IntPtr.Zero,Location,GridSize);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Hypotenuse(IntPtr _this,float Width,float Height);
/// <summary>Returns the hypotenuse of a right-angled triangle given the width and height.</summary>
public static float Hypotenuse(float Width,float Height)
{
	float ___ret = Hypotenuse(IntPtr.Zero,Width,Height);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int InRange_FloatFloat(IntPtr _this,float Value,float Min,float Max,int InclusiveMin,int InclusiveMax);
/// <summary>Returns V clamped to be between A and B (inclusive)</summary>
public static bool InRange_FloatFloat(float Value,float Min,float Max,bool InclusiveMin=true,bool InclusiveMax=true)
{
	int ___ret = InRange_FloatFloat(IntPtr.Zero,Value,Min,Max,InclusiveMin?1:0,InclusiveMax?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_FloatFloat(IntPtr _this,float A,float B);
/// <summary>Returns true if A does not equal B (A != B)</summary>
public static bool NotEqual_FloatFloat(float A,float B)
{
	int ___ret = NotEqual_FloatFloat(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NearlyEqual_FloatFloat(IntPtr _this,float A,float B,float ErrorTolerance);
/// <summary>Returns true if A is nearly equal to B (|A - B| < ErrorTolerance)</summary>
public static bool NearlyEqual_FloatFloat(float A,float B,float ErrorTolerance=0.000001f)
{
	int ___ret = NearlyEqual_FloatFloat(IntPtr.Zero,A,B,ErrorTolerance);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_FloatFloat(IntPtr _this,float A,float B);
/// <summary>Returns true if A is exactly equal to B (A == B)</summary>
public static bool EqualEqual_FloatFloat(float A,float B)
{
	int ___ret = EqualEqual_FloatFloat(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GreaterEqual_FloatFloat(IntPtr _this,float A,float B);
/// <summary>Returns true if A is greater than or equal to B (A >= B)</summary>
public static bool GreaterEqual_FloatFloat(float A,float B)
{
	int ___ret = GreaterEqual_FloatFloat(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int LessEqual_FloatFloat(IntPtr _this,float A,float B);
/// <summary>Returns true if A is Less than or equal to B (A <= B)</summary>
public static bool LessEqual_FloatFloat(float A,float B)
{
	int ___ret = LessEqual_FloatFloat(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Greater_FloatFloat(IntPtr _this,float A,float B);
/// <summary>Returns true if A is greater than B (A > B)</summary>
public static bool Greater_FloatFloat(float A,float B)
{
	int ___ret = Greater_FloatFloat(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Less_FloatFloat(IntPtr _this,float A,float B);
/// <summary>Returns true if A is Less than B (A < B)</summary>
public static bool Less_FloatFloat(float A,float B)
{
	int ___ret = Less_FloatFloat(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Subtract_FloatFloat(IntPtr _this,float A,float B);
/// <summary>Subtraction (A - B)</summary>
public static float Subtract_FloatFloat(float A,float B=1.000000f)
{
	float ___ret = Subtract_FloatFloat(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Add_FloatFloat(IntPtr _this,float A,float B);
/// <summary>Addition (A + B)</summary>
public static float Add_FloatFloat(float A,float B=1.000000f)
{
	float ___ret = Add_FloatFloat(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Fraction(IntPtr _this,float A);
/// <summary>Returns the fractional part of a float.</summary>
public static float Fraction(float A)
{
	float ___ret = Fraction(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Percent_FloatFloat(IntPtr _this,float A,float B);
/// <summary>Modulo (A % B)</summary>
public static float Percent_FloatFloat(float A,float B=1.000000f)
{
	float ___ret = Percent_FloatFloat(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Divide_FloatFloat(IntPtr _this,float A,float B);
/// <summary>Division (A / B)</summary>
public static float Divide_FloatFloat(float A,float B=1.000000f)
{
	float ___ret = Divide_FloatFloat(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Multiply_IntFloat(IntPtr _this,int A,float B);
/// <summary>Multiplication (A * B)</summary>
public static float Multiply_IntFloat(int A,float B)
{
	float ___ret = Multiply_IntFloat(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Multiply_FloatFloat(IntPtr _this,float A,float B);
/// <summary>Multiplication (A * B)</summary>
public static float Multiply_FloatFloat(float A,float B)
{
	float ___ret = Multiply_FloatFloat(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float MultiplyMultiply_FloatFloat(IntPtr _this,float Base,float Exp);
/// <summary>Power (Base to the Exp-th power)</summary>
public static float MultiplyMultiply_FloatFloat(float Base,float Exp)
{
	float ___ret = MultiplyMultiply_FloatFloat(IntPtr.Zero,Base,Exp);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Abs_Int(IntPtr _this,int A);
/// <summary>Returns the absolute (positive) value of A</summary>
public static int Abs_Int(int A)
{
	int ___ret = Abs_Int(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Clamp(IntPtr _this,int Value,int Min,int Max);
/// <summary>Returns Value clamped to be between A and B (inclusive)</summary>
public static int Clamp(int Value,int Min,int Max)
{
	int ___ret = Clamp(IntPtr.Zero,Value,Min,Max);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Max(IntPtr _this,int A,int B);
/// <summary>Returns the maximum value of A and B</summary>
public static int Max(int A,int B)
{
	int ___ret = Max(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Min(IntPtr _this,int A,int B);
/// <summary>Returns the minimum value of A and B</summary>
public static int Min(int A,int B)
{
	int ___ret = Min(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RandomIntegerInRange(IntPtr _this,int Min,int Max);
/// <summary>Return a random integer between Min and Max (>= Min and <= Max)</summary>
public static int RandomIntegerInRange(int Min,int Max)
{
	int ___ret = RandomIntegerInRange(IntPtr.Zero,Min,Max);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RandomInteger(IntPtr _this,int Max);
/// <summary>Returns a uniformly distributed random number between 0 and Max - 1</summary>
public static int RandomInteger(int Max)
{
	int ___ret = RandomInteger(IntPtr.Zero,Max);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SignOfInteger(IntPtr _this,int A);
/// <summary>Sign (integer, returns -1 if A < 0, 0 if A is zero, and +1 if A > 0)</summary>
public static int SignOfInteger(int A)
{
	int ___ret = SignOfInteger(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Not_Int(IntPtr _this,int A);
/// <summary>Bitwise NOT (~A)</summary>
public static int Not_Int(int A)
{
	int ___ret = Not_Int(IntPtr.Zero,A);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Or_IntInt(IntPtr _this,int A,int B);
/// <summary>Bitwise OR (A | B)</summary>
public static int Or_IntInt(int A,int B)
{
	int ___ret = Or_IntInt(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Xor_IntInt(IntPtr _this,int A,int B);
/// <summary>Bitwise XOR (A ^ B)</summary>
public static int Xor_IntInt(int A,int B)
{
	int ___ret = Xor_IntInt(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int And_IntInt(IntPtr _this,int A,int B);
/// <summary>Bitwise AND (A & B)</summary>
public static int And_IntInt(int A,int B)
{
	int ___ret = And_IntInt(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_IntInt(IntPtr _this,int A,int B);
/// <summary>Returns true if A is not equal to B (A != B)</summary>
public static bool NotEqual_IntInt(int A,int B)
{
	int ___ret = NotEqual_IntInt(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_IntInt(IntPtr _this,int A,int B);
/// <summary>Returns true if A is equal to B (A == B)</summary>
public static bool EqualEqual_IntInt(int A,int B)
{
	int ___ret = EqualEqual_IntInt(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GreaterEqual_IntInt(IntPtr _this,int A,int B);
/// <summary>Returns true if A is greater than or equal to B (A >= B)</summary>
public static bool GreaterEqual_IntInt(int A,int B)
{
	int ___ret = GreaterEqual_IntInt(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int LessEqual_IntInt(IntPtr _this,int A,int B);
/// <summary>Returns true if A is less than or equal to B (A <= B)</summary>
public static bool LessEqual_IntInt(int A,int B)
{
	int ___ret = LessEqual_IntInt(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Greater_IntInt(IntPtr _this,int A,int B);
/// <summary>Returns true if A is greater than B (A > B)</summary>
public static bool Greater_IntInt(int A,int B)
{
	int ___ret = Greater_IntInt(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Less_IntInt(IntPtr _this,int A,int B);
/// <summary>Returns true if A is less than B (A < B)</summary>
public static bool Less_IntInt(int A,int B)
{
	int ___ret = Less_IntInt(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Subtract_IntInt(IntPtr _this,int A,int B);
/// <summary>Subtraction (A - B)</summary>
public static int Subtract_IntInt(int A,int B=1)
{
	int ___ret = Subtract_IntInt(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Add_IntInt(IntPtr _this,int A,int B);
/// <summary>Addition (A + B)</summary>
public static int Add_IntInt(int A,int B=1)
{
	int ___ret = Add_IntInt(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Percent_IntInt(IntPtr _this,int A,int B);
/// <summary>Modulo (A % B)</summary>
public static int Percent_IntInt(int A,int B=1)
{
	int ___ret = Percent_IntInt(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Divide_IntInt(IntPtr _this,int A,int B);
/// <summary>Division (A / B)</summary>
public static int Divide_IntInt(int A,int B=1)
{
	int ___ret = Divide_IntInt(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Multiply_IntInt(IntPtr _this,int A,int B);
/// <summary>Multiplication (A * B)</summary>
public static int Multiply_IntInt(int A,int B)
{
	int ___ret = Multiply_IntInt(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_ByteByte(IntPtr _this,int A,int B);
/// <summary>Returns true if A is not equal to B (A != B)</summary>
public static bool NotEqual_ByteByte(byte A,byte B)
{
	int ___ret = NotEqual_ByteByte(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_ByteByte(IntPtr _this,int A,int B);
/// <summary>Returns true if A is equal to B (A == B)</summary>
public static bool EqualEqual_ByteByte(byte A,byte B)
{
	int ___ret = EqualEqual_ByteByte(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GreaterEqual_ByteByte(IntPtr _this,int A,int B);
/// <summary>Returns true if A is greater than or equal to B (A >= B)</summary>
public static bool GreaterEqual_ByteByte(byte A,byte B)
{
	int ___ret = GreaterEqual_ByteByte(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int LessEqual_ByteByte(IntPtr _this,int A,int B);
/// <summary>Returns true if A is less than or equal to B (A <= B)</summary>
public static bool LessEqual_ByteByte(byte A,byte B)
{
	int ___ret = LessEqual_ByteByte(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Greater_ByteByte(IntPtr _this,int A,int B);
/// <summary>Returns true if A is greater than B (A > B)</summary>
public static bool Greater_ByteByte(byte A,byte B)
{
	int ___ret = Greater_ByteByte(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Less_ByteByte(IntPtr _this,int A,int B);
/// <summary>Returns true if A is less than B (A < B)</summary>
public static bool Less_ByteByte(byte A,byte B)
{
	int ___ret = Less_ByteByte(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BMax(IntPtr _this,int A,int B);
/// <summary>Returns the maximum value of A and B</summary>
public static byte BMax(byte A,byte B)
{
	int ___ret = BMax(IntPtr.Zero,A,B);
	return (byte)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BMin(IntPtr _this,int A,int B);
/// <summary>Returns the minimum value of A and B</summary>
public static byte BMin(byte A,byte B)
{
	int ___ret = BMin(IntPtr.Zero,A,B);
	return (byte)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Subtract_ByteByte(IntPtr _this,int A,int B);
/// <summary>Subtraction (A - B)</summary>
public static byte Subtract_ByteByte(byte A,byte B=1)
{
	int ___ret = Subtract_ByteByte(IntPtr.Zero,A,B);
	return (byte)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Add_ByteByte(IntPtr _this,int A,int B);
/// <summary>Addition (A + B)</summary>
public static byte Add_ByteByte(byte A,byte B=1)
{
	int ___ret = Add_ByteByte(IntPtr.Zero,A,B);
	return (byte)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Percent_ByteByte(IntPtr _this,int A,int B);
/// <summary>Modulo (A % B)</summary>
public static byte Percent_ByteByte(byte A,byte B=1)
{
	int ___ret = Percent_ByteByte(IntPtr.Zero,A,B);
	return (byte)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Divide_ByteByte(IntPtr _this,int A,int B);
/// <summary>Division (A / B)</summary>
public static byte Divide_ByteByte(byte A,byte B=1)
{
	int ___ret = Divide_ByteByte(IntPtr.Zero,A,B);
	return (byte)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Multiply_ByteByte(IntPtr _this,int A,int B);
/// <summary>Multiplication (A * B)</summary>
public static byte Multiply_ByteByte(byte A,byte B)
{
	int ___ret = Multiply_ByteByte(IntPtr.Zero,A,B);
	return (byte)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BooleanNOR(IntPtr _this,int A,int B);
/// <summary>Returns the logical Not OR of two values (A NOR B)</summary>
public static bool BooleanNOR(bool A,bool B)
{
	int ___ret = BooleanNOR(IntPtr.Zero,A?1:0,B?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BooleanXOR(IntPtr _this,int A,int B);
/// <summary>Returns the logical eXclusive OR of two values (A XOR B)</summary>
public static bool BooleanXOR(bool A,bool B)
{
	int ___ret = BooleanXOR(IntPtr.Zero,A?1:0,B?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BooleanOR(IntPtr _this,int A,int B);
/// <summary>Returns the logical OR of two values (A OR B)</summary>
public static bool BooleanOR(bool A,bool B)
{
	int ___ret = BooleanOR(IntPtr.Zero,A?1:0,B?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BooleanNAND(IntPtr _this,int A,int B);
/// <summary>Returns the logical NAND of two values (A AND B)</summary>
public static bool BooleanNAND(bool A,bool B)
{
	int ___ret = BooleanNAND(IntPtr.Zero,A?1:0,B?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BooleanAND(IntPtr _this,int A,int B);
/// <summary>Returns the logical AND of two values (A AND B)</summary>
public static bool BooleanAND(bool A,bool B)
{
	int ___ret = BooleanAND(IntPtr.Zero,A?1:0,B?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_BoolBool(IntPtr _this,int A,int B);
/// <summary>Returns true if the values are not equal (A != B)</summary>
public static bool NotEqual_BoolBool(bool A,bool B)
{
	int ___ret = NotEqual_BoolBool(IntPtr.Zero,A?1:0,B?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_BoolBool(IntPtr _this,int A,int B);
/// <summary>Returns true if the values are equal (A == B)</summary>
public static bool EqualEqual_BoolBool(bool A,bool B)
{
	int ___ret = EqualEqual_BoolBool(IntPtr.Zero,A?1:0,B?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Not_PreBool(IntPtr _this,int A);
/// <summary>Returns the logical complement of the Boolean value (NOT A)</summary>
public static bool Not_PreBool(bool A)
{
	int ___ret = Not_PreBool(IntPtr.Zero,A?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RandomBoolWithWeightFromStream(IntPtr _this,float Weight,ref FRandomStream RandomStream);
/// <summary>
/// Get a random chance with the specified weight. Range of weight is 0.0 - 1.0 E.g.,
///               Weight = .6 return value = True 60% of the time
/// </summary>
public static bool RandomBoolWithWeightFromStream(float Weight,FRandomStream RandomStream)
{
	int ___ret = RandomBoolWithWeightFromStream(IntPtr.Zero,Weight,ref RandomStream);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RandomBoolWithWeight(IntPtr _this,float Weight);
/// <summary>
/// Get a random chance with the specified weight. Range of weight is 0.0 - 1.0 E.g.,
///              Weight = .6 return value = True 60% of the time
/// </summary>
public static bool RandomBoolWithWeight(float Weight)
{
	int ___ret = RandomBoolWithWeight(IntPtr.Zero,Weight);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RandomBool(IntPtr _this);
/// <summary>Returns a uniformly distributed random bool</summary>
public static bool RandomBool()
{
	int ___ret = RandomBool(IntPtr.Zero);
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
