using System.Runtime.CompilerServices;

namespace UnrealEngine
{
    public class IFileManager
    {
        /**
         * Converts passed in filename to use an absolute path (for reading)
         *
         * @param	Filename	filename to convert to use an absolute path, safe to pass in already using absolute path
         * 
         * @return	filename using absolute path
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string ConvertToAbsolutePathForExternalAppForRead(string AbsolutePath);


        /**
         * Converts passed in filename to use an absolute path (for writing)
         *
         * @param	Filename	filename to convert to use an absolute path, safe to pass in already using absolute path
         * 
         * @return	filename using absolute path
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string ConvertToAbsolutePathForExternalAppForWrite(string AbsolutePath);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static int ReadAllBytes(string InPath, out byte[] bytes);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static int WriteAllBytes(string InPath, byte[] bytes);
    }
}
