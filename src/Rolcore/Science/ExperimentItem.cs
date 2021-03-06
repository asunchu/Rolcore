﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rolcore.Science
{
    /// <summary>
    /// Base class for an item that is part of an <see cref="Experiment"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ExperimentItem<T>
    {
        private readonly T _Item;

        public ExperimentItem(T item)
        {
            this._Item = item;
        }

        public T Item
        {
            get { return this._Item; }
        }
    }
}
