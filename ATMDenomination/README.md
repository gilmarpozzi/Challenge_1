# ATM Denomination Calculator

This C# console application calculates possible combinations of banknotes for ATM withdrawals using different denominations (10 EUR, 50 EUR, and 100 EUR).

## Problem Description

The ATM has three cartridges for different denominations:
- 10 EUR cartridge
- 50 EUR cartridge
- 100 EUR cartridge

The program calculates possible combinations for the following amounts:
- 30 EUR
- 50 EUR
- 60 EUR
- 80 EUR
- 140 EUR
- 230 EUR
- 370 EUR
- 610 EUR
- 980 EUR

## Requirements

- .NET 9.0 SDK
- Docker (optional, for containerized execution)

## Running the Application

### Using .NET CLI

1. Build the application:
```bash
dotnet build
```

2. Run the application:
```bash
dotnet run
```

### Using Docker

1. Build the Docker image:
```bash
docker build -t atm-denomination .
```

2. Run the container:
```bash
docker run atm-denomination
```

## Example Output

For an amount of 100 EUR, the program will show all possible combinations:
- 10 x 10 EUR
- 1 x 50 EUR + 5 x 10 EUR
- 2 x 50 EUR
- 1 x 100 EUR

## Implementation Details

The solution uses a recursive approach to find all possible combinations of banknotes. The algorithm:
1. Takes a target amount and available denominations as input
2. Recursively builds combinations by trying each denomination
3. Groups and formats the results for clear presentation

## Project Structure

- `Program.cs` - Main application code
- `Dockerfile` - Docker configuration
- `ATMDenomination.csproj` - Project configuration
- `README.md` - This documentation file 