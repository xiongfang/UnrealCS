#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure containing information about one hit of a trace, such as point of impact and surface normal at that point.</summary>
	[StructLayout(LayoutKind.Explicit,Size=132)]
	public partial struct FHitResult
	{
		/// <summary>Indicates if this hit was a result of blocking collision. If false, there was no hit or it was an overlap/touch instead.</summary>
		public bool bBlockingHit
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		/// <summary>
		/// Whether the trace started in penetration, i.e. with an initial blocking overlap.
		/// In the case of penetration, if PenetrationDepth > 0.f, then it will represent the distance along the Normal vector that will result in
		/// minimal contact between the swept shape and the object that was hit. In this case, ImpactNormal will be the normal opposed to movement at that location
		/// (ie, Normal may not equal ImpactNormal). ImpactPoint will be the same as Location, since there is no single impact point to report.
		/// </summary>
		public bool bStartPenetrating
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 2, 2); } }}
			
		}
		/// <summary>
		/// 'Time' of impact along trace direction (ranging from 0.0 to 1.0) if there is a hit, indicating time between TraceStart and TraceEnd.
		/// For swept movement (but not queries) this may be pulled back slightly from the actual time of impact, to prevent precision problems with adjacent geometry.
		/// </summary>
		[FieldOffset(4)]
		public float Time;
		/// <summary>The distance from the TraceStart to the ImpactPoint in world space. This value is 0 if there was an initial overlap (trace started inside another colliding object).</summary>
		[FieldOffset(8)]
		public float Distance;
		/// <summary>
		/// The location in world space where the moving shape would end up against the impacted object, if there is a hit. Equal to the point of impact for line tests.
		/// Example: for a sphere trace test, this is the point where the center of the sphere would be located when it touched the other object.
		/// For swept movement (but not queries) this may not equal the final location of the shape since hits are pulled back slightly to prevent precision issues from overlapping another surface.
		/// </summary>
		[FieldOffset(12)]
		public FVector_NetQuantize Location;
		/// <summary>
		/// Location in world space of the actual contact of the trace shape (box, sphere, ray, etc) with the impacted object.
		/// Example: for a sphere trace test, this is the point where the surface of the sphere touches the other object.
		/// @note: In the case of initial overlap (bStartPenetrating=true), ImpactPoint will be the same as Location because there is no meaningful single impact point to report.
		/// </summary>
		[FieldOffset(24)]
		public FVector_NetQuantize ImpactPoint;
		/// <summary>
		/// Normal of the hit in world space, for the object that was swept. Equal to ImpactNormal for line tests.
		/// This is computed for capsules and spheres, otherwise it will be the same as ImpactNormal.
		/// Example: for a sphere trace test, this is a normalized vector pointing in towards the center of the sphere at the point of impact.
		/// </summary>
		[FieldOffset(36)]
		public FVector_NetQuantizeNormal Normal;
		/// <summary>
		/// Normal of the hit in world space, for the object that was hit by the sweep, if any.
		/// For example if a box hits a flat plane, this is a normalized vector pointing out from the plane.
		/// In the case of impact with a corner or edge of a surface, usually the "most opposing" normal (opposed to the query direction) is chosen.
		/// </summary>
		[FieldOffset(48)]
		public FVector_NetQuantizeNormal ImpactNormal;
		/// <summary>
		/// Start location of the trace.
		/// For example if a sphere is swept against the world, this is the starting location of the center of the sphere.
		/// </summary>
		[FieldOffset(60)]
		public FVector_NetQuantize TraceStart;
		/// <summary>
		/// End location of the trace; this is NOT where the impact occurred (if any), but the furthest point in the attempted sweep.
		/// For example if a sphere is swept against the world, this would be the center of the sphere if there was no blocking hit.
		/// </summary>
		[FieldOffset(72)]
		public FVector_NetQuantize TraceEnd;
		/// <summary>
		/// If this test started in penetration (bStartPenetrating is true) and a depenetration vector can be computed,
		/// this value is the distance along Normal that will result in moving out of penetration.
		/// If the distance cannot be computed, this distance will be zero.
		/// </summary>
		[FieldOffset(84)]
		public float PenetrationDepth;
		/// <summary>Extra data about item that was hit (hit primitive specific).</summary>
		[FieldOffset(88)]
		public int Item;
		/// <summary>Name of bone we hit (for skeletal meshes).</summary>
		[FieldOffset(116)]
		public FName BoneName;
		/// <summary>Face index we hit (for complex hits with triangle meshes).</summary>
		[FieldOffset(128)]
		public int FaceIndex;
		
	}
	
}
#endif
#endif
