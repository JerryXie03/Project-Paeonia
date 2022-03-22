# 灰烬战线：九霄共和
## Project-Paeonia
An anime-styled military RTT game I'm developing since May 2021 in collaboration with several artist and coder online, a parody to the game AshArms.\
The decision to develop a game came as I was accepted into Computer Science. I was wondering if I could put what I've been learning and what I love together and get something out of it. Playing the game AshArms gave me an idea. While I enjoyed the game overall, the gameplay isn't the most satisfying. Thus came the question "what if I can make a better version?"

## 关于游戏
《灰烬战线：九霄共和》是游戏《灰烬战线》的同人作品，属于RTT，由一群兴趣使然网友从2021年5月开始制作。游戏将预计在2022年2月放出无剧情DEMO，在2022年8月放出完整游戏，2023年之前完成所有更新。游戏不收费，无内购，暂无DLC的计划，没有决定开不开放赞助通道

## 关于背景和设定 Settings
( •̀ ω •́ )✧\
娘化，都可以娘化\
\
本游戏起源于在百度贴吧中关于灰烬战线中系的讨论。在原游戏《灰烬战线》中，有不同的“学联”代表着现实中的不同国家。其中没有中系。在贴吧里关于中系的讨论中，大部分人都持有中系“无车可出”，“只有冷战后期才有自己的特色载具”的想法。\
\
作为一名热衷于老装备的《战争雷霆》老玩家，同时因为对老物件总有特殊情感，本人认为这样的说法是不妥的。于是，《灰烬战线：九霄共和》应运而生了。一开始作为一个图文帖，科普（这应该不算科学普及吧，我也只是让其他人知晓了装备的存在而已，并没有什么干货，毕竟没有门路）从“九一八”事变到内战结束这段时间内涌现出的中国本土载具，后来因为本人考入了计算机系，决定和画师联手将这些设定变为一个游戏，一定程度上也是锻炼自己的编程能力的同时向玩家进行科普。（但我好像找不到更好的词了）\
\
名字 *“九霄共和学联”* 来自于向网友征集的名字。原本想要设定为“九州”，但是据网友反馈对于这个名字的印象已经被日本的“九州”先入为主了，于是改为了“九霄”。\
\
因为原游戏《灰烬战线》的背景是二战时期的装备，本游戏内（将）主要涵盖从民国初期至共和国建立的中国本土装备，以及冷战初期乃至中期的二战水平的装备。

## 关于游戏玩法 Gameplay

## 关于授权 Authorization
![image](https://user-images.githubusercontent.com/90075718/140989907-ca65bf82-11c5-4e88-a115-ceeb5aed47d3.png)


## Dev Blog
### 0.0.16
 - 加入了全新的主界面UI
 - 全新设置界面UI
 - 右上角还不能用的资源（正在搭建资源管理系统）
 - 暂时，暂时，暂时采用新字体
 - 主界面立绘可点击，跳出对话框，暂时不可以更换
 - 暂时禁用了战斗系统，因为需要对其进行重构
 - 往剧情演出里面增加了测试脚本
 - 0.0.161：将所有音效分进了音效组，玩家可以直接调音效组的音量。加入了简单的单击音效

### 0.0.15
 - 因为难度问题，编队暂时变回了满编大队
 - 修复了一个导致无法移动的恶性bug
 - 修复了一个导致无法点亮周围地块的恶性bug
 - 现在无法因为点亮而攻击到攻击不到的敌方单位了（比如山后面）
 - 增加了敌军：测试重型火炮，攻击方式：对不在敌方视野内的我方攻击中火炮上一个“被搜索”buff，范围7格，如果该火炮在这个范围内在攻击，对我方火炮增加“被发现”buff，同时发起两轮反制火炮；对在敌方视野内的我方攻击中火炮上一个“被发现”Buff，同时发起两轮反制火炮；装甲中等，血量中等，装填长（但有急速射两发），攻击力高，攻击范围全图
 - 增加了敌军：测试轻型火炮，攻击方式：对范围内的我方单位发起炮击，无需被标记；装甲低，血量低，装填长，攻击力地，攻击范围远
 - 增加了敌军：测试防空炮，攻击方式：对范围内的我方空军进行杀伤，无法攻击我方地面单位；装甲低，血量低，装填短，有弹匣，攻击范围远
 - 新人物：T-34-85/T-34-85改，中型坦克，满编4人，技能是切换苏制BR365A APHEBC为中制56式APFSDS，可以从容应对高甲单位，但是本身的装药弹后效也特别足就是了；装甲十分优秀，速度稍微比36式慢一点
 - 增加了共7个关卡
 - 章节加入了背景图片
 - 0.0.151：新人物：研轰三式，中型轰炸机，满编2人，只能进行轰炸，视野比侦察机窄，不容易被敌方防空炮击落。时间长，需要72秒钟；更改了视野范围，现在不在视野内的会消失不见，首次点亮后会出现然后失去视野会变成灰色
 - 0.0.152：修复了一个DOLLS因为血量变量out of bound导致的无法减血量而变为无敌的bug；修复了一个敌方因为血量变量null pointer导致的一被攻击就死亡的bug；修复了一个因为代码逻辑问题导致直到眼前才能看到山和树林的bug。这是不对的，应该是如果前面有个山，我看得到这个山，但是看不到后面的东西，树林也是一样。
 - 0.0.153：增加了背包系统，现在过关可以获得掉落物，但是掉落物暂时不会显示，而是要回到主页查看。
 - 0.0.154：增加了编队查看界面、DOLL详细信息界面。
 - 0.0.155：增加了剧情演示的 Scene。

### 0.0.14
 - 现在编队不再是最大编队了
 - 移动模式的bug修复
 - 更改了敌军的生成模式和移动模式，现在敌人会在文件中设定好的位置出生，然后沿着设定好的路线移动
 - 更改了地图的生成模式，将文件从纯文本改为了json
 - 加入了背景草稿
 - 加入了新的测试UI
 - 加入了新的BGM
 - BGM可以更改音乐大小了，但是音效还不行
 - 更改了主页逻辑，新增了关卡要打完上一关才能解锁下一关的设定，并且可以保存进度
 - 不同的关卡加入了选人的限制
 - 可以一键清除进度了
 - 0.0.141：修复了一个小的战争迷雾的bug，关卡内bgm也可以被设置调节了
 - 0.0.142：加入了敌方火炮
 - 0.0.143：修复了无法移动的bug，并且把主菜单界面改为了原来的纯色

### 0.0.13
 - 项目的管理模式从Unity Collab改为了上传至Github
 - 重新加入了移动读条并且更改了移动方式，从点击周围的格子改为拖拽出路线，角色会自动沿着这条路线行进。在前进时，如果玩家画出新的路线，角色会走完当前一格然后沿着新的路线移动
 - 更改了空军的移动方式，现在飞机的速度和帧数不挂钩了
 - 更改了空军的路径，现在不会出现飞机因为时间到了但还没有重置到起点导致空中支援不触发但却又进入冷却时间的情况了
 - 优化了渲染模式，具体效果不变，我的手机上帧数从18上升到了50
 - 取消了动态水面，削减了贴图清晰度，重新加回了特效和辉光
 - 重做了代码逻辑，具体效果不变，性能有所提升，帧数可以稳定在30帧以上
 - 加入了BGM
 - 现在玩家的信息可以被保存下来，例如上一次通关所得的星数
 - “复兴”甲的弹着点优化，攻击力提升，散布减少
 - 0.0.131：修复了一个小的导致空中支援无法找到敌军的bug
 - 0.0.132：增加了新的BGM
 - 0.0.133：试了一下新的UI

### 0.0.12
 - 增加了主页面和结算页面
 - 新兵种：空军
 - 新人物：“复兴”甲型 (AP-1)轻型侦查/轰炸机，武器为2x7.62mm机枪，4x100磅炸弹
 - 添加了空中支援。当使用空中支援时，将技能图标从左下角拖拽至目标地点，飞机由屏幕左边进场，在目标地点附近对敌军进行打击，由右边出场
 - 基本上做完了一个关卡，有起点，有目标，有敌人
 - 添加了友军伤害
 - 0.0.121：“复兴”甲 的备弹从4×100磅变为2×2颗100磅，散布变小，溅射范围变小，单次基础攻击力翻倍，起飞准备时间42→35秒
 - 0.0.122：关闭了辉光和特效，帧数有所提升，可以稳定在20帧左右

### 0.0.11
 - 增加敌人：测试靶标：步战车。特点：穿深低，伤害低，护甲低，射速快
 - 增加敌人：测试靶标：坦歼。特点：穿深高，伤害高，护甲低，射速慢
 - 增加我方单位：M10/105mm，自行火炮，装填时间16秒，不会自动攻击，手动瞄准技能攻击
 - 增加了简易的敌人路线
 - 增加了同位体和编队：轻型载具为5编队，中型为3编队，重型为1编队。
 - 现在有破不破编的设定了：当我方只有一个单位而敌方的编队有5个时，就算攻击为9999也只能造成对方血量1/5的伤害，请注意随着dolls损失，火力也会下降哦
 - 因为老是出bug，暂时取消了移动读条，会在后续版本修复重新加入
 - 降低了画质，更流畅了

### 0.0.10
 - 单位选择系统从弹出编程了下拉窗口，且可以左右滑动
 - 编队系统的bug被修复了
 - 编队现在可以将单位取消选择
 - 编队现在按照兵种来分配了
 - 增加敌人：测试靶标：静态靶标。不会攻击，没有防御，血量高
 - 目前只有三六式可以生成
 - 加入了血量管理
 - 加入了音效
 - 加入了战斗系统，目前为自动攻击范围内的敌军
 - 加入了战争迷雾
 - 加入了地势系统，地势可以阻碍视线
 - 到达敌方基地可以结束游戏
 - 现在可以直接退出到菜单界面，不需要关闭游戏重进
 - 0.0.101：攻击加入了弹道，不会是一条直线了

### 0.0.09
 - 项目在bilibili首次通过视频的方式亮相
 - 现在点击卡槽会弹出编队窗口，选择对应角色可以编入队伍
 - 队伍中的单位会自动生成在相应位置
 - 增加了立绘不完全的其他角色，目前只有三六式可以生成
 - 更新了渲染模式为URP（好难用
 - 地图和UI现在分为两个摄像机来渲染
 - 辉光不会让UI也亮堂堂了
 - 人物的信息被整合进了一个文件，好做管理
 - 0.0.091：修复了一个人物不会跟着摄像机走的bug，是把人物和地图分开渲染了，但是忘记挂载摄像机的代码导致的
 - 0.0.092：修复选择人物后，再次点击然后选择退出就会卡掉该人物的bug

### 0.0.08
 - 因为贴吧的审核，逐渐将更新日志从贴吧转移到bilibili
 - 单位生成从拖拽变成了进入游戏时编入队伍，队伍中的单位会自动生成在相应位置
 - 现在单击其他单位会取消选择原来的单位，点击单位去不了的地块也会取消选择单位
 - 修复了单位在不被选中的时候体力条不读条的bug
 - 优化了双指缩放的速度
 - 优化了单指滑动屏幕的算法，不会把双指视为快速移动的单指了
 - 加入了出生点和敌方基地
 - 增加了三六式头像背景和立绘草稿，画师塔塔肥 
 - 更改了应用图标
<img src="https://user-images.githubusercontent.com/90075718/140990599-5db7cb70-763a-45d8-b053-8f0fc2574130.png" width="40%" height="40%">

### 0.0.07
 - 人物生成的方式为从右下角拖拽至地图上生成
 - 修复了拖拽物品时在手机不是16:9的情况下导致物品起飞的bug

### 0.0.06
 - 移动后的人物读条改为了dolls的基础行动值 × 目前地块的行动值乘子
 - Dolls分为轻型，中型，和重型，这些决定了dolls的基础行动力，轻型载具恢复行动力的时间比重型载具要短很多
 - 地形分为草地，沙地，沼泽，森林，丘陵，山地，和河流；在草地和沙地上，dolls的行动力恢复不受影响；在森林里，行动力恢复时间变为1.5倍；在沼泽和丘陵，恢复时间变为2.1倍；山地和河流不可进入
 - 把人物的碰撞箱从树立在当前地块中央改为了扁平地铺在当前地块上。

### 0.0.05
 - 加入了第一个人物：沪造三六式十轮装甲车。轻型装甲车，武器网传是1x7.92mm民二四式重机枪和1x37mm三〇式战防炮，史图上的是2x7.92mm
 - 把胶囊改成了人物贴图草稿。
 - 在移动后Dolls需要等到一段时间来恢复行动力

### 0.0.04
 - 移动时会有一个六边形生成代表下一步去哪
 - 对以后的工作进行了规划

### 0.0.03
 - 在txt文档里面有一个数字矩阵，不同的数字代表着不同的地形
 - 加入了山地，森林，丘陵，沙漠，草原，水体

### 0.0.02
 - 当玩家选中单位的时候，单位会变红
 - 当玩家在选中一个单位的情况下，再点击一个地块，这个被选中的单位就会移动过去
 - 在开始游戏的时候，会通过一个txt文件生成地图

### 0.0.01
 - 利用免费素材生成了一个由六边形地块组成的棋盘
 - 新增了一个胶囊作为单位
 - 当玩家拖拽的时候，摄像头可以移动

### 0.0.00
 - 完成了Unity的下载和安装
 - 确定了游戏模式：战棋和RTT的融合
