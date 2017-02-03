namespace UnrealEngine
{
    public struct Const
    {
        public const float PI = (3.1415926535897932f);
        public const float SMALL_NUMBER = (1.0e-8f);
        public const float KINDA_SMALL_NUMBER = (1.0e-4f);
        public const float BIG_NUMBER = (3.4e+38f);
        public const float EULERS_NUMBER = (2.71828182845904523536f);
        // Copied from float.h
        public const float MAX_FLT = 3.402823466e+38F;

        // Aux constants.
        public const float INV_PI = (0.31830988618f);
        public const float HALF_PI = (1.57079632679f);

        
        // Magic numbers for numerical precision.
        public const float DELTA	=		(0.00001f);

        /**
         * Lengths of normalized vectors (These are half their maximum values
         * to assure that dot products with normalized vectors don't overflow).
         */
        public const float FLOAT_NORMAL_THRESH	=			(0.0001f);

        //
        // Magic numbers for numerical precision.
        //
        public const float THRESH_POINT_ON_PLANE=			(0.10f);		/* Thickness of plane for front/back/inside test */
        public const float THRESH_POINT_ON_SIDE	=		(0.20f);		/* Thickness of polygon side's side-plane for point-inside/outside/on side test */
        public const float THRESH_POINTS_ARE_SAME	=		(0.00002f);	/* Two points are same if within this distance */
        public const float THRESH_POINTS_ARE_NEAR	=		(0.015f);	/* Two points are near if within this distance and can be combined if imprecise math is ok */
        public const float THRESH_NORMALS_ARE_SAME	=		(0.00002f);	/* Two normal points are same if within this distance */
													        /* Making this too large results in incorrect CSG classification and disaster */
        public const float THRESH_VECTORS_ARE_NEAR	=		(0.0004f);	/* Two vectors are near if within this distance and can be combined if imprecise math is ok */
													        /* Making this too large results in lighting problems due to inaccurate texture coordinates */
        public const float THRESH_SPLIT_POLY_WITH_PLANE=	(0.25f);		/* A plane splits a polygon in half */
        public const float THRESH_SPLIT_POLY_PRECISELY=		(0.01f);		/* A plane exactly splits a polygon */
        public const float THRESH_ZERO_NORM_SQUARED	=	(0.0001f);	/* Size of a unit normal that is considered "zero", squared */
        public const float THRESH_NORMALS_ARE_PARALLEL	=	(0.999845f);	/* Two unit vectors are parallel if abs(A dot B) is greater than or equal to this. This is roughly cosine(1.0 degrees). */
        public const float THRESH_NORMALS_ARE_ORTHOGONAL=	(0.017455f);	/* Two unit vectors are orthogonal (perpendicular) if abs(A dot B) is less than or equal this. This is roughly cosine(89.0 degrees). */

        /** Allowed error for a normalized vector (against squared magnitude) */
        public const float THRESH_VECTOR_NORMALIZED	=	(0.01f);		
        /** Allowed error for a normalized quaternion (against squared magnitude) */
        public const float THRESH_QUAT_NORMALIZED = (0.01f);		
    }
    public class FMath : UKismetMathLibrary
    {
        /**
            * Computes the sine and cosine of a scalar float.
            *
            * @param ScalarSin	Pointer to where the Sin result should be stored
            * @param ScalarCos	Pointer to where the Cos result should be stored
            * @param Value  input angles 
            */
        public static void SinCos(out float ScalarSin, out float ScalarCos, float Value)
        {
            // Map Value to y in [-pi,pi], x = 2*pi*quotient + remainder.
            float quotient = (Const.INV_PI * 0.5f) * Value;
            if (Value >= 0.0f)
            {
                quotient = (float)((int)(quotient + 0.5f));
            }
            else
            {
                quotient = (float)((int)(quotient - 0.5f));
            }
            float y = Value - (2.0f * Const.PI) * quotient;

            // Map y to [-pi/2,pi/2] with sin(y) = sin(Value).
            float sign;
            if (y > Const.HALF_PI)
            {
                y = Const.PI - y;
                sign = -1.0f;
            }
            else if (y < -Const.HALF_PI)
            {
                y = -Const.PI - y;
                sign = -1.0f;
            }
            else
            {
                sign = +1.0f;
            }

            float y2 = y * y;

            // 11-degree minimax approximation
            ScalarSin = (((((-2.3889859e-08f * y2 + 2.7525562e-06f) * y2 - 0.00019840874f) * y2 + 0.0083333310f) * y2 - 0.16666667f) * y2 + 1.0f) * y;

            // 10-degree minimax approximation
            float p = ((((-2.6051615e-07f * y2 + 2.4760495e-05f) * y2 - 0.0013888378f) * y2 + 0.041666638f) * y2 - 0.5f) * y2 + 1.0f;
            ScalarCos = sign * p;
        }

        public static float InvSqrt(float A)
        {
            return (float)(1.0f / System.Math.Sqrt(A));
        }

        public static FVector Lerp(FVector A, FVector B, float V)
        {
            return A + (B - A) * V;
        }

        public static float Clamp(float A, float min, float max)
        {
            return UKismetMathLibrary.FClamp(A, max, min);
        }
        public static new int Clamp(int A, int min, int max)
        {
            return UKismetMathLibrary.Clamp(A, max, min);
        }

        public static float Max(float A, float B)
        {
            return UKismetMathLibrary.FMax(A, B);
        }

        public static float Min(float A,float B)
        {
            return UKismetMathLibrary.FMin(A, B);
        }

        public static int Sign(int A)
        {
            return UKismetMathLibrary.SignOfInteger(A);
        }
        public static float Sign(float A)
        {
            return UKismetMathLibrary.SignOfFloat(A);
        }
    }
}
