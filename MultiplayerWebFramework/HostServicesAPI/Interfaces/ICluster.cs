using Microsoft.AspNetCore.Mvc;
using MWFModelsLibrary.Enums;
using MWFModelsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HostServicesAPI.Interfaces
{
    public interface ICluster
    {
        public List<GameInstanceModel> ActiveGameInstances { get; set; }
        public Task<HttpResponseMessage> SpinUpGameInstance(Game game, string port, string args, int hostId, string filePath);
        public Task<HttpResponseMessage> ShutDownGameInstanceById(int inGameInstanceId);
        public Task<bool> ShutDownAllGameInstances(int hostId);
    }
}
