namespace UnrealEngine
{

    //// Generic axis enum (mirrored for property use in Object.h)
    //enum EAxis
    //{
    //        None,
    //        X,
    //        Y,
    //        Z,
    //}
    public enum EForceInit
    {
        ForceInit,
        ForceInitToZero
    }

    // Extended axis enum for more specialized usage
    enum EAxisList
    {
            None = 0,
            X = 1,
            Y = 2,
            Z = 4,

            Screen = 8,
            XY = X | Y,
            XZ = X | Z,
            YZ = Y | Z,
            XYZ = X | Y | Z,
            All = XYZ | Screen,

            //alias over Axis YZ since it isn't used when the z-rotation widget is being used
            ZRotation = YZ,

            // alias over Screen since it isn't used when the 2d translate rotate widget is being used
            Rotate2D = Screen,
    }

}
