using QueryVideoDemo.Tools;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace QueryVideoDemo.Controllers
{
    [ApiController]
    [Route("ceshi")]
    [EnableCors("cors")] //������ǰ��д������ӿڵ�д��
    public class GetVideoController : ControllerBase
    {
        //ʹ��Get��������ĸ�ʽ
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
                return Ok("�ǳ���Ǹ��û�в鵽����Ҫ����Ƶ");
            }
        }
    }
}
