using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVMCreater
{
    public partial class ToolForm : Form
    {
        public ToolForm()
        {
            InitializeComponent();
        }

      
        private void btnCreateScripts_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            string path="";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                path= folder.SelectedPath;

            }

            if (!string.IsNullOrEmpty(path))
            {
                if (!string.IsNullOrEmpty(tbMainVmName.Text))//主VM创建
                {
                    if (!string.IsNullOrEmpty(tbMainVmName.Text))
                        TempleHelper.GenCode(tbMainVmName.Text, path);
                }

                if (listViewGListVmName.Items.Count>0)
                {
                    
                }
                if (listBoxCommomVmName.Items.Count > 0)
                {

                }
            }
           
            Close();
        }
    
        private void btnCreateSingleVm_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            string path = "";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                path = folder.SelectedPath;

            }
            if (!string.IsNullOrEmpty(path) && !string.IsNullOrEmpty(textBoxVmScriptName.Text))
            {
                //if (!string.IsNullOrEmpty(textBoxVmScriptName.Text))
                //    TempleHelper.GenCode(textBoxVmScriptName.Text, path);
            }
            Close();

        }

        private void BtnAddGlistVmName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxGListVmName.Text)) return;
            var result = new List<object>();
            foreach (var item in listViewGListVmName.Items)
            {
                if (result.Contains(item))
                {
                    continue;
                }
                result.Add(item);
            }
            if (!result.Contains(textBoxGListVmName.Text))
            {
                result.Add(textBoxGListVmName.Text);
            }

            textBoxGListVmName.Text = "";
            InitGListData(result);
        }
      

        private void BtnRemoveGlistVmName_Click(object sender, EventArgs e)
        {
            if (listViewGListVmName.SelectedItem == null) return;
            var result = new List<object>();
            foreach (var item in listViewGListVmName.Items)
            {
                if (item!= listViewGListVmName.SelectedItem)
                {
                    result.Add(item);
                }
            }
            InitGListData(result);
        }
        private void InitGListData(List<object> dataObjects)
        {
            listViewGListVmName.Items.Clear();
            listViewGListVmName.Items.AddRange(dataObjects.ToArray());
        }
        private void InitListViewCommomVmName(List<object> dataObjects)
        {
            listBoxCommomVmName.Items.Clear();
            listBoxCommomVmName.Items.AddRange(dataObjects.ToArray());
        }
        
        private void BtnAddCommomVmName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCommomVmName.Text)) return;
            var result = new List<object>();
            foreach (var item in listBoxCommomVmName.Items)
            {
                if (result.Contains(item))
                {
                    continue;
                }
                result.Add(item);
            }
            if (!result.Contains(textBoxCommomVmName.Text))
            {
                result.Add(textBoxCommomVmName.Text);
            }

            textBoxCommomVmName.Text = "";
            InitListViewCommomVmName(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxCommomVmName.SelectedItem == null) return;
            var result = new List<object>();
            foreach (var item in listBoxCommomVmName.Items)
            {
                if (item != listBoxCommomVmName.SelectedItem)
                {
                    result.Add(item);
                }
            }
            InitListViewCommomVmName(result);
        }
    }
}
