using CommandLine;
using Tia2Ax.Services;
using System;
using Tia2Ax.Utils;

namespace tia2ax
{
    public static class TiaOpeness
    {
        public static bool CheckPrerequisities()
        {
            try
            {
                if (!ApiResolver.IsOpennessInstalled())
                {
                    throw new Exception(
                        $"The TIA Portal Openness version required {ApiResolver.StrRequiredVersion}{Environment.NewLine} is not installed.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            try
            {
                if (!ApiResolver.IsTiaInstalled())
                {
                    throw new Exception(
                        $"The TIA Portal version required {ApiResolver.StrRequiredVersion}{Environment.NewLine} is not installed.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return true;
        }
    }
 }






