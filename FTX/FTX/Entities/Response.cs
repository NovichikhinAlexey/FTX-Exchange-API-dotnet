﻿namespace FTX.Entities
{
    public class Response<T>
    {
        public bool Success { get; set; }
        public T Result { get; set; }
    }
}
