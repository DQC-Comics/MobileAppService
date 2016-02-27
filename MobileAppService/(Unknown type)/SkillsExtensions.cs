﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DqccomicsMobileapiService;
using DqccomicsMobileapiService.Models;
using Microsoft.Rest;

namespace DqccomicsMobileapiService
{
    public static partial class SkillsExtensions
    {
        /// <param name='operations'>
        /// Reference to the DqccomicsMobileapiService.ISkills.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static ApiSkill GetSkill(this ISkills operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISkills)s).GetSkillAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the DqccomicsMobileapiService.ISkills.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<ApiSkill> GetSkillAsync(this ISkills operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<DqccomicsMobileapiService.Models.ApiSkill> result = await operations.GetSkillWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the DqccomicsMobileapiService.ISkills.
        /// </param>
        public static IList<ApiSkill> GetSkills(this ISkills operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISkills)s).GetSkillsAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the DqccomicsMobileapiService.ISkills.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<ApiSkill>> GetSkillsAsync(this ISkills operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<DqccomicsMobileapiService.Models.ApiSkill>> result = await operations.GetSkillsWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
