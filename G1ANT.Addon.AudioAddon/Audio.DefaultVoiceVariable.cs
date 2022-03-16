using System;
using G1ANT.Language;
using System.Speech.Synthesis;

namespace G1ANT.Addon.AudioAddon
{
    [Variable(Name = "defaultvoice", Tooltip = "Name of default voice for command speak from addon.audio")]
    public class DeafulVoiceVariable : Variable
    {
        private TextStructure value;
        public DeafulVoiceVariable(AbstractScripter scripter) : base(scripter)
        {
            var synth = new SpeechSynthesizer();
            value = new TextStructure(synth.Voice.Name);
        }

        public override Structure GetValue(string index = "")
        {
            return new TextStructure(value);
        }

        public override void SetValue(Structure value, string index = null)
        {
            this.value.Set(value, index);
        }
    }
}
