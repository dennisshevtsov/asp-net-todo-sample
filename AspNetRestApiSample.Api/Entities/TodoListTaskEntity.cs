﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace AspNetRestApiSample.Api.Entities
{
  /// <summary>Represents data of a todo list task.</summary>
  public sealed class TodoListTaskEntity : TodoListEntityBase
  {
    /// <summary>Gets/sets an object that represents data of a TODO list.</summary>
    public TodoListEntity? TodoList { get; set; }

    /// <summary>Gets/sets an object that indicates if a TODO list task is completed.</summary>
    public bool Completed { get; set; }
  }
}
