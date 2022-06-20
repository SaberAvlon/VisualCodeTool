using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCreater.VmBase
{
    //未确定列表绑定数据类前，可使用该类进行数据绑定
    public class ListBindStandardData
    {
        public string DataId;//用于比较
        public string DataName;//显示文字
        public string DataIconUrl;//显示的预览图
        public bool DataBool;//bool备用
        public int Index;//数字索引

        public ListBindStandardData()
        {

        }
    }
}
