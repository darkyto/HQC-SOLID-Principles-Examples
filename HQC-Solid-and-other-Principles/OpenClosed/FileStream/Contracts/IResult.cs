namespace HQC_Solid_and_other_Principles.OpenClosed.FileStream.Contracts
{
    using System;

    public interface IResult
    {
        int Length { get; set; }

        int Sent { get; set; }
    }
}
