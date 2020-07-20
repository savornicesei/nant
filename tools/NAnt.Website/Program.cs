using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Wyam.CodeAnalysis;
using Wyam.Common.Execution;
using Wyam.Common.IO;
using Wyam.Common.Meta;
using Wyam.Core.Execution;
using Wyam.Core.Modules.Extensibility;
using Wyam.Docs;
using Trace = Wyam.Common.Tracing.Trace;

namespace NAnt.Website
{
	class Program
	{
		static int Main(string[] args)
		{
			AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionEvent;
			
			Trace.AddListener(new System.Diagnostics.TextWriterTraceListener(Console.Out));
			Program program = new Program();
			return program.Run(args);
		}

		private int Run(string[] args)
		{
			int result = 0;
			
			// Output version info
			Trace.Information($"Wyam version {Engine.Version}");
			
			//find tools folder absolute path
			Assembly current = Assembly.GetExecutingAssembly();
			DirectoryInfo currentDir = Directory.GetParent(current.Location);
			while (currentDir!= null && currentDir.Exists && currentDir.Name != "tools")
			{
				currentDir = currentDir.Parent;
			}

			if (currentDir == null || currentDir.Parent == null)
			{
				Trace.Information($"Could not find folder called 'tools' or its parent. Exiting....");
				return -2;
			}

			currentDir = new DirectoryInfo(Path.Combine(currentDir.Parent.FullName, "website"));
			Directory.SetCurrentDirectory(currentDir.FullName);

			try
			{
				var engine = new Engine();

				engine.Namespaces.Add("Wyam.Docs"); // or razor will complain
				engine.Namespaces.Add("Wyam.Html");
				engine.Namespaces.Add("Wyam.Yaml");
				engine.Namespaces.Add("Wyam.Razor");
				engine.Namespaces.Add("Wyam.Markdown");
				engine.Namespaces.Add("Wyam.CodeAnalysis");
				
				engine.FileSystem.InputPaths.Add(new DirectoryPath(Path.Combine(currentDir.FullName, "input")));
				engine.FileSystem.OutputPath = new DirectoryPath(Path.Combine(currentDir.FullName, "output"));
				
				var dr = new Docs();
				dr.Apply(engine);
				
				engine.Pipelines.InsertBefore(Docs.RenderPages, "References",
					new Execute(ctx =>
                         new AnalyzeCSharp()
                        .WithProjects(ctx.List<string>(DocsKeys.ProjectFiles))
                        .WherePublic()
                        .WhereNamespaces(n => n.EndsWith("Task") || n.EndsWith("Functions") || n.EndsWith("Types"))
                        .WhereSymbol(s => IsNantReference(s))
                        .WithDocsForImplicitSymbols()
                        .WithWritePath(x => {
	                        string name = x.String("DisplayName").ToLower();
	                        if(name == "index")
	                        {
		                        name = "indx";  // Special case for the Index module
	                        }
                
	                        // Remove generic types
	                        int genericParamsIndex = name.IndexOf("<");
	                        if(genericParamsIndex != -1)
	                        {
		                        name = name.Substring(0, genericParamsIndex);
	                        }
                
	                        return new FilePath($"references/{name}.html");
                        })
                    )
					); 
				
				engine.Execute();
			}
			catch (Exception ex)
			{
				Trace.Error(ex.ToString());
				result = -1;
			}

			return result;
		}

		private bool IsNantReference(ISymbol symbol)
		{
			if (symbol == null)
				return false;

			var attributes = symbol.GetAttributes();

			return attributes.Any(a => a.AttributeClass.Name == "TaskNameAttribute"
			                           || a.AttributeClass.Name == "FunctionAttribute"
			                           || a.AttributeClass.Name == "TaskAttributeAttribute");
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
			Environment.Exit(-1);
		}
	}
}