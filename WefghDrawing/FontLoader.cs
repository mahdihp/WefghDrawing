using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WefghDrawing
{

    public static class FontLoader
    {
        public static PrivateFontCollection LoadEmbeddedFont(string resourceName)
        {
            var pfc = new PrivateFontCollection();
            var assembly = Assembly.GetExecutingAssembly();

            using var stream = assembly.GetManifestResourceStream(resourceName);
            if (stream == null)
                throw new Exception($"Font not found: {resourceName}");

            byte[] fontData = new byte[stream.Length];
            stream.Read(fontData, 0, (int)stream.Length);

            unsafe
            {
                fixed (byte* pFontData = fontData)
                {
                    pfc.AddMemoryFont((IntPtr)pFontData, fontData.Length);
                }
            }

            return pfc;
        }
    }

}
