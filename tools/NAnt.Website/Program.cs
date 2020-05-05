/*
 * This project is almost a copy of Wyam CLI tool.
 * Url: https://github.com/Wyamio/Wyam/tree/develop/src/clients/Wyam
 * License: MIT
 */

using System;
using Wyam;
using Wyam.Commands;
using Wyam.Tracing;
using Wyam.Common.Tracing;
using Wyam.Configuration.Preprocessing;
using Wyam.Core.Execution;

namespace NAnt.Website
{
	class Program
	{
		static int Main(string[] args)
		{
			AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionEvent;
			
			Trace.AddListener(new System.Diagnostics.TextWriterTraceListener(System.Console.Out));
			Program program = new Program();
			return program.Run(args);
			
			/*var engine = new Engine();

			engine.Namespaces.Add("Wyam.Docs"); // or razor will complain
			engine.FileSystem.InputPaths.Add(new DirectoryPath(@"C:\temp\wyam.test\content"));
			engine.FileSystem.InputPaths.Add(new DirectoryPath(@"C:\temp\wyam.test\input"));
			engine.FileSystem.OutputPath = new DirectoryPath(@"C:\temp\wyam.test\site");
			var dr = new Wyam.Docs.Docs();
			dr.Apply(engine);
			engine.Execute();*/
		}
		
		private static void UnhandledExceptionEvent(object sender, UnhandledExceptionEventArgs e)
		{
			// Exit with a error exit code
			Exception exception = e.ExceptionObject as Exception;
			if (exception != null)
			{
				Trace.Critical(exception.Message);
				Trace.Verbose(exception.ToString());
			}
			Environment.Exit((int)ExitCode.UnhandledError);
		}
		
		private int Run(string[] args)
		{
			// Add a default trace listener
			Trace.AddListener(new SimpleColorConsoleTraceListener { TraceOutputOptions = System.Diagnostics.TraceOptions.None });

			// Output version info
			Trace.Information($"Wyam version {Engine.Version}");

			// Make sure we're not running under Mono
			if (Type.GetType("Mono.Runtime") != null)
			{
				Trace.Critical("The Mono runtime is not supported. Please check the GitHub repository and issue tracker for information on .NET Core support for cross platform execution.");
				return (int)ExitCode.UnsupportedRuntime;
			}

			// Parse the command line
			Preprocessor preprocessor = new Preprocessor();
			Command command;
			try
			{
				bool hasParseArgsErrors;
				command = CommandParser.Parse(args, preprocessor, out hasParseArgsErrors);
				if (command == null)
				{
					return hasParseArgsErrors ? (int)ExitCode.CommandLineError : (int)ExitCode.Normal;
				}
			}
			catch (Exception ex)
			{
				Trace.Error("Error while parsing command line: {0}", ex.Message);
				if (Trace.Level == System.Diagnostics.SourceLevels.Verbose)
				{
					Trace.Error("Stack trace:{0}{1}", Environment.NewLine, ex.StackTrace);
				}
				return (int)ExitCode.CommandLineError;
			}

			// Run the command
			return (int)command.Run(preprocessor);
		}
	}
}