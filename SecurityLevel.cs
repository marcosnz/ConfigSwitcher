namespace ConfigSwitcher
{
    public enum SecurityLevel
    {
        /// <summary>Developer level.</summary>
        Dev,

        /// <summary>UAT level.</summary>
        Uat,

        /// <summary>Production level.</summary>
        Prod,

        /// <summary>Known but ignoring.</summary>
        Ignore,
    }
}