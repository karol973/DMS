using MaterialSkin;
using MaterialSkin.Controls;

namespace DMS.Views.Shared
{
   internal static class MaterialTheme
   {
      public static void Apply(MaterialForm form)
      {
         MaterialSkinManager manager = MaterialSkinManager.Instance;

         manager.AddFormToManage(form);

         manager.Theme = MaterialSkinManager.Themes.LIGHT;

         manager.ColorScheme = new ColorScheme(
            Primary.Blue600,
            Primary.Blue700,
            Primary.Blue200,
            Accent.LightBlue200,
            TextShade.WHITE);
      }
   }
}
