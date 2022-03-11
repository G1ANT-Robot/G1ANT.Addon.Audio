using System;
using G1ANT.Language;
using System.Speech.Synthesis;
using System.Collections.Generic;

namespace G1ANT.Addon.AudioAddon
{
    [Variable(Name = "installedvoices", Tooltip = "List of installed voices on machine")]
    public class InstalledVoicesVariable : Variable
    {
        public InstalledVoicesVariable(AbstractScripter scripter) : base(scripter)
        {
        }

        public override Structure GetValue(string index = "")
        {
            List<object> installedVoices = new List<object>();
            var synth = new SpeechSynthesizer();
            foreach (var voice in synth.GetInstalledVoices())
                installedVoices.Add(voice.VoiceInfo.Name);
            return new ListStructure(installedVoices, scripter:Scripter);
        }

        public override void SetValue(Structure value, string index = null)
        {
            throw new NotSupportedException($"This variable is read only and its Set method should never be called");
        }
    }
}