﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using AspNetRestApiSample.Api.Indentities;

namespace AspNetRestApiSample.Api.Dtos
{
  /// <summary>Represents data to complete a todo list task.</summary>
  public sealed class CompleteTodoListTaskRequestDto : ITodoListIdentity, ITodoListTaskIdentity
  {
    /// <summary>Gets/sets an object that reprsents an ID of a todo list.</summary>
    public Guid TodoListId { get; set; }

    /// <summary>Gets/sets an object that represents an ID of a todo list task.</summary>
    public Guid TodoListTaskId { get; set; }
  }
}
