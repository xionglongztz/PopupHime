Imports System.ComponentModel
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '位置显示
        Dim WndX As New Integer, WndY As New Integer '定义x,y新的屏幕坐标
        Randomize() '随机数初始化
        WndX = Int(Rnd() * Screen.PrimaryScreen.Bounds.Width) - Width '取整由0到屏幕横向距离的数，减去本身大小
        WndY = Int(Rnd() * Screen.PrimaryScreen.Bounds.Height) - Height
        Location = New Point(WndX + Width, WndY + Height) '放置位置
        '内容显示
        Dim mw As New List(Of String) '定义新的列表（窗口内容MeetingWords）
        Dim Ran As New Random() '定义新随机数
        Randomize() '伪随机（不产生重复的）
        mw.Add("我大意了啊，没有闪！")
        mw.Add("刚才有个朋友问我，马老师发生什么事了") '马保国名言
        mw.Add("我是四年级学生森上上土，是来监管你们的！")
        mw.Add("好，很多窗口！") '《啊！海军》 - 好，很有精神
        mw.Add("关掉，关掉，一定要关掉") '关掉姐
        mw.Add("我们不管遇到什么困难，微笑的去面对她") '冬泳怪鸽名言
        mw.Add("一日三餐没烦恼，今天就吃老⑧秘制小汉堡") '岛市老八名言
        mw.Add("一看就是老窗口人了")
        mw.Add("我控制窗口一直可以的") '阴阳怪气
        mw.Add("《关于我被作者编写为电脑程序并成功运行这档事》") '转生史莱姆
        mw.Add("KO↘KO↗DA↘YO↗") '明日方舟
        mw.Add("谢邀，人在电脑，刚被打开") '知乎
        mw.Add("知道了，这就去和开发者对线") 'Moba类游戏衍生梗
        mw.Add("23333333333333") '哈哈哈哈
        mw.Add(":(你的电脑出现问题，需要重新启动") 'Windows10蓝屏
        mw.Add("点击查看：开发者早期驯服野生窗口珍贵录像")
        mw.Add("小别致长得真东西")
        mw.Add("窗口打开了啊啊啊啊啊啊啊啊啊啊啊") '布施明唱的布好听
        mw.Add("控制窗口混乱程度的能力") '东方对一个人物能力的评价
        mw.Add("此生无悔入东方，来世原生幻想乡")
        mw.Add("魔理沙偷走了重要的东西") '东方
        mw.Add("VB.NET是世界上最好的语言") '赞美程序的发明者
        mw.Add("每一帧都是壁纸")
        mw.Add("我们小学二年级就学过，这种程序是可以关掉的") 'up:毕导THU
        mw.Add("这是你的电脑，上面布满了窗口") 'up:回形针Paperclip
        mw.Add("震惊，一用户电脑上突然弹出了大量的窗口")
        mw.Add("震惊，电脑上出现这个东西，99%的人不知道怎么办"） 'UC浏览器
        mw.Add("你也网上冲浪啊，你是GG还是MM") 'QQ等初代网络流行语
        mw.Add("肥料掺了银克拉，不流失，不蒸发，O浪费") '骨粉广告词
        mw.Add("你掉的是这个金克拉，还是这个银克拉，还是这个查克拉呢") '多厨爆炸
        mw.Add("正道的光，照在了大腚上") '正义大道
        mw.Add("酸甜苦辣咸，窗口天天见") '喜羊羊与灰太狼之懒羊羊当大厨
        mw.Add("如果窗口有颜色，那她一定是白色")
        mw.Add("没用的窗口不要扔，裹上鸡蛋液，粘上面包糠，炸至两面金黄，隔壁小孩馋哭了")
        mw.Add("你打音游像东方，你打东方像音游")
        mw.Add("0001011000100010100010000010") '23210114程序出生日（转换成HEX16进制作为指令输入程序）彩蛋提示②
        mw.Add("竖起大拇指，自信音游人")
        mw.Add("你问我几岁，你问的太多了") 'Muse Dash
        mw.Add("E S M 跑") '音游梗
        mw.Add("你为什么不问问神奇海螺呢") '海绵宝宝
        mw.Add("好家伙，我直接好家伙")
        mw.Add("建议改成：建议不要建议")
        mw.Add("本窗口创建日期：" & DateTime.Now.Year + 300 & "年" & DateTime.Now.Month & "月" & DateTime.Now.Day & "日" & DateTime.Now.Hour & "时" & DateTime.Now.Minute & "分" & DateTime.Now.Second & "秒") '梦回三百年前
        mw.Add("Hello World!") '草
        mw.Add("叔叔我啊，__________")
        mw.Add("欸，弱欸，拜托你很弱欸，你现在知道谁是老大了吧") '杰哥不要
        mw.Add("鞋印梗是要扣钱的") '谐音梗
        mw.Add("我是练习时常两年半的独立软件弹窗姬，喜欢唱，跳，rap，偷袭") 'ikun
        mw.Add("这个是24世纪才会有的窗口，因为发电厂计算机停电了，现在有了电脑让我重新活了回来，爷很高兴") '爷喜欢的删减环节
        mw.Add("哈哈哈哈哈哈哈")
        mw.Add("你的双手是为了你的一生而服务的，而不是你的弹窗") 'osu
        mw.Add("适度弹窗益脑，沉迷弹窗伤身") '健康游戏忠告
        mw.Add("学习新思想，争做新青年") '青年dark♂学习
        mw.Add("I'm a country girl,but you're a super cityboy")
        mw.Add("Daisuke..") 'Daisuke..
        mw.Add("Sakura Samurai")
        mw.Add("压S了，梁飞凡") '梁非凡冥场面
        mw.Add("你指尖跃动的电光，是我此生不灭的信仰，唯我超电磁炮永世长存！") '《某科学的超电磁炮》
        mw.Add("沉迷弹窗，日渐消瘦")
        mw.Add("我待电脑如初恋，她却弹窗千百遍")
        mw.Add("初看不知画中意，再看已是画中人") '各种捏她诗句
        mw.Add("从前有座山，山里有座庙，庙里有台满是窗口的电脑")
        mw.Add("我相信，梦能到达的地方，总有一天，脚步也能到达")
        mw.Add("这橙色便是溴") '萌凤
        mw.Add("Komeiji Satori，yyds") '觉大人赛高（罗马音）
        mw.Add("在这美好的一天里，花儿在微笑，鸟儿在欢唱，像你这样的孩子，就应该接受不断地弹窗") 'Undertale
        mw.Add("弹窗5分钟，玩梗亿小时") 'OPPO广告
        mw.Add("你可能是正版用户的受害者") 'Windows
        mw.Add("Windows，yyds")
        mw.Add("请问您今天要来点弹窗吗") '《请问您今天要来点兔子吗》
        mw.Add("弹窗降临到我身边") '《天使降临到我身边》
        mw.Add("愿窗口与你同在") '星球大战
        mw.Add("众所周知，弹窗是关不掉的")
        mw.Add("刻在DNA里的窗口")
        mw.Add("_(:з」∠)_") '表情都出来了...服了，官方吐槽，最为致命
        mw.Add("这个程序一共有2147483647个对话框") '2^31-1程序都快出错了2333333
        mw.Add("我弹窗发自真心") '德国boy
        mw.Add("窗口可能会迟到，但她从不会缺席") '模仿“蕉迟但到”梗
        mw.Add("宁就是窗口之子") '新海诚《天气之子》
        mw.Add("Super面筋人") '黑镖客梦回
        mw.Add("看这个弹窗这么可爱，不如我们把他...") '华农兄弟
        mw.Add("针布戳，疯狂弹窗针布戳") '谐音梗x2
        mw.Add("这个弹窗看起来很好玩的亚子")
        mw.Add("雨女无瓜") '巴啦啦小魔仙之游乐王子
        mw.Add("tips:输入命令行参数/?可以获得帮助哦")
        mw.Add("tips:输入命令行参数/s可以进行设置哦") '程序本身相关
        mw.Add("我就是打S，S外面，从这跳下去，也不会再来一个弹窗") '王境泽“真香”
        mw.Add("人类的本质是什么") '复读机
        mw.Add("咕咕咕") '鸽子
        mw.Add("#43E1FF") '神秘颜色代码
        mw.Add("要想富，先撸树") 'Minecraft我的世界
        mw.Add("歪比巴卜") '植物大战僵尸
        mw.Add("当你看到这条消息时，说明这不是BUG这是特性") 'mc梗x2
        mw.Add("'这行代码的上面，一共有95个梗") '开发者调皮了
        mw.Add(IO.Path.GetFileName(Application.ExecutablePath) & "已停止工作，Windows正在寻找可用的解决方案") '皮，接着皮（Windows系统程序出现问题才会有的提示）
        mw.Add("很抱歉，弹窗姬 已停止运行") '柚子皮你是真的皮（安卓系统程序出问题才会有的提示）
        mw.Add("你不是人造革") '那你是真的皮
        mw.Add("少女祈祷中...") '老车车人了
        mw.Add("正在提交反馈至神经...") '老方舟人了
        mw.Add("专属BGM:Astronomia") '黑人抬棺
        mw.Add("肥宅快乐窗") '万物皆可肥宅lization
        mw.Add("Bin2Hex >_") '彩蛋提示①，指二进制转十六进制，并输入到终端命令行（Command Prompt or Terminal）
        mw.Add("看弹窗就像抽奖，你不知道看到的下一个是什么弹窗")
        mw.Add("我有一个大胆的想法")
        mw.Add("/kill @e[type=Window]") '老mc了
        mw.Add("喵内~") '星野日向
        mw.Add("这个窗口100亿%关不掉的啊") '石纪元 - 石神千空
        mw.Add("没有人比我更懂弹窗") '某普
        mw.Add("你现在不能游荡，周围有怪物在休息") 'mc梗x2
        mw.Add("我已经是一个成熟的软件了，该学会自己玩梗了")
        mw.Add("《好比是我每一个弹窗都这么多信息量你能不能坚持关完的故事》") '300年前（1202年）某新番
        mw.Add("弹窗姬，300岁，电脑应用程序，用花贝给开发者捐款") '捏他花呗广告
        mw.Add("你今天要是能关掉我，我当场就把这个弹窗吃掉") '某本伟
        mw.Add("你似乎来到了没有知识存在的荒原") '知乎
        mw.Add("亲，这边建议您换台电脑呢") '老某宝客服了
        mw.Add("哈他拉库") '工作细胞
        mw.Add("真的是非常exciting啊") '毕导
        mw.Add("低情商：把这个程序关了" & vbCrLf & "高情商：我给你重装个系统吧")
        mw.Add("咱也不知道，咱也不敢问") '前几年的老梗了
        mw.Add("tips:Ctrl+E可以关闭程序")
        mw.Add("tips:Esc可以关闭当前弹窗")
        mw.Add("tips:空格或点击标签可以暂停程序运行")
        mw.Add("tips:按下F1可以直接复制选中弹窗的标签内容了")
        mw.Add("tips:其实这个软件最初设置是有性别的（甚至连人设名字都有...）但是对于这样一个软件似乎没什么用")
        mw.Add("我是一只小可耐~小可耐啊真可爱")
        mw.Add("主人不要把我关掉好么，球球你惹") '纯卖萌
        mw.Add("可爱即正义") '草莓棉花糖衍生梗
        mw.Add("叮~" & vbCrLf & "IndiHime" & vbCrLf & "130 160" & vbCrLf & "265 430") '印尼宽带广告
        mw.Add("tips:只要知道了歌曲的bpm，就可以求出ms=(60/BPM)*1000的方法求出毫秒数，这样就可以让弹窗与音乐同步了") '但是这个计时器精度不高，所以难免会有错位的情况出现，以后重写代码时考虑使用更精密的计时器
        mw.Add("我不会轻易的狗带！！")
        mw.Add("Her name,plz") '羊角酒吧网（HornPub）的一个梗（又皮了
        mw.Add("tips:这是至今为止存在的第一个用VBdotNET检测Win10系统是否开启深色模式的例子")
        mw.Add("tips:疯狂模式下无法进行各种操作，只能通过任务管理器关闭程序")
        mw.Add("びゅおむす") '程序的生日转换成26进制（byuoms）再通过平假名发音表示出来
        mw.Add("1200G") '程序的生日转换成62进制（1zo0G）数字+大小写字母，因其长得像1200G

        'mw.add("")'这行是便于添加新条目复制用的
        '随机显示内容
        Label1.Text = mw(Ran.Next(0, mw.Count)) '文本显示随机一条
        Dim wdt As New List(Of String) '定义新的列表（窗口标题WinDowTitle）
        Dim Rand As New Random() '定义新随机数
        Randomize() '伪随机（不产生重复的）
        wdt.Add("电脑发来了一条信息")
        wdt.Add("我才不是玩梗小鬼呢")
        wdt.Add("你的电脑报废了呦")
        wdt.Add("喵喵喵")
        wdt.Add("我要咬你啊~")
        wdt.Add("呜呜呜")
        wdt.Add("汪汪汪")
        wdt.Add("哈哈哈")
        wdt.Add("哼，再也不理你了")
        wdt.Add("嗷呜~") '随机显示内容
        Text = wdt(Rand.Next(0, wdt.Count)) '文本显示随机一条
        'tips:你可能不知道，网上关于"用VBdotNet来检测win10系统是否开启深色模式"的代码算法为0
        '这个程序的检测代码是全网首发
        '而且这个程序采用了一个很巧妙的方法，可以不用引入dwm之类的api，还很方便
        Dim colorKey = Hex(Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\History\Colors", True).GetValue("ColorHistory0", "0")) '获取系统颜色(并转换为十六进制)
        '格式为AABBGGRR，暂时没有用上此行代码，以后可能会用到
        Dim dKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", True).GetValue("AppsUseLightTheme", "0") '判断是否为深色主题
        If dKey = 0 Then '如果是深色主题
            With Me '修改设置
                .BackColor = Color.FromArgb(53, 54, 58)
                .Label1.ForeColor = Color.FromArgb(218, 220, 224) '标签前景色
            End With
        End If
        '开发者再吐槽一句：
        '真的就没有一点关于win7以上系统dwm相关api的中文文档吗
        '我啃生肉啃不动啊，哪怕来个例子也行啊
        '难不成电脑真的要被手机取代了吧，那手机上软件都是在哪编写的？
        '移动端怕不是真的成为主力了吧...
        '国内软件商遇到不赚钱的项目就一点也不投资了？
        '哪怕有个中文文档也好啊
        MyBase.KeyPreview = True '窗体比控件提前相应键盘事件
        If Form1.Tag = "1" Then
            TopMost = True '置顶
        End If
    End Sub
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown '按下键盘时
        If Form1.Tag = "1" Then '如果标签为1
            Exit Sub '取消执行
        End If
        If e.KeyCode = Keys.Escape Then '如果按下的是Esc键
            Dispose() '关掉这个弹窗
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.E AndAlso e.Modifiers = Keys.Control Then '如果同时按下Ctrl+E
            Form1.Dispose() '结束程序
        ElseIf e.KeyCode = Keys.Space Then '如果按下的是空格键
            If Form1.Timer1.Enabled = True Then '如果正在运行
                Form1.Timer1.Enabled = False '暂停运行
            Else '否则
                Form1.Timer1.Enabled = True '继续
            End If
        ElseIf e.KeyCode = Keys.F1 Then '如果按下F1键
            My.Computer.Clipboard.SetText(Label1.Text) '复制弹窗内容
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click '点击标签时
        If Form1.Tag = "1" Then '如果标签为1
            Exit Sub '取消执行
        End If
        If Form1.Timer1.Enabled = True Then '如果正在运行
            Form1.Timer1.Enabled = False '暂停运行
        Else '否则
            Form1.Timer1.Enabled = True '继续
        End If
    End Sub
End Class