﻿using CommandLine;
using Tia2Ax.Services;
using System;
using System.Resources;
using Tia2Ax.Utils;
using System.Reflection;

namespace tia2ax
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Parser.Default.ParseArguments<Options>(args)
            .WithParsed(o =>
            {
                var recoverCurrentDirectory = Environment.CurrentDirectory;
                try
                {
                    GoAhead(o);
                    Console.WriteLine("Done.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                finally
                {
                    Environment.CurrentDirectory = recoverCurrentDirectory;
                }
            });

            
        }

        private static void GoAhead(Options options)
        {
            if (TiaOpeness.CheckPrerequisities())
            {
                var traceWriter = new Tia2Ax.Interfaces.TraceWriter();
                var apiWrapper = new Tia2Ax.Interfaces.ApiWrapper(traceWriter);

                var creator = new Tia2AxServices(traceWriter, apiWrapper);
                creator.OpenProject(options.TiaSourceProject);
                creator.GetPlcList(options.OutputProjectFolder, options.IO, options.HwId);
            }
        }

    }


    internal class Options 
    {
        [Option('x', "tia-source-project", Required = true, HelpText = "TIA portal source project")]
        public string TiaSourceProject { get; set; }

        [Option('o', "output-folder", Required = true,
            HelpText = "Output project folder where generator emits result.")]
        public string OutputProjectFolder { get; set; }

        [Option('i', "io", Required = false, HelpText = "Export IO addresses")]
        public bool IO { get; set; }

        [Option('h', "hwid", Required = false, HelpText = "Export hardware identifiers")]
        public bool HwId { get; set; }


    }
}






