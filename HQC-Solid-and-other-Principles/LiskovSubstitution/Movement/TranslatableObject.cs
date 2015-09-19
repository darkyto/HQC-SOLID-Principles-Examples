namespace HQC_Solid_and_other_Principles.LiskovSubstitution.Movement
{
    using System;
    using HQC_Solid_and_other_Principles.LiskovSubstitution.Movement.Controls;

    public abstract class TranslatableObject : ITranslatable
    {
        public abstract void Translate();

        public virtual void Move()
        {
            this.Translate();
        }
    }
}
