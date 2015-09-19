namespace HQC_Solid_and_other_Principles.OpenClosed.FileStream
{
    using System;
    using HQC_Solid_and_other_Principles.OpenClosed.FileStream.Contracts;

    public class File : IResult
    {
        public string Name { get; set; }

        public int Length { get; set; }

        public int Sent { get; set; }
    }
}
