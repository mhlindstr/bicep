// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Bicep.Core.RegistryClient.Models
{
    internal partial class JWK
    {
        internal static JWK DeserializeJWK(JsonElement element)
        {
            Optional<JWKHeader> jwk = default;
            Optional<string> alg = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jwk"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jwk = JWKHeader.DeserializeJWKHeader(property.Value);
                    continue;
                }
                if (property.NameEquals("alg"))
                {
                    alg = property.Value.GetString();
                    continue;
                }
            }
            return new JWK(jwk.Value, alg.Value);
        }
    }
}