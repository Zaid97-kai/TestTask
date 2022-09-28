using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask.Classes;

namespace TestTask
{
    public partial class Form1 : Form
    {
        public static int currentTime = 0;
        public static int setsFirstCount = 0;
        public static int setsSecondCount = 0;
        public static string currentText = "";
        public Queue<ServerTask> serverTasks;
        public Queue<Queue<ServerTask>> serverTasksQueue;
        public Form1()
        {
            InitializeComponent();
            serverTasks = new Queue<ServerTask>();
        }

        private void bnGenerate_Click(object sender, EventArgs e)
        {
            bool flag = false;
            int count = 0;
            currentText = tbInputData.Text;
            string[] sets = currentText.Split(new char[] { '\n', '\n' });
            for (int i = 0; i < sets.Length; i++)
            {
                if (i == 0)
                {
                    setsFirstCount = Convert.ToInt32(sets[0]);
                    flag = true;
                }
                else if (flag && !sets[i].Contains(" "))
                {
                    if (sets[i] == "")
                    {
                        continue;
                    }
                    else
                    {
                        setsSecondCount = Convert.ToInt32(sets[i]);
                        flag = false;
                    }
                }
                else if(!flag && !sets[i].Contains(" "))
                {
                    setsFirstCount = Convert.ToInt32(sets[i]);
                }
                else if (sets[i] == " ")
                {
                    continue;
                }
                else if (sets[i].Contains(" "))
                {
                    string[] tempSets = sets[i].Split(' ');

                    serverTasks.Enqueue(
                        new ServerTask() 
                        { 
                            first = Convert.ToInt32(tempSets[0]), 
                            second = Convert.ToInt32(tempSets[1]) 
                        });
                    count++;
                }
            }
        }
    }
}
