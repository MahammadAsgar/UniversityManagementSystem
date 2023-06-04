﻿using System.Text.Json.Serialization;

namespace SharedLibrary
{
    public class Response<T> where T : class
    {
        public T Data { get; private set; }
        public string Message { get; private set; }
        public bool IsSuccessful { get; private set; }

        public static Response<T> Success(T data, string message)
        {
            return new Response<T> { Data = data, Message = message, IsSuccessful = true };
        }

        public static Response<T> Success(string message)
        {
            return new Response<T> { Data = default, Message = message, IsSuccessful = true };
        }

        public static Response<T> Success(T data)
        {
            return new Response<T> { Data = data, IsSuccessful = true };
        }

        public static Response<IEnumerable<T>> Success(IEnumerable<T> data)
        {
            return new Response<IEnumerable<T>> { Data = data, IsSuccessful = true };
        }

        public static Response<IEnumerable<T>> Success(IEnumerable<T> data, string message)
        {
            return new Response<IEnumerable<T>> { Data = data, Message = message, IsSuccessful = true };
        }



        public static Response<T> Fail(string message)
        {
            return new Response<T> { Message = message, IsSuccessful = false };
        }
    }
}
