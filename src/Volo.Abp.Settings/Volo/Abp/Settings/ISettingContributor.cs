﻿using System.Threading.Tasks;

namespace Volo.Abp.Settings
{
    public interface ISettingContributor
    {
        Task<string> GetOrNull(string name, string entityType, string entityId, bool fallback = true);
    }
}