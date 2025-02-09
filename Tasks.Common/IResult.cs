﻿namespace Tasks.Common
{
    public interface IResult<T>
    {
        T Value { get; set; }
        bool Succeeded { get; set; }
    }
}
