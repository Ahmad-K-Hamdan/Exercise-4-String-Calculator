# String Calculator

This repository contains an implementation of a String Calculator in C#. The calculator parses a string containing numbers, separated by various delimiters, and returns their sum. It is designed to handle edge cases such as negative numbers, empty input, and large numbers according to common coding exercise requirements.

## Features

- **Add Method**: `Add(string numbers)` accepts a string of numbers (with delimiters) and returns their sum as an integer.
- **Flexible Delimiters**: Supports commas, newlines, and custom single-character delimiters (e.g. `//;\n1;2`).
- **Negative Number Detection**: Throws an exception listing all negative numbers in the input.
- **Ignores Big Numbers**: Numbers greater than 1000 are ignored in the sum.
- **Handles Empty Strings**: Returns 0 for empty input.

## Usage

### Example Inputs

| Input                 | Output | Notes                                 |
|-----------------------|--------|---------------------------------------|
| `""`                  | `0`    | Empty string returns 0                |
| `"1"`                 | `1`    | Single number                         |
| `"1,2,3"`             | `6`    | Comma as delimiter                    |
| `"1\n2,3"`            | `6`    | Newline and comma delimiters          |
| `"//;\n1;2"`          | `3`    | Custom delimiter `;`                  |
| `"2,1001"`            | `2`    | Ignores numbers > 1000                |
| `"1,2,-3,4,-5"`       | Error  | Throws: negatives not allowed: -3, -5 |

### How to Run

1. Clone this repository:
   ```bash
   git clone https://github.com/Ahmad-K-Hamdan/Exercise-4-String-Calculator.git
   ```
2. Open the solution in Visual Studio or your C# IDE.
3. Run the project. You can interact with the `Calculator` class directly or extend the `Program.cs` to accept user input.

### How It Works

- The main method of interest is `Calculator.Add(string numbers)`.
- It parses the string, identifies numbers, handles delimiters, and performs checks for negative and big numbers.
- Negative numbers result in an exception with all negative values listed.
- All numbers greater than 1000 are excluded from the result.

## Testing

Unit tests are provided in the `String Calculator Tests/CalculatorTests.cs` file, covering all supported scenarios:
- Empty input
- Single/multiple numbers
- Various delimiters
- Negative numbers
- Large numbers

To run tests:
- Use your IDE’s test runner for .NET projects.
- Or run `dotnet test` from the command line.

## Project Structure

```
.
├── String Calculator/
│   ├── Calculator.cs      # Main calculator logic
│   └── Program.cs         # Program entry point
├── String Calculator Tests/
│   └── CalculatorTests.cs # Unit tests for the calculator
└── README.md              # Project documentation
```
