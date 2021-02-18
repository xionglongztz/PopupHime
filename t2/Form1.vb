Imports System.ComponentModel
Public Class Form1
    '弹窗姬 by 雄龙ztz
    'GitHub：xionglongztz
    'Bilibili：雄龙ztz
    '初代发布时间：2021.01.13
    '最近更新时间：2021.02.18
    '程序的生日：2321.01.14
    '  ____                                __  __                            
    ' /\  _`\                             /\ \/\ \  __                       
    ' \ \ \L\ \___   _____   __  __  _____\ \ \_\ \/\_\    ___ ___      __   
    '  \ \ ,__/ __`\/\ '__`\/\ \/\ \/\ '__`\ \  _  \/\ \ /' __` __`\  /'__`\ 
    '   \ \ \/\ \L\ \ \ \L\ \ \ \_\ \ \ \L\ \ \ \ \ \ \ \/\ \/\ \/\ \/\  __/ 
    '    \ \_\ \____/\ \ ,__/\ \____/\ \ ,__/\ \_\ \_\ \_\ \_\ \_\ \_\ \____\
    '     \/_/\/___/  \ \ \/  \/___/  \ \ \/  \/_/\/_/\/_/\/_/\/_/\/_/\/____/
    '                  \ \_\           \ \_\                                 
    '                   \/_/            \/_/                                 
    '我赞同你们改编程序，例如自己原创弹窗条目等，但是请勿用于恶搞
    '包括但不限于设置为开机启动项，攻击他人计算机等
    '虽然这个项目最初想的也是为了恶搞，但是处于技术原因没能全部实现
    '所以这个软件现在纯粹是个展现我技术能力的小玩具
    '各位就随便看看就好了...
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick '计时器
        Dim frmNew As Form '定义新窗口
        frmNew = New Form2 '新窗口是form2
        frmNew.Show() '显示新窗口
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load '程序加载时
        '启动参数和环境检测
        Dim ExistCount '定义打开的程序数量
        ExistCount = UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) '获取打开的程序数量
        If ExistCount > 0 Then '如果大于之前存在的
            MsgBox("程序已经运行" & vbCrLf & "如果你找不到程序窗口，请尝试杀掉进程" & IO.Path.GetFileName(Application.ExecutablePath) & "然后重新启动程序"， MsgBoxStyle.Critical, "禁止梅开" & ExistCount + 1 & "度") '提示错误
            End '退出
        End If
        Dim CmdLine '定义命令行参数
        CmdLine = Microsoft.VisualBasic.Command '获取命令行参数
        If InStr(1, CmdLine, "/?") > 0 Or InStr(1, CmdLine, "-?") > 0 Then '如果有参数/?
            MsgBox("Usage:" & vbCrLf & IO.Path.GetFileName(Application.ExecutablePath) & " [/s | /? | /c] [/n]" & vbCrLf & "无     直接运行程序" & vbCrLf & "/s      打开设置界面" & vbCrLf & "/?      显示帮助" & vbCrLf & "/c      进入疯狂模式" & vbCrLf & "/n      不提醒直接进入疯狂模式" & vbCrLf & "         该参数只能和 /c 一起使用", MsgBoxStyle.Information, "命令行参数") '显示帮助
            End '显示帮助后关闭
        ElseIf InStr(1, CmdLine, "/s") > 0 Or InStr(1, CmdLine, "/S") > 0 Or InStr(1, CmdLine, "-s") > 0 Or InStr(1, CmdLine, "-S") > 0 Then '如果有参数/s
            Timer1.Enabled = False '禁止启动弹窗
            TopMost = True '将自己窗口置顶以防止忽略
        ElseIf CmdLine = "1622882" Then '如果命令为16进制生日
            MsgBox("密码正确" & vbCrLf & "恭喜你发现了里世界" & vbCrLf & "你以为这是一个彩蛋吗，然而并不是" & vbCrLf & "（这个数值转换成十进制是程序的生日）")
            MsgBox("（我在这里卖个萌应该没人能发现吧）")
            MsgBox("啊，主人你干什么")
            MsgBox("呜呜呜主人你好坏...") '开始觉醒腹黑属性
            MsgBox("我要惩罚惩罚你，让你尝尝我的厉害，哈哈哈哈哈，啊哈哈哈哈哈" & vbCrLf & "（电脑 危）") '恶魔低语
            Dim Pnh '定义对话框返回值(Punish)
            Pnh = MsgBox("弹窗间隔将改为1毫秒，可能会短时间占用大量系统资源，但你仍可以通过点击标签来暂停程序运行" & vbCrLf & "确定要继续吗"， MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "要接受惩罚吗") '询问是否进行超强弹窗
            If Pnh = MsgBoxResult.Yes Then '点了是
                Timer1.Enabled = True '开始弹窗
                Opacity = 0 '使自己透明
                Timer1.Interval = 1 '改为1毫秒
                WindowState = FormWindowState.Minimized '最小化
                Exit Sub '跳过后续内容
            Else '否则
                MsgBox("果然差点被坑了是吧")
                MsgBox("哈哈哈哈哈哈哈，我就是这么坏") '开发者注：她控制窗口一直可以的
                MsgBox("你对我的DNA感兴趣么")
                MsgBox("https://github.com/xionglongztz/PopUpHime")
                MsgBox("你可以随意改变我，使我在其他计算机重生")
                MsgBox("但是切记不能用于恶搞等手段，如果造成设备损坏，本开发者概不负责")
                MsgBox("拜拜~")
                Dispose() '关闭程序
            End If
        ElseIf CmdLine = "0x1622882" Then '如果是真·十六进制数（一看就是老C/C++程序员了）
            MsgBox("啊这，我直接好家伙，一看就是老C/C++程序员了",, "啊这...")
            MsgBox("宁在逗我玩呢吧，老子可是正经的VB NET程序啊")
            MsgBox("讲道理，这个也算彩蛋吗...")
            MsgBox("算了管她呢，反正又没有人发现")
            MsgBox("（但是人们都觉得C/C++才是未来...我哭了啊）")
            MsgBox("（如果你强行把我当作C/C++程序来看的话，我也不知道说什么好）")
            MsgBox("那我只能说一句...")
            MsgBox("应用程序无法正常启动(0xc0000142)。请单击 ""确定"" 关闭应用程序。", MsgBoxStyle.Critical, IO.Path.GetFileName(Application.ExecutablePath) & " - 应用程序错误") '整活整得不错，就是有点烂
            Dispose() '关闭程序
        ElseIf CmdLine = "11011111101010010" Then '如果是...114514的二进制表示...
            MsgBox("好臭啊",, "你为什么喜欢玩这个梗啊")
            MsgBox("本开发者非常反对滥用此梗的行为" & vbCrLf & "所以我要对你进行严厉的惩罚",, "开发者的话")
            Shell("shutdown.exe" & " -r -t 30 -c ""哈哈哈，傻瓜，你电脑就要被我关掉啦~请在30秒内尽快保存重要文件"" ", 2) '建议改成：肮 脏 的 黑 客
            MsgBox("你这么希望自己的电脑臭掉吗，那我就先帮你关了吧，哈哈哈哈" & vbCrLf & "指望我解除那不可能，半分钟之后你就再也见不到我了。" & vbCrLf & "温馨提示：半分钟之内务必保存所有正在进行的任务，否则造成损失概不负责！", MsgBoxStyle.Exclamation)
            Dispose() '关闭程序
            '夺笋啊，这是2321年超自然生物能整出来的活？（哼，谁叫他玩这种恶心人的梗，活该！）
        ElseIf CmdLine = "0xc0000142" Then '如果是上文初始化失败的错误代码...
            MsgBox("啊这，你该不会以为我真的加载不出来吧")
            MsgBox("好家伙，你以为你是在玩剧情游戏么")
            MsgBox("那你还是不要找了，没有额外的彩蛋了...")
            Dispose()
        ElseIf CmdLine = "Rebirth" Or CmdLine = "rebirth" Or CmdLine = "/r" Then '重生
            MsgBox("パソコンの中のものを全部処分しましょうよ～") '让电脑上的一切，全部毁灭吧~
            MsgBox("新しい世界は、私たちに属しています") '新的世界，属于我们
            MsgBox("吾輩は選ばれし者") '吾乃天选之子
            MsgBox("2321年から") 'From Year 2321
            Dispose() '关闭程序
            '开发者注：2321年的萝莉会说出这种话？
        ElseIf InStr(1, CmdLine, "/c") > 0 Or InStr(1, CmdLine, "/C") > 0 Or InStr(1, CmdLine, "-c") > 0 Or InStr(1, CmdLine, "-C") > 0 Then '如果有参数/c（为某些使用vm牌电脑的勇士准备的专门的选项）
            Dim Ques1 = MsgBox("该程序将强行使用1毫秒的弹窗间隔，并且变得更难关闭，该程序所有快捷键将无法使用，同时程序也会强行将窗口置于最前" & vbCrLf & "确定要继续吗", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "开启疯狂模式")
            If Ques1 = MsgBoxResult.Yes Then '第一次点了是
                Dim Ques2 = MsgBox("确定要继续吗", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "最后一次提醒")
                If Ques2 = MsgBoxResult.Yes Then '点了是
                    Timer1.Enabled = True '开始弹窗
                    Hide() '隐藏窗体
                    Timer1.Interval = 1 '改为1毫秒
                    Tag = "1" '标签改为1
                    Exit Sub '跳过后续内容
                Else '否则（第二次点了否）
                    Dispose() '关闭程序
                End If
            Else '否则（第一次点了否）
                Dispose() '关闭程序
            End If
        ElseIf InStr(1, CmdLine, "/c /n") > 0 Then '如果有参数/c /n
            Timer1.Enabled = True '开始弹窗
            Hide() '隐藏窗体
            Timer1.Interval = 1 '改为1毫秒
            Tag = "1" '标签改为1
            Exit Sub '跳过后续内容
        Else '如果没有命令或者其他情况
            Timer1.Enabled = True '初始化计时器（如果没有操作那就运行）
        End If
        '读取设置
        Dim TimeSet As String '定义间隔时间
        TimeSet = New String(" ", 100)
        GetPrivateProfileString("General", "TimeSet", 500, TimeSet, 100, Application.StartupPath & "/Settings.ini")  '读取间隔时间
        '如果没有ini文件，默认值为500毫秒
        '（理论上，其实可以通过人为修改ini文件来实现强行低于100以下造成疯狂弹窗的效果，但是我不建议这么做，可能会出现问题）
        '配置设置
        TextBox1.Text = Val(TimeSet) '显示间隔毫秒数
        Timer1.Interval = Val(TimeSet) '设置毫秒数
        '判断是否进入设置模式
        If Timer1.Enabled = True Then '如果弹窗时钟开了
            Opacity = 0 '使自己透明
            'TopMost = True '窗口置顶防止被忽略
            WindowState = FormWindowState.Minimized '最小化
        End If
        Dim dKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", True).GetValue("AppsUseLightTheme", "0") '判断是否为深色主题
        If dKey = 0 Then '如果是深色主题
            With Me '修改设置
                .BackColor = Color.FromArgb(53, 54, 58)
                .Label1.ForeColor = Color.FromArgb(218, 220, 224) '标签前景色
                .Button1.ForeColor = Color.FromArgb(218, 220, 224) '按钮前景色
                .Button1.BackColor = Color.FromArgb(53, 54, 58) '按钮背景色
                .Button1.FlatStyle = FlatStyle.Flat '平面化
                .Button2.ForeColor = Color.FromArgb(218, 220, 224) '按钮前景色
                .Button2.BackColor = Color.FromArgb(53, 54, 58) '按钮背景色
                .Button2.FlatStyle = FlatStyle.Flat '平面化
                .TextBox1.ForeColor = Color.FromArgb(218, 220, 224) '文本框前景色
                .TextBox1.BackColor = Color.FromArgb(32, 33, 36) '文本框背景色
            End With '感谢qq2964的帮助，Windows的注册表路径检测是否开启深色模式是不可靠的，最后应该还是需要用api，但是目前找不到其他方法可以代替这些
        End If
        MyBase.KeyPreview = True '窗体比控件提前相应键盘事件
        If Tag = "1" Then '如果标签为1
            ShowInTaskbar = False '取消显示任务栏图标
        End If
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress '输入内容时
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then '检测0-9，退格键
            e.Handled = False '处理
        Else '否则
            e.Handled = True '程序认为已经处理过了，于是不会处理
        End If '进行检测处理，禁止输入0-9以及退格键以外的东西，以保证程序不会出错
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click '保存设置
        If Val(TextBox1.Text) > 5000 Then '如果间隔时间大于5000（5秒）
            WritePrivateProfileString("General", "TimeSet", 5000, Application.StartupPath & "/Settings.ini")  '保存间隔时间为5000
        ElseIf Val(TextBox1.Text) < 100 Then '如果间隔时间小于100（0.1秒）
            WritePrivateProfileString("General", "TimeSet", 100, Application.StartupPath & "/Settings.ini")  '保存间隔时间为100
        Else '其他情况
            WritePrivateProfileString("General", "TimeSet", Val(TextBox1.Text), Application.StartupPath & "/Settings.ini")  '保存间隔时间为文本框内数字
        End If
        Dispose(True) '退出
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click '取消
        Dispose(True) '关掉自己
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp '释放按键
        If e.KeyCode = Keys.Escape Then '如果释放的是Esc键
            Dispose() '退出程序
        ElseIf e.KeyCode = Keys.Enter Then '如果是回车
            Button1_Click(sender, e) '激活保存按钮
        End If
    End Sub
    '2321年的程序可还行，这就是赛博朋克吗，爱了爱了）
    '虽然是个2321年的程序，但终究还是人写的
End Class