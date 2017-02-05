using System;

namespace TesteInjDependencias
{
    public interface ITesteA
    {
        Guid IdReferencia { get; }
    }

    public interface ITesteB
    {
        Guid IdReferencia { get; }
    }
}