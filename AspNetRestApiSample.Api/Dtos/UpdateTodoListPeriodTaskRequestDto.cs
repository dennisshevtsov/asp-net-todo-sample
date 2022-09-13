﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace AspNetRestApiSample.Api.Dtos
{
  /// <summary>Represents data to update todo list task.</summary>
  public sealed class UpdateTodoListPeriodTaskRequestDto : UpdateTodoListTaskRequestDtoBase
  {
    /// <summary>Gets/sets an object that represents a beginning of a task.</summary>
    public DateTime Beginning { get; set; }

    /// <summary>Gets/sets an object that represents an end of a task.</summary>
    public DateTime End { get; set; }
  }
}
