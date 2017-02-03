namespace UnrealEngine
{
    public partial struct FVector4
    {
        public FVector4(float InX = 0.0f, float InY = 0.0f, float InZ = 0.0f, float InW = 1.0f)
        {
            X = InX;
            Y = InY;
            Z = InZ;
            W = InW;
        }

        public FVector4(FVector Vec3,float InW)
        {
            X = Vec3.X;
            Y = Vec3.Y;
            Z = Vec3.Z;
            W = InW;
        }
        /**
         * Returns a normalized copy of the vector if safe to normalize.
         *
         * @param Tolerance Minimum squared length of vector for normalization.
         * @return A normalized copy of the vector or a zero vector.
         */
        public FVector4 GetSafeNormal(float Tolerance = Const.SMALL_NUMBER)
        {
            float SquareSum = X*X + Y*Y + Z*Z;
	        if( SquareSum > Tolerance )
	        {
		        float Scale = FMath.InvSqrt(SquareSum);
		        return new FVector4(X*Scale, Y*Scale, Z*Scale, 0.0f);
	        }
	        return new FVector4(0.0f);
        }
    }
}
