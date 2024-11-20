﻿namespace A3S.Core.ConfigOptions
{
    public class JwtTokenSettings
    {
        public string Key {  get; set; }
        public string Issuer { get; set; }
        public int ExpireInMinutes { get; set; }
    }
}