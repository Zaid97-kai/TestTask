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
        public List<Queue<ServerTask>> serverTasksQueue;
        public Form1()
        {
            InitializeComponent();
            tbInputData.Text = "3\n\n3\n2 2\n4 4\n6 6\n\n3\n3 3\n7 7\n6 6\n\n2\n2 2\n5 5";
            serverTasksQueue = new List<Queue<ServerTask>>();
        }

        private void bnGenerate_Click(object sender, EventArgs e)
        {
            bool flag = false;
            currentText = tbInputData.Text;
            string[] sets = currentText.Split(new char[] { '\n', '\n' });
            for (int i = 0; i < sets.Length; i++)
            {
                if (!flag)
                {
                    setsFirstCount = Convert.ToInt32(sets[0]);
                    flag = true;
                    continue;
                }
                else if (sets[i] == " ")
                {
                    continue;
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
                        serverTasksQueue.Add(new Queue<ServerTask>());
                        i++;
                    }
                }

                for (int j = 0; j < setsSecondCount; j++)
                {
                    if (sets[i + j].Contains(" "))
                    {
                        string[] tempSets = sets[i + j].Split(' ');

                        Queue<ServerTask> serverTasks = new Queue<ServerTask>();

                        ServerTask serverTask = new ServerTask()
                        {
                            first = Convert.ToInt32(tempSets[0]),
                            second = Convert.ToInt32(tempSets[1])
                        };

                        serverTasksQueue[serverTasksQueue.Count - 1].Enqueue(serverTask);
                    }
                    if(j == setsSecondCount - 1)
                    {
                        i += j;
                    }
                }
            }

            foreach (Queue<ServerTask> serverTaskQueue in serverTasksQueue)
            {
                foreach (ServerTask serverTask in serverTaskQueue)
                {
                    while (serverTask.first >= currentTime)
                    {
                        currentTime++;
                    }
                    currentTime += serverTask.second;
                }
            }
        }
    }
}
