// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    internal class MachineLearningScheduleOperationSource : IOperationSource<MachineLearningScheduleResource>
    {
        private readonly ArmClient _client;

        internal MachineLearningScheduleOperationSource(ArmClient client)
        {
            _client = client;
        }

        MachineLearningScheduleResource IOperationSource<MachineLearningScheduleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MachineLearningScheduleData.DeserializeMachineLearningScheduleData(document.RootElement);
            return new MachineLearningScheduleResource(_client, data);
        }

        async ValueTask<MachineLearningScheduleResource> IOperationSource<MachineLearningScheduleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MachineLearningScheduleData.DeserializeMachineLearningScheduleData(document.RootElement);
            return new MachineLearningScheduleResource(_client, data);
        }
    }
}
