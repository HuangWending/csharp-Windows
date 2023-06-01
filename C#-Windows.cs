using System;
using System.Windows.Forms;

namespace MyApplication
{
    public class MyWindow : Form
    {
        public MyWindow()
        {
            // 设置窗口标题
            Text = "黄文定的窗口";

            // 设置窗口大小
            Size = new System.Drawing.Size(400, 300);

            // 创建标签控件
            Label label = new Label();
            label.Text = "Hello, HuangWending!";

            // 将标签控件添加到窗口中
            Controls.Add(label);
        }

        static void Main()
        {
            // 创建窗口实例
            Application.Run(new MyWindow());
        }
    }
}
