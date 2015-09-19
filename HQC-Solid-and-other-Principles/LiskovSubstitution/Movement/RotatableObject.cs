namespace HQC_Solid_and_other_Principles.LiskovSubstitution.Movement
{
    using System;
    using HQC_Solid_and_other_Principles.LiskovSubstitution.Movement.Controls;

    public abstract class RotatableObject : IRotatable
    {
        public abstract void Rotate();

        public virtual void Move()
        {
            this.Rotate();
        }
    }
}
