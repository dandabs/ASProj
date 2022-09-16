using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Utils
{
    public abstract class FontManager
    {
        public static PrivateFontCollection pfc = new PrivateFontCollection();

        public static void initialize()
        {
            // DA 16/9/22 FontAwesome Brands
            int _FABl = Properties.Resources.Font_Awesome_6_Brands_Regular_400.Length;
            byte[] _FABd = Properties.Resources.Font_Awesome_6_Brands_Regular_400;
            IntPtr _FABmd = Marshal.AllocCoTaskMem(_FABl);
            Marshal.Copy(_FABd, 0, _FABmd, _FABl);
            pfc.AddMemoryFont(_FABmd, _FABl);

            // DA 16/9/22 FontAwesome Regular
            int _FARl = Properties.Resources.Font_Awesome_6_Free_Regular_400.Length;
            byte[] _FARd = Properties.Resources.Font_Awesome_6_Free_Regular_400;
            IntPtr _FARmd = Marshal.AllocCoTaskMem(_FARl);
            Marshal.Copy(_FARd, 0, _FARmd, _FARl);
            pfc.AddMemoryFont(_FARmd, _FARl);

            // DA 16/9/22 FontAwesome Solid
            int _FASl = Properties.Resources.Font_Awesome_6_Free_Solid_400.Length;
            byte[] _FASd = Properties.Resources.Font_Awesome_6_Free_Solid_400;
            IntPtr _FASmd = Marshal.AllocCoTaskMem(_FASl);
            Marshal.Copy(_FASd, 0, _FASmd, _FASl);
            pfc.AddMemoryFont(_FASmd, _FASl);

            // DA 16/9/22 Manrope
            int _MRl = Properties.Resources.Manrope_VariableFont_wght.Length;
            byte[] _MRd = Properties.Resources.Manrope_VariableFont_wght;
            IntPtr _MRmd = Marshal.AllocCoTaskMem(_MRl);
            Marshal.Copy(_MRd, 0, _MRmd, _MRl);
            pfc.AddMemoryFont(_MRmd, _MRl);

            // DA 16/9/22 Pokémon
            int _PKMl = Properties.Resources.PokemonGb_RAeo.Length;
            byte[] _PKMd = Properties.Resources.PokemonGb_RAeo;
            IntPtr _PKMmd = Marshal.AllocCoTaskMem(_PKMl);
            Marshal.Copy(_PKMd, 0, _PKMmd, _PKMl);
            pfc.AddMemoryFont(_PKMmd, _PKMl);
        }
    }
}
