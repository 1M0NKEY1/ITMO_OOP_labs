﻿namespace Itmo.ObjectOrientedProgramming.Lab2.Prototype;

public interface IPrototype<out T>
    where T : IPrototype<T>
{
    T Clone();
}