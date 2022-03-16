using G1ANT.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G1ANT.Addon.AudioAddon
{
    [Addon(Name = "AddonAudio", Tooltip = "Addon which allows robot manipulate audio")]
    [Copyright(Author = "G1ANT Robot Ltd", Copyright = "G1ANT Robot Ltd", Email = "hi@g1ant.com", Website = "www.g1ant.com")]
    [License(Type = "LGPL", ResourceName = "License.txt")]
    public class Addon : Language.Addon
    {

        public override void Check()
        {
            base.Check();
        }

        public override void LoadDlls()
        {
            base.LoadDlls();
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }
}