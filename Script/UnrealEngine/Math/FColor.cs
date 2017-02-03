namespace UnrealEngine
{
    public partial struct FColor
    {
        /** Some pre-inited colors, useful for debug code */
        static public readonly FColor White = new FColor(255,255,255);
        static public readonly FColor Black = new FColor(0, 0, 0);
        static public readonly FColor Transparent = new FColor(0, 0, 0, 0);
        static public readonly FColor Red = new FColor(255, 0, 0);
        static public readonly FColor Green = new FColor(0, 255, 0);
        static public readonly FColor Blue = new FColor(0, 0, 255);
        static public readonly FColor Yellow = new FColor(255, 255, 0);
        static public readonly FColor Cyan = new FColor(0, 255, 255);
        static public readonly FColor Magenta = new FColor(255, 0, 255);
        static public readonly FColor Orange = new FColor(243, 156, 18);
        static public readonly FColor Purple = new FColor(169, 7, 228);
        static public readonly FColor Turquoise = new FColor(26, 188, 156);
        static public readonly FColor Silver = new FColor(189, 195, 199);
        static public readonly FColor Emerald = new FColor(46, 204, 113);

        public FColor(byte r, byte g, byte b,byte a=255) { this.R = r; G = g; B = b; A = a; }
    }
}
