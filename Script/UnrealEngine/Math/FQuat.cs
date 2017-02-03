using System.Runtime.CompilerServices;

namespace UnrealEngine
{
    public partial struct FQuat
    {
        public readonly static FQuat Identity = new FQuat(0, 0, 0, 1);

        //public FQuat() { X = 0; Y = 0; Z = 0; W = 0; }

        public FQuat(EForceInit init) { X = 0; Y = 0; Z = 0; W = init == EForceInit.ForceInitToZero ? 0 : 1; }

        public FQuat(float InX, float InY, float InZ, float InW)
        {
            X = InX;
            Y = InY;
            Z = InZ;
            W = InW;
        }

        public FQuat(FQuat Q)
        {
            X = Q.X;
            Y = Q.Y;
            Z = Q.Z;
            W = Q.W;
        }

        public FQuat(FMatrix M)
        {
            this = MakeFromMatrix(M);
        }
        public FQuat(FRotator R)
        {
            this = R.Quaternion();
        }
        public FQuat(FVector Axis, float AngleRad)
        {
            float half_a = 0.5f * AngleRad;
            float s, c;
            FMath.SinCos(out s, out c, half_a);

            X = s * Axis.X;
            Y = s * Axis.Y;
            Z = s * Axis.Z;
            W = c;

            //DiagnosticCheckNaN();
        }

        /**
	     * Gets the result of adding a Quaternion to this.
	     * This is a component-wise addition; composing quaternions should be done via multiplication.
	     *
	     * @param Q The Quaternion to add.
	     * @return The result of addition.
	     */
        public static FQuat operator +(FQuat A,FQuat Q)
        {
            return new FQuat(A.X + Q.X, A.Y + Q.Y, A.Z + Q.Z, A.W + Q.W);
        }

        /**
         * Gets the result of subtracting a Quaternion to this.
         * This is a component-wise subtraction; composing quaternions should be done via multiplication.
         *
         * @param Q The Quaternion to subtract.
         * @return The result of subtraction.
         */
        public static FQuat operator -(FQuat A, FQuat Q)
        {
            return new FQuat(A.X - Q.X, A.Y - Q.Y, A.Z - Q.Z, A.W - Q.W);
        }

        /**
         * Checks whether another Quaternion is equal to this, within specified tolerance.
         *
         * @param Q The other Quaternion.
         * @param Tolerance Error Tolerance.
         * @return true if two Quaternion are equal, within specified tolerance, otherwise false.
         */
        public override bool Equals(object Obj)
        {
            FQuat Q = (FQuat)Obj;
            float Tolerance = Const.KINDA_SMALL_NUMBER;
            return (FMath.Abs(X - Q.X) <= Tolerance && FMath.Abs(Y - Q.Y) <= Tolerance && FMath.Abs(Z - Q.Z) <= Tolerance && FMath.Abs(W - Q.W) <= Tolerance)
        || (FMath.Abs(X + Q.X) <= Tolerance && FMath.Abs(Y + Q.Y) <= Tolerance && FMath.Abs(Z + Q.Z) <= Tolerance && FMath.Abs(W + Q.W) <= Tolerance);
        }
        public override int GetHashCode()
        { return base.GetHashCode(); }
        /**
         * Checks whether this Quaternion is an Identity Quaternion.
         * Assumes Quaternion tested is normalized.
         *
         * @return true if Quaternion is a normalized Identity Quaternion.
         */
        public bool IsIdentity()
        {
            return ((W * W) > ((1.0f - Const.DELTA) * (1.0f - Const.DELTA)));
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static FQuat Multiply(ref FQuat _this,ref FQuat Other);
        /**
         * Gets the result of multiplying this by another quaternion (this * Q).
         *
         * Order matters when composing quaternions: C = A * B will yield a quaternion C that logically
         * first applies B then A to any subsequent transformation (right first, then left).
         *
         * @param Q The Quaternion to multiply this by.
         * @return The result of multiplication (this * Q).
         */
        public static FQuat operator*(FQuat A, FQuat Q )
        {
            return Multiply(ref A,ref Q);
        }

        /**
         * Rotate a vector by this quaternion.
         *
         * @param V the vector to be rotated
         * @return vector after rotation
         * @see RotateVector()
         */
        public static FVector operator *(FQuat A, FVector V)
        {
            return A.RotateVector(V);
        }

        /** 
         * Multiply this by a matrix.
         * This matrix conversion came from
         * http://www.m-hikari.com/ija/ija-password-2008/ija-password17-20-2008/aristidouIJA17-20-2008.pdf
         * used for non-uniform scaling transform.
         *
         * @param M Matrix to multiply by.
         * @return Matrix result after multiplication.
         */
        //FMatrix operator*( const FMatrix& M ) const;

        /**
         * Get the result of scaling this quaternion.
         *
         * @param Scale The scaling factor.
         * @return The result of scaling.
         */
        public static FQuat operator *(FQuat A, float Scale)
        {
            A.X *= Scale;
            A.Y *= Scale;
            A.Z *= Scale;
            A.W *= Scale;

            //DiagnosticCheckNaN();

            return A;
        }

        /**
         * Divide this quaternion by scale.
         *
         * @param Scale What to divide by.
         * @return new Quaternion of this after division by scale.
         */
        public static FQuat operator /(FQuat A, float Scale)
        {
            float Recip = 1.0f / Scale;
            return new FQuat(A.X * Recip, A.Y * Recip, A.Z * Recip, A.W * Recip);
        }

        /**
         * Checks whether two quaternions are identical.
         * This is an exact comparison per-component;see Equals() for a comparison
         * that allows for a small error tolerance and flipped axes of rotation.
         *
         * @param Q The other quaternion.
         * @return true if two quaternion are identical, otherwise false.
         * @see Equals()
         */
        public static bool operator ==(FQuat A, FQuat Q)
        {
            return A.Equals(Q);
        }

        /**
         * Checks whether two quaternions are not identical.
         *
         * @param Q The other quaternion.
         * @return true if two quaternion are not identical, otherwise false.
         */
        public static bool operator !=(FQuat A, FQuat Q)
        {
            return !A.Equals(Q);
        }

        /**
         * Calculates dot product of two quaternions.
         *
         * @param Q The other quaternions.
         * @return The dot product.
         */
        public static float operator |(FQuat A, FQuat Q)
        {
            return A.X * Q.X + A.Y * Q.Y + A.Z * Q.Z + A.W * Q.W;
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static FQuat MakeFromMatrix(ref FMatrix Matrix);
        public static FQuat MakeFromMatrix(FMatrix Matrix)
        {
            return MakeFromMatrix(ref Matrix);
        }
        /**
	     * Convert a vector of floating-point Euler angles (in degrees) into a Quaternion.
	     * 
	     * @param Euler the Euler angles
	     * @return constructed FQuat
	     */
        public static FQuat MakeFromEuler(FVector Euler)
        {
            return FRotator.MakeFromEuler(Euler).Quaternion();
        }

        /** Convert a Quaternion into floating-point Euler angles (in degrees). */
        public FVector Euler()
        {
            return Rotator().Euler();
        }

        /**
         * Normalize this quaternion if it is large enough.
         * If it is too small, returns an identity quaternion.
         *
         * @param Tolerance Minimum squared length of quaternion for normalization.
         */
        public void Normalize(float Tolerance = Const.SMALL_NUMBER)
        {
            float SquareSum = X * X + Y * Y + Z * Z + W * W;

            if (SquareSum >= Tolerance)
            {
                float Scale = FMath.InvSqrt(SquareSum);

                X *= Scale;
                Y *= Scale;
                Z *= Scale;
                W *= Scale;
            }
            else
            {
                this = FQuat.Identity;
            }
        }

        /**
         * Get a normalized copy of this quaternion.
         * If it is too small, returns an identity quaternion.
         *
         * @param Tolerance Minimum squared length of quaternion for normalization.
         */
        public FQuat GetNormalized(float Tolerance = Const.SMALL_NUMBER)
        {
            FQuat Result = this;
            Result.Normalize(Tolerance);
            return Result;
        }

        // Return true if this quaternion is normalized
        public bool IsNormalized()
        {
            return (FMath.Abs(1.0f - SizeSquared()) < Const.THRESH_QUAT_NORMALIZED);
        }

        /**
         * Get the length of this quaternion.
         *
         * @return The length of this quaternion.
         */
        public float Size()
        {
            return (float)(FMath.Sqrt(X * X + Y * Y + Z * Z + W * W));
        }

        /**
         * Get the length squared of this quaternion.
         *
         * @return The length of this quaternion.
         */
        public float SizeSquared()
        {
            return (X * X + Y * Y + Z * Z + W * W);
        }

        /** 
         * get the axis and angle of rotation of this quaternion
         *
         * @param Axis{out] vector of axis of the quaternion
         * @param Angle{out] angle of the quaternion
         * @warning : assumes normalized quaternions.
         */
        public void ToAxisAndAngle(out FVector Axis, out float Angle)
        {
            Angle = (float)(2.0f * FMath.Acos(W));
            Axis = GetRotationAxis();
        }

        /**
         * Rotate a vector by this quaternion.
         *
         * @param V the vector to be rotated
         * @return vector after rotation
         */
        public FVector RotateVector(FVector V)
        {
            // http://people.csail.mit.edu/bkph/articles/Quaternions.pdf
            // V' = V + 2w(Q x V) + (2Q x (Q x V))
            // refactor:
            // V' = V + w(2(Q x V)) + (Q x (2(Q x V)))
            // T = 2(Q x V);
            // V' = V + w*(T) + (Q x T)

            FVector Q = new FVector(X, Y, Z);
            FVector T = FVector.CrossProduct(Q, V) * 2.0f;
            FVector Result = V + (T * W) + FVector.CrossProduct(Q, T);
            return Result;
        }

        /**
         * Rotate a vector by the inverse of this quaternion.
         *
         * @param V the vector to be rotated
         * @return vector after rotation by the inverse of this quaternion.
         */
        public FVector UnrotateVector(FVector V)
        {
            FVector Q = new FVector(-X, -Y, -Z); // Inverse
            FVector T = FVector.CrossProduct(Q, V) * 2.0f;
            FVector Result = V + (T * W) + FVector.CrossProduct(Q, T);
            return Result;
        }

        /**
         * @return quaternion with W=0 and V=theta*v.
         */
        public FQuat Log()
        {
            FQuat Result = new UnrealEngine.FQuat();
            Result.W = 0.0f;

            if (FMath.Abs(W) < 1.0f)
            {
                float Angle = (float)FMath.Acos(W);
                float SinAngle = (float)FMath.Sin(Angle);

                if (FMath.Abs(SinAngle) >= Const.SMALL_NUMBER)
                {
                    float Scale = Angle / SinAngle;
                    Result.X = Scale * X;
                    Result.Y = Scale * Y;
                    Result.Z = Scale * Z;

                    return Result;
                }
            }

            Result.X = X;
            Result.Y = Y;
            Result.Z = Z;

            return Result;
        }

        /**
         * @note Exp should really only be used after Log.
         * Assumes a quaternion with W=0 and V=theta*v (where |v| = 1).
         * Exp(q) = (sin(theta)*v, cos(theta))
         */
        public FQuat Exp()
        {
            float Angle = (float)FMath.Sqrt(X * X + Y * Y + Z * Z);
            float SinAngle = (float)FMath.Sin(Angle);

            FQuat Result = new FQuat();
            Result.W = (float)FMath.Cos(Angle);

            if (FMath.Abs(SinAngle) >= Const.SMALL_NUMBER)
            {
                float Scale = SinAngle / Angle;
                Result.X = Scale * X;
                Result.Y = Scale * Y;
                Result.Z = Scale * Z;
            }
            else
            {
                Result.X = X;
                Result.Y = Y;
                Result.Z = Z;
            }

            return Result;
        }

        /**
         * @return inverse of this quaternion
         */
        public FQuat Inverse()
        {
            return new FQuat(-X, -Y, -Z, W);
        }

        /**
         * Enforce that the delta between this Quaternion and another one represents
         * the shortest possible rotation angle
         */
        public void EnforceShortestArcWith(FQuat OtherQuat)
        {
            float DotResult = (OtherQuat | this);
            float Bias = DotResult > 0 ? 1.0f : -1.0f;

            X *= Bias;
            Y *= Bias;
            Z *= Bias;
            W *= Bias;
        }

        /** Get the forward direction (X axis) after it has been rotated by this Quaternion. */
        public FVector GetAxisX()
        {
            return RotateVector(new FVector(1.0f, 0.0f, 0.0f));
        }

        /** Get the right direction (Y axis) after it has been rotated by this Quaternion. */
        public FVector GetAxisY()
        {
            return RotateVector(new FVector(0.0f, 1.0f, 0.0f));
        }

        /** Get the up direction (Z axis) after it has been rotated by this Quaternion. */
        public FVector GetAxisZ()
        {
            return RotateVector(new FVector(0.0f, 0.0f, 1.0f));
        }

        /** Get the forward direction (X axis) after it has been rotated by this Quaternion. */
        public FVector GetForwardVector()
        {
            return GetAxisX();
        }

        /** Get the right direction (Y axis) after it has been rotated by this Quaternion. */
        public FVector GetRightVector()
        {
            return GetAxisY();
        }

        /** Get the up direction (Z axis) after it has been rotated by this Quaternion. */
        public FVector GetUpVector()
        {
            return GetAxisZ();
        }

        /** Convert a rotation into a unit vector facing in its direction. Equivalent to GetForwardVector(). */
        public FVector Vector()
        {
            return GetAxisX();
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static FRotator Rotator(ref FQuat _this);
        /** Get the FRotator representation of this Quaternion. */
        public FRotator Rotator()
        {
            return Rotator(ref this);
        }

        /**
         * Get the axis of rotation of the Quaternion.
         * This is the axis around which rotation occurs to transform the canonical coordinate system to the target orientation.
         * For the identity Quaternion which has no such rotation, FVector(1,0,0) is returned.
         */
        public FVector GetRotationAxis()
        {
            // Ensure we never try to sqrt a neg number
            float S = (float)(FMath.Sqrt(FMath.Max(1.0f - (W * W), 0.0f)));

            if (S >= 0.0001f)
            {
                return new FVector(X / S, Y / S, Z / S);
            }

            return new FVector(1.0f, 0.0f, 0.0f);
        }

        /**
         * Get a textual representation of the vector.
         *
         * @return Text describing the vector.
         */
        public override string ToString()
        {
            return string.Format("X={0} Y={1} Z={2} W={3}", X, Y, Z, W);
        }
    }
}
