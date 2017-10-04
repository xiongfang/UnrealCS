using System;
namespace UnrealEngine
{
	public partial class UKismetMathLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>
		/// Computes the intersection point between a line and a plane.
		/// @param               T - The t of the intersection between the line and the plane
		/// @param               Intersection - The point of intersection between the line and the plane
		/// @return              True if the intersection test was successful.
		/// </summary>
		public extern static bool LinePlaneIntersection_OriginNormal(FVector LineStart,FVector LineEnd,FVector PlaneOrigin,FVector PlaneNormal,out float T,out FVector Intersection);
		/// <summary>
		/// Computes the intersection point between a line and a plane.
		/// @param               T - The t of the intersection between the line and the plane
		/// @param               Intersection - The point of intersection between the line and the plane
		/// @return              True if the intersection test was successful.
		/// </summary>
		public extern static bool LinePlaneIntersection(FVector LineStart,FVector LineEnd,FPlane APlane,out float T,out FVector Intersection);
		/// <summary>
		/// Determines whether a given point is in a box with a given transform. Includes points on the box.
		/// @param Point                          Point to test
		/// @param BoxWorldTransform      Component-to-World transform of the box.
		/// @param BoxExtent                      Extents of the box (distance in each axis from origin), in component space.
		/// @return Whether the point is in the box.
		/// </summary>
		public extern static bool IsPointInBoxWithTransform(FVector Point,FTransform BoxWorldTransform,FVector BoxExtent);
		/// <summary>
		/// Determines whether the given point is in a box. Includes points on the box.
		/// @param Point                 Point to test
		/// @param BoxOrigin             Origin of the box
		/// @param BoxExtent             Extents of the box (distance in each axis from origin)
		/// @return Whether the point is in the box.
		/// </summary>
		public extern static bool IsPointInBox(FVector Point,FVector BoxOrigin,FVector BoxExtent);
		/// <summary>Set the seed of a random stream to a specific number</summary>
		public extern static void SetRandomStreamSeed(out FRandomStream Stream,int NewSeed);
		/// <summary>Create a new random seed for a random stream</summary>
		public extern static void SeedRandomStream(out FRandomStream Stream);
		/// <summary>Reset a random stream</summary>
		public extern static void ResetRandomStream(FRandomStream Stream);
		/// <summary>Create a random rotation</summary>
		public extern static FRotator RandomRotatorFromStream(bool bRoll,FRandomStream Stream);
		/// <summary>Returns a random vector with length of 1.0</summary>
		public extern static FVector RandomUnitVectorFromStream(FRandomStream Stream);
		/// <summary>Generate a random number between Min and Max</summary>
		public extern static float RandomFloatInRangeFromStream(float Min,float Max,FRandomStream Stream);
		/// <summary>Returns a random float between 0 and 1</summary>
		public extern static float RandomFloatFromStream(FRandomStream Stream);
		/// <summary>Returns a random bool</summary>
		public extern static bool RandomBoolFromStream(FRandomStream Stream);
		/// <summary>Return a random integer between Min and Max (>= Min and <= Max)</summary>
		public extern static int RandomIntegerInRangeFromStream(int Min,int Max,FRandomStream Stream);
		/// <summary>Returns a uniformly distributed random number between 0 and Max - 1</summary>
		public extern static int RandomIntegerFromStream(int Max,FRandomStream Stream);
		/// <summary>Resets the state of a given spring</summary>
		public extern static void ResetVectorSpringState(out FVectorSpringState SpringState);
		/// <summary>Resets the state of a given spring</summary>
		public extern static void ResetFloatSpringState(out FFloatSpringState SpringState);
		/// <summary>
		/// Uses a simple spring model to interpolate a vector from Current to Target.
		/// @param Current                                Current value
		/// @param Target                                 Target value
		/// @param SpringState                    Data related to spring model (velocity, error, etc..) - Create a unique variable per spring
		/// @param Stiffness                              How stiff the spring model is (more stiffness means more oscillation around the target value)
		/// @param CriticalDampingFactor  How much damping to apply to the spring (0 means no damping, 1 means critically damped which means no oscillation)
		/// @param Mass                                   Multiplier that acts like mass on a spring
		/// </summary>
		public extern static FVector VectorSpringInterp(FVector Current,FVector Target,out FVectorSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass=1.000000f);
		/// <summary>
		/// Uses a simple spring model to interpolate a float from Current to Target.
		/// @param Current                               Current value
		/// @param Target                                Target value
		/// @param SpringState                   Data related to spring model (velocity, error, etc..) - Create a unique variable per spring
		/// @param Stiffness                             How stiff the spring model is (more stiffness means more oscillation around the target value)
		/// @param CriticalDampingFactor How much damping to apply to the spring (0 means no damping, 1 means critically damped which means no oscillation)
		/// @param Mass                                  Multiplier that acts like mass on a spring
		/// </summary>
		public extern static float FloatSpringInterp(float Current,float Target,out FFloatSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass=1.000000f);
		/// <summary>
		/// Interpolates towards a varying target color smoothly.
		/// @param               Current                 Current Color
		/// @param               Target                  Target Color
		/// @param               DeltaTime               Time since last tick
		/// @param               InterpSpeed             Interpolation speed
		/// @return              New interpolated Color
		/// </summary>
		public extern static FLinearColor CInterpTo(FLinearColor Current,FLinearColor Target,float DeltaTime,float InterpSpeed);
		/// <summary>
		/// Tries to reach Target rotation at a constant rate.
		/// @param               Current                 Actual rotation
		/// @param               Target                  Target rotation
		/// @param               DeltaTime               Time since last tick
		/// @param               InterpSpeed             Interpolation speed
		/// @return              New interpolated position
		/// </summary>
		public extern static FRotator RInterpTo_Constant(FRotator Current,FRotator Target,float DeltaTime,float InterpSpeed);
		/// <summary>
		/// Tries to reach Target rotation based on Current rotation, giving a nice smooth feeling when rotating to Target rotation.
		/// @param               Current                 Actual rotation
		/// @param               Target                  Target rotation
		/// @param               DeltaTime               Time since last tick
		/// @param               InterpSpeed             Interpolation speed
		/// @return              New interpolated position
		/// </summary>
		public extern static FRotator RInterpTo(FRotator Current,FRotator Target,float DeltaTime,float InterpSpeed);
		/// <summary>
		/// Tries to reach Target at a constant rate.
		/// @param               Current                 Actual position
		/// @param               Target                  Target position
		/// @param               DeltaTime               Time since last tick
		/// @param               InterpSpeed             Interpolation speed
		/// @return              New interpolated position
		/// </summary>
		public extern static FVector2D Vector2DInterpTo_Constant(FVector2D Current,FVector2D Target,float DeltaTime,float InterpSpeed);
		/// <summary>
		/// Tries to reach Target based on distance from Current position, giving a nice smooth feeling when tracking a position.
		/// @param               Current                 Actual position
		/// @param               Target                  Target position
		/// @param               DeltaTime               Time since last tick
		/// @param               InterpSpeed             Interpolation speed
		/// @return              New interpolated position
		/// </summary>
		public extern static FVector2D Vector2DInterpTo(FVector2D Current,FVector2D Target,float DeltaTime,float InterpSpeed);
		/// <summary>
		/// Tries to reach Target at a constant rate.
		/// @param               Current                 Actual position
		/// @param               Target                  Target position
		/// @param               DeltaTime               Time since last tick
		/// @param               InterpSpeed             Interpolation speed
		/// @return              New interpolated position
		/// </summary>
		public extern static FVector VInterpTo_Constant(FVector Current,FVector Target,float DeltaTime,float InterpSpeed);
		/// <summary>
		/// Tries to reach Target based on distance from Current position, giving a nice smooth feeling when tracking a position.
		/// @param               Current                 Actual position
		/// @param               Target                  Target position
		/// @param               DeltaTime               Time since last tick
		/// @param               InterpSpeed             Interpolation speed
		/// @return              New interpolated position
		/// </summary>
		public extern static FVector VInterpTo(FVector Current,FVector Target,float DeltaTime,float InterpSpeed);
		/// <summary>
		/// Tries to reach Target at a constant rate.
		/// @param               Current                 Actual position
		/// @param               Target                  Target position
		/// @param               DeltaTime               Time since last tick
		/// @param               InterpSpeed             Interpolation speed
		/// @return              New interpolated position
		/// </summary>
		public extern static float FInterpTo_Constant(float Current,float Target,float DeltaTime,float InterpSpeed);
		/// <summary>
		/// Tries to reach Target based on distance from Current position, giving a nice smooth feeling when tracking a position.
		/// @param               Current                 Actual position
		/// @param               Target                  Target position
		/// @param               DeltaTime               Time since last tick
		/// @param               InterpSpeed             Interpolation speed
		/// @return              New interpolated position
		/// </summary>
		public extern static float FInterpTo(float Current,float Target,float DeltaTime,float InterpSpeed);
		/// <summary>Returns true if vector2D A is not equal to vector2D B (A != B) within a specified error tolerance</summary>
		public extern static bool NotEqual_Vector2DVector2D(FVector2D A,FVector2D B,float ErrorTolerance=0.000100f);
		/// <summary>Returns true if vector2D A is equal to vector2D B (A == B) within a specified error tolerance</summary>
		public extern static bool EqualEqual_Vector2DVector2D(FVector2D A,FVector2D B,float ErrorTolerance=0.000100f);
		/// <summary>Returns Vector A subtracted by B</summary>
		public extern static FVector2D Subtract_Vector2DFloat(FVector2D A,float B);
		/// <summary>Returns Vector A added by B</summary>
		public extern static FVector2D Add_Vector2DFloat(FVector2D A,float B);
		/// <summary>Returns Vector A divided by B</summary>
		public extern static FVector2D Divide_Vector2DFloat(FVector2D A,float B=1.000000f);
		/// <summary>Element-wise Vector multiplication (Result = {A.x*B.x, A.y*B.y})</summary>
		public extern static FVector2D Multiply_Vector2DVector2D(FVector2D A,FVector2D B);
		/// <summary>Returns Vector A scaled by B</summary>
		public extern static FVector2D Multiply_Vector2DFloat(FVector2D A,float B);
		/// <summary>Returns subtraction of Vector B from Vector A (A - B)</summary>
		public extern static FVector2D Subtract_Vector2DVector2D(FVector2D A,FVector2D B);
		/// <summary>Returns addition of Vector A and Vector B (A + B)</summary>
		public extern static FVector2D Add_Vector2DVector2D(FVector2D A,FVector2D B);
		/// <summary>
		/// Returns true if transform A is nearly equal to B
		/// @param LocationTolerance        How close position of transforms need to be to be considered equal
		/// @param RotationTolerance        How close rotations of transforms need to be to be considered equal
		/// @param Scale3DTolerance         How close scale of transforms need to be to be considered equal
		/// </summary>
		public extern static bool NearlyEqual_TransformTransform(FTransform A,FTransform B,float LocationTolerance=0.000100f,float RotationTolerance=0.000100f,float Scale3DTolerance=0.000100f);
		/// <summary>Returns true if transform A is equal to transform B</summary>
		public extern static bool EqualEqual_TransformTransform(FTransform A,FTransform B);
		/// <summary>Tries to reach a target transform.</summary>
		public extern static FTransform TInterpTo(FTransform Current,FTransform Target,float DeltaTime,float InterpSpeed);
		/// <summary>Ease between A and B using a specified easing function.</summary>
		public extern static FTransform TEase(FTransform A,FTransform B,float Alpha,EEasingFunc EasingFunc,float BlendExp=2.000000f,int Steps=2);
		/// <summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1).</summary>
		public extern static FTransform TLerp(FTransform A,FTransform B,float Alpha,ELerpInterpolationMode InterpMode=ELerpInterpolationMode.QuatInterp);
		/// <summary>
		/// Returns the inverse of the given transform T.
		/// Example: Given a LocalToWorld transform, WorldToLocal will be returned.
		/// @param       T       The transform you wish to invert
		/// @return      The inverse of T.
		/// </summary>
		public extern static FTransform InvertTransform(FTransform T);
		/// <summary>
		/// Returns the given transform, converted to be relative to the given ParentTransform.
		/// Example: AToB = ConvertTransformToRelative(AToWorld, BToWorld) to compute A relative to B.
		/// @param               Transform               The transform you wish to convert
		/// @param               ParentTransform The transform the conversion is relative to (in the same space as Transform)
		/// @return              The new relative transform
		/// </summary>
		public extern static FTransform ConvertTransformToRelative(FTransform Transform,FTransform ParentTransform);
		/// <summary>
		/// Compose two transforms in order: A * B.
		/// Order matters when composing transforms:
		/// A * B will yield a transform that logically first applies A then B to any subsequent transformation.
		/// Example: LocalToWorld = ComposeTransforms(DeltaRotation, LocalToWorld) will change rotation in local space by DeltaRotation.
		/// Example: LocalToWorld = ComposeTransforms(LocalToWorld, DeltaRotation) will change rotation in world space by DeltaRotation.
		/// @return New transform: A * B
		/// </summary>
		public extern static FTransform ComposeTransforms(FTransform A,FTransform B);
		/// <summary>
		/// Transform a direction vector by the inverse of the supplied transform - will not change its length.
		/// For example, if T was an object's transform, would transform a direction from world space to local space.
		/// </summary>
		public extern static FVector InverseTransformDirection(FTransform T,FVector Direction);
		/// <summary>
		/// Transform a position by the inverse of the supplied transform.
		/// For example, if T was an object's transform, would transform a position from world space to local space.
		/// </summary>
		public extern static FVector InverseTransformLocation(FTransform T,FVector Location);
		/// <summary>
		/// Transform a direction vector by the supplied transform - will not change its length.
		/// For example, if T was an object's transform, would transform a direction from local space to world space.
		/// </summary>
		public extern static FVector TransformDirection(FTransform T,FVector Direction);
		/// <summary>
		/// Transform a position by the supplied transform.
		/// For example, if T was an object's transform, would transform a position from local space to world space.
		/// </summary>
		public extern static FVector TransformLocation(FTransform T,FVector Location);
		/// <summary>Returns true if A and B are not equal (A != B)</summary>
		public extern static bool NotEqual_NameName(FName A,FName B);
		/// <summary>Returns true if A and B are equal (A == B)</summary>
		public extern static bool EqualEqual_NameName(FName A,FName B);
		/// <summary>
		/// Determine if a class is a child of another class.
		/// @return      true if TestClass == ParentClass, or if TestClass is a child of ParentClass; false otherwise, or if either
		///                      the value for either parameter is 'None'.
		/// </summary>
		public extern static bool ClassIsChildOf(TSubclassOf<UObject>  TestClass,TSubclassOf<UObject>  ParentClass);
		/// <summary>Returns true if A and B are not equal (A != B)</summary>
		public extern static bool NotEqual_ClassClass(UClass A,UClass B);
		/// <summary>Returns true if A and B are equal (A == B)</summary>
		public extern static bool EqualEqual_ClassClass(UClass A,UClass B);
		/// <summary>Returns true if A and B are not equal (A != B)</summary>
		public extern static bool NotEqual_ObjectObject(UObject A,UObject B);
		/// <summary>Returns true if A and B are equal (A == B)</summary>
		public extern static bool EqualEqual_ObjectObject(UObject A,UObject B);
		/// <summary>Get the X direction vector after this rotation</summary>
		public extern static FVector Conv_RotatorToVector(FRotator InRot);
		/// <summary>Create a rotator which orients X along the supplied direction vector</summary>
		public extern static FRotator Conv_VectorToRotator(FVector InVec);
		/// <summary>Build a reference frame from three axes</summary>
		public extern static FRotator MakeRotationFromAxes(FVector Forward,FVector Right,FVector Up);
		/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
		public extern static UClass SelectClass(UClass A,UClass B,bool bSelectA);
		/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
		public extern static UObject SelectObject(UObject A,UObject B,bool bSelectA);
		/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
		public extern static FTransform SelectTransform(FTransform A,FTransform B,bool bPickA);
		/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
		public extern static FLinearColor SelectColor(FLinearColor A,FLinearColor B,bool bPickA);
		/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
		public extern static FRotator SelectRotator(FRotator A,FRotator B,bool bPickA);
		/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
		public extern static FVector SelectVector(FVector A,FVector B,bool bPickA);
		/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
		public extern static float SelectFloat(float A,float B,bool bPickA);
		/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
		public extern static int SelectInt(int A,int B,bool bPickA);
		/// <summary>If bPickA is true, A is returned, otherwise B is</summary>
		public extern static FString SelectString(FString A,FString B,bool bPickA);
		/// <summary>Converts a RGB linear color to HSV (where H is in R, S is in G, and V is in B)</summary>
		public extern static void RGBToHSV_Vector(FLinearColor RGB,out FLinearColor HSV);
		/// <summary>Converts a HSV linear color (where H is in R, S is in G, and V is in B) to RGB</summary>
		public extern static void HSVToRGB_Vector(FLinearColor HSV,out FLinearColor RGB);
		/// <summary>Breaks apart a color into individual HSV components (as well as alpha)</summary>
		public extern static void RGBToHSV(FLinearColor InColor,out float H,out float S,out float V,out float A);
		/// <summary>Make a color from individual color components (HSV space)</summary>
		public extern static FLinearColor HSVToRGB(float H,float S,float V,float A=1.000000f);
		/// <summary>Breaks apart a color into individual RGB components (as well as alpha)</summary>
		public extern static void BreakColor(FLinearColor InColor,out float R,out float G,out float B,out float A);
		/// <summary>Make a color from individual color components (RGB space)</summary>
		public extern static FLinearColor MakeColor(float R,float G,float B,float A=1.000000f);
		/// <summary>Breaks apart a random number generator</summary>
		public extern static void BreakRandomStream(FRandomStream InRandomStream,out int InitialSeed);
		/// <summary>Makes a SRand-based random number generator</summary>
		public extern static FRandomStream MakeRandomStream(int InitialSeed);
		/// <summary>Breaks apart a transform into location, rotation and scale</summary>
		public extern static void BreakTransform(FTransform InTransform,out FVector Location,out FRotator Rotation,out FVector Scale);
		/// <summary>Make a transform from location, rotation and scale</summary>
		public extern static FTransform MakeTransform(FVector Location,FRotator Rotation,FVector Scale);
		/// <summary>Breaks apart a rotator into its component axes</summary>
		public extern static void BreakRotIntoAxes(FRotator InRot,out FVector X,out FVector Y,out FVector Z);
		/// <summary>Breaks apart a rotator into {Roll, Pitch, Yaw} angles in degrees</summary>
		public extern static void BreakRotator(FRotator InRot,out float Roll,out float Pitch,out float Yaw);
		/// <summary>Builds a matrix with given Z and Y axes. Z will remain fixed, Y may be changed minimally to enforce orthogonality. X will be computed. Inputs need not be normalized.</summary>
		public extern static FRotator MakeRotFromZY(FVector Z,FVector Y);
		/// <summary>Builds a matrix with given Z and X axes. Z will remain fixed, X may be changed minimally to enforce orthogonality. Y will be computed. Inputs need not be normalized.</summary>
		public extern static FRotator MakeRotFromZX(FVector Z,FVector X);
		/// <summary>Builds a matrix with given Y and Z axes. Y will remain fixed, Z may be changed minimally to enforce orthogonality. X will be computed. Inputs need not be normalized.</summary>
		public extern static FRotator MakeRotFromYZ(FVector Y,FVector Z);
		/// <summary>Builds a matrix with given Y and X axes. Y will remain fixed, X may be changed minimally to enforce orthogonality. Z will be computed. Inputs need not be normalized.</summary>
		public extern static FRotator MakeRotFromYX(FVector Y,FVector X);
		/// <summary>Builds a matrix with given X and Z axes. X will remain fixed, Z may be changed minimally to enforce orthogonality. Y will be computed. Inputs need not be normalized.</summary>
		public extern static FRotator MakeRotFromXZ(FVector X,FVector Z);
		/// <summary>Builds a matrix with given X and Y axes. X will remain fixed, Y may be changed minimally to enforce orthogonality. Z will be computed. Inputs need not be normalized.</summary>
		public extern static FRotator MakeRotFromXY(FVector X,FVector Y);
		/// <summary>Builds a rotation matrix given only a ZAxis. X and Y are unspecified but will be orthonormal. ZAxis need not be normalized.</summary>
		public extern static FRotator MakeRotFromZ(FVector Z);
		/// <summary>Builds a rotation matrix given only a YAxis. X and Z are unspecified but will be orthonormal. YAxis need not be normalized.</summary>
		public extern static FRotator MakeRotFromY(FVector Y);
		/// <summary>Builds a rotator given only a XAxis. Y and Z are unspecified but will be orthonormal. XAxis need not be normalized.</summary>
		public extern static FRotator MakeRotFromX(FVector X);
		/// <summary>Find a rotation for an object at Start location to point at Target location.</summary>
		public extern static FRotator FindLookAtRotation(FVector Start,FVector Target);
		/// <summary>Makes a rotator {Roll, Pitch, Yaw} from rotation values supplied in degrees</summary>
		public extern static FRotator MakeRotator(float Roll,float Pitch,float Yaw);
		/// <summary>Breaks a vector apart into Yaw, Pitch rotation values given in degrees. (non-clamped)</summary>
		public extern static void GetYawPitchFromVector(FVector InVec,out float Yaw,out float Pitch);
		/// <summary>Creates a directional vector from rotation values {Pitch, Yaw} supplied in degrees with specified Length</summary>
		public extern static FVector CreateVectorFromYawPitch(float Yaw,float Pitch,float Length=1.000000f);
		/// <summary>Rotate the world up vector by the given rotation</summary>
		public extern static FVector GetUpVector(FRotator InRot);
		/// <summary>Rotate the world right vector by the given rotation</summary>
		public extern static FVector GetRightVector(FRotator InRot);
		/// <summary>Rotate the world forward vector by the given rotation</summary>
		public extern static FVector GetForwardVector(FRotator InRot);
		/// <summary>Breaks a 2D vector apart into X, Y.</summary>
		public extern static void BreakVector2D(FVector2D InVec,out float X,out float Y);
		/// <summary>Makes a 2d vector {X, Y}</summary>
		public extern static FVector2D MakeVector2D(float X,float Y);
		/// <summary>Breaks a vector apart into X, Y, Z</summary>
		public extern static void BreakVector(FVector InVec,out float X,out float Y,out float Z);
		/// <summary>Makes a vector {X, Y, Z}</summary>
		public extern static FVector MakeVector(float X,float Y,float Z);
		/// <summary>Makes an FBox2D from Min and Max and sets IsValid to true</summary>
		public extern static FBox2D MakeBox2D(FVector2D Min,FVector2D Max);
		/// <summary>Makes an FBox from Min and Max and sets IsValid to true</summary>
		public extern static FBox MakeBox(FVector Min,FVector Max);
		/// <summary>Convert a float into a LinearColor, where each element is that float</summary>
		public extern static FLinearColor Conv_FloatToLinearColor(float InFloat);
		/// <summary>Convert a float into a vector, where each element is that float</summary>
		public extern static FVector Conv_FloatToVector(float InFloat);
		/// <summary>Convert an IntVector to a vector</summary>
		public extern static FVector Conv_IntVectorToVector(FIntVector InIntVector);
		/// <summary>Convert a Vector2D to a Vector</summary>
		public extern static FVector Conv_Vector2DToVector(FVector2D InVector2D,float Z=0.000000f);
		/// <summary>Convert a Vector to a Vector2D</summary>
		public extern static FVector2D Conv_VectorToVector2D(FVector InVector);
		/// <summary>Convert a vector to a transform. Uses vector as location</summary>
		public extern static FTransform Conv_VectorToTransform(FVector InLocation);
		/// <summary>Converts a LinearColor to a color</summary>
		public extern static FColor Conv_LinearColorToColor(FLinearColor InLinearColor);
		/// <summary>Converts a color to LinearColor</summary>
		public extern static FLinearColor Conv_ColorToLinearColor(FColor InColor);
		/// <summary>Converts a LinearColor to a vector</summary>
		public extern static FVector Conv_LinearColorToVector(FLinearColor InLinearColor);
		/// <summary>Converts a vector to LinearColor</summary>
		public extern static FLinearColor Conv_VectorToLinearColor(FVector InVec);
		/// <summary>Converts a byte to an integer</summary>
		public extern static int Conv_ByteToInt(byte InByte);
		/// <summary>Converts a bool to a byte</summary>
		public extern static byte Conv_BoolToByte(bool InBool);
		/// <summary>Converts a bool to a float (0.0f or 1.0f)</summary>
		public extern static float Conv_BoolToFloat(bool InBool);
		/// <summary>Converts a bool to an int</summary>
		public extern static int Conv_BoolToInt(bool InBool);
		/// <summary>Converts a int to a bool</summary>
		public extern static bool Conv_IntToBool(int InInt);
		/// <summary>Converts an integer to an IntVector</summary>
		public extern static FIntVector Conv_IntToIntVector(int InInt);
		/// <summary>Converts an integer to a byte (if the integer is too large, returns the low 8 bits)</summary>
		public extern static byte Conv_IntToByte(int InInt);
		/// <summary>Converts an integer to a float</summary>
		public extern static float Conv_IntToFloat(int InInt);
		/// <summary>Converts a byte to a float</summary>
		public extern static float Conv_ByteToFloat(byte InByte);
		/// <summary>Converts a time span string to a Timespan object</summary>
		public extern static bool TimespanFromString(FString TimespanString,out FTimespan Result);
		/// <summary>Returns a zero time span value</summary>
		public extern static FTimespan TimespanZeroValue();
		/// <summary>Returns the ratio between two time spans (A / B), handles zero values</summary>
		public extern static float TimespanRatio(FTimespan A,FTimespan B);
		/// <summary>Returns the minimum time span value</summary>
		public extern static FTimespan TimespanMinValue();
		/// <summary>Returns the maximum time span value</summary>
		public extern static FTimespan TimespanMaxValue();
		/// <summary>Returns a time span that represents the specified number of seconds</summary>
		public extern static FTimespan FromSeconds(float Seconds);
		/// <summary>Returns a time span that represents the specified number of minutes</summary>
		public extern static FTimespan FromMinutes(float Minutes);
		/// <summary>Returns a time span that represents the specified number of milliseconds</summary>
		public extern static FTimespan FromMilliseconds(float Milliseconds);
		/// <summary>Returns a time span that represents the specified number of hours</summary>
		public extern static FTimespan FromHours(float Hours);
		/// <summary>Returns a time span that represents the specified number of days</summary>
		public extern static FTimespan FromDays(float Days);
		/// <summary>Returns the total number of seconds in A</summary>
		public extern static float GetTotalSeconds(FTimespan A);
		/// <summary>Returns the total number of minutes in A</summary>
		public extern static float GetTotalMinutes(FTimespan A);
		/// <summary>Returns the total number of milliseconds in A</summary>
		public extern static float GetTotalMilliseconds(FTimespan A);
		/// <summary>Returns the total number of hours in A</summary>
		public extern static float GetTotalHours(FTimespan A);
		/// <summary>Returns the total number of days in A</summary>
		public extern static float GetTotalDays(FTimespan A);
		/// <summary>Returns the seconds component of A</summary>
		public extern static int GetSeconds(FTimespan A);
		/// <summary>Returns the minutes component of A</summary>
		public extern static int GetMinutes(FTimespan A);
		/// <summary>Returns the milliseconds component of A</summary>
		public extern static int GetMilliseconds(FTimespan A);
		/// <summary>Returns the hours component of A</summary>
		public extern static int GetHours(FTimespan A);
		/// <summary>Returns the absolute value of A</summary>
		public extern static FTimespan GetDuration(FTimespan A);
		/// <summary>Returns the days component of A</summary>
		public extern static int GetDays(FTimespan A);
		/// <summary>Returns true if A is less than or equal to B (A <= B)</summary>
		public extern static bool LessEqual_TimespanTimespan(FTimespan A,FTimespan B);
		/// <summary>Returns true if A is less than B (A < B)</summary>
		public extern static bool Less_TimespanTimespan(FTimespan A,FTimespan B);
		/// <summary>Returns true if A is greater than or equal to B (A >= B)</summary>
		public extern static bool GreaterEqual_TimespanTimespan(FTimespan A,FTimespan B);
		/// <summary>Returns true if A is greater than B (A > B)</summary>
		public extern static bool Greater_TimespanTimespan(FTimespan A,FTimespan B);
		/// <summary>Returns true if the values are not equal (A != B)</summary>
		public extern static bool NotEqual_TimespanTimespan(FTimespan A,FTimespan B);
		/// <summary>Returns true if the values are equal (A == B)</summary>
		public extern static bool EqualEqual_TimespanTimespan(FTimespan A,FTimespan B);
		/// <summary>Scalar multiplication (A * s)</summary>
		public extern static FTimespan Multiply_TimespanFloat(FTimespan A,float Scalar);
		/// <summary>Subtraction (A - B)</summary>
		public extern static FTimespan Subtract_TimespanTimespan(FTimespan A,FTimespan B);
		/// <summary>Addition (A + B)</summary>
		public extern static FTimespan Add_TimespanTimespan(FTimespan A,FTimespan B);
		/// <summary>Breaks a Timespan into its components</summary>
		public extern static void BreakTimespan(FTimespan InTimespan,out int Days,out int Hours,out int Minutes,out int Seconds,out int Milliseconds);
		/// <summary>Makes a Timespan struct</summary>
		public extern static FTimespan MakeTimespan(int Days,int Hours,int Minutes,int Seconds,int Milliseconds);
		/// <summary>Converts a date string to a DateTime object</summary>
		public extern static bool DateTimeFromString(FString DateTimeString,out FDateTime Result);
		/// <summary>Converts a date string in ISO-8601 format to a DateTime object</summary>
		public extern static bool DateTimeFromIsoString(FString IsoString,out FDateTime Result);
		/// <summary>Returns the UTC date and time on this computer</summary>
		public extern static FDateTime UtcNow();
		/// <summary>Returns the local date on this computer</summary>
		public extern static FDateTime Today();
		/// <summary>Returns the local date and time on this computer</summary>
		public extern static FDateTime Now();
		/// <summary>Returns the minimum date and time value</summary>
		public extern static FDateTime DateTimeMinValue();
		/// <summary>Returns the maximum date and time value</summary>
		public extern static FDateTime DateTimeMaxValue();
		/// <summary>Returns whether given year is a leap year</summary>
		public extern static bool IsLeapYear(int Year);
		/// <summary>Returns the number of days in the given year</summary>
		public extern static int DaysInYear(int Year);
		/// <summary>Returns the number of days in the given year and month</summary>
		public extern static int DaysInMonth(int Year,int Month);
		/// <summary>Returns whether A's time is in the morning</summary>
		public extern static bool IsMorning(FDateTime A);
		/// <summary>Returns whether A's time is in the afternoon</summary>
		public extern static bool IsAfternoon(FDateTime A);
		/// <summary>Returns the year component of A</summary>
		public extern static int GetYear(FDateTime A);
		/// <summary>Returns the time elapsed since midnight of A</summary>
		public extern static FTimespan GetTimeOfDay(FDateTime A);
		/// <summary>Returns the second component of A</summary>
		public extern static int GetSecond(FDateTime A);
		/// <summary>Returns the month component of A</summary>
		public extern static int GetMonth(FDateTime A);
		/// <summary>Returns the minute component of A</summary>
		public extern static int GetMinute(FDateTime A);
		/// <summary>Returns the millisecond component of A</summary>
		public extern static int GetMillisecond(FDateTime A);
		/// <summary>Returns the hour component of A (12h format)</summary>
		public extern static int GetHour12(FDateTime A);
		/// <summary>Returns the hour component of A (24h format)</summary>
		public extern static int GetHour(FDateTime A);
		/// <summary>Returns the day of year of A</summary>
		public extern static int GetDayOfYear(FDateTime A);
		/// <summary>Returns the day component of A (1 to 31)</summary>
		public extern static int GetDay(FDateTime A);
		/// <summary>Returns the date component of A</summary>
		public extern static FDateTime GetDate(FDateTime A);
		/// <summary>Returns true if A is less than or equal to B (A <= B)</summary>
		public extern static bool LessEqual_DateTimeDateTime(FDateTime A,FDateTime B);
		/// <summary>Returns true if A is less than B (A < B)</summary>
		public extern static bool Less_DateTimeDateTime(FDateTime A,FDateTime B);
		/// <summary>Returns true if A is greater than or equal to B (A >= B)</summary>
		public extern static bool GreaterEqual_DateTimeDateTime(FDateTime A,FDateTime B);
		/// <summary>Returns true if A is greater than B (A > B)</summary>
		public extern static bool Greater_DateTimeDateTime(FDateTime A,FDateTime B);
		/// <summary>Returns true if the values are not equal (A != B)</summary>
		public extern static bool NotEqual_DateTimeDateTime(FDateTime A,FDateTime B);
		/// <summary>Returns true if the values are equal (A == B)</summary>
		public extern static bool EqualEqual_DateTimeDateTime(FDateTime A,FDateTime B);
		/// <summary>Subtraction (A - B)</summary>
		public extern static FTimespan Subtract_DateTimeDateTime(FDateTime A,FDateTime B);
		/// <summary>Subtraction (A - B)</summary>
		public extern static FDateTime Subtract_DateTimeTimespan(FDateTime A,FTimespan B);
		/// <summary>Addition (A + B)</summary>
		public extern static FDateTime Add_DateTimeTimespan(FDateTime A,FTimespan B);
		/// <summary>Breaks a DateTime into its components</summary>
		public extern static void BreakDateTime(FDateTime InDateTime,out int Year,out int Month,out int Day,out int Hour,out int Minute,out int Second,out int Millisecond);
		/// <summary>Makes a DateTime struct</summary>
		public extern static FDateTime MakeDateTime(int Year,int Month,int Day,int Hour=0,int Minute=0,int Second=0,int Millisecond=0);
		/// <summary>
		/// Creates a plane with a facing direction of Normal at the given Point
		/// @param Point  A point on the plane
		/// @param Normal  The Normal of the plane at Point
		/// @return Plane instance
		/// </summary>
		public extern static FPlane MakePlaneFromPointAndNormal(FVector Point,FVector Normal);
		/// <summary>Element-wise multiplication of a linear color by a float (F*R, F*G, F*B, F*A)</summary>
		public extern static FLinearColor Multiply_LinearColorFloat(FLinearColor A,float B);
		/// <summary>Element-wise multiplication of two linear colors (R*R, G*G, B*B, A*A)</summary>
		public extern static FLinearColor Multiply_LinearColorLinearColor(FLinearColor A,FLinearColor B);
		/// <summary>
		/// Linearly interpolates between two colors by the specified Alpha amount (100% of A when Alpha=0 and 100% of B when Alpha=1).  The interpolation is performed in HSV color space taking the shortest path to the new color's hue.  This can give better results than a normal lerp, but is much more expensive.  The incoming colors are in RGB space, and the output color will be RGB.  The alpha value will also be interpolated.
		/// @param       A               The color and alpha to interpolate from as linear RGBA
		/// @param       B               The color and alpha to interpolate to as linear RGBA
		/// @param       Alpha   Scalar interpolation amount (usually between 0.0 and 1.0 inclusive)
		/// @return      The interpolated color in linear RGB space along with the interpolated alpha value
		/// </summary>
		public extern static FLinearColor LinearColorLerpUsingHSV(FLinearColor A,FLinearColor B,float Alpha);
		/// <summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
		public extern static FLinearColor LinearColorLerp(FLinearColor A,FLinearColor B,float Alpha);
		/// <summary>
		/// Clamps an angle to the range of [-180, 180].
		/// @param Angle The Angle to clamp.
		/// @return The clamped angle.
		/// </summary>
		public extern static float NormalizeAxis(float Angle);
		/// <summary>
		/// Clamps an angle to the range of [0, 360].
		/// @param Angle The angle to clamp.
		/// @return The clamped angle.
		/// </summary>
		public extern static float ClampAxis(float Angle);
		/// <summary>Create a rotation from an axis and and angle (in degrees)</summary>
		public extern static FRotator RotatorFromAxisAndAngle(FVector Axis,float Angle);
		/// <summary>Normalized A-B</summary>
		public extern static FRotator NormalizedDeltaRotator(FRotator A,FRotator B);
		/// <summary>Easeing  between A and B using a specified easing function</summary>
		public extern static FRotator REase(FRotator A,FRotator B,float Alpha,bool bShortestPath,EEasingFunc EasingFunc,float BlendExp=2.000000f,int Steps=2);
		/// <summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
		public extern static FRotator RLerp(FRotator A,FRotator B,float Alpha,bool bShortestPath);
		/// <summary>Generates a random rotation, with optional random roll.</summary>
		public extern static FRotator RandomRotator(bool bRoll=false);
		/// <summary>Get the reference frame direction vectors (axes) described by this rotation</summary>
		public extern static void GetAxes(FRotator A,out FVector X,out FVector Y,out FVector Z);
		/// <summary>Negate a rotator</summary>
		public extern static FRotator NegateRotator(FRotator A);
		/// <summary>Combine 2 rotations to give you the resulting rotation</summary>
		public extern static FRotator ComposeRotators(FRotator A,FRotator B);
		/// <summary>Returns rotator representing rotator A scaled by B</summary>
		public extern static FRotator Multiply_RotatorInt(FRotator A,int B);
		/// <summary>Returns rotator representing rotator A scaled by B</summary>
		public extern static FRotator Multiply_RotatorFloat(FRotator A,float B);
		/// <summary>Returns true if rotator A is not equal to rotator B (A != B) within a specified error tolerance</summary>
		public extern static bool NotEqual_RotatorRotator(FRotator A,FRotator B,float ErrorTolerance=0.000100f);
		/// <summary>Returns true if rotator A is equal to rotator B (A == B) within a specified error tolerance</summary>
		public extern static bool EqualEqual_RotatorRotator(FRotator A,FRotator B,float ErrorTolerance=0.000100f);
		/// <summary>Find the unit direction vector from one position to another.</summary>
		public extern static FVector GetDirectionUnitVector(FVector From,FVector To);
		/// <summary>Find the maximum element (X, Y or Z) of a vector</summary>
		public extern static float GetMaxElement(FVector A);
		/// <summary>Find the minimum element (X, Y or Z) of a vector</summary>
		public extern static float GetMinElement(FVector A);
		/// <summary>Clamp the vector size between a min and max length</summary>
		public extern static FVector ClampVectorSize(FVector A,float Min,float Max);
		/// <summary>Negate a vector.</summary>
		public extern static FVector NegateVector(FVector A);
		/// <summary>
		/// Projects a vector onto a plane defined by a normalized vector (PlaneNormal).
		/// @param  V Vector to project onto the plane.
		/// @param  PlaneNormal Normal of the plane.
		/// @return Vector projected onto the plane.
		/// </summary>
		public extern static FVector ProjectVectorOnToPlane(FVector V,FVector PlaneNormal);
		/// <summary>
		/// Projects a point onto a plane defined by a point on the plane and a plane normal.
		/// @param  Point Point to project onto the plane.
		/// @param  PlaneBase A point on the plane.
		/// @param  PlaneNormal Normal of the plane.
		/// @return Point projected onto the plane.
		/// </summary>
		public extern static FVector ProjectPointOnToPlane(FVector Point,FVector PlaneBase,FVector PlaneNormal);
		/// <summary>
		/// Find the distance from a point to the closest point on an infinite line.
		/// @param Point                  Point for which we find the distance to the closest point on the line.
		/// @param LineOrigin             Point of reference on the line.
		/// @param LineDirection  Direction of the line. Not required to be normalized.
		/// @return The distance from the given point to the closest point on the line.
		/// </summary>
		public extern static float GetPointDistanceToLine(FVector Point,FVector LineOrigin,FVector LineDirection);
		/// <summary>
		/// Find the distance from a point to the closest point on a segment.
		/// @param Point                  Point for which we find the distance to the closest point on the segment.
		/// @param SegmentStart   Start of the segment.
		/// @param SegmentEnd             End of the segment.
		/// @return The distance from the given point to the closest point on the segment.
		/// </summary>
		public extern static float GetPointDistanceToSegment(FVector Point,FVector SegmentStart,FVector SegmentEnd);
		/// <summary>
		/// Find the closest point on an infinite line to a given point.
		/// @param Point                 Point for which we find the closest point on the line.
		/// @param LineOrigin    Point of reference on the line.
		/// @param LineDirection Direction of the line. Not required to be normalized.
		/// @return The closest point on the line to the given point.
		/// </summary>
		public extern static FVector FindClosestPointOnLine(FVector Point,FVector LineOrigin,FVector LineDirection);
		/// <summary>
		/// Find the closest point on a segment to a given point.
		/// @param Point                 Point for which we find the closest point on the segment.
		/// @param SegmentStart  Start of the segment.
		/// @param SegmentEnd    End of the segment.
		/// @return The closest point on the segment to the given point.
		/// </summary>
		public extern static FVector FindClosestPointOnSegment(FVector Point,FVector SegmentStart,FVector SegmentEnd);
		/// <summary>
		/// Find closest points between 2 segments.
		/// @param       Segment1Start   Start of the 1st segment.
		/// @param       Segment1End             End of the 1st segment.
		/// @param       Segment2Start   Start of the 2nd segment.
		/// @param       Segment2End             End of the 2nd segment.
		/// @param       Segment1Point   Closest point on segment 1 to segment 2.
		/// @param       Segment2Point   Closest point on segment 2 to segment 1.
		/// </summary>
		public extern static void FindNearestPointsOnLineSegments(FVector Segment1Start,FVector Segment1End,FVector Segment2Start,FVector Segment2End,out FVector Segment1Point,out FVector Segment2Point);
		/// <summary>
		/// Given a direction vector and a surface normal, returns the vector reflected across the surface normal.
		/// Produces a result like shining a laser at a mirror!
		/// @param Direction Direction vector the ray is coming from.
		/// @param SurfaceNormal A normal of the surface the ray should be reflected on.
		/// @returns Reflected vector.
		/// </summary>
		public extern static FVector GetReflectionVector(FVector Direction,FVector SurfaceNormal);
		/// <summary>
		/// Projects one vector (V) onto another (Target) and returns the projected vector.
		/// If Target is nearly zero in length, returns the zero vector.
		/// @param  V Vector to project.
		/// @param  Target Vector on which we are projecting.
		/// @return V projected on to Target.
		/// </summary>
		public extern static FVector ProjectVectorOnToVector(FVector V,FVector Target);
		/// <summary>Mirrors a vector by a normal</summary>
		public extern static FVector MirrorVectorByNormal(FVector InVect,FVector InNormal);
		/// <summary>
		/// RandomUnitVectorWithYawAndPitch
		/// @param MaxYaw - The Yaw-angle of the cone (from ConeDir to horizontal-edge), in degrees.
		/// @param MaxPitch - The Pitch-angle of the cone (from ConeDir to vertical-edge), in degrees.
		/// </summary>
		public extern static FVector RandomUnitVectorInConeWithYawAndPitch(FVector ConeDir,float MaxYawInDegrees,float MaxPitchInDegrees);
		/// <summary>
		/// Returns a random vector with length of 1, within the specified cone, with uniform random distribution.
		/// @param ConeDir       The base "center" direction of the cone.
		/// @param ConeHalfAngle         The half-angle of the cone (from ConeDir to edge), in radians.
		/// </summary>
		public extern static FVector RandomUnitVectorInCone(FVector ConeDir,float ConeHalfAngle);
		/// <summary>Returns a random point within the specified bounding box</summary>
		public extern static FVector RandomPointInBoundingBox(FVector Origin,FVector BoxExtent);
		/// <summary>Returns a random vector with length of 1</summary>
		public extern static FVector RandomUnitVector();
		/// <summary>Easeing  between A and B using a specified easing function</summary>
		public extern static FVector VEase(FVector A,FVector B,float Alpha,EEasingFunc EasingFunc,float BlendExp=2.000000f,int Steps=2);
		/// <summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
		public extern static FVector VLerp(FVector A,FVector B,float Alpha);
		/// <summary>Returns a unit normal version of the vector2d A</summary>
		public extern static FVector2D Normal2D(FVector2D A);
		/// <summary>Returns a unit normal version of the FVector A</summary>
		public extern static FVector Normal(FVector A);
		/// <summary>Returns the squared length of a 2d FVector.</summary>
		public extern static float VSize2DSquared(FVector2D A);
		/// <summary>Returns the squared length of the FVector</summary>
		public extern static float VSizeSquared(FVector A);
		/// <summary>Returns the length of a 2d FVector.</summary>
		public extern static float VSize2D(FVector2D A);
		/// <summary>Returns the length of the FVector</summary>
		public extern static float VSize(FVector A);
		/// <summary>Returns the cross product of two 2d vectors</summary>
		public extern static float CrossProduct2D(FVector2D A,FVector2D B);
		/// <summary>Returns the dot product of two 2d vectors</summary>
		public extern static float DotProduct2D(FVector2D A,FVector2D B);
		/// <summary>Returns the cross product of two 3d vectors</summary>
		public extern static FVector Cross_VectorVector(FVector A,FVector B);
		/// <summary>Returns the dot product of two 3d vectors</summary>
		public extern static float Dot_VectorVector(FVector A,FVector B);
		/// <summary>Returns true if vector A is not equal to vector B (A != B) within a specified error tolerance</summary>
		public extern static bool NotEqual_VectorVector(FVector A,FVector B,float ErrorTolerance=0.000100f);
		/// <summary>Returns true if vector A is equal to vector B (A == B) within a specified error tolerance</summary>
		public extern static bool EqualEqual_VectorVector(FVector A,FVector B,float ErrorTolerance=0.000100f);
		/// <summary>Returns result of vector A rotated by AngleDeg around Axis</summary>
		public extern static FVector RotateAngleAxis(FVector InVect,float AngleDeg,FVector Axis);
		/// <summary>Returns result of vector A rotated by Rotator B</summary>
		public extern static FVector GreaterGreater_VectorRotator(FVector A,FRotator B);
		/// <summary>Returns result of vector A rotated by the inverse of Rotator B</summary>
		public extern static FVector LessLess_VectorRotator(FVector A,FRotator B);
		/// <summary>Subtracts an integer from each component of a vector</summary>
		public extern static FVector Subtract_VectorInt(FVector A,int B);
		/// <summary>Subtracts a float from each component of a vector</summary>
		public extern static FVector Subtract_VectorFloat(FVector A,float B);
		/// <summary>Vector subtraction</summary>
		public extern static FVector Subtract_VectorVector(FVector A,FVector B);
		/// <summary>Adds an integer to each component of a vector</summary>
		public extern static FVector Add_VectorInt(FVector A,int B);
		/// <summary>Adds a float to each component of a vector</summary>
		public extern static FVector Add_VectorFloat(FVector A,float B);
		/// <summary>Vector addition</summary>
		public extern static FVector Add_VectorVector(FVector A,FVector B);
		/// <summary>Vector divide by vector</summary>
		public extern static FVector Divide_VectorVector(FVector A,FVector B=default(FVector));
		/// <summary>Vector divide by an integer</summary>
		public extern static FVector Divide_VectorInt(FVector A,int B=1);
		/// <summary>Vector divide by a float</summary>
		public extern static FVector Divide_VectorFloat(FVector A,float B=1.000000f);
		/// <summary>Element-wise Vector multiplication (Result = {A.x*B.x, A.y*B.y, A.z*B.z})</summary>
		public extern static FVector Multiply_VectorVector(FVector A,FVector B);
		/// <summary>Scales Vector A by B</summary>
		public extern static FVector Multiply_VectorInt(FVector A,int B);
		/// <summary>Scales Vector A by B</summary>
		public extern static FVector Multiply_VectorFloat(FVector A,float B);
		/// <summary>
		/// Returns a new rotation component value
		/// @param InCurrent is the current rotation value
		/// @param InDesired is the desired rotation value
		/// @param  is the rotation amount to apply
		/// @return a new rotation component value clamped in the range (-360,360)
		/// </summary>
		public extern static float FixedTurn(float InCurrent,float InDesired,float InDeltaRate);
		/// <summary>
		/// Simple function to create a pulsating scalar value
		/// @param  InCurrentTime  Current absolute time
		/// @param  InPulsesPerSecond  How many full pulses per second?
		/// @param  InPhase  Optional phase amount, between 0.0 and 1.0 (to synchronize pulses)
		/// @return  Pulsating value (0.0-1.0)
		/// </summary>
		public extern static float MakePulsatingValue(float InCurrentTime,float InPulsesPerSecond=1.000000f,float InPhase=0.000000f);
		/// <summary>Interpolate between A and B, applying an ease in/out function.  Exp controls the degree of the curve.</summary>
		public extern static float FInterpEaseInOut(float A,float B,float Alpha,float Exponent);
		/// <summary>Multiplies the input value by pi.</summary>
		public extern static float MultiplyByPi(float Value);
		/// <summary>Returns Value mapped from one range into another where the Value is clamped to the Input Range.  (e.g. 0.5 normalized from the range 0->1 to 0->50 would result in 25)</summary>
		public extern static float MapRangeClamped(float Value,float InRangeA,float InRangeB,float OutRangeA,float OutRangeB);
		/// <summary>Returns Value mapped from one range into another.  (e.g. 20 normalized from the range 10->50 to 20->40 would result in 25)</summary>
		public extern static float MapRangeUnclamped(float Value,float InRangeA,float InRangeB,float OutRangeA,float OutRangeB);
		/// <summary>Returns Value normalized to the given range.  (e.g. 20 normalized to the range 10->50 would result in 0.25)</summary>
		public extern static float NormalizeToRange(float Value,float RangeMin,float RangeMax);
		/// <summary>Sign (float, returns -1 if A < 0, 0 if A is zero, and +1 if A > 0)</summary>
		public extern static float SignOfFloat(float A);
		/// <summary>Returns the number of times Divisor will go into Dividend (i.e., Dividend divided by Divisor), as well as the remainder</summary>
		public extern static int FMod(float Dividend,float Divisor,out float Remainder);
		/// <summary>Rounds A to the smallest following integer</summary>
		public extern static int FCeil(float A);
		/// <summary>Rounds A to an integer with truncation towards zero for each element in a vector.  (e.g. -1.7 truncated to -1, 2.8 truncated to 2)</summary>
		public extern static FIntVector FTruncVector(FVector InVector);
		/// <summary>Rounds A to an integer with truncation towards zero.  (e.g. -1.7 truncated to -1, 2.8 truncated to 2)</summary>
		public extern static int FTrunc(float A);
		/// <summary>Rounds A to the largest previous integer</summary>
		public extern static int FFloor(float A);
		/// <summary>Rounds A to the nearest integer</summary>
		public extern static int Round(float A);
		/// <summary>Easeing  between A and B using a specified easing function</summary>
		public extern static float Ease(float A,float B,float Alpha,EEasingFunc EasingFunc,float BlendExp=2.000000f,int Steps=2);
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
		public extern static float InverseLerp(float A,float B,float Value);
		/// <summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
		public extern static float Lerp(float A,float B,float Alpha);
		/// <summary>Returns V clamped to be between A and B (inclusive)</summary>
		public extern static float FClamp(float Value,float Min,float Max);
		/// <summary>Returns the maximum value of A and B</summary>
		public extern static float FMax(float A,float B);
		/// <summary>Returns the minimum value of A and B</summary>
		public extern static float FMin(float A,float B);
		/// <summary>
		/// Clamps an arbitrary angle to be between the given angles.  Will clamp to nearest boundary.
		/// @param MinAngleDegrees       "from" angle that defines the beginning of the range of valid angles (sweeping clockwise)
		/// @param MaxAngleDegrees       "to" angle that defines the end of the range of valid angles
		/// @return Returns clamped angle in the range -180..180.
		/// </summary>
		public extern static float ClampAngle(float AngleDegrees,float MinAngleDegrees,float MaxAngleDegrees);
		/// <summary>Returns the inverse tan (atan2) of A/B (result is in Degrees)</summary>
		public extern static float DegAtan2(float A,float B);
		/// <summary>Returns the inverse tan (atan) (result is in Degrees)</summary>
		public extern static float DegAtan(float A);
		/// <summary>Returns the tan of A (expects Degrees)</summary>
		public extern static float DegTan(float A);
		/// <summary>Returns the inverse cos (arccos) of A (result is in Degrees)</summary>
		public extern static float DegAcos(float A);
		/// <summary>Returns the cos of A (expects Degrees)</summary>
		public extern static float DegCos(float A);
		/// <summary>Returns the inverse sin (arcsin) of A (result is in Degrees)</summary>
		public extern static float DegAsin(float A);
		/// <summary>Returns the sin of A (expects Degrees)</summary>
		public extern static float DegSin(float A);
		/// <summary>Returns degrees value based on the input radians</summary>
		public extern static float RadiansToDegrees(float A);
		/// <summary>Returns radians value based on the input degrees</summary>
		public extern static float DegreesToRadians(float A);
		/// <summary>Returns the value of TAU (= 2 * PI)</summary>
		public extern static float GetTAU();
		/// <summary>Returns the value of PI</summary>
		public extern static float GetPI();
		/// <summary>Generate a random number between Min and Max</summary>
		public extern static float RandomFloatInRange(float Min,float Max);
		/// <summary>Returns a random float between 0 and 1</summary>
		public extern static float RandomFloat();
		/// <summary>Returns square of A (A*A)</summary>
		public extern static float Square(float A);
		/// <summary>Returns square root of A</summary>
		public extern static float Sqrt(float A);
		/// <summary>Returns natural log of A (if e^R == A, returns R)</summary>
		public extern static float Loge(float A);
		/// <summary>Returns exponential(e) to the power A (e^A)</summary>
		public extern static float Exp(float A);
		/// <summary>Returns the inverse tan (atan2) of A/B (result is in Radians)</summary>
		public extern static float Atan2(float A,float B);
		/// <summary>Returns the inverse tan (atan) (result is in Radians)</summary>
		public extern static float Atan(float A);
		/// <summary>Returns the tan of A (expects Radians)</summary>
		public extern static float Tan(float A);
		/// <summary>Returns the inverse cosine (arccos) of A (result is in Radians)</summary>
		public extern static float Acos(float A);
		/// <summary>Returns the cosine of A (expects Radians)</summary>
		public extern static float Cos(float A);
		/// <summary>Returns the inverse sine (arcsin) of A (result is in Radians)</summary>
		public extern static float Asin(float A);
		/// <summary>Returns the sine of A (expects Radians)</summary>
		public extern static float Sin(float A);
		/// <summary>Returns the absolute (positive) value of A</summary>
		public extern static float Abs(float A);
		/// <summary>
		/// Snaps a value to the nearest grid multiple. E.g.,
		///             Location = 5.1, GridSize = 10.0 : return value = 10.0
		/// If GridSize is 0 Location is returned
		/// if GridSize is very small precision issues may occur.
		/// </summary>
		public extern static float GridSnap_Float(float Location,float GridSize);
		/// <summary>Returns the hypotenuse of a right-angled triangle given the width and height.</summary>
		public extern static float Hypotenuse(float Width,float Height);
		/// <summary>Returns V clamped to be between A and B (inclusive)</summary>
		public extern static bool InRange_FloatFloat(float Value,float Min,float Max,bool InclusiveMin=true,bool InclusiveMax=true);
		/// <summary>Returns true if A does not equal B (A != B)</summary>
		public extern static bool NotEqual_FloatFloat(float A,float B);
		/// <summary>Returns true if A is nearly equal to B (|A - B| < ErrorTolerance)</summary>
		public extern static bool NearlyEqual_FloatFloat(float A,float B,float ErrorTolerance=0.000001f);
		/// <summary>Returns true if A is exactly equal to B (A == B)</summary>
		public extern static bool EqualEqual_FloatFloat(float A,float B);
		/// <summary>Returns true if A is greater than or equal to B (A >= B)</summary>
		public extern static bool GreaterEqual_FloatFloat(float A,float B);
		/// <summary>Returns true if A is Less than or equal to B (A <= B)</summary>
		public extern static bool LessEqual_FloatFloat(float A,float B);
		/// <summary>Returns true if A is greater than B (A > B)</summary>
		public extern static bool Greater_FloatFloat(float A,float B);
		/// <summary>Returns true if A is Less than B (A < B)</summary>
		public extern static bool Less_FloatFloat(float A,float B);
		/// <summary>Subtraction (A - B)</summary>
		public extern static float Subtract_FloatFloat(float A,float B=1.000000f);
		/// <summary>Addition (A + B)</summary>
		public extern static float Add_FloatFloat(float A,float B=1.000000f);
		/// <summary>Returns the fractional part of a float.</summary>
		public extern static float Fraction(float A);
		/// <summary>Modulo (A % B)</summary>
		public extern static float Percent_FloatFloat(float A,float B=1.000000f);
		/// <summary>Division (A / B)</summary>
		public extern static float Divide_FloatFloat(float A,float B=1.000000f);
		/// <summary>Multiplication (A * B)</summary>
		public extern static float Multiply_IntFloat(int A,float B);
		/// <summary>Multiplication (A * B)</summary>
		public extern static float Multiply_FloatFloat(float A,float B);
		/// <summary>Power (Base to the Exp-th power)</summary>
		public extern static float MultiplyMultiply_FloatFloat(float Base,float Exp);
		/// <summary>Returns the absolute (positive) value of A</summary>
		public extern static int Abs_Int(int A);
		/// <summary>Returns Value clamped to be between A and B (inclusive)</summary>
		public extern static int Clamp(int Value,int Min,int Max);
		/// <summary>Returns the maximum value of A and B</summary>
		public extern static int Max(int A,int B);
		/// <summary>Returns the minimum value of A and B</summary>
		public extern static int Min(int A,int B);
		/// <summary>Return a random integer between Min and Max (>= Min and <= Max)</summary>
		public extern static int RandomIntegerInRange(int Min,int Max);
		/// <summary>Returns a uniformly distributed random number between 0 and Max - 1</summary>
		public extern static int RandomInteger(int Max);
		/// <summary>Sign (integer, returns -1 if A < 0, 0 if A is zero, and +1 if A > 0)</summary>
		public extern static int SignOfInteger(int A);
		/// <summary>Bitwise NOT (~A)</summary>
		public extern static int Not_Int(int A);
		/// <summary>Bitwise OR (A | B)</summary>
		public extern static int Or_IntInt(int A,int B);
		/// <summary>Bitwise XOR (A ^ B)</summary>
		public extern static int Xor_IntInt(int A,int B);
		/// <summary>Bitwise AND (A & B)</summary>
		public extern static int And_IntInt(int A,int B);
		/// <summary>Returns true if A is not equal to B (A != B)</summary>
		public extern static bool NotEqual_IntInt(int A,int B);
		/// <summary>Returns true if A is equal to B (A == B)</summary>
		public extern static bool EqualEqual_IntInt(int A,int B);
		/// <summary>Returns true if A is greater than or equal to B (A >= B)</summary>
		public extern static bool GreaterEqual_IntInt(int A,int B);
		/// <summary>Returns true if A is less than or equal to B (A <= B)</summary>
		public extern static bool LessEqual_IntInt(int A,int B);
		/// <summary>Returns true if A is greater than B (A > B)</summary>
		public extern static bool Greater_IntInt(int A,int B);
		/// <summary>Returns true if A is less than B (A < B)</summary>
		public extern static bool Less_IntInt(int A,int B);
		/// <summary>Subtraction (A - B)</summary>
		public extern static int Subtract_IntInt(int A,int B=1);
		/// <summary>Addition (A + B)</summary>
		public extern static int Add_IntInt(int A,int B=1);
		/// <summary>Modulo (A % B)</summary>
		public extern static int Percent_IntInt(int A,int B=1);
		/// <summary>Division (A / B)</summary>
		public extern static int Divide_IntInt(int A,int B=1);
		/// <summary>Multiplication (A * B)</summary>
		public extern static int Multiply_IntInt(int A,int B);
		/// <summary>Returns true if A is not equal to B (A != B)</summary>
		public extern static bool NotEqual_ByteByte(byte A,byte B);
		/// <summary>Returns true if A is equal to B (A == B)</summary>
		public extern static bool EqualEqual_ByteByte(byte A,byte B);
		/// <summary>Returns true if A is greater than or equal to B (A >= B)</summary>
		public extern static bool GreaterEqual_ByteByte(byte A,byte B);
		/// <summary>Returns true if A is less than or equal to B (A <= B)</summary>
		public extern static bool LessEqual_ByteByte(byte A,byte B);
		/// <summary>Returns true if A is greater than B (A > B)</summary>
		public extern static bool Greater_ByteByte(byte A,byte B);
		/// <summary>Returns true if A is less than B (A < B)</summary>
		public extern static bool Less_ByteByte(byte A,byte B);
		/// <summary>Returns the maximum value of A and B</summary>
		public extern static byte BMax(byte A,byte B);
		/// <summary>Returns the minimum value of A and B</summary>
		public extern static byte BMin(byte A,byte B);
		/// <summary>Subtraction (A - B)</summary>
		public extern static byte Subtract_ByteByte(byte A,byte B=1);
		/// <summary>Addition (A + B)</summary>
		public extern static byte Add_ByteByte(byte A,byte B=1);
		/// <summary>Modulo (A % B)</summary>
		public extern static byte Percent_ByteByte(byte A,byte B=1);
		/// <summary>Division (A / B)</summary>
		public extern static byte Divide_ByteByte(byte A,byte B=1);
		/// <summary>Multiplication (A * B)</summary>
		public extern static byte Multiply_ByteByte(byte A,byte B);
		/// <summary>Returns the logical Not OR of two values (A NOR B)</summary>
		public extern static bool BooleanNOR(bool A,bool B);
		/// <summary>Returns the logical eXclusive OR of two values (A XOR B)</summary>
		public extern static bool BooleanXOR(bool A,bool B);
		/// <summary>Returns the logical OR of two values (A OR B)</summary>
		public extern static bool BooleanOR(bool A,bool B);
		/// <summary>Returns the logical NAND of two values (A AND B)</summary>
		public extern static bool BooleanNAND(bool A,bool B);
		/// <summary>Returns the logical AND of two values (A AND B)</summary>
		public extern static bool BooleanAND(bool A,bool B);
		/// <summary>Returns true if the values are not equal (A != B)</summary>
		public extern static bool NotEqual_BoolBool(bool A,bool B);
		/// <summary>Returns true if the values are equal (A == B)</summary>
		public extern static bool EqualEqual_BoolBool(bool A,bool B);
		/// <summary>Returns the logical complement of the Boolean value (NOT A)</summary>
		public extern static bool Not_PreBool(bool A);
		/// <summary>
		/// Get a random chance with the specified weight. Range of weight is 0.0 - 1.0 E.g.,
		///               Weight = .6 return value = True 60% of the time
		/// </summary>
		public extern static bool RandomBoolWithWeightFromStream(float Weight,FRandomStream RandomStream);
		/// <summary>
		/// Get a random chance with the specified weight. Range of weight is 0.0 - 1.0 E.g.,
		///              Weight = .6 return value = True 60% of the time
		/// </summary>
		public extern static bool RandomBoolWithWeight(float Weight);
		/// <summary>Returns a uniformly distributed random bool</summary>
		public extern static bool RandomBool();
		
	}
	
}
