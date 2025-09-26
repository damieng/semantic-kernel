// Copyright (c) Microsoft. All rights reserved.

using System;
using MongoDB.Bson;

namespace Microsoft.SemanticKernel.Connectors.MongoDB;

internal static class MongoValue
{
    public static BsonValue CreateBsonValue(object? value)
    {
        if (value is Guid guid)
        {
            return new BsonBinaryData(guid, GuidRepresentation.Standard);
        }

        return BsonValue.Create(value);
    }
}
