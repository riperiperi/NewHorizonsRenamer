﻿using System;
using System.Collections.Generic;

namespace NHSE.Core
{
    /// <summary>
    /// Key Value pair for a displayed <see cref="T:System.String" /> and underlying <see cref="T:System.Int32" /> value.
    /// </summary>
    public readonly struct ComboItem : IEquatable<int>
    {
        public string Text { get; }
        public int Value { get; }

        public ComboItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public bool Equals(ComboItem other) => Value == other.Value && string.Equals(Text, other.Text);
        public bool Equals(int other) => Value == other;
        public override bool Equals(object obj) => obj is ComboItem other && Equals(other);
        public override int GetHashCode() => Value;
        public static bool operator ==(ComboItem left, ComboItem right) => left.Equals(right);
        public static bool operator !=(ComboItem left, ComboItem right) => !(left == right);
    }

    public static class ComboItemUtil
    {
        public static List<ComboItem> GetArray(string[] items)
        {
            var result = new List<ComboItem>(items.Length / 2);
            for (int i = 0; i < items.Length; i++)
            {
                var text = items[i];
                if (text.Length == 0)
                    continue;
                var item = new ComboItem(text, i);
                result.Add(item);
            }

            return result;
        }

        public static List<ComboItem> GetArray<T>(Type t) where T : struct, IFormattable
        {
            var names = Enum.GetNames(t);
            var values = (T[])Enum.GetValues(t);

            var acres = new List<ComboItem>(names.Length);
            for (int i = 0; i < names.Length; i++)
                acres.Add(new ComboItem($"{names[i]} - {values[i]:X}", (ushort)(object)values[i]));
            acres.SortByText();
            return acres;
        }

        public static List<ComboItem> GetArray(IReadOnlyList<ushort> values, string[] names)
        {
            var result = new List<ComboItem>(values.Count);
            foreach (var value in values)
            {
                var text = names[value];
                var item = new ComboItem(text, value);
                result.Add(item);
            }

            return result;
        }

        public static void Add(this List<ComboItem> storage, IReadOnlyList<INamedValue> tuples, Dictionary<string, string> translate)
        {
            int initial = storage.Count;
            storage.Capacity = storage.Count + tuples.Count;
            foreach (var kvp in tuples)
            {
                var translated = translate.TryGetValue(kvp.Name, out var t) ? t : kvp.Name;
                var item = new ComboItem(translated, kvp.Index);
                storage.Add(item);
            }
            storage.Sort(initial, storage.Count - initial, Comparer);
        }

        public static void SortByText(this List<ComboItem> arr) => arr.Sort(Comparer);

        private static readonly FunctorComparer<ComboItem> Comparer =
            new FunctorComparer<ComboItem>((a, b) => string.CompareOrdinal(a.Text, b.Text));

        private sealed class FunctorComparer<T> : IComparer<T>
        {
            private readonly Comparison<T> Comparison;
            public FunctorComparer(Comparison<T> comparison) => Comparison = comparison;
            public int Compare(T x, T y) => Comparison(x, y);
        }
    }
}
