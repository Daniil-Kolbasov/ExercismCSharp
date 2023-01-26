# Log Levels

In this exercise you'll be processing log-lines.

Each log line is a string formatted as follows: **` "[<LEVEL>]: <MESSAGE>" `**

There are three different log levels:

- **` INFO `**
- **` WARNING `**
- **` ERROR `**

You have three tasks, each of which will take a log line and ask you to do something with it.

## 1. Get message from a log line

Implement the (*static*) ` LogLine.Message() ` method to return a log line's message:

```C#
LogLine.Message("[ERROR]: Invalid operation")
// => "Invalid operation"
```

Any leading or trailing white space should be removed:

```c#
LogLine.Message("[WARNING]:  Disk almost full\r\n")
// => "Disk almost full"
```

## 2. Get log level from a log line

Implement the (*static*) ` LogLine.Message() ` method to return a log line's log level, which should be returned in lowercase:

```c#
LogLine.LogLevel("[ERROR]: Invalid operation")
// => "error"
```

## 3. Reformat a log line

Implement the (*static*) ` LogLine.Message() ` method that reformats the log line, putting the message first and the log level after it in parentheses:

```c#
LogLine.Reformat("[INFO]: Operation completed")
// => "Operation completed (info)"
```

### Syllabus

Strings
