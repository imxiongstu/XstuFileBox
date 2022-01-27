using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XStuFileBox.Common.Configure
{
    public static class AppSettings
    {
        private static IConfiguration configuration { get; set; }
        static AppSettings()
        {
            //读取本地bin目录的appsettings.json配置文件
            configuration = new ConfigurationBuilder()
                         .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                         .AddJsonFile("appsettings.json", true, true)
                         .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true, true)
                         .Build();
        }

        /// <summary>
        /// 获取配置
        /// </summary>
        /// <param name="keyValue">例：ConnectionStrings:MySqlConStr</param>
        /// <returns></returns>
        public static string Get(string keyValue)
        {
            return configuration.GetSection(keyValue).Value;
        }
    }
}
