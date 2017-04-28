using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace JJGSpeechRecognizer
{
    class SpeechRecognizer
    {
        public event KeyPressEventHandler KeyPress;
        private static SpeechGUI gui;   
        internal static SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
        
        internal static void GrammarLoader(SpeechGUI x)
        {
            gui = x;
            
            Grammar grammar = new Grammar(MakeGrammarBuilder());
            recognizer.LoadGrammarAsync(grammar);
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
            recognizer.SpeechRecognitionRejected += Recognizer_SpeechRecognitionRejected;
        }
        private static GrammarBuilder MakeGrammarBuilder()
        {
            List<Choices> choiceList = CommandLogic.GetCommandChoices();
            GrammarBuilder gb = new GrammarBuilder(choiceList[0]);
            gb.Append(choiceList[1]);
            gb.Append(choiceList[2]);
            gb.Append(choiceList[3]);

            GrammarBuilder _default = new GrammarBuilder();
            _default.Append(choiceList[4]);

            //there is an unsolved issue regarding GrammarBuilder gb. The problem appears as if the gb is not constructed correctly.
            //Choices gb2 = new Choices(new GrammarBuilder[] { gb, _default });
            //return (GrammarBuilder)gb2;
            return _default;
        }
        internal static void Start()
        {
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }
        internal static void Stop()
        {
            recognizer.RecognizeAsyncStop();
        }
        private static void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            CommandLogic.Do(e, gui);
        }
        private static void Recognizer_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            gui.LBLSpeechTextOut.Text = string.Empty;
            foreach(RecognizedPhrase phrase in e.Result.Alternates)
            {
                gui.LBLSpeechTextOut.Text = gui.LBLSpeechTextOut.Text + phrase.Text;
                //new gui change
            }


        }        
    }
}
