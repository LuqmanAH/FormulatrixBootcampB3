# Logging Techniques in CSharp

## Built-in Library used for logging

Consists of two error levels, can be viewed by tracelistener. outputs to console log or file based log

1. Debug
2. Trace

## Third Party Logging Libraries

Such as log4Net, NLog. Offers more error levels to be logged, such as:

| No. | Error level      | Behavior                                                         |
| --- | ---------------- | ---------------------------------------------------------------- |
| 1.  | Fatal / Critical | Logs condition that leads to program failure                     |
| 2.  | Error            | Logs conditions that lead to handled errors                      |
| 3.  | Warning          | Logs conditions that may lead unexpected program behavior        |
| 4.  | Info             | Logs the flow of the program runtime, can be released to user    |
| 5.  | Debug            | Logs the flow of the program runtime for debugging process       |
| 6.  | Trace            | Similar to the info level, but exhaustively used for development |
| 7   | Off              | Disable logger record when of a condition                        |

May be released as console file, database, or even SMTP
