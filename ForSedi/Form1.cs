using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForSedi
{
    public partial class Form1 : Form
    {
        List<string> ss_File;
        List<string[]> FileData;
        List<string> SelectTask;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            usSelectFile_CT.cbEvent += UpdateList;
            usSelectFile_CT.DefaltIncludeText("stsCT2_");
            SelectTask = new List<string>();
            FileData = new List<string[]>();
            ss_File = new List<string>();
        }

        void UpdateList()
        {
            ReadFile_csv(usSelectFile_CT.File[0]);

            ckbList_TaskItem.Items.Clear();
            foreach(string s in ss_File)
            {
                ckbList_TaskItem.Items.Add(s, false);
            }

        }


        public void ReadFile_csv(string fn)
        {
            ss_File.Clear();
            string[] ss;
            string s;
            StreamReader srL = new StreamReader(fn);

            while (!srL.EndOfStream)
            {
                s = srL.ReadLine().Replace(" ", "");
                if (s != "")
                {
                    ss = s.Split(',');

                    if (!ss_File.Contains(ss[1])) { ss_File.Add(ss[1]); }

                }
            }
            srL.Close();
        }


        public Dictionary<string, int> InputData(string fn, List<string> list)
        {
            Dictionary<string, int> Data = new Dictionary<string, int>();
            //Dictionary<string, List<int>> dc = new Dictionary<string, List<int>>();
            foreach (string s1 in list)
            {
                //dc.Add(s1, new List<int>());
                Data.Add(s1, 0);
            }

            string[] ss;
            string s;
            StreamReader srL = new StreamReader(fn);
            bool isFirst = true;
            int LastOne = 0;
            int Now = 0;
            while (!srL.EndOfStream)
            {
                s = srL.ReadLine().Replace(" ", "");
                if (s != "")
                {
                    ss = s.Split(',');

                    if (Data.ContainsKey(ss[1]))
                    {
                        if (isFirst)
                            Now = int.Parse(ss[3]) - 0;
                        else
                            Now = int.Parse(ss[3]) - LastOne;

                        //dc[ss[1]].Add(Now);
                        Data[ss[1]] += Now;
                    }
                    LastOne = int.Parse(ss[3]);
                }
                isFirst = false;
                
            }
            srL.Close();


            return Data;
        }
        private void ckbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSelectAll.Checked)
            {
                for (int j = 0; j < ckbList_TaskItem.Items.Count; j++)
                    ckbList_TaskItem.SetItemChecked(j, true);
            }
            else
            {
                for (int j = 0; j < ckbList_TaskItem.Items.Count; j++)
                    ckbList_TaskItem.SetItemChecked(j, false);
            }
            Select();
        }

        private void btnTaskCalStart_Click(object sender, EventArgs e)
        {
            dgTaskTime.Columns.Clear();
            dgTaskTime.Rows.Clear();

            dgTaskTime.Columns.Add("SER", "SER");
            dgTaskTime.Columns.Add("Total", "Total");
            for (int i = 0; i < SelectTask.Count; i++)
            {
                dgTaskTime.Columns.Add(SelectTask[i], SelectTask[i]);
            }


            int Total;
            for(int i = 0; i < usSelectFile_CT.File.Count; i++)
            {
                Dictionary<string, int> Data = new Dictionary<string, int>(InputData(usSelectFile_CT.File[i], SelectTask));
                dgTaskTime.Rows.Add();
                Total = 0;
                dgTaskTime.Rows[i].Cells["SER"].Value = Path.GetFileNameWithoutExtension(usSelectFile_CT.File[i]).Substring(7,4);
                foreach (KeyValuePair<string, int> dc in Data)
                {
                    dgTaskTime.Rows[i].Cells[dc.Key].Value = dc.Value.ToString();
                    Total += dc.Value;
                }
                dgTaskTime.Rows[i].Cells["Total"].Value = Total.ToString();
            }








        }

        private void ckbList_TaskItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select();
        }

        void Select()
        {
            SelectTask.Clear();
            for (int i = 0; i < ckbList_TaskItem.Items.Count; i++)
            {
                if (ckbList_TaskItem.GetItemChecked(i))
                {
                    SelectTask.Add(ckbList_TaskItem.Items[i].ToString());
                }
            }
        }
    }
}
