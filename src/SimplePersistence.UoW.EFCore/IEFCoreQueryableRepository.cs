#region License
// The MIT License (MIT)
// 
// Copyright (c) 2016 SimplePersistence
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion
namespace SimplePersistence.UoW.EFCore
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Specialized interface of an <see cref="IQueryableRepository{TEntity,TId}"/> 
    /// for the Entity Framework Core.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TKey">The entity id type</typeparam>
    public interface IEFCoreQueryableRepository<TEntity, in TKey>
        : IQueryableRepository<TEntity, TKey>
        where TEntity : class
    {
        /// <summary>
        /// The Entity Framework database context
        /// </summary>
        DbContext Context { get; }

        /// <summary>
        /// The <see cref="DbSet{TEntity}"/> of this repository entity
        /// </summary>
        DbSet<TEntity> Set { get; }
    }

    /// <summary>
    /// Specialized interface of an <see cref="IQueryableRepository{TEntity,TId01,TId02}"/> 
    /// for the Entity Framework Core.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TKey01">The entity id first type</typeparam>
    /// <typeparam name="TKey02">The entity id second type</typeparam>
    public interface IEFCoreQueryableRepository<TEntity, in TKey01, in TKey02>
        : IQueryableRepository<TEntity, TKey01, TKey02>
        where TEntity : class
    {
        /// <summary>
        /// The Entity Framework database context
        /// </summary>
        DbContext Context { get; }

        /// <summary>
        /// The <see cref="DbSet{TEntity}"/> of this repository entity
        /// </summary>
        DbSet<TEntity> Set { get; }
    }

    /// <summary>
    /// Specialized interface of an <see cref="IQueryableRepository{TEntity,TId01,TId02,TId03}"/> 
    /// for the Entity Framework Core.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TKey01">The entity id first type</typeparam>
    /// <typeparam name="TKey02">The entity id second type</typeparam>
    /// <typeparam name="TKey03">The entity id third type</typeparam>
    public interface IEFCoreQueryableRepository<TEntity, in TKey01, in TKey02, in TKey03>
        : IQueryableRepository<TEntity, TKey01, TKey02, TKey03>
        where TEntity : class
    {
        /// <summary>
        /// The Entity Framework database context
        /// </summary>
        DbContext Context { get; }

        /// <summary>
        /// The <see cref="DbSet{TEntity}"/> of this repository entity
        /// </summary>
        DbSet<TEntity> Set { get; }
    }

    /// <summary>
    /// Specialized interface of an <see cref="IQueryableRepository{TEntity,TId01,TId02,TId03,TId04}"/> 
    /// for the Entity Framework Core.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TKey01">The entity id first type</typeparam>
    /// <typeparam name="TKey02">The entity id second type</typeparam>
    /// <typeparam name="TKey03">The entity id third type</typeparam>
    /// <typeparam name="TKey04">The entity id fourth type</typeparam>
    public interface IEFCoreQueryableRepository<TEntity, in TKey01, in TKey02, in TKey03, in TKey04>
        : IQueryableRepository<TEntity, TKey01, TKey02, TKey03, TKey04>
        where TEntity : class
    {
        /// <summary>
        /// The Entity Framework database context
        /// </summary>
        DbContext Context { get; }

        /// <summary>
        /// The <see cref="DbSet{TEntity}"/> of this repository entity
        /// </summary>
        DbSet<TEntity> Set { get; }
    }

    /// <summary>
    /// Specialized interface of an <see cref="IQueryableRepository{TEntity}"/> 
    /// for the Entity Framework Core.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    public interface IEFCoreQueryableRepository<TEntity> : IQueryableRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// The Entity Framework database context
        /// </summary>
        DbContext Context { get; }

        /// <summary>
        /// The <see cref="DbSet{TEntity}"/> of this repository entity
        /// </summary>
        DbSet<TEntity> Set { get; }
    }
}
