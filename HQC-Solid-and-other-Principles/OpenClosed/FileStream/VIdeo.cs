namespace HQC_Solid_and_other_Principles.OpenClosed.FileStream
{
    using System;
    using HQC_Solid_and_other_Principles.OpenClosed.FileStream.Contracts;

    public class Video : IResult
    {
        public int Sent { get; set; }

        public int Length { get; set; }

        public string Content { get; set; }
    }
}