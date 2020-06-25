using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
namespace Speech_Recognition
{
    public partial class Jarvis : Form
    {
        public static string Classifier;
        SpeechRecognitionEngine speechreco = new SpeechRecognitionEngine();
        SpeechSynthesizer jarvis = new SpeechSynthesizer();
       

        public Jarvis()
        {
      
                speechreco.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(speechreco_speechRecognized);
                LoadGrammar();
                speechreco.SetInputToDefaultAudioDevice();
                speechreco.RecognizeAsync(RecognizeMode.Multiple);
                InitializeComponent();
     
        }

        private void LoadGrammar()
        {

            Choices texts = new Choices();
            string[] lines = File.ReadAllLines(Environment.CurrentDirectory + "\\command.txt");
            texts.Add(lines);
            Grammar wordlist = new Grammar(new GrammarBuilder(texts));
            speechreco.LoadGrammar(wordlist);
            

        }

        private void speechreco_speechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            richTextBox1.Text = e.Result.Text;
            string speech = e.Result.Text;
            switch(speech)
            {
                case "jarvis":
                    jarvis.Speak("yes sir");
                    break;
                case "hello":
                    jarvis.Speak("hello sir");
                    break;
                case "how are you":
                    jarvis.Speak("I am fine thank you");
                    break;
                case "goodmorning":
                    jarvis.Speak("good morning sir");
                    break;
                case "take a screenshot":
                    jarvis.Speak("screenshot will be taken in twenty seconds");
                    ExecuteCommand("C:/nircmd.exe cmdwait 20000 savescreenshot E:/shot.png");
                    jarvis.Speak("screenshot taken");
                    break;
                case "max":
                    jarvis.Speak("volume is at max now");
                    ExecuteCommand("C:/nircmd.exe setsysvolume 65535");
                    break;
                case "show information":
                    jarvis.Speak("here is today's schedule");
                    Info sc = new Info();
                    sc.Show();
                    break;
                case "log in":
                    this.Hide();
                    LogIn log = new LogIn();
                    log.Show();
                    break;
                case "check":
                    jarvis.Speak("here you can see available bus information");
                    Info info = new Info();
                    this.Visible = false;
                    info.ShowDialog();
                    break;
                case "reserve":
                    Seat_reservation seat1 = new Seat_reservation();
                    this.Visible = false;
                    jarvis.Speak("here you can book yorself a seat by filling all information");
                    seat1.ShowDialog();                    
                    break;
                case "book now":
                    Seat_reservation seat = new Seat_reservation();
                    this.Visible = false;
                    seat.ShowDialog();
                    break;





            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static void ExecuteCommand(string Command)
        {
            System.Diagnostics.ProcessStartInfo processStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd" , "/c" + Command);


            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;

            processStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = processStartInfo;
            proc.Start();
            proc.Close();

        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            Classifier = AdminBtn.Text;
            LogIn log = new LogIn();
            this.Visible = false;
            log.ShowDialog();
          
        }

        private void AccountantBtn_Click(object sender, EventArgs e)
        {
            Classifier = AccountantBtn.Text;
            LogIn log = new LogIn();
            this.Visible = false;
            log.ShowDialog();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Classifier = button2.Text;
            LogIn log = new LogIn();
            this.Visible = false;
            log.ShowDialog();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Classifier = button1.Text;
            LogIn log = new LogIn();
            this.Visible = false;
            log.ShowDialog();
        }
    }
}
