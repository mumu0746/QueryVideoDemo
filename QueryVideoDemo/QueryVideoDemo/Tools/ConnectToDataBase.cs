using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QueryVideoDemo.Tools
{
    public class VideoInfo
    {
        public int id { get; set; }
        public string videoName { get; set; }
        public string videoURL { get; set; }
        public int videoDuration { get; set; }
        public int releaseTime { get; set; }
        public int likes { get; set; }
        public int collects { get; set; }
        public int comments { get; set; }
    }
    public static class ConnectToDataBase
    {
        public static List<VideoInfo> GetVideoByInfo(string queryInfo)
        {
            List<VideoInfo> videoList = new List<VideoInfo>();

            string constr = @"Data Source=.;Initial Catalog=Video;Integrated Security=True";
            using(SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    string sql = String.Format("select * from VideoInfo where videoName collate SQL_Latin1_General_CP1_CI_AS like '%{0}%'", queryInfo);  //不区分大小写且模糊查询
                    SqlCommand command = new SqlCommand(sql, conn);  

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VideoInfo video = new VideoInfo();
                            video.id = Convert.ToInt32(reader["id"]);
                            video.videoName = reader["videoName"].ToString();
                            video.videoURL = reader["videoURL"].ToString();
                            video.videoDuration = Convert.ToInt32(reader["videoDuration"]);
                            video.releaseTime = Convert.ToInt32(reader["releaseTime"]);
                            video.likes = Convert.ToInt32(reader["likes"]);
                            video.collects = Convert.ToInt32(reader["collects"]);
                            video.comments = Convert.ToInt32(reader["comments"]);

                            videoList.Add(video);
                        }
                    }
                    return videoList;
                }
                catch (Exception ex)
                {
                    //处理异常
                    throw ex;
                }
                //不需要再手动关闭连接，因为在 using 块的末尾会自动调用相关对象的Dispose方法，关掉reader和数据库的连接
            }
        }
    }
}
