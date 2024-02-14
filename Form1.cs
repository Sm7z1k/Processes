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

namespace Processes
{
    public partial class Form1 : Form
    {
        List<System.Diagnostics.Process> processesStorage;
        System.Diagnostics.Process process;
        public Form1()
        {
            InitializeComponent();
            processesStorage = new List<System.Diagnostics.Process>();
            rtbProcessName.Text = "notepad";
            AllignText();
            lvProcesses.Columns.Add("PID");
            lvProcesses.Columns.Add("Name");
            lvProcesses.Columns.Add("Base priority");
            lvProcesses.Columns.Add("Start time");
        }
        void InitProcess(System.Diagnostics.Process proc)
        {
            AllignText();
            proc.StartInfo = new System.Diagnostics.ProcessStartInfo(rtbProcessName.Text);
        }
        void AllignText()
        {
            rtbProcessName.SelectAll();
            rtbProcessName.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(lvProcesses.SelectedItems.Count == 1)
            {
                DeleteProcess(lvProcesses.SelectedItems[0].Index);                            
            }
            else if (lvProcesses.SelectedItems.Count > 1)
            {
                for(int i = lvProcesses.SelectedItems.Count - 1; i >= 0; i--)
                {
                    DeleteProcess(lvProcesses.SelectedItems[i].Index);
                }                
            }
            else if(processesStorage.Count > 0)
            {
                try
                {
                    //process = Process.GetProcessById(Convert.ToInt32(lvProcesses.Items[lvProcesses.Items.Count-1]));
                    DeleteProcess(processesStorage.Count - 1);
                    if (processesStorage.Count > 0)
                    {
                        this.TopMost = true;                        
                    }
                }
                catch (Exception ex)
                {
                    processesStorage.RemoveAt(processesStorage.Count - 1);
                }
            }
            UpdatelbCountProcess();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            InitProcess(process);
            process.Start();
            SaveProcess(process);
            UpdatelbCountProcess();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (processesStorage.Count > 0)
            {
                int i = processesStorage.Count;
                while (i > 0)
                {
                    try
                    {
                        i--;
                        DeleteProcess(i);
                    }
                    catch (Exception ex)
                    {
                        processesStorage.RemoveAt(i);
                    }
                }
            }
        }
        void Info(int proc)
        {
            lbProcessInfo.Text = "Process info:\n";            
            lbProcessInfo.Text += $"PID:            {processesStorage[proc].Id}\n";
            lbProcessInfo.Text += $"Base priority:  {processesStorage[proc].BasePriority}\n";
            lbProcessInfo.Text += $"Start time:     {processesStorage[proc].StartTime}\n";
            lbProcessInfo.Text += $"Total CPU time: {processesStorage[proc].TotalProcessorTime}\n";
            lbProcessInfo.Text += $"User CPU time:  {processesStorage[proc].UserProcessorTime}\n";
            lbProcessInfo.Text += $"SessionId:      {processesStorage[proc].SessionId}\n";
            lbProcessInfo.Text += $"Name:           {processesStorage[proc].ProcessName}\n";
            lbProcessInfo.Text += $"Affinity:       {processesStorage[proc].ProcessorAffinity}\n";
            lbProcessInfo.Text += $"Threads:        {processesStorage[proc].Threads.Count}\n";
        }
        string Info()
        {
            return lbProcessInfo.Text = "нет выбранного процесса";
        }
        void SaveProcess(System.Diagnostics.Process proc)
        {
            processesStorage.Add(proc);

            lvProcesses.Items.Add(proc.Id.ToString());
            lvProcesses.Items[lvProcesses.Items.Count - 1].SubItems.Add(proc.ProcessName);
            lvProcesses.Items[lvProcesses.Items.Count - 1].SubItems.Add(proc.BasePriority.ToString());
            lvProcesses.Items[lvProcesses.Items.Count - 1].SubItems.Add(proc.StartTime.ToString());
        }
        void DeleteProcess(int proc)
        {
            processesStorage[proc].CloseMainWindow();
            processesStorage[proc].Close();
            processesStorage.RemoveAt(proc);
            lvProcesses.Items.RemoveAt(proc);
        }
        void UpdatelbCountProcess()
        {
            lbCountProcesses.Text = $"{processesStorage.Count}";
        }

        private void lvProcesses_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvProcesses.SelectedItems.Count > 0) Info(lvProcesses.SelectedItems[0].Index);
            else lbProcessInfo.Text = Info();
        }
    }
}
