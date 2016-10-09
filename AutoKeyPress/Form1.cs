using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace AutoKeyPress
{
    public partial class Form1 : Form
    {
        WindowsInputController keyspammer = new WindowsInputController();
        public Form1()
        {
            InitializeComponent();
          //  button1.Location = new Point(10, 10);

           // button1.TabIndex = 0;

         //   button1.Text = "Click to automate Calculator";

          //  button1.AutoSize = true;

            this.Controls.Add(button1);
        }



        private void button1_Click(object sender, EventArgs e)

        {

            // Get a handle to the Calculator application. The window class

            // and window name were obtained using the Spy++ tool.

            // IntPtr calculatorHandle = FindWindow("CalcFrame", "Calculator");

            //IntPtr calculatorHandle = FindWindow("Notepad++", @"C:\Users\mberryhill\Desktop\test.txt - Notepad++");

            //// Verify that Calculator is a running process.

            //if (calculatorHandle == IntPtr.Zero)

            //{

            //    calculatorHandle = FindWindow("Notepad++", @"*C:\Users\mberryhill\Desktop\test.txt - Notepad++");

            //}

            //IntPtr calculatorHandle = FindWindow(@"#32770 (Dialog)", @"Chat");

            //if (calculatorHandle == IntPtr.Zero)

            //{

            //    MessageBox.Show("Calculator is not running.");

            //    return;

            //}

            // Make Calculator the foreground application and send it 

            // a set of calculations.


            //   SendKeys.SendWait("I Can now have my program send input signals to another!\n");
            //    IntPtr test= (IntPtr)0x00050D70;
            //SetForegroundWindow(test);
            //while(true){  

                
            ////SendKeys.SendWait("HI");
            ////SendKeys.SendWait("{ENTER}");
            //SendKeys.SendWait("E");
            //System.Threading.Thread.Sleep(700);
            //}
            //SendKeys.SendWait("111");

            //SendKeys.SendWait("*");

            //SendKeys.SendWait("11");

            //SendKeys.SendWait("=");


            IntPtr thisApp = keyspammer.GetForegroundWindowPtr(); //this will have to be in the forground when the user presses the button.

            IntPtr targetApp = thisApp; //by default we have the current window.

            if (thisApp != null)
            {
                //set the target app, which we will send the data to. we will stop as soon as the user changes the window.
              
                while(targetApp == thisApp){
                    targetApp = keyspammer.GetForegroundWindowPtr();
                    System.Threading.Thread.Sleep(500);
                }

                //Now spam the target app window
                while (true)
                {
                    var currentApplication = keyspammer.GetForegroundWindowPtr();

                    if (currentApplication== null || currentApplication != targetApp)
                    {
                        break;
                    }
                    
                    SendKeys.SendWait(txtSpamBtn.Text);
                    System.Threading.Thread.Sleep(Convert.ToInt32(txtbxTimeSpam.Text));
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)

        {

            Process[] processlist = Process.GetProcesses();

            foreach (Process process in processlist)

            {

                if (!String.IsNullOrEmpty(process.MainWindowTitle))

                {

                    Console.WriteLine("Process: {0} ID: {1} Window title: {2} PRIOTIYCLASS: {3}", process.ProcessName, process.Id, process.MainWindowTitle, process.PriorityClass);

                }

            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void txtSpamBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxTimeSpam_TextChanged(object sender, EventArgs e)
        {
            try{
                Convert.ToInt32(txtbxTimeSpam.Text);
            }catch
            {
                MessageBox.Show("You must enter a number in ms");
            }
        }
    }
}
