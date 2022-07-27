﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace AspNetRestApiSample.Api.Services
{
  using AspNetRestApiSample.Api.Dtos;

  public sealed class TodoListService : ITodoListService
  {
    public Task<GetTodoListResponseDto> GetTodoListAsync(
      GetTodoListRequestDto query, CancellationToken cancellationToken)
      => throw new NotImplementedException();

    public Task<SearchTodoListsRecordResponseDto[]> SearchTodoListsAsync(
      SearchTodoListsRequestDto query, CancellationToken cancellationToken)
      => throw new NotImplementedException();

    public Task<AddTodoListResponseDto> AddTodoListAsync(
      AddTodoListRequestDto command, CancellationToken cancellationToken)
      => throw new NotImplementedException();

    public Task UpdateTodoListAsync(
      UpdateTodoListRequestDto command, CancellationToken cancellationToken)
      => throw new NotImplementedException();

    public Task DeleteTodoListAsync(
      DeleteTodoListRequestDto command, CancellationToken cancellationToken)
      => throw new NotImplementedException();
  }
}
