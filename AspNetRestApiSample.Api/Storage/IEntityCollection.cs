﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace AspNetRestApiSample.Api.Storage
{
  using AspNetRestApiSample.Api.Entities;

  /// <summary>Provides a simple API to an entity collection in a database.</summary>
  /// <typeparam name="TEntity">A type of an entity.</typeparam>
  public interface IEntityCollection<TEntity> where TEntity : TodoListEntityBase
  {
    /// <summary>Gets an attached entity that satisfies defined conditions.</summary>
    /// <param name="id">An object that represents a primary ID of an entity.</param>
    /// <param name="todoListId">An object that represents a ID of a TODO list.</param>
    /// <param name="cancellationToken">An object that propagates notification that operations should be canceled.</param>
    /// <returns>An object that represents an asynchronous operation that can return a value.</returns>
    public Task<TEntity?> GetAttachedAsync(
      Guid id, Guid todoListId, CancellationToken cancellationToken);

    /// <summary>Gets an detached entity that satisfies defined conditions.</summary>
    /// <param name="id">An object that represents a primary ID of an entity.</param>
    /// <param name="todoListId">An object that represents a ID of a TODO list.</param>
    /// <param name="cancellationToken">An object that propagates notification that operations should be canceled.</param>
    /// <returns>An object that represents an asynchronous operation that can return a value.</returns>
    public Task<TEntity?> GetDetachedAsync(
      Guid id, Guid todoListId, CancellationToken cancellationToken);

    /// <summary>Populates an entity with data of a command.</summary>
    /// <param name="command">An object that represents data to populate an entity.</param>
    /// <param name="entity">An instance of an entity.</param>
    public void AddOrUpdate(object command, TEntity entity);

    /// <summary>Enqueues an entity to be deleted.</summary>
    /// <param name="entity">An instance of an entity.</param>
    public void Delete(TEntity entity);
  }
}
