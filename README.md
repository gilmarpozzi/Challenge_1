# ATM Denomination Calculator

This is a C# console application that calculates possible combinations of banknotes for ATM withdrawals using different denominations (10 EUR, 50 EUR, and 100 EUR).

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

- .NET 7.0 SDK
- Docker (optional, for containerized execution)

## Project Structure

The project is organized into two main parts:

### Main Project (ATMDenomination)
- `Program.cs` - Contains the main class with the application entry point
- `ATMDenominationCalculator.cs` - Contains the business logic for calculating combinations

### Test Project (ATMDenomination.Tests)
- `ATMDenominationTests.cs` - Contains unit tests to validate the calculator logic

## Running the Project

### Using .NET CLI

1. Restore dependencies:
```bash
dotnet restore
```

2. Build the project:
```bash
dotnet build
```

3. Run the application:
```bash
dotnet run --project ATMDenomination
```

4. Run the tests:
```bash
dotnet test
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

## Unit Tests

The project includes comprehensive unit tests that verify:

1. Correct number of combinations for different amounts
2. Validation of returned combinations
3. Handling of special cases (zero amount)
4. Handling of impossible amounts

To run the tests:
```bash
dotnet test
```

## Implementation Details

The solution uses a recursive approach to find all possible combinations of banknotes. The algorithm:
1. Takes a target amount and available denominations as input
2. Recursively builds combinations by trying each denomination
3. Groups and formats the results for clear presentation

### Main Classes

#### ATMDenominationCalculator
- Responsible for the combination calculation logic
- Main method: `FindCombinations(int target, int[] denominations)`
- Implements the recursive algorithm to find all possible combinations

#### Program
- Application entry point
- Responsible for user interface and result presentation
- Uses ATMDenominationCalculator to perform calculations

## Contributing

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request 