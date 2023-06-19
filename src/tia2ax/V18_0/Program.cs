using CommandLine;
using Tia2Ax.Services;
using System;

namespace tia2ax
{
    internal class Program
    {
        static void Main(string[] args)
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
            var traceWriter = new Tia2Ax.Interfaces.TraceWriter();
            var apiWrapper = new Tia2Ax.Interfaces.ApiWrapper(traceWriter);
            var creator = new Tia2AxServices(traceWriter, apiWrapper);
            creator.OpenProject(options.TiaSourceProject);
            creator.GetPlcList(options.OutputProjectFolder);
        }
    }

    internal class Options 
    {
        [Option('x', "tia-source-project", Required = true, HelpText = "TIA portal source project")]
        public string TiaSourceProject { get; set; }

        [Option('o', "output-folder", Required = true,
            HelpText = "Output project folder where generator emits result.")]
        public string OutputProjectFolder { get; set; }


    }
}






