﻿using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{

    [JsType(Name = "System.Collections.Generic.IEnumerator$1", Filename = "~/Internal/Core.js")]
    public interface JsImplIEnumerator<T>
    {
        /// <summary>Gets the element in the collection at the current position of the enumerator.</summary>
        /// <returns>The element in the collection at the current position of the enumerator.</returns>
        T Current
        {
            get;
        }
    }

    [JsType(Name = "System.Collections.Generic.IEnumerable$1", Filename = "~/Internal/Core.js")]
    public interface JsImplIEnumerable<T> : JsImplIEnumerable
    {
        /// <summary>Returns an enumerator that iterates through the collection.</summary>
        /// <returns>A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.</returns>
        /// <filterpriority>1</filterpriority>
        JsImplIEnumerator<T> GetEnumerator();
    }

    [JsType(Name = "System.Collections.Generic.IList$1", Filename = "~/Internal/Core.js")]
    internal interface JsImplIList<T> : JsImplICollection<T>
    {
    }

    [JsType(Name = "System.Collections.Generic.ICollection$1", Filename = "~/Internal/Core.js")]
    internal interface JsImplICollection<T> : JsImplIEnumerable<T>
    {
        /// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1" />.</summary>
        /// <returns>The number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1" />.</returns>
        int Count
        {
            get;
        }
        /// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only.</summary>
        /// <returns>true if the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only; otherwise, false.</returns>
        bool IsReadOnly
        {
            get;
        }
        /// <summary>Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1" />.</summary>
        /// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only.</exception>
        void Add(T item);
        /// <summary>Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1" />.</summary>
        /// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only. </exception>
        void Clear();
        /// <summary>Determines whether the <see cref="T:System.Collections.Generic.ICollection`1" /> contains a specific value.</summary>
        /// <returns>true if <paramref name="item" /> is found in the <see cref="T:System.Collections.Generic.ICollection`1" />; otherwise, false.</returns>
        /// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        bool Contains(T item);
        /// <summary>Copies the elements of the <see cref="T:System.Collections.Generic.ICollection`1" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
        /// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Generic.ICollection`1" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
        /// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="array" /> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="arrayIndex" /> is less than 0.</exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="array" /> is multidimensional.-or-The number of elements in the source <see cref="T:System.Collections.Generic.ICollection`1" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />.-or-Type <paramref name="T" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
        void CopyTo(T[] array, int arrayIndex);
        /// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.Generic.ICollection`1" />.</summary>
        /// <returns>true if <paramref name="item" /> was successfully removed from the <see cref="T:System.Collections.Generic.ICollection`1" />; otherwise, false. This method also returns false if <paramref name="item" /> is not found in the original <see cref="T:System.Collections.Generic.ICollection`1" />.</returns>
        /// <param name="item">The object to remove from the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only.</exception>
        bool Remove(T item);
    }

    [JsType(Name = "System.Collections.Generic.IDictionary$2", Filename = "~/Internal/Core.js")]
    internal interface JsImplIDictionary<K, T>
    {
    }

    /// <summary>Provides the base interface for the abstraction of sets.</summary>
    /// <typeparam name="T">The type of elements in the set.</typeparam>
    [JsType(Name = "System.Collections.Generic.ISet$1", Filename = "~/Internal/Core.js")]
    internal interface JsImplISet<T> : JsImplICollection<T>, JsImplIEnumerable<T>, JsImplIEnumerable
    {
        /// <summary>Adds an element to the current set and returns a value to indicate if the element was successfully added. </summary>
        /// <returns>true if the element is added to the set; false if the element is already in the set.</returns>
        /// <param name="item">The element to add to the set.</param>
        bool Add(T item);
        /// <summary>Modifies the current set so that it contains all elements that are present in both the current set and in the specified collection.</summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="other" /> is null.</exception>
        void UnionWith(JsImplIEnumerable<T> other);
        /// <summary>Modifies the current set so that it contains only elements that are also in a specified collection.</summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="other" /> is null.</exception>
        void IntersectWith(JsImplIEnumerable<T> other);
        /// <summary>Removes all elements in the specified collection from the current set.</summary>
        /// <param name="other">The collection of items to remove from the set.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="other" /> is null.</exception>
        void ExceptWith(JsImplIEnumerable<T> other);
        /// <summary>Modifies the current set so that it contains only elements that are present either in the current set or in the specified collection, but not both. </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="other" /> is null.</exception>
        void SymmetricExceptWith(JsImplIEnumerable<T> other);
        /// <summary>Determines whether a set is a subset of a specified collection.</summary>
        /// <returns>true if the current set is a subset of <paramref name="other" />; otherwise, false.</returns>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="other" /> is null.</exception>
        bool IsSubsetOf(JsImplIEnumerable<T> other);
        /// <summary>Determines whether the current set is a superset of a specified collection.</summary>
        /// <returns>true if the current set is a superset of <paramref name="other" />; otherwise, false.</returns>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="other" /> is null.</exception>
        bool IsSupersetOf(JsImplIEnumerable<T> other);
        /// <summary>Determines whether the current set is a correct superset of a specified collection.</summary>
        /// <returns>true if the <see cref="T:System.Collections.Generic.ISet`1" /> object is a correct superset of <paramref name="other" />; otherwise, false.</returns>
        /// <param name="other">The collection to compare to the current set. </param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="other" /> is null.</exception>
        bool IsProperSupersetOf(JsImplIEnumerable<T> other);
        /// <summary>Determines whether the current set is a property (strict) subset of a specified collection.</summary>
        /// <returns>true if the current set is a correct subset of <paramref name="other" />; otherwise, false.</returns>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="other" /> is null.</exception>
        bool IsProperSubsetOf(JsImplIEnumerable<T> other);
        /// <summary>Determines whether the current set overlaps with the specified collection.</summary>
        /// <returns>true if the current set and <paramref name="other" /> share at least one common element; otherwise, false.</returns>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="other" /> is null.</exception>
        bool Overlaps(JsImplIEnumerable<T> other);
        /// <summary>Determines whether the current set and the specified collection contain the same elements.</summary>
        /// <returns>true if the current set is equal to <paramref name="other" />; otherwise, false.</returns>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="other" /> is null.</exception>
        bool SetEquals(JsImplIEnumerable<T> other);
    }


}