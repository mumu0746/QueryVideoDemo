# QueryVideoDemo
用于查询数据库中所存放的视频，前后端结合，只涉及GET请求
## 前端部分
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;学习了前端三件套：HTML+CSS+JS，以及vue2基础。<br/><br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;前端主要做了两个页面，一个是首页，用于查询功能，包含输入框、搜索按钮以及一个小鸟动画；另一个是详情页，用于展示搜索到的数据。<br/><br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;输入框使用了模糊查询并且不区分大小写，用户点击搜索之后，前端发送get请求给后端，并将搜索关键词赋值给请求参数，然后等待后端响应，返回数据库中查询的数据给前端，最后前端用这些数据对页面进行渲染。
<br/><br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;此外在详情页，还布置了各种选择器，例如根据视频的时长，或者根据视频的发布时间对视频进行筛选，有更好的用户体验。<br/><br/>
## 后端部分
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;学习了C#语言以及SQL Server数据库。<br/><br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;在数据库中事先准备好了数据，然后利用C#代码和数据库建立连接，可以对数据库进行一系列操作。
