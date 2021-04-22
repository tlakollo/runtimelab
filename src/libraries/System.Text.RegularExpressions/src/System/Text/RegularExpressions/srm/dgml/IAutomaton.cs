﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace System.Text.RegularExpressions.SRM.DGML
{
    /// <summary>
    /// For accessing the key components of an automaton.
    /// </summary>
    /// <typeparam name="L">type of labels in moves</typeparam>
    internal interface IAutomaton<L>
    {
        /// <summary>
        /// Enumerates all moves of the automaton.
        /// </summary>
        IEnumerable<Move<L>> GetMoves();

        /// <summary>
        /// Enumerates all states of the automaton.
        /// </summary>
        IEnumerable<int> GetStates();

        /// <summary>
        /// Provides a description of the state for visualization purposes.
        /// </summary>
        string DescribeState(int state);

        /// <summary>
        /// Provides a description of the label for visualization purposes.
        /// </summary>
        string DescribeLabel(L lab);

        /// <summary>
        /// Provides a description of the start label for visualization purposes.
        /// </summary>
        string DescribeStartLabel();

        /// <summary>
        /// The initial state of the automaton.
        /// </summary>
        int InitialState { get; }

        /// <summary>
        /// The number of states of the automaton.
        /// </summary>
        int StateCount { get; }

        /// <summary>
        /// Returns true iff the state is a final state.
        /// </summary>
        bool IsFinalState(int state);
    }

}
