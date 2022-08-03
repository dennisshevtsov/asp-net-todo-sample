﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace AspNetRestApiSample.Api.Configurations
{
  using Microsoft.EntityFrameworkCore;
  using Microsoft.EntityFrameworkCore.Metadata.Builders;
  using Microsoft.EntityFrameworkCore.ValueGeneration;

  using AspNetRestApiSample.Api.Entities;

  public abstract class EntityTypeConfigurationBase<TEntity>
    : IEntityTypeConfiguration<TEntity>
    where TEntity : EntityBase
  {
    private const string DescriminatorPropertyName = "__type";

    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
      builder.ToContainer("todo-list-container");

      builder.HasKey(entity => entity.Id);
      builder.HasPartitionKey(entity => entity.TodoListId);

      builder.Property(typeof(string), EntityTypeConfigurationBase<TEntity>.DescriminatorPropertyName).HasValueGenerator<DescriminatorValueGenerator>();
      builder.HasDiscriminator(EntityTypeConfigurationBase<TEntity>.DescriminatorPropertyName, typeof(string));

      builder.Property(entity => entity.Id).ToJsonProperty("id").HasValueGenerator<GuidValueGenerator>();
      builder.Property(entity => entity.TodoListId).ToJsonProperty("todoListId").HasValueGenerator<PartitionKeyValueGenerator>();
    }
  }
}
