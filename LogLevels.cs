using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        var subStrings = logLine.Split(':', StringSplitOptions.TrimEntries);
        var message = subStrings.GetValue(1);
        return message.ToString();
    }

    public static string LogLevel(string logLine)
    {
        var subStrings = logLine.Split('[', ']');
        var logLevel = subStrings.GetValue(1);
        return logLevel.ToString().ToLower();
    }

    public static string Reformat(string logLine)
    {
        char[] separators = { '[', ']', ':' };
        var subStrings = logLine.Split(separators, StringSplitOptions.TrimEntries);
        subStrings.SetValue("(",0);
        subStrings.SetValue(")",2);

        var reformatLogLine = subStrings.GetValue(3) + " " +
                              subStrings.GetValue(0) +
                              subStrings.GetValue(1).ToString().ToLower() +
                              subStrings.GetValue(2);
        return reformatLogLine;
    }
}
