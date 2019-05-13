namespace MultiFrameworkTargets
{
    public class CompilerFlagBasedSettings
    {
#if NET20
        public string CompiledAgainst { get; } = "NET20";
#endif

#if NET472
        public string CompiledAgainst { get; } = "NET472";
#endif

#if NETSTANDARD2_0
        public string CompiledAgainst { get; } = "NETSTANDARD2_0";
#endif
    }
}
