﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace AspNetRestApiSample.Api.Storage
{
  /// <summary>Represents settings of a database.</summary>
  public sealed class DatabaseOptions
  {
    /// <summary>Gets/sets an object that represents an account endpoint of a database.</summary>
    public string? AccountEndpoint { get; set; }

    /// <summary>Gets/sets an object that represents an account key of a database.</summary>
    public string? AccountKey { get; set; }

    /// <summary>Gets/sets an object that represents a name of a database.</summary>
    public string? DatabaseName { get; set; }

    /// <summary>Gets/sets an object that represents a name of a container.</summary>
    public string? ContainerName { get; set; }

    /// <summary>Gets/sets an object that represents a value of a throughput.</summary>
    public int Throughput { get; set; }
  }
}
