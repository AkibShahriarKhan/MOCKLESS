using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Speech.Recognition;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;


namespace JJGSpeechRecognizer
{
    //This class simulates keystrokes from Keys Class
    static class KeyboardSend
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        private const int KEYEVENTF_EXTENDEDKEY = 1;
        private const int KEYEVENTF_KEYUP = 2;

        public static void KeyDown(Keys vKey)
        {
            keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY, 0);
        }

        public static void KeyUp(Keys vKey)
        {
            keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }
    }
    //Definition Ends

    class CommandLogic
    {
        private static List<string> subject = new List<string>();
        private static List<string> verb = new List<string>();
        private static List<string> preposition = new List<string>();
        private static List<string> _object = new List<string>();

        private int numb, numb2;
        private static Process curProg = new Process();
        public static String procName;
        public static List<String> pids = new List<string>();

        
        private static void fillSubject()
        {
            subject.Add("I");
            subject.Add("he");
            subject.Add("she");
            subject.Add("we");
            subject.Add("they");
            subject.Add("Mockless");
            subject.Add("Akib");
            subject.Add("Joy");
            subject.Add("Pro");
            subject.Add("Rahul");
            subject.Add("Sir");
        }
        private static void fillVerb()
        {
            verb.Add("eat");
            verb.Add("want");
            verb.Add("wants");
            verb.Add("Like");
            verb.Add("Likes");
        }
        private static void fillPreposition()
        {
            preposition.Add("to");
        }
        private static void fill_Object()
        {
            _object.Add("Rice");
            _object.Add("Fried Chicken");
            _object.Add("My computer");
        }
        

        internal static List<Choices> GetCommandChoices()
        {
            //testing voice elements - works as default
            List<string> voices = new List<string>();
            voices.Add("say hello");            //OK
            voices.Add("print my name");        //OK
            voices.Add("Goodbye");              //OK
            voices.Add("amar naam bolo");       //OK
            voices.Add("Mockless");             //OK
            voices.Add("vaat khaiso");          //OK
            voices.Add("tor naam ki");          //OK
            voices.Add("sob kotha bujis");      //Action doesnt work
            voices.Add("kemon aso");            //No action defined
            voices.Add("kemon aso");            //No action defined
            voices.Add("ekdom chup");           //No action defined
            voices.Add("tor baper naam ki");    //No action defined
            //mouse control
            voices.Add("mouse narao");
            voices.Add("down");
            voices.Add("up");
            voices.Add("right");
            voices.Add("left");
            voices.Add("majh khaane");
            voices.Add("click left");
            voices.Add("click right");
            //System
            voices.Add("sound baaraao");
            voices.Add("sound komaao");
            voices.Add("close koro");
            voices.Add("program switch koro");
            voices.Add("screenshot nao");
            voices.Add("windows menu open koro");
            //window tasks
            voices.Add("my computer open koro");
            voices.Add("go to");
            voices.Add("go right");
            voices.Add("go left");
            voices.Add("go up");
            voices.Add("go down");
            voices.Add("enter");
            voices.Add("back");
            voices.Add("copy");
            voices.Add("paste");
            voices.Add("Select all");
            voices.Add("my computer close koro");
            //chrome related
            voices.Add("face book login koro");
            voices.Add("you tube a jao to");
            voices.Add("google a jao to");
            voices.Add("vues a login koro");
            voices.Add("vues close koro");
            voices.Add("tab close koro");
            //calculator task
            voices.Add("calculator open koro");
            voices.Add("calculator close koro");
            voices.Add("jog koro");
            voices.Add("biyog koro");
            voices.Add("goon koro");
            voices.Add("vaag koro");
            voices.Add("folafol");
            voices.Add("pesao");
            voices.Add("clear koro");

            //Photo Viewer
            voices.Add("camera open koro");
            voices.Add("boro koro");
            voices.Add("soto koro");
            voices.Add("muse felo");
            voices.Add("tab dao");

            //number

            voices.Add("ak");
            voices.Add("dui");
            voices.Add("teen");
            voices.Add("char");
            voices.Add("paach");
            voices.Add("soy");
            voices.Add("shaat");
            voices.Add("aat");
            voices.Add("shunno");
           





            Choices voicesChoice = new Choices(voices.ToArray());

            
            fillSubject();
            Choices subjectChoice = new Choices(subject.ToArray());
            fillVerb();
            Choices verbChoice = new Choices(verb.ToArray());
            fillPreposition();
            Choices prepositionChoice = new Choices(preposition.ToArray());
            fill_Object();
            Choices _objectChoice = new Choices(_object.ToArray());
            
            List<Choices> choiceList = new List<Choices>();
            
            choiceList.Add(subjectChoice);
            choiceList.Add(verbChoice);
            choiceList.Add(prepositionChoice);
            choiceList.Add(_objectChoice);
            choiceList.Add(voicesChoice);

            return choiceList;
        }

        public static void Do(SpeechRecognizedEventArgs e, SpeechGUI gui)
        {
            //this function is equivalent to Akib.ProjectWork.response._recognizeSpeechAndMakeSureTheComputerSpeaksToYou_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
            int mouseX = 32000;
            int mouseY = 32000;
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            switch (e.Result.Text)
            {
                //test commands
                case "say hello":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    speechSynthesizer.Speak("Hello!");
                    break;

                case "print my name":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    speechSynthesizer.Speak("Mockless");
                    break;

                case "Goodbye":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    speechSynthesizer.Speak("Goodbye");
                    break;

                case "amar naam bolo":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    speechSynthesizer.Speak(" AKEEEB SHAHRIAR KHAN");
                    
                    break;

                case "Mockless":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    speechSynthesizer.Speak("bolan sir");
                    Thread.Sleep(500);
                    speechSynthesizer.Dispose();
                    break;

                case "vaat khaiso":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    speechSynthesizer.Speak(" ami vaat khai naa");
                    Thread.Sleep(500);
                    speechSynthesizer.Dispose();
                    break;

                case "tor naam ki":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    speechSynthesizer.Speak("umaar naam Mockless, ami baanglaa bollta paari.");
                    Thread.Sleep(500);
                    speechSynthesizer.Dispose();
                    break;

                case "Sob kotha bujis":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    speechSynthesizer.Speak("bujhi");//doesnt work
                    break;

                //Mouse Movement
                case "mouse narao":
                    MouseControl.MoveTo(mouseX, mouseY);
                    break;

                case "down":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    mouseY = mouseY + 5000;
                    MouseControl.MoveTo(mouseX, mouseY);
                    break;

                case "up":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    mouseY = mouseY - 5000;
                    MouseControl.MoveTo(mouseX, mouseY);
                    break;

                case "left":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    mouseX = mouseX - 5000;
                    MouseControl.MoveTo(mouseX, mouseY);
                    break;

                case "right":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    mouseX = mouseX + 5000;
                    MouseControl.MoveTo(mouseX, mouseY);
                    break;

                case "majh khaane":
                    MouseControl.MoveTo(35000, 35000);
                    break;

                case "click left":
                    MouseControl.LeftClick();
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    speechSynthesizer.Speak("LEFT BUTTON CLICKED");
                    break;

                case "click right":
                    MouseControl.RightClick();
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    speechSynthesizer.Speak("RIGHT BUTTON CLICKED");
                    break;
                
                //Calculator Commands
                case "calculator open koro":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    curProg = System.Diagnostics.Process.Start("calc"); //"calc" process started and the process is referred by curProg

                    if (!pids.Contains("calc")) { pids.Add(curProg.ProcessName); }
                    //gui.LBLSpeechTextOut.Text = curProg.ProcessName;
                    // pids has the string element "calc"
                    speechSynthesizer.Speak("calculator open koresi");
                    
                    break;

                case "jog koro":
                    speechSynthesizer.Speak("calculator a zog kortesi");
                    SendKeys.Send("{ADD}");
                    /// Thread.Sleep(500);
                    break;

                case "biyog koro":
                    SendKeys.Send("{SUBTRACT}");
                    Thread.Sleep(500);
                    break;
                case "goon koro":

                    SendKeys.Send("{MULTIPLY}");
                    Thread.Sleep(500);
                    break;
                case "vaag koro":

                    SendKeys.Send("{DIVIDE}");
                    Thread.Sleep(500);
                    break;

                case "ek":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                     SendKeys.Send("{1}");
                    break;

                case "dui":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;

                    SendKeys.Send("{2}");

                    break;
                case "teen":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;

                    SendKeys.Send("{3}");

                    break;
                case "chaar":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;

                    SendKeys.Send("{4}");

                    break;
                case "pach":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;

                    SendKeys.Send("{5}");

                    break;

                case "soy":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{6}");
                    break;

                case "shaat":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{7}");
                    break;

                case "aat":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{8}");
                    break;

                case "noy":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{9}");
                    break;

                case "shunno":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{0}");
                    break;

                case "folafol":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{ENTER}");
                    break;

                case "pesao":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{BS}");
                    break;

                case "clear koro":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{ESC}");
                    break;

                case "calculator close koro":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    
                    if (pids.Contains("calc"))
                    {
                        KillProcessAndChildren("Calculator"); //"Calculator" is the process name found from task manager. 
                                                              //"calc" process name didnt exist. Using "calc" in this case, will return empty array from GetProcessByName() 
                                                              //and in turn will cause an index out of bound error 
                                                              //Additional Info: unlike Explorer, calculator creates ONE and ONLY ONE process for new calculator instance(s) as a result, 
                                                              //TempProc[TempProc.Length-1].kill() will close all the instance at once.
                        pids.Remove("calc");
                        speechSynthesizer.Speak("calculator close koresi");
                        Thread.Sleep(500);
                    }
                    else
                    {
                        speechSynthesizer.Speak("The Process is not running.");
                        Thread.Sleep(500);
                    }
                    break;

                //Windows Explorer
                case "my computer open koro":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;

                    //System.Diagnostics.Process.Start("iexplore.exe", "::{20d04fe0-3aea-1069-a2d8-08002b30309d}"); //File Explorer opened
                    curProg = System.Diagnostics.Process.Start("explorer", "::{20d04fe0-3aea-1069-a2d8-08002b30309d}"); //File Explorer opened and referred by curProg
                    procName = "explorer";
                    pids.Add(procName); //pids has "calc", "explorer"
                    Thread.Sleep(500);
                    speechSynthesizer.Speak("my computer open koresi");
                    speechSynthesizer.Dispose();
                    break;

                case "go right":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{RIGHT}");
                    break;

                case "go left":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{LEFT}");
                    break;

                case "go up":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{UP}");
                    break;

                case "go down":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{DOWN}");
                    break;

                case "enter":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{ENTER}");
                    break;

                case "back":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{BS}");
                    break;

                case "copy":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("^c");
                    break;

                case "paste":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("^v");
                    break;
                    
                case "sob nir ba chon karo":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("^a");
                    break;

                case "refresh koro":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    KeyboardSend.KeyDown(Keys.F5);
                    KeyboardSend.KeyUp(Keys.F5);
                    break;

                case "desktop dekhao":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    KeyboardSend.KeyDown(Keys.LWin);
                    KeyboardSend.KeyDown(Keys.D);
                    KeyboardSend.KeyUp(Keys.LWin);
                    KeyboardSend.KeyUp(Keys.D);
                    break;

                case "niche scroll koro":

                    SendKeys.Send("{DOWN} 10");
                    break;

                case "upore scroll koro":

                    SendKeys.Send("{UP} 10");
                    break;

                case "screenshot nao":
                    PrintScreen();
                    break;

                case "my computer close koro":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;

                    if (procName != null)
                    {
                        KillProcessAndChildren(procName);

                        speechSynthesizer.Speak("my computer close koresi");
                        Thread.Sleep(500);
                    }
                    else
                    {
                        speechSynthesizer.Speak("The Process is not running.");
                        Thread.Sleep(500);
                    }
                    break;

                //alt-F4
                case "close koro":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("%{F4}");
                    speechSynthesizer.Speak("close korsi");

                    break;

                //Browser control
                case "tab close koro":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("^{F4}");
                    speechSynthesizer.Speak("Tab close koresi");
                    break;

                case "program switch koro":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    speechSynthesizer.Speak("program switch korsi");
                    KeyboardSend.KeyDown(Keys.RWin);
                    KeyboardSend.KeyDown(Keys.Tab);
                    KeyboardSend.KeyUp(Keys.RWin);
                    KeyboardSend.KeyUp(Keys.Tab);
                    break;

                //Chrome Related    
                case "face book login koro":
                    System.Diagnostics.Process.Start("https://www.facebook.com/");
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    speechSynthesizer.Speak("facebook a login koresi");
                    break;

                case "you tube a jao to":
                    System.Diagnostics.Process.Start("https://www.youtube.com/");
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    speechSynthesizer.Speak("youtube open koresi");
                    break;

                case "google a jao to":
                    System.Diagnostics.Process.Start("https://www.google.com.bd/");
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    speechSynthesizer.Speak("google open koresi");
                    break;

                case "vues a login koro":
                    curProg = System.Diagnostics.Process.Start("https://portal.aiub.edu/");
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    speechSynthesizer.Speak("V U E S portal open koresi");
                    speechSynthesizer.Speak("login korun please");
                    break;

                case "vues close koro":

                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    Process TempProc = Process.GetProcessById(Convert.ToInt32(curProg.Id.ToString()));
                    TempProc.CloseMainWindow();
                    TempProc.WaitForExit();
                    speechSynthesizer.Speak("VUES close koresi");
                    break;
                    
                case "sound baaraao":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    ExecuteCommand("C:/nircmd.exe changesysvolume +8000");
                    break;

                case "sound komaao":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    ExecuteCommand("C:/nircmd.exe changesysvolume -8000");
                    break;

                case "soto koro": //zoom out
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    KeyboardSend.KeyDown(Keys.ControlKey);
                    SendKeys.Send("{SUBTRACT}");
                    KeyboardSend.KeyUp(Keys.ControlKey);
                    break;
                //Camera Related
                //case "camera open koro":
                //    gui.LBLSpeechTextOut.Text = e.Result.Text;
                //    curProg = Process.Start("Camera.exe");
                //    pids.Add(curProg.ProcessName);
                //    Camera camera = new Camera();
                //    speechSynthesizer.Speak("camera open koresi");
                //    break;
                case "boro koro": //zoom in
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    KeyboardSend.KeyDown(Keys.ControlKey);
                    SendKeys.Send("{ADD}");
                    KeyboardSend.KeyUp(Keys.ControlKey);
                    break;

                case "muse felo":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{DEL}");
                    break;

                case "tab dao":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("{TAB}");
                    break;

                case "windows menu open koro":
                    gui.LBLSpeechTextOut.Text = e.Result.Text;
                    SendKeys.Send("^{ESC}");
                    break;
            }   
        }
               
        public static void ExecuteCommand(string Command)
        {
            System.Diagnostics.ProcessStartInfo procStartInfo =
             new System.Diagnostics.ProcessStartInfo("cmd", "/c " + Command);

            // The following commands are needed to redirect the standard output.
            // This means that it will be redirected to the Process.StandardOutput StreamReader.
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            // Do not create the black window  .
            procStartInfo.CreateNoWindow = true;
            // Now we create a process, assign its ProcessStartInfo and start it
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            proc.Close();
        }
        //Closing Funtion
        private static void KillProcessAndChildren(String PName)
        {
            Process[] TempProc = Process.GetProcessesByName(PName);
            int x = TempProc.Length - 1;
            TempProc[x].Kill(); //kills the last "explorer" process
            /*
            foreach (Process p in TempProc)//kills all the "explorer" processes
            {
                p.Kill();
                pids.Remove(Pname);
            }
            */
        }
        //ends

        //Printing Screen
        static void PrintScreen()
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Bitmap sshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics gg = Graphics.FromImage(sshot as Image);
            gg.CopyFromScreen(0, 0, 0, 0, sshot.Size);
            sshot.Save(@"C:\MocklessShots\ss.jpg", ImageFormat.Jpeg);

            //screentest
        }
    }
}
