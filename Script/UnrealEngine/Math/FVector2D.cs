namespace UnrealEngine
{
    public partial struct FVector2D
    {

        /** Global 2D zero vector constant (0,0) */
        static public readonly FVector2D ZeroVector = new FVector2D(0, 0);

        /** Global 2D unit vector constant (1,1) */
        static public readonly FVector2D UnitVector = new FVector2D(1, 1);

        public FVector2D(float InX, float InY)
        {
            X = InX;
            Y = InY;
        }
        /**
         * Gets the result of component-wise addition of this and another vector.
         *
         * @param V The vector to add to this.
         * @return The result of vector addition.
         */
        public static FVector2D operator +(FVector2D A, FVector2D V)
        {
            return new FVector2D(A.X + V.X, A.Y + V.Y);
        }
        /**
         * Gets the result of component-wise subtraction of this by another vector.
         *
         * @param V The vector to subtract from this.
         * @return The result of vector subtraction.
         */
        public static FVector2D operator -(FVector2D A, FVector2D V)
        {
            return new FVector2D(A.X - V.X, A.Y - V.Y);
        }

        /**
        * Gets the result of scaling the vector (multiplying each component by a value).
        *
        * @param Scale What to multiply each component by.
        * @return The result of multiplication.
        */
        public static FVector2D operator *(FVector2D A, float Scale)
        {
            return new FVector2D(A.X * Scale, A.Y * Scale);
        }
        /**
         * Gets the result of dividing each component of the vector by a value.
         *
         * @param Scale What to divide each component by.
         * @return The result of division.
         */
        public static FVector2D operator /(FVector2D A, float Scale)
        {
            float RScale = 1.0f / Scale;
            return new FVector2D(A.X * RScale, A.Y * RScale);
        }
        /**
         * Gets the result of component-wise multiplication of this vector by another.
         *
         * @param V The vector to multiply with.
         * @return The result of multiplication.
         */
        public static FVector2D operator *(FVector2D A, FVector2D V)
        {
            return new FVector2D(A.X * V.X, A.Y * V.Y);
        }
        /**
         * Gets the result of component-wise division of this vector by another.
         *
         * @param V The vector to divide by.
         * @return The result of division.
         */
        public static FVector2D operator /(FVector2D A, FVector2D V)
        {
            return new FVector2D(A.X / V.X, A.Y / V.Y);
        }

        public static float Dot(FVector2D a, FVector2D b)
        {
            return a.X * b.X + a.Y * b.Y;
        }


        public float Size()
        {
            return (float)System.Math.Sqrt(X * X + Y * Y);
        }

        public float magnitude
        {
            get
            {
                return Size();
            }
        }

        public FVector2D normalized
        {
            get
            {
                return new FVector2D(X / magnitude, Y / magnitude);
            }
        }

        public override bool Equals(object obj)
        {
            FVector2D V = (FVector2D)obj;
            return X == V.X && Y == V.Y;
        }
        public override int GetHashCode()
        { return base.GetHashCode(); }
        public static bool operator ==(FVector2D This, FVector2D Other)
        {
            return This.Equals(Other);
        }

        public static bool operator !=(FVector2D This, FVector2D Other)
        {
            return !This.Equals(Other);
        }

        public static float operator |(FVector2D A, FVector2D V)
        {
            return A.X * V.X + A.Y * V.Y;
        }


        public static float operator ^(FVector2D A, FVector2D V)
        {
            return A.X * V.Y - A.Y * V.X;
        }

        /**
        * Calculates the dot product of two vectors.
        *
        * @param A The first vector.
        * @param B The second vector.
        * @return The dot product.
        */
        public static float DotProduct(FVector2D A, FVector2D B)
        {
            return A | B;
        }

        /**
         * Squared distance between two 2D points.
         *
         * @param V1 The first point.
         * @param V2 The second point.
         * @return The squared distance between two 2D points.
         */
        public static float DistSquared(FVector2D V1, FVector2D V2)
        {
            return UKismetMathLibrary.Square(V2.X - V1.X) + UKismetMathLibrary.Square(V2.Y - V1.Y);
        }

        /**
         * Distance between two 2D points.
         *
         * @param V1 The first point.
         * @param V2 The second point.
         * @return The squared distance between two 2D points.
         */
        public static float Distance(FVector2D V1, FVector2D V2)
        {
            return UKismetMathLibrary.Sqrt(FVector2D.DistSquared(V1, V2));
        }

        /**
         * Calculate the cross product of two vectors.
         *
         * @param A The first vector.
         * @param B The second vector.
         * @return The cross product.
         */
        public static float CrossProduct(FVector2D A, FVector2D B)
        {
            return A ^ B;
        }
        /**
         * Rotates around axis (0,0,1)
         *
         * @param AngleDeg Angle to rotate (in degrees)
         * @return Rotated Vector
         */
        public FVector2D GetRotated(float AngleDeg)
        {
            float S, C;
            FMath.SinCos(out S, out C, UKismetMathLibrary.DegreesToRadians(AngleDeg));

            float OMC = 1.0f - C;

            return new FVector2D(
                C * X - S * Y,
                S * X + C * Y);
        }

        /**
         * Gets a normalized copy of the vector, checking it is safe to do so based on the length.
         * Returns zero vector if vector length is too small to safely normalize.
         *
         * @param Tolerance Minimum squared length of vector for normalization.
         * @return A normalized copy of the vector if safe, (0,0) otherwise.
         */
        public FVector2D GetSafeNormal(float Tolerance = Const.SMALL_NUMBER)
        {
            float SquareSum = X * X + Y * Y;
            if (SquareSum > Tolerance)
            {
                float Scale = (float)(1.0f / FMath.Sqrt(SquareSum));
                return new FVector2D(X * Scale, Y * Scale);
            }
            return new FVector2D(0.0f, 0.0f);
        }

        /**
	     * Normalize this vector in-place if it is large enough, set it to (0,0) otherwise.
	     *
	     * @param Tolerance Minimum squared length of vector for normalization.
	     * @see GetSafeNormal()
	     */
        public void Normalize(float Tolerance = Const.SMALL_NUMBER)
        {
            float SquareSum = X * X + Y * Y;
            if (SquareSum > Tolerance)
            {
                float Scale = (float)(1.0f / FMath.Sqrt(SquareSum));
                X *= Scale;
                Y *= Scale;
                return;
            }
            X = 0.0f;
            Y = 0.0f;
        }


        public static float Angle(FVector2D A,FVector2D B)
        {
            float cosa = (A | B) / (A.Size() * B.Size());
            return UKismetMathLibrary.Acos(cosa);
        }
    }
}
