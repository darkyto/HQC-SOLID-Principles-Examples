﻿namespace HQC_Solid_and_other_Principles.LiskovSubstitution.Movement.Controls
{
    using System;

    public interface IRotatable : IMovable
    {
        void Rotate();
    }
}
