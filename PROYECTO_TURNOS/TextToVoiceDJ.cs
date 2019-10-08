using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Speech.Synthesis;
using System.Threading;

namespace Texto_a_Voz
{
    public class TextToVoiceDJ
    {
        public void EjecutarTextToVoice(object TextoPresent)
        {
            //Agregar la referencia System.Speech
            Thread Tarea = new Thread(new ParameterizedThreadStart(ConverTextToVoice));
            Tarea.Start(TextoPresent);
        }

        public void ConverTextToVoice(object texto)
        {
            //--.Turno, numero JV, 001, pasar a la clinica del doctor, Jorge Vásquez
            SpeechSynthesizer voz = new SpeechSynthesizer();
            
            voz.Rate = 1;
            voz.SetOutputToDefaultAudioDevice();
            voz.Speak(texto.ToString());
        }
    }
}