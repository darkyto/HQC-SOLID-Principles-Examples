namespace HQC_Solid_and_other_Principles.OpenClosed.FileStream
{
    using System;
    using HQC_Solid_and_other_Principles.OpenClosed.FileStream.Contracts;

    public class Music : IResult
    {
        public int Sent { get; set; }

        public int Length { get; set; }

        public string Artist { get; set; }

        public string Audio { get; set; }
    }
}