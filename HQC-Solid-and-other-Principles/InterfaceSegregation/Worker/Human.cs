namespace HQC_Solid_and_other_Principles.InterfaceSegregation.Worker
{
    using System;
    using HQC_Solid_and_other_Principles.InterfaceSegregation.Worker.Contracts;

    public class Human : IWorker, ISleeper, IEater
    {
        public void Work()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
