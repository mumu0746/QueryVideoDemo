using QueryVideoDemo.Tools;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace QueryVideoDemo.Controllers
{
    [ApiController]
    [Route("ceshi")]
    [EnableCors("cors")] //这边添加前端写的请求接口的写法
    public class GetVideoController : ControllerBase
    {
        //使用Get方法请求的格式
        [HttpGet]
        [Route("test")]
        public IActionResult Test(string queryInfo)
        {
            List<VideoInfo> success = ConnectToDataBase.GetVideoByInfo(queryInfo);
            if (success.Count != 0)
            {
                return Ok(success);
            }
            else
            {
                return Ok("非常抱歉，没有查到您需要的视频");
            }
        }
    }
}
