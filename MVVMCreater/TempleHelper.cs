using System.IO;

namespace MVVMCreater
{
    public class TempleHelper
    {
        public static string TargetPath = "E:/ZHouseMobile/ZhiBenJia.ZHouse.Mobile/Views/";

        public static string ControlPath = @"E:/Temple/Control/###Control.txt";
        public static string ModelPath = @"E:/Temple/Model/###Model.txt";
        public static string ViewPath = @"E:/Temple/View/###Window.txt";
        public static string ViewEventPath = @"E:/Temple/View/###Event.txt";
        public static string ViewBindPath = @"E:/Temple/View/Bind/###WindowBind.txt";
        public static string ViewModelPath = @"E:/Temple/ViewModel/###ViewModel.txt";
        public static string HelperPath = @"E:/Temple/###Helper.txt";

        public string LoadJsonStrFromFile(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            return sr.ReadToEnd();
        }

        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="templeName"></param>
        public static void GenCode(string templeName)
        {
            string directory = TargetPath + templeName;
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            //Control
            GenCodeHandle(directory,templeName,ControlPath,"Control", "Control");
            //Model
            GenCodeHandle(directory, templeName, ModelPath, "Model", "Model");
            //View
            GenCodeHandle(directory, templeName, ViewPath, "View","Window");
            GenCodeHandle(directory, templeName, ViewEventPath, "View","Event");
            //Bind
            GenCodeHandle(directory, templeName, ViewBindPath, "View/Bind", "Bind");
            //ViewModel
            GenCodeHandle(directory, templeName, ViewModelPath, "ViewModel", "ViewModel");
            //Helper
            GenCodeHandle(directory, templeName, HelperPath, "", "Helper");
        }

        private static void GenCodeHandle(string directory, string templeName, string partPath,string partStr,string partName)
        {
            string dir = directory + $"/{partStr}";
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            string content = File.ReadAllText(partPath);
            if (!string.IsNullOrEmpty(content)) {
                content = content.Replace("###", templeName);
                File.WriteAllText(dir + $"/{templeName}{partName}.cs", content);
            }
        }
    }
}