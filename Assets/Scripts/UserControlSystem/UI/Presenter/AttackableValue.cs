﻿using System;
using UnityEngine;

namespace UserControlSystem
{
    [CreateAssetMenu(fileName = nameof(AttackableValue), menuName = "Strategy Game/" + nameof(AttackableValue), order = 0)]
    public sealed class AttackableValue : ScriptableObject
    {
        public IAttackable CurrentValue { get; private set; }
        public Action<IAttackable> OnNewValue;

        public void SetValue(IAttackable value)
        {
            CurrentValue = value;
            OnNewValue?.Invoke(value);
        }
    }
}