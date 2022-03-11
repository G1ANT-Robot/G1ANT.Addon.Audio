using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;
using System.Speech.Synthesis;

namespace G1ANT.Addon.AudioAddon
{   
    [Command(Name = "audio.speak", Tooltip = "Robot reads the given text")]
    class SpeakSayCommand : Command
    {

        public SpeakSayCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public class Arguments : CommandArguments
        {
            [Argument(Name = "Text", Required = true, Tooltip = "Text to read")]
            public TextStructure Text { get; set; }

            [Argument(Name = "Volume", Required = false, Tooltip = "Volume from 0 too 100")]
            public IntegerStructure Volume { get; set; } = new IntegerStructure(100);

            [Argument(Name = "Rate", Required = false, Tooltip = "How fast your text will be read")]
            public IntegerStructure Rate { get; set; } = new IntegerStructure(1);

            [Argument(Name = "VoiceName",DefaultVariable = "defaultvoice", Required = false, Tooltip = "Select name of the voice. For example Microsoft David Desktop")]
            public TextStructure VoiceName { get; set; }

        }

        public void Execute(Arguments arguments)
        {       
            var synth = new SpeechSynthesizer();
            synth.Volume = arguments.Volume.Value;
            synth.Rate = arguments.Rate.Value;
            if (!string.IsNullOrEmpty(arguments.VoiceName?.Value)) 
                synth.SelectVoice(arguments.VoiceName.Value);
            synth.Speak(arguments.Text.Value);
        }
    }

}
