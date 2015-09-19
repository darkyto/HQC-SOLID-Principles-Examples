namespace HQC_Solid_and_other_Principles.DependencyInversion.Worker
{
    using System;
    using HQC_Solid_and_other_Principles.DependencyInversion.Worker.Contracts;

    public class HighPerformer : IWorker
    {
        public void Work()
        {
            // do the Fast work logic
        }
    }
}
