﻿using KristofferStrube.Blazor.MediaCaptureStreams.UnionTypes;
using System.Text.Json.Serialization;

namespace KristofferStrube.Blazor.MediaCaptureStreams;

[JsonConverter(typeof(UnionTypeJsonConverter<ConstrainDouble>))]
public class ConstrainDouble : UnionType
{
    public ConstrainDouble(double value) : base(value) { }
    public ConstrainDouble(ConstrainDoubleRange value) : base(value) { }
    internal ConstrainDouble(object value) : base(value) { }

    public static implicit operator ConstrainDouble(double value)
    {
        return new(value);
    }

    public static implicit operator ConstrainDouble(ConstrainDoubleRange value)
    {
        return new(value);
    }
}
