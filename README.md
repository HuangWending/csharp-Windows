# csharp-Windows
C#创建窗口
using System;：导入System命名空间，其中包含了常用的C#类型和功能。
using System.Windows.Forms;：导入System.Windows.Forms命名空间，其中包含了用于创建Windows窗口的类和控件。
namespace MyApplication：定义一个名为MyApplication的命名空间。
public class MyWindow : Form：定义一个名为MyWindow的公共类，继承自Form类，表示一个窗口。
public MyWindow()：构造函数，用于初始化窗口的属性和控件。
Text = "黄文定的窗口";：设置窗口的标题为"黄文定的窗口"。
Size = new System.Drawing.Size(400, 300);：设置窗口的大小为宽度400像素，高度300像素。
Label label = new Label();：创建一个Label标签控件的实例。
label.Text = "Hello, HuangWending!";：设置标签控件显示的文本为"Hello, HuangWending!"。
Controls.Add(label);：将标签控件添加到窗口中的控件集合中。
static void Main()：程序的入口点。
Application.Run(new MyWindow());：创建窗口实例并运行应用程序。
创建一个标题为"黄文定的窗口"、大小为400x300像素的窗口，并在窗口中显示一个标签控件，文本为"Hello, HuangWending!"。
