using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MVVMCreater.ScriptsCreate
{

    public class TempleHelper
    {
        public static string ControlPath = @"/Temple/Control/###Control.txt";
        public static string ModelPath = @"/Temple/Model/###Model.txt";
        public static string ViewPath = @"/Temple/View/###Window.txt";
        public static string ViewEventPath = @"/Temple/View/###Event.txt";
        public static string ViewBindPath = @"/Temple/View/Bind/###WindowBind.txt";

        public static string ListBindPath = @"/Temple/View/Bind/ListBind/###Bind.txt";
        public static string ListItemBindPath = @"/Temple/View/Bind/ListBind/###ItemBind.txt";
        public static string ListViewModelPath = @"/Temple/ViewModel/ListViewModel/###ViewModel.txt";
        public static string ListItemViewModelPath = @"/Temple/ViewModel/ListViewModel/###ItemViewModel.txt";


        public static string ViewModelPath = @"/Temple/ViewModel/###ViewModel.txt";
        public static string HelperPath = @"/Temple/###Helper.txt";

        public string LoadJsonStrFromFile(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            return sr.ReadToEnd();
        }

        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="templeName"></param>
        /// <param name="createPath"></param>
        public static void GenCode(string templeName, string createPath)
        {
            string targetPath = createPath + "/";
            string directory = targetPath + templeName;
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            //Control
            GenCodeHandle(directory, templeName, ControlPath, "Control", "Control");
            //Model
            GenCodeHandle(directory, templeName, ModelPath, "Model", "Model");
            //View
            GenCodeHandle(directory, templeName, ViewPath, "View", "Window");

            //Bind
            GenCodeHandle(directory, templeName, ViewBindPath, "View/Bind", "Bind");
            //ViewModel
            GenCodeHandle(directory, templeName, ViewModelPath, "ViewModel", "ViewModel");
            //Helper
            //GenCodeHandle(directory, templeName, HelperPath, "", "Helper");
        }

        public static void GenListCode(string directory, string createName)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            //Bind
            GenCodeHandleV2(directory + "/View/Bind", createName, ListBindPath, "Bind");
            GenCodeHandleV2(directory + "/View/Bind", createName, ListItemBindPath, "ItemBind");
            //ViewModel
            GenCodeHandleV2(directory + "/ViewModel", createName, ListViewModelPath, "ViewModel");
            GenCodeHandleV2(directory + "/ViewModel", createName, ListItemViewModelPath, "ItemViewModel");

        }

        public static void GenSingleVmCode(string templeName, string createPath)
        {
            string TargetPath = createPath + "/";
            string directory = TargetPath + templeName;
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            GenCodeHandle(directory, templeName, ViewBindPath, "View/Bind", "Bind");
            //ViewModel
            GenCodeHandle(directory, templeName, ViewModelPath, "ViewModel", "ViewModel");
        }

        public static void GenGListVmCode(string templeName, string createPath)
        {

        }

        private static void GenCodeHandle(string directory, string templeName, string partPath, string partStr, string partName)
        {
            string dir = directory + $"/{partStr}";
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            string content = File.ReadAllText(System.Windows.Forms.Application.StartupPath + partPath);
            if (!string.IsNullOrEmpty(content))
            {
                content = content.Replace("###", templeName);
                File.WriteAllText(dir + $"/{templeName}{partName}.cs", content);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="createName"></param>
        /// <param name="demoPath"></param>
        /// <param name="scriptEnd"></param>
        private static void GenCodeHandleV2(string directory, string createName, string demoPath, string scriptEnd)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            string content = File.ReadAllText(System.Windows.Forms.Application.StartupPath + demoPath);
            if (!string.IsNullOrEmpty(content))
            {
                content = content.Replace("###", createName);
                File.WriteAllText(directory + $"/{createName}{scriptEnd}.cs", content);
            }
        }

        public static void OpenFiles()
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = false,
                Title = "打开一个文件夹",
                Filter = "所有文件(*.*)|*.*"
            };
            // = "打开一个文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(dialog.FileName))
                {
                    var selectName = dialog.SafeFileName;
                    var scriptReplace = selectName.Replace(".cs", "");
                    string content = File.ReadAllText(dialog.FileName);
                    if (!string.IsNullOrEmpty(content))
                    {
                        var lines = content.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var line in lines)
                        {
                            if (line.Contains("public"))
                            {

                                //主界面Vm bind
                                if (line.Contains("SkinBtn") || line.Contains("GButton"))//主界面-->绑定在主界面上的->按钮
                                {

                                }
                                else if (line.Contains("GTextField"))//主界面-->绑定在主界面上的->文本
                                {

                                }
                                else if (line.Contains("Controller"))//主界面-->绑定在主界面上的->控制器---自动生成代码不建议用控制器
                                {

                                }
                                //其它Vm bind
                                else if (line.Contains("Skin") && !line.Contains(content))//其它CS--》其他导出的组件绑定
                                {

                                }
                                else if (line.Contains("GComponent"))//其它CS--》内部文本按钮考虑+++直接绑定现实隐藏
                                {

                                }
                                else if (line.Contains("Skin") && !line.Contains(content))//其它CS--》其他导出的组件绑定
                                {

                                }
                                else if (line.Contains("GList"))//其它CS--》Glist的绑定代码
                                {

                                }
                            }
                        }
                    }
                }
            }

        }
    }
}