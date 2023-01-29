# SmartEyes
Speech recognition controls eye movement

Step 1:
请自行在“百度智能云”上注册申请一个百度语音识别的应用，并在“AipController”脚本中填写相关信息。

Step 2:
请创建一个Canvas并命名为【AipManager】，并创建一个Button、Text、Image用来添加“AipController”脚本变量，并去掉【Button】的原有按钮组件，添加“ListenButton”脚本。

Step 3:
创建一个空物体用来管理信息，并搭载“MsgManager”脚本，在其中添加识别关键词。

Step 4:
最后在“MsgManager”脚本中的“EyesControl”函数内编写关键词识别之后的操作函数。

Step 5:
运行程序后，鼠标按住【Button】开始讲话，即可识别关键词做出相应动作。