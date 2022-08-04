﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace AspNetRestApiSample.Api.Dtos
{
  using AspNetRestApiSample.Api.Indentities;

  /// <summary>Represents data to update todo list task.</summary>
  public sealed class UpdateTodoListTaskRequestDto : ITodoListIdentity, ITodoListTaskIdentity
  {
    /// <summary>Gets/sets an object that reprsents an ID of a todo list.</summary>
    public Guid TodoListId { get; set; }

    /// <summary>Gets/sets an object that represents an ID of a todo list task.</summary>
    public Guid TodoListTaskId { get; set; }

    /// <summary>Gets/sets an object that represents a title of a todo list task.</summary>
    public string? Title { get; set; }

    /// <summary>Gets/sets an object that represents a description of a todo list task.</summary>
    public string? Description { get; set; }
  }
}
