using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using VOL.Core.Configuration;

using VOL.WebApi.Controllers.MqDataHandle;

namespace VOL.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
            //CreateHostBuilder(args).Build().Run();
            var host = CreateHostBuilder(args).Build();
            #region kafka订阅消息
            //if (AppSetting.Kafka.UseConsumer)
            //{
            //    using var scope = host.Services.CreateScope();
            //    var testConsumer = scope.ServiceProvider.GetService<IKafkaConsumer<string, string>>();
            //    testConsumer.Consume(res =>
            //    {
            //        Console.WriteLine($"recieve:{DateTime.Now.ToLongTimeString()}  value:{res.Message.Value}");
            //        //静态方法 数据处理 入库等操作
            //        bool bl = DataHandle.AlarmData(res.Message.Value);
            //        //回调函数需返回便于执行Commit
            //        return bl;
            //    }, AppSetting.Kafka.Topics.TestTopic);
            //}
            #endregion
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
               Host.CreateDefaultBuilder(args)
                   .ConfigureAppConfiguration((context, config) =>
                   {
                       // 加载 appsettings.json 配置
                       config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                   })
                   .ConfigureWebHostDefaults(webBuilder =>
                   {
                       webBuilder.ConfigureKestrel(serverOptions =>
                       {
                           serverOptions.Limits.MaxRequestBodySize = 10485760;
                           // Set properties and call methods on options
                       });

                       // 从配置中读取 Kestrel 监听地址
                       var configuration = new ConfigurationBuilder()
                           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                           .Build();

                       var kestrelUrl = configuration.GetValue<string>("AppUrls:KestrelUrl");
                       webBuilder.UseKestrel().UseUrls(kestrelUrl);
                       webBuilder.UseIIS();
                       webBuilder.UseStartup<Startup>();
                   }).UseServiceProviderFactory(new AutofacServiceProviderFactory());
    }
}
