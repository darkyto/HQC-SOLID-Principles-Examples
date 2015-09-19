namespace HQC_Solid_and_other_Principles.DependencyInversion.Worker
{
    using System;
    using HQC_Solid_and_other_Principles.DependencyInversion.Worker.Contracts;

    public class Manager
    {
        private IWorker worker;

        public Manager(IWorker worker) 
        {
            this.worker = worker;
        }

        public void Manage()
        {
            this.worker.Work();
        }
    }
}
