﻿using System;

namespace StateMachinesLab.DecisionTrees.WithActions.Recursive
{
    /// <include file = 'docs/StatesLab.xml' path='doc/DecisionTree/Recursive/DecisionTree/class'/>
    public class DTNode<TData> : ITransition<TData, int>
    {
        private readonly Func<TData, bool> _condition;
        private readonly ITransition<TData, int> _onTrue, _onFalse;

        /// <include file = 'docs/StatesLab.xml' path='doc/DecisionTree/Recursive/DecisionTree/ctor'/>
        public DTNode(Func<TData, bool> condition, ITransition<TData, int> onTrue, ITransition<TData, int> onFalse)
        {
            _condition = condition;
            _onTrue = onTrue;
            _onFalse = onFalse;
        }

        /// <include file = 'docs/StatesLab.xml' path='doc/DecisionTree/Recursive/DecisionTree/Evaluate'/>
        public int Evaluate(TData data)
            => (_condition(data)) ? _onTrue.Evaluate(data) : _onFalse.Evaluate(data);
    }
}