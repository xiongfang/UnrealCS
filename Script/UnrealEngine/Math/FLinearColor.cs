namespace UnrealEngine
{
    public partial struct FLinearColor
    {
        // Common colors.	
        static public readonly FLinearColor White = new FLinearColor(1.0f, 1.0f, 1.0f);
        static public readonly FLinearColor Gray = new FLinearColor(0.5f, 0.5f, 0.5f);
        static public readonly FLinearColor Black = new FLinearColor(0, 0, 0);
        static public readonly FLinearColor Transparent = new FLinearColor(0, 0, 0, 0);
        static public readonly FLinearColor Red = new FLinearColor(1.0f, 0, 0);
        static public readonly FLinearColor Green = new FLinearColor(0, 1.0f, 0);
        static public readonly FLinearColor Blue = new FLinearColor(0, 0, 1.0f);
        static public readonly FLinearColor Yellow = new FLinearColor(1.0f, 1.0f, 0);

        public FLinearColor(float InR, float InG, float InB, float InA = 1.0f)
        {
            R = (InR);
            G = (InG);
            B = (InB);
            A = (InA);
        }
        public FLinearColor(FColor Color)
        {
            R = Color.R / 255.0f;
            G = Color.G / 255.0f;
            B = Color.B / 255.0f;
            A = Color.A / 255.0f;
        }

        public static implicit operator FColor(FLinearColor Color)
        {
            return Color.ToFColor();
        }
        public static implicit operator FLinearColor(FColor Color)
        {
            return new FLinearColor(Color);
        }

        public FColor ToFColor()
        {
            return new FColor((byte)(R * 255), (byte)(G * 255), (byte)(B * 255), (byte)(A * 255));
        }

        public static FLinearColor operator +(FLinearColor ColorA, FLinearColor ColorB)
        {
            return new FLinearColor(
                 ColorA.R + ColorB.R,
                 ColorA.G + ColorB.G,
                 ColorA.B + ColorB.B,
                 ColorA.A + ColorB.A
                );
        }


        public static FLinearColor operator -(FLinearColor ColorA, FLinearColor ColorB)
        {
            return new FLinearColor(
                ColorA.R - ColorB.R,
                ColorA.G - ColorB.G,
                ColorA.B - ColorB.B,
                ColorA.A - ColorB.A
                );
        }

        public static FLinearColor operator *(FLinearColor ColorA, FLinearColor ColorB)
        {
            return new FLinearColor(
                ColorA.R * ColorB.R,
                ColorA.G * ColorB.G,
                ColorA.B * ColorB.B,
                ColorA.A * ColorB.A
                );
        }

        public static FLinearColor operator *(FLinearColor ColorA, float Scalar)
        {
            return new FLinearColor(
                ColorA.R * Scalar,
                ColorA.G * Scalar,
                ColorA.B * Scalar,
                ColorA.A * Scalar
                );
        }


        public static FLinearColor operator /(FLinearColor ColorA, FLinearColor ColorB)
        {
            return new FLinearColor(
                ColorA.R / ColorB.R,
                ColorA.G / ColorB.G,
                ColorA.B / ColorB.B,
                ColorA.A / ColorB.A
                );
        }

        public static FLinearColor operator /(FLinearColor ColorA, float Scalar)
        {
            float InvScalar = 1.0f / Scalar;
            return new FLinearColor(
                ColorA.R * InvScalar,
                ColorA.G * InvScalar,
                ColorA.B * InvScalar,
                ColorA.A * InvScalar
                );
        }
    }
}
