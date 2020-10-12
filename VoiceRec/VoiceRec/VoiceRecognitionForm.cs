using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;

namespace VoiceRec
{
    public partial class VoiceRecognitionForm : Form
    {
        private SpeechRecognitionEngine RecEng;
        private GrammarBuilder             GrB;
        private Grammar                      G;
        private Dictionary<String, String>   D;
        private Choices               Commands;
        private SpeechSynthesizer        Synth;

        public VoiceRecognitionForm()
        {
            InitializeComponent();
            Init();
        }   // Constructor

        private void Init()
        {
            // Start with disabling some features.
            Disable.Enabled = false;
            Question.Enabled = false;
            Answer.Enabled = false;

            // Create an instance of a SpeechRecognitionEngine.
            RecEng = new SpeechRecognitionEngine();

            // Create an instance of a Dictionary of Strings, which will hold Tuples -> <Quest, Ans>.
            D = new Dictionary<String, String>();

            // Read all the Ans-Quest from the Grammar.
            string[] Lines = System.IO.File.ReadAllLines("Grammar.txt");

            // Create an instance of Choices and fill The Choice set with commands
            Commands = new Choices();
            for (int i = 0; i < Lines.Length; i++)
            {
                string[] Tokens = Lines[i].Split('\t');
                if (Tokens[0] != "")
                {
                    Commands.Add(Tokens[0]); // Append the command.
                    D[Tokens[0]] = Tokens[1]; // insert <Quest, Ans>. to the Dictionary.
                }   // if
            }   // for

            // Create an instance of a grammar builder, and append the commands.
            GrB = new GrammarBuilder();
            GrB.Append(Commands);

            // Create a Grammar grom the GrammarBuilder.
            G = new Grammar(GrB);

            // Load The Grammar to the Engine Recognision.
            RecEng.LoadGrammarAsync(G);

            // Set The input Device to default.
            RecEng.SetInputToDefaultAudioDevice();

            // Create an instance of a SpeechSynthesizer.
            Synth = new SpeechSynthesizer();

            // Configure the audio output.   
            Synth.SetOutputToDefaultAudioDevice();

            // Handle a SpeechRecognized event.
            RecEng.SpeechRecognized += RecEng_SpeechRecognized;
        }   // Init

        private void RecEng_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            // Print The answer.
            if (TextRadio.Checked) TBox.Text += D[e.Result.Text] + '\n';
            else Synth.Speak(D[e.Result.Text]);
        }   // RecEng_SpeechRecognized event handler 

        private void Enable_Click(object sender, EventArgs e)
        {
            // Start listen and recognize.
            RecEng.RecognizeAsync(RecognizeMode.Multiple);

            // Switch buttons.
            Enable.Enabled = false;
            Disable.Enabled = true;
        }   // Enable_Click

        private void Disable_Click(object sender, EventArgs e)
        {
            // Stop listen and recognize.
            RecEng.RecognizeAsyncStop();

            // Switch buttons.
            Enable.Enabled = true;
            Disable.Enabled = false;
        }   // Disable_Click

        private void TrainButton_Click(object sender, EventArgs e)
        {
            Disable_Click(sender, e);
            if (TrainButton.Text.Equals("Train"))
            {
                Question.Enabled = true;
                Answer.Enabled = true;
                TrainButton.Text = "Submit";
                Enable.Enabled = false;
            }   // if
            else
            {
                if(!Question.Text.Equals("") 
                    && !Answer.Text.Equals(""))
                {
                    File.AppendAllText("Grammar.txt",
                        Question.Text + '\t' + Answer.Text + Environment.NewLine);
                    Init();
                }   // if

                Question.Enabled = false;
                Answer.Enabled = false;
                TrainButton.Text = "Train";
                Enable.Enabled = true;
            }   // else

            Question.Text = "Command";
            Answer.Text = "Answer";
        }   // TrainButton_Click
    }   // VoiceRecognitionForm
}   // VoiceRec
