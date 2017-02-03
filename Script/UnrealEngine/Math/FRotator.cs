using System.Runtime.CompilerServices;
namespace UnrealEngine
{
    public partial struct FRotator
    {
	    /**
	     * Constructor
	     *
	     * @param InF Value to set all components to.
	     */
	    public FRotator(float InF)
        {
            this.Pitch = this.Roll = this.Yaw = InF;
        }

	    /**
	     * Constructor.
	     *
	     * @param InPitch Pitch in degrees.
	     * @param InYaw Yaw in degrees.
	     * @param InRoll Roll in degrees.
	     */
        public FRotator(float InPitch, float InYaw, float InRoll)
        {
            this.Pitch = InPitch;
            this.Yaw = InYaw;
            this.Roll = InRoll;
        }

        public FRotator(FRotator Other)
        {
            this.Pitch =Other.Pitch;
            this.Yaw = Other.Yaw;
            this.Roll = Other.Roll;
        }

        /**
	     * Get the result of adding a rotator to this.
	     *
	     * @param R The other rotator.
	     * @return The result of adding a rotator to this.
	     */
        public static FRotator operator +(FRotator A,FRotator R)
        {
            return new FRotator(A.Pitch + R.Pitch, A.Yaw + R.Yaw, A.Roll + R.Roll);
        }

	    /**
	     * Get the result of subtracting a rotator from this.
	     *
	     * @param R The other rotator.
	     * @return The result of subtracting a rotator from this.
	     */
        public static FRotator operator -(FRotator A, FRotator R)
        {
            return new FRotator(A.Pitch - R.Pitch, A.Yaw - R.Yaw, A.Roll - R.Roll);
        }

	    /**
	     * Get the result of scaling this rotator.
	     *
	     * @param Scale The scaling factor.
	     * @return The result of scaling.
	     */
	    public static FRotator operator*(FRotator A, float Scale )
        {
            return new FRotator( A.Pitch*Scale, A.Yaw*Scale, A.Roll*Scale );
        }

        /**
	     * Checks whether two rotators are identical. This checks each component for exact equality.
	     *
	     * @param R The other rotator.
	     * @return true if two rotators are identical, otherwise false.
	     * @see Equals()
	     */
	    public static bool operator==(FRotator A, FRotator R )
        {
            return A.Equals(R);
        }

	    /**
	     * Checks whether two rotators are different.
	     *
	     * @param V The other rotator.
	     * @return true if two rotators are different, otherwise false.
	     */
	    public static bool operator!=(FRotator A,FRotator V )
        {
            return !A.Equals(V);
        }

        bool Equals(FRotator R, float Tolerance=Const.KINDA_SMALL_NUMBER )
        {
            	return (FMath.Abs(NormalizeAxis(Pitch - R.Pitch)) <= Tolerance) 
		    && (FMath.Abs(NormalizeAxis(Yaw - R.Yaw)) <= Tolerance) 
		    && (FMath.Abs(NormalizeAxis(Roll - R.Roll)) <= Tolerance);
        }

        public override bool Equals(object obj)
        {
            return Equals((FRotator)obj);
        }
        public override int GetHashCode()
        { return base.GetHashCode(); }
        /**
	    * Adds to each component of the rotator.
	    *
	    * @param DeltaPitch Change in pitch. (+/-)
	    * @param DeltaYaw Change in yaw. (+/-)
	    * @param DeltaRoll Change in roll. (+/-)
	    * @return Copy of rotator after addition.
	    */
	    public FRotator Add( float DeltaPitch, float DeltaYaw, float DeltaRoll )
        {
            Yaw   += DeltaYaw;
	        Pitch += DeltaPitch;
	        Roll  += DeltaRoll;
	        //DiagnosticCheckNaN();
	        return this;
        }

	    /**
	    * Returns the inverse of the rotator.
	    */
	    public FRotator GetInverse()
        {
            return Quaternion().Inverse().Rotator();
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static FVector Vector(ref FRotator _this);

        /**
	     * Convert a rotation into a unit vector facing in its direction.
	     *
	     * @return Rotation as a unit direction vector.
	     */
	    public FVector Vector()
        {
            return Vector(ref this);
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static FQuat Quaternion(ref FRotator _this);
	    /**
	     * Get Rotation as a quaternion.
	     *
	     * @return Rotation as a quaternion.
	     */
	    public FQuat Quaternion()
        {
            return Quaternion(ref this);
        }

	    /**
	     * Convert a Rotator into floating-point Euler angles (in degrees). Rotator now stored in degrees.
	     *
	     * @return Rotation as a Euler angle vector.
	     */
	    public FVector Euler()
        {
            return new FVector( Roll, Pitch, Yaw );
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static FVector RotateVector(ref FRotator _this,FVector V);
	    /**
	     * Rotate a vector rotated by this rotator.
	     *
	     * @param V The vector to rotate.
	     * @return The rotated vector.
	     */
	    public FVector RotateVector(FVector V )
        {
            return RotateVector(ref this,V);
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static FVector UnrotateVector(ref FRotator _this,FVector V);
	    /**
	     * Returns the vector rotated by the inverse of this rotator.
	     *
	     * @param V The vector to rotate.
	     * @return The rotated vector.
	     */
	    public FVector UnrotateVector( FVector V )
        {
            return UnrotateVector(ref this,V);
        }

	    /**
	     * Gets the rotation values so they fall within the range [0,360]
	     *
	     * @return Clamped version of rotator.
	     */
	    public FRotator Clamp()
        {
            return new FRotator(ClampAxis(Pitch), ClampAxis(Yaw), ClampAxis(Roll));
        }


        /** 
	     * Create a copy of this rotator and normalize, removes all winding and creates the "shortest route" rotation. 
	     *
	     * @return Normalized copy of this rotator
	     */
	    public FRotator GetNormalized()
        {
            FRotator Rot = this;
	        Rot.Normalize();
	        return Rot;
        }

	    /** 
	     * Create a copy of this rotator and denormalize, clamping each axis to 0 - 360. 
	     *
	     * @return Denormalized copy of this rotator
	     */
	    public FRotator GetDenormalized()
        {
            FRotator Rot = this;
	        Rot.Pitch	= ClampAxis(Rot.Pitch);
	        Rot.Yaw		= ClampAxis(Rot.Yaw);
	        Rot.Roll	= ClampAxis(Rot.Roll);
	        return Rot;
        }

	    /**
	     * In-place normalize, removes all winding and creates the "shortest route" rotation.
	     */
	    public void Normalize()
        {
            Pitch = NormalizeAxis(Pitch);
	        Yaw = NormalizeAxis(Yaw);
	        Roll = NormalizeAxis(Roll);
        }

        /**
	     * Clamps an angle to the range of [0, 360).
	     *
	     * @param Angle The angle to clamp.
	     * @return The clamped angle.
	     */
	    public static float ClampAxis( float Angle )
        {
            //Angle = FMath::Fmod(Angle, 360.f);
            Angle = Angle% 360.0f;

	        if (Angle < 0.0f)
	        {
		        // shift to [0,360) range
		        Angle += 360.0f;
	        }

	        return Angle;
        }

	    /**
	     * Clamps an angle to the range of (-180, 180].
	     *
	     * @param Angle The Angle to clamp.
	     * @return The clamped angle.
	     */
	    public static float NormalizeAxis( float Angle )
        {
            // returns Angle in the range [0,360)
	        Angle = ClampAxis(Angle);

	        if (Angle > 180.0f)
	        {
		        // shift to (-180,180]
		        Angle -= 360.0f;
	        }

	        return Angle;
        }

	    /**
	     * Convert a vector of floating-point Euler angles (in degrees) into a Rotator. Rotator now stored in degrees
	     *
	     * @param Euler Euler angle vector.
	     * @return A rotator from a Euler angle.
	     */
	    public static FRotator MakeFromEuler( FVector Euler )
        {
            return new FRotator(Euler.Y, Euler.Z, Euler.X);
        }


        public static readonly FRotator ZeroRotator = new FRotator();
    }
}
