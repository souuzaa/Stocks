---
languages:
- csharp
products:
- dotnet
- dotnet-orleans
page_type: sample
name: "Orleans Stocks sample app"
urlFragment: "orleans-stocks-sample-app"
description: "An Orleans sample app demonstrating real-time Stocks."
---

# Orleans Stocks sample app

This application fetches stock prices from a remote orleans cluster service, caches them in a grain, and displays them on screen.

## Demonstrates

* How to use Orleans from within a [`BackgroundService`](https://docs.microsoft.com/aspnet/core/fundamentals/host/hosted-services#backgroundservice-base-class).
* How to use timers within a grain

A [`BackgroundService`](https://docs.microsoft.com/aspnet/core/fundamentals/host/hosted-services#backgroundservice-base-class) periodically create the stock price for a variety of stocks from corresponding `StockGrain` instances.
Each `StockGrain` is identified by its stock ticker symbol, for example, the string `"MSFT"`.

For the sample to display all of the stocks listed: "MSFT", "GOOG", "AAPL", "GME", "AMZN".

Use k6sample.js script to run API tests.

## Sample prerequisites

This sample is written in C# and targets .NET 8.0. It requires the [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later.

## Building the sample

To download and run the sample, follow these steps:

1. Download and unzip the sample.
2. In Visual Studio (2022 or later):
    1. On the menu bar, choose **File** > **Open** > **Project/Solution**.
    2. Navigate to the folder that holds the unzipped sample code, and open the C# project (.csproj) file.
    3. Choose the <kbd>F5</kbd> key to run with debugging, or <kbd>Ctrl</kbd>+<kbd>F5</kbd> keys to run the project without debugging.
3. From the command line:
   1. Navigate to the folder that holds the unzipped sample code.
   2. At the command line, type [`dotnet run`](https://docs.microsoft.com/dotnet/core/tools/dotnet-run).
