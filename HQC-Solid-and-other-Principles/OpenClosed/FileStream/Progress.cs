namespace HQC_Solid_and_other_Principles.OpenClosed.FileStream
{
    using System;
    using HQC_Solid_and_other_Principles.OpenClosed.FileStream.Contracts;

    public class Progress
    {
        private IResult result;

        public Progress(IResult result)
        {
            this.result = result;
        }

        public int GetCurrentPercent()
        {
            return this.result.Sent / this.result.Length;
        }
    }
}
