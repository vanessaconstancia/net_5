using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace teste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SingleFileAppController : ControllerBase
    {


        private readonly ILogger<SingleFileAppController> _logger;

        public SingleFileAppController(ILogger<SingleFileAppController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
               string versao = Assembly
                .GetEntryAssembly()?
                .GetCustomAttribute<TargetFrameworkAttribute>()?
                .FrameworkName;
            OperatingSystem os = Environment.OSVersion;
            string pasta = System.AppContext.BaseDirectory;

            return $"Executando na máquina: {Environment.MachineName} \nSistema Operacional: {Environment.OSVersion} \nVersão do .net {versao} \nPasta {pasta} ";

        }
    }
}
