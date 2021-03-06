﻿namespace Raven.Documentation.Samples.Server.Troubleshooting
{
	public class EnablingLogging
	{
		/*
		#region enabling_logging_1
		<nlog xmlns="http://www.nlog-project.org/schemas/NLog.netfx35.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
			<targets>
				<target 
					xsi:type="AsyncWrapper"
					name="AsyncLog">

					<target xsi:type="SplitGroup">
						<!-- create log files with a max size of 256 MB -->
						<target 
							name="File" 
							xsi:type="File"    
							archiveAboveSize="268435456"
							fileName="${basedir}\Logs\${shortdate}.log">
							<layout xsi:type="CsvLayout">
								<column name="time" layout="${longdate}" />
								<column name="logger" layout="${logger}"/>
								<column name="level" layout="${level}"/>
								<column name="database" layout="${mdc:item=database}"/>
								<column name="threadid" layout="${threadid}" />
								<column name="message" layout="${message}" />
								<column name="exception" layout="${exception:format=tostring}" />
							</layout>
						</target>
					</target>
				</target>
			</targets>
			<rules>
				<!-- supported levels: Off, Fatal, Error, Warn, Info, Debug, Trace -->
   				<logger name="Raven.*" writeTo="AsyncLog" minlevel="Debug" />
   				<logger name="*Rachis*" writeTo="AsyncLog" minlevel="Debug" />
			</rules>
		</nlog>
		#endregion
		*/
	}
}